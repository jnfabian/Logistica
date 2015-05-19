Imports System.Security.Principal

Imports System.Security
Imports System.IO
Imports Clases.Impersonation
Imports Clases

Public Class Frm_Login


    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        Dim strUsuRed As String
        Dim strClaveRed As String

        'Process.Start("P:\Keywords.JPG")
        'Process.Start("\\sw-DESASRV\Backup\DESARROLLO\Keywords.jpg")

        If String.IsNullOrEmpty(Me.TxtUsuario.Text) Then
            MsgBox("Ingrese Usuario", MsgBoxStyle.Exclamation, "Aviso")
            TxtUsuario.Focus()
        ElseIf String.IsNullOrEmpty(Me.TxtClave.Text) Then
            MsgBox("Ingrese Clave", MsgBoxStyle.Exclamation, "Aviso")
            TxtClave.Focus()
        ElseIf Not String.IsNullOrEmpty(Me.TxtUsuario.Text) And Not String.IsNullOrEmpty(Me.TxtClave.Text) Then
            Dim AutenticarUsuario As New Clases.C_Login
            DgvDatosUsuario.DataSource = AutenticarUsuario.Validar(Me.TxtUsuario.Text.ToString.Trim)
            If DgvDatosUsuario.Rows.Count = 1 Then
                If DgvDatosUsuario.Rows(0).Cells(1).Value = Me.TxtClave.Text.ToString.Trim Then
                    If DgvDatosUsuario.Rows(0).Cells(5).Value = "A" Or DgvDatosUsuario.Rows(0).Cells(5).Value = "P" Then
                        Frm_Principal.Text = "Usuario : " & DgvDatosUsuario.Rows(0).Cells(3).Value & " " & DgvDatosUsuario.Rows(0).Cells(4).Value & " , " & DgvDatosUsuario.Rows(0).Cells(2).Value
                        Frm_Principal.datosUsuario = Me.TxtUsuario.Text.ToString.Trim



                        Dim cParametros As New Clases.DatosConexion ' Inicializa parametros
                        Dim obj As New Clases.DatosConexion


                        'Dim ci As New Clases.Impersonation
                        'Dim arg As Array
                        'Clases.ImpersonationDemo.Main()

                        Dim impersonatedUser As WindowsImpersonationContext = Nothing
                        impersonatedUser = Clases.SafeTokenHandle.getImpersonate()

                        'Dim oADUsuarioDAL As New Clases.ADUsuarioDAL("LDAP://NOMBRESERVIDOR/DC=DOMINIO,DC=COM")
                        'If Not oADUsuarioDAL.EstaAutentificado("DOMINIO.COM", "usuario1", "pass123") = True Then
                        'Dim ousu As New Clases.C_Login

                        'strUsuRed = ousu.UsuarioAutentificaRed(2).Rows(0).Item(0)
                        'strClaveRed = ousu.UsuarioAutentificaRed(3).Rows(0).Item(0)


                        'Dim oADUsuarioDAL As New Clases.ADUsuarioDAL("LDAP://feditora/DC=editoraperu,DC=msft")

                        'If Not oADUsuarioDAL.EstaAutentificado("editoraperu.msft", strUsuRed, strClaveRed) = True Then
                        '    MsgBox("Informar al personal de Informatica", MsgBoxStyle.Information, "Error de Conectividad a la Red")
                        'End If
                        'Clases.Impersonation.ConectarUsuario()


                        'Clases.Impersonation.crearCarpeta("\\sw-imgdig\d$\")
                        'Clases.Impersonation.crearCarpeta("\\sw-imgdig\d$\Digitalizacion\ProyDigital\Calidad\1840\")
                        'Directory.CreateDirectory("\\sw-imgdig\d$\Digitalizacion\ProyDigital\Calidad\1840\", )
                        Frm_Principal.Show()
                        Me.Hide()
                        LimpiarTextBox()
                    Else
                        MsgBox("ACCESO DENEGADO, usuario desactivado", MsgBoxStyle.Exclamation, "Aviso")
                    End If

                Else
                    MsgBox("ACCESO DENEGADO, clave no valida", MsgBoxStyle.Exclamation, "Aviso")
                    TxtClave.Focus()
                    TxtClave.SelectAll()
                End If
            Else
                MsgBox("ACCESO DENEGADO, usuario no valido", MsgBoxStyle.Exclamation, "Aviso")
                TxtUsuario.Focus()
                TxtUsuario.SelectAll()
            End If
        End If
    End Sub

    Public Sub LimpiarTextBox()
        TxtUsuario.Text = ""
        TxtClave.Text = ""
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

    Private Sub TxtUsuario_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtUsuario.TextChanged
        TxtUsuario.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub TxtClave_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtClave.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnAceptar_Click(sender, e)
        End If
    End Sub

    Private Sub TxtClave_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtClave.TextChanged
        TxtClave.CharacterCasing = CharacterCasing.Upper
    End Sub


 
End Class