Imports System.IO

Public Class Frm_QAPDFs
    Private tipoVer As Integer = 0
    Dim estadoCheck As Integer = 1

    Dim aArchivos As New Clases.AccesoArchivos()
    Dim lErrorConexionRed As Long
    Dim carpetaRaiz As String = Configuration.ConfigurationManager.AppSettings("carpetaRaiz")

    Public Sub New(ByVal tipo As Integer)
        MyBase.New()
        tipoVer = tipo
        InitializeComponent()
        If tipoVer = 1 Then
            Me.Text = "QA - PDFs para aprobar"
        Else
            Me.Text = "QA - PDFs desaprobados"
        End If
    End Sub

    Private Sub Frm_QAPDFs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenarTiposDocumento()

        If tipoVer = 1 Then
            ListarPdfsPorAprobar()
        ElseIf tipoVer = 2 Then
            ListarPdfsDesaprobados()
        End If

        mostrarBotones()
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
    End Sub

    Private Sub ListarPdfsPorAprobar()
        Dim cEdicion As New Clases.C_Edicion
        Dim codEmpaste As String = tbCodigoEmpaste.Text
        Dim codEdicion As String = tbCodigoEdicion.Text
        Dim tipo As Integer = 0

        If cbTipoDocumento.SelectedIndex() <> -1 Then
            If cbTipoDocumento.SelectedValue = "0" Then
                tipo = 0
            Else
                tipo = Convert.ToInt16(cbTipoDocumento.SelectedValue)
            End If
        End If

        dgvPDFs.DataSource = Nothing
        dgvPDFs.Columns.Clear()


        If tipo = 0 Then
            dgvPDFs.DataSource = cEdicion.BuscarPdfPorAprobar(1, codEdicion, codEmpaste, tipo)
        Else
            dgvPDFs.DataSource = cEdicion.BuscarPdfPorAprobar(2, codEdicion, codEmpaste, tipo)
        End If

        crearColumnasPDFsPorAprobar()
    End Sub

    Private Sub crearColumnasPDFsPorAprobar()

        dgvPDFs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        'dgvPDFs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvPDFs.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

        dgvPDFs.DefaultCellStyle.BackColor = Color.AliceBlue
        dgvPDFs.Columns.Item(0).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvPDFs.Columns.Item(0).HeaderText = "Cod. Empaste"
        dgvPDFs.Columns.Item(0).Visible = False
        dgvPDFs.Columns.Item(1).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvPDFs.Columns.Item(1).HeaderText = "Cod. Edición"
        dgvPDFs.Columns.Item(1).Name = "CodigoEdicion"
        dgvPDFs.Columns.Item(1).Visible = True
        dgvPDFs.Columns.Item(1).Width = 60
        dgvPDFs.Columns.Item(2).Visible = False
        dgvPDFs.Columns.Item(2).Name = "Tipo"
        dgvPDFs.Columns.Item(3).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvPDFs.Columns.Item(3).HeaderText = "Tipo"
        dgvPDFs.Columns.Item(3).Visible = True
        dgvPDFs.Columns.Item(3).Width = 30
        dgvPDFs.Columns.Item(4).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvPDFs.Columns.Item(4).HeaderText = "N. de Edición"
        dgvPDFs.Columns.Item(4).Visible = False
        dgvPDFs.Columns.Item(4).Width = 15
        dgvPDFs.Columns.Item(5).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvPDFs.Columns.Item(5).HeaderText = "N. de Paginas"
        dgvPDFs.Columns.Item(6).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvPDFs.Columns.Item(6).HeaderText = "Fec. Edicion"
        dgvPDFs.Columns.Item(6).Width = 60
        'DataGridViewAutoSizeColumnMode.ColumnHeader()
        dgvPDFs.Columns.Item(7).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvPDFs.Columns.Item(7).HeaderText = "Director"
        dgvPDFs.Columns.Item(8).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvPDFs.Columns.Item(8).HeaderText = "Pag. Faltantes"
        dgvPDFs.Columns.Item(8).Visible = False
        dgvPDFs.Columns.Item(9).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvPDFs.Columns.Item(9).HeaderText = "Bueno"
        dgvPDFs.Columns.Item(9).Visible = False
        dgvPDFs.Columns.Item(10).Visible = False
        dgvPDFs.Columns.Item(11).Visible = False
        dgvPDFs.Columns.Item(12).Visible = False
        dgvPDFs.Columns.Item(13).Visible = False
        dgvPDFs.Columns.Item(14).Visible = True
        dgvPDFs.Columns.Item(14).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvPDFs.Columns.Item(14).HeaderText = "PDF"
        dgvPDFs.Columns.Item(14).Name = "colPDF"
        dgvPDFs.Columns.Item(15).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvPDFs.Columns.Item(15).HeaderText = "Estado"
        dgvPDFs.Columns.Item(15).Name = "colEstado"
        dgvPDFs.Columns.Item(15).Visible = False
        dgvPDFs.Refresh()
        agregarCheckBox()

    End Sub

    Private Sub agregarCheckBox()
        Dim ColCheckBox As New DataGridViewCheckBoxColumn
        With ColCheckBox
            .HeaderText = "Evaluar"
            .Name = "EvaluarPDF"
            .TrueValue = 1
            .FalseValue = 0
            .DefaultCellStyle.BackColor = Color.LightSteelBlue
            .DisplayIndex = 0
            .Frozen = False
            .SortMode = DataGridViewColumnSortMode.NotSortable
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            .Width = 30
        End With
        If dgvPDFs.Columns("EvaluarPDF") Is Nothing Then
            Dim count As Integer = dgvPDFs.Columns.Count
            dgvPDFs.Columns.Add(ColCheckBox)
        Else
            dgvPDFs.Columns("EvaluarPDF").Width = 40
            Dim c As Integer = dgvPDFs.Columns.Item("EvaluarPDF").Index
            If c = 0 Then
                dgvPDFs.Columns.Remove("EvaluarPDF")
                ColCheckBox.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
                dgvPDFs.Columns.Insert(dgvPDFs.Columns.Count, ColCheckBox)
            End If
        End If

        dgvPDFs.Refresh()

    End Sub

    Private Sub ListarPdfsDesaprobados()
        Dim cEdiciones As New Clases.C_Edicion
        Dim codEmpaste As String = tbCodigoEmpaste.Text
        Dim codEdicion As String = tbCodigoEdicion.Text

        Dim tipo As Integer = 0
        If cbTipoDocumento.SelectedIndex() <> -1 Then
            If cbTipoDocumento.SelectedValue = "0" Then
                tipo = 0
            Else
                tipo = Convert.ToInt16(cbTipoDocumento.SelectedValue)
            End If
        End If

        dgvPDFs.DataSource = Nothing
        dgvPDFs.Columns.Clear()
        If tipo = 0 Then
            dgvPDFs.DataSource = cEdiciones.BuscarPdfPorAprobar(3, codEdicion, codEmpaste, tipo)
        Else
            dgvPDFs.DataSource = cEdiciones.BuscarPdfPorAprobar(4, codEdicion, codEmpaste, tipo)
        End If

        crearColumnasPDFsDesaprobados()
    End Sub

    Private Sub crearColumnasPDFsDesaprobados()

        'dgvPDFs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvPDFs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvPDFs.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgvPDFs.DefaultCellStyle.BackColor = Color.AliceBlue
        dgvPDFs.Columns.Item(0).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvPDFs.Columns.Item(0).HeaderText = "Cod. Empaste"
        dgvPDFs.Columns.Item(0).Visible = False
        dgvPDFs.Columns.Item(1).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvPDFs.Columns.Item(1).HeaderText = "Cod. Edición"
        dgvPDFs.Columns.Item(1).Name = "CodigoEdicion"
        dgvPDFs.Columns.Item(1).Visible = True
        'dgvPDFs.Columns.Item(1).Width = 60
        dgvPDFs.Columns.Item(2).Visible = False
        dgvPDFs.Columns.Item(2).Name = "Tipo"
        dgvPDFs.Columns.Item(3).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvPDFs.Columns.Item(3).HeaderText = "Tipo"
        dgvPDFs.Columns.Item(3).Visible = True
        dgvPDFs.Columns.Item(4).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvPDFs.Columns.Item(4).HeaderText = "N. de Edición"
        dgvPDFs.Columns.Item(4).Visible = False
        dgvPDFs.Columns.Item(5).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvPDFs.Columns.Item(5).HeaderText = "N. de Paginas"
        dgvPDFs.Columns.Item(6).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvPDFs.Columns.Item(6).HeaderText = "Fec. Edicion"
        dgvPDFs.Columns.Item(7).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvPDFs.Columns.Item(7).HeaderText = "Director"
        dgvPDFs.Columns.Item(8).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvPDFs.Columns.Item(8).HeaderText = "Pag. Faltantes"
        dgvPDFs.Columns.Item(8).Visible = False
        dgvPDFs.Columns.Item(9).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvPDFs.Columns.Item(9).HeaderText = "Bueno"
        dgvPDFs.Columns.Item(9).Visible = False
        dgvPDFs.Columns.Item(10).Visible = False
        dgvPDFs.Columns.Item(11).Visible = False
        dgvPDFs.Columns.Item(12).Visible = False
        dgvPDFs.Columns.Item(13).Visible = False
        dgvPDFs.Columns.Item(14).Visible = True
        dgvPDFs.Columns.Item(14).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvPDFs.Columns.Item(14).HeaderText = "PDF"
        dgvPDFs.Columns.Item(14).Name = "colPDF"
        'dgvPDFs.Columns.Item(14).Width = 200

        dgvPDFs.Columns.Item(15).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvPDFs.Columns.Item(15).HeaderText = "Estado"
        dgvPDFs.Columns.Item(15).Name = "colEstado"
        dgvPDFs.Columns.Item(15).Visible = False

        dgvPDFs.Columns.Item(16).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvPDFs.Columns.Item(16).HeaderText = "CodIncidencia"
        dgvPDFs.Columns.Item(16).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvPDFs.Columns.Item(16).Name = "CodigoIncidencia"
        dgvPDFs.Columns.Item(16).Visible = False

        'dgvPDFs.Columns.Item(16).SortMode = DataGridViewColumnSortMode.NotSortable
        'dgvPDFs.Columns.Item(16).HeaderText = "DescripcionEstado"
        'dgvPDFs.Columns.Item(16).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        'dgvPDFs.Columns.Item(16).Name = "DescripcionEstado"
        'dgvPDFs.Columns.Item(16).Visible = False


        dgvPDFs.Refresh()
        agregarCheckBox()


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

    Private Sub dgvPDFs_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPDFs.CellClick
        If e.RowIndex = -1 Then
            Return
        End If

        If dgvPDFs.Rows.Count > 0 Then
            If Not dgvPDFs.Columns("EvaluarPDF") Is Nothing Then
                If e.ColumnIndex = dgvPDFs.Rows(e.RowIndex).Cells("EvaluarPDF").ColumnIndex Then
                    If dgvPDFs.Rows(e.RowIndex).Cells("EvaluarPDF").Value = 1 Then
                        dgvPDFs.Rows(e.RowIndex).Cells("EvaluarPDF").Value = 0
                    Else
                        dgvPDFs.Rows(e.RowIndex).Cells("EvaluarPDF").Value = 1
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub dgvPDFs_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPDFs.CellDoubleClick
        If e.RowIndex = -1 Then
            If Not dgvPDFs.Columns("EvaluarPDF") Is Nothing Then
                If e.ColumnIndex = dgvPDFs.Columns("EvaluarPDF").Index And dgvPDFs.Rows.Count > 0 Then
                    For i As Integer = 0 To dgvPDFs.Rows.Count - 1
                        dgvPDFs.Rows(i).Cells("EvaluarPDF").Value = estadoCheck
                    Next
                    If estadoCheck = 1 Then
                        estadoCheck = 0
                    Else
                        estadoCheck = 1
                    End If
                End If
            End If
        Else
            Dim nombrePDF As String = ""

            If tipoVer = 1 Then
                If e.ColumnIndex = dgvPDFs.Columns("colPDF").Index Then
                    nombrePDF = dgvPDFs.Rows(e.RowIndex).Cells("colPDF").Value
                    If nombrePDF <> "" Then
                        MostrarPDFQ(nombrePDF)
                    Else
                        MsgBox("No hay archivos asociado", MsgBoxStyle.Exclamation, "Aviso")
                    End If
                End If
            Else
                If e.ColumnIndex = dgvPDFs.Columns("ColPDF").Index Then
                    nombrePDF = dgvPDFs.Rows(e.RowIndex).Cells("ColPDF").Value
                    If nombrePDF <> "" Then
                        MostrarPDFP(nombrePDF)
                    Else
                        MsgBox("No hay archivos asociado", MsgBoxStyle.Exclamation, "Aviso")
                    End If
                Else
                    Dim codInc As Integer = Convert.ToInt16(dgvPDFs.Rows(e.RowIndex).Cells("CodigoIncidencia").Value)
                    mostrarDatosPDFDesaprobado(codInc)
                End If
            End If
        End If
    End Sub

    Private Sub MostrarPDFQ(ByVal nombrePDF As String)
        '***********CARPETA DE PRUEBAS LOCALES **************
        'Dim carpetaQ As String = "C:\Users\fa1juanx\Desktop\EMPASTE\carpetaQ\Diario Oficial El Peruano\"

        Dim carpetaQ As String = Configuration.ConfigurationManager.AppSettings("carpetaPeruanoV")
        Dim carpetaImagen As String = getCarpetaPDFQ(nombrePDF)
        Dim ruta As String = carpetaQ & carpetaImagen & nombrePDF
        Try
            'If File.Exists(ruta) Then
            Process.Start(ruta)
            'Else
            'MessageBox.Show("No existe el PDF seleccionado: " & ruta, "Alerta PDF", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'End If
        Catch ex As Exception
            MessageBox.Show("No se puede mostrar el pdf seleccionado" & vbNewLine &
                            ruta, "Alerta Imagen", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub

    Private Sub MostrarPDFP(ByVal nombrePDF As String)
        Dim carpetaP As String = Configuration.ConfigurationManager.AppSettings("carpetaP")
        Dim carpetaImagen As String = getCarpetaPDFP(nombrePDF)
        Dim ruta As String = carpetaP & carpetaImagen & nombrePDF

        Try
            If File.Exists(ruta) Then
                Process.Start(ruta)
            Else
                MessageBox.Show("No existe el PDF seleccionado: " & ruta, "Alerta PDF", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            MessageBox.Show("No se puede mostrar el PDF seleccionado", "Alerta PDF", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
        
    End Sub

    Private Sub mostrarDatosPDFDesaprobado(ByVal codigoIncidencia As Integer)
        Dim QA_Incidencia As Frm_Incidencia = New Frm_Incidencia(codigoIncidencia, "PDF")
        QA_Incidencia.ShowDialog()
    End Sub

    Private Function getCarpetaPDFQ(ByVal nombrePDF As String) As String
        Dim carpetaAnio As String = nombrePDF.Substring(0, 4)
        Dim carUbicacion As String = "Ediciones PDF Corregidas" & "\"
        Dim carpetaEdicion As String = nombrePDF.Substring(0, 4) & " PDF"

        Dim carpetaPDF As String = carUbicacion & carpetaEdicion & "\"

        Return carpetaPDF
    End Function

    Private Function getCarpetaPDFP(ByVal nombrePDF As String) As String
        Dim carpetaAnio As String = nombrePDF.Substring(0, 4)


        Dim carpetaPDF As String = carpetaAnio & " PDF\"

        Return carpetaPDF
    End Function

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If tipoVer = 1 Then
            ListarPdfsPorAprobar()
        Else
            ListarPdfsDesaprobados()
        End If
    End Sub

    Private Sub btnAprobar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAprobar.Click
        Dim FrmCondicional As MsgBoxResult = MsgBox("Aprobar todos los PDFs seleccionados?", MsgBoxStyle.YesNo, "Aviso")
        If FrmCondicional <> MsgBoxResult.Yes Then
            Return
        End If

        Dim arrayCodTipNom As New ArrayList
        Dim codigo As String
        Dim tipo As String
        Dim nombre As String
        If dgvPDFs.Rows.Count > 0 Then
            If Not dgvPDFs.Columns("EvaluarPDF") Is Nothing Then
                For i As Integer = 0 To dgvPDFs.Rows.Count - 1
                    If dgvPDFs.Rows(i).Cells("EvaluarPDF").Value = 1 Then
                        codigo = dgvPDFs.Rows(i).Cells("CodigoEdicion").Value
                        tipo = dgvPDFs.Rows(i).Cells("Tipo").Value
                        nombre = dgvPDFs.Rows(i).Cells("colPDF").Value
                        arrayCodTipNom.Add(codigo & "," & tipo & "," & nombre)
                    End If
                Next
            End If
            If arrayCodTipNom.Count > 0 Then

                PasarPdfsSinPhotoshoop(arrayCodTipNom)
                AprobarPDFs(arrayCodTipNom)

                MsgBox("PDFs Aprobados Correctamente", MsgBoxStyle.Exclamation, "Aviso")

            Else
                MessageBox.Show("No hay PDFs seleccionados", "Alerta PDF", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

    Public Sub PasarPdfsSinPhotoshoop(ByVal arreglo As ArrayList)

        Dim pdfP As String = ""
        Dim pdfR As String = ""
        Dim codigo As String = ""
        Dim nombre As String = ""
        Dim tipo As String = ""
        Dim año As String = ""

        For Each x As String In arreglo
            Dim arr As Array = x.Split(",")
            codigo = arr(0).ToString
            tipo = arr(1).ToString
            nombre = arr(2).ToString
            año = nombre.Substring(0, 4)
        Next

        Dim carpetaP As String = Configuration.ConfigurationManager.AppSettings("carpetaP")
        Dim carpetaR As String = Configuration.ConfigurationManager.AppSettings("carpetaR")

        Dim carpeta_PDFP As String = año & "\" & año & " PDF\"
        Dim carpeta_PDFR As String = "PDF -FINAL\" & año & " PDF\"

        aArchivos.Inic(Clases.DatosConexion.dominio, Clases.DatosConexion.usuario, Clases.DatosConexion.clave)
        lErrorConexionRed = aArchivos.RedConectar(carpetaRaiz)

        pdfP = carpetaP & carpeta_PDFP & nombre
        pdfR = carpetaR & carpeta_PDFR & nombre

        If File.Exists(pdfP) Then

            If Not Directory.Exists(carpetaR & carpeta_PDFR) Then
                Directory.CreateDirectory(carpetaR & carpeta_PDFR)
            End If

            If File.Exists(pdfR) Then
                My.Computer.FileSystem.DeleteFile(pdfR)
            End If

            File.Move(pdfP, pdfR)

        End If

        aArchivos.RedDesconectar(carpetaRaiz)

    End Sub

    Private Sub AprobarPDFs(ByVal arrayCodigos As ArrayList)
        Dim codigo As String
        Dim tipo As Integer
        Dim nombre As String
        Dim datos As Array

        Dim cEdicion As New Clases.C_Edicion

        For Each codtipnom As String In arrayCodigos
            datos = codtipnom.Split(",")
            codigo = datos(0)
            tipo = Convert.ToInt16(datos(1).ToString())
            nombre = datos(2).ToString()

            Try
                pasarPDFR(nombre)
                cEdicion.PasarEdicionesFinal(codigo, tipo, Frm_Principal.datosUsuario)
                ListarPdfsPorAprobar()
            Catch ex As Exception
                MsgBox("Error al aprobar los PDFs seleccionados", MsgBoxStyle.Exclamation, "Aviso")
            End Try
        Next

    End Sub

    Private Sub pasarPDFR(ByVal nombrePDF As String)
        Dim carpetaP As String = Configuration.ConfigurationManager.AppSettings("carpetaP")
        Dim carpetaQ As String = Configuration.ConfigurationManager.AppSettings("carpetaPeruano")
        Dim carpetaR As String = Configuration.ConfigurationManager.AppSettings("carpetaR")
        Dim carpetaPDFP As String = getCarpetaPDFP(nombrePDF)
        Dim carpetaPDFQ As String = getCarpetaPDFQ(nombrePDF)
        Dim carpetaPDFR As String = getCarpetaPDFR(nombrePDF)
        Dim pdfQ As String = ""
        Dim pdfR As String = ""
        Dim pdfP As String = ""

        aArchivos.Inic(Clases.DatosConexion.dominio, Clases.DatosConexion.usuario, Clases.DatosConexion.clave)
        lErrorConexionRed = aArchivos.RedConectar(carpetaRaiz)

        If Not Directory.Exists(carpetaR & carpetaPDFR) Then
            Directory.CreateDirectory(carpetaR & carpetaPDFR)
        End If

        pdfP = carpetaP & carpetaPDFP & nombrePDF
        pdfQ = carpetaQ & carpetaPDFQ & nombrePDF
        pdfR = carpetaR & carpetaPDFR & nombrePDF
        If File.Exists(pdfQ) Then
            If File.Exists(pdfR) Then
                My.Computer.FileSystem.DeleteFile(pdfR)
            End If
            File.Move(pdfQ, pdfR)
            'File.Move(pdfP, pdfR)
        End If

        aArchivos.RedDesconectar(carpetaRaiz)
    End Sub

    Private Function getCarpetaPDFR(ByVal nombrePDF) As String
        Dim carUbicacion = "PDF -FINAL" & "\" & "PDF-Corregida PHOTOSHOP"
        Dim carpetaR As String = ""
        Dim carpetaAnio As String = nombrePDF.Substring(0, 4)
        Dim carpetaEdicion As String = nombrePDF.Substring(0, 4) & " PDF "
        carpetaR = carUbicacion & "\" & carpetaEdicion & "\"
        Return carpetaR
    End Function

    Private Sub btnDesaprobar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDesaprobar.Click

        Dim FrmCondicional As MsgBoxResult = MsgBox(" Esta seguro de Desaprobar todos los PDFs seleccionados?", MsgBoxStyle.YesNo, "Aviso")
        If FrmCondicional <> MsgBoxResult.Yes Then
            Return
        End If

        Dim arrayCodTipNom As ArrayList = getArrayDatosSeleccionados()
        If arrayCodTipNom.Count > 0 Then
            Dim r As Integer
            r = DesaprobarPDFs(arrayCodTipNom)
            If r = 1 Then
                MsgBox("PDFs Desaprobados Correctamente", MsgBoxStyle.Exclamation, "Aviso")
            End If
        Else
            MessageBox.Show("No hay PDFs seleccionados", "Alerta PDF", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
    Private Sub pasarPDFsP(ByVal nombre As String)
        Dim carpetaP As String = Configuration.ConfigurationManager.AppSettings("carpetaP")
        Dim carpetaQ As String = Configuration.ConfigurationManager.AppSettings("carpetaPeruano")
        Dim carpetaPDF_P As String = getCarpetaPDFP(nombre)
        Dim carpetaPDF_Q As String = getCarpetaPDFQ(nombre)
        Dim pdfP As String = ""
        Dim pdfQ As String = ""

        aArchivos.Inic(Clases.DatosConexion.dominio, Clases.DatosConexion.usuario, Clases.DatosConexion.clave)
        lErrorConexionRed = aArchivos.RedConectar(carpetaRaiz)

        If Not Directory.Exists(carpetaP & carpetaPDF_P) Then
            Directory.CreateDirectory(carpetaP & carpetaPDF_P)
        End If

        pdfP = carpetaP & carpetaPDF_P & nombre
        pdfQ = carpetaQ & carpetaPDF_Q & nombre

        If File.Exists(pdfQ) Then
            File.Move(pdfQ, pdfP)
        End If
        aArchivos.RedDesconectar(carpetaRaiz)

    End Sub
    '  Private Function getCarpetaPDFQ() As String
    'Dim carAnio As String = Me.TxtCodIdentificacion.Text.Substring(4, 4)
    ' Dim carUbicacion As String = "Ediciones PDF" & "\"
    ' Dim carPDF As String = carAnio & " PDF"

    ' Dim carpetaPDFQ As String = carUbicacion & carPDF & "\"
    '     Return carpetaPDFQ
    '  End Function


    Private Function getArrayDatosSeleccionados() As ArrayList
        Dim arrayCodTipNom As New ArrayList
        Dim codigo As String
        Dim tipo As String
        Dim nombre As String
        If dgvPDFs.Rows.Count > 0 Then
            If Not dgvPDFs.Columns("EvaluarPDF") Is Nothing Then
                For i As Integer = 0 To dgvPDFs.Rows.Count - 1
                    If dgvPDFs.Rows(i).Cells("EvaluarPDF").Value = 1 Then
                        codigo = dgvPDFs.Rows(i).Cells("CodigoEdicion").Value
                        tipo = dgvPDFs.Rows(i).Cells("Tipo").Value
                        nombre = dgvPDFs.Rows(i).Cells("colPDF").Value
                        arrayCodTipNom.Add(codigo & "," & tipo & "," & nombre)
                    End If
                Next
            End If
        End If
        Return arrayCodTipNom
    End Function

    Private Function DesaprobarPDFs(ByVal arrayCodTipNombre As ArrayList) As Integer
        Dim codigo As String
        Dim tipo As Integer
        Dim nombre As String
        Dim datos As Array

        Dim cEdicion As New Clases.C_Edicion

        Dim frmIncidencia As New Frm_Incidencia("PDF")

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
                    cEdicion.PasarEdicionesReproceso(codigo, tipo, incid, desc, Frm_Principal.datosUsuario)
                    pasarPDFsP(nombre)
                    ListarPdfsPorAprobar()
                    Return 1
                Catch ex As Exception
                    MsgBox("Error al aprobar los PDFs seleccionados", MsgBoxStyle.Exclamation, "Aviso")
                    Return -1
                End Try
            Next
        Else
            Return 0
        End If

    End Function

    Private Sub btnPasarQA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPasarQA.Click
        Dim arrCodiNombTipoInci As ArrayList = obetenerCodiNombTipoInciSeleccionados()
        Dim datos As Array
        Try
            If arrCodiNombTipoInci.Count > 0 Then
                For Each codigo As String In arrCodiNombTipoInci
                    datos = codigo.Split(",")
                    codigo = datos(0)
                    EliminarRegistroPDF(codigo)
                    Exit For
                Next
                pasarPDFsQA(arrCodiNombTipoInci)
                ListarPdfsDesaprobados()
                MessageBox.Show("PDFs pasados a QA correctamente", "Alerta PDF", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                MessageBox.Show("No hay PFDs seleccionados", "Alerta PDF", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

        Catch ex As Exception
            MessageBox.Show("Error al pasar PDFs a QA", "Alerta PDF", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Function obetenerCodiNombTipoInciSeleccionados() As ArrayList
        Dim arrCodigoNombreTipoInci As ArrayList = New ArrayList

        If dgvPDFs.Rows.Count > 0 Then
            For i As Integer = 0 To dgvPDFs.Rows.Count - 1
                If dgvPDFs.Rows(i).Cells("EvaluarPDF").Value = 1 Then
                    If dgvPDFs.Rows(i).Cells("ColPDF").Value <> "" Then
                        arrCodigoNombreTipoInci.Add(dgvPDFs.Rows(i).Cells("CodigoEdicion").Value & "," & dgvPDFs.Rows(i).Cells("ColPDF").Value & "," & dgvPDFs.Rows(i).Cells("Tipo").Value & "," & dgvPDFs.Rows(i).Cells("CodigoIncidencia").Value)
                    Else
                        MessageBox.Show("La página " & dgvPDFs.Rows(i).Cells("CodigoIdentificacion").Value & " no tiene PDF", "Alerta PDF", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                End If
            Next
        End If

        Return arrCodigoNombreTipoInci
    End Function

    Private Sub pasarPDFsQA(ByVal arrCodiNombTipoInci As ArrayList)
        Dim carpetaP As String = Configuration.ConfigurationManager.AppSettings("carpetaP")
        Dim carpetaQ As String = Configuration.ConfigurationManager.AppSettings("carpetaPeruano")
        Dim carpetaPDF_P As String
        Dim carpetaPDF_Q As String
        Dim pdfP As String = ""
        Dim pdfQ As String = ""
        Dim cod As String = ""
        Dim nom As String = ""
        Dim tipo As Integer
        Dim codInc As Integer
        Dim dato As Array

        Dim cEdicion As New Clases.C_Edicion

        aArchivos.Inic(Clases.DatosConexion.dominio, Clases.DatosConexion.usuario, Clases.DatosConexion.clave)
        lErrorConexionRed = aArchivos.RedConectar(carpetaRaiz)

        For Each codnomtip As String In arrCodiNombTipoInci
            dato = codnomtip.Split(",")
            cod = dato(0).ToString()
            nom = dato(1).ToString()
            tipo = Convert.ToInt16(dato(2).ToString())
            codInc = Convert.ToInt16(dato(3).ToString())

            carpetaPDF_P = getCarpetaPDFP(nom)
            carpetaPDF_Q = getCarpetaPDFQ(nom)

            pdfP = carpetaP & carpetaPDF_P & nom
            If File.Exists(pdfP) Then
                pdfQ = carpetaQ & carpetaPDF_Q & nom
                If File.Exists(pdfQ) Then
                    My.Computer.FileSystem.DeleteFile(pdfQ)
                End If
                File.Move(pdfP, pdfQ)
                'File.Copy(pdfP, pdfQ, True)
                cEdicion.PasarEdicionesQA(2, cod, tipo, codInc, Frm_Principal.datosUsuario)
            Else
                MessageBox.Show("No existe el PDF: " & pdfP, "Alerta PDF", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Next

        aArchivos.RedDesconectar(carpetaRaiz)
    End Sub
    Private Sub EliminarRegistroPDF(ByVal codigo As String)
        Dim cEdiciones As New Clases.C_Edicion
        Dim tipoDocumento As String = "PDF"
        cEdiciones.EliminarRegistroRechazadosPDF(codigo, tipoDocumento)
    End Sub

    
End Class