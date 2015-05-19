Public Class Frm_CrearReporteEdicion

    Private Sub Frm_CrearReporteEdicion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargarCbxTipo()
        CargarUsuarios()
    End Sub
    Public Sub CargarUsuarios()
        Dim Datos As New Clases.C_ReporteDetalleEmpaste
        Dim RecuperarDato = Datos.CargarDatos(3, "", 0, "", "")
        Dim Dr As DataRow
        Dr = RecuperarDato.NewRow
        Dr.Item(0) = "TODOS"
        Dr.Item(1) = "TODOS"
        RecuperarDato.Rows.InsertAt(Dr, 0)
        CbxUsuario.DataSource = RecuperarDato
        CbxUsuario.ValueMember = RecuperarDato.Columns(0).ToString.Trim
        CbxUsuario.DisplayMember = RecuperarDato.Columns(1).ToString.Trim
    End Sub

    Private Sub TxtCodIdentificacion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCodIdentificacion.KeyPress
        If InStr(1, "QwEeRrTtYyUuIiOoPpAaSsDdFfGgHhJjKkLlÑñZzXxCcVvBbNnMm0123456789-" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub TxtCodIdentificacion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCodIdentificacion.TextChanged
        TxtCodIdentificacion.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub BtnVistaPreliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVistaPreliminar.Click
        Dim Reporte As New Clases.C_ReporteDetalleEmpaste
        Dim StrCodIdentificacion As String
        If TxtCodIdentificacion.Text = "" Then
            StrCodIdentificacion = "0"
        Else
            StrCodIdentificacion = TxtCodIdentificacion.Text
        End If

        DgvReporteDetalleEmpaste.DataSource = Reporte.CargarDatos(2, StrCodIdentificacion, CbxTipo.SelectedValue, CbxUsuario.SelectedValue, TxtObservacion.Text)
        If DgvReporteDetalleEmpaste.Rows.Count > 0 Then
            DgvReporteDetalleEmpaste.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            DgvReporteDetalleEmpaste.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            Dim rpt As New Clases.RptDetalle
            rpt.SetDataSource(DgvReporteDetalleEmpaste.DataSource)
            Frm_ReporteEdicion.CrvEdicion.ReportSource = rpt
            Frm_ReporteEdicion.ShowDialog()
        Else
            MsgBox("No existe datos para código de identificación ingresada", MsgBoxStyle.Exclamation, "Aviso")
        End If
    End Sub

    Public Sub CargarCbxTipo()
        Dim Datos As New Clases.C_ReporteDetalleEmpaste
        Dim RecuperarDato = Datos.CargarDatos(1, "", 0, "", "")
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