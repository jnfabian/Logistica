Public Class Frm_CrearReporteEmpaste

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub Frm_CrearReporteEmpaste_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargarCbxEstado()
        CargarVistos()
        CargarUsuarios()
    End Sub

    Private Sub BtnVistaPreliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVistaPreliminar.Click
        Dim Mostrar As New Clases.C_ReporteEmpaste
        DgvEmpaste.DataSource = Mostrar.CargarDatos(2, TxtCodIdentificacion.Text, CbxEstado.SelectedValue, CbxVisto.SelectedValue, CbxUsuario.SelectedValue, TxtObservaciones.Text)
        If DgvEmpaste.Rows.Count > 0 Then
            Dim rpt As New Clases.RptEmpaste_N
            rpt.SetDataSource(DgvEmpaste.DataSource)
            Frm_ReporteEmpaste.CrvEmpaste.ReportSource = rpt
            Frm_ReporteEmpaste.ShowDialog()
        Else
            MsgBox("No existe datos para código de identificación ingresada", MsgBoxStyle.Exclamation, "Aviso")
        End If
    End Sub

    Private Sub TxtCodIdentificacion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCodIdentificacion.TextChanged
        TxtCodIdentificacion.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub TxtCodIdentificacion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCodIdentificacion.KeyPress
        If InStr(1, "QwEeRrTtYyUuIiOoPpAaSsDdFfGgHhJjKkLlÑñZzXxCcVvBbNnMm0123456789-" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub
    Public Sub CargarUsuarios()
        Dim Datos As New Clases.C_ReporteEmpaste
        Dim RecuperarDato = Datos.CargarDatos(4, "", 0, 0, "", "")
        Dim Dr As DataRow
        Dr = RecuperarDato.NewRow
        Dr.Item(0) = "TODOS"
        Dr.Item(1) = "TODOS"
        RecuperarDato.Rows.InsertAt(Dr, 0)
        CbxUsuario.DataSource = RecuperarDato
        CbxUsuario.ValueMember = RecuperarDato.Columns(0).ToString.Trim
        CbxUsuario.DisplayMember = RecuperarDato.Columns(1).ToString.Trim
    End Sub
    Public Sub CargarVistos()
        Dim Datos As New Clases.C_ReporteEmpaste
        Dim RecuperarDato = Datos.CargarDatos(3, "", 0, 0, "", "")
        Dim Dr As DataRow
        Dr = RecuperarDato.NewRow
        Dr.Item(0) = "0"
        Dr.Item(1) = "TODOS"
        RecuperarDato.Rows.InsertAt(Dr, 0)
        CbxVisto.DataSource = RecuperarDato
        CbxVisto.ValueMember = RecuperarDato.Columns(0).ToString.Trim
        CbxVisto.DisplayMember = RecuperarDato.Columns(1).ToString.Trim
    End Sub

    Public Sub CargarCbxEstado()
        Dim Datos As New Clases.C_ReporteEmpaste
        Dim RecuperarDato = Datos.CargarDatos(1, "", 0, 0, "", "")
        Dim Dr As DataRow
        Dr = RecuperarDato.NewRow
        Dr.Item(0) = "0"
        Dr.Item(1) = "TODOS"
        RecuperarDato.Rows.InsertAt(Dr, 0)
        CbxEstado.DataSource = RecuperarDato
        CbxEstado.ValueMember = RecuperarDato.Columns(0).ToString.Trim
        CbxEstado.DisplayMember = RecuperarDato.Columns(1).ToString.Trim
    End Sub

End Class