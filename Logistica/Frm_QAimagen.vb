Imports System.IO


Public Class Frm_QAimagen
    Private tipoVer As Integer = 0
    Private aprobadas As Boolean

    Dim aArchivos As New Clases.AccesoArchivos()
    Dim lErrorConexionRed As Long
    Dim carpetaRaiz As String = Configuration.ConfigurationManager.AppSettings("carpetaRaiz")
    Dim cPaginas As New Clases.C_Paginas
    Dim ds As New DataSet
    Dim TotalPaginas As Double

    Public Sub New(ByVal tipo As Integer)
        MyBase.New()
        tipoVer = tipo
        InitializeComponent()
        If tipoVer = 1 Then
            Me.Text = "QA Imagenes para aprobar"
        Else
            Me.Text = "QA Imagenes desaprobadas"
        End If
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If tipoVer = 1 Then
            ListarImagenesPorAprobar()
        Else
            ListarImagenesDesaprobadas()
        End If
        lblInicio.Text = 0
        lblFinal.Text = dgvImagenes.Rows.Count
        cPaginas.final = 100
        cPaginas.inicio = 0

    End Sub

    Private Sub Frm_QAimagen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenarTiposDocumento()

        If tipoVer = 1 Then
            ListarImagenesPorAprobar()
        ElseIf tipoVer = 2 Then
            ListarImagenesDesaprobadas()
        End If

        mostrarBotones()
        lblInicio.Text = 0
        lblFinal.Text = dgvImagenes.Rows.Count
    End Sub

    Private Sub mostrarBotones()
        If tipoVer = 1 Then
            Me.btnAprobar.Visible = True
            Me.btnDesaprobar.Visible = True
            Me.btnPasarQA.Visible = False
        ElseIf tipoVer = 2 Then
            Me.btnAprobar.Visible = False
            Me.btnDesaprobar.Visible = False
            Me.btnPasarQA.Visible = True
        End If
    End Sub

    Private Sub llenarTiposDocumento()
        Dim cPaginas As New Clases.C_Paginas
        Dim dt As DataTable = cPaginas.getTiposDocumento()

        Dim dr As DataRow

        dr = dt.NewRow()
        dr("TIPO") = "0"
        dr("DESCRIPCION") = "Todos"
        dt.Rows.InsertAt(dr, 0)

        cbTipoDocumento.DataSource = dt
        cbTipoDocumento.ValueMember = "TIPO"
        cbTipoDocumento.DisplayMember = "DESCRIPCION"

        'cbTipoDocumento.DataSource = 
    End Sub

    Private Sub ListarImagenesDesaprobadas()
        Dim cPaginas As New Clases.C_Paginas
        Dim codEmpaste As String = tbCodigoEmpaste.Text
        Dim codEdicion As String = tbCodigoEdicion.Text
        Dim codPagina As String = tbCodigoPagina.Text
        Dim tipo As Integer = 0
        If cbTipoDocumento.SelectedIndex() <> -1 Then
            If cbTipoDocumento.SelectedValue = "0" Then
                tipo = 0
            Else
                tipo = Convert.ToInt16(cbTipoDocumento.SelectedValue)
            End If
        End If

        dgvImagenes.DataSource = Nothing
        dgvImagenes.Columns.Clear()
        If tipo = 0 Then
            dgvImagenes.DataSource = cPaginas.BuscarPaginaPorAprobar(3, codPagina, codEdicion, codEmpaste, tipo)

        Else
            dgvImagenes.DataSource = cPaginas.BuscarPaginaPorAprobar(4, codPagina, codEdicion, codEmpaste, tipo)
        End If

        crearColumnasImagenesDesaprobadas()

    End Sub

    Private Sub crearColumnasImagenesDesaprobadas()
        dgvImagenes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvImagenes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgvImagenes.DefaultCellStyle.BackColor = Color.AliceBlue
        dgvImagenes.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvImagenes.Columns.Item(0).Visible = False
        dgvImagenes.Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvImagenes.Columns.Item(1).Visible = False
        dgvImagenes.Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvImagenes.Columns.Item(2).Visible = False
        dgvImagenes.Columns.Item(2).Name = "Tipo"
        dgvImagenes.Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvImagenes.Columns.Item(3).HeaderText = "Cod. identificación"
        dgvImagenes.Columns.Item(3).Name = "CodigoIdentificacion"
        dgvImagenes.Columns.Item(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvImagenes.Columns(4).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvImagenes.Columns.Item(4).HeaderText = "N. Pág."
        dgvImagenes.Columns.Item(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvImagenes.Columns.Item(4).Visible = False
        dgvImagenes.Columns(5).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvImagenes.Columns.Item(5).HeaderText = "Pag. Tomo"
        dgvImagenes.Columns.Item(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvImagenes.Columns.Item(5).Visible = False
        dgvImagenes.Columns(6).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvImagenes.Columns.Item(6).HeaderText = "Completo"
        dgvImagenes.Columns.Item(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvImagenes.Columns.Item(6).Visible = False
        dgvImagenes.Columns(7).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvImagenes.Columns.Item(7).HeaderText = "Incompleto"
        dgvImagenes.Columns.Item(7).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvImagenes.Columns(8).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvImagenes.Columns.Item(8).HeaderText = "Roto"
        dgvImagenes.Columns.Item(8).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvImagenes.Columns(9).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvImagenes.Columns.Item(9).HeaderText = "Manchado"
        dgvImagenes.Columns.Item(9).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvImagenes.Columns(10).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvImagenes.Columns.Item(10).HeaderText = "Falta"
        dgvImagenes.Columns.Item(10).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvImagenes.Columns.Item(10).Visible = False
        dgvImagenes.Columns(11).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvImagenes.Columns.Item(11).HeaderText = "Dificultad"
        dgvImagenes.Columns.Item(11).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvImagenes.Columns.Item(11).Visible = False
        dgvImagenes.Columns(12).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvImagenes.Columns.Item(12).HeaderText = "Observaciones"
        dgvImagenes.Columns.Item(12).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvImagenes.Columns(13).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvImagenes.Columns.Item(13).HeaderText = "Imagen"
        dgvImagenes.Columns.Item(13).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvImagenes.Columns.Item(13).Name = "ColImagen"
        dgvImagenes.Columns(14).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvImagenes.Columns.Item(14).HeaderText = "CodIncidencia"
        dgvImagenes.Columns.Item(14).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvImagenes.Columns.Item(14).Name = "CodigoIncidencia"
        dgvImagenes.Columns.Item(14).Visible = False
        dgvImagenes.Refresh()
        agregarCheckBox()

    End Sub

    Private Sub ListarImagenesPorAprobar()

        Dim codEmpaste As String = tbCodigoEmpaste.Text
        Dim codEdicion As String = tbCodigoEdicion.Text
        Dim codPagina As String = tbCodigoPagina.Text
        Dim tipo As Integer = 0

        If cbTipoDocumento.SelectedIndex() <> -1 Then
            If cbTipoDocumento.SelectedValue = "0" Then
                tipo = 0
            Else
                tipo = Convert.ToInt16(cbTipoDocumento.SelectedValue)
            End If
        End If

        dgvImagenes.DataSource = Nothing
        dgvImagenes.Columns.Clear()
        If tipo = 0 Then
            'dgvImagenes.DataSource = cPaginas.BuscarPaginaPorAprobar(1, codPagina, codEdicion, codEmpaste, tipo)
            Dim dt As DataTable = cPaginas.BuscarPaginaPorAprobar(1, codPagina, codEdicion, codEmpaste, tipo)
            lblTotal.Text = dt.Rows.Count
            TotalPaginas = Convert.ToDouble(lblTotal.Text)
            dgvImagenes.DataSource = cPaginas.Listado()
            If Not dgvImagenes.Rows.Count < TotalPaginas Then
                btnSiguiente.Visible = vbFalse
                btnAtras.Visible = vbFalse
            Else
                btnSiguiente.Visible = vbTrue
                btnAtras.Visible = vbTrue
                btnAtras.Enabled = vbFalse
                btnSiguiente.Enabled = vbTrue
            End If
        Else
            dgvImagenes.DataSource = cPaginas.BuscarPaginaPorAprobar(2, codPagina, codEdicion, codEmpaste, tipo)
        End If

        crearColumnasImagenes()
    End Sub
    Private Sub btnSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSiguiente.Click
        btnSiguiente.Enabled = cPaginas.Siguiente(TotalPaginas)
        btnAtras.Enabled = vbTrue

        If cPaginas.final > TotalPaginas Then
            lblFinal.Text = dgvImagenes.Rows.Count + cPaginas.inicio
        Else
            lblFinal.Text = cPaginas.final
        End If

        lblInicio.Text = cPaginas.inicio

    End Sub
    Private Sub btnAtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtras.Click
        Dim valor As Integer = dgvImagenes.Rows.Count
        btnAtras.Enabled = cPaginas.Atras(valor)
        btnSiguiente.Enabled = vbTrue
        lblInicio.Text = cPaginas.inicio
        lblFinal.Text = cPaginas.final
    End Sub

    Private Sub crearColumnasImagenes()
        dgvImagenes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvImagenes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgvImagenes.DefaultCellStyle.BackColor = Color.AliceBlue
        dgvImagenes.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvImagenes.Columns.Item(0).Visible = False
        dgvImagenes.Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvImagenes.Columns.Item(1).Visible = False
        dgvImagenes.Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvImagenes.Columns.Item(2).Visible = False
        dgvImagenes.Columns.Item(2).Name = "Tipo"
        dgvImagenes.Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvImagenes.Columns.Item(3).HeaderText = "Cod. identificación"
        dgvImagenes.Columns.Item(3).Name = "CodigoIdentificacion"
        dgvImagenes.Columns.Item(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvImagenes.Columns(4).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvImagenes.Columns.Item(4).HeaderText = "N. Pág."
        dgvImagenes.Columns.Item(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvImagenes.Columns.Item(4).Visible = False
        dgvImagenes.Columns(5).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvImagenes.Columns.Item(5).HeaderText = "Pag. Tomo"
        dgvImagenes.Columns.Item(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvImagenes.Columns.Item(5).Visible = False
        dgvImagenes.Columns(6).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvImagenes.Columns.Item(6).HeaderText = "Completo"
        dgvImagenes.Columns.Item(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvImagenes.Columns.Item(6).Visible = False
        dgvImagenes.Columns(7).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvImagenes.Columns.Item(7).HeaderText = "Incompleto"
        dgvImagenes.Columns.Item(7).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvImagenes.Columns.Item(7).Visible = False
        dgvImagenes.Columns(8).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvImagenes.Columns.Item(8).HeaderText = "Roto"
        dgvImagenes.Columns.Item(8).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvImagenes.Columns.Item(8).Visible = False
        dgvImagenes.Columns(9).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvImagenes.Columns.Item(9).HeaderText = "Manchado"
        dgvImagenes.Columns.Item(9).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvImagenes.Columns.Item(9).Visible = False
        dgvImagenes.Columns(10).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvImagenes.Columns.Item(10).HeaderText = "Falta"
        dgvImagenes.Columns.Item(10).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvImagenes.Columns.Item(10).Visible = False
        dgvImagenes.Columns(11).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvImagenes.Columns.Item(11).HeaderText = "Dificultad"
        dgvImagenes.Columns.Item(11).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvImagenes.Columns.Item(11).Visible = False

        dgvImagenes.Columns(12).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvImagenes.Columns.Item(12).HeaderText = "Observaciones"
        dgvImagenes.Columns.Item(12).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        dgvImagenes.Columns.Item(12).Width = 280
        'dgvImagenes.Columns.Item(12).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

        dgvImagenes.Columns(13).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvImagenes.Columns.Item(13).HeaderText = "Imagen"
        dgvImagenes.Columns.Item(13).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvImagenes.Columns.Item(13).Name = "ColImagen"
      
        dgvImagenes.Refresh()
        agregarCheckBox()

    End Sub
    Private Sub agregarCheckBox()
        Dim ColCheckBox As New DataGridViewCheckBoxColumn
        With ColCheckBox
            .HeaderText = "Evaluar"
            .Name = "EvaluarImagen"
            .Width = 40
            .TrueValue = 1
            .FalseValue = 0
            .DefaultCellStyle.BackColor = Color.LightSteelBlue
            .DisplayIndex = 0
            .Frozen = False
            .SortMode = DataGridViewColumnSortMode.NotSortable
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
        End With
        If dgvImagenes.Columns("EvaluarImagen") Is Nothing Then
            Dim count As Integer = dgvImagenes.Columns.Count
            dgvImagenes.Columns.Add(ColCheckBox)
        Else
            dgvImagenes.Columns("EvaluarImagen").Width = 40
            Dim c As Integer = dgvImagenes.Columns.Item("EvaluarImagen").Index
            If c = 0 Then
                dgvImagenes.Columns.Remove("EvaluarImagen")
                ColCheckBox.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
                dgvImagenes.Columns.Insert(dgvImagenes.Columns.Count, ColCheckBox)
            End If
        End If

        dgvImagenes.Refresh()

    End Sub

    Private Sub dgvImagenes_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvImagenes.CellClick
        If e.RowIndex = -1 Then
            Return
        End If

        If dgvImagenes.Rows.Count > 0 Then
            If Not dgvImagenes.Columns("EvaluarImagen") Is Nothing Then
                If e.ColumnIndex = dgvImagenes.Rows(e.RowIndex).Cells("EvaluarImagen").ColumnIndex Then
                    If dgvImagenes.Rows(e.RowIndex).Cells("EvaluarImagen").Value = 1 Then
                        dgvImagenes.Rows(e.RowIndex).Cells("EvaluarImagen").Value = 0
                    Else
                        dgvImagenes.Rows(e.RowIndex).Cells("EvaluarImagen").Value = 1
                    End If
                End If
            End If
        End If

        If tipoVer = 1 Then
            
        ElseIf tipoVer = 2 Then

        End If

    End Sub

    Private Sub dgvImagenes_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvImagenes.CellDoubleClick
        If e.RowIndex = -1 Then
            If Not dgvImagenes.Columns("EvaluarImagen") Is Nothing Then
                If e.ColumnIndex = dgvImagenes.Columns("EvaluarImagen").Index And dgvImagenes.Rows.Count > 0 Then
                    If dgvImagenes.Rows(0).Cells("EvaluarImagen").Value = 1 Then
                        For i As Integer = 0 To dgvImagenes.Rows.Count - 1
                            dgvImagenes.Rows(i).Cells("EvaluarImagen").Value = 0
                        Next
                    Else
                        For i As Integer = 0 To dgvImagenes.Rows.Count - 1
                            dgvImagenes.Rows(i).Cells("EvaluarImagen").Value = 1
                        Next
                    End If
                End If
            End If
        Else
            If tipoVer = 1 Then
                If e.ColumnIndex = dgvImagenes.Columns("ColImagen").Index Then
                    Dim nombreImagen As String = ""
                    nombreImagen = dgvImagenes.Rows(e.RowIndex).Cells("ColImagen").Value
                    If nombreImagen <> "" Then
                        MostrarImagenQ(nombreImagen)
                    Else
                        MsgBox("No hay archivos asociado", MsgBoxStyle.Exclamation, "Aviso")
                    End If
                End If
            Else
                If e.ColumnIndex = dgvImagenes.Columns("ColImagen").Index Then
                    Dim nombreImagen As String = ""
                    nombreImagen = dgvImagenes.Rows(e.RowIndex).Cells("ColImagen").Value
                    If nombreImagen <> "" Then
                        MostrarImagenP(nombreImagen)
                    Else
                        MsgBox("No hay archivos asociado", MsgBoxStyle.Exclamation, "Aviso")
                    End If
                Else
                    Dim codInc As Integer = Convert.ToInt16(dgvImagenes.Rows(e.RowIndex).Cells("CodigoIncidencia").Value)
                    mostrarDatosImagenDesaprobada(codInc)
                End If
            End If
        End If
    End Sub

    Private Sub mostrarDatosImagenDesaprobada(ByVal codigoIncidencia As Integer)
        Dim QA_Incidencia As Frm_Incidencia = New Frm_Incidencia(codigoIncidencia, "IMAGEN")
        QA_Incidencia.ShowDialog()
    End Sub

    Private Sub MostrarImagenQ(ByVal nombreImagen As String)
        '***********CARPETA DE PRUEBAS LOCALES **************
        'Dim carpetaQ As String = "C:\Users\fa1juanx\Desktop\EMPASTE\carpetaQ\Diario Oficial El Peruano"

        Dim carpetaQ As String = Configuration.ConfigurationManager.AppSettings("carpetaPeruanoV")
        Dim carpetaImagen As String = getCarpetaImagenQ(nombreImagen)
        Dim ruta As String = carpetaQ & carpetaImagen & nombreImagen

        'Dim clave As New Security.SecureString()
        'clave.AppendChar("y")
        'clave.AppendChar("o")
        'clave.AppendChar("l")
        'clave.AppendChar("a")
        'clave.AppendChar("2")
        'clave.AppendChar("0")
        'clave.AppendChar("6")
        'clave.AppendChar("1")
        'clave.MakeReadOnly()

        Try
            '    If File.Exists(ruta) Then
            '        'Shell("NET USE J: \\192.168.1.100\CarpetaElegida   yola2061  /USER:nombreDelUsuario")
            '        Dim cn As String = "NET USE T: \\sw-imgdig\d$ " & Clases.Impersonation.iPass & " /USER:" & Clases.Impersonation.iUsuario
            '        Shell(cn)
            '        Process.Start(ruta) ', "mcafee", clave, "editoraperu.msft")
            '        Shell("net use T: /delete")
            Process.Start(ruta)
            '    Else
            '        MessageBox.Show("No existe la imagen seleccionada: " & ruta, "Alerta Imagen", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    End If
        Catch ex As Exception
            MessageBox.Show("No se puede mostrar la imagen seleccionada" & vbNewLine &
                            ruta, "Alerta Imagen", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try


    End Sub

    Private Sub MostrarImagenP(ByVal nombreImagen As String)
        Dim carpetaP As String = Configuration.ConfigurationManager.AppSettings("carpetaP")
        Dim carpetaImagen As String = getCarpetaImagenP(nombreImagen)
        Dim ruta As String = carpetaP & carpetaImagen & nombreImagen

        Try
            If File.Exists(ruta) Then
                Process.Start(ruta)
            Else
                MessageBox.Show("No existe la imagen seleccionada: " & ruta, "Alerta Imagen", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            MessageBox.Show("No se puede mostrar la imagen seleccionada", "Alerta Imagen", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
        
    End Sub

    Private Function getCarpetaImagenQ(ByVal nombreImagen As String) As String
        Dim carpetaAnio As String = nombreImagen.Substring(0, 4)
        Dim carpetaTomo As String = "TOMO-" & nombreImagen.Substring(18, 2)
        Dim carpetaEdicion As String = nombreImagen.Substring(0, 8) & nombreImagen.Substring(20, 5)

        Dim carpetaImagen As String = carpetaAnio & "\" & carpetaTomo & "\" & carpetaEdicion & "\"

        Return carpetaImagen
    End Function

    Private Sub btnAprobar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAprobar.Click
        Dim FrmCondicional As MsgBoxResult = MsgBox("Aprobar todas las Imagenes seleccionadas?", MsgBoxStyle.YesNo, "Aviso")
        If FrmCondicional <> MsgBoxResult.Yes Then
            Return
        End If

        Dim arrayCodTipNom As New ArrayList
        Dim codigo As String
        Dim tipo As String
        Dim nombre As String
        If dgvImagenes.Rows.Count > 0 Then
            If Not dgvImagenes.Columns("EvaluarImagen") Is Nothing Then
                For i As Integer = 0 To dgvImagenes.Rows.Count - 1
                    If dgvImagenes.Rows(i).Cells("EvaluarImagen").Value = 1 Then
                        codigo = dgvImagenes.Rows(i).Cells("CodigoIdentificacion").Value
                        tipo = dgvImagenes.Rows(i).Cells("Tipo").Value
                        nombre = dgvImagenes.Rows(i).Cells("ColImagen").Value
                        arrayCodTipNom.Add(codigo & "," & tipo & "," & nombre)
                    End If
                Next
            End If
            If arrayCodTipNom.Count > 0 Then
                AprobarImagenes(arrayCodTipNom)
                MsgBox("Imagenes Aprobadas Correctamente", MsgBoxStyle.Exclamation, "Aviso")
            Else
                MessageBox.Show("No hay imagenes seleccionadas", "Alerta Imagen", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub
    Private Sub AprobarImagenes(ByVal arrayCodigos As ArrayList)
        Dim codigo As String
        Dim tipo As Integer
        Dim nombre As String
        Dim datos As Array

        Dim cPagina As New Clases.C_Paginas

        For Each codtipnom As String In arrayCodigos
            datos = codtipnom.Split(",")
            codigo = datos(0).ToString()
            tipo = Convert.ToInt16(datos(1).ToString())
            nombre = datos(2).ToString()

            Try
                pasarImagenR(nombre)
                cPagina.PasarPaginasFinal(codigo, tipo, Frm_Principal.datosUsuario)
            Catch ex As Exception
                MsgBox("Error al aprobar las imagenes seleccionadas", MsgBoxStyle.Exclamation, "Aviso")
            End Try
        Next
        ListarImagenesPorAprobar()
    End Sub
    Private Sub pasarImagenR(ByVal nombreImagen As String)
        Dim carpetaQ As String = Configuration.ConfigurationManager.AppSettings("carpetaPeruano")
        Dim carpetaR As String = Configuration.ConfigurationManager.AppSettings("carpetaR")
        Dim carpetaImagenQ As String = getCarpetaImagenQ(nombreImagen)
        Dim carpetaImagenR As String = getCarpetaImagenR(nombreImagen)
        Dim imgQ As String = ""
        Dim imgR As String = ""

        aArchivos.Inic(Clases.DatosConexion.dominio, Clases.DatosConexion.usuario, Clases.DatosConexion.clave)
        lErrorConexionRed = aArchivos.RedConectar(carpetaRaiz)

        If Not Directory.Exists(carpetaR & carpetaImagenR) Then
            Try
                Directory.CreateDirectory(carpetaR & carpetaImagenR)
            Catch ex As Exception
                Throw ex
            End Try
        End If

        imgQ = carpetaQ & carpetaImagenQ & nombreImagen
        imgR = carpetaR & carpetaImagenR & nombreImagen
        If File.Exists(imgQ) Then
            If File.Exists(imgR) Then
                My.Computer.FileSystem.DeleteFile(imgR)
            End If
            File.Move(imgQ, imgR)
            'File.Copy(imgQ, imgR, True)
        End If

        aArchivos.RedDesconectar(carpetaRaiz)
    End Sub

    Private Function getCarpetaImagenR(ByVal nombreImagen) As String
        Dim carpetaR As String = ""
        Dim carpetaUbicacion = "JPG -FINAL"
        Dim carpetaAnio As String = nombreImagen.Substring(0, 4)
        Dim carpetaTomo As String = "TOMO-" & nombreImagen.Substring(18, 2)
        Dim carpetaEdicion As String = nombreImagen.Substring(0, 8) & nombreImagen.Substring(20, 5)
        carpetaR = carpetaUbicacion & "\" & carpetaAnio & "\" & carpetaTomo & "\" & carpetaEdicion & "\"

        Return carpetaR
    End Function

    Private Sub btnDesaprobar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDesaprobar.Click
        Dim FrmCondicional As MsgBoxResult = MsgBox("Desaprobar todas las Imagenes seleccionadas?", MsgBoxStyle.YesNo, "Aviso")
        If FrmCondicional <> MsgBoxResult.Yes Then
            Return
        End If
        Dim arrayCodTipNom As ArrayList = getArrayDatosSeleccionados()
        If arrayCodTipNom.Count > 0 Then
            DesaprobarImagenes(arrayCodTipNom)
            MsgBox("Imagenes Desaprobadas Correctamente", MsgBoxStyle.Exclamation, "Aviso")
        Else
            MessageBox.Show("No hay imagenes seleccionadas", "Alerta Imagen", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
    Private Function getArrayDatosSeleccionados() As ArrayList
        Dim arrayCodTipNom As New ArrayList
        Dim codigo As String
        Dim tipo As String
        Dim nombre As String
        If dgvImagenes.Rows.Count > 0 Then
            If Not dgvImagenes.Columns("EvaluarImagen") Is Nothing Then
                For i As Integer = 0 To dgvImagenes.Rows.Count - 1
                    If dgvImagenes.Rows(i).Cells("EvaluarImagen").Value = 1 Then
                        codigo = dgvImagenes.Rows(i).Cells("CodigoIdentificacion").Value
                        tipo = dgvImagenes.Rows(i).Cells("Tipo").Value
                        nombre = dgvImagenes.Rows(i).Cells("ColImagen").Value
                        arrayCodTipNom.Add(codigo & "," & tipo & "," & nombre)
                    End If
                Next
            End If
        End If
        Return arrayCodTipNom
    End Function
    Private Sub DesaprobarImagenes(ByVal arrayCodTipNombre As ArrayList)
        Dim codigo As String
        Dim tipo As Integer
        Dim nombre As String
        Dim datos As Array

        Dim cPagina As New Clases.C_Paginas

        Dim frmIncidencia As New Frm_Incidencia("IMAGEN")

        frmIncidencia.ShowDialog()

        Dim incid As String = frmIncidencia.getIncidencia()
        Dim desc As String = frmIncidencia.getDescripcion()
        Dim est As Integer = frmIncidencia.getEstado()

        If est = 1 Then
            For Each codtipnom As String In arrayCodTipNombre
                datos = codtipnom.Split(",")
                codigo = datos(0).ToString()
                tipo = Convert.ToInt16(datos(1).ToString())
                nombre = datos(2).ToString()

                Try
                    pasarImagenP(nombre)
                    cPagina.PasarPaginasReproceso(codigo, tipo, incid, desc, Frm_Principal.datosUsuario)
                Catch ex As Exception
                    MsgBox("Error al aprobar las imagenes seleccionadas", MsgBoxStyle.Exclamation, "Aviso")
                End Try
            Next
            ListarImagenesPorAprobar()
        End If

    End Sub
    Private Sub pasarImagenP(ByVal nombreImagen As String)
        Dim carpetaQ As String = Configuration.ConfigurationManager.AppSettings("carpetaPeruano")
        Dim carpetaP As String = Configuration.ConfigurationManager.AppSettings("carpetaP")
        Dim carpetaImagenQ As String = getCarpetaImagenQ(nombreImagen)
        Dim carpetaImagenP As String = getCarpetaImagenP(nombreImagen)
        Dim imgQ As String = ""
        Dim imgP As String = ""

        aArchivos.Inic(Clases.DatosConexion.dominio, Clases.DatosConexion.usuario, Clases.DatosConexion.clave)
        lErrorConexionRed = aArchivos.RedConectar(carpetaRaiz)

        If Not Directory.Exists(carpetaP & carpetaImagenP) Then
            Directory.CreateDirectory(carpetaP & carpetaImagenP)
        End If

        imgQ = carpetaQ & carpetaImagenQ & nombreImagen
        imgP = carpetaP & carpetaImagenP & nombreImagen
        If File.Exists(imgQ) Then
            'File.Copy(imgQ, imgP, True)
            If File.Exists(imgP) Then
                My.Computer.FileSystem.DeleteFile(imgP)
            End If
            File.Move(imgQ, imgP)
        End If

        aArchivos.RedDesconectar(carpetaRaiz)
    End Sub
    Private Function getCarpetaImagenP(ByVal nombreImagen As String) As String
        Dim carpetaAnio As String = nombreImagen.Substring(0, 4)
        Dim carpetaTomo As String = "TOMO-" & nombreImagen.Substring(18, 2)
        Dim carpetaEdicion As String = nombreImagen.Substring(0, 8) & nombreImagen.Substring(20, 5)

        Dim carpetaImagen As String = carpetaAnio & "\" & carpetaTomo & "\" & carpetaEdicion & "\"

        Return carpetaImagen
    End Function

    Private Sub btnPasarQA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPasarQA.Click
        Dim arrCodiNombTipoInci As ArrayList = obetenerCodiNombTipoInciSeleccionados()

        Try
            If dgvImagenes.Rows.Count > 0 Then
                pasarImagenesQA(arrCodiNombTipoInci)
                ListarImagenesDesaprobadas()
                MessageBox.Show("Imagenes pasadas a QA correctamente", "Alerta Imagen", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                MessageBox.Show("No hay imagenes seleccionadas", "Alerta Imagen", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            
        Catch ex As Exception
            MessageBox.Show("Error al pasar imagenes a QA", "Alerta Imagen", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
        
    End Sub

    Private Function obetenerCodiNombTipoInciSeleccionados() As ArrayList
        Dim arrCodigoNombreTipoInci As ArrayList = New ArrayList

        If dgvImagenes.Rows.Count > 0 Then
            For i As Integer = 0 To dgvImagenes.Rows.Count - 1
                If dgvImagenes.Rows(i).Cells("EvaluarImagen").Value = 1 Then
                    If dgvImagenes.Rows(i).Cells("ColImagen").Value <> "" Then
                        arrCodigoNombreTipoInci.Add(dgvImagenes.Rows(i).Cells("CodigoIdentificacion").Value & "," & dgvImagenes.Rows(i).Cells("ColImagen").Value & "," & dgvImagenes.Rows(i).Cells("Tipo").Value & "," & dgvImagenes.Rows(i).Cells("CodigoIncidencia").Value)
                    Else
                        MessageBox.Show("La página " & dgvImagenes.Rows(i).Cells("CodigoIdentificacion").Value & " no tiene imagen", "Alerta Imagen", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                End If
            Next
        End If

        Return arrCodigoNombreTipoInci
    End Function

    Private Sub pasarImagenesQA(ByVal arrCodiNombTipoInci As ArrayList)
        Dim carpetaP As String = Configuration.ConfigurationManager.AppSettings("carpetaP")
        Dim carpetaQ As String = Configuration.ConfigurationManager.AppSettings("carpetaPeruano")
        Dim carpetaImagen_P As String
        Dim carpetaImagen_Q As String
        Dim imgP As String = ""
        Dim imgQ As String = ""
        Dim cod As String = ""
        Dim nom As String = ""
        Dim tipo As Integer
        Dim codInc As Integer
        Dim dato As Array

        Dim cPagina As New Clases.C_Paginas

        aArchivos.Inic(Clases.DatosConexion.dominio, Clases.DatosConexion.usuario, Clases.DatosConexion.clave)
        lErrorConexionRed = aArchivos.RedConectar(carpetaRaiz)

        For Each codnomtip As String In arrCodiNombTipoInci
            dato = codnomtip.Split(",")
            cod = dato(0).ToString()
            nom = dato(1).ToString()
            tipo = Convert.ToInt16(dato(2).ToString())
            codInc = Convert.ToInt16(dato(3).ToString())

            carpetaImagen_P = getCarpetaImagenP(nom)
            carpetaImagen_Q = getCarpetaImagenQ(nom)

            imgP = carpetaP & carpetaImagen_P & nom
            If File.Exists(imgP) Then
                imgQ = carpetaQ & carpetaImagen_Q & nom
                'File.Copy(imgP, imgQ, True)
                If File.Exists(imgQ) Then
                    My.Computer.FileSystem.DeleteFile(imgQ)
                End If
                File.Move(imgP, imgQ)
                cPagina.PasarPaginasQA(2, cod, tipo, codInc, Frm_Principal.datosUsuario)
            Else
                MessageBox.Show("No existe la imagen: " & imgP, "Alerta PDF", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Next

        aArchivos.RedDesconectar(carpetaRaiz)
    End Sub

  
    
  
    
End Class