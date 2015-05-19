Imports System.IO
Imports System.Diagnostics
Public Class Frm_Edicion

    Dim moverme
    Dim valorBool As Integer = 1

    Dim aArchivos As New Clases.AccesoArchivos()
    Dim lErrorConexionRed As Long
    Dim carpetaRaiz As String = Configuration.ConfigurationManager.AppSettings("carpetaRaiz")


#Region "VARIABLES QUE RECIBEN VALOR DE FROM_EMPASTE"
    Public Frm_Edi_NumEdicion As Integer = 0
    Public Frm_Edi_NumSuplemento As Integer = 0
    Public Frm_Edi_NumSemestre As Integer = 0

    Public Frm_Edi_NEDR As Integer = 0
    Public Frm_Edi_NSUR As Integer = 0
    Public Frm_Edi_NSER As Integer = 0

    Public Frm_Edi_CodEmpaste As String = ""
    Public Frm_Edi_CodAuxEdicion As String = ""
    Public Frm_Edi_AuxNumPag As Integer = 0
    Public Frm_Edi_NumPagTotalEmpaste As Integer = 0
    Public Frm_Edi_NumPagTotalEdicion As Integer = 0
    Public Frm_Edi_ControlRecibirEmpaste As Integer 'RECIBE EL VALOR DE LA VARIABLE Frm_EmpControlEnviarEdicion DE FROM EMPASTE
    Public Frm_Edi_CodTipo As Integer = 1
    Public Frm_Edi_Empaste As String = ""

    'Nuevas Variables Josech
    Public Frm_Edi_Fecha As String = ""

    'Dim estadoAprobado() As String = {"IP", ""}

    Public A As Integer
    'Public Frm_Edi_FilaSeleccionada As Integer

#End Region
#Region "VARIABLES QUE ENVIAN VALOR A FROM_EMPASTE"
    Public Frm_Edi_CodAuxEdicionEnviarEmpaste As String = ""
#End Region
#Region "CODIGO DETALLE EMPASTE"

    Private Sub Frm_Edicion_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Frm_Edi_CodAuxEdicionEnviarEmpaste = Frm_Edi_CodAuxEdicion
        Frm_Edi_Empaste = ""
        Frm_Edi_CodAuxEdicion = ""

    End Sub

    Private Sub Frm_Edicion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargarCbxTipo()
        If Frm_Edi_ControlRecibirEmpaste = 1 Then
            LimpiarFormulario()
            TlsAgregarPagina.Enabled = False
            A = 1
        ElseIf Frm_Edi_ControlRecibirEmpaste = 2 Then
            CbxTipo.SelectedValue = Frm_Edi_CodTipo
            Frm_Edi_NumPagTotalEdicion = Frm_Edi_NumPagTotalEdicion - CInt(TxtENumPagEdicion.Text)
            TlsAgregarPagina.Enabled = True
            A = 0
        End If
        Frm_Edi_Empaste = LblCodIden.Text.Substring(0, 11)

        TlsEliminarPagina.Enabled = False
        TlsModificarPagina.Enabled = False
        TxtENumEdicion.Enabled = False
        TxtENumEdicion.ForeColor = Color.Red
        TxtENumEdicion.BackColor = Color.White

        'Frm_Edi_CodTipo = Convert.ToInt16(CbxTipo.SelectedValue().ToString())

        CargarDatosPagina(LblCodIden.Text.Substring(0, 11), LblCodIden.Text & TxtCodEdi.Text, CbxTipo.SelectedValue)
        TxtCodEdi.Select()
    End Sub

    Private Sub CbxTipo_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CbxTipo.SelectedIndexChanged
        If CbxTipo.SelectedIndex = 0 Then
            LblFecha.Text = "Fec. edición *"
            LblNumero.Text = "N°. edición *"
            LblNumeroPaginas.Text = "N°. pág. edición *"
        ElseIf CbxTipo.SelectedIndex = 1 Then
            LblFecha.Text = "Fec. suplemento *"
            LblNumero.Text = "N°. suplemento *"
            LblNumeroPaginas.Text = "N°. pág. suplemento *"
        ElseIf CbxTipo.SelectedIndex = 2 Then
            LblFecha.Text = "Fec. extraordinario *"
            LblNumero.Text = "N°. extraordinario *"
            LblNumeroPaginas.Text = "N°. pág. extraordinario *"
        End If
    End Sub

    Public Sub LimpiarFormulario()
        TxtCodEdi.Text = ""
        CbxTipo.SelectedIndex = 0
        DtpEFechaEdicion.Text = DateTime.Now
        TxtEDirector.Text = ""
        TxtENumEdicion.Text = ""
        TxtENumPagEdicion.Text = ""
        TxtEPagFaltantes.Text = ""
        TxtObservaciones.Text = ""
        CkxEBueno.Checked = False
        CkxEDelgado.Checked = False
        CkxEDeteriorado.Checked = False
        CkxEGrueso.Checked = False
    End Sub

    Public Sub CargarCbxTipo()
        Dim CPrioridad As New Clases.C_Edicion
        Dim RecuperarDato = CPrioridad.CargarDatos(1, "", "")
        CbxTipo.DataSource = RecuperarDato
        CbxTipo.ValueMember = RecuperarDato.Columns(0).ToString.Trim
        CbxTipo.DisplayMember = RecuperarDato.Columns(1).ToString.Trim
    End Sub

    Private Sub TlsGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TlsGuardar.Click
        Dim ValorFec_1 = DateDiff("d", DtpI.Text, DtpF.Text)
        Dim ValorFec_2 = DateDiff("d", DtpI.Text, DtpEFechaEdicion.Text)
        Dim nro_paginasEmpaste As Integer
        Dim nro_paginasEdicion As Integer
        Try
            nro_paginasEmpaste = CInt(Frm_Edi_NumPagTotalEmpaste)
        Catch ex As Exception
            nro_paginasEmpaste = 0
        End Try
        Try
            nro_paginasEdicion = CInt(Me.TxtENumPagEdicion.Text)
        Catch ex As Exception
            nro_paginasEdicion = 0
        End Try

        Dim StringBueno As String = "" : Dim StringGrueso As String = "" : Dim StringDelgado As String = "" : Dim StringDeteriorado As String = ""
        Dim NumPagRegistradas As Integer = 0
        If DgwPaginas.Rows.Count > 0 Then
            NumPagRegistradas = DgwPaginas.Rows.Count
        End If
        If CkxEBueno.Checked = True Then
            StringBueno = "S"
        ElseIf CkxEBueno.Checked = False Then
            StringBueno = "N"
        End If
        If CkxEGrueso.Checked = True Then
            StringGrueso = "S"
        ElseIf CkxEGrueso.Checked = False Then
            StringGrueso = "N"
        End If
        If CkxEDelgado.Checked = True Then
            StringDelgado = "S"
        ElseIf CkxEDelgado.Checked = False Then
            StringDelgado = "N"
        End If
        If CkxEDeteriorado.Checked = True Then
            StringDeteriorado = "S"
        ElseIf CkxEDeteriorado.Checked = False Then
            StringDeteriorado = "N"
        End If
        If Len(LblCodIden.Text & TxtCodEdi.Text) <> 18 Then
            MsgBox("El código de identificación debe de tener 18 caracteres", MsgBoxStyle.Exclamation, "Aviso")
            TxtCodEdi.Focus()
        ElseIf String.IsNullOrEmpty(TxtENumEdicion.Text) Then
            MsgBox("Ingrese " & LblNumero.Text, MsgBoxStyle.Exclamation, "Aviso")
            TxtENumEdicion.Focus()
        ElseIf String.IsNullOrEmpty(TxtENumPagEdicion.Text) Then
            MsgBox("Ingrese " & LblNumeroPaginas.Text & "", MsgBoxStyle.Exclamation, "Aviso")
            TxtENumPagEdicion.Focus()
        ElseIf CbxTipo.SelectedIndex = 0 And Frm_Edi_NEDR + A > Frm_Edi_NumEdicion Then
            MsgBox("El N. de ediciones excede a la cantidad de ediciones ingresados en el Empaste", MsgBoxStyle.Exclamation, "Aviso")
            CbxTipo.Focus()
        ElseIf CbxTipo.SelectedIndex = 1 And Frm_Edi_NSUR + A > Frm_Edi_NumSuplemento Then
            MsgBox("El N. de suplementos excede a la cantidad de suplementos ingresados en el Empaste", MsgBoxStyle.Exclamation, "Aviso")
            CbxTipo.Focus()
        ElseIf CbxTipo.SelectedIndex = 2 And Frm_Edi_NSER + A > Frm_Edi_NumSemestre Then
            MsgBox("El N. de extraordinario excede a la cantidad de extraordinarios ingresados en el Empaste", MsgBoxStyle.Exclamation, "Aviso")
            CbxTipo.Focus()
            'ElseIf ValorFec_2 > ValorFec_1 And ValorFec_2 >= -1 Then
            '    MsgBox("La fecha de " & LblFecha.Text & " debe estar dentro del rango de fecha ingresada en el Empaste", MsgBoxStyle.Exclamation, "Aviso")
            '    DtpEFechaEdicion.Focus()
        ElseIf ValorFec_2 < 0 Or ValorFec_2 > ValorFec_1 Then
            MsgBox("La fecha de " & LblFecha.Text & " debe estar dentro del rango de fecha ingresada en el Empaste", MsgBoxStyle.Exclamation, "Aviso")
            DtpEFechaEdicion.Focus()
        ElseIf CkxEBueno.Checked = False And CkxEDelgado.Checked = False And CkxEDeteriorado.Checked = False And CkxEGrueso.Checked = False Then
            MsgBox("Seleccione al menos una calidad de papel", MsgBoxStyle.Exclamation, "Aviso")
            'ElseIf Frm_Empaste.TxtNumPaginas.Text < Me.TxtENumPagEdicion.Text Then  -- ms.28.06.2012
            'ElseIf nro_paginasEmpaste < Me.TxtENumPagEdicion.Text Then
            '    MsgBox("El N. de páginas de ediciones excede al N° de páginas ingresado en el empaste", MsgBoxStyle.Exclamation, "Aviso")-- ms.13.09.2012

        ElseIf NumPagRegistradas > TxtENumPagEdicion.Text Then
            MsgBox("El N. de páginas registradas excede al N. de páginas ingresadas", MsgBoxStyle.Exclamation, "Aviso")
        ElseIf TxtCodEdi.Text <> "" And TxtCodEdi.MaxLength = Len(TxtCodEdi.Text) And Len(LblCodIden.Text & TxtCodEdi.Text) = 18 Then
            Dim Gestionar As New Clases.C_Edicion
            Dim ValorDevueltoRegistrar As String = ""
            Dim ValorDevueltoModificar As String = ""
            If Frm_Edi_CodAuxEdicion = "" And TxtCodEdi.Text <> "" Then
                Dim Valor_Booleano_1 = Gestionar.BuscarEdicion(1, Frm_Edi_Empaste, LblCodIden.Text & TxtCodEdi.Text, CbxTipo.SelectedValue)
                If Valor_Booleano_1 = "SI" Then
                    ValorDevueltoRegistrar = Gestionar.Gestionar_Edicion(1, Frm_Edi_Empaste, "", LblCodIden.Text & TxtCodEdi.Text, CbxTipo.SelectedValue, TxtENumEdicion.Text, CInt(TxtENumPagEdicion.Text), DtpEFechaEdicion.Text, TxtEDirector.Text.ToString.Trim, TxtEPagFaltantes.Text, StringBueno, StringDelgado, StringGrueso, StringDeteriorado, TxtObservaciones.Text, Frm_Login.DgvDatosUsuario.Rows(0).Cells(0).Value, tbTitulo.Text, tbSubtitulo.Text)
                    If ValorDevueltoRegistrar = LblCodIden.Text & TxtCodEdi.Text Then
                        MsgBox("Detalle de empaste almacenado", MsgBoxStyle.Information, "Aviso")
                        Frm_Edi_CodAuxEdicion = LblCodIden.Text & TxtCodEdi.Text
                        Frm_Edi_AuxNumPag = TxtENumPagEdicion.Text
                        TlsAgregarPagina.Enabled = True

                        'Frm_Empaste.Frm_Emp_FilaSeleccionada2 = Frm_Edi_CodAuxEdicion

                    Else
                        MsgBox("Detalle de empaste no almacenado", MsgBoxStyle.Information, "Aviso")
                    End If
                Else
                    MsgBox("Ya existe el código ingresado", MsgBoxStyle.Exclamation, "Aviso")
                End If
            ElseIf Frm_Edi_CodAuxEdicion <> "" And Frm_Edi_CodAuxEdicion = LblCodIden.Text & TxtCodEdi.Text Then
                ValorDevueltoModificar = Gestionar.Gestionar_Edicion(3, Frm_Edi_Empaste, Frm_Edi_CodAuxEdicion, LblCodIden.Text & TxtCodEdi.Text, Me.CbxTipo.SelectedValue, TxtENumEdicion.Text, CInt(TxtENumPagEdicion.Text), DtpEFechaEdicion.Text, TxtEDirector.Text.ToString.Trim, TxtEPagFaltantes.Text, StringBueno, StringDelgado, StringGrueso, StringDeteriorado, TxtObservaciones.Text, Frm_Login.DgvDatosUsuario.Rows(0).Cells(0).Value, tbTitulo.Text, tbSubtitulo.Text)
                If ValorDevueltoModificar = LblCodIden.Text & TxtCodEdi.Text Then
                    MsgBox("Detalle de empaste actualizado", MsgBoxStyle.Information, "Aviso")
                    Frm_Edi_AuxNumPag = TxtENumPagEdicion.Text

                    ''Frm_Empaste.Frm_Emp_FilaSeleccionada2 = Frm_Edi_CodAuxEdicion

                Else
                    MsgBox("Detalle de empaste no actualizado", MsgBoxStyle.Information, "Aviso")
                End If
            ElseIf Frm_Edi_CodAuxEdicion <> "" And Frm_Edi_CodAuxEdicion <> LblCodIden.Text & TxtCodEdi.Text Then
                Dim Valor_Booleano_2 = Gestionar.BuscarEdicion(1, Frm_Edi_Empaste, LblCodIden.Text & TxtCodEdi.Text, CbxTipo.SelectedValue)
                If Valor_Booleano_2 = "SI" Then
                    Dim Valor_Booleano_3 = Gestionar.BuscarEdicion(2, Frm_Edi_Empaste, Frm_Edi_CodAuxEdicion, CbxTipo.SelectedValue)
                    If Valor_Booleano_3 = "SI" Then
                        ValorDevueltoModificar = Gestionar.Gestionar_Edicion(3, Frm_Edi_Empaste, Frm_Edi_CodAuxEdicion, LblCodIden.Text & TxtCodEdi.Text, CbxTipo.SelectedValue, TxtENumEdicion.Text, CInt(TxtENumPagEdicion.Text), DtpEFechaEdicion.Text, TxtEDirector.Text.ToString.Trim, TxtEPagFaltantes.Text, StringBueno, StringDelgado, StringGrueso, StringDeteriorado, TxtObservaciones.Text, Frm_Login.DgvDatosUsuario.Rows(0).Cells(0).Value, tbTitulo.Text, tbSubtitulo.Text)
                        If ValorDevueltoModificar = LblCodIden.Text & TxtCodEdi.Text Then
                            MsgBox("Detalle de empaste actualizado", MsgBoxStyle.Information, "Aviso")
                            Frm_Edi_CodAuxEdicion = LblCodIden.Text & TxtCodEdi.Text
                            Frm_Edi_AuxNumPag = TxtENumPagEdicion.Text
                            TlsAgregarPagina.Enabled = True

                            'Frm_Empaste.Frm_Emp_FilaSeleccionada2 = Frm_Edi_CodAuxEdicion

                        Else
                            MsgBox("Detalle de empaste no actualizado", MsgBoxStyle.Information, "Aviso")
                        End If
                    Else
                        MsgBox("No se puede modificar dicho registro, ya que contiene páginas registradas", MsgBoxStyle.Exclamation, "Aviso")
                    End If
                Else
                    MsgBox("Ya existe el código de identificación", MsgBoxStyle.Exclamation, "Aviso")
                End If
            End If
        End If
    End Sub

#Region "VALIDACIONES"

    Private Sub TxtEEdicion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtENumEdicion.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub TxtENumPagEdicion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtENumPagEdicion.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub TxtCodEdi_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCodEdi.TextChanged
        TxtCodEdi.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub TxtCodEdi_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCodEdi.KeyPress
        If InStr(1, "QqWwEeRrTtYyUuIiOoPpAaSsDdFfGgHhJjKkLlÑñZzXxCcVvBbNnMm0123456789-" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub TxtCodEdi_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCodEdi.KeyUp
        If Len(TxtCodEdi.Text) = 1 Then
            TxtENumEdicion.Text = TxtCodEdi.Text.Substring(0, 1)
        ElseIf Len(TxtCodEdi.Text) = 2 Then
            TxtENumEdicion.Text = TxtCodEdi.Text.Substring(0, 2)
        ElseIf Len(TxtCodEdi.Text) = 3 Then
            TxtENumEdicion.Text = TxtCodEdi.Text.Substring(0, 3)

            '------------------------se aumento---------------------'
        ElseIf Len(TxtCodEdi.Text) = 4 Then
            TxtENumEdicion.Text = TxtCodEdi.Text.Substring(0, 4)
        ElseIf Len(TxtCodEdi.Text) = 5 Then
            TxtENumEdicion.Text = TxtCodEdi.Text.Substring(0, 5)
        ElseIf Len(TxtCodEdi.Text) = 6 Then
            TxtENumEdicion.Text = TxtCodEdi.Text.Substring(0, 6)
            '------------------------hasta Aqui---------------------'


        ElseIf Len(TxtCodEdi.Text) <= 1 Then
            TxtENumEdicion.Text = ""
        End If
    End Sub

#End Region
#End Region
#Region "CODIGO PARA PAGINAS"

    Private Sub DgwPaginas_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgwPaginas.CellClick
        If e.RowIndex = -1 Then
            Return
        End If
        
        verificarPosChbx()
        If DgwPaginas.Rows.Count > 0 Then
            TlsModificarPagina.Enabled = True
            TlsEliminarPagina.Enabled = True

            Frm_Edi_AuxNumPag = DgwPaginas.SelectedCells(4).Value

            Dim estado As String = DgwPaginas.Rows(e.RowIndex).Cells("CodEstado").Value

            If Not DgwPaginas.Columns("CargarImagen") Is Nothing Then
                If e.ColumnIndex = DgwPaginas.Rows(e.RowIndex).Cells("CargarImagen").ColumnIndex And e.RowIndex <> -1 And (estado = "IP" Or estado = "EI" Or estado = "ER") Then
                    If DgwPaginas.Rows(e.RowIndex).Cells("CargarImagen").Value = 1 Then
                        DgwPaginas.Rows(e.RowIndex).Cells("CargarImagen").Value = 0
                    Else
                        DgwPaginas.Rows(e.RowIndex).Cells("CargarImagen").Value = 1
                    End If
                End If
            End If
        Else
            TlsModificarPagina.Enabled = False
            TlsEliminarPagina.Enabled = False
        End If
    End Sub

    Private Sub TlsEliminarPagina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TlsEliminarPagina.Click
        If DgwPaginas.Rows.Count > 0 Then
            Dim FrmCondicional As MsgBoxResult = MsgBox("Esta seguro de eliminar", MsgBoxStyle.YesNo, "Aviso")
            If FrmCondicional = MsgBoxResult.Yes Then
                Dim Eliminar As New Clases.C_Paginas
                Dim ValorDevuelto = Eliminar.Gestionar_Pagina(3, "", DgwPaginas.SelectedCells(0).Value, DgwPaginas.SelectedCells(1).Value, DgwPaginas.SelectedCells(2).Value, DgwPaginas.SelectedCells(3).Value, 0, "", "", "", "", "", "", "", Frm_Login.DgvDatosUsuario.Rows(0).Cells(0).Value, "")
                If ValorDevuelto = 999 Then
                    MsgBox("La página con código " & DgwPaginas.SelectedCells(3).Value & " fue eliminado", MsgBoxStyle.Information, "Aviso")
                    CargarDatosPagina(LblCodIden.Text.Substring(0, 11), LblCodIden.Text & TxtCodEdi.Text, CbxTipo.SelectedValue)
                End If
            End If

        End If
    End Sub

    Public Sub CargarDatosPagina(ByVal CodEmpaste As String, ByVal CodDetalle As String, ByVal TipoDetalle As Integer)
        Dim Mostrar As New Clases.C_Paginas
        DgwPaginas.DataSource = Nothing
        DgwPaginas.Columns.Clear()
        Dim n As Integer = DgwPaginas.Columns.Count
        DgwPaginas.DataSource = Mostrar.CargarDatos(1, CodEmpaste, CodDetalle, TipoDetalle)
        'DgwPaginas.Refresh()
        Try

            DgwPaginas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            DgwPaginas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            DgwPaginas.DefaultCellStyle.BackColor = Color.AliceBlue
            DgwPaginas.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
            DgwPaginas.Columns.Item(0).Visible = False
            DgwPaginas.Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
            DgwPaginas.Columns.Item(1).Visible = False
            DgwPaginas.Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
            DgwPaginas.Columns.Item(2).Visible = False

            DgwPaginas.Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable
            DgwPaginas.Columns.Item(3).HeaderText = "Cod. identificación"
            DgwPaginas.Columns.Item(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            DgwPaginas.Columns.Item(3).Name = "codigoPagina"

            DgwPaginas.Columns(4).SortMode = DataGridViewColumnSortMode.NotSortable
            DgwPaginas.Columns.Item(4).HeaderText = "N. Pág."
            DgwPaginas.Columns.Item(4).Name = "numeroPagina"
            'DgwPaginas.Columns.Item(4).Width = 40

            DgwPaginas.Columns(5).SortMode = DataGridViewColumnSortMode.NotSortable
            DgwPaginas.Columns.Item(5).HeaderText = "N. Pág. Tomo"
            DgwPaginas.Columns.Item(5).Name = "numeroPaginaTomo"
            'DgwPaginas.Columns.Item(5).Width = 40


            For i = 0 To DgwPaginas.Rows.Count - 1
                If DgwPaginas.Rows(i).Cells(6).Value = "S" Then
                    DgwPaginas.Rows(i).Cells(6).Value = "SI"
                Else
                    DgwPaginas.Rows(i).Cells(6).Value = "NO"
                End If
                If DgwPaginas.Rows(i).Cells(7).Value = "S" Then
                    DgwPaginas.Rows(i).Cells(7).Value = "SI"
                Else
                    DgwPaginas.Rows(i).Cells(7).Value = "NO"
                End If
                If DgwPaginas.Rows(i).Cells(8).Value = "S" Then
                    DgwPaginas.Rows(i).Cells(8).Value = "SI"
                Else
                    DgwPaginas.Rows(i).Cells(8).Value = "NO"
                End If
                If DgwPaginas.Rows(i).Cells(9).Value = "S" Then
                    DgwPaginas.Rows(i).Cells(9).Value = "SI"
                Else
                    DgwPaginas.Rows(i).Cells(9).Value = "NO"
                End If
                If DgwPaginas.Rows(i).Cells(10).Value = "S" Then
                    DgwPaginas.Rows(i).Cells(10).Value = "SI"
                Else
                    DgwPaginas.Rows(i).Cells(10).Value = "NO"
                End If
                If DgwPaginas.Rows(i).Cells(11).Value = "S" Then
                    DgwPaginas.Rows(i).Cells(11).Value = "SI"
                Else
                    DgwPaginas.Rows(i).Cells(11).Value = "NO"
                End If
            Next

            DgwPaginas.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DgwPaginas.Columns(6).SortMode = DataGridViewColumnSortMode.NotSortable
            DgwPaginas.Columns(6).Name = "Completo"
            DgwPaginas.Columns.Item(6).HeaderText = "Completo"
            'DgwPaginas.Columns.Item(6).Width = 30
            DgwPaginas.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DgwPaginas.Columns(7).SortMode = DataGridViewColumnSortMode.NotSortable
            DgwPaginas.Columns.Item(7).HeaderText = "Incompleto"
            'DgwPaginas.Columns.Item(7).Width = 30
            DgwPaginas.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DgwPaginas.Columns(8).SortMode = DataGridViewColumnSortMode.NotSortable
            DgwPaginas.Columns.Item(8).HeaderText = "Roto"
            'DgwPaginas.Columns.Item(8).Width = 30
            DgwPaginas.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DgwPaginas.Columns(9).SortMode = DataGridViewColumnSortMode.NotSortable
            DgwPaginas.Columns.Item(9).HeaderText = "Manchado"
            'DgwPaginas.Columns.Item(9).Width = 30
            DgwPaginas.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DgwPaginas.Columns(10).SortMode = DataGridViewColumnSortMode.NotSortable
            DgwPaginas.Columns.Item(10).HeaderText = "Falta"
            'DgwPaginas.Columns.Item(10).Width = 30
            DgwPaginas.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DgwPaginas.Columns(11).SortMode = DataGridViewColumnSortMode.NotSortable
            DgwPaginas.Columns.Item(11).HeaderText = "Dificultad"
            'DgwPaginas.Columns.Item(11).Width = 30
            DgwPaginas.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DgwPaginas.Columns(12).SortMode = DataGridViewColumnSortMode.NotSortable
            DgwPaginas.Columns.Item(12).Visible = False

            DgwPaginas.Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DgwPaginas.Columns(13).SortMode = DataGridViewColumnSortMode.NotSortable
            DgwPaginas.Columns.Item(13).HeaderText = "Imagen"
            DgwPaginas.Columns.Item(13).Name = "ImagenP"
            'DgwPaginas.Columns.Item(13).Width = 165

            DgwPaginas.Columns(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DgwPaginas.Columns(14).SortMode = DataGridViewColumnSortMode.NotSortable
            DgwPaginas.Columns.Item(14).HeaderText = "CodEstado"
            DgwPaginas.Columns.Item(14).Name = "CodEstado"
            DgwPaginas.Columns.Item(14).Visible = False

            DgwPaginas.Columns(15).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DgwPaginas.Columns(15).SortMode = DataGridViewColumnSortMode.NotSortable
            DgwPaginas.Columns.Item(15).HeaderText = "Estado"
            DgwPaginas.Columns.Item(15).Name = "Estado"
            'DgwPaginas.Columns.Item(15).Width = 70

            verificarPosChbx()

            If DgwPaginas.Rows.Count > 0 Then
                TlsModificarPagina.Enabled = True
                TlsEliminarPagina.Enabled = True
                TxtCodEdi.Text = Frm_Edi_CodAuxEdicion.Substring(12, 6)
                TxtENumEdicion.Text = Frm_Edi_CodAuxEdicion.Substring(12, 6)
                TxtCodEdi.Enabled = False
                'DgwPaginas.Rows.Item(Frm_Edi_FilaSeleccionada).Selected = True
            Else
                TlsModificarPagina.Enabled = False
                TlsEliminarPagina.Enabled = False
                'Frm_Edi_FilaSeleccionada = 0
                TxtCodEdi.Enabled = True
            End If
        Catch ex As Exception
            MsgBox("Error Inesperado", MsgBoxStyle.Critical, "Editora Peru")
        End Try
    End Sub
    Private Sub verificarPosChbx()
        Dim ColCheckBox As New DataGridViewCheckBoxColumn
        With ColCheckBox
            .HeaderText = "Cargar"
            .Name = "CargarImagen"
            .Width = 30
            .TrueValue = 1
            .FalseValue = 0
            .DefaultCellStyle.BackColor = Color.LightSteelBlue
            .DisplayIndex = 0
            .Frozen = False
            .SortMode = DataGridViewColumnSortMode.NotSortable
        End With
        If DgwPaginas.Columns("CargarImagen") Is Nothing Then
            DgwPaginas.Columns.Add(ColCheckBox)
            'DgwPaginas.Columns.Add(ColCheckBox)
        Else
            Dim c As Integer = DgwPaginas.Columns.Item("CargarImagen").Index
            If c = 0 Then
                DgwPaginas.Columns.Remove("CargarImagen")
                DgwPaginas.Columns.Insert(DgwPaginas.Columns.Count, ColCheckBox)
            End If
        End If
    End Sub

    Public Sub ModificarPagina() 'para modificar el codigo de pagina'
        If DgwPaginas.Rows.Count > 0 Then
            Frm_Paginas.LblCodIdenEmDe.Text = DgwPaginas.SelectedCells(3).Value.ToString.Substring(0, 18) & "-"
            Frm_Paginas.TxtCodPag.Text = DgwPaginas.SelectedCells(3).Value.ToString.Substring(19, 3) 'si se desea uamentar a a 6 caracteres el codigo de pagina se cambia el 3 x 6 quedando(19,6)
            Frm_Paginas.TxtNumPagina.Text = DgwPaginas.SelectedCells(3).Value.ToString.Substring(19, 3)
            If IsDBNull(DgwPaginas.SelectedCells(5).Value) Then
                Frm_Paginas.TxtNumTomo.Text = ""
            Else
                Frm_Paginas.TxtNumTomo.Text = DgwPaginas.SelectedCells(5).Value
            End If
            'Frm_Paginas.TxtNumPagina.Text = DgwPaginas.SelectedCells(4).Value
            If DgwPaginas.SelectedCells(6).Value = "SI" Then
                Frm_Paginas.CkxCompleta.Checked = True
            Else
                Frm_Paginas.CkxCompleta.Checked = False
            End If
            If DgwPaginas.SelectedCells(7).Value = "SI" Then
                Frm_Paginas.CkxIncompleta.Checked = True
            Else
                Frm_Paginas.CkxIncompleta.Checked = False
            End If
            If DgwPaginas.SelectedCells(8).Value = "SI" Then
                Frm_Paginas.CkxRota.Checked = True
            Else
                Frm_Paginas.CkxRota.Checked = False
            End If
            If DgwPaginas.SelectedCells(9).Value = "SI" Then
                Frm_Paginas.CkxManchada.Checked = True
            Else
                Frm_Paginas.CkxManchada.Checked = False
            End If
            If DgwPaginas.SelectedCells(10).Value = "SI" Then
                Frm_Paginas.CkxFalta.Checked = True
            Else
                Frm_Paginas.CkxFalta.Checked = False
            End If
            If DgwPaginas.SelectedCells(11).Value = "SI" Then
                Frm_Paginas.CkxDificultad.Checked = True
            Else
                Frm_Paginas.CkxDificultad.Checked = False
            End If
            Frm_Paginas.Frm_Pag_TipoDetalle = CbxTipo.SelectedValue
            Frm_Paginas.Frm_Pag_ControlDetalle = 2
            Frm_Paginas.Frm_Cant_Pag_Edicion = CInt(TxtENumPagEdicion.Text)
            Frm_Paginas.TxtObservaciones.Text = DgwPaginas.SelectedCells(12).Value
            Frm_Paginas.Frm_Pag_NumPaginas = DgwPaginas.Rows.Count
            Frm_Paginas.Frm_Pag_NumPaginasMax = TxtENumPagEdicion.Text
            Frm_Paginas.ShowDialog()
            CargarDatosPagina(LblCodIden.Text.Substring(0, 11), Frm_Edi_CodAuxEdicion, CbxTipo.SelectedValue)
        End If
    End Sub

#Region "CODIGO DE DATOS QUE SE ENVIAN A PAGINAS"

    Private Sub TlsAgregarPagina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TlsAgregarPagina.Click
        If Len(LblCodIden.Text & TxtCodEdi.Text) = 18 And TxtENumEdicion.Text <> "" And TxtENumPagEdicion.Text <> "" Then
            Frm_Paginas.Frm_Pag_NumPaginas = DgwPaginas.Rows.Count
            Frm_Paginas.Frm_Pag_NumPaginasMax = Frm_Edi_AuxNumPag

            Frm_Paginas.LblCodIdenEmDe.Text = Frm_Edi_CodAuxEdicion & "-"
            Frm_Paginas.Frm_Cant_Pag_Edicion = CInt(TxtENumPagEdicion.Text)
            Frm_Paginas.Frm_Pag_TipoDetalle = CbxTipo.SelectedValue
            Frm_Paginas.Frm_Pag_ControlDetalle = 1
            Frm_Paginas.ShowDialog()
            CargarDatosPagina(LblCodIden.Text.Substring(0, 11), Frm_Edi_CodAuxEdicion, CbxTipo.SelectedValue)
        Else
            MsgBox("Tiene que ingresar el detalle de empaste, para poder agregar una página", MsgBoxStyle.Information, "Aviso")
        End If
    End Sub

    Private Sub DgwPaginas_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgwPaginas.CellDoubleClick

        If e.RowIndex <> -1 Then
            'Dim c As Integer = DgwPaginas.Rows(e.RowIndex).Cells("CargarImagen").ColumnIndex
            If e.ColumnIndex = DgwPaginas.Columns("ImagenP").Index Then
                Dim nombreImagen As String = ""
                Dim codigoEstado As String = DgwPaginas.Rows(e.RowIndex).Cells("CodEstado").Value
                nombreImagen = DgwPaginas.Rows(e.RowIndex).Cells("ImagenP").Value
                If nombreImagen <> "" Then
                    ' MostrarImagen(nombreImagen)
                    MostrarImagen(nombreImagen, codigoEstado)
                Else
                    MsgBox("No hay archivos asociado", MsgBoxStyle.Exclamation, "Aviso")
                End If
            ElseIf e.ColumnIndex = DgwPaginas.Columns("Estado").Index Then
                Dim codEstado As String = DgwPaginas.Rows(e.RowIndex).Cells("CodEstado").Value
                Dim codImagen As String = DgwPaginas.Rows(e.RowIndex).Cells("CodigoPagina").Value
                If codEstado = "ER" Then
                    mostrarImagenDesaprobada(codImagen)
                Else
                    ModificarPagina()
                End If
            Else
                ModificarPagina()
            End If
        Else
            Dim estado As String
            If Not DgwPaginas.Columns("CargarImagen") Is Nothing Then
                If e.ColumnIndex = DgwPaginas.Columns("CargarImagen").Index And DgwPaginas.Rows.Count > 0 Then
                    For i As Integer = 0 To DgwPaginas.Rows.Count - 1
                        estado = DgwPaginas.Rows(i).Cells("CodEstado").Value
                        If estado = "IP" Or estado = "EI" Then
                            DgwPaginas.Rows(i).Cells("CargarImagen").Value = valorBool
                        End If
                    Next
                    If valorBool = 0 Then
                        valorBool = 1
                    Else
                        valorBool = 0
                    End If
                End If
            End If
        End If

    End Sub
    Sub mostrarImagenDesaprobada(ByVal codigo As String)
        Dim QA_Incidencia As Frm_Incidencia = New Frm_Incidencia(codigo, "IMAGEN")
        QA_Incidencia.ShowDialog()
    End Sub

    Private Sub TlsModificarPagina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TlsModificarPagina.Click
        ModificarPagina()
    End Sub

#End Region
#End Region

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click

        '"moverme":Es una variable publica del frm_edicion esta en la parte de arriba.
        'Me.Hide()esconde el formulario. 
        moverme = CAMBIAR
        moverme.Show()

    End Sub


    Private Sub TlsCargarImagen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TlsCargarImagen.Click
        Dim cods As String = ""
        Dim arrCodigos As ArrayList = New ArrayList


        If DgwPaginas.Rows.Count > 0 Then
            For i As Integer = 0 To DgwPaginas.Rows.Count - 1
                If DgwPaginas.Rows(i).Cells("CargarImagen").Value = 1 Then
                    cods = cods & " -> " & DgwPaginas.Rows(i).Cells(3).Value
                    arrCodigos.Add(DgwPaginas.Rows(i).Cells(3).Value)
                End If
            Next
        End If
        DigitalizarImgenes(arrCodigos)
    End Sub


    Private Sub DigitalizarImgenes(ByVal arrayCodigos As ArrayList)
        Dim carpetaP As String = Configuration.ConfigurationManager.AppSettings("carpetaP")
        '***********CARPETA DE PRUEBAS LOCALES **************
        ' Dim carpetaP As String = "C:\Users\fa1juanx\Desktop\EMPASTE\carpetaP\"
        Dim nombreImg As String = ""
        Dim enc As Boolean = True

        Dim cPagina As New Clases.C_Paginas

        aArchivos.Inic(Clases.DatosConexion.dominio, Clases.DatosConexion.usuario, Clases.DatosConexion.clave)
        lErrorConexionRed = aArchivos.RedConectar(carpetaRaiz)

        Dim arrayImagenes As ArrayList = New ArrayList
        Dim tipoEdicion As String = Me.CbxTipo.SelectedValue
        If tipoEdicion = "1" Then
            tipoEdicion = "E"
        ElseIf tipoEdicion = "2" Then
            tipoEdicion = "S"
        ElseIf tipoEdicion = "3" Then
            tipoEdicion = "X"
        Else
            tipoEdicion = "E"
        End If

        Dim fechaEdicion As String = Me.DtpEFechaEdicion.Text.Substring(6, 4) & Me.DtpEFechaEdicion.Text.Substring(3, 2) & Me.DtpEFechaEdicion.Text.Substring(0, 2)
        Dim carAnio As String = Me.LblCodIden.Text.Substring(4, 4)
        Dim carTomo As String = "TOMO-" & Me.LblCodIden.Text.Substring(9, 2)
        Dim carEdicion As String = fechaEdicion & "-" & Me.TxtCodEdi.Text.Substring(Me.TxtCodEdi.Text.Length - 3) & tipoEdicion
        Dim carpetaImagen As String = getCarpetaImagen()
        Dim ruta As String = carpetaP & carpetaImagen
        Dim carpeta As New DirectoryInfo(ruta)
        Dim nombreImg2$
        Dim cont%
        Dim lista As New ArrayList
        Dim list As String

        If Directory.Exists(ruta) Then
            For Each file As FileInfo In carpeta.GetFiles()
                arrayImagenes.Add(file.Name.ToUpper())
            Next

            For Each codigo As String In arrayCodigos
                Dim codigo2$
                nombreImg = fechaEdicion & "-" & codigo.Substring(0, 11) & carEdicion.Substring(8) & "-" & codigo.Substring(codigo.Length - 3) & ".JPG"
                If codigo.Substring(2, 1) = 1 Then
                    nombreImg2 = fechaEdicion & "-" & codigo.Substring(0, 2) & "2" & codigo.Substring(3, 8) & carEdicion.Substring(8) & "-" & codigo.Substring(codigo.Length - 3) & ".JPG"
                    codigo2 = "I-2" & codigo.Substring(3, 15)
                Else
                    nombreImg2 = fechaEdicion & "-" & codigo.Substring(0, 2) & "1" & codigo.Substring(3, 8) & carEdicion.Substring(8) & "-" & codigo.Substring(codigo.Length - 3) & ".JPG"
                    codigo2 = "I-1" & codigo.Substring(3, 15)
                End If

                If arrayImagenes.Contains(nombreImg) Then
                    cPagina.DigitalizarPaginas(codigo, Frm_Edi_CodTipo, nombreImg, Frm_Principal.datosUsuario)
                ElseIf arrayImagenes.Contains(nombreImg2) Then
                    cPagina.DigitalizarPaginas(codigo2, Frm_Edi_CodTipo, nombreImg2, Frm_Principal.datosUsuario)
                Else
                    enc = False
                    cont += 1
                    lista.Add(codigo)
                End If
            Next
            For Each cod As String In lista
                list += cod + vbNewLine
            Next
            If enc Then
                MessageBox.Show("Imagenes actualizadas correctamente", "Alerta Imagen", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                MessageBox.Show("No se encontraron todas las imagenes" & vbNewLine & "faltan : " & cont.ToString & vbNewLine & list, _
                                "Alerta Imagen", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            CargarDatosPagina(LblCodIden.Text.Substring(0, 11), LblCodIden.Text & TxtCodEdi.Text, CbxTipo.SelectedValue)
        Else
            MessageBox.Show("El directorio " & ruta & " no existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        aArchivos.RedDesconectar(carpetaRaiz)
        'MessageBox.Show(xxx, "Nombres", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Sub
    Private Sub MostrarImagen2(ByVal nombreImagen As String, ByVal codigo As String)
        ' Dim estado As String = DgwPaginas.Rows(e.RowIndex).Cells("CodEstado").Value
    End Sub
    Private Sub MostrarImagen(ByVal nombreImagen As String, ByVal codEstado As String)
        Dim carpetaP As String = Configuration.ConfigurationManager.AppSettings("carpetaP")
        Dim carpetaQ As String = Configuration.ConfigurationManager.AppSettings("carpetaPeruano")
        Dim carpetaR As String = Configuration.ConfigurationManager.AppSettings("carpetaR")

        'Dim carpetaQ As String = "C:\Users\fa1juanx\Desktop\capetaQ\"

        Dim carpetaImagen As String = getCarpetaImagen()
        Dim carpetaImagenR As String = getCarpetaImagenR()
        Dim ruta As String ' carpetaP & carpetaImagen & nombreImagen
        'cargar el estado de la pagina, hacer un recorrido a la grilla buscando el dato en la columna estado

        'aArchivos.Inic(Clases.DatosConexion.dominio, Clases.DatosConexion.usuario, Clases.DatosConexion.clave)
        'lErrorConexionRed = aArchivos.RedConectar(carpetaRaiz)

        If codEstado = "IR" Then
            ruta = carpetaR & carpetaImagenR & nombreImagen
        ElseIf codEstado = "IQ" Then
            ruta = carpetaQ & carpetaImagen & nombreImagen
        Else
            'ruta = carpetaP & carpetaImagen & nombreImagen
            ruta = carpetaP & carpetaImagen & nombreImagen
        End If


        Try
            If File.Exists(ruta) Then
                Process.Start(ruta)
                'Process.Start("C:\WINDOWS\system32\mspaint.exe", ruta)
                'Shell("C:\WINDOWS\system32\mspaint.exe " + ruta, 1)

            Else
                MessageBox.Show("No existe la imagen seleccionada" &
                                vbNewLine & "la ruta es : " &
                                vbNewLine & ruta, "Alerta Imagen", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

        Catch ex As Exception
            MessageBox.Show("No se puede mostrar la imagen seleccionada" & _
                            vbNewLine & ruta, "Alerta Imagen", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

        'aArchivos.RedDesconectar(carpetaRaiz)

    End Sub
    Private Function getCarpetaImagenR() As String
        Dim tipoEdicion As String = Me.CbxTipo.SelectedValue
        If tipoEdicion = "1" Then
            tipoEdicion = "E"
        ElseIf tipoEdicion = "2" Then
            tipoEdicion = "S"
        Else
            tipoEdicion = "X"
        End If

        Dim fechaEdicion As String = Me.DtpEFechaEdicion.Text.Substring(6, 4) & Me.DtpEFechaEdicion.Text.Substring(3, 2) & Me.DtpEFechaEdicion.Text.Substring(0, 2)
        Dim capetaUbicacion As String = "JPG -FINAL"
        Dim carAnio As String = Me.LblCodIden.Text.Substring(4, 4)
        Dim carTomo As String = "TOMO-" & Me.LblCodIden.Text.Substring(9, 2)
        Dim carEdicion As String = fechaEdicion & "-" & Me.TxtCodEdi.Text.Substring(Me.TxtCodEdi.Text.Length - 3) & tipoEdicion

        Dim carpetaImagen As String = capetaUbicacion & "\" & carAnio & "\" & carTomo & "\" & carEdicion & "\"

        Return carpetaImagen
    End Function

    Private Function getCarpetaImagen() As String
        Dim tipoEdicion As String = Me.CbxTipo.SelectedValue
        If tipoEdicion = "1" Then
            tipoEdicion = "E"
        ElseIf tipoEdicion = "2" Then
            tipoEdicion = "S"
        Else
            tipoEdicion = "X"
        End If

        Dim fechaEdicion As String = Me.DtpEFechaEdicion.Text.Substring(6, 4) & Me.DtpEFechaEdicion.Text.Substring(3, 2) & Me.DtpEFechaEdicion.Text.Substring(0, 2)

        Dim carAnio As String = Me.LblCodIden.Text.Substring(4, 4)
        Dim carTomo As String = "TOMO-" & Me.LblCodIden.Text.Substring(9, 2)
        Dim carEdicion As String = fechaEdicion & "-" & Me.TxtCodEdi.Text.Substring(Me.TxtCodEdi.Text.Length - 3) & tipoEdicion

        Dim carpetaImagen As String = carAnio & "\" & carTomo & "\" & carEdicion & "\"

        Return carpetaImagen
    End Function
    Private Function getCarpetaImagenPDF() As String
        Dim tipoEdicion As String = Me.CbxTipo.SelectedValue
        If tipoEdicion = "1" Then
            tipoEdicion = "E"
        ElseIf tipoEdicion = "2" Then
            tipoEdicion = "S"
        Else
            tipoEdicion = "X"
        End If

        Dim fechaEdicion As String = Me.DtpEFechaEdicion.Text.Substring(6, 4) & Me.DtpEFechaEdicion.Text.Substring(3, 2) & Me.DtpEFechaEdicion.Text.Substring(0, 2)
        Dim carUbicacion As String = "Ediciones PDF" & "\"
        Dim carAnio As String = Me.LblCodIden.Text.Substring(4, 4) & " PDF"
        Dim carEdicion As String = fechaEdicion & "-" & Me.TxtCodEdi.Text.Substring(Me.TxtCodEdi.Text.Length - 3) & tipoEdicion

        Dim carpetaImagen As String = carUbicacion & carAnio & "\" & carEdicion & "\"

        Return carpetaImagen
    End Function



    Private Sub TlsPasarQA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TlsPasarQA.Click

        Dim arrNombreCodigo As ArrayList = New ArrayList

        If DgwPaginas.Rows.Count > 0 Then
            For i As Integer = 0 To DgwPaginas.Rows.Count - 1
                If DgwPaginas.Rows(i).Cells("CargarImagen").Value = 1 Then
                    If DgwPaginas.Rows(i).Cells("ImagenP").Value <> "" Then
                        Dim codigoEstado As String = DgwPaginas.Rows(i).Cells("CodEstado").Value
                        Dim codigoPagina As String = DgwPaginas.Rows(i).Cells(3).Value
                        arrNombreCodigo.Add(DgwPaginas.Rows(i).Cells("ImagenP").Value & "," & DgwPaginas.Rows(i).Cells(3).Value)

                        If (codigoEstado.Equals("ER")) Then
                            EliminarRegistroRechazados(codigoPagina)
                        End If
                    Else
                        MessageBox.Show("La página " & DgwPaginas.Rows(i).Cells(3).Value & " no tiene imagen", "Alerta Imagen", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Return
                    End If
                End If
            Next
            Try
                PasarEstadoImagenesQA(arrNombreCodigo)
                CargarDatosPagina(LblCodIden.Text.Substring(0, 11), LblCodIden.Text & TxtCodEdi.Text, CbxTipo.SelectedValue)
                MessageBox.Show("Imagenes pasadas a QA correctamente", "Alerta Imagen", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Catch ex As Exception
                MessageBox.Show("Error al pasar imagenes a QA", "Alerta Imagen", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        End If
    End Sub
    Private Sub EliminarRegistroRechazados(ByVal codigo As String)

        Dim cPagina As New Clases.C_Paginas
        cPagina.EliminarRegistroRechazado(codigo)

    End Sub

    Private Sub PasarEstadoImagenesQA(ByVal arrayNombreCodigoImagen As ArrayList)
        Dim carpetaP As String = Configuration.ConfigurationManager.AppSettings("carpetaP")
        Dim carpetaQ As String = Configuration.ConfigurationManager.AppSettings("carpetaPeruano")
        Dim carpetaImagen_P As String = getCarpetaImagen()
        Dim carpetaImagen_Q As String = getCarpetaImagen()
        Dim imgP As String = ""
        Dim imgQ As String = ""
        Dim nom As String = ""
        Dim cod As String = ""
        Dim dato As Array

        Dim cPagina As New Clases.C_Paginas

        aArchivos.Inic(Clases.DatosConexion.dominio, Clases.DatosConexion.usuario, Clases.DatosConexion.clave)
        lErrorConexionRed = aArchivos.RedConectar(carpetaRaiz)

        If Not Directory.Exists(carpetaQ & carpetaImagen_Q) Then
            Directory.CreateDirectory(carpetaQ & carpetaImagen_Q)
        End If

        For Each imgcod As String In arrayNombreCodigoImagen
            dato = imgcod.Split(",")
            nom = dato(0).ToString()
            cod = dato(1).ToString()

            imgP = carpetaP & carpetaImagen_P & nom
            If File.Exists(imgP) Then
                imgQ = carpetaQ & carpetaImagen_Q & nom
                If File.Exists(imgQ) Then
                    My.Computer.FileSystem.DeleteFile(imgQ)
                End If
                File.Move(imgP, imgQ)
                'File.Copy(imgP, imgQ, True)
                Try
                    cPagina.PasarPaginasQA(1, cod, Frm_Edi_CodTipo, 0, Frm_Principal.datosUsuario)
                Catch ex As Exception
                    MessageBox.Show("Error al actualizar datos de : " & cod, "Alerta Imagen", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End Try
            Else
                MessageBox.Show("No existe la imagen: " & imgP, "Alerta Imagen", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Next

        aArchivos.RedDesconectar(carpetaRaiz)
    End Sub


 
End Class