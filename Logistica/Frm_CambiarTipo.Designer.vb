<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CAMBIAR
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CAMBIAR))
        Me.cboCambioTipo = New System.Windows.Forms.ComboBox
        Me.TITIPOEMPASTEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DirectorioDataSet = New Logistica.DirectorioDataSet
        Me.grp_Cambios = New System.Windows.Forms.GroupBox
        Me.cbo_TipoEdicionAnterior = New System.Windows.Forms.ComboBox
        Me.lbl_TipoEdicionAnterior = New System.Windows.Forms.Label
        Me.lbl_NuevoTipoEdicion = New System.Windows.Forms.Label
        Me.lbl_EdicionAnterior = New System.Windows.Forms.Label
        Me.Etlbl_EdicionAnterior = New System.Windows.Forms.Label
        Me.lbl_NuevaEdicion = New System.Windows.Forms.Label
        Me.txt_NuevaEdicion = New System.Windows.Forms.TextBox
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.txtCambiarTipo = New System.Windows.Forms.TextBox
        Me.txtCodempaste = New System.Windows.Forms.TextBox
        Me.txttipo = New System.Windows.Forms.TextBox
        Me.TI_TIPO_EMPASTETableAdapter = New Logistica.DirectorioDataSetTableAdapters.TI_TIPO_EMPASTETableAdapter
        CType(Me.TITIPOEMPASTEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DirectorioDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_Cambios.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboCambioTipo
        '
        Me.cboCambioTipo.DataSource = Me.TITIPOEMPASTEBindingSource
        Me.cboCambioTipo.DisplayMember = "vchDescripcion"
        Me.cboCambioTipo.FormattingEnabled = True
        Me.cboCambioTipo.Location = New System.Drawing.Point(178, 51)
        Me.cboCambioTipo.Name = "cboCambioTipo"
        Me.cboCambioTipo.Size = New System.Drawing.Size(218, 21)
        Me.cboCambioTipo.TabIndex = 0
        Me.cboCambioTipo.ValueMember = "numTipo"
        '
        'TITIPOEMPASTEBindingSource
        '
        Me.TITIPOEMPASTEBindingSource.DataMember = "TI_TIPO_EMPASTE"
        Me.TITIPOEMPASTEBindingSource.DataSource = Me.DirectorioDataSet
        '
        'DirectorioDataSet
        '
        Me.DirectorioDataSet.DataSetName = "DirectorioDataSet"
        Me.DirectorioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'grp_Cambios
        '
        Me.grp_Cambios.Controls.Add(Me.cbo_TipoEdicionAnterior)
        Me.grp_Cambios.Controls.Add(Me.lbl_TipoEdicionAnterior)
        Me.grp_Cambios.Controls.Add(Me.lbl_NuevoTipoEdicion)
        Me.grp_Cambios.Controls.Add(Me.lbl_EdicionAnterior)
        Me.grp_Cambios.Controls.Add(Me.Etlbl_EdicionAnterior)
        Me.grp_Cambios.Controls.Add(Me.lbl_NuevaEdicion)
        Me.grp_Cambios.Controls.Add(Me.txt_NuevaEdicion)
        Me.grp_Cambios.Controls.Add(Me.btnAceptar)
        Me.grp_Cambios.Controls.Add(Me.cboCambioTipo)
        Me.grp_Cambios.Location = New System.Drawing.Point(23, 21)
        Me.grp_Cambios.Name = "grp_Cambios"
        Me.grp_Cambios.Size = New System.Drawing.Size(402, 162)
        Me.grp_Cambios.TabIndex = 1
        Me.grp_Cambios.TabStop = False
        Me.grp_Cambios.Text = "Cambios"
        '
        'cbo_TipoEdicionAnterior
        '
        Me.cbo_TipoEdicionAnterior.DataSource = Me.TITIPOEMPASTEBindingSource
        Me.cbo_TipoEdicionAnterior.DisplayMember = "vchDescripcion"
        Me.cbo_TipoEdicionAnterior.Enabled = False
        Me.cbo_TipoEdicionAnterior.FormattingEnabled = True
        Me.cbo_TipoEdicionAnterior.Location = New System.Drawing.Point(178, 24)
        Me.cbo_TipoEdicionAnterior.Name = "cbo_TipoEdicionAnterior"
        Me.cbo_TipoEdicionAnterior.Size = New System.Drawing.Size(218, 21)
        Me.cbo_TipoEdicionAnterior.TabIndex = 8
        Me.cbo_TipoEdicionAnterior.ValueMember = "numTipo"
        '
        'lbl_TipoEdicionAnterior
        '
        Me.lbl_TipoEdicionAnterior.AutoSize = True
        Me.lbl_TipoEdicionAnterior.Location = New System.Drawing.Point(16, 28)
        Me.lbl_TipoEdicionAnterior.Name = "lbl_TipoEdicionAnterior"
        Me.lbl_TipoEdicionAnterior.Size = New System.Drawing.Size(105, 13)
        Me.lbl_TipoEdicionAnterior.TabIndex = 7
        Me.lbl_TipoEdicionAnterior.Text = "Tipo Edición Anterior"
        '
        'lbl_NuevoTipoEdicion
        '
        Me.lbl_NuevoTipoEdicion.AutoSize = True
        Me.lbl_NuevoTipoEdicion.Location = New System.Drawing.Point(16, 51)
        Me.lbl_NuevoTipoEdicion.Name = "lbl_NuevoTipoEdicion"
        Me.lbl_NuevoTipoEdicion.Size = New System.Drawing.Size(101, 13)
        Me.lbl_NuevoTipoEdicion.TabIndex = 6
        Me.lbl_NuevoTipoEdicion.Text = "Nuevo Tipo Edición"
        '
        'lbl_EdicionAnterior
        '
        Me.lbl_EdicionAnterior.AutoSize = True
        Me.lbl_EdicionAnterior.Location = New System.Drawing.Point(178, 75)
        Me.lbl_EdicionAnterior.Name = "lbl_EdicionAnterior"
        Me.lbl_EdicionAnterior.Size = New System.Drawing.Size(0, 13)
        Me.lbl_EdicionAnterior.TabIndex = 5
        '
        'Etlbl_EdicionAnterior
        '
        Me.Etlbl_EdicionAnterior.AutoSize = True
        Me.Etlbl_EdicionAnterior.Location = New System.Drawing.Point(16, 72)
        Me.Etlbl_EdicionAnterior.Name = "Etlbl_EdicionAnterior"
        Me.Etlbl_EdicionAnterior.Size = New System.Drawing.Size(81, 13)
        Me.Etlbl_EdicionAnterior.TabIndex = 4
        Me.Etlbl_EdicionAnterior.Text = "Edición Anterior"
        '
        'lbl_NuevaEdicion
        '
        Me.lbl_NuevaEdicion.AutoSize = True
        Me.lbl_NuevaEdicion.Location = New System.Drawing.Point(16, 96)
        Me.lbl_NuevaEdicion.Name = "lbl_NuevaEdicion"
        Me.lbl_NuevaEdicion.Size = New System.Drawing.Size(77, 13)
        Me.lbl_NuevaEdicion.TabIndex = 3
        Me.lbl_NuevaEdicion.Text = "Nueva Edición"
        '
        'txt_NuevaEdicion
        '
        Me.txt_NuevaEdicion.Location = New System.Drawing.Point(178, 94)
        Me.txt_NuevaEdicion.Name = "txt_NuevaEdicion"
        Me.txt_NuevaEdicion.Size = New System.Drawing.Size(100, 20)
        Me.txt_NuevaEdicion.TabIndex = 2
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(140, 122)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(89, 32)
        Me.btnAceptar.TabIndex = 1
        Me.btnAceptar.Text = "Procesar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'txtCambiarTipo
        '
        Me.txtCambiarTipo.Location = New System.Drawing.Point(94, 0)
        Me.txtCambiarTipo.Name = "txtCambiarTipo"
        Me.txtCambiarTipo.Size = New System.Drawing.Size(100, 20)
        Me.txtCambiarTipo.TabIndex = 2
        Me.txtCambiarTipo.Visible = False
        '
        'txtCodempaste
        '
        Me.txtCodempaste.Location = New System.Drawing.Point(23, 0)
        Me.txtCodempaste.Name = "txtCodempaste"
        Me.txtCodempaste.Size = New System.Drawing.Size(65, 20)
        Me.txtCodempaste.TabIndex = 3
        Me.txtCodempaste.Visible = False
        '
        'txttipo
        '
        Me.txttipo.Location = New System.Drawing.Point(201, 0)
        Me.txttipo.Name = "txttipo"
        Me.txttipo.Size = New System.Drawing.Size(47, 20)
        Me.txttipo.TabIndex = 4
        Me.txttipo.Visible = False
        '
        'TI_TIPO_EMPASTETableAdapter
        '
        Me.TI_TIPO_EMPASTETableAdapter.ClearBeforeFill = True
        '
        'CAMBIAR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 195)
        Me.Controls.Add(Me.txttipo)
        Me.Controls.Add(Me.txtCodempaste)
        Me.Controls.Add(Me.txtCambiarTipo)
        Me.Controls.Add(Me.grp_Cambios)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CAMBIAR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CAMBIAR TIPO DE EDICION"
        CType(Me.TITIPOEMPASTEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DirectorioDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_Cambios.ResumeLayout(False)
        Me.grp_Cambios.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboCambioTipo As System.Windows.Forms.ComboBox
    Friend WithEvents grp_Cambios As System.Windows.Forms.GroupBox
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents txtCambiarTipo As System.Windows.Forms.TextBox
    Friend WithEvents txtCodempaste As System.Windows.Forms.TextBox
    Friend WithEvents txttipo As System.Windows.Forms.TextBox
    Friend WithEvents DirectorioDataSet As Logistica.DirectorioDataSet
    Friend WithEvents TITIPOEMPASTEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TI_TIPO_EMPASTETableAdapter As Logistica.DirectorioDataSetTableAdapters.TI_TIPO_EMPASTETableAdapter
    Friend WithEvents Etlbl_EdicionAnterior As System.Windows.Forms.Label
    Friend WithEvents lbl_NuevaEdicion As System.Windows.Forms.Label
    Friend WithEvents txt_NuevaEdicion As System.Windows.Forms.TextBox
    Friend WithEvents lbl_EdicionAnterior As System.Windows.Forms.Label
    Friend WithEvents lbl_NuevoTipoEdicion As System.Windows.Forms.Label
    Friend WithEvents cbo_TipoEdicionAnterior As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_TipoEdicionAnterior As System.Windows.Forms.Label
End Class
