Imports System.Collections

Public Class AccesoArchivos
    '---------------------------------------------------------------------------------------
    ' Módulo    : mcUsuariosCuentas
    ' Fecha     : 10/05/2009 10:26
    ' Autor     : Fernando G. Doncel
    ' Finalidad : Impersonation & Acceso archivos y carpetas compartidos
    '---------------------------------------------------------------------------------------
    ' Ejemplo de uso acceso recursos red:
    '
    ' Dim oUserSystem As mcUsuariosCuentas
    ' Dim lErrorConexionRed As long
    ' Set oUserSystem = New mcUsuariosCuentas
    ' oUserSystem.Inic ArchivoINI("Login", "Dominio"), _
    '                  ArchivoINI("Login", "UsuarioNombre"), _
    '                  ArchivoINI("Login", "Clave")
    ' lErrorConexionRed = oUserSystem.RedConectar(ArchivoINI("Directorios","Ruta1"))
    ' ... 'Aquí se hace lo que se tenga que hacer
    ' oUserSystem.RedDesconectar (ArchivoINI("Directorios","Ruta1"))
    '---------------------------------------------------------------------------------------

    '---------------------------------------------------------------------------------------
    ' WNetConnection
    ' CONSTANTS
    Private Const NO_ERROR = 0
    Private Const CONNECT_LOCALDRIVE = 256
    Private Const CONNECT_REDIRECT = 128
    Private Const CONNECT_UPDATE_PROFILE = 1
    Private Const CONNECT_INTERACTIVE = 8

    Private Const RESOURCETYPE_DISK = &H1
    Private Const RESOURCETYPE_PRINT = &H2
    Private Const RESOURCETYPE_ANY = &H0
    Private Const RESOURCE_CONNECTED = &H1
    Private Const RESOURCE_REMEMBERED = &H3
    Private Const RESOURCE_GLOBALNET = &H2
    Private Const RESOURCEDISPLAYTYPE_DOMAIN = &H1
    Private Const RESOURCEDISPLAYTYPE_GENERIC = &H0
    Private Const RESOURCEDISPLAYTYPE_SERVER = &H2
    Private Const RESOURCEDISPLAYTYPE_SHARE = &H3
    Private Const RESOURCEUSAGE_CONNECTABLE = &H1
    Private Const RESOURCEUSAGE_CONTAINER = &H2
    'Error Constants:
    Private Const ERROR_ACCESS_DENIED = 5&
    Private Const ERROR_ALREADY_ASSIGNED = 85&
    Private Const ERROR_BAD_DEV_TYPE = 66&
    Private Const ERROR_BAD_DEVICE = 1200&
    Private Const ERROR_BAD_NET_NAME = 67&
    Private Const ERROR_BAD_PROFILE = 1206&
    Private Const ERROR_BAD_PROVIDER = 1204&
    Private Const ERROR_BUSY = 170&
    Private Const ERROR_CANCELLED = 1223&
    Private Const ERROR_CANNOT_OPEN_PROFILE = 1205&
    Private Const ERROR_DEVICE_ALREADY_REMEMBERED = 1202&
    Private Const ERROR_EXTENDED_ERROR = 1208&
    Private Const ERROR_INVALID_PASSWORD = 86&
    Private Const ERROR_NO_NET_OR_BAD_PATH = 1203&

    Private Dominio As String
    Private UsuarioNombre As String
    Private Clave As String

    ' CUSTOM TYPES
    Structure NETRESOURCE
        Public dwScope As Long
        Public dwType As Long
        Public dwDisplayType As Long
        Public dwUsage As Long
        Public lpLocalName As String
        Public lpRemoteName As String
        Public lpComment As String
        Public lpProvider As String
    End Structure

    ' API DECLARATIONS
    Private Declare Function WNetUseConnection Lib "mpr.dll" _
       Alias "WNetUseConnectionA" ( _
       ByVal hwndOwner As Long, _
       ByRef lpNetResource As NETRESOURCE, _
       ByVal lpUserName As String, _
       ByVal lpPassword As String, _
       ByVal dwFlags As Long, _
       ByVal lpAccessName As String, _
       ByRef lpBufferSize As Long, _
       ByRef lpResult As Long) _
       As Long

    Private Declare Function WNetCancelConnection2 Lib "mpr.dll" _
       Alias "WNetCancelConnection2A" ( _
       ByVal lpName As String, _
       ByVal dwFlags As Long, _
       ByVal fForce As Long) _
       As Long

    Private Declare Function WNetAddConnection2 Lib "mpr.dll" Alias _
          "WNetAddConnection2A" (ByVal lpNetResource As NETRESOURCE, _
          ByVal lpPassword As String, ByVal lpUserName As String, _
          ByVal dwFlags As Long) As Long
    '---------------------------------------------------------------------------------------
    ' Datos del usuario
    Private mstrUsuarioNombre As String
    Private mstrDominio As String
    Private mstrClave As String
    ' Coleccion para rutas de red
    Private mColRutas As Dictionary(Of String, Boolean)
    ' Token de Impersonation
    Private mhToken As Long
    ' Estado de Impersonation
    Private mblnImpersonationState As Boolean
    '---------------------------------------------------------------------------------------

    Public Sub New()
        mColRutas = New Dictionary(Of String, Boolean)
    End Sub

    Protected Overrides Sub Finalize()
        mColRutas = Nothing
    End Sub

    Public Function Inic(ByVal strDominio As String, ByVal strUsuarioNombre As String, ByVal strClave As String) As Boolean

        'Dim oClave As mcRijndael
        'Dim strClaveDecrypt As String

        'oClave = New mcRijndael
        Dominio = strDominio
        UsuarioNombre = strUsuarioNombre
        'strClaveDecrypt = oClave.DecryptString(strClave, "ClaveEncriptacion")
        Clave = strClave 'strClaveDecrypt

    End Function
    '---------------------------------------------------------------------------------------
    ' Acceso recursos red
    Public Function RedConectar(ByVal strRutaUNC As String) As Long

        Dim NetR As New NETRESOURCE

        NetR.dwScope = RESOURCE_GLOBALNET
        NetR.dwType = RESOURCETYPE_DISK
        NetR.dwDisplayType = RESOURCEDISPLAYTYPE_SHARE
        NetR.dwUsage = RESOURCEUSAGE_CONNECTABLE
        'NetR.lpLocalName = "X:" 'Conectar sin unidad de red
        NetR.lpRemoteName = strRutaUNC
        'NetR.lpComment = "Opcional"
        'NetR.lpProvider =

        RedConectar = WNetAddConnection2(NetR, Clave, Dominio & "\" & UsuarioNombre, _
                                     CONNECT_UPDATE_PROFILE)

        If mColRutas.ContainsKey(strRutaUNC) Then
            mColRutas(strRutaUNC) = (RedConectar = 0)
        Else
            mColRutas.Add(strRutaUNC, (RedConectar = 0))
        End If

    End Function

    Public Function RedDesconectar(ByVal strRutaUNC As String) As Long

        If mColRutas.ContainsKey(strRutaUNC) Then
            If mColRutas(strRutaUNC) Then
                RedDesconectar = WNetCancelConnection2(strRutaUNC, CONNECT_UPDATE_PROFILE, False)
                'RedDesconectar = WNetCancelConnection2(strRutaUNC, 0, False)
                mColRutas(strRutaUNC) = Not (RedDesconectar = 0)
            End If
        Else
            RedDesconectar = ERROR_BAD_NET_NAME
        End If

    End Function

    Public Function RedDesconectarTodo() As Boolean

        RedDesconectarTodo = True
        Dim Rutas As Object
        Dim i As Integer
        Rutas = mColRutas.Keys
        For i = 0 To mColRutas.Count - 1
            If mColRutas(Rutas(i)) Then
                mColRutas(Rutas(i)) = Not (WNetCancelConnection2(Rutas(i), CONNECT_UPDATE_PROFILE, False) = 0)
                RedDesconectarTodo = RedDesconectarTodo And Not (mColRutas(Rutas(i)))
            End If
        Next

    End Function

    Public Function RutaConectada(ByVal strRutaUNC As String) As Boolean

        If mColRutas.ContainsKey(strRutaUNC) Then RutaConectada = mColRutas(strRutaUNC)

    End Function
    '---------------------------------------------------------------------------------------
End Class
