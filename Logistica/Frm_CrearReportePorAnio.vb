Imports Clases
Public Class Frm_CrearReportePorAnio

    Private Sub Frm_CrearReportePorAnio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call CargaAnio()
        DgReporteXanio.Visible = vbFalse
    End Sub

    Sub CargaAnio()
        Dim obj As New C_ReportePorAnio

        cboReporte.DataSource = obj.ListarAnio
        cboReporte.DisplayMember = "año"
        cboReporte.ValueMember = "año"


    End Sub

    Private Sub btnMostrarReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMostrarReporte.Click
        Dim obj As New C_ReportePorAnio
        'DgReporteXanio es un objeto dentro del formulario pero en el lado izquierdo inferior
        'para que no sea visto
        DgReporteXanio.DataSource = obj.ListadoXaño(cboReporte.SelectedValue.ToString)

        If DgReporteXanio.Rows.Count > 1 Then
            'DgReporteXanio.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            'DgReporteXanio.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            Dim rpt As New RptListadoAnio
            rpt.SetDataSource(DgReporteXanio.DataSource)
            Frm_ReportePorAnio.CrvReporteAnio.ReportSource = rpt
            Frm_ReportePorAnio.ShowDialog()
        End If
    End Sub
End Class