Public Class Frm_Paginas
#Region "VARIABLES PUBLICAR"
    Public Frm_Pag_CodAuxPag As String = ""
#End Region
#Region "VARIABLES QUE TOMAN VALOR DE DETALLE EDICION"
    Public Frm_Pag_NumPaginas As Integer = 0
    Public Frm_Pag_NumPaginasMax As Integer = 0
    Public Frm_Pag_TipoDetalle As Integer = 0

    Public Frm_Pag_ControlDetalle As Integer = 0
    Public Frm_Cant_Pag_Edicion As Integer = 0

    Public AgregarPagina As Integer
#End Region
#Region "CODIGO DE PAGINAS"

    Private Sub Frm_Paginas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Frm_Pag_ControlDetalle = 2 Then
            Frm_Pag_CodAuxPag = LblCodIdenEmDe.Text & TxtCodPag.Text
            AgregarPagina = 0
        ElseIf Frm_Pag_ControlDetalle = 1 Then
            LimpiarCampos()
            AgregarPagina = 1
        End If
        TxtNumPagina.Enabled = False
        TxtNumPagina.BackColor = Color.White
        TxtNumPagina.ForeColor = Color.Black
        TxtCodPag.Select()
    End Sub

    Private Sub TlsGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TlsGuardar.Click
        Dim StringCompleto As String = ""
        Dim StringIncompleto As String = ""
        Dim StringRota As String = ""
        Dim StringManchada As String = ""
        Dim StringFalta As String = ""
        Dim StringDificultad As String = ""

        If CkxCompleta.Checked = True Then
            StringCompleto = "S"
        Else
            StringCompleto = "N"
        End If
        If CkxIncompleta.Checked = True Then
            StringIncompleto = "S"
        Else
            StringIncompleto = "N"
        End If
        If CkxRota.Checked = True Then
            StringRota = "S"
        Else
            StringRota = "N"
        End If
        If CkxManchada.Checked = True Then
            StringManchada = "S"
        Else
            StringManchada = "N"
        End If
        If CkxFalta.Checked = True Then
            StringFalta = "S"
        Else
            StringFalta = "N"
        End If
        If CkxDificultad.Checked = True Then
            StringDificultad = "S"
        Else
            StringDificultad = "N"
        End If
        If TxtCodPag.MaxLength <> Len(TxtCodPag.Text) Then
            MsgBox("El código debe tener 22 caracteres", MsgBoxStyle.Exclamation, "Aviso")
            TxtCodPag.Focus()
        ElseIf TxtNumPagina.Text <> TxtCodPag.Text Then
            MsgBox("El N. de página debe ser igual a los 3 últimos dígitos del código de identificación", MsgBoxStyle.Exclamation, "Aviso")

            'puedo desabilitar esta linea de codigo para que me agrege la pagina sin el mensajes
            'ElseIf Frm_Pag_NumPaginas + AgregarPagina > Frm_Pag_NumPaginasMax Then 'Frm_Pag_NumPaginasMax=TxtENumPagEdicion.Text
        ElseIf Frm_Pag_NumPaginas + AgregarPagina > Frm_Cant_Pag_Edicion Then 'CInt(Frm_Edicion.TxtENumPagEdicion.Text) Then
            MsgBox("El N. de páginas no puede ser mayor a lo ingresado en el detalle de empaste", MsgBoxStyle.Exclamation, "Aviso")
            '---------------------------------------------------------------------------------------

        ElseIf CkxCompleta.Checked = False And CkxDificultad.Checked = False And CkxFalta.Checked = False And CkxIncompleta.Checked = False And CkxManchada.Checked = False And CkxRota.Checked = False Then
            MsgBox("Seleccione al menos un estado de página", MsgBoxStyle.Exclamation, "Aviso")
        ElseIf TxtCodPag.Text <> "" And TxtCodPag.MaxLength = Len(TxtCodPag.Text) And TxtNumPagina.Text <> "" Then
            Dim Gestionar As New Clases.C_Paginas
            Dim ValorDevueltoRegistrar As String = ""
            Dim ValorDevueltoModificar As String = ""

            If Frm_Pag_CodAuxPag = "" And TxtCodPag.Text <> "" Then
                Dim Valor_Booleano_1 = Gestionar.BuscarPagina(1, LblCodIdenEmDe.Text.Substring(0, 11), LblCodIdenEmDe.Text.Substring(0, 18), Frm_Pag_TipoDetalle, LblCodIdenEmDe.Text & TxtCodPag.Text)
                If Valor_Booleano_1 = "NO" Then
                    ValorDevueltoRegistrar = Gestionar.Gestionar_Pagina_RetCad(1, "", LblCodIdenEmDe.Text.Substring(0, 11), LblCodIdenEmDe.Text.Substring(0, 18), Frm_Pag_TipoDetalle, LblCodIdenEmDe.Text & TxtCodPag.Text, TxtNumPagina.Text, StringCompleto, StringIncompleto, StringRota, StringManchada, StringFalta, StringDificultad, TxtObservaciones.Text, Frm_Login.DgvDatosUsuario.Rows(0).Cells(0).Value, TxtNumTomo.Text)
                    If ValorDevueltoRegistrar = LblCodIdenEmDe.Text & TxtCodPag.Text Then
                        MsgBox("Página almacenada", MsgBoxStyle.Information, "Aviso")
                        Frm_Pag_CodAuxPag = LblCodIdenEmDe.Text & TxtCodPag.Text
                        LimpiarCampos()
                        Me.Close()
                    Else
                        MsgBox("Página no almacenada", MsgBoxStyle.Information, "Aviso")
                    End If
                Else
                    MsgBox("Ya existe el código de identificación", MsgBoxStyle.Exclamation, "Aviso")
                End If
            ElseIf Frm_Pag_CodAuxPag <> "" And Frm_Pag_CodAuxPag = LblCodIdenEmDe.Text & TxtCodPag.Text Then
                ValorDevueltoRegistrar = Gestionar.Gestionar_Pagina_RetCad(2, Frm_Pag_CodAuxPag, LblCodIdenEmDe.Text.Substring(0, 11), LblCodIdenEmDe.Text.Substring(0, 18), Frm_Pag_TipoDetalle, LblCodIdenEmDe.Text & TxtCodPag.Text, TxtNumPagina.Text, StringCompleto, StringIncompleto, StringRota, StringManchada, StringFalta, StringDificultad, TxtObservaciones.Text, Frm_Login.DgvDatosUsuario.Rows(0).Cells(0).Value, TxtNumTomo.Text)
                If ValorDevueltoRegistrar = LblCodIdenEmDe.Text & TxtCodPag.Text Then
                    MsgBox("Página actualizada", MsgBoxStyle.Information, "Aviso")
                    Frm_Pag_CodAuxPag = ""
                    LimpiarCampos()
                    Me.Close()
                Else
                    MsgBox("Página no actualizada", MsgBoxStyle.Information, "Aviso")
                End If
            ElseIf Frm_Pag_CodAuxPag <> "" And Frm_Pag_CodAuxPag <> LblCodIdenEmDe.Text & TxtCodPag.Text Then
                Dim Valor_Booleano_2 = Gestionar.BuscarPagina(1, LblCodIdenEmDe.Text.Substring(0, 11), LblCodIdenEmDe.Text.Substring(0, 18), Frm_Pag_TipoDetalle, LblCodIdenEmDe.Text & TxtCodPag.Text)
                If Valor_Booleano_2 = "NO" Then
                    ValorDevueltoRegistrar = Gestionar.Gestionar_Pagina_RetCad(2, Frm_Pag_CodAuxPag, LblCodIdenEmDe.Text.Substring(0, 11), LblCodIdenEmDe.Text.Substring(0, 18), Frm_Pag_TipoDetalle, LblCodIdenEmDe.Text & TxtCodPag.Text, TxtNumPagina.Text, StringCompleto, StringIncompleto, StringRota, StringManchada, StringFalta, StringDificultad, TxtObservaciones.Text, Frm_Login.DgvDatosUsuario.Rows(0).Cells(0).Value, TxtNumTomo.Text)
                    If ValorDevueltoRegistrar = LblCodIdenEmDe.Text & TxtCodPag.Text Then
                        MsgBox("Página actualizada", MsgBoxStyle.Information, "Aviso")
                        Frm_Pag_CodAuxPag = ""
                        LimpiarCampos()
                        Me.Close()
                    Else
                        MsgBox("Página no actualizada", MsgBoxStyle.Information, "Aviso")
                    End If

                Else
                    MsgBox("Ya existe el código de identificación", MsgBoxStyle.Exclamation, "Aviso")
                End If
            End If
        End If

    End Sub

    Public Sub LimpiarCampos()
        TxtCodPag.Text = ""
        TxtNumPagina.Text = ""
        CkxCompleta.Checked = False
        CkxDificultad.Checked = False
        CkxFalta.Checked = False
        CkxIncompleta.Checked = False
        CkxManchada.Checked = False
        CkxRota.Checked = False
        TxtObservaciones.Text = ""
        TxtNumTomo.Text = ""
    End Sub

    Private Sub Frm_Paginas_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Frm_Pag_CodAuxPag = ""
        LimpiarCampos()
    End Sub

#Region "VALIDACIONES"

    Private Sub TxtCodPag_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCodPag.KeyPress
        If InStr(1, "0123456789-" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub TxtCodPag_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCodPag.KeyUp
        If Len(TxtCodPag.Text) = 1 Then
            TxtNumPagina.Text = TxtCodPag.Text.Substring(0, 1)
        ElseIf Len(TxtCodPag.Text) = 2 Then
            TxtNumPagina.Text = TxtCodPag.Text.Substring(0, 2)
        ElseIf Len(TxtCodPag.Text) = 3 Then
            TxtNumPagina.Text = TxtCodPag.Text.Substring(0, 3)
        ElseIf Len(TxtCodPag.Text) = 4 Then
            TxtNumPagina.Text = TxtCodPag.Text.Substring(0, 4)
        ElseIf Len(TxtCodPag.Text) = 5 Then
            TxtNumPagina.Text = TxtCodPag.Text.Substring(0, 5)
        ElseIf Len(TxtCodPag.Text) = 6 Then
            TxtNumPagina.Text = TxtCodPag.Text.Substring(0, 6)
        ElseIf Len(TxtCodPag.Text) <= 1 Then
            TxtNumPagina.Text = ""
        End If
    End Sub

    Private Sub TxtCodPag_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCodPag.TextChanged
        TxtCodPag.CharacterCasing = CharacterCasing.Upper
    End Sub
#End Region
#End Region

 
  
End Class