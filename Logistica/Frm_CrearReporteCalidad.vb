Imports Clases

Public Class Frm_CrearReporteCalidad

    Private Sub Frm_ReporteCalidad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call CargarAños()

    End Sub

    Sub CargarAños()

        Dim obj As New C_ReportePorAnio

        cboAnios.DataSource = obj.ListarAnio
        cboAnios.DisplayMember = "año"
        cboAnios.ValueMember = "año"

        cboAnios.DropDownStyle = ComboBoxStyle.DropDownList


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim ds As New DirectorioDataSet
        Dim reporteCalidad As New DirectorioDataSetTableAdapters.Usp_Reporte_calidadTableAdapter
        reporteCalidad.Fill(ds.Tables("Usp_Reporte_calidad"), cboAnios.SelectedValue)

        Dim rp As New RptCalidad2
        rp.SetDataSource(ds)

        Dim vista As New Frm_Reporte
        vista.CryReporte.ReportSource = rp
        vista.WindowState = FormWindowState.Maximized
        vista.Show()



    End Sub
End Class