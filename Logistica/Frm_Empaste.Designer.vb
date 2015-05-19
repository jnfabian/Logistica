<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Empaste
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Empaste))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TpgEmpasteIngreso = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TxtNumExtraordinario = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtNumSuplementos = New System.Windows.Forms.TextBox()
        Me.Frm1Group3 = New System.Windows.Forms.GroupBox()
        Me.CbxEstadoEmpaste = New System.Windows.Forms.ComboBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.CbxVisto = New System.Windows.Forms.ComboBox()
        Me.LblVisto = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.Frm_Empaste_TlsNuevo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.TlsGuardar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TlsEliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.TxtObservaciones = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Frm1Group4 = New System.Windows.Forms.GroupBox()
        Me.TxtNivel = New System.Windows.Forms.TextBox()
        Me.TxtAnaquel = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtEdicionesFaltantes = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtNumPaginas = New System.Windows.Forms.TextBox()
        Me.TxtCodIdentificacion = New System.Windows.Forms.TextBox()
        Me.TxtNumEdiciones = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Frm1Group2 = New System.Windows.Forms.GroupBox()
        Me.TxtAltura = New System.Windows.Forms.TextBox()
        Me.Frm1Lbl4 = New System.Windows.Forms.Label()
        Me.Frm2Lbl3 = New System.Windows.Forms.Label()
        Me.TxtAncho = New System.Windows.Forms.TextBox()
        Me.TxtLargo = New System.Windows.Forms.TextBox()
        Me.Frm2Lbl2 = New System.Windows.Forms.Label()
        Me.frm1Group1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DtpFecInicio = New System.Windows.Forms.DateTimePicker()
        Me.DtpFecTermino = New System.Windows.Forms.DateTimePicker()
        Me.Frm1Lbl1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TpgBusqueda = New System.Windows.Forms.TabPage()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.TlsSeleccionarEmpaste = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.DgwEmpasteBusqueda = New System.Windows.Forms.DataGridView()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.TxtObservacionEmpasteBusqueda = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.TxtCodIdentificacionBusqueda = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.TlsAgregarEdicion = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.TlsModificarEdicion = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.TlsEliminarEdicion = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator()
        Me.TlsProcesarEdicion = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator16 = New System.Windows.Forms.ToolStripSeparator()
        Me.TlsPDFaQA = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator17 = New System.Windows.Forms.ToolStripSeparator()
        Me.DgwEdicion = New System.Windows.Forms.DataGridView()
        Me.DgvEmpasteGuardado = New System.Windows.Forms.DataGridView()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TpgDetalleEmpaste = New System.Windows.Forms.TabPage()
        Me.TpgBusquedaDetalleEmpaste = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LblCodigoDetalleEmpaste = New System.Windows.Forms.Label()
        Me.TxtObservacionesDetalleEmpasteBusqueda = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtCodigoDetalleEmpasteBusqueda = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ToolStrip4 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator13 = New System.Windows.Forms.ToolStripSeparator()
        Me.TlsBuscarDetalleEmpaste = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator14 = New System.Windows.Forms.ToolStripSeparator()
        Me.TlsLimpiarBusquedaDetalleEmpaste = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator15 = New System.Windows.Forms.ToolStripSeparator()
        Me.TabControl1.SuspendLayout()
        Me.TpgEmpasteIngreso.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Frm1Group3.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.Frm1Group4.SuspendLayout()
        Me.Frm1Group2.SuspendLayout()
        Me.frm1Group1.SuspendLayout()
        Me.TpgBusqueda.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        CType(Me.DgwEmpasteBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.ToolStrip3.SuspendLayout()
        CType(Me.DgwEdicion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvEmpasteGuardado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl2.SuspendLayout()
        Me.TpgDetalleEmpaste.SuspendLayout()
        Me.TpgBusquedaDetalleEmpaste.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.ToolStrip4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(102, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(574, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "INVENTARIO DE EMPASTES DEL DIARIO OFICIAL EL PERUANO"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TpgEmpasteIngreso)
        Me.TabControl1.Controls.Add(Me.TpgBusqueda)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(12, 31)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(970, 335)
        Me.TabControl1.TabIndex = 4
        '
        'TpgEmpasteIngreso
        '
        Me.TpgEmpasteIngreso.Controls.Add(Me.GroupBox1)
        Me.TpgEmpasteIngreso.Location = New System.Drawing.Point(4, 25)
        Me.TpgEmpasteIngreso.Name = "TpgEmpasteIngreso"
        Me.TpgEmpasteIngreso.Padding = New System.Windows.Forms.Padding(3)
        Me.TpgEmpasteIngreso.Size = New System.Drawing.Size(962, 306)
        Me.TpgEmpasteIngreso.TabIndex = 0
        Me.TpgEmpasteIngreso.Text = "Empaste"
        Me.TpgEmpasteIngreso.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.TxtNumExtraordinario)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.TxtNumSuplementos)
        Me.GroupBox1.Controls.Add(Me.Frm1Group3)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.CbxVisto)
        Me.GroupBox1.Controls.Add(Me.LblVisto)
        Me.GroupBox1.Controls.Add(Me.ToolStrip1)
        Me.GroupBox1.Controls.Add(Me.TxtObservaciones)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Frm1Group4)
        Me.GroupBox1.Controls.Add(Me.TxtEdicionesFaltantes)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.TxtNumPaginas)
        Me.GroupBox1.Controls.Add(Me.TxtCodIdentificacion)
        Me.GroupBox1.Controls.Add(Me.TxtNumEdiciones)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Frm1Group2)
        Me.GroupBox1.Controls.Add(Me.frm1Group1)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(950, 294)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Empaste"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(462, 202)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(267, 15)
        Me.Label16.TabIndex = 23
        Me.Label16.Text = "NOTA : ( * ) Son campos obligatorios a ingresar."
        '
        'TxtNumExtraordinario
        '
        Me.TxtNumExtraordinario.Location = New System.Drawing.Point(382, 117)
        Me.TxtNumExtraordinario.MaxLength = 3
        Me.TxtNumExtraordinario.Name = "TxtNumExtraordinario"
        Me.TxtNumExtraordinario.Size = New System.Drawing.Size(71, 22)
        Me.TxtNumExtraordinario.TabIndex = 8
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(257, 120)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(119, 16)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "N°  Extraordinario *"
        '
        'TxtNumSuplementos
        '
        Me.TxtNumSuplementos.Location = New System.Drawing.Point(382, 86)
        Me.TxtNumSuplementos.MaxLength = 3
        Me.TxtNumSuplementos.Name = "TxtNumSuplementos"
        Me.TxtNumSuplementos.Size = New System.Drawing.Size(71, 22)
        Me.TxtNumSuplementos.TabIndex = 7
        '
        'Frm1Group3
        '
        Me.Frm1Group3.Controls.Add(Me.CbxEstadoEmpaste)
        Me.Frm1Group3.Location = New System.Drawing.Point(6, 158)
        Me.Frm1Group3.Name = "Frm1Group3"
        Me.Frm1Group3.Size = New System.Drawing.Size(216, 45)
        Me.Frm1Group3.TabIndex = 18
        Me.Frm1Group3.TabStop = False
        Me.Frm1Group3.Text = "Estado de Empaste (Soporte)"
        '
        'CbxEstadoEmpaste
        '
        Me.CbxEstadoEmpaste.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxEstadoEmpaste.FormattingEnabled = True
        Me.CbxEstadoEmpaste.Location = New System.Drawing.Point(10, 17)
        Me.CbxEstadoEmpaste.Name = "CbxEstadoEmpaste"
        Me.CbxEstadoEmpaste.Size = New System.Drawing.Size(140, 24)
        Me.CbxEstadoEmpaste.TabIndex = 19
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(257, 89)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(105, 16)
        Me.Label23.TabIndex = 21
        Me.Label23.Text = "N° Suplemento *"
        '
        'CbxVisto
        '
        Me.CbxVisto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxVisto.FormattingEnabled = True
        Me.CbxVisto.Location = New System.Drawing.Point(612, 115)
        Me.CbxVisto.Name = "CbxVisto"
        Me.CbxVisto.Size = New System.Drawing.Size(120, 24)
        Me.CbxVisto.TabIndex = 20
        '
        'LblVisto
        '
        Me.LblVisto.AutoSize = True
        Me.LblVisto.Location = New System.Drawing.Point(474, 120)
        Me.LblVisto.Name = "LblVisto"
        Me.LblVisto.Size = New System.Drawing.Size(38, 16)
        Me.LblVisto.TabIndex = 19
        Me.LblVisto.Text = "Visto"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator6, Me.Frm_Empaste_TlsNuevo, Me.ToolStripSeparator1, Me.TlsGuardar, Me.ToolStripSeparator2, Me.TlsEliminar, Me.ToolStripSeparator9})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 18)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(944, 32)
        Me.ToolStrip1.TabIndex = 18
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 32)
        '
        'Frm_Empaste_TlsNuevo
        '
        Me.Frm_Empaste_TlsNuevo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frm_Empaste_TlsNuevo.Image = CType(resources.GetObject("Frm_Empaste_TlsNuevo.Image"), System.Drawing.Image)
        Me.Frm_Empaste_TlsNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Frm_Empaste_TlsNuevo.Name = "Frm_Empaste_TlsNuevo"
        Me.Frm_Empaste_TlsNuevo.Size = New System.Drawing.Size(71, 29)
        Me.Frm_Empaste_TlsNuevo.Text = "Nuevo"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 32)
        '
        'TlsGuardar
        '
        Me.TlsGuardar.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TlsGuardar.Image = CType(resources.GetObject("TlsGuardar.Image"), System.Drawing.Image)
        Me.TlsGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TlsGuardar.Name = "TlsGuardar"
        Me.TlsGuardar.Size = New System.Drawing.Size(78, 29)
        Me.TlsGuardar.Text = "Guardar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 32)
        '
        'TlsEliminar
        '
        Me.TlsEliminar.Image = CType(resources.GetObject("TlsEliminar.Image"), System.Drawing.Image)
        Me.TlsEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TlsEliminar.Name = "TlsEliminar"
        Me.TlsEliminar.Size = New System.Drawing.Size(83, 29)
        Me.TlsEliminar.Text = "Eliminar"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 32)
        '
        'TxtObservaciones
        '
        Me.TxtObservaciones.Location = New System.Drawing.Point(8, 220)
        Me.TxtObservaciones.MaxLength = 2000
        Me.TxtObservaciones.Multiline = True
        Me.TxtObservaciones.Name = "TxtObservaciones"
        Me.TxtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtObservaciones.Size = New System.Drawing.Size(718, 68)
        Me.TxtObservaciones.TabIndex = 14
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(11, 201)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(100, 16)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "Observaciones"
        '
        'Frm1Group4
        '
        Me.Frm1Group4.Controls.Add(Me.TxtNivel)
        Me.Frm1Group4.Controls.Add(Me.TxtAnaquel)
        Me.Frm1Group4.Controls.Add(Me.Label12)
        Me.Frm1Group4.Controls.Add(Me.Label11)
        Me.Frm1Group4.Location = New System.Drawing.Point(477, 141)
        Me.Frm1Group4.Name = "Frm1Group4"
        Me.Frm1Group4.Size = New System.Drawing.Size(229, 46)
        Me.Frm1Group4.TabIndex = 11
        Me.Frm1Group4.TabStop = False
        Me.Frm1Group4.Text = "Ubicación física"
        '
        'TxtNivel
        '
        Me.TxtNivel.Location = New System.Drawing.Point(170, 17)
        Me.TxtNivel.Name = "TxtNivel"
        Me.TxtNivel.Size = New System.Drawing.Size(50, 22)
        Me.TxtNivel.TabIndex = 13
        '
        'TxtAnaquel
        '
        Me.TxtAnaquel.Location = New System.Drawing.Point(71, 17)
        Me.TxtAnaquel.Name = "TxtAnaquel"
        Me.TxtAnaquel.Size = New System.Drawing.Size(50, 22)
        Me.TxtAnaquel.TabIndex = 12
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(124, 20)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(47, 16)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Nivel *"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(4, 20)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 16)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Anaquel *"
        '
        'TxtEdicionesFaltantes
        '
        Me.TxtEdicionesFaltantes.Location = New System.Drawing.Point(611, 86)
        Me.TxtEdicionesFaltantes.Name = "TxtEdicionesFaltantes"
        Me.TxtEdicionesFaltantes.Size = New System.Drawing.Size(120, 22)
        Me.TxtEdicionesFaltantes.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(474, 89)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(126, 16)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Ediciones Faltantes"
        '
        'TxtNumPaginas
        '
        Me.TxtNumPaginas.Enabled = False
        Me.TxtNumPaginas.Location = New System.Drawing.Point(382, 150)
        Me.TxtNumPaginas.Name = "TxtNumPaginas"
        Me.TxtNumPaginas.Size = New System.Drawing.Size(71, 22)
        Me.TxtNumPaginas.TabIndex = 9
        '
        'TxtCodIdentificacion
        '
        Me.TxtCodIdentificacion.Location = New System.Drawing.Point(581, 54)
        Me.TxtCodIdentificacion.MaxLength = 11
        Me.TxtCodIdentificacion.Name = "TxtCodIdentificacion"
        Me.TxtCodIdentificacion.Size = New System.Drawing.Size(150, 22)
        Me.TxtCodIdentificacion.TabIndex = 1
        '
        'TxtNumEdiciones
        '
        Me.TxtNumEdiciones.Location = New System.Drawing.Point(382, 55)
        Me.TxtNumEdiciones.MaxLength = 3
        Me.TxtNumEdiciones.Name = "TxtNumEdiciones"
        Me.TxtNumEdiciones.Size = New System.Drawing.Size(71, 22)
        Me.TxtNumEdiciones.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(454, 56)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(125, 16)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Cod. Identificación *"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(257, 153)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 16)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "N° Páginas"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(257, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 16)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "N° Ediciones *"
        '
        'Frm1Group2
        '
        Me.Frm1Group2.Controls.Add(Me.TxtAltura)
        Me.Frm1Group2.Controls.Add(Me.Frm1Lbl4)
        Me.Frm1Group2.Controls.Add(Me.Frm2Lbl3)
        Me.Frm1Group2.Controls.Add(Me.TxtAncho)
        Me.Frm1Group2.Controls.Add(Me.TxtLargo)
        Me.Frm1Group2.Controls.Add(Me.Frm2Lbl2)
        Me.Frm1Group2.Location = New System.Drawing.Point(6, 94)
        Me.Frm1Group2.Name = "Frm1Group2"
        Me.Frm1Group2.Size = New System.Drawing.Size(216, 63)
        Me.Frm1Group2.TabIndex = 2
        Me.Frm1Group2.TabStop = False
        Me.Frm1Group2.Text = "Dimenciones del tomo (cm.)"
        '
        'TxtAltura
        '
        Me.TxtAltura.Location = New System.Drawing.Point(158, 35)
        Me.TxtAltura.Name = "TxtAltura"
        Me.TxtAltura.Size = New System.Drawing.Size(50, 22)
        Me.TxtAltura.TabIndex = 5
        '
        'Frm1Lbl4
        '
        Me.Frm1Lbl4.AutoSize = True
        Me.Frm1Lbl4.Location = New System.Drawing.Point(161, 16)
        Me.Frm1Lbl4.Name = "Frm1Lbl4"
        Me.Frm1Lbl4.Size = New System.Drawing.Size(50, 16)
        Me.Frm1Lbl4.TabIndex = 4
        Me.Frm1Lbl4.Text = "Altura *"
        '
        'Frm2Lbl3
        '
        Me.Frm2Lbl3.AutoSize = True
        Me.Frm2Lbl3.Location = New System.Drawing.Point(88, 16)
        Me.Frm2Lbl3.Name = "Frm2Lbl3"
        Me.Frm2Lbl3.Size = New System.Drawing.Size(54, 16)
        Me.Frm2Lbl3.TabIndex = 3
        Me.Frm2Lbl3.Text = "Ancho *"
        '
        'TxtAncho
        '
        Me.TxtAncho.Location = New System.Drawing.Point(84, 35)
        Me.TxtAncho.Name = "TxtAncho"
        Me.TxtAncho.Size = New System.Drawing.Size(50, 22)
        Me.TxtAncho.TabIndex = 4
        '
        'TxtLargo
        '
        Me.TxtLargo.Location = New System.Drawing.Point(10, 35)
        Me.TxtLargo.Name = "TxtLargo"
        Me.TxtLargo.Size = New System.Drawing.Size(50, 22)
        Me.TxtLargo.TabIndex = 3
        '
        'Frm2Lbl2
        '
        Me.Frm2Lbl2.AutoSize = True
        Me.Frm2Lbl2.Location = New System.Drawing.Point(12, 16)
        Me.Frm2Lbl2.Name = "Frm2Lbl2"
        Me.Frm2Lbl2.Size = New System.Drawing.Size(51, 16)
        Me.Frm2Lbl2.TabIndex = 0
        Me.Frm2Lbl2.Text = "Largo *"
        '
        'frm1Group1
        '
        Me.frm1Group1.Controls.Add(Me.Label2)
        Me.frm1Group1.Controls.Add(Me.DtpFecInicio)
        Me.frm1Group1.Controls.Add(Me.DtpFecTermino)
        Me.frm1Group1.Controls.Add(Me.Frm1Lbl1)
        Me.frm1Group1.Controls.Add(Me.Label3)
        Me.frm1Group1.Location = New System.Drawing.Point(6, 49)
        Me.frm1Group1.Name = "frm1Group1"
        Me.frm1Group1.Size = New System.Drawing.Size(248, 45)
        Me.frm1Group1.TabIndex = 15
        Me.frm1Group1.TabStop = False
        Me.frm1Group1.Text = "Fecha"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(131, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Al"
        '
        'DtpFecInicio
        '
        Me.DtpFecInicio.CalendarTitleBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.DtpFecInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpFecInicio.Location = New System.Drawing.Point(37, 17)
        Me.DtpFecInicio.Name = "DtpFecInicio"
        Me.DtpFecInicio.Size = New System.Drawing.Size(88, 22)
        Me.DtpFecInicio.TabIndex = 16
        '
        'DtpFecTermino
        '
        Me.DtpFecTermino.CalendarTitleBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.DtpFecTermino.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpFecTermino.Location = New System.Drawing.Point(152, 17)
        Me.DtpFecTermino.Name = "DtpFecTermino"
        Me.DtpFecTermino.Size = New System.Drawing.Size(88, 22)
        Me.DtpFecTermino.TabIndex = 17
        '
        'Frm1Lbl1
        '
        Me.Frm1Lbl1.AutoSize = True
        Me.Frm1Lbl1.Location = New System.Drawing.Point(3, 20)
        Me.Frm1Lbl1.Name = "Frm1Lbl1"
        Me.Frm1Lbl1.Size = New System.Drawing.Size(37, 16)
        Me.Frm1Lbl1.TabIndex = 0
        Me.Frm1Lbl1.Text = "Del *"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(72, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "al *"
        '
        'TpgBusqueda
        '
        Me.TpgBusqueda.Controls.Add(Me.GroupBox6)
        Me.TpgBusqueda.Location = New System.Drawing.Point(4, 25)
        Me.TpgBusqueda.Name = "TpgBusqueda"
        Me.TpgBusqueda.Padding = New System.Windows.Forms.Padding(3)
        Me.TpgBusqueda.Size = New System.Drawing.Size(962, 306)
        Me.TpgBusqueda.TabIndex = 1
        Me.TpgBusqueda.Text = "Búsqueda"
        Me.TpgBusqueda.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.ToolStrip2)
        Me.GroupBox6.Controls.Add(Me.GroupBox8)
        Me.GroupBox6.Controls.Add(Me.GroupBox7)
        Me.GroupBox6.Location = New System.Drawing.Point(6, 1)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(738, 280)
        Me.GroupBox6.TabIndex = 0
        Me.GroupBox6.TabStop = False
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator4, Me.TlsSeleccionarEmpaste, Me.ToolStripSeparator5})
        Me.ToolStrip2.Location = New System.Drawing.Point(3, 18)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(732, 32)
        Me.ToolStrip2.TabIndex = 2
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 32)
        '
        'TlsSeleccionarEmpaste
        '
        Me.TlsSeleccionarEmpaste.Image = CType(resources.GetObject("TlsSeleccionarEmpaste.Image"), System.Drawing.Image)
        Me.TlsSeleccionarEmpaste.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TlsSeleccionarEmpaste.Name = "TlsSeleccionarEmpaste"
        Me.TlsSeleccionarEmpaste.Size = New System.Drawing.Size(103, 29)
        Me.TlsSeleccionarEmpaste.Text = "Seleccionar"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 32)
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.DgwEmpasteBusqueda)
        Me.GroupBox8.Location = New System.Drawing.Point(6, 102)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(726, 172)
        Me.GroupBox8.TabIndex = 1
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Datos filtrados"
        '
        'DgwEmpasteBusqueda
        '
        Me.DgwEmpasteBusqueda.AllowUserToAddRows = False
        Me.DgwEmpasteBusqueda.AllowUserToDeleteRows = False
        Me.DgwEmpasteBusqueda.BackgroundColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.DgwEmpasteBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgwEmpasteBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgwEmpasteBusqueda.Location = New System.Drawing.Point(7, 21)
        Me.DgwEmpasteBusqueda.MultiSelect = False
        Me.DgwEmpasteBusqueda.Name = "DgwEmpasteBusqueda"
        Me.DgwEmpasteBusqueda.ReadOnly = True
        Me.DgwEmpasteBusqueda.RowHeadersVisible = False
        Me.DgwEmpasteBusqueda.RowHeadersWidth = 50
        Me.DgwEmpasteBusqueda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgwEmpasteBusqueda.Size = New System.Drawing.Size(713, 144)
        Me.DgwEmpasteBusqueda.TabIndex = 0
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.TxtObservacionEmpasteBusqueda)
        Me.GroupBox7.Controls.Add(Me.Label4)
        Me.GroupBox7.Controls.Add(Me.BtnBuscar)
        Me.GroupBox7.Controls.Add(Me.TxtCodIdentificacionBusqueda)
        Me.GroupBox7.Controls.Add(Me.Label15)
        Me.GroupBox7.Location = New System.Drawing.Point(6, 55)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(726, 44)
        Me.GroupBox7.TabIndex = 0
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Filtro de búsqueda"
        '
        'TxtObservacionEmpasteBusqueda
        '
        Me.TxtObservacionEmpasteBusqueda.Location = New System.Drawing.Point(353, 17)
        Me.TxtObservacionEmpasteBusqueda.Name = "TxtObservacionEmpasteBusqueda"
        Me.TxtObservacionEmpasteBusqueda.Size = New System.Drawing.Size(286, 22)
        Me.TxtObservacionEmpasteBusqueda.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(266, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Observación"
        '
        'BtnBuscar
        '
        Me.BtnBuscar.ImageKey = "(none)"
        Me.BtnBuscar.Location = New System.Drawing.Point(645, 16)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscar.TabIndex = 2
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'TxtCodIdentificacionBusqueda
        '
        Me.TxtCodIdentificacionBusqueda.Location = New System.Drawing.Point(158, 17)
        Me.TxtCodIdentificacionBusqueda.MaxLength = 11
        Me.TxtCodIdentificacionBusqueda.Name = "TxtCodIdentificacionBusqueda"
        Me.TxtCodIdentificacionBusqueda.Size = New System.Drawing.Size(100, 22)
        Me.TxtCodIdentificacionBusqueda.TabIndex = 1
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(3, 20)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(152, 16)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Código de Identificación"
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.ToolStrip3)
        Me.GroupBox9.Controls.Add(Me.DgwEdicion)
        Me.GroupBox9.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(947, 271)
        Me.GroupBox9.TabIndex = 5
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Detalle del Empaste"
        '
        'ToolStrip3
        '
        Me.ToolStrip3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip3.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator7, Me.TlsAgregarEdicion, Me.ToolStripSeparator3, Me.TlsModificarEdicion, Me.ToolStripSeparator8, Me.TlsEliminarEdicion, Me.ToolStripSeparator12, Me.TlsProcesarEdicion, Me.ToolStripSeparator16, Me.TlsPDFaQA, Me.ToolStripSeparator17})
        Me.ToolStrip3.Location = New System.Drawing.Point(3, 16)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Size = New System.Drawing.Size(941, 32)
        Me.ToolStrip3.TabIndex = 1
        Me.ToolStrip3.Text = "ToolStrip3"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 32)
        '
        'TlsAgregarEdicion
        '
        Me.TlsAgregarEdicion.Image = CType(resources.GetObject("TlsAgregarEdicion.Image"), System.Drawing.Image)
        Me.TlsAgregarEdicion.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TlsAgregarEdicion.Name = "TlsAgregarEdicion"
        Me.TlsAgregarEdicion.Size = New System.Drawing.Size(127, 29)
        Me.TlsAgregarEdicion.Text = "Agregar Edición"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 32)
        '
        'TlsModificarEdicion
        '
        Me.TlsModificarEdicion.Image = CType(resources.GetObject("TlsModificarEdicion.Image"), System.Drawing.Image)
        Me.TlsModificarEdicion.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TlsModificarEdicion.Name = "TlsModificarEdicion"
        Me.TlsModificarEdicion.Size = New System.Drawing.Size(133, 29)
        Me.TlsModificarEdicion.Text = "Modificar Edición"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 32)
        '
        'TlsEliminarEdicion
        '
        Me.TlsEliminarEdicion.Image = CType(resources.GetObject("TlsEliminarEdicion.Image"), System.Drawing.Image)
        Me.TlsEliminarEdicion.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TlsEliminarEdicion.Name = "TlsEliminarEdicion"
        Me.TlsEliminarEdicion.Size = New System.Drawing.Size(127, 29)
        Me.TlsEliminarEdicion.Text = "Eliminar Edición"
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(6, 32)
        '
        'TlsProcesarEdicion
        '
        Me.TlsProcesarEdicion.Image = Global.Logistica.My.Resources.Resources.pdf
        Me.TlsProcesarEdicion.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TlsProcesarEdicion.Name = "TlsProcesarEdicion"
        Me.TlsProcesarEdicion.Size = New System.Drawing.Size(123, 29)
        Me.TlsProcesarEdicion.Text = "Relacionar PDF"
        '
        'ToolStripSeparator16
        '
        Me.ToolStripSeparator16.Name = "ToolStripSeparator16"
        Me.ToolStripSeparator16.Size = New System.Drawing.Size(6, 32)
        '
        'TlsPDFaQA
        '
        Me.TlsPDFaQA.Image = CType(resources.GetObject("TlsPDFaQA.Image"), System.Drawing.Image)
        Me.TlsPDFaQA.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TlsPDFaQA.Name = "TlsPDFaQA"
        Me.TlsPDFaQA.Size = New System.Drawing.Size(104, 29)
        Me.TlsPDFaQA.Text = "Enviar a QA"
        '
        'ToolStripSeparator17
        '
        Me.ToolStripSeparator17.Name = "ToolStripSeparator17"
        Me.ToolStripSeparator17.Size = New System.Drawing.Size(6, 32)
        '
        'DgwEdicion
        '
        Me.DgwEdicion.AllowUserToAddRows = False
        Me.DgwEdicion.AllowUserToDeleteRows = False
        Me.DgwEdicion.AllowUserToOrderColumns = True
        Me.DgwEdicion.AllowUserToResizeColumns = False
        Me.DgwEdicion.AllowUserToResizeRows = False
        Me.DgwEdicion.BackgroundColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.DgwEdicion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgwEdicion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgwEdicion.GridColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.DgwEdicion.Location = New System.Drawing.Point(3, 48)
        Me.DgwEdicion.MultiSelect = False
        Me.DgwEdicion.Name = "DgwEdicion"
        Me.DgwEdicion.ReadOnly = True
        Me.DgwEdicion.RowHeadersVisible = False
        Me.DgwEdicion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgwEdicion.Size = New System.Drawing.Size(936, 223)
        Me.DgwEdicion.TabIndex = 0
        '
        'DgvEmpasteGuardado
        '
        Me.DgvEmpasteGuardado.AllowUserToAddRows = False
        Me.DgvEmpasteGuardado.AllowUserToDeleteRows = False
        Me.DgvEmpasteGuardado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvEmpasteGuardado.ColumnHeadersVisible = False
        Me.DgvEmpasteGuardado.Location = New System.Drawing.Point(682, 4)
        Me.DgvEmpasteGuardado.MultiSelect = False
        Me.DgvEmpasteGuardado.Name = "DgvEmpasteGuardado"
        Me.DgvEmpasteGuardado.ReadOnly = True
        Me.DgvEmpasteGuardado.RowHeadersVisible = False
        Me.DgvEmpasteGuardado.Size = New System.Drawing.Size(88, 31)
        Me.DgvEmpasteGuardado.TabIndex = 6
        Me.DgvEmpasteGuardado.Visible = False
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 32)
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(6, 32)
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TpgDetalleEmpaste)
        Me.TabControl2.Controls.Add(Me.TpgBusquedaDetalleEmpaste)
        Me.TabControl2.Location = New System.Drawing.Point(12, 370)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(970, 309)
        Me.TabControl2.TabIndex = 7
        '
        'TpgDetalleEmpaste
        '
        Me.TpgDetalleEmpaste.Controls.Add(Me.GroupBox9)
        Me.TpgDetalleEmpaste.Location = New System.Drawing.Point(4, 22)
        Me.TpgDetalleEmpaste.Name = "TpgDetalleEmpaste"
        Me.TpgDetalleEmpaste.Padding = New System.Windows.Forms.Padding(3)
        Me.TpgDetalleEmpaste.Size = New System.Drawing.Size(962, 283)
        Me.TpgDetalleEmpaste.TabIndex = 0
        Me.TpgDetalleEmpaste.Text = "Registros de Detalle de Empaste"
        Me.TpgDetalleEmpaste.UseVisualStyleBackColor = True
        '
        'TpgBusquedaDetalleEmpaste
        '
        Me.TpgBusquedaDetalleEmpaste.Controls.Add(Me.GroupBox2)
        Me.TpgBusquedaDetalleEmpaste.Controls.Add(Me.ToolStrip4)
        Me.TpgBusquedaDetalleEmpaste.Location = New System.Drawing.Point(4, 22)
        Me.TpgBusquedaDetalleEmpaste.Name = "TpgBusquedaDetalleEmpaste"
        Me.TpgBusquedaDetalleEmpaste.Padding = New System.Windows.Forms.Padding(3)
        Me.TpgBusquedaDetalleEmpaste.Size = New System.Drawing.Size(962, 283)
        Me.TpgBusquedaDetalleEmpaste.TabIndex = 1
        Me.TpgBusquedaDetalleEmpaste.Text = "Busqueda Detalle Empaste"
        Me.TpgBusquedaDetalleEmpaste.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LblCodigoDetalleEmpaste)
        Me.GroupBox2.Controls.Add(Me.TxtObservacionesDetalleEmpasteBusqueda)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TxtCodigoDetalleEmpasteBusqueda)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(6, 38)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(738, 102)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filtro de búsqueda"
        '
        'LblCodigoDetalleEmpaste
        '
        Me.LblCodigoDetalleEmpaste.AutoSize = True
        Me.LblCodigoDetalleEmpaste.Location = New System.Drawing.Point(167, 25)
        Me.LblCodigoDetalleEmpaste.Name = "LblCodigoDetalleEmpaste"
        Me.LblCodigoDetalleEmpaste.Size = New System.Drawing.Size(56, 16)
        Me.LblCodigoDetalleEmpaste.TabIndex = 4
        Me.LblCodigoDetalleEmpaste.Text = "Label17"
        '
        'TxtObservacionesDetalleEmpasteBusqueda
        '
        Me.TxtObservacionesDetalleEmpasteBusqueda.Location = New System.Drawing.Point(164, 58)
        Me.TxtObservacionesDetalleEmpasteBusqueda.Name = "TxtObservacionesDetalleEmpasteBusqueda"
        Me.TxtObservacionesDetalleEmpasteBusqueda.Size = New System.Drawing.Size(367, 22)
        Me.TxtObservacionesDetalleEmpasteBusqueda.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 16)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Observación"
        '
        'TxtCodigoDetalleEmpasteBusqueda
        '
        Me.TxtCodigoDetalleEmpasteBusqueda.Location = New System.Drawing.Point(262, 22)
        Me.TxtCodigoDetalleEmpasteBusqueda.MaxLength = 6
        Me.TxtCodigoDetalleEmpasteBusqueda.Name = "TxtCodigoDetalleEmpasteBusqueda"
        Me.TxtCodigoDetalleEmpasteBusqueda.Size = New System.Drawing.Size(50, 22)
        Me.TxtCodigoDetalleEmpasteBusqueda.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(152, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Código de Identificación"
        '
        'ToolStrip4
        '
        Me.ToolStrip4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip4.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.ToolStrip4.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator13, Me.TlsBuscarDetalleEmpaste, Me.ToolStripSeparator14, Me.TlsLimpiarBusquedaDetalleEmpaste, Me.ToolStripSeparator15})
        Me.ToolStrip4.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip4.Name = "ToolStrip4"
        Me.ToolStrip4.Size = New System.Drawing.Size(956, 32)
        Me.ToolStrip4.TabIndex = 0
        Me.ToolStrip4.Text = "ToolStrip4"
        '
        'ToolStripSeparator13
        '
        Me.ToolStripSeparator13.Name = "ToolStripSeparator13"
        Me.ToolStripSeparator13.Size = New System.Drawing.Size(6, 32)
        '
        'TlsBuscarDetalleEmpaste
        '
        Me.TlsBuscarDetalleEmpaste.Image = CType(resources.GetObject("TlsBuscarDetalleEmpaste.Image"), System.Drawing.Image)
        Me.TlsBuscarDetalleEmpaste.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TlsBuscarDetalleEmpaste.Name = "TlsBuscarDetalleEmpaste"
        Me.TlsBuscarDetalleEmpaste.Size = New System.Drawing.Size(189, 29)
        Me.TlsBuscarDetalleEmpaste.Text = "Buscar Detalle de Empaste"
        '
        'ToolStripSeparator14
        '
        Me.ToolStripSeparator14.Name = "ToolStripSeparator14"
        Me.ToolStripSeparator14.Size = New System.Drawing.Size(6, 32)
        '
        'TlsLimpiarBusquedaDetalleEmpaste
        '
        Me.TlsLimpiarBusquedaDetalleEmpaste.Image = CType(resources.GetObject("TlsLimpiarBusquedaDetalleEmpaste.Image"), System.Drawing.Image)
        Me.TlsLimpiarBusquedaDetalleEmpaste.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TlsLimpiarBusquedaDetalleEmpaste.Name = "TlsLimpiarBusquedaDetalleEmpaste"
        Me.TlsLimpiarBusquedaDetalleEmpaste.Size = New System.Drawing.Size(200, 29)
        Me.TlsLimpiarBusquedaDetalleEmpaste.Text = "Limpiar criterio de búsqueda"
        '
        'ToolStripSeparator15
        '
        Me.ToolStripSeparator15.Name = "ToolStripSeparator15"
        Me.ToolStripSeparator15.Size = New System.Drawing.Size(6, 32)
        '
        'Frm_Empaste
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(994, 694)
        Me.Controls.Add(Me.TabControl2)
        Me.Controls.Add(Me.DgvEmpasteGuardado)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Frm_Empaste"
        Me.Text = "Inventario de empaste"
        Me.TabControl1.ResumeLayout(False)
        Me.TpgEmpasteIngreso.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Frm1Group3.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Frm1Group4.ResumeLayout(False)
        Me.Frm1Group4.PerformLayout()
        Me.Frm1Group2.ResumeLayout(False)
        Me.Frm1Group2.PerformLayout()
        Me.frm1Group1.ResumeLayout(False)
        Me.frm1Group1.PerformLayout()
        Me.TpgBusqueda.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        CType(Me.DgwEmpasteBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        CType(Me.DgwEdicion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvEmpasteGuardado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl2.ResumeLayout(False)
        Me.TpgDetalleEmpaste.ResumeLayout(False)
        Me.TpgBusquedaDetalleEmpaste.ResumeLayout(False)
        Me.TpgBusquedaDetalleEmpaste.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ToolStrip4.ResumeLayout(False)
        Me.ToolStrip4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TpgEmpasteIngreso As System.Windows.Forms.TabPage
    Friend WithEvents TpgBusqueda As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Frm1Group4 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtNivel As System.Windows.Forms.TextBox
    Friend WithEvents TxtAnaquel As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TxtEdicionesFaltantes As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtNumPaginas As System.Windows.Forms.TextBox
    Friend WithEvents TxtCodIdentificacion As System.Windows.Forms.TextBox
    Friend WithEvents TxtNumEdiciones As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Frm1Group3 As System.Windows.Forms.GroupBox
    Friend WithEvents Frm1Group2 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtAltura As System.Windows.Forms.TextBox
    Friend WithEvents Frm1Lbl4 As System.Windows.Forms.Label
    Friend WithEvents Frm2Lbl3 As System.Windows.Forms.Label
    Friend WithEvents TxtAncho As System.Windows.Forms.TextBox
    Friend WithEvents TxtLargo As System.Windows.Forms.TextBox
    Friend WithEvents Frm2Lbl2 As System.Windows.Forms.Label
    Friend WithEvents frm1Group1 As System.Windows.Forms.GroupBox
    Friend WithEvents DtpFecTermino As System.Windows.Forms.DateTimePicker
    Friend WithEvents Frm1Lbl1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents BtnBuscar As System.Windows.Forms.Button
    Friend WithEvents TxtCodIdentificacionBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents DgwEmpasteBusqueda As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Frm_Empaste_TlsNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TlsGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TxtNumSuplementos As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents CbxVisto As System.Windows.Forms.ComboBox
    Friend WithEvents LblVisto As System.Windows.Forms.Label
    Friend WithEvents CbxEstadoEmpaste As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolStrip3 As System.Windows.Forms.ToolStrip
    Friend WithEvents TlsAgregarEdicion As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TlsEliminarEdicion As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TxtNumExtraordinario As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents DtpFecInicio As System.Windows.Forms.DateTimePicker
    Public WithEvents DgwEdicion As System.Windows.Forms.DataGridView
    Friend WithEvents TlsSeleccionarEmpaste As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DgvEmpasteGuardado As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TlsModificarEdicion As System.Windows.Forms.ToolStripButton
    Friend WithEvents TlsEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator11 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator12 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtObservacionEmpasteBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TpgDetalleEmpaste As System.Windows.Forms.TabPage
    Friend WithEvents TpgBusquedaDetalleEmpaste As System.Windows.Forms.TabPage
    Friend WithEvents ToolStrip4 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator13 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TlsBuscarDetalleEmpaste As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtCodigoDetalleEmpasteBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator14 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TxtObservacionesDetalleEmpasteBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents LblCodigoDetalleEmpaste As System.Windows.Forms.Label
    Friend WithEvents TlsLimpiarBusquedaDetalleEmpaste As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator15 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TlsProcesarEdicion As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator16 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TlsPDFaQA As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator17 As System.Windows.Forms.ToolStripSeparator

End Class
