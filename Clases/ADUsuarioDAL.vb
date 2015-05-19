Imports System.DirectoryServices
Public Class ADUsuarioDAL
    Private strLDAPRuta As String
    Public [Error] As String

    Public Function EstaAutentificado(ByVal strDominio As String, ByVal strUsuario As String, ByVal strContrasena As String) As Boolean
        Dim blnExito As Boolean = False
        Dim strDominioUsuario As String = strDominio & "\" & strUsuario
        Dim deEntrada As DirectoryEntry = New DirectoryEntry(strLDAPRuta, strDominioUsuario, strContrasena)
        Try
            Dim objObjecto As Object = deEntrada.NativeObject
            Dim dsBuscador As New DirectorySearcher(deEntrada)
            dsBuscador.Filter = "(SAMAccountName=" & strUsuario & ")"
            Dim srResultado As SearchResult = dsBuscador.FindOne()
            If Not srResultado Is Nothing Then
                blnExito = True
            Else
                blnExito = False
            End If
            dsBuscador.Dispose()
        Catch ex As Exception
            Me.Error = ex.Message()
        Finally
            deEntrada.Dispose()
        End Try
        Return blnExito
    End Function
    Sub New(ByVal strRuta As String)
        Me.strLDAPRuta = strRuta
    End Sub

End Class
