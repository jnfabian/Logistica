<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_CrearReportePagina
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_CrearReportePagina))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CbxUsuario = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.TxtObservacion = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtCodIdentificacion = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.DgvReportePagina = New System.Windows.Forms.DataGridView
        Me.BtnSalir = New System.Windows.Forms.Button
        Me.BtnVistaPreliminar = New System.Windows.Forms.Button
        Me.CbxTipo = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DgvReportePagina, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.CbxTipo)
        Me.GroupBox1.Controls.Add(Me.CbxUsuario)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.TxtObservacion)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxtCodIdentificacion)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(435, 192)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'CbxUsuario
        '
        Me.CbxUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxUsuario.FormattingEnabled = True
        Me.CbxUsuario.Location = New System.Drawing.Point(176, 77)
        Me.CbxUsuario.Name = "CbxUsuario"
        Me.CbxUsuario.Size = New System.Drawing.Size(157, 24)
        Me.CbxUsuario.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 16)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Usuario"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(6, 164)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(244, 15)
        Me.Label16.TabIndex = 25
        Me.Label16.Text = "NOTA : ( * ) Campos obligatorios a ingresar."
        '
        'TxtObservacion
        '
        Me.TxtObservacion.Location = New System.Drawing.Point(176, 110)
        Me.TxtObservacion.Multiline = True
        Me.TxtObservacion.Name = "TxtObservacion"
        Me.TxtObservacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtObservacion.Size = New System.Drawing.Size(250, 51)
        Me.TxtObservacion.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Observación"
        '
        'TxtCodIdentificacion
        '
        Me.TxtCodIdentificacion.Location = New System.Drawing.Point(176, 15)
        Me.TxtCodIdentificacion.MaxLength = 19
        Me.TxtCodIdentificacion.Name = "TxtCodIdentificacion"
        Me.TxtCodIdentificacion.Size = New System.Drawing.Size(250, 22)
        Me.TxtCodIdentificacion.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código de Identificación *"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DgvReportePagina)
        Me.GroupBox2.Controls.Add(Me.BtnSalir)
        Me.GroupBox2.Controls.Add(Me.BtnVistaPreliminar)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 201)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(435, 48)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'DgvReportePagina
        '
        Me.DgvReportePagina.AllowUserToAddRows = False
        Me.DgvReportePagina.AllowUserToDeleteRows = False
        Me.DgvReportePagina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvReportePagina.Location = New System.Drawing.Point(148, 13)
        Me.DgvReportePagina.MultiSelect = False
        Me.DgvReportePagina.Name = "DgvReportePagina"
        Me.DgvReportePagina.ReadOnly = True
        Me.DgvReportePagina.RowHeadersVisible = False
        Me.DgvReportePagina.Size = New System.Drawing.Size(141, 29)
        Me.DgvReportePagina.TabIndex = 2
        Me.DgvReportePagina.Visible = False
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(339, 15)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(75, 23)
        Me.BtnSalir.TabIndex = 1
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnVistaPreliminar
        '
        Me.BtnVistaPreliminar.Location = New System.Drawing.Point(9, 15)
        Me.BtnVistaPreliminar.Name = "BtnVistaPreliminar"
        Me.BtnVistaPreliminar.Size = New System.Drawing.Size(117, 23)
        Me.BtnVistaPreliminar.TabIndex = 0
        Me.BtnVistaPreliminar.Text = "Vista preliminar"
        Me.BtnVistaPreliminar.UseVisualStyleBackColor = True
        '
        'CbxTipo
        '
        Me.CbxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxTipo.FormattingEnabled = True
        Me.CbxTipo.Location = New System.Drawing.Point(176, 45)
        Me.CbxTipo.Name = "CbxTipo"
        Me.CbxTipo.Size = New System.Drawing.Size(157, 24)
        Me.CbxTipo.TabIndex = 28
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 48)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 16)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Tipo"
        '
        'Frm_CrearReportePagina
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ClientSize = New System.Drawing.Size(459, 257)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Frm_CrearReportePagina"
        Me.Text = "Generar reporte de páginas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DgvReportePagina, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtCodIdentificacion As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents BtnVistaPreliminar As System.Windows.Forms.Button
    Friend WithEvents DgvReportePagina As System.Windows.Forms.DataGridView
    Friend WithEvents TxtObservacion As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CbxUsuario As System.Windows.Forms.ComboBox
    Friend WithEvents CbxTipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
