Public Class Frm_Trazabilidad

    Private Sub Frm_Trazabilidad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Dim cTrazabilidad As New Clases.C_Trazabilidad
        dgvResultados.DataSource = cTrazabilidad.cargarTrazabilidad(Me.tbCodigo.Text, Convert.ToInt16(Me.cbTipo.SelectedValue))

        If dgvResultados.Rows.Count = 0 Then
            MessageBox.Show("No existe cambios en este Objeto")
        End If

        If Me.cbTipo.SelectedValue = "0" Then
            crearColumnasTrazabilidadPagina()
        ElseIf Me.cbTipo.SelectedValue = "1" Then
            crearColumnasTrazabilidadEdicion()
        End If

    End Sub

    Private Sub crearColumnasTrazabilidadEdicion()
        dgvResultados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvResultados.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

        dgvResultados.DefaultCellStyle.BackColor = Color.AliceBlue
        dgvResultados.Columns.Item(0).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvResultados.Columns.Item(0).HeaderText = "Cod. Empaste"
        dgvResultados.Columns.Item(0).Visible = False
        dgvResultados.Columns.Item(1).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvResultados.Columns.Item(1).HeaderText = "Cod. Edición"
        dgvResultados.Columns.Item(1).Name = "CodigoEdicion"
        dgvResultados.Columns.Item(1).Visible = True
        dgvResultados.Columns.Item(2).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvResultados.Columns.Item(2).Name = "Tipo"
        dgvResultados.Columns.Item(2).Visible = False
        dgvResultados.Columns.Item(3).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvResultados.Columns.Item(3).HeaderText = "Codigo"
        dgvResultados.Columns.Item(3).Visible = False
        dgvResultados.Columns.Item(4).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvResultados.Columns.Item(4).HeaderText = "Cod. Estado"
        dgvResultados.Columns.Item(4).Visible = False
        dgvResultados.Columns.Item(5).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvResultados.Columns.Item(5).HeaderText = "Fecha"
        dgvResultados.Columns.Item(6).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvResultados.Columns.Item(6).HeaderText = "Usuario"
        dgvResultados.Columns.Item(7).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvResultados.Columns.Item(7).HeaderText = "Desc. Estado"
        
        dgvResultados.Refresh()

    End Sub

    Private Sub crearColumnasTrazabilidadPagina()
        dgvResultados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvResultados.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

        dgvResultados.DefaultCellStyle.BackColor = Color.AliceBlue
        dgvResultados.Columns.Item(0).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvResultados.Columns.Item(0).HeaderText = "Cod. Empaste"
        dgvResultados.Columns.Item(0).Visible = False
        dgvResultados.Columns.Item(1).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvResultados.Columns.Item(1).HeaderText = "Cod. Edición"
        dgvResultados.Columns.Item(1).Name = "CodigoEdicion"
        dgvResultados.Columns.Item(1).Visible = False
        dgvResultados.Columns.Item(2).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvResultados.Columns.Item(2).Visible = False
        dgvResultados.Columns.Item(2).Name = "Tipo"

        dgvResultados.Columns.Item(3).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvResultados.Columns.Item(3).HeaderText = "CodigoPagina"
        dgvResultados.Columns.Item(3).Visible = True

        dgvResultados.Columns.Item(4).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvResultados.Columns.Item(4).HeaderText = "Codigo"
        dgvResultados.Columns.Item(4).Visible = False

        dgvResultados.Columns.Item(5).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvResultados.Columns.Item(5).HeaderText = "Cod. Estado"
        dgvResultados.Columns.Item(5).Visible = False
        dgvResultados.Columns.Item(6).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvResultados.Columns.Item(6).HeaderText = "Fecha"
        dgvResultados.Columns.Item(7).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvResultados.Columns.Item(7).HeaderText = "Usuario"
        dgvResultados.Columns.Item(8).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvResultados.Columns.Item(8).HeaderText = "Desc. Estado"

        dgvResultados.Refresh()
    End Sub


End Class