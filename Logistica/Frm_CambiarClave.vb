Public Class Frm_CambiarClave

    Private Sub Frm_CambiarClave_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LblUsuario.Text = LblUsuario.Text & " " & Frm_Login.DgvDatosUsuario.Rows(0).Cells(3).Value & " " & Frm_Login.DgvDatosUsuario.Rows(0).Cells(4).Value & " , " & Frm_Login.DgvDatosUsuario.Rows(0).Cells(2).Value
    End Sub

    Private Sub TlsGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TlsGuardar.Click
        If String.IsNullOrEmpty(TxtClaveActual.Text) Then
            MsgBox("Ingrese clave actual", MsgBoxStyle.Exclamation, "Aviso")
            TxtClaveActual.Focus()
        ElseIf String.IsNullOrEmpty(TxtClaveNueva.Text) Then
            MsgBox("Ingrese clave nueva", MsgBoxStyle.Exclamation, "Aviso")
            TxtClaveNueva.Focus()
        ElseIf String.IsNullOrEmpty(TxtConfirmarClaveNueva.Text) Then
            MsgBox("Ingrese confirmación de clave", MsgBoxStyle.Exclamation, "Aviso")
            TxtConfirmarClaveNueva.Focus()
        Else
            If Frm_Login.DgvDatosUsuario.Rows(0).Cells(1).Value <> TxtClaveActual.Text Then
                MsgBox("La clave actual no es la correcta", MsgBoxStyle.Information, "Aviso")
                TxtClaveActual.Focus()
                TxtClaveActual.SelectAll()
            ElseIf TxtConfirmarClaveNueva.Text <> TxtClaveNueva.Text Then
                MsgBox("La clave nueva, con la clave de confirmación no son iguales", MsgBoxStyle.Information, "Aviso")
                TxtConfirmarClaveNueva.Focus()
                TxtConfirmarClaveNueva.SelectAll()
            ElseIf Frm_Login.DgvDatosUsuario.Rows(0).Cells(1).Value = TxtClaveActual.Text And TxtConfirmarClaveNueva.Text = TxtClaveNueva.Text Then
                Dim Cambiar As New Clases.C_CambiarClave
                Dim ValorDevuelto = Cambiar.CambiarClave(1, Frm_Login.DgvDatosUsuario.Rows(0).Cells(0).Value, TxtClaveNueva.Text, Frm_Login.DgvDatosUsuario.Rows(0).Cells(1).Value)
                If ValorDevuelto = TxtClaveNueva.Text Then
                    MsgBox("El cambio de clave se realizo correctamente", MsgBoxStyle.Information, "Aviso")
                    Dim ActualizarData As New Clases.C_Login
                    Frm_Login.DgvDatosUsuario.DataSource = ActualizarData.Validar(Frm_Login.DgvDatosUsuario.Rows(0).Cells(0).Value)
                Else
                    MsgBox("El cambio de clave no se realizo correctamente", MsgBoxStyle.Information, "Aviso")
                End If
            End If
        End If
    End Sub

    Private Sub TxtClaveActual_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtClaveActual.TextChanged
        TxtClaveActual.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub TxtClaveNueva_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtClaveNueva.TextChanged
        TxtClaveNueva.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub TxtConfirmarClaveNueva_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtConfirmarClaveNueva.TextChanged
        TxtConfirmarClaveNueva.CharacterCasing = CharacterCasing.Upper
    End Sub
End Class