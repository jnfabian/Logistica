<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_InventarioEdiciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_InventarioEdiciones))
        Me.Label1 = New System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TpgEmpasteIngreso = New System.Windows.Forms.TabPage
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TxtObservaciones = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.CbxVisto = New System.Windows.Forms.ComboBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.TxtNivel = New System.Windows.Forms.TextBox
        Me.TxtAnaquel = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.TxtEdicionesFaltantes = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.TxtNumPaginas = New System.Windows.Forms.TextBox
        Me.TxtCodIdentificacion = New System.Windows.Forms.TextBox
        Me.TxtNumEdiciones = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.CkxDeteriorado = New System.Windows.Forms.CheckBox
        Me.CkxRegular = New System.Windows.Forms.CheckBox
        Me.CkxBueno = New System.Windows.Forms.CheckBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.TxtAltura = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.TxtAncho = New System.Windows.Forms.TextBox
        Me.TxtLargo = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.DtpFecIni = New System.Windows.Forms.DateTimePicker
        Me.DtpTermino = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.TpgBusqueda = New System.Windows.Forms.TabPage
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.TxtCodIdentificacionBusqueda = New System.Windows.Forms.TextBox
        Me.BtnBuscar = New System.Windows.Forms.Button
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.TlsAgregar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.TlsModificar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.DgwEmpaste = New System.Windows.Forms.DataGridView
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.TlsEliminar2 = New System.Windows.Forms.ToolStripButton
        Me.TlsNuevo = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.TlsGuardar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.TabControl1.SuspendLayout()
        Me.TpgEmpasteIngreso.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TpgBusqueda.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.DgwEmpaste, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(157, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(420, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "INVENTARIO DE EDICIONES DEL DIARIO OFICIAL EL PERUANO"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TpgEmpasteIngreso)
        Me.TabControl1.Controls.Add(Me.TpgBusqueda)
        Me.TabControl1.Location = New System.Drawing.Point(12, 29)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(709, 302)
        Me.TabControl1.TabIndex = 4
        '
        'TpgEmpasteIngreso
        '
        Me.TpgEmpasteIngreso.Controls.Add(Me.GroupBox1)
        Me.TpgEmpasteIngreso.Location = New System.Drawing.Point(4, 22)
        Me.TpgEmpasteIngreso.Name = "TpgEmpasteIngreso"
        Me.TpgEmpasteIngreso.Padding = New System.Windows.Forms.Padding(3)
        Me.TpgEmpasteIngreso.Size = New System.Drawing.Size(701, 276)
        Me.TpgEmpasteIngreso.TabIndex = 0
        Me.TpgEmpasteIngreso.Text = "Empaste"
        Me.TpgEmpasteIngreso.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ToolStrip1)
        Me.GroupBox1.Controls.Add(Me.TxtObservaciones)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.TxtEdicionesFaltantes)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.TxtNumPaginas)
        Me.GroupBox1.Controls.Add(Me.TxtCodIdentificacion)
        Me.GroupBox1.Controls.Add(Me.TxtNumEdiciones)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(686, 262)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Empaste"
        '
        'TxtObservaciones
        '
        Me.TxtObservaciones.Location = New System.Drawing.Point(6, 213)
        Me.TxtObservaciones.Multiline = True
        Me.TxtObservaciones.Name = "TxtObservaciones"
        Me.TxtObservaciones.Size = New System.Drawing.Size(670, 45)
        Me.TxtObservaciones.TabIndex = 17
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(14, 197)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(78, 13)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "Observaciones"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.CbxVisto)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Controls.Add(Me.TxtNivel)
        Me.GroupBox5.Controls.Add(Me.TxtAnaquel)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Location = New System.Drawing.Point(328, 121)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(348, 73)
        Me.GroupBox5.TabIndex = 15
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Ubicacion Fisica"
        '
        'CbxVisto
        '
        Me.CbxVisto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxVisto.FormattingEnabled = True
        Me.CbxVisto.Items.AddRange(New Object() {"Seleccione..", "Concluido", "No Concluido"})
        Me.CbxVisto.Location = New System.Drawing.Point(172, 16)
        Me.CbxVisto.Name = "CbxVisto"
        Me.CbxVisto.Size = New System.Drawing.Size(97, 21)
        Me.CbxVisto.TabIndex = 4
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(136, 19)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(30, 13)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Visto"
        '
        'TxtNivel
        '
        Me.TxtNivel.Location = New System.Drawing.Point(75, 19)
        Me.TxtNivel.Name = "TxtNivel"
        Me.TxtNivel.Size = New System.Drawing.Size(50, 20)
        Me.TxtNivel.TabIndex = 2
        '
        'TxtAnaquel
        '
        Me.TxtAnaquel.Location = New System.Drawing.Point(75, 45)
        Me.TxtAnaquel.Name = "TxtAnaquel"
        Me.TxtAnaquel.Size = New System.Drawing.Size(50, 20)
        Me.TxtAnaquel.TabIndex = 2
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(11, 22)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(31, 13)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Nivel"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(11, 48)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Anaquel"
        '
        'TxtEdicionesFaltantes
        '
        Me.TxtEdicionesFaltantes.Location = New System.Drawing.Point(576, 91)
        Me.TxtEdicionesFaltantes.Name = "TxtEdicionesFaltantes"
        Me.TxtEdicionesFaltantes.Size = New System.Drawing.Size(100, 20)
        Me.TxtEdicionesFaltantes.TabIndex = 14
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(464, 98)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(99, 13)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Ediciones Faltantes"
        '
        'TxtNumPaginas
        '
        Me.TxtNumPaginas.Location = New System.Drawing.Point(404, 95)
        Me.TxtNumPaginas.Name = "TxtNumPaginas"
        Me.TxtNumPaginas.Size = New System.Drawing.Size(50, 20)
        Me.TxtNumPaginas.TabIndex = 12
        '
        'TxtCodIdentificacion
        '
        Me.TxtCodIdentificacion.Location = New System.Drawing.Point(576, 59)
        Me.TxtCodIdentificacion.Name = "TxtCodIdentificacion"
        Me.TxtCodIdentificacion.Size = New System.Drawing.Size(100, 20)
        Me.TxtCodIdentificacion.TabIndex = 11
        '
        'TxtNumEdiciones
        '
        Me.TxtNumEdiciones.Location = New System.Drawing.Point(404, 59)
        Me.TxtNumEdiciones.Name = "TxtNumEdiciones"
        Me.TxtNumEdiciones.Size = New System.Drawing.Size(50, 20)
        Me.TxtNumEdiciones.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(464, 61)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(106, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Codigo Identificacion"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(325, 95)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "N° Paginas"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(325, 61)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "N° Ediciones"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.CkxDeteriorado)
        Me.GroupBox4.Controls.Add(Me.CkxRegular)
        Me.GroupBox4.Controls.Add(Me.CkxBueno)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 149)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(313, 45)
        Me.GroupBox4.TabIndex = 6
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Estado de Empaste (Soporte)"
        '
        'CkxDeteriorado
        '
        Me.CkxDeteriorado.AutoSize = True
        Me.CkxDeteriorado.Location = New System.Drawing.Point(219, 19)
        Me.CkxDeteriorado.Name = "CkxDeteriorado"
        Me.CkxDeteriorado.Size = New System.Drawing.Size(81, 17)
        Me.CkxDeteriorado.TabIndex = 2
        Me.CkxDeteriorado.Text = "Deteriorado"
        Me.CkxDeteriorado.UseVisualStyleBackColor = True
        '
        'CkxRegular
        '
        Me.CkxRegular.AutoSize = True
        Me.CkxRegular.Location = New System.Drawing.Point(110, 19)
        Me.CkxRegular.Name = "CkxRegular"
        Me.CkxRegular.Size = New System.Drawing.Size(63, 17)
        Me.CkxRegular.TabIndex = 1
        Me.CkxRegular.Text = "Regular"
        Me.CkxRegular.UseVisualStyleBackColor = True
        '
        'CkxBueno
        '
        Me.CkxBueno.AutoSize = True
        Me.CkxBueno.Location = New System.Drawing.Point(11, 19)
        Me.CkxBueno.Name = "CkxBueno"
        Me.CkxBueno.Size = New System.Drawing.Size(57, 17)
        Me.CkxBueno.TabIndex = 0
        Me.CkxBueno.Text = "Bueno"
        Me.CkxBueno.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TxtAltura)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.TxtAncho)
        Me.GroupBox3.Controls.Add(Me.TxtLargo)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 91)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(313, 57)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Dimenciones del tomo (centimetros)"
        '
        'TxtAltura
        '
        Me.TxtAltura.Location = New System.Drawing.Point(250, 22)
        Me.TxtAltura.Name = "TxtAltura"
        Me.TxtAltura.Size = New System.Drawing.Size(50, 20)
        Me.TxtAltura.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(210, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Altura"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(107, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Ancho"
        '
        'TxtAncho
        '
        Me.TxtAncho.Location = New System.Drawing.Point(149, 22)
        Me.TxtAncho.Name = "TxtAncho"
        Me.TxtAncho.Size = New System.Drawing.Size(50, 20)
        Me.TxtAncho.TabIndex = 2
        '
        'TxtLargo
        '
        Me.TxtLargo.Location = New System.Drawing.Point(45, 22)
        Me.TxtLargo.Name = "TxtLargo"
        Me.TxtLargo.Size = New System.Drawing.Size(50, 20)
        Me.TxtLargo.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Largo"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DtpFecIni)
        Me.GroupBox2.Controls.Add(Me.DtpTermino)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 44)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(313, 41)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Fecha"
        '
        'DtpFecIni
        '
        Me.DtpFecIni.CalendarTitleBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.DtpFecIni.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpFecIni.Location = New System.Drawing.Point(32, 15)
        Me.DtpFecIni.Name = "DtpFecIni"
        Me.DtpFecIni.Size = New System.Drawing.Size(96, 20)
        Me.DtpFecIni.TabIndex = 1
        '
        'DtpTermino
        '
        Me.DtpTermino.CalendarTitleBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.DtpTermino.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpTermino.Location = New System.Drawing.Point(205, 15)
        Me.DtpTermino.Name = "DtpTermino"
        Me.DtpTermino.Size = New System.Drawing.Size(95, 20)
        Me.DtpTermino.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Del"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(162, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(15, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "al"
        '
        'TpgBusqueda
        '
        Me.TpgBusqueda.Controls.Add(Me.GroupBox6)
        Me.TpgBusqueda.Location = New System.Drawing.Point(4, 22)
        Me.TpgBusqueda.Name = "TpgBusqueda"
        Me.TpgBusqueda.Padding = New System.Windows.Forms.Padding(3)
        Me.TpgBusqueda.Size = New System.Drawing.Size(701, 276)
        Me.TpgBusqueda.TabIndex = 1
        Me.TpgBusqueda.Text = "Busqueda"
        Me.TpgBusqueda.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.ToolStrip2)
        Me.GroupBox6.Controls.Add(Me.GroupBox8)
        Me.GroupBox6.Controls.Add(Me.GroupBox7)
        Me.GroupBox6.Location = New System.Drawing.Point(6, 1)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(689, 269)
        Me.GroupBox6.TabIndex = 0
        Me.GroupBox6.TabStop = False
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.BtnBuscar)
        Me.GroupBox7.Controls.Add(Me.TxtCodIdentificacionBusqueda)
        Me.GroupBox7.Controls.Add(Me.Label15)
        Me.GroupBox7.Location = New System.Drawing.Point(6, 47)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(677, 38)
        Me.GroupBox7.TabIndex = 0
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Filtro de Busqueda"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(4, 17)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(40, 13)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Codigo"
        '
        'TxtCodIdentificacionBusqueda
        '
        Me.TxtCodIdentificacionBusqueda.Location = New System.Drawing.Point(50, 14)
        Me.TxtCodIdentificacionBusqueda.Name = "TxtCodIdentificacionBusqueda"
        Me.TxtCodIdentificacionBusqueda.Size = New System.Drawing.Size(100, 20)
        Me.TxtCodIdentificacionBusqueda.TabIndex = 1
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(160, 11)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscar.TabIndex = 2
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.DgwEmpaste)
        Me.GroupBox8.Location = New System.Drawing.Point(6, 86)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(677, 177)
        Me.GroupBox8.TabIndex = 1
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Datos Filtrados"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TlsAgregar, Me.ToolStripSeparator4, Me.TlsModificar, Me.ToolStripSeparator5, Me.TlsEliminar2, Me.ToolStripSeparator6})
        Me.ToolStrip2.Location = New System.Drawing.Point(3, 16)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(683, 25)
        Me.ToolStrip2.TabIndex = 2
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'TlsAgregar
        '
        Me.TlsAgregar.Image = CType(resources.GetObject("TlsAgregar.Image"), System.Drawing.Image)
        Me.TlsAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TlsAgregar.Name = "TlsAgregar"
        Me.TlsAgregar.Size = New System.Drawing.Size(66, 22)
        Me.TlsAgregar.Text = "Agregar"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'TlsModificar
        '
        Me.TlsModificar.Image = CType(resources.GetObject("TlsModificar.Image"), System.Drawing.Image)
        Me.TlsModificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TlsModificar.Name = "TlsModificar"
        Me.TlsModificar.Size = New System.Drawing.Size(70, 22)
        Me.TlsModificar.Text = "Modificar"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'DgwEmpaste
        '
        Me.DgwEmpaste.AllowUserToAddRows = False
        Me.DgwEmpaste.AllowUserToDeleteRows = False
        Me.DgwEmpaste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgwEmpaste.Location = New System.Drawing.Point(7, 15)
        Me.DgwEmpaste.MultiSelect = False
        Me.DgwEmpaste.Name = "DgwEmpaste"
        Me.DgwEmpaste.ReadOnly = True
        Me.DgwEmpaste.RowHeadersVisible = False
        Me.DgwEmpaste.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgwEmpaste.Size = New System.Drawing.Size(664, 156)
        Me.DgwEmpaste.TabIndex = 0
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'TlsEliminar2
        '
        Me.TlsEliminar2.Image = CType(resources.GetObject("TlsEliminar2.Image"), System.Drawing.Image)
        Me.TlsEliminar2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TlsEliminar2.Name = "TlsEliminar2"
        Me.TlsEliminar2.Size = New System.Drawing.Size(63, 22)
        Me.TlsEliminar2.Text = "Eliminar"
        '
        'TlsNuevo
        '
        Me.TlsNuevo.Image = CType(resources.GetObject("TlsNuevo.Image"), System.Drawing.Image)
        Me.TlsNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TlsNuevo.Name = "TlsNuevo"
        Me.TlsNuevo.Size = New System.Drawing.Size(58, 22)
        Me.TlsNuevo.Text = "Nuevo"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'TlsGuardar
        '
        Me.TlsGuardar.Image = CType(resources.GetObject("TlsGuardar.Image"), System.Drawing.Image)
        Me.TlsGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TlsGuardar.Name = "TlsGuardar"
        Me.TlsGuardar.Size = New System.Drawing.Size(66, 22)
        Me.TlsGuardar.Text = "Guardar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TlsNuevo, Me.ToolStripSeparator1, Me.TlsGuardar, Me.ToolStripSeparator2})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 16)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(680, 25)
        Me.ToolStrip1.TabIndex = 18
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Frm_InventarioEdiciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(731, 338)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Frm_InventarioEdiciones"
        Me.Text = "INVENTARIO DE EDICIONES"
        Me.TabControl1.ResumeLayout(False)
        Me.TpgEmpasteIngreso.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TpgBusqueda.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.DgwEmpaste, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
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
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents CbxVisto As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
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
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents CkxDeteriorado As System.Windows.Forms.CheckBox
    Friend WithEvents CkxRegular As System.Windows.Forms.CheckBox
    Friend WithEvents CkxBueno As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtAltura As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtAncho As System.Windows.Forms.TextBox
    Friend WithEvents TxtLargo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DtpFecIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtpTermino As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents BtnBuscar As System.Windows.Forms.Button
    Friend WithEvents TxtCodIdentificacionBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents TlsAgregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TlsModificar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents DgwEmpaste As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents TlsNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TlsGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TlsEliminar2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator

End Class
