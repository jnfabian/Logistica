Imports System
Imports System.Runtime.InteropServices
Imports System.Security.Principal
Imports System.Security.Permissions

Imports System.IO

<Assembly: SecurityPermissionAttribute(SecurityAction.RequestMinimum, UnmanagedCode:=True)> 
Public Class Impersonation

    Public Shared iUsuario As String = ""
    Public Shared iClave As New Security.SecureString()
    Public Shared iPass As String
    Public Shared iDominio As String = ""
    'Public Shared iDominioSecurity As New Security.SecureString()

    '<DllImport("C:\\WINNT\\System32\\advapi32.dll")> _
    <DllImport("C:\\WINDOWS\\System32\\advapi32.dll")> _
    Public Shared Function LogonUser(ByVal lpszUsername As String, ByVal lpszDomain As String, ByVal lpszPassword As String, _
             ByVal dwLogonType As Integer, ByVal dwLogonProvider As Integer, ByRef phToken As Integer) As Boolean
    End Function

    '<DllImport("C:\\WINNT\\System32\\Kernel32.dll")> _
    <DllImport("C:\\WINDOWS\\System32\\Kernel32.dll")> _
    Public Shared Function GetLastError() As Integer
    End Function

    'Public Shared Sub Main(ByVal args() As String)
    Public Shared Sub Main()
        'The Windows NT user token.
        Dim token1 As Integer

        'Get the user token for the specified user, machine, and password using the unmanaged LogonUser method.

        'The parameters for LogonUser are the user name, computer name, password,
        'Logon type (LOGON32_LOGON_NETWORK_CLEARTEXT), Logon provider (LOGON32_PROVIDER_DEFAULT),
        'and user token.
        Dim loggedOn As Boolean = LogonUser("usrdigital", "editoraperu.msft", "cendoc@ep", 9, 0, token1)
        Console.WriteLine("LogonUser called")

        'Call GetLastError to try to determine why logon failed if it did not succeed.
        Dim ret As Integer = GetLastError()

        Console.WriteLine("LogonUser Success? " & loggedOn.ToString())
        Console.WriteLine("NT Token Value: " & token1.ToString())
        If ret <> 0 Then
            Console.WriteLine("Error code (126 == ""Specified module could not be found""): " & ret)
        End If
        'Starting impersonation here:
        Console.WriteLine("Before impersonation:")
        Dim mWI1 As WindowsIdentity = WindowsIdentity.GetCurrent()
        Console.WriteLine(mWI1.Name)
        Console.WriteLine(mWI1.Token)
        'Directory.CreateDirectory("\\sw-imgdig\d$\Digitalizacion\ProyDigital\Calidad\1841\")
        Dim token2 As IntPtr = New IntPtr(token1)

        Console.WriteLine("New identity created:")
        Dim mWI2 As WindowsIdentity = New WindowsIdentity(token2)
        Console.WriteLine(mWI2.Name)
        Console.WriteLine(mWI2.Token)

        'Impersonate the user.
        Dim mWIC As WindowsImpersonationContext = mWI2.Impersonate()

        Console.WriteLine("After impersonation:")
        Dim mWI3 As WindowsIdentity = WindowsIdentity.GetCurrent()
        Console.WriteLine(mWI3.Name)
        Console.WriteLine(mWI3.Token)

        'Revert to previous identity.
        mWIC.Undo()

        Console.WriteLine("After impersonation is reverted:")
        Dim mWI4 As WindowsIdentity = WindowsIdentity.GetCurrent()
        Console.WriteLine(mWI4.Name)
        Console.WriteLine(mWI4.Token)
    End Sub

    Public Shared Sub crearCarpeta(ByVal nombreCarpeta As String)
        Dim token As Integer
        'Dim loggedOn = LogonUser("la1juanx", "editoraperu.msft", "gmd102013", 3, 0, token)
        Dim loggedOn = LogonUser("usrdigital", "editoraperu.msft", "cendoc@ep", 9, 0, token)

        Dim wid_current As WindowsIdentity = WindowsIdentity.GetCurrent()

        Dim admin_token As IntPtr = New IntPtr(token)
        Dim wid_admin As WindowsIdentity = Nothing
        Dim wic As WindowsImpersonationContext = Nothing

        Try
            'If LogonUser("Local Admin name", "Local computer name", "pwd", 9, 0, admin_token) <> 0 Then
            If loggedOn <> 0 Then
                wid_admin = New WindowsIdentity(admin_token)
                wic = wid_admin.Impersonate()
                'System.IO.File.Copy("C:\right.bmp", "\\157.60.113.28\testnew\right.bmp", True)
                Directory.CreateDirectory(nombreCarpeta)
            Else
                'MessageBox.Show("Copy Failed")
            End If
        Catch se As System.Exception
            Dim ret As Integer = Marshal.GetLastWin32Error()
            'MessageBox.Show(ret.ToString(), "Error code: " + ret.ToString())
            'MessageBox.Show(se.Message)
        Finally
            If wic IsNot Nothing Then
                wic.Undo()
            End If
        End Try
    End Sub

    Public Shared Sub ConectarUsuario()
        Dim ousu As New Clases.C_Login
        Dim strUsuRed As String
        Dim strClaveRed As String
        Dim dominio As String
        dominio = ousu.UsuarioAutentificaRed(1).Rows(0).Item(0)
        strUsuRed = ousu.UsuarioAutentificaRed(2).Rows(0).Item(0)
        strClaveRed = ousu.UsuarioAutentificaRed(3).Rows(0).Item(0)

        iUsuario = strUsuRed
        iDominio = dominio
        iPass = strClaveRed
        For Each c As Char In strClaveRed
            iClave.AppendChar(c)
        Next

        Dim token1 As Integer
        Dim falla As String
        Dim loggedOn As Boolean = LogonUser(strUsuRed, dominio, strClaveRed, 9, 0, token1)

        Dim ret As Integer = GetLastError()

        If ret <> 0 Then
            falla = "Error code (126 == ""Specified module could not be found""): " & ret
        End If

        Dim mWI1 As WindowsIdentity = WindowsIdentity.GetCurrent()

    End Sub

End Class