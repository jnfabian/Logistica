Imports System.IO
Imports System.Diagnostics
Imports System.Security.Principal

Public Class Frm_Empaste
    Public Frm_Emp_Control As Integer = 1
    Public Frm_Emp_CodAuxEmpaste As String = ""

    Public Frm_Emp_ControlEnviarEdicion As Integer = 0

    Public Frm_Emp_FilaSeleccionada As Integer = 0
    Public frm_Emp_FlatBusqueda As Integer = 0

    Dim valorBool As Integer = 0
    Dim aArchivos As New Clases.AccesoArchivos()
    Dim lErrorConexionRed As Long
    Dim carpetaRaiz As String = Configuration.ConfigurationManager.AppSettings("carpetaRaiz")


#Region "CODIGO SOLO PARA EMPASTE"
    Private Sub Frm_InventarioEdiciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargarCbxVisto()
        TlsGuardar.Enabled = False
        TlsEliminar.Enabled = False
        Dim NivelUsuario = VerificarUsuario()
        If NivelUsuario = 1 Then
            LblVisto.Visible = True
            CbxVisto.Visible = True
            CbxVisto.SelectedIndex = 1
        ElseIf NivelUsuario = 0 Then
            LblVisto.Visible = False
            CbxVisto.Visible = False
        End If
        CargarCbxEstadoEmpaste()
        CbxEstadoEmpaste.SelectedIndex = 0
        DeshabilitarCampos()
    End Sub

    Public Function VerificarUsuario() As Integer
        If Frm_Login.DgvDatosUsuario.Rows(0).Cells(10).Value = 1 Then
            Return 1
        ElseIf Frm_Login.DgvDatosUsuario.Rows(0).Cells(10).Value = 0 Then
            Return 0
        End If
    End Function

#Region "PESTAÑA EMPASTE"

    Private Sub Frm_Empaste_TlsNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Frm_Empaste_TlsNuevo.Click
        If String.IsNullOrEmpty(TxtCodIdentificacion.Text) Then
            HabilitarCampos()
            LimpiarCampos()
            Frm_Emp_CodAuxEmpaste = "" 'COD AUXILIAR
        Else
            Dim FrmCondicional As MsgBoxResult = MsgBox("Esta seguro de crear un empaste nuevo", MsgBoxStyle.YesNo, "Aviso")
            If FrmCondicional = MsgBoxResult.Yes Then
                HabilitarCampos()
                LimpiarCampos()
                Me.Height = 384
                Frm_Emp_CodAuxEmpaste = ""
            End If
        End If
        Frm_Emp_Control = 1
        TlsGuardar.Enabled = True
        TlsEliminar.Enabled = False
        TxtCodIdentificacion.Focus()
    End Sub

    Private Sub TlsGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TlsGuardar.Click
        Dim Valor = DateDiff("d", DtpFecInicio.Text, DtpFecTermino.Text)

        If TxtCodIdentificacion.MaxLength <> Len(TxtCodIdentificacion.Text) Then
            MsgBox("El código de identificación debe tener 11 caracteres", MsgBoxStyle.Exclamation, "Aviso")
            TxtCodIdentificacion.Focus()
        ElseIf String.IsNullOrEmpty(TxtCodIdentificacion.Text) Then
            MsgBox("Ingrese código de identificación", MsgBoxStyle.Exclamation, "Aviso")
            TxtCodIdentificacion.Focus()
        ElseIf Valor <= -1 Then
            MsgBox("La fecha de inicio no puede ser mayor que la fecha de término", MsgBoxStyle.Exclamation, "Aviso")
            DtpFecInicio.Focus()
        ElseIf String.IsNullOrEmpty(TxtLargo.Text) Then
            MsgBox("Ingrese el largo", MsgBoxStyle.Exclamation, "Aviso")
            TxtLargo.Focus()
        ElseIf String.IsNullOrEmpty(TxtAncho.Text) Then
            MsgBox("Ingrese el ancho", MsgBoxStyle.Exclamation, "Aviso")
            TxtAncho.Focus()
        ElseIf String.IsNullOrEmpty(TxtAltura.Text) Then
            MsgBox("Ingrese la altura", MsgBoxStyle.Exclamation, "Aviso")
            TxtAltura.Focus()
        ElseIf String.IsNullOrEmpty(TxtNumEdiciones.Text) Then
            MsgBox("Ingrese número de ediciones", MsgBoxStyle.Exclamation, "Aviso")
            TxtNumEdiciones.Focus()
        ElseIf String.IsNullOrEmpty(TxtNumSuplementos.Text) Then
            MsgBox("Ingrese número de suplementos", MsgBoxStyle.Exclamation, "Aviso")
            TxtNumSuplementos.Focus()
        ElseIf String.IsNullOrEmpty(TxtNumExtraordinario.Text) Then
            MsgBox("Ingrese número de Extraordinario", MsgBoxStyle.Exclamation, "Aviso")
            TxtNumExtraordinario.Focus()
            'ElseIf String.IsNullOrEmpty(TxtNumPaginas.Text) Then
            '    MsgBox("Ingrese número de páginas", MsgBoxStyle.Exclamation, "Aviso")
            '    TxtNumPaginas.Focus()
        ElseIf String.IsNullOrEmpty(TxtAnaquel.Text) Then
            MsgBox("Ingrese anaquel", MsgBoxStyle.Exclamation, "Aviso")
            TxtAnaquel.Focus()
        ElseIf String.IsNullOrEmpty(TxtNivel.Text) Then
            MsgBox("Ingrese nivel", MsgBoxStyle.Exclamation, "Aviso")
            TxtNivel.Focus()
        ElseIf Not String.IsNullOrEmpty(TxtCodIdentificacion.Text) Then
            Dim Gestionar As New Clases.C_Empaste
            Dim ValorDevueltoRegistrar As String = ""
            Dim ValorDevueltoModificar As String = ""
            Dim NivelUsuario = VerificarUsuario()
            Dim BuscarCodEmpaste As New Clases.C_Empaste
            If Frm_Emp_CodAuxEmpaste = "" And TxtCodIdentificacion.Text.ToString.Trim <> "" Then ' COD AUXILIAR
                Dim ValorBooleano_1 = BuscarCodEmpaste.BuscarEmpaste(1, TxtCodIdentificacion.Text.ToString.Trim)
                If ValorBooleano_1 = "NO" Then
                    MsgBox("Ya existe el código de identificación", MsgBoxStyle.Exclamation, "Aviso")
                    TxtCodIdentificacion.Focus()
                    TxtCodIdentificacion.SelectAll()
                ElseIf ValorBooleano_1 = "SI" Then
                    If NivelUsuario = 1 Then
                        ValorDevueltoRegistrar = Gestionar.Registrar_Empaste(1, "", DtpFecInicio.Text, DtpFecTermino.Text, TxtLargo.Text, TxtAncho.Text, TxtAltura.Text, CbxEstadoEmpaste.SelectedValue, TxtNumEdiciones.Text, TxtNumSuplementos.Text, TxtNumExtraordinario.Text, TxtNumPaginas.Text, TxtCodIdentificacion.Text, TxtEdicionesFaltantes.Text, CbxVisto.SelectedValue, TxtAnaquel.Text, TxtNivel.Text, TxtObservaciones.Text, Frm_Login.DgvDatosUsuario.Rows(0).Cells(0).Value)
                    ElseIf NivelUsuario = 0 Then
                        ValorDevueltoRegistrar = Gestionar.Registrar_Empaste(1, "", DtpFecInicio.Text, DtpFecTermino.Text, TxtLargo.Text, TxtAncho.Text, TxtAltura.Text, CbxEstadoEmpaste.SelectedValue, TxtNumEdiciones.Text, TxtNumSuplementos.Text, TxtNumExtraordinario.Text, TxtNumPaginas.Text, TxtCodIdentificacion.Text, TxtEdicionesFaltantes.Text, 2, TxtAnaquel.Text, TxtNivel.Text, TxtObservaciones.Text, Frm_Login.DgvDatosUsuario.Rows(0).Cells(0).Value)
                    End If
                    If ValorDevueltoRegistrar = TxtCodIdentificacion.Text Then
                        MsgBox("Empaste almacenado", MsgBoxStyle.Information, "Aviso")
                        MostrarEmpasteGuardado(TxtCodIdentificacion.Text) 'CARGA LA DATA DEL EMPASTE GUARDADO
                        Frm_Emp_CodAuxEmpaste = TxtCodIdentificacion.Text.ToString.Trim 'COD AUXILIAR
                        MostrarEdicion(TxtCodIdentificacion.Text)
                        TlsEliminar.Enabled = True
                        TpgDetalleEmpaste.Show()
                        Me.Height = 700
                    Else
                        MsgBox("Empaste no almacenado", MsgBoxStyle.Information, "Aviso")
                    End If
                End If

            ElseIf Frm_Emp_CodAuxEmpaste <> "" And Frm_Emp_CodAuxEmpaste = TxtCodIdentificacion.Text.ToString.Trim Then 'COD AUXILIAR


                If DgwEdicion.Rows.Count > 0 Then
                    Dim NEDR As Integer = 0 : Dim NSUR As Integer = 0 : Dim NSER As Integer = 0 : Dim NUMPAGINAS As Integer = 0
                    For i = 0 To DgwEdicion.Rows.Count - 1
                        If DgwEdicion.Rows(i).Cells(2).Value = 1 Then
                            NEDR = NEDR + 1
                        ElseIf DgwEdicion.Rows(i).Cells(2).Value = 2 Then
                            NSUR = NSUR + 1
                        ElseIf DgwEdicion.Rows(i).Cells(2).Value = 3 Then
                            NSER = NSER + 1
                        End If
                        NUMPAGINAS = NUMPAGINAS + DgwEdicion.Rows(i).Cells(5).Value
                    Next
                    If NEDR > TxtNumEdiciones.Text Then
                        MsgBox("No se puede modificar, ya que la cantidad de ediciones ingresadas, es mayor al número de ediciones registradas", MsgBoxStyle.Exclamation, "Aviso")
                    ElseIf NSUR > TxtNumSuplementos.Text Then
                        MsgBox("No se puede modificar, ya que la cantidad de suplementos ingresados, es mayor al número de suplementos registrados", MsgBoxStyle.Exclamation, "Aviso")
                    ElseIf NSER > TxtNumExtraordinario.Text Then
                        MsgBox("No se puede modificar, ya que la cantidad de extraordinario ingresados, es mayor al número de extraordinarios registrados", MsgBoxStyle.Exclamation, "Aviso")
                        'ElseIf NUMPAGINAS > TxtNumPaginas.Text Then
                        '   MsgBox("No se puede modificar, ya que la cantidad de páginas ingresadas, es mayor al número de páginas registradas", MsgBoxStyle.Exclamation, "Aviso")
                    Else
                        If NivelUsuario = 1 Then
                            ValorDevueltoModificar = Gestionar.Registrar_Empaste(2, Frm_Emp_CodAuxEmpaste, DtpFecInicio.Text, DtpFecTermino.Text, TxtLargo.Text, TxtAncho.Text, TxtAltura.Text, CbxEstadoEmpaste.SelectedValue, TxtNumEdiciones.Text, TxtNumSuplementos.Text, TxtNumExtraordinario.Text, TxtNumPaginas.Text, TxtCodIdentificacion.Text, TxtEdicionesFaltantes.Text, CbxVisto.SelectedValue, TxtAnaquel.Text, TxtNivel.Text, TxtObservaciones.Text, Frm_Login.DgvDatosUsuario.Rows(0).Cells(0).Value) 'COD AUXILIAR
                        ElseIf NivelUsuario = 0 Then
                            ValorDevueltoModificar = Gestionar.Registrar_Empaste(2, Frm_Emp_CodAuxEmpaste, DtpFecInicio.Text, DtpFecTermino.Text, TxtLargo.Text, TxtAncho.Text, TxtAltura.Text, CbxEstadoEmpaste.SelectedValue, TxtNumEdiciones.Text, TxtNumSuplementos.Text, TxtNumExtraordinario.Text, TxtNumPaginas.Text, TxtCodIdentificacion.Text, TxtEdicionesFaltantes.Text, 2, TxtAnaquel.Text, TxtNivel.Text, TxtObservaciones.Text, Frm_Login.DgvDatosUsuario.Rows(0).Cells(0).Value) 'COD AUXILIAR
                        End If
                        If ValorDevueltoModificar = TxtCodIdentificacion.Text Then
                            MsgBox("Empaste actualizado", MsgBoxStyle.Information, "Aviso")
                            TpgDetalleEmpaste.Show()
                            Me.Height = 700
                            MostrarEmpasteGuardado(TxtCodIdentificacion.Text) 'CARGA LA DATA DEL EMPASTE GUARDADO
                            MostrarEdicion(TxtCodIdentificacion.Text)
                            TlsEliminar.Enabled = True
                        Else
                            MsgBox("Empaste no actualizado", MsgBoxStyle.Information, "Aviso")
                        End If
                    End If
                Else
                    If NivelUsuario = 1 Then
                        ValorDevueltoModificar = Gestionar.Registrar_Empaste(2, Frm_Emp_CodAuxEmpaste, DtpFecInicio.Text, DtpFecTermino.Text, TxtLargo.Text, TxtAncho.Text, TxtAltura.Text, CbxEstadoEmpaste.SelectedValue, TxtNumEdiciones.Text, TxtNumSuplementos.Text, TxtNumExtraordinario.Text, TxtNumPaginas.Text, TxtCodIdentificacion.Text, TxtEdicionesFaltantes.Text, CbxVisto.SelectedValue, TxtAnaquel.Text, TxtNivel.Text, TxtObservaciones.Text, Frm_Login.DgvDatosUsuario.Rows(0).Cells(0).Value) 'COD AUXILIAR
                    ElseIf NivelUsuario = 0 Then
                        ValorDevueltoModificar = Gestionar.Registrar_Empaste(2, Frm_Emp_CodAuxEmpaste, DtpFecInicio.Text, DtpFecTermino.Text, TxtLargo.Text, TxtAncho.Text, TxtAltura.Text, CbxEstadoEmpaste.SelectedValue, TxtNumEdiciones.Text, TxtNumSuplementos.Text, TxtNumExtraordinario.Text, TxtNumPaginas.Text, TxtCodIdentificacion.Text, TxtEdicionesFaltantes.Text, 2, TxtAnaquel.Text, TxtNivel.Text, TxtObservaciones.Text, Frm_Login.DgvDatosUsuario.Rows(0).Cells(0).Value) 'COD AUXILIAR
                    End If
                    If ValorDevueltoModificar = TxtCodIdentificacion.Text Then
                        MsgBox("Empaste actualizado", MsgBoxStyle.Information, "Aviso")
                        TpgDetalleEmpaste.Show()
                        Me.Height = 700
                        MostrarEmpasteGuardado(TxtCodIdentificacion.Text) 'CARGA LA DATA DEL EMPASTE GUARDADO
                        MostrarEdicion(TxtCodIdentificacion.Text)
                        TlsEliminar.Enabled = True
                    Else
                        MsgBox("Empaste no actualizado", MsgBoxStyle.Information, "Aviso")
                    End If
                End If

            ElseIf Frm_Emp_CodAuxEmpaste <> "" And Frm_Emp_CodAuxEmpaste <> TxtCodIdentificacion.Text.ToString.Trim Then 'COD AUXILIAR


                If DgwEdicion.Rows.Count > 0 Then
                    Dim NEDR As Integer = 0 : Dim NSUR As Integer = 0 : Dim NSER As Integer = 0 : Dim NUMPAGINAS As Integer = 0
                    For i = 0 To DgwEdicion.Rows.Count - 1
                        If DgwEdicion.Rows(i).Cells(2).Value = 1 Then
                            NEDR = NEDR + 1
                        ElseIf DgwEdicion.Rows(i).Cells(2).Value = 2 Then
                            NSUR = NSUR + 1
                        ElseIf DgwEdicion.Rows(i).Cells(2).Value = 3 Then
                            NSER = NSER + 1
                        End If
                        NUMPAGINAS = NUMPAGINAS + DgwEdicion.Rows(i).Cells(5).Value
                    Next
                    If NEDR > TxtNumEdiciones.Text Then
                        MsgBox("No se puede modificar, ya que la cantidad de ediciones ingresadas, es mayor al número de ediciones registradas", MsgBoxStyle.Exclamation, "Aviso")
                    ElseIf NSUR > TxtNumSuplementos.Text Then
                        MsgBox("No se puede modificar, ya que la cantidad de suplementos ingresados, es mayor al número de suplementos registrados", MsgBoxStyle.Exclamation, "Aviso")
                    ElseIf NSER > TxtNumExtraordinario.Text Then
                        MsgBox("No se puede modificar, ya que la cantidad de extraordinario ingresados, es mayor al número de extraordinarios registrados", MsgBoxStyle.Exclamation, "Aviso")
                    ElseIf NUMPAGINAS > TxtNumPaginas.Text Then
                        MsgBox("No se puede modificar, ya que la cantidad de páginas ingresadas, es menor al mayor de páginas registradas", MsgBoxStyle.Exclamation, "Aviso")
                    Else
                        Dim ValorBooleano_2 = BuscarCodEmpaste.BuscarEmpaste(1, TxtCodIdentificacion.Text.ToString.Trim)
                        If ValorBooleano_2 = "SI" Then
                            Dim BuscarCodEmpasteEnDetalle As New Clases.C_Empaste
                            Dim ValorBooleano_3 = BuscarCodEmpasteEnDetalle.BuscarEmpaste(2, Frm_Emp_CodAuxEmpaste) ' COD AUXILIAR
                            If ValorBooleano_3 = "SI" Then
                                If NivelUsuario = 1 Then
                                    ValorDevueltoModificar = Gestionar.Registrar_Empaste(2, Frm_Emp_CodAuxEmpaste, DtpFecInicio.Text, DtpFecTermino.Text, TxtLargo.Text, TxtAncho.Text, TxtAltura.Text, CbxEstadoEmpaste.SelectedValue, TxtNumEdiciones.Text, TxtNumSuplementos.Text, TxtNumExtraordinario.Text, TxtNumPaginas.Text, TxtCodIdentificacion.Text, TxtEdicionesFaltantes.Text, CbxVisto.SelectedValue, TxtAnaquel.Text, TxtNivel.Text, TxtObservaciones.Text, Frm_Login.DgvDatosUsuario.Rows(0).Cells(0).Value) 'COD AUXILIAR
                                Else
                                    ValorDevueltoModificar = Gestionar.Registrar_Empaste(2, Frm_Emp_CodAuxEmpaste, DtpFecInicio.Text, DtpFecTermino.Text, TxtLargo.Text, TxtAncho.Text, TxtAltura.Text, CbxEstadoEmpaste.SelectedValue, TxtNumEdiciones.Text, TxtNumSuplementos.Text, TxtNumExtraordinario.Text, TxtNumPaginas.Text, TxtCodIdentificacion.Text, TxtEdicionesFaltantes.Text, 0, TxtAnaquel.Text, TxtNivel.Text, TxtObservaciones.Text, Frm_Login.DgvDatosUsuario.Rows(0).Cells(0).Value) 'COD AUXILIAR
                                End If
                                If ValorDevueltoModificar = TxtCodIdentificacion.Text Then
                                    MsgBox("Empaste actualizado", MsgBoxStyle.Information, "Aviso")
                                    MostrarEmpasteGuardado(TxtCodIdentificacion.Text) 'CARGA LA DATA DEL EMPASTE GUARDADO
                                    Frm_Emp_CodAuxEmpaste = TxtCodIdentificacion.Text.ToString.Trim ' COD AUXILIAR
                                    MostrarEdicion(TxtCodIdentificacion.Text)
                                    TlsEliminar.Enabled = True
                                    TpgDetalleEmpaste.Show()
                                    Me.Height = 700
                                Else
                                    MsgBox("Empaste no actualizado", MsgBoxStyle.Information, "Aviso")
                                End If
                            ElseIf ValorBooleano_3 = "NO" Then
                                MsgBox("No se puede modificar el Empaste, ya que contiene ediciones registradas", MsgBoxStyle.Exclamation, "Aviso")
                            End If
                        Else
                            MsgBox("Ya existe el código de identificación", MsgBoxStyle.Exclamation, "Aviso")
                            TxtCodIdentificacion.Focus()
                            TxtCodIdentificacion.SelectAll()
                        End If

                    End If
                Else
                    Dim ValorBooleano_2 = BuscarCodEmpaste.BuscarEmpaste(1, TxtCodIdentificacion.Text.ToString.Trim)
                    If ValorBooleano_2 = "SI" Then
                        Dim BuscarCodEmpasteEnDetalle As New Clases.C_Empaste
                        Dim ValorBooleano_3 = BuscarCodEmpasteEnDetalle.BuscarEmpaste(2, Frm_Emp_CodAuxEmpaste) ' COD AUXILIAR
                        If ValorBooleano_3 = "SI" Then
                            If NivelUsuario = 1 Then
                                ValorDevueltoModificar = Gestionar.Registrar_Empaste(2, Frm_Emp_CodAuxEmpaste, DtpFecInicio.Text, DtpFecTermino.Text, TxtLargo.Text, TxtAncho.Text, TxtAltura.Text, CbxEstadoEmpaste.SelectedValue, TxtNumEdiciones.Text, TxtNumSuplementos.Text, TxtNumExtraordinario.Text, TxtNumPaginas.Text, TxtCodIdentificacion.Text, TxtEdicionesFaltantes.Text, CbxVisto.SelectedValue, TxtAnaquel.Text, TxtNivel.Text, TxtObservaciones.Text, Frm_Login.DgvDatosUsuario.Rows(0).Cells(0).Value) 'COD AUXILIAR
                            Else
                                ValorDevueltoModificar = Gestionar.Registrar_Empaste(2, Frm_Emp_CodAuxEmpaste, DtpFecInicio.Text, DtpFecTermino.Text, TxtLargo.Text, TxtAncho.Text, TxtAltura.Text, CbxEstadoEmpaste.SelectedValue, TxtNumEdiciones.Text, TxtNumSuplementos.Text, TxtNumExtraordinario.Text, TxtNumPaginas.Text, TxtCodIdentificacion.Text, TxtEdicionesFaltantes.Text, 0, TxtAnaquel.Text, TxtNivel.Text, TxtObservaciones.Text, Frm_Login.DgvDatosUsuario.Rows(0).Cells(0).Value) 'COD AUXILIAR
                            End If
                            If ValorDevueltoModificar = TxtCodIdentificacion.Text Then
                                MsgBox("Empaste actualizado", MsgBoxStyle.Information, "Aviso")
                                MostrarEmpasteGuardado(TxtCodIdentificacion.Text) 'CARGA LA DATA DEL EMPASTE GUARDADO
                                Frm_Emp_CodAuxEmpaste = TxtCodIdentificacion.Text.ToString.Trim ' COD AUXILIAR
                                MostrarEdicion(TxtCodIdentificacion.Text)
                                TlsEliminar.Enabled = True
                                TpgDetalleEmpaste.Show()
                                Me.Height = 700
                            Else
                                MsgBox("Empaste no actualizado", MsgBoxStyle.Information, "Aviso")
                            End If
                        ElseIf ValorBooleano_3 = "NO" Then
                            MsgBox("No se puede modificar el Empaste, ya que contiene ediciones registradas", MsgBoxStyle.Exclamation, "Aviso")
                        End If
                    Else
                        MsgBox("Ya existe el código de identificación", MsgBoxStyle.Exclamation, "Aviso")
                        TxtCodIdentificacion.Focus()
                        TxtCodIdentificacion.SelectAll()
                    End If
                End If

            End If
        End If
        Frm_Emp_Control = 1
    End Sub

    Private Sub TpgBusqueda_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TpgBusqueda.TextChanged
        Me.Height = 384
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 1 Then
            Me.Height = 384
        ElseIf TabControl1.SelectedIndex = 0 And Frm_Emp_CodAuxEmpaste <> "" Then
            Me.Height = 700
        ElseIf TabControl1.SelectedIndex = 0 And Frm_Emp_CodAuxEmpaste = "" Then
            Me.Height = 384
        End If
    End Sub

    Public Sub MostrarEmpasteGuardado(ByVal CodEmpaste As String)
        Dim Gestionar As New Clases.C_Empaste
        DgvEmpasteGuardado.DataSource = Gestionar.CargarDatos(3, CodEmpaste, "")
        DgvEmpasteGuardado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Public Sub CargarCbxVisto()
        Dim CPrioridad As New Clases.C_Empaste
        Dim RecuperarDato = CPrioridad.CargarDatos(1, "", "")
        CbxVisto.DataSource = RecuperarDato
        CbxVisto.ValueMember = RecuperarDato.Columns(0).ToString.Trim
        CbxVisto.DisplayMember = RecuperarDato.Columns(1).ToString.Trim
    End Sub

    Public Sub CargarCbxEstadoEmpaste()
        Dim CPrioridad As New Clases.C_Empaste
        Dim RecuperarDato = CPrioridad.CargarDatos(2, "", "")
        CbxEstadoEmpaste.DataSource = RecuperarDato
        CbxEstadoEmpaste.ValueMember = RecuperarDato.Columns(0).ToString.Trim
        CbxEstadoEmpaste.DisplayMember = RecuperarDato.Columns(1).ToString.Trim
    End Sub

    Public Sub DeshabilitarCampos()
        DtpFecInicio.Enabled = False : DtpFecTermino.Enabled = False : TxtLargo.Enabled = False : TxtAncho.Enabled = False
        TxtAltura.Enabled = False : TxtNumEdiciones.Enabled = False : TxtNumExtraordinario.Enabled = False : TxtCodIdentificacion.Enabled = False
        TxtNumPaginas.Enabled = False : TxtEdicionesFaltantes.Enabled = False : TxtAnaquel.Enabled = False : TxtNivel.Enabled = False
        CbxVisto.Enabled = False : TxtObservaciones.Enabled = False : CbxEstadoEmpaste.Enabled = False : TxtNumSuplementos.Enabled = False
    End Sub

    Public Sub HabilitarCampos()
        DtpFecInicio.Enabled = True : DtpFecTermino.Enabled = True : TxtLargo.Enabled = True : TxtAncho.Enabled = True
        TxtAltura.Enabled = True : TxtNumEdiciones.Enabled = True : TxtNumExtraordinario.Enabled = True : TxtCodIdentificacion.Enabled = True
        'TxtNumPaginas.Enabled = True : TxtEdicionesFaltantes.Enabled = True : TxtAnaquel.Enabled = True : TxtNivel.Enabled = True
        TxtEdicionesFaltantes.Enabled = True : TxtAnaquel.Enabled = True : TxtNivel.Enabled = True
        CbxVisto.Enabled = True : TxtObservaciones.Enabled = True : CbxEstadoEmpaste.Enabled = True : TxtNumSuplementos.Enabled = True
    End Sub

    Public Sub LimpiarCampos()
        DtpFecInicio.Text = Date.Now : DtpFecTermino.Text = Date.Now : TxtLargo.Text = "" : TxtAncho.Text = ""
        TxtAltura.Text = "" : TxtNumEdiciones.Text = "" : TxtNumSuplementos.Text = "" : TxtNumExtraordinario.Text = ""
        TxtCodIdentificacion.Text = "" : TxtNumPaginas.Text = "0" : TxtEdicionesFaltantes.Text = "" : TxtAnaquel.Text = ""
        TxtNivel.Text = "" : TxtObservaciones.Text = ""
        CbxEstadoEmpaste.SelectedIndex = 0
        Dim NivelUsuario = VerificarUsuario()
        If NivelUsuario = 1 Then
            CbxVisto.SelectedIndex = 1
        End If
    End Sub

    Private Sub TlsEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TlsEliminar.Click
        If Frm_Emp_CodAuxEmpaste <> "" Then
            Dim BuscarCodEmpasteEnDetalle As New Clases.C_Empaste
            Dim ValorBooleano_4 = BuscarCodEmpasteEnDetalle.BuscarEmpaste(1, Frm_Emp_CodAuxEmpaste) 'COD AUXILIAR
            If ValorBooleano_4 = "NO" Then
                Dim ValorBooleano_3 = BuscarCodEmpasteEnDetalle.BuscarEmpaste(2, Frm_Emp_CodAuxEmpaste) 'COD AUXILIAR
                If ValorBooleano_3 = "SI" Then
                    Dim FrmCondicional As MsgBoxResult = MsgBox("Esta seguro de eliminar el empaste", MsgBoxStyle.YesNo, "Aviso")
                    If FrmCondicional = MsgBoxResult.Yes Then
                        Dim Gestionar As New Clases.C_Empaste
                        Dim Valordevuelto = Gestionar.Registrar_Empaste(3, "", DateTime.Now, DateTime.Now, 0, 0, 0, 0, 0, 0, 0, 0, Frm_Emp_CodAuxEmpaste, "", 0, 0, 0, "", Frm_Login.DgvDatosUsuario.Rows(0).Cells(0).Value) 'COD AUXILIAR
                        If Valordevuelto = "ELIMINADO" Then
                            MsgBox("Empaste Eliminado", MsgBoxStyle.Information, "Aviso")
                            If DgwEmpasteBusqueda.Rows.Count > 0 Then
                                BtnBuscar_Click(sender, e)
                            End If
                            LimpiarCampos()
                            Frm_Emp_CodAuxEmpaste = "" 'COD AUXILIAR
                            Me.Height = 384
                            TxtCodIdentificacion.Focus()
                        Else
                            MsgBox("Empaste No Eliminado", MsgBoxStyle.Information, "Aviso")
                        End If
                    End If
                ElseIf ValorBooleano_3 = "NO" Then
                    MsgBox("No se puede eliminar el Empaste, ya que tiene detalle(s) registrados", MsgBoxStyle.Exclamation, "Aviso")
                End If
            Else
                MsgBox("No se puede eliminar el empaste, ya que no existe el código de identificación", MsgBoxStyle.Exclamation, "Aviso")
            End If


        Else
            MsgBox("Debe Seleccionar un empaste y/o guardar un empaste para poder eliminar", MsgBoxStyle.Exclamation, "Aviso")
        End If
    End Sub

#End Region
#Region "VALIDACIONES"

    Private Sub TxtNumEdiciones_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNumEdiciones.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub TxtNumSuplementos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNumSuplementos.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub TxtNumPaginas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNumPaginas.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub TxtAnaquel_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtAnaquel.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub TxtNivel_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNivel.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub TxtLargo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtLargo.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub TxtAncho_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtAncho.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub TxtAltura_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtAltura.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub TxtCodIdentificacion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCodIdentificacion.KeyPress
        If InStr(1, "QwEeRrTtYyUuIiOoPpAaSsDdFfGgHhJjKkLlÑñZzXxCcVvBbNnMm0123456789-" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub TxtSemestre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNumExtraordinario.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub TxtCodIdentificacion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCodIdentificacion.TextChanged
        TxtCodIdentificacion.CharacterCasing = CharacterCasing.Upper
    End Sub

#End Region
#Region "PESTAÑA BUSCAR EMPASTE"

    Private Sub TxtObservacionEmpasteBusqueda_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtObservacionEmpasteBusqueda.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnBuscar_Click(sender, e)
        End If
    End Sub


    Private Sub TxtCodIdentificacionBusqueda_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCodIdentificacionBusqueda.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnBuscar_Click(sender, e)
        End If
    End Sub

    Private Sub TxtCodIdentificacionBusqueda_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCodIdentificacionBusqueda.KeyPress
        If InStr(1, "QwEeRrTtYyUuIiOoPpAaSsDdFfGgHhJjKkLlÑñZzXxCcVvBbNnMm0123456789-" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub TxtCodIdentificacionBusqueda_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCodIdentificacionBusqueda.TextChanged
        TxtCodIdentificacionBusqueda.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub TlsSeleccionarEmpaste_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TlsSeleccionarEmpaste.Click
        SeleccionarEmpaste()
        TlsGuardar.Enabled = True
        TlsEliminar.Enabled = True
        Me.Height = 700
    End Sub

    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
        Dim Gestionar As New Clases.C_Empaste
        DgwEmpasteBusqueda.DataSource = Gestionar.CargarDatos(3, TxtCodIdentificacionBusqueda.Text.ToString.Trim, TxtObservacionEmpasteBusqueda.Text)
        DgwEmpasteBusqueda.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        CrearColumnasDataGridViewEmpasteBuscado()
        frm_Emp_FlatBusqueda = 1
    End Sub

    Private Sub DgwEmpasteBusqueda_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgwEmpasteBusqueda.CellClick
        If DgwEmpasteBusqueda.Rows.Count > 0 Then
            Frm_Emp_CodAuxEmpaste = DgwEmpasteBusqueda.SelectedCells(0).Value 'COD AUXILIAR
        End If
    End Sub

    Private Sub DgwEmpasteBusqueda_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgwEmpasteBusqueda.CellDoubleClick
        If DgwEmpasteBusqueda.Rows.Count > 0 Then
            SeleccionarEmpaste()
            TlsGuardar.Enabled = True
            TlsEliminar.Enabled = True
            TpgDetalleEmpaste.Show()
            Me.Height = 700
        End If
    End Sub

    Public Sub CrearColumnasDataGridViewEmpasteBuscado()
        DgwEmpasteBusqueda.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DgwEmpasteBusqueda.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DgwEmpasteBusqueda.DefaultCellStyle.BackColor = Color.AliceBlue
        DgwEmpasteBusqueda.Columns.Item(0).SortMode = DataGridViewColumnSortMode.NotSortable
        DgwEmpasteBusqueda.Columns.Item(0).HeaderText = "Cod. identificación"
        DgwEmpasteBusqueda.Columns.Item(1).Visible = False
        DgwEmpasteBusqueda.Columns.Item(2).Visible = False
        DgwEmpasteBusqueda.Columns.Item(3).Visible = False
        DgwEmpasteBusqueda.Columns.Item(4).SortMode = DataGridViewColumnSortMode.NotSortable
        DgwEmpasteBusqueda.Columns.Item(4).HeaderText = "N. de Ediciones"
        DgwEmpasteBusqueda.Columns.Item(5).SortMode = DataGridViewColumnSortMode.NotSortable
        DgwEmpasteBusqueda.Columns.Item(5).HeaderText = "N. de Suplementos"
        DgwEmpasteBusqueda.Columns.Item(6).SortMode = DataGridViewColumnSortMode.NotSortable
        DgwEmpasteBusqueda.Columns.Item(6).HeaderText = "N. de Extraordinarios"

        DgwEmpasteBusqueda.Columns.Item(7).SortMode = DataGridViewColumnSortMode.NotSortable
        DgwEmpasteBusqueda.Columns.Item(7).HeaderText = "N. de Páginas"

        DgwEmpasteBusqueda.Columns.Item(8).SortMode = DataGridViewColumnSortMode.NotSortable
        DgwEmpasteBusqueda.Columns.Item(8).HeaderText = "Fec. Inicio"
        DgwEmpasteBusqueda.Columns.Item(9).SortMode = DataGridViewColumnSortMode.NotSortable
        DgwEmpasteBusqueda.Columns.Item(9).HeaderText = "Fec. Término"
        DgwEmpasteBusqueda.Columns.Item(10).Visible = False
        DgwEmpasteBusqueda.Columns.Item(11).Visible = False
        DgwEmpasteBusqueda.Columns.Item(12).Visible = False
        DgwEmpasteBusqueda.Columns.Item(13).Visible = False
        DgwEmpasteBusqueda.Columns.Item(14).Visible = False
        DgwEmpasteBusqueda.Columns.Item(15).Visible = False
        DgwEmpasteBusqueda.Columns.Item(0).Width = 100
    End Sub

    Public Sub SeleccionarEmpaste()
        If DgwEmpasteBusqueda.Rows.Count > 0 Then
            TxtCodIdentificacion.Text = DgwEmpasteBusqueda.SelectedCells(0).Value
            TxtLargo.Text = DgwEmpasteBusqueda.SelectedCells(1).Value
            TxtAncho.Text = DgwEmpasteBusqueda.SelectedCells(2).Value
            TxtAltura.Text = DgwEmpasteBusqueda.SelectedCells(3).Value
            TxtNumEdiciones.Text = DgwEmpasteBusqueda.SelectedCells(4).Value
            TxtNumSuplementos.Text = DgwEmpasteBusqueda.SelectedCells(5).Value
            TxtNumExtraordinario.Text = DgwEmpasteBusqueda.SelectedCells(6).Value
            TxtNumPaginas.Text = DgwEmpasteBusqueda.SelectedCells(7).Value
            DtpFecInicio.Text = DgwEmpasteBusqueda.SelectedCells(8).Value
            DtpFecTermino.Text = DgwEmpasteBusqueda.SelectedCells(9).Value
            TxtEdicionesFaltantes.Text = DgwEmpasteBusqueda.SelectedCells(10).Value
            TxtAnaquel.Text = DgwEmpasteBusqueda.SelectedCells(11).Value
            TxtNivel.Text = DgwEmpasteBusqueda.SelectedCells(12).Value
            CbxEstadoEmpaste.SelectedValue = DgwEmpasteBusqueda.SelectedCells(13).Value
            CbxVisto.SelectedValue = DgwEmpasteBusqueda.SelectedCells(14).Value
            TxtObservaciones.Text = DgwEmpasteBusqueda.SelectedCells(15).Value
            TpgEmpasteIngreso.Show()
            HabilitarCampos()
            Frm_Emp_Control = 2
            Frm_Emp_CodAuxEmpaste = DgwEmpasteBusqueda.SelectedCells(0).Value ' COD AUXILIAR
            MostrarEdicion(Frm_Emp_CodAuxEmpaste) 'COD AUXLIAR
        End If
    End Sub

#End Region
#End Region

#Region "CODIGO SOLO PARA EDICION"

    Private Sub DgwEdicion_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgwEdicion.CellClick
        If e.RowIndex = -1 Then
            Return
        End If

        If DgwEdicion.Rows.Count > 0 Then
            TlsEliminarEdicion.Enabled = True
            TlsModificarEdicion.Enabled = True
            Frm_Emp_FilaSeleccionada = e.RowIndex

            Dim estado As String = DgwEdicion.Rows(e.RowIndex).Cells("CodEstado").Value

            If Not DgwEdicion.Columns("CargarPDF") Is Nothing Then
                If e.ColumnIndex = DgwEdicion.Rows(e.RowIndex).Cells("CargarPDF").ColumnIndex And e.RowIndex <> -1 And (estado = "PP" Or estado = "EI" Or estado = "ER") Then
                    If DgwEdicion.Rows(e.RowIndex).Cells("CargarPDF").Value = 1 Then
                        DgwEdicion.Rows(e.RowIndex).Cells("CargarPDF").Value = 0
                    Else
                        DgwEdicion.Rows(e.RowIndex).Cells("CargarPDF").Value = 1
                    End If
                End If
            End If
        Else
            TlsEliminarEdicion.Enabled = False
            TlsModificarEdicion.Enabled = False
        End If
    End Sub

    Private Sub TlsEliminarEdicion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TlsEliminarEdicion.Click
        If DgwEdicion.Rows.Count > 0 Then
            Dim BuscarCodEdicionPaginas As New Clases.C_Edicion
            Dim ValorBooleano_4 = BuscarCodEdicionPaginas.BuscarEdicion(2, DgwEdicion.SelectedCells(0).Value, DgwEdicion.SelectedCells(1).Value, DgwEdicion.SelectedCells(2).Value)
            If ValorBooleano_4 = "SI" Then
                Dim FrmCondicional As MsgBoxResult = MsgBox("Esta seguro de eliminar", MsgBoxStyle.YesNo, "Aviso")
                If FrmCondicional = MsgBoxResult.Yes Then
                    Dim Gestionar As New Clases.C_Edicion
                    Dim Valordevuelto = Gestionar.Gestionar_Edicion(2, DgwEdicion.SelectedCells(0).Value, "", DgwEdicion.SelectedCells(1).Value, DgwEdicion.SelectedCells(2).Value, 0, 0, DateTime.Now, "", "", "", "", "", "", "", Frm_Login.DgvDatosUsuario.Rows(0).Cells(0).Value, "", "")
                    If Valordevuelto = "ELIMINADO" Then
                        MsgBox("Detalle de empaste con código " & DgwEdicion.SelectedCells(1).Value & " Eliminado", MsgBoxStyle.Information, "Aviso")
                        MostrarEdicion(Frm_Emp_CodAuxEmpaste) 'COD AUXILIAR
                    Else
                        MsgBox("Detalle de empaste con código " & DgwEdicion.SelectedCells(1).Value & " no Eliminado", MsgBoxStyle.Information, "Aviso")
                    End If
                End If
            ElseIf ValorBooleano_4 = "NO" Then
                MsgBox("No se puede eliminar el detalle de empaste, ya que contiene páginas registradas", MsgBoxStyle.Exclamation, "Aviso")
            End If
        Else
            MsgBox("No existe registros a eliminar", MsgBoxStyle.Exclamation, "Aviso")
        End If
    End Sub

    Private Sub TlsModificarEdicion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TlsModificarEdicion.Click
        ModificarEdicion()
    End Sub

    Public Sub MostrarEdicion(ByVal CodIdentificacion As String)
        Dim Observacion As String = Me.TxtObservacionEmpasteBusqueda.Text
        Dim mostrar As New Clases.C_Edicion
        DgwEdicion.DataSource = Nothing
        DgwEdicion.Columns.Clear()
        Dim nc As Integer = DgwEdicion.Columns.Count
        DgwEdicion.DataSource = mostrar.CargarDatos(2, CodIdentificacion, Observacion)
        'DgwEdicion.Refresh()
        CrearColumnasEdicion()
    End Sub

    Public Sub CrearColumnasEdicion()
        DgwEdicion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DgwEdicion.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DgwEmpasteBusqueda.DefaultCellStyle.BackColor = Color.AliceBlue
        DgwEdicion.Columns.Item(0).Visible = False
        DgwEdicion.Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
        DgwEdicion.Columns.Item(1).Width = 100
        DgwEdicion.Columns.Item(1).HeaderText = "Cod. identificación"
        DgwEdicion.Columns.Item(1).Name = "codigoIdentificacion"

        DgwEdicion.Columns.Item(2).Visible = False
        DgwEdicion.Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable
        DgwEdicion.Columns.Item(3).HeaderText = "Tipo"
        DgwEdicion.Columns(4).SortMode = DataGridViewColumnSortMode.NotSortable
        DgwEdicion.Columns.Item(4).HeaderText = "N. de edición"
        DgwEdicion.Columns(5).SortMode = DataGridViewColumnSortMode.NotSortable
        DgwEdicion.Columns.Item(5).HeaderText = "N. de Páginas"
        DgwEdicion.Columns.Item(5).Width = 40
        DgwEdicion.Columns(6).SortMode = DataGridViewColumnSortMode.NotSortable
        DgwEdicion.Columns.Item(6).HeaderText = "Fecha"
        DgwEdicion.Columns.Item(7).Visible = False
        DgwEdicion.Columns.Item(8).Visible = False
        For i = 0 To DgwEdicion.Rows.Count - 1
            If DgwEdicion.Rows(i).Cells(9).Value = "S" Then
                DgwEdicion.Rows(i).Cells(9).Value = "SI"
            Else
                DgwEdicion.Rows(i).Cells(9).Value = "NO"
            End If
            If DgwEdicion.Rows(i).Cells(10).Value = "S" Then
                DgwEdicion.Rows(i).Cells(10).Value = "SI"
            Else
                DgwEdicion.Rows(i).Cells(10).Value = "NO"
            End If
            If DgwEdicion.Rows(i).Cells(11).Value = "S" Then
                DgwEdicion.Rows(i).Cells(11).Value = "SI"
            Else
                DgwEdicion.Rows(i).Cells(11).Value = "NO"
            End If
            If DgwEdicion.Rows(i).Cells(12).Value = "S" Then
                DgwEdicion.Rows(i).Cells(12).Value = "SI"
            Else
                DgwEdicion.Rows(i).Cells(12).Value = "NO"
            End If
        Next
        DgwEdicion.Columns(9).SortMode = DataGridViewColumnSortMode.NotSortable
        DgwEdicion.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgwEdicion.Columns.Item(9).HeaderText = "Bueno"
        DgwEdicion.Columns.Item(9).Width = 40
        DgwEdicion.Columns(10).SortMode = DataGridViewColumnSortMode.NotSortable
        DgwEdicion.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgwEdicion.Columns.Item(10).HeaderText = "Delgado"
        DgwEdicion.Columns.Item(10).Width = 40
        DgwEdicion.Columns(11).SortMode = DataGridViewColumnSortMode.NotSortable
        DgwEdicion.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgwEdicion.Columns.Item(11).HeaderText = "Grueso"
        DgwEdicion.Columns.Item(11).Width = 40
        DgwEdicion.Columns(12).SortMode = DataGridViewColumnSortMode.NotSortable
        DgwEdicion.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgwEdicion.Columns.Item(12).HeaderText = "Deteriorado"
        DgwEdicion.Columns.Item(12).Width = 40
        DgwEdicion.Columns.Item(13).Visible = False

        DgwEdicion.Columns(14).SortMode = DataGridViewColumnSortMode.NotSortable
        DgwEdicion.Columns(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgwEdicion.Columns.Item(14).HeaderText = "PDF"
        DgwEdicion.Columns.Item(14).Name = "PdfP"
        DgwEdicion.Columns.Item(14).Width = 200

        DgwEdicion.Columns(15).SortMode = DataGridViewColumnSortMode.NotSortable
        DgwEdicion.Columns(15).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgwEdicion.Columns.Item(15).HeaderText = "CodEstado"
        DgwEdicion.Columns.Item(15).Name = "CodEstado"
        DgwEdicion.Columns.Item(15).Visible = False

        DgwEdicion.Columns(16).SortMode = DataGridViewColumnSortMode.NotSortable
        DgwEdicion.Columns(16).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgwEdicion.Columns.Item(16).HeaderText = "Estado"
        DgwEdicion.Columns.Item(16).Name = "Estado"
        DgwEdicion.Columns.Item(16).Width = 80

        DgwEdicion.Columns(17).SortMode = DataGridViewColumnSortMode.NotSortable
        DgwEdicion.Columns(17).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgwEdicion.Columns.Item(17).HeaderText = "Titulo"
        DgwEdicion.Columns.Item(17).Name = "Titulo"
        DgwEdicion.Columns.Item(17).Visible = False

        DgwEdicion.Columns(18).SortMode = DataGridViewColumnSortMode.NotSortable
        DgwEdicion.Columns(18).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgwEdicion.Columns.Item(18).HeaderText = "SubTitulo"
        DgwEdicion.Columns.Item(18).Name = "SubTitulo"
        DgwEdicion.Columns.Item(18).Visible = False

        'DgwEdicion.Columns.Add(ColCheckBox)
        If DgwEdicion.Columns("CargarPDF") Is Nothing Then
            Dim ColCheckBox As New DataGridViewCheckBoxColumn
            DgwEdicion.Columns.Insert(DgwEdicion.Columns.Count, ColCheckBox)
            With ColCheckBox
                .HeaderText = "Procesar"
                .Name = "CargarPDF"
                .Width = 50
                .TrueValue = 1
                .FalseValue = 0
                .DefaultCellStyle.BackColor = Color.LightSteelBlue
                .DisplayIndex = 0
                .Frozen = False
            End With
            'DgwEdicion.Columns.Add(ColCheckBox)
            'DgwPaginas.Columns.Add(ColCheckBox)
        End If

        DgwEdicion.Refresh()

        If DgwEdicion.Rows.Count > 0 Then
            TlsModificarEdicion.Enabled = True
            TlsEliminarEdicion.Enabled = True
            TxtCodIdentificacion.Text = Frm_Emp_CodAuxEmpaste
            TxtCodIdentificacion.Enabled = False

        Else
            TlsModificarEdicion.Enabled = False
            TlsEliminarEdicion.Enabled = False
            TxtCodIdentificacion.Enabled = True
        End If

    End Sub


#Region "BUSQUEDA DE EMPASTE"

    Private Sub TlsBuscarDetalleEmpaste_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TlsBuscarDetalleEmpaste.Click
        BuscarDetalleEmpaste()
    End Sub

    Private Sub TxtObservacionesDetalleEmpasteBusqueda_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtObservacionesDetalleEmpasteBusqueda.KeyDown
        If e.KeyCode = Keys.Enter Then
            TlsBuscarDetalleEmpaste_Click(sender, e)
        End If
    End Sub

    Public Sub BuscarDetalleEmpaste()
        Dim mostrar As New Clases.C_Edicion
        DgwEdicion.DataSource = mostrar.CargarDatos(3, LblCodigoDetalleEmpaste.Text & TxtCodigoDetalleEmpasteBusqueda.Text, TxtObservacionesDetalleEmpasteBusqueda.Text)
        CrearColumnasEdicion()
        TpgDetalleEmpaste.Show()
        frm_Emp_FlatBusqueda = 2
    End Sub

    Private Sub TabControl2_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl2.SelectedIndexChanged
        If TabControl2.SelectedIndex = 1 Then
            LblCodigoDetalleEmpaste.Text = Frm_Emp_CodAuxEmpaste & "-"
        End If
    End Sub

    Private Sub TxtCodigoDetalleEmpasteBusqueda_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCodigoDetalleEmpasteBusqueda.KeyDown
        If e.KeyCode = Keys.Enter Then
            TlsBuscarDetalleEmpaste_Click(sender, e)
        End If
    End Sub

    Private Sub TxtBusquedaDetalleEmpaste_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCodigoDetalleEmpasteBusqueda.KeyPress
        If InStr(1, "QwEeRrTtYyUuIiOoPpAaSsDdFfGgHhJjKkLlÑñZzXxCcVvBbNnMm0123456789-" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub TxtBusquedaDetalleEmpaste_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCodigoDetalleEmpasteBusqueda.TextChanged
        TxtCodigoDetalleEmpasteBusqueda.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub TlsLimpiarBusquedaDetalleEmpaste_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TlsLimpiarBusquedaDetalleEmpaste.Click
        TxtCodigoDetalleEmpasteBusqueda.Text = ""
        TxtObservacionesDetalleEmpasteBusqueda.Text = ""
    End Sub

#End Region

#Region "CODIGO A ENVIAR A EDICION"

    Private Sub TlsAgregarEdicion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TlsAgregarEdicion.Click

        Frm_Edicion.ToolStripButton1.Enabled = False

        If TxtCodIdentificacion.Text.ToString.Trim <> "" And TxtNumEdiciones.Text <> "" And TxtNumSuplementos.Text <> "" And TxtNumExtraordinario.Text <> "" Then
            If Frm_Emp_Control = 1 Then
                If DgvEmpasteGuardado.Rows.Count > 0 Then
                    Frm_Edicion.Frm_Edi_CodEmpaste = DgvEmpasteGuardado.Rows(0).Cells(0).Value
                    Frm_Edicion.LblCodIden.Text = DgvEmpasteGuardado.Rows(0).Cells(0).Value & "-"
                    Frm_Edicion.DtpI.Text = DgvEmpasteGuardado.Rows(0).Cells(8).Value
                    Frm_Edicion.DtpF.Text = DgvEmpasteGuardado.Rows(0).Cells(9).Value
                    Frm_Edicion.Frm_Edi_NumEdicion = DgvEmpasteGuardado.Rows(0).Cells(4).Value
                    Frm_Edicion.Frm_Edi_NumSuplemento = DgvEmpasteGuardado.Rows(0).Cells(5).Value
                    Frm_Edicion.Frm_Edi_NumSemestre = DgvEmpasteGuardado.Rows(0).Cells(6).Value
                End If
            ElseIf Frm_Emp_Control = 2 Then
                Frm_Edicion.Frm_Edi_CodEmpaste = DgwEmpasteBusqueda.SelectedCells(0).Value
                Frm_Edicion.LblCodIden.Text = DgwEmpasteBusqueda.SelectedCells(0).Value & "-"
                Frm_Edicion.DtpI.Text = DgwEmpasteBusqueda.SelectedCells(8).Value
                Frm_Edicion.DtpF.Text = DgwEmpasteBusqueda.SelectedCells(9).Value
                Frm_Edicion.Frm_Edi_NumEdicion = DgwEmpasteBusqueda.SelectedCells(4).Value
                Frm_Edicion.Frm_Edi_NumSuplemento = DgwEmpasteBusqueda.SelectedCells(5).Value
                Frm_Edicion.Frm_Edi_NumSemestre = DgwEmpasteBusqueda.SelectedCells(6).Value
            End If
            NumeroDetallesRegistrados()
            Frm_Emp_ControlEnviarEdicion = 1
            Frm_Edicion.Frm_Edi_ControlRecibirEmpaste = Frm_Emp_ControlEnviarEdicion
            EnviarTotalPagEmpasteyTotalPagEdicion()
            Frm_Edicion.ShowDialog()
            MostrarEdicion(Frm_Emp_CodAuxEmpaste)
        Else
            MsgBox("Debe llenar el formulario para poder agregar un detalle de empaste", MsgBoxStyle.Exclamation, "Aviso")
        End If
        'SE ENVIA 10 DATOS A LA INTERFAZ DETALLE DE EMPASTE
    End Sub


    Private Sub DgwEdicion_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgwEdicion.CellDoubleClick
        Frm_Edicion.ToolStripButton1.Enabled = True
        If e.RowIndex <> -1 Then
            If e.ColumnIndex = DgwEdicion.Columns("PdfP").Index Then
                Dim nombrePDF As String = ""
                Dim codigoEstado As String = DgwEdicion.Rows(e.RowIndex).Cells("CodEstado").Value
                nombrePDF = DgwEdicion.Rows(e.RowIndex).Cells("PdfP").Value
                If nombrePDF <> "" Then
                    MostrarPDF(nombrePDF, codigoEstado)
                Else
                    MsgBox("No hay archivos asociado", MsgBoxStyle.Exclamation, "Aviso")
                End If
            ElseIf e.ColumnIndex = DgwEdicion.Columns("Estado").Index Then
                Dim codigoEstado As String = DgwEdicion.Rows(e.RowIndex).Cells("CodEstado").Value
                Dim tipoDocumento As String = "PDF"

                If codigoEstado.Equals("ER") Then
                    Dim codigoEdicion As String = DgwEdicion.Rows(e.RowIndex).Cells("codigoIdentificacion").Value
                    mostrarIncidencia(codigoEdicion, tipoDocumento)
                End If
            Else
                MostrarDatosEdicion()
            End If
        Else
            Dim estado As String
            If Not DgwEdicion.Columns("CargarPDF") Is Nothing Then
                If e.ColumnIndex = DgwEdicion.Columns("CargarPDF").Index And DgwEdicion.Rows.Count > 0 Then
                    For i As Integer = 0 To DgwEdicion.Rows.Count - 1
                        estado = DgwEdicion.Rows(i).Cells("CodEstado").Value
                        If estado = "PP" Or estado = "EI" Or estado = "ER" Then
                            DgwEdicion.Rows(i).Cells("CargarPDF").Value = valorBool
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
    Private Sub mostrarIncidencia(ByVal codigo As String, ByVal tipo As String)
        Dim QA_Incidencia As Frm_Incidencia = New Frm_Incidencia(codigo, tipo)
        QA_Incidencia.ShowDialog()
    End Sub

    Private Sub MostrarDatosEdicion()
        Dim frmEdicion As New Frm_Edicion

        If DgwEdicion.Rows.Count > 0 Then

            frmEdicion.DtpI.Text = DtpFecInicio.Text
            frmEdicion.DtpF.Text = DtpFecTermino.Text
            frmEdicion.Frm_Edi_CodEmpaste = TxtCodIdentificacion.Text
            frmEdicion.Frm_Edi_NumEdicion = TxtNumEdiciones.Text
            frmEdicion.Frm_Edi_NumSuplemento = TxtNumSuplementos.Text
            frmEdicion.Frm_Edi_NumSemestre = TxtNumExtraordinario.Text
            Dim Codigo = DgwEdicion.SelectedCells(1).Value

            frmEdicion.LblCodIden.Text = DgwEdicion.SelectedCells(1).Value.ToString.Substring(0, 12) 'captura en el label LblCodIden el codigo del gwdEdicion
            frmEdicion.TxtCodEdi.Text = DgwEdicion.SelectedCells(1).Value.ToString.Substring(12, 6) 'captura en el textbox TxtCodEdi gwdEdicion
            frmEdicion.Frm_Edi_CodAuxEdicion = DgwEdicion.SelectedCells(1).Value
            frmEdicion.Frm_Edi_CodTipo = DgwEdicion.SelectedCells(2).Value
            frmEdicion.TxtENumEdicion.Text = DgwEdicion.SelectedCells(4).Value
            frmEdicion.Frm_Edi_AuxNumPag = DgwEdicion.SelectedCells(5).Value
            frmEdicion.TxtENumPagEdicion.Text = DgwEdicion.SelectedCells(5).Value
            frmEdicion.DtpEFechaEdicion.Text = DgwEdicion.SelectedCells(6).Value
            frmEdicion.TxtEDirector.Text = DgwEdicion.SelectedCells(7).Value
            frmEdicion.TxtEPagFaltantes.Text = DgwEdicion.SelectedCells(8).Value
            frmEdicion.TxtObservaciones.Text = DgwEdicion.SelectedCells(13).Value

            frmEdicion.tbTitulo.Text = DgwEdicion.SelectedCells(17).Value
            frmEdicion.tbSubtitulo.Text = DgwEdicion.SelectedCells(18).Value

            If DgwEdicion.SelectedCells(9).Value = "SI" Then
                frmEdicion.CkxEBueno.Checked = True
            Else
                frmEdicion.CkxEBueno.Checked = False
            End If
            If DgwEdicion.SelectedCells(10).Value = "SI" Then
                frmEdicion.CkxEDelgado.Checked = True
            Else
                frmEdicion.CkxEDelgado.Checked = False
            End If
            If DgwEdicion.SelectedCells(11).Value = "SI" Then
                frmEdicion.CkxEGrueso.Checked = True
            Else
                frmEdicion.CkxEGrueso.Checked = False
            End If
            If DgwEdicion.SelectedCells(12).Value = "SI" Then
                frmEdicion.CkxEDeteriorado.Checked = True
            Else
                frmEdicion.CkxEDeteriorado.Checked = False
            End If
            NumeroDetallesRegistrados()
            Frm_Emp_ControlEnviarEdicion = 2
            frmEdicion.Frm_Edi_ControlRecibirEmpaste = Frm_Emp_ControlEnviarEdicion
            EnviarTotalPagEmpasteyTotalPagEdicion()
            frmEdicion.ShowDialog()

            If frm_Emp_FlatBusqueda = 1 Then
                If TxtCodIdentificacionBusqueda.Text = "" And TxtObservacionEmpasteBusqueda.Text = "" Then
                    MostrarEdicion(Frm_Emp_CodAuxEmpaste)
                ElseIf TxtCodIdentificacionBusqueda.Text <> "" And TxtObservacionEmpasteBusqueda.Text = "" Then
                    MostrarEdicion(Frm_Emp_CodAuxEmpaste)
                ElseIf TxtCodIdentificacionBusqueda.Text = "" And TxtObservacionEmpasteBusqueda.Text <> "" Then
                    MostrarEdicion(Frm_Emp_CodAuxEmpaste)
                ElseIf TxtCodIdentificacionBusqueda.Text <> "" And TxtObservacionEmpasteBusqueda.Text <> "" Then
                    MostrarEdicion(Frm_Emp_CodAuxEmpaste)
                End If
            ElseIf frm_Emp_FlatBusqueda = 2 Then
                If TxtCodigoDetalleEmpasteBusqueda.Text = "" And TxtObservacionesDetalleEmpasteBusqueda.Text = "" Then
                    If TxtCodigoDetalleEmpasteBusqueda.Text = "" And TxtObservacionesDetalleEmpasteBusqueda.Text = "" Then
                        MostrarEdicion(Frm_Emp_CodAuxEmpaste)
                    ElseIf TxtCodigoDetalleEmpasteBusqueda.Text <> "" And TxtObservacionesDetalleEmpasteBusqueda.Text = "" Then
                        BuscarDetalleEmpaste()
                    ElseIf TxtCodigoDetalleEmpasteBusqueda.Text = "" And TxtObservacionesDetalleEmpasteBusqueda.Text <> "" Then
                        BuscarDetalleEmpaste()
                    ElseIf TxtCodigoDetalleEmpasteBusqueda.Text <> "" And TxtObservacionesDetalleEmpasteBusqueda.Text <> "" Then
                        BuscarDetalleEmpaste()
                    End If
                End If
            End If
            DgwEdicion.Rows(Frm_Emp_FilaSeleccionada).Selected = True
        Else
            TlsModificarEdicion.Enabled = False
            TlsEliminarEdicion.Enabled = False
        End If

    End Sub

    Public Sub ModificarEdicion()
        Try
            If DgwEdicion.Rows.Count > 0 Then

                Frm_Edicion.DtpI.Text = DtpFecInicio.Text
                Frm_Edicion.DtpF.Text = DtpFecTermino.Text
                Frm_Edicion.Frm_Edi_CodEmpaste = TxtCodIdentificacion.Text
                Frm_Edicion.Frm_Edi_NumEdicion = TxtNumEdiciones.Text
                Frm_Edicion.Frm_Edi_NumSuplemento = TxtNumSuplementos.Text
                Frm_Edicion.Frm_Edi_NumSemestre = TxtNumExtraordinario.Text
                Dim Codigo = DgwEdicion.SelectedCells(1).Value

                Frm_Edicion.LblCodIden.Text = DgwEdicion.SelectedCells(1).Value.ToString.Substring(0, 12) 'captura en el label LblCodIden el codigo del gwdEdicion
                Frm_Edicion.TxtCodEdi.Text = DgwEdicion.SelectedCells(1).Value.ToString.Substring(12, 6) 'captura en el textbox TxtCodEdi gwdEdicion
                Frm_Edicion.Frm_Edi_CodAuxEdicion = DgwEdicion.SelectedCells(1).Value
                Frm_Edicion.Frm_Edi_CodTipo = DgwEdicion.SelectedCells(2).Value
                Frm_Edicion.TxtENumEdicion.Text = DgwEdicion.SelectedCells(4).Value
                Frm_Edicion.Frm_Edi_AuxNumPag = DgwEdicion.SelectedCells(5).Value
                Frm_Edicion.TxtENumPagEdicion.Text = DgwEdicion.SelectedCells(5).Value
                Frm_Edicion.DtpEFechaEdicion.Text = DgwEdicion.SelectedCells(6).Value
                Frm_Edicion.TxtEDirector.Text = DgwEdicion.SelectedCells(7).Value
                Frm_Edicion.TxtEPagFaltantes.Text = DgwEdicion.SelectedCells(8).Value
                Frm_Edicion.TxtObservaciones.Text = DgwEdicion.SelectedCells(13).Value

                Frm_Edicion.tbTitulo.Text = DgwEdicion.SelectedCells(16).Value
                Frm_Edicion.tbSubtitulo.Text = DgwEdicion.SelectedCells(17).Value

                If DgwEdicion.SelectedCells(9).Value = "SI" Then
                    Frm_Edicion.CkxEBueno.Checked = True
                Else
                    Frm_Edicion.CkxEBueno.Checked = False
                End If
                If DgwEdicion.SelectedCells(10).Value = "SI" Then
                    Frm_Edicion.CkxEDelgado.Checked = True
                Else
                    Frm_Edicion.CkxEDelgado.Checked = False
                End If
                If DgwEdicion.SelectedCells(11).Value = "SI" Then
                    Frm_Edicion.CkxEGrueso.Checked = True
                Else
                    Frm_Edicion.CkxEGrueso.Checked = False
                End If
                If DgwEdicion.SelectedCells(12).Value = "SI" Then
                    Frm_Edicion.CkxEDeteriorado.Checked = True
                Else
                    Frm_Edicion.CkxEDeteriorado.Checked = False
                End If
                NumeroDetallesRegistrados()
                Frm_Emp_ControlEnviarEdicion = 2
                Frm_Edicion.Frm_Edi_ControlRecibirEmpaste = Frm_Emp_ControlEnviarEdicion
                EnviarTotalPagEmpasteyTotalPagEdicion()

                Dim cod_iden As String = DgwEdicion.SelectedCells(1).Value.ToString.Substring(0, 12)
                Dim CodEdi As String = DgwEdicion.SelectedCells(1).Value.ToString.Substring(12, 6)
                Dim CodAuxEdicion As String = DgwEdicion.SelectedCells(1).Value
                Dim CodTipo As String = DgwEdicion.SelectedCells(2).Value
                Dim ENumEdicion As String = DgwEdicion.SelectedCells(4).Value
                Dim AuxNumPag As String = DgwEdicion.SelectedCells(5).Value
                Dim NumPagEdicion As String = DgwEdicion.SelectedCells(5).Value
                Dim EFechaEdicion As String = DgwEdicion.SelectedCells(6).Value
                Dim EDirector As String = DgwEdicion.SelectedCells(7).Value
                Dim EPagFaltantes As String = DgwEdicion.SelectedCells(8).Value
                Dim Observaciones As String = DgwEdicion.SelectedCells(13).Value
                Dim CkxEBueno As String = DgwEdicion.SelectedCells(9).Value
                Dim CkxEDelgado As String = DgwEdicion.SelectedCells(10).Value
                Dim CkxEGrueso As String = DgwEdicion.SelectedCells(11).Value
                Dim CkxEDeteriorado As String = DgwEdicion.SelectedCells(12).Value


                Frm_Edicion.ShowDialog()

                If frm_Emp_FlatBusqueda = 1 Then
                    If TxtCodIdentificacionBusqueda.Text = "" And TxtObservacionEmpasteBusqueda.Text = "" Then
                        MostrarEdicion(Frm_Emp_CodAuxEmpaste)
                    ElseIf TxtCodIdentificacionBusqueda.Text <> "" And TxtObservacionEmpasteBusqueda.Text = "" Then
                        MostrarEdicion(Frm_Emp_CodAuxEmpaste)
                    ElseIf TxtCodIdentificacionBusqueda.Text = "" And TxtObservacionEmpasteBusqueda.Text <> "" Then
                        MostrarEdicion(Frm_Emp_CodAuxEmpaste)
                    ElseIf TxtCodIdentificacionBusqueda.Text <> "" And TxtObservacionEmpasteBusqueda.Text <> "" Then
                        MostrarEdicion(Frm_Emp_CodAuxEmpaste)
                    End If
                ElseIf frm_Emp_FlatBusqueda = 2 Then
                    If TxtCodigoDetalleEmpasteBusqueda.Text = "" And TxtObservacionesDetalleEmpasteBusqueda.Text = "" Then
                        If TxtCodigoDetalleEmpasteBusqueda.Text = "" And TxtObservacionesDetalleEmpasteBusqueda.Text = "" Then
                            MostrarEdicion(Frm_Emp_CodAuxEmpaste)
                        ElseIf TxtCodigoDetalleEmpasteBusqueda.Text <> "" And TxtObservacionesDetalleEmpasteBusqueda.Text = "" Then
                            BuscarDetalleEmpaste()
                        ElseIf TxtCodigoDetalleEmpasteBusqueda.Text = "" And TxtObservacionesDetalleEmpasteBusqueda.Text <> "" Then
                            BuscarDetalleEmpaste()
                        ElseIf TxtCodigoDetalleEmpasteBusqueda.Text <> "" And TxtObservacionesDetalleEmpasteBusqueda.Text <> "" Then
                            BuscarDetalleEmpaste()
                        End If
                    End If
                End If
                DgwEdicion.Rows(Frm_Emp_FilaSeleccionada).Selected = True
            Else
                TlsModificarEdicion.Enabled = False
                TlsEliminarEdicion.Enabled = False
            End If

        Catch ex As Exception
            MsgBox("Error Inesperado, Continue", MsgBoxStyle.Critical, "Editora Peru")
        End Try
    End Sub

    Public Sub EnviarTotalPagEmpasteyTotalPagEdicion()
        If Frm_Emp_Control = 1 Then
            If DgvEmpasteGuardado.Rows.Count > 0 Then
                Frm_Edicion.Frm_Edi_NumPagTotalEmpaste = DgvEmpasteGuardado.Rows(0).Cells(7).Value
            End If
        ElseIf Frm_Emp_Control = 2 Then
            Frm_Edicion.Frm_Edi_NumPagTotalEmpaste = DgwEmpasteBusqueda.SelectedCells(7).Value
        End If
        Frm_Edicion.Frm_Edi_NumPagTotalEdicion = 0
        If DgwEdicion.Rows.Count > 0 Then
            For i = 0 To DgwEdicion.Rows.Count - 1
                Frm_Edicion.Frm_Edi_NumPagTotalEdicion = Frm_Edicion.Frm_Edi_NumPagTotalEdicion + DgwEdicion.Rows(i).Cells(5).Value
            Next
        End If
    End Sub

    Public Sub NumeroDetallesRegistrados()
        Dim NEDR As Integer = 0
        Dim NSUR As Integer = 0
        Dim NSER As Integer = 0
        For i = 0 To DgwEdicion.Rows.Count - 1
            If DgwEdicion.Rows(i).Cells(2).Value = 1 Then
                NEDR = NEDR + 1
            ElseIf DgwEdicion.Rows(i).Cells(2).Value = 2 Then
                NSUR = NSUR + 1
            ElseIf DgwEdicion.Rows(i).Cells(2).Value = 3 Then
                NSER = NSER + 1
            End If
        Next
        Frm_Edicion.Frm_Edi_NEDR = NEDR
        Frm_Edicion.Frm_Edi_NSUR = NSUR
        Frm_Edicion.Frm_Edi_NSER = NSER
        NEDR = 0
        NSUR = 0
        NSER = 0

    End Sub
#End Region
#End Region

    Private Sub TlsProcesarEdicion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TlsProcesarEdicion.Click
        Dim arrayCodigos As ArrayList = New ArrayList
        Dim codigos As String = ""
        If DgwEdicion.Rows.Count > 0 Then
            For i As Integer = 0 To DgwEdicion.Rows.Count - 1
                If DgwEdicion.Rows(i).Cells("CargarPDF").Value = 1 And DgwEdicion.Rows(i).Cells("PdfP").Value = "" Then
                    'CODIGO + TIPO + FECHA
                    arrayCodigos.Add(DgwEdicion.Rows(i).Cells(1).Value & "," & DgwEdicion.Rows(i).Cells(2).Value & "," & DgwEdicion.Rows(i).Cells(6).Value)
                    'codigos &= codigos & DgwEdicion.Rows(i).Cells(1).Value & DgwEdicion.Rows(i).Cells(2).Value & DgwEdicion.Rows(i).Cells(6).Value & "/n"
                End If
            Next
            ' If arrayCodigos.Count > 0 Then
            DigitalizarPDF(arrayCodigos)
            'Else
            ' MessageBox.Show("Pdfs ya Indexados")
            'End If
        Else
        MessageBox.Show("No hay Filas seleccionadas", "Aviso Edición", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub TlsPDFaQA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TlsPDFaQA.Click
        Dim arrPDF As ArrayList = New ArrayList
        Dim arrCodigoPDF As ArrayList = New ArrayList
        Dim arrCodigoNombreTipoPDF As ArrayList = New ArrayList

        If DgwEdicion.Rows.Count > 0 Then
            For i As Integer = 0 To DgwEdicion.Rows.Count - 1
                If DgwEdicion.Rows(i).Cells("CargarPDF").Value = 1 Then
                    If DgwEdicion.Rows(i).Cells("PdfP").Value <> "" Then
                        Dim codigoEstado As String = DgwEdicion.Rows(i).Cells("CodEstado").Value
                        arrPDF.Add(DgwEdicion.Rows(i).Cells("PdfP").Value)
                        arrCodigoPDF.Add(DgwEdicion.Rows(i).Cells(3).Value)
                        arrCodigoNombreTipoPDF.Add(DgwEdicion.Rows(i).Cells(1).Value & "," & DgwEdicion.Rows(i).Cells("PdfP").Value & "," & DgwEdicion.Rows(i).Cells(2).Value)
                        If codigoEstado.Equals("ER") Then
                            Dim codigoEdicion As String = DgwEdicion.Rows(i).Cells("codigoIdentificacion").Value
                            EliminarRegistroPDF(codigoEdicion)
                        End If
                    Else
                        MessageBox.Show("La edición " & DgwEdicion.Rows(i).Cells(1).Value & " no tiene pdf", "Alerta PDF", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Return

                    End If
                End If
            Next
            Try
                PasarActualizarEstadoPDF(arrCodigoNombreTipoPDF)
                MostrarEdicion(TxtCodIdentificacion.Text)
                MessageBox.Show("PDFs pasados a QA correctamente", "Alerta PDF", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Catch ex As Exception
                MessageBox.Show("Error al pasar PDF a QA", "Alerta PDF", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        End If
    End Sub
    Private Sub EliminarRegistroPDF(ByVal codigo As String)
        Dim cEdiciones As New Clases.C_Edicion
        Dim tipoDocumento As String = "PDF"
        cEdiciones.EliminarRegistroRechazadosPDF(codigo, tipoDocumento)

    End Sub

    Private Sub DigitalizarPDF(ByVal arrayCodigos As ArrayList)
        Dim carpetaP As String = Configuration.ConfigurationManager.AppSettings("carpetaP")
        '***********CARPETA DE PRUEBAS LOCALES **************
        'Dim carpetaP As String = "C:\Users\fa1juanx\Desktop\EMPASTE\carpetaP\"

        Dim cont%
        Dim nombrePDF As String = ""
        Dim nombrePDF2 As String = ""
        Dim enc As Boolean = True
        Dim cEdicion As New Clases.C_Edicion
        Dim arrayPDF As ArrayList = New ArrayList
        Dim carpetapdf As String = getCarpetaPDFP()
        Dim ruta As String = carpetaP & carpetapdf
        Dim tipo As String = "1"
        Dim fecha As String = ""
        Dim datos As Array
        Dim codigo2$
        Dim lista As New ArrayList
        Dim list As String

        'aArchivos.Inic(Clases.DatosConexion.dominio, Clases.DatosConexion.usuario, Clases.DatosConexion.clave)
        'lErrorConexionRed = aArchivos.RedConectar(carpetaRaiz)

        If Directory.Exists(ruta) Then
            Dim carpeta As New DirectoryInfo(ruta)
            For Each file As FileInfo In carpeta.GetFiles()
                If file.Extension.ToUpper() = ".PDF" Then
                    arrayPDF.Add(file.Name.ToUpper())
                End If
            Next
            For Each codigo As String In arrayCodigos
                datos = codigo.Split(",")
                codigo = datos(0)
                tipo = getTipoEdicion(datos(1).ToString()) 'codigo.Substring(codigo.Length - 11, 1)
                fecha = datos(2).ToString().Substring(6, 4) & datos(2).ToString().Substring(3, 2) & datos(2).ToString().Substring(0, 2) 'codigo.Substring(codigo.Length - 10)
                nombrePDF = fecha & "-" & codigo.Substring(0, 11) & "-" & codigo.Substring(codigo.Length - 3) & tipo & ".PDF"

                If nombrePDF.Substring(11, 1) = 1 Then
                    nombrePDF2 = fecha & "-" & codigo.Substring(0, 2) & "2" & codigo.Substring(3, 8) & "-" & codigo.Substring(codigo.Length - 3) & tipo & ".PDF"
                    codigo2 = "I-2" & codigo.Substring(3, 15)
                Else
                    nombrePDF2 = fecha & "-" & codigo.Substring(0, 2) & "1" & codigo.Substring(3, 8) & "-" & codigo.Substring(codigo.Length - 3) & tipo & ".PDF"
                    codigo2 = "I-1" & codigo.Substring(3, 15)
                End If

                If arrayPDF.Contains(nombrePDF) Then
                    cEdicion.DigitalizarEdicionPDF(codigo, Convert.ToInt16(datos(1).ToString()), nombrePDF, Frm_Principal.datosUsuario)
                ElseIf arrayPDF.Contains(nombrePDF2) Then
                    cEdicion.DigitalizarEdicionPDF(codigo2, Convert.ToInt16(datos(1).ToString()), nombrePDF2, Frm_Principal.datosUsuario)
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
                MessageBox.Show("PDFs actualizados correctamente", "Alerta PDF", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                MessageBox.Show("No se encontraron todos los PDFs" & vbNewLine & "faltan : " & cont.ToString & vbNewLine & list, _
                                "Alerta PDF", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            MostrarEdicion(TxtCodIdentificacion.Text)
        Else
            MessageBox.Show("El directorio " & ruta & " no existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        'aArchivos.RedDesconectar(carpetaRaiz)
    End Sub

    Private Function getCarpetaPDFP() As String
        Dim carAnio As String = Me.TxtCodIdentificacion.Text.Substring(4, 4)
        Dim carPDF As String = carAnio & " PDF"

        Dim carpetaPDF As String = carPDF & "\"
        Return carpetaPDF
    End Function

    Private Function getTipoEdicion(ByVal tiponum As String) As String
        Dim tipo As String = ""
        If tiponum = "1" Then
            tipo = "E"
        ElseIf tiponum = "2" Then
            tipo = "S"
        ElseIf tiponum = "3" Then
            tipo = "X"
        Else
            tipo = "E"
        End If
        Return tipo
    End Function

    Private Sub MostrarPDF(ByVal nombrePDF As String, ByVal codigoEstado As String)
        Dim carpetaP As String = Configuration.ConfigurationManager.AppSettings("carpetaP")
        Dim carpetaQ As String = Configuration.ConfigurationManager.AppSettings("CarpetaPeruano")
        Dim capetaR As String = Configuration.ConfigurationManager.AppSettings("carpetaR")
        Dim carpetaPDF As String = getCarpetaPDFP()
        Dim carpetaPDFQ As String = getCarpetaPDFQ()
        Dim carpetaPDFR As String = getCarpetaPDFR()
        Dim ruta As String = "" '= carpetaP & carpetaPDF & nombrePDF

        aArchivos.Inic(Clases.DatosConexion.dominio, Clases.DatosConexion.usuario, Clases.DatosConexion.clave)
        lErrorConexionRed = aArchivos.RedConectar(carpetaRaiz)

        If codigoEstado = "PP" Or codigoEstado = "ER" Then
            ruta = carpetaP & carpetaPDF & nombrePDF
        ElseIf codigoEstado = "PQ" Then
            ruta = carpetaQ & carpetaPDFQ & nombrePDF

        Else
            ruta = capetaR & carpetaPDFR & nombrePDF
        End If
        'Dim impersonatedUser As WindowsImpersonationContext = Nothing
        'impersonatedUser = Clases.SafeTokenHandle.getImpersonate()
        Try
            If File.Exists(ruta) Then
                'Dim rutaS As String = "\\sw-imgdig\d$\Digitalizacion\ProyDigital\Calidad\Diario Oficial El Peruano\Ediciones PDF Corregidas\1840 PDF\18400104-I-1-1840-01-002E.PDF"
                'Process.Start("C:\Archivos de programa\Adobe\Reader 10.0\Reader\AcroRd32.exe", ruta)
                'Shell("C:\Archivos de programa\Adobe\Reader 10.0\Reader\AcroRd32.exe \\sw-imgdig\d$\Digitalizacion\ProyDigital\scaneo\1840 PDF\18400101-I-1-1840-01-001E.PDF", 1)
                Process.Start(ruta)
                ' Else
                ' MessageBox.Show("No existe el pdf seleccionado", "Alerta PDF", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                '   MessageBox.Show("No tiene los accesos suficeines", "ACCESO")
            Else
                MessageBox.Show("No existe la ruta : " & vbNewLine & ruta)
            End If
        Catch ex As Exception
            MessageBox.Show("No se puede mostrar el pdf seleccionado" & vbNewLine & _
                             ruta, "Alerta PDF", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
        aArchivos.RedDesconectar(carpetaRaiz)

    End Sub

    Private Function getCarpetaPDFR() As String
        Dim carAnio As String = Me.TxtCodIdentificacion.Text.Substring(4, 4)
        Dim carUbicacion As String = "PDF -FINAL" & "\" & "PDF-corregida PHOTOSHOP" & "\"
        Dim carPDF As String = carAnio & " PDF"

        Dim carpetaPDFQ As String = carUbicacion & carPDF & "\"
        Return carpetaPDFQ
    End Function

    Private Function getCarpetaPDFQ() As String
        Dim carAnio As String = Me.TxtCodIdentificacion.Text.Substring(4, 4)
        Dim carUbicacion As String = "Ediciones PDF Corregidas" & "\"
        Dim carPDF As String = carAnio & " PDF"

        Dim carpetaPDFQ As String = carUbicacion & carPDF & "\"
        Return carpetaPDFQ
    End Function

    Private Sub PasarActualizarEstadoPDF(ByVal arraCodNomTip As ArrayList)
        Dim carpetaP As String = Configuration.ConfigurationManager.AppSettings("carpetaP")
        Dim carpetaQ As String = Configuration.ConfigurationManager.AppSettings("carpetaPeruano")
        Dim carpetaPDF_P As String = getCarpetaPDFP()
        Dim carpetaPDF_Q As String = getCarpetaPDFQ()

        Dim pdfP As String = ""
        Dim pdfQ As String = ""
        Dim cod As String = ""
        Dim nom As String = ""
        Dim tipo As Integer = 0
        Dim dato As Array

        Dim cEdicion As New Clases.C_Edicion

        aArchivos.Inic(Clases.DatosConexion.dominio, Clases.DatosConexion.usuario, Clases.DatosConexion.clave)
        lErrorConexionRed = aArchivos.RedConectar(carpetaRaiz)

        If Not Directory.Exists(carpetaQ & carpetaPDF_Q) Then
            Directory.CreateDirectory(carpetaQ & carpetaPDF_Q)
        End If

        For Each codnomtip As String In arraCodNomTip
            dato = codnomtip.Split(",")
            cod = dato(0).ToString()
            nom = dato(1).ToString()
            tipo = Convert.ToInt16(dato(2).ToString())

            pdfP = carpetaP & carpetaPDF_P & nom
            If File.Exists(pdfP) Then
                pdfQ = carpetaQ & carpetaPDF_Q & nom

                If File.Exists(pdfQ) Then
                    My.Computer.FileSystem.DeleteFile(pdfQ)
                End If

                File.Move(pdfP, pdfQ)
                'File.Copy(pdfP, pdfQ, True)
                cEdicion.PasarEdicionesQA(1, cod, tipo, 0, Frm_Principal.datosUsuario)
            Else
                MessageBox.Show("No existe el PDF: " & pdfP, "Alerta PDF", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Next
        aArchivos.RedDesconectar(carpetaRaiz)
    End Sub




    Private Sub DgwEdicion_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgwEdicion.CellContentClick

    End Sub
End Class