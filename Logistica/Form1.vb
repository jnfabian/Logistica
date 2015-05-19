Public Class Frm_InventarioEdiciones
    Public CodigoEmpaste As Integer = 1
    Private Sub Frm_InventarioEdiciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CbxVisto.SelectedIndex = 0
        DeshabilitarBotonesEmpastes()
        DeshabilitarCampos()
        CrearColumnasDataGridView()
    End Sub
    Public Sub CrearColumnasDataGridView()
        DgwEmpaste.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DgwEmpaste.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DgwEmpaste.Columns.Add("Cod", "Cod")
        DgwEmpaste.Columns.Add("CodIdentificacion", "Identificacion")
        DgwEmpaste.Columns.Add("NumEdiciones", "N°. Ediciones")
        DgwEmpaste.Columns.Add("NumPaginas", "N°. Paginas")
        DgwEmpaste.Columns.Add("EdicionesFaltantes", "Ediciones Faltantes")
        DgwEmpaste.Columns.Add("FecIni", "F. Inicio")
        DgwEmpaste.Columns.Add("FecFin", "F. Termino")
        DgwEmpaste.Columns.Add("Largo", "Largo")
        DgwEmpaste.Columns.Add("Ancho", "Ancho")
        DgwEmpaste.Columns.Add("Altura", "Altura")
    End Sub
    Public Sub DeshabilitarBotonesEmpastes()
        TlsNuevo.Enabled = True
        TlsGuardar.Enabled = False
    End Sub
    Public Sub DeshabilitarCampos()
        DtpFecIni.Enabled = False
        DtpTermino.Enabled = False

        TxtLargo.Enabled = False
        TxtAncho.Enabled = False
        TxtAltura.Enabled = False

        CkxBueno.Enabled = False
        CkxDeteriorado.Enabled = False
        CkxRegular.Enabled = False

        TxtNumEdiciones.Enabled = False
        TxtCodIdentificacion.Enabled = False
        TxtNumPaginas.Enabled = False
        TxtEdicionesFaltantes.Enabled = False

        TxtAnaquel.Enabled = False
        TxtNivel.Enabled = False

        CbxVisto.Enabled = False
        TxtObservaciones.Enabled = False
    End Sub
    Public Sub HabilitarCampos()
        DtpFecIni.Enabled = True
        DtpTermino.Enabled = True

        TxtLargo.Enabled = True
        TxtAncho.Enabled = True
        TxtAltura.Enabled = True

        CkxBueno.Enabled = True
        CkxDeteriorado.Enabled = True
        CkxRegular.Enabled = True

        TxtNumEdiciones.Enabled = True
        TxtCodIdentificacion.Enabled = True
        TxtNumPaginas.Enabled = True
        TxtEdicionesFaltantes.Enabled = True

        TxtAnaquel.Enabled = True
        TxtNivel.Enabled = True

        CbxVisto.Enabled = True
        TxtObservaciones.Enabled = True
    End Sub
    Public Sub LimpiarCampos()
        DtpFecIni.Text = Date.Now
        DtpTermino.Text = Date.Now

        TxtLargo.Text = ""
        TxtAncho.Text = ""
        TxtAltura.Text = ""

        CkxBueno.Checked = False
        CkxDeteriorado.Checked = False
        CkxRegular.Checked = False

        TxtNumEdiciones.Text = ""
        TxtCodIdentificacion.Text = ""
        TxtNumPaginas.Text = ""
        TxtEdicionesFaltantes.Text = ""

        TxtAnaquel.Text = ""
        TxtNivel.Text = ""

        CbxVisto.SelectedIndex = 0
        TxtObservaciones.Text = ""
    End Sub
    Private Sub TxtAltura_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtAltura.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub TxtAnaquel_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtAnaquel.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub TxtAncho_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtAncho.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub TxtEdicionesFaltantes_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtEdicionesFaltantes.KeyPress
        If InStr(1, "0123456789-" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub TxtLargo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtLargo.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub TxtNivel_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNivel.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub TxtNumPaginas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNumPaginas.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub TlsNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TlsNuevo.Click
        TlsGuardar.Enabled = True
        HabilitarCampos()
        LimpiarCampos()
    End Sub
    Private Sub TlsGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TlsGuardar.Click
        DgwEmpaste.Rows.Add(CodigoEmpaste, TxtCodIdentificacion.Text, TxtNumEdiciones.Text, TxtNumPaginas.Text, TxtEdicionesFaltantes.Text, DtpFecIni.Text, DtpTermino.Text, TxtLargo.Text, TxtAncho.Text, TxtAltura.Text)
        CodigoEmpaste += 1
        LimpiarCampos()
    End Sub
    Private Sub TlsModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TlsModificar.Click
        TpgEmpasteIngreso.Show()
        TxtCodIdentificacion.Text = DgwEmpaste.SelectedCells(1).Value
        TxtNumEdiciones.Text = DgwEmpaste.SelectedCells(2).Value
        TxtNumPaginas.Text = DgwEmpaste.SelectedCells(3).Value
        TxtEdicionesFaltantes.Text = DgwEmpaste.SelectedCells(4).Value
        DtpFecIni.Text = DgwEmpaste.SelectedCells(5).Value
        DtpTermino.Text = DgwEmpaste.SelectedCells(6).Value
        TxtLargo.Text = DgwEmpaste.SelectedCells(7).Value
        TxtAncho.Text = DgwEmpaste.SelectedCells(8).Value
        TxtAltura.Text = DgwEmpaste.SelectedCells(9).Value
    End Sub
End Class
