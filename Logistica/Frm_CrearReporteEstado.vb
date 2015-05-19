Imports CrystalDecisions.Shared

Public Class Frm_CrearReporteEstado
    Dim cReporteEstado As New Clases.C_ReporteEstado

    Private Sub btnVista_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVista.Click
        If tbAnio.Text.Length <> 4 Then
            MsgBox("Ingrese un Año correcto", MsgBoxStyle.Exclamation, "Aviso")
        Else
            Dim cReporteEstado As New Clases.C_ReporteEstado
            Dim t As Integer = cbTipo.SelectedIndex()
            Dim estado As String = cbEstado.SelectedValue.ToString()
            Dim anio As Integer = Convert.ToInt16(tbAnio.Text)
            Dim dt As DataTable
            'Desconectar
            Dim rpt
            dt = cReporteEstado.CargarDatos(t + 1, estado, anio)
            If t = 0 Then
                rpt = New Clases.RptEstadoPagina
            Else
                rpt = New Clases.RptEstadoEdicion
            End If

            If dt.Rows.Count > 0 Then
                rpt.SetDataSource(dt)
                Frm_ReporteEstado.CrvEstado.ReportSource = rpt
                Frm_ReporteEstado.ShowDialog()
            Else
                MsgBox("No existe datos, con los campos seleccionados", MsgBoxStyle.Exclamation, "Aviso")
            End If

        End If
    End Sub

    Private Sub Frm_CrearReporteEstado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenarTipos()
    End Sub

    Private Sub llenarTipos()
        Dim dt As DataTable = New DataTable("Tipos")
        dt.Columns.Add("Codigo")
        dt.Columns.Add("Descripcion")

        Dim dr As DataRow

        dr = dt.NewRow()
        dr("Codigo") = "0"
        dr("Descripcion") = "Página"
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("Codigo") = "1"
        dr("Descripcion") = "Edición"
        dt.Rows.Add(dr)

        Me.cbTipo.DataSource = dt
        Me.cbTipo.ValueMember = "Codigo"
        Me.cbTipo.DisplayMember = "Descripcion"
    End Sub

    Private Sub llenarEstados()
        Dim tipo As String = Convert.ToString(cbTipo.SelectedIndex)

        Dim t As String = ""
        If (tipo = "0") Then
            t = "IMAGEN"
        ElseIf tipo = "1" Then
            t = "PDF"
        Else
            t = "IMAGEN"
        End If

        Dim dt As DataTable = cReporteEstado.CargarEstados(t)
        Dim dr As DataRow
        dr = dt.NewRow()
        dr("Codigo") = "0"
        dr("Descripcion") = "Todos"
        dr("Grupo") = "t"
        dt.Rows.InsertAt(dr, 0)

        cbEstado.DataSource = dt
        cbEstado.ValueMember = "Codigo"
        cbEstado.DisplayMember = "Descripcion"
    End Sub

    Private Sub cbTipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTipo.SelectedIndexChanged
        llenarEstados()
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbAnio.KeyPress
        If Not (Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub MostrarResultados()
        Dim cReporteEstado As New Clases.C_ReporteEstado
        'dgvResultado.DataSource = cReporteEstado.CargarDatos(1, "EI", 1825)
        'dgvResultado.Refresh()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class