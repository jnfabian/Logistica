<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Edicion
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Edicion))
        Me.TpgDatos = New System.Windows.Forms.TabPage
        Me.tbSubtitulo = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.tbTitulo = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.TxtCodEdi = New System.Windows.Forms.TextBox
        Me.LblCodIden = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.TxtObservaciones = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.CbxTipo = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtENumPagEdicion = New System.Windows.Forms.TextBox
        Me.LblNumeroPaginas = New System.Windows.Forms.Label
        Me.TxtEPagFaltantes = New System.Windows.Forms.TextBox
        Me.TxtENumEdicion = New System.Windows.Forms.TextBox
        Me.LblNumero = New System.Windows.Forms.Label
        Me.DtpEFechaEdicion = New System.Windows.Forms.DateTimePicker
        Me.LblFecha = New System.Windows.Forms.Label
        Me.TxtEDirector = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.GroupBox9 = New System.Windows.Forms.GroupBox
        Me.CkxEDeteriorado = New System.Windows.Forms.CheckBox
        Me.CkxEGrueso = New System.Windows.Forms.CheckBox
        Me.CkxEDelgado = New System.Windows.Forms.CheckBox
        Me.CkxEBueno = New System.Windows.Forms.CheckBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.TlsGuardar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.DtpI = New System.Windows.Forms.DateTimePicker
        Me.DtpF = New System.Windows.Forms.DateTimePicker
        Me.TabControl2 = New System.Windows.Forms.TabControl
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.TlsAgregarPagina = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.TlsModificarPagina = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.TlsEliminarPagina = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.TlsCargarImagen = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.TlsPasarQA = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator
        Me.DgwPaginas = New System.Windows.Forms.DataGridView
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TpgDatos.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.ToolStrip3.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DgwPaginas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TpgDatos
        '
        Me.TpgDatos.Controls.Add(Me.tbSubtitulo)
        Me.TpgDatos.Controls.Add(Me.Label4)
        Me.TpgDatos.Controls.Add(Me.tbTitulo)
        Me.TpgDatos.Controls.Add(Me.Label3)
        Me.TpgDatos.Controls.Add(Me.GroupBox2)
        Me.TpgDatos.Controls.Add(Me.Label16)
        Me.TpgDatos.Controls.Add(Me.TxtObservaciones)
        Me.TpgDatos.Controls.Add(Me.Label2)
        Me.TpgDatos.Controls.Add(Me.CbxTipo)
        Me.TpgDatos.Controls.Add(Me.Label1)
        Me.TpgDatos.Controls.Add(Me.TxtENumPagEdicion)
        Me.TpgDatos.Controls.Add(Me.LblNumeroPaginas)
        Me.TpgDatos.Controls.Add(Me.TxtEPagFaltantes)
        Me.TpgDatos.Controls.Add(Me.TxtENumEdicion)
        Me.TpgDatos.Controls.Add(Me.LblNumero)
        Me.TpgDatos.Controls.Add(Me.DtpEFechaEdicion)
        Me.TpgDatos.Controls.Add(Me.LblFecha)
        Me.TpgDatos.Controls.Add(Me.TxtEDirector)
        Me.TpgDatos.Controls.Add(Me.Label21)
        Me.TpgDatos.Controls.Add(Me.GroupBox9)
        Me.TpgDatos.Controls.Add(Me.Label19)
        Me.TpgDatos.Controls.Add(Me.ToolStrip3)
        Me.TpgDatos.Controls.Add(Me.DtpI)
        Me.TpgDatos.Controls.Add(Me.DtpF)
        Me.TpgDatos.Location = New System.Drawing.Point(4, 25)
        Me.TpgDatos.Name = "TpgDatos"
        Me.TpgDatos.Padding = New System.Windows.Forms.Padding(3)
        Me.TpgDatos.Size = New System.Drawing.Size(856, 318)
        Me.TpgDatos.TabIndex = 0
        Me.TpgDatos.Text = "Detalle de ediciones"
        Me.TpgDatos.UseVisualStyleBackColor = True
        '
        'tbSubtitulo
        '
        Me.tbSubtitulo.Location = New System.Drawing.Point(84, 210)
        Me.tbSubtitulo.Name = "tbSubtitulo"
        Me.tbSubtitulo.Size = New System.Drawing.Size(574, 22)
        Me.tbSubtitulo.TabIndex = 28
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 213)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 16)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Sub Titulo"
        '
        'tbTitulo
        '
        Me.tbTitulo.Location = New System.Drawing.Point(84, 179)
        Me.tbTitulo.Name = "tbTitulo"
        Me.tbTitulo.Size = New System.Drawing.Size(574, 22)
        Me.tbTitulo.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 16)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Titulo"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtCodEdi)
        Me.GroupBox2.Controls.Add(Me.LblCodIden)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(188, 36)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(206, 43)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Código Identificación *"
        '
        'TxtCodEdi
        '
        Me.TxtCodEdi.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodEdi.Location = New System.Drawing.Point(113, 15)
        Me.TxtCodEdi.MaxLength = 6
        Me.TxtCodEdi.Name = "TxtCodEdi"
        Me.TxtCodEdi.Size = New System.Drawing.Size(64, 24)
        Me.TxtCodEdi.TabIndex = 2
        '
        'LblCodIden
        '
        Me.LblCodIden.AutoSize = True
        Me.LblCodIden.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCodIden.Location = New System.Drawing.Point(6, 18)
        Me.LblCodIden.Name = "LblCodIden"
        Me.LblCodIden.Size = New System.Drawing.Size(55, 18)
        Me.LblCodIden.TabIndex = 26
        Me.LblCodIden.Text = "LblCod"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(414, 245)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(244, 15)
        Me.Label16.TabIndex = 24
        Me.Label16.Text = "NOTA : ( * ) Campos obligatorios a ingresar."
        '
        'TxtObservaciones
        '
        Me.TxtObservaciones.Location = New System.Drawing.Point(6, 263)
        Me.TxtObservaciones.MaxLength = 2000
        Me.TxtObservaciones.Multiline = True
        Me.TxtObservaciones.Name = "TxtObservaciones"
        Me.TxtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtObservaciones.Size = New System.Drawing.Size(659, 45)
        Me.TxtObservaciones.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 245)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 16)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Observaciones"
        '
        'CbxTipo
        '
        Me.CbxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxTipo.FormattingEnabled = True
        Me.CbxTipo.Location = New System.Drawing.Point(61, 46)
        Me.CbxTipo.Name = "CbxTipo"
        Me.CbxTipo.Size = New System.Drawing.Size(110, 24)
        Me.CbxTipo.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 16)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Tipo *"
        '
        'TxtENumPagEdicion
        '
        Me.TxtENumPagEdicion.Location = New System.Drawing.Point(571, 106)
        Me.TxtENumPagEdicion.Name = "TxtENumPagEdicion"
        Me.TxtENumPagEdicion.Size = New System.Drawing.Size(87, 22)
        Me.TxtENumPagEdicion.TabIndex = 4
        '
        'LblNumeroPaginas
        '
        Me.LblNumeroPaginas.AutoSize = True
        Me.LblNumeroPaginas.Location = New System.Drawing.Point(433, 109)
        Me.LblNumeroPaginas.Name = "LblNumeroPaginas"
        Me.LblNumeroPaginas.Size = New System.Drawing.Size(110, 16)
        Me.LblNumeroPaginas.TabIndex = 5
        Me.LblNumeroPaginas.Text = "N°. pág. edición *"
        '
        'TxtEPagFaltantes
        '
        Me.TxtEPagFaltantes.Location = New System.Drawing.Point(571, 142)
        Me.TxtEPagFaltantes.Name = "TxtEPagFaltantes"
        Me.TxtEPagFaltantes.Size = New System.Drawing.Size(87, 22)
        Me.TxtEPagFaltantes.TabIndex = 5
        '
        'TxtENumEdicion
        '
        Me.TxtENumEdicion.Location = New System.Drawing.Point(571, 76)
        Me.TxtENumEdicion.MaxLength = 3
        Me.TxtENumEdicion.Name = "TxtENumEdicion"
        Me.TxtENumEdicion.Size = New System.Drawing.Size(87, 22)
        Me.TxtENumEdicion.TabIndex = 3
        '
        'LblNumero
        '
        Me.LblNumero.AutoSize = True
        Me.LblNumero.Location = New System.Drawing.Point(449, 77)
        Me.LblNumero.Name = "LblNumero"
        Me.LblNumero.Size = New System.Drawing.Size(83, 16)
        Me.LblNumero.TabIndex = 3
        Me.LblNumero.Text = "N°.  edición *"
        '
        'DtpEFechaEdicion
        '
        Me.DtpEFechaEdicion.CalendarTitleBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.DtpEFechaEdicion.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpEFechaEdicion.Location = New System.Drawing.Point(571, 38)
        Me.DtpEFechaEdicion.Name = "DtpEFechaEdicion"
        Me.DtpEFechaEdicion.Size = New System.Drawing.Size(87, 22)
        Me.DtpEFechaEdicion.TabIndex = 7
        '
        'LblFecha
        '
        Me.LblFecha.AutoSize = True
        Me.LblFecha.Location = New System.Drawing.Point(433, 41)
        Me.LblFecha.Name = "LblFecha"
        Me.LblFecha.Size = New System.Drawing.Size(108, 16)
        Me.LblFecha.TabIndex = 1
        Me.LblFecha.Text = "Fec. de edición *"
        '
        'TxtEDirector
        '
        Me.TxtEDirector.Location = New System.Drawing.Point(61, 83)
        Me.TxtEDirector.Name = "TxtEDirector"
        Me.TxtEDirector.Size = New System.Drawing.Size(333, 22)
        Me.TxtEDirector.TabIndex = 6
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(427, 145)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(116, 16)
        Me.Label21.TabIndex = 12
        Me.Label21.Text = "Páginas Faltantes"
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.CkxEDeteriorado)
        Me.GroupBox9.Controls.Add(Me.CkxEGrueso)
        Me.GroupBox9.Controls.Add(Me.CkxEDelgado)
        Me.GroupBox9.Controls.Add(Me.CkxEBueno)
        Me.GroupBox9.Location = New System.Drawing.Point(7, 106)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(387, 58)
        Me.GroupBox9.TabIndex = 9
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Calidad de papel *"
        '
        'CkxEDeteriorado
        '
        Me.CkxEDeteriorado.AutoSize = True
        Me.CkxEDeteriorado.Location = New System.Drawing.Point(181, 35)
        Me.CkxEDeteriorado.Name = "CkxEDeteriorado"
        Me.CkxEDeteriorado.Size = New System.Drawing.Size(99, 20)
        Me.CkxEDeteriorado.TabIndex = 13
        Me.CkxEDeteriorado.Text = "Deteriorado"
        Me.CkxEDeteriorado.UseVisualStyleBackColor = True
        '
        'CkxEGrueso
        '
        Me.CkxEGrueso.AutoSize = True
        Me.CkxEGrueso.Location = New System.Drawing.Point(16, 35)
        Me.CkxEGrueso.Name = "CkxEGrueso"
        Me.CkxEGrueso.Size = New System.Drawing.Size(71, 20)
        Me.CkxEGrueso.TabIndex = 11
        Me.CkxEGrueso.Text = "Grueso"
        Me.CkxEGrueso.UseVisualStyleBackColor = True
        '
        'CkxEDelgado
        '
        Me.CkxEDelgado.AutoSize = True
        Me.CkxEDelgado.Location = New System.Drawing.Point(181, 17)
        Me.CkxEDelgado.Name = "CkxEDelgado"
        Me.CkxEDelgado.Size = New System.Drawing.Size(80, 20)
        Me.CkxEDelgado.TabIndex = 12
        Me.CkxEDelgado.Text = "Delgado"
        Me.CkxEDelgado.UseVisualStyleBackColor = True
        '
        'CkxEBueno
        '
        Me.CkxEBueno.AutoSize = True
        Me.CkxEBueno.Location = New System.Drawing.Point(16, 17)
        Me.CkxEBueno.Name = "CkxEBueno"
        Me.CkxEBueno.Size = New System.Drawing.Size(66, 20)
        Me.CkxEBueno.TabIndex = 10
        Me.CkxEBueno.Text = "Bueno"
        Me.CkxEBueno.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(4, 86)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(55, 16)
        Me.Label19.TabIndex = 7
        Me.Label19.Text = "Director"
        '
        'ToolStrip3
        '
        Me.ToolStrip3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip3.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator3, Me.TlsGuardar, Me.ToolStripSeparator7, Me.ToolStripButton1})
        Me.ToolStrip3.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Size = New System.Drawing.Size(850, 32)
        Me.ToolStrip3.TabIndex = 0
        Me.ToolStrip3.Text = "ToolStrip3"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 32)
        '
        'TlsGuardar
        '
        Me.TlsGuardar.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TlsGuardar.Image = CType(resources.GetObject("TlsGuardar.Image"), System.Drawing.Image)
        Me.TlsGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TlsGuardar.Name = "TlsGuardar"
        Me.TlsGuardar.Size = New System.Drawing.Size(83, 29)
        Me.TlsGuardar.Text = "Guardar"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 32)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(29, 29)
        Me.ToolStripButton1.Text = "Cambiar Tipo"
        '
        'DtpI
        '
        Me.DtpI.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpI.Location = New System.Drawing.Point(278, 6)
        Me.DtpI.Name = "DtpI"
        Me.DtpI.Size = New System.Drawing.Size(87, 22)
        Me.DtpI.TabIndex = 17
        '
        'DtpF
        '
        Me.DtpF.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpF.Location = New System.Drawing.Point(390, 6)
        Me.DtpF.Name = "DtpF"
        Me.DtpF.Size = New System.Drawing.Size(87, 22)
        Me.DtpF.TabIndex = 18
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TpgDatos)
        Me.TabControl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl2.Location = New System.Drawing.Point(12, 4)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(864, 347)
        Me.TabControl2.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ToolStrip1)
        Me.GroupBox1.Controls.Add(Me.DgwPaginas)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 365)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(870, 243)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Paginas del detalle de empaste"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.TlsAgregarPagina, Me.ToolStripSeparator2, Me.TlsModificarPagina, Me.ToolStripSeparator5, Me.TlsEliminarPagina, Me.ToolStripSeparator4, Me.TlsCargarImagen, Me.ToolStripSeparator6, Me.TlsPasarQA, Me.ToolStripSeparator8})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 16)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(864, 32)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 32)
        '
        'TlsAgregarPagina
        '
        Me.TlsAgregarPagina.Image = CType(resources.GetObject("TlsAgregarPagina.Image"), System.Drawing.Image)
        Me.TlsAgregarPagina.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TlsAgregarPagina.Name = "TlsAgregarPagina"
        Me.TlsAgregarPagina.Size = New System.Drawing.Size(125, 29)
        Me.TlsAgregarPagina.Text = "Agregar Página"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 32)
        '
        'TlsModificarPagina
        '
        Me.TlsModificarPagina.Image = CType(resources.GetObject("TlsModificarPagina.Image"), System.Drawing.Image)
        Me.TlsModificarPagina.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TlsModificarPagina.Name = "TlsModificarPagina"
        Me.TlsModificarPagina.Size = New System.Drawing.Size(131, 29)
        Me.TlsModificarPagina.Text = "Modificar Página"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 32)
        '
        'TlsEliminarPagina
        '
        Me.TlsEliminarPagina.Image = CType(resources.GetObject("TlsEliminarPagina.Image"), System.Drawing.Image)
        Me.TlsEliminarPagina.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TlsEliminarPagina.Name = "TlsEliminarPagina"
        Me.TlsEliminarPagina.Size = New System.Drawing.Size(125, 29)
        Me.TlsEliminarPagina.Text = "Eliminar Página"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 32)
        '
        'TlsCargarImagen
        '
        Me.TlsCargarImagen.Image = Global.Logistica.My.Resources.Resources.imagen
        Me.TlsCargarImagen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TlsCargarImagen.Name = "TlsCargarImagen"
        Me.TlsCargarImagen.Size = New System.Drawing.Size(144, 29)
        Me.TlsCargarImagen.Text = "Relacionar Imagen"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 32)
        '
        'TlsPasarQA
        '
        Me.TlsPasarQA.Image = CType(resources.GetObject("TlsPasarQA.Image"), System.Drawing.Image)
        Me.TlsPasarQA.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TlsPasarQA.Name = "TlsPasarQA"
        Me.TlsPasarQA.Size = New System.Drawing.Size(104, 29)
        Me.TlsPasarQA.Text = "Enviar a QA"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 32)
        '
        'DgwPaginas
        '
        Me.DgwPaginas.AllowUserToAddRows = False
        Me.DgwPaginas.AllowUserToDeleteRows = False
        Me.DgwPaginas.AllowUserToResizeColumns = False
        Me.DgwPaginas.AllowUserToResizeRows = False
        Me.DgwPaginas.BackgroundColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.DgwPaginas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgwPaginas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgwPaginas.GridColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.DgwPaginas.Location = New System.Drawing.Point(7, 51)
        Me.DgwPaginas.MultiSelect = False
        Me.DgwPaginas.Name = "DgwPaginas"
        Me.DgwPaginas.ReadOnly = True
        Me.DgwPaginas.RowHeadersVisible = False
        Me.DgwPaginas.RowHeadersWidth = 50
        Me.DgwPaginas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgwPaginas.Size = New System.Drawing.Size(857, 186)
        Me.DgwPaginas.TabIndex = 0
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipTitle = "HOLA"
        '
        'Frm_Edicion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ClientSize = New System.Drawing.Size(894, 620)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TabControl2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Frm_Edicion"
        Me.Text = "Detalle de ediciones"
        Me.TpgDatos.ResumeLayout(False)
        Me.TpgDatos.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        Me.TabControl2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DgwPaginas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TpgDatos As System.Windows.Forms.TabPage
    Friend WithEvents TxtEPagFaltantes As System.Windows.Forms.TextBox
    Friend WithEvents TxtEDirector As System.Windows.Forms.TextBox
    Friend WithEvents TxtENumPagEdicion As System.Windows.Forms.TextBox
    Friend WithEvents TxtENumEdicion As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents CkxEDeteriorado As System.Windows.Forms.CheckBox
    Friend WithEvents CkxEGrueso As System.Windows.Forms.CheckBox
    Friend WithEvents CkxEDelgado As System.Windows.Forms.CheckBox
    Friend WithEvents CkxEBueno As System.Windows.Forms.CheckBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents LblNumeroPaginas As System.Windows.Forms.Label
    Friend WithEvents LblNumero As System.Windows.Forms.Label
    Friend WithEvents DtpEFechaEdicion As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblFecha As System.Windows.Forms.Label
    Friend WithEvents ToolStrip3 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TlsGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DgwPaginas As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents TlsAgregarPagina As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TlsEliminarPagina As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CbxTipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DtpF As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtpI As System.Windows.Forms.DateTimePicker
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TlsModificarPagina As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents LblCodIden As System.Windows.Forms.Label
    Friend WithEvents TxtCodEdi As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents TlsCargarImagen As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TlsPasarQA As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tbSubtitulo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbTitulo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
