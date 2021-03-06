﻿Public Class Frm_CrearReportePagina

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub BtnVistaPreliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVistaPreliminar.Click
        If String.IsNullOrEmpty(TxtCodIdentificacion.Text) Then
            MsgBox("Ingrese código de identificación", MsgBoxStyle.Exclamation, "Aviso")
        ElseIf Not String.IsNullOrEmpty(TxtCodIdentificacion.Text) Then
            Dim ReportePagina As New Clases.C_ReportePaginas
            DgvReportePagina.DataSource = ReportePagina.CargarDatos(2, TxtCodIdentificacion.Text, CbxTipo.SelectedValue, CbxUsuario.SelectedValue, TxtObservacion.Text)
            If DgvReportePagina.Rows.Count > 0 Then

                Dim rpt As New Clases.RptPaginas
                rpt.SetDataSource(DgvReportePagina.DataSource)
                Frm_ReportePagina.CrvPagina.ReportSource = rpt
                Frm_ReportePagina.ShowDialog()
            Else
                MsgBox("No existe datos, para el código de identificación ingresada", MsgBoxStyle.Exclamation, "Aviso")
            End If
        End If
    End Sub

    Private Sub TxtCodIdentificacion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCodIdentificacion.KeyPress
        If InStr(1, "QwEeRrTtYyUuIiOoPpAaSsDdFfGgHhJjKkLlÑñZzXxCcVvBbNnMm0123456789-" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub TxtCodIdentificacion_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCodIdentificacion.TextChanged
        TxtCodIdentificacion.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub Frm_CrearReportePagina_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargarUsuario()
        CargarCbxTipo()
    End Sub
    Public Sub CargarUsuario()
        Dim Datos As New Clases.C_ReportePaginas
        Dim RecuperarDato = Datos.CargarDatos(1, "", 0, "", "")
        Dim Dr As DataRow
        Dr = RecuperarDato.NewRow
        Dr.Item(0) = "TODOS"
        Dr.Item(1) = "TODOS"
        RecuperarDato.Rows.InsertAt(Dr, 0)
        CbxUsuario.DataSource = RecuperarDato
        CbxUsuario.ValueMember = RecuperarDato.Columns(0).ToString.Trim
        CbxUsuario.DisplayMember = RecuperarDato.Columns(1).ToString.Trim
    End Sub

    Public Sub CargarCbxTipo()
        Dim Datos As New Clases.C_ReportePaginas
        Dim RecuperarDato = Datos.CargarDatos(3, "", 0, "", "")
        Dim Dr As DataRow
        Dr = RecuperarDato.NewRow
        Dr.Item(0) = "0"
        Dr.Item(1) = "TODOS"
        RecuperarDato.Rows.InsertAt(Dr, 0)
        CbxTipo.DataSource = RecuperarDato
        CbxTipo.ValueMember = RecuperarDato.Columns(0).ToString.Trim
        CbxTipo.DisplayMember = RecuperarDato.Columns(1).ToString.Trim
    End Sub
End Class