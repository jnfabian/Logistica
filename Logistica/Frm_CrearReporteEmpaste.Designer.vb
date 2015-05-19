<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_CrearReporteEmpaste
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_CrearReporteEmpaste))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.TxtCodIdentificacion = New System.Windows.Forms.TextBox
        Me.CbxEstado = New System.Windows.Forms.ComboBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.CbxUsuario = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.TxtObservaciones = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.CbxVisto = New System.Windows.Forms.ComboBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.DgvEmpaste = New System.Windows.Forms.DataGridView
        Me.BtnSalir = New System.Windows.Forms.Button
        Me.BtnVistaPreliminar = New System.Windows.Forms.Button
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DgvEmpaste, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código de Identificación"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Estado"
        '
        'TxtCodIdentificacion
        '
        Me.TxtCodIdentificacion.Location = New System.Drawing.Point(166, 15)
        Me.TxtCodIdentificacion.MaxLength = 11
        Me.TxtCodIdentificacion.Name = "TxtCodIdentificacion"
        Me.TxtCodIdentificacion.Size = New System.Drawing.Size(250, 22)
        Me.TxtCodIdentificacion.TabIndex = 5
        '
        'CbxEstado
        '
        Me.CbxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxEstado.FormattingEnabled = True
        Me.CbxEstado.Location = New System.Drawing.Point(166, 43)
        Me.CbxEstado.Name = "CbxEstado"
        Me.CbxEstado.Size = New System.Drawing.Size(142, 24)
        Me.CbxEstado.TabIndex = 8
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CbxUsuario)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TxtObservaciones)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.CbxVisto)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.CbxEstado)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.TxtCodIdentificacion)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(424, 188)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        '
        'CbxUsuario
        '
        Me.CbxUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxUsuario.FormattingEnabled = True
        Me.CbxUsuario.Location = New System.Drawing.Point(166, 103)
        Me.CbxUsuario.Name = "CbxUsuario"
        Me.CbxUsuario.Size = New System.Drawing.Size(142, 24)
        Me.CbxUsuario.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 16)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Usuario"
        '
        'TxtObservaciones
        '
        Me.TxtObservaciones.Location = New System.Drawing.Point(166, 135)
        Me.TxtObservaciones.Multiline = True
        Me.TxtObservaciones.Name = "TxtObservaciones"
        Me.TxtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtObservaciones.Size = New System.Drawing.Size(250, 45)
        Me.TxtObservaciones.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 16)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Observación"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Visto"
        '
        'CbxVisto
        '
        Me.CbxVisto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxVisto.FormattingEnabled = True
        Me.CbxVisto.Location = New System.Drawing.Point(166, 73)
        Me.CbxVisto.Name = "CbxVisto"
        Me.CbxVisto.Size = New System.Drawing.Size(142, 24)
        Me.CbxVisto.TabIndex = 9
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DgvEmpaste)
        Me.GroupBox3.Controls.Add(Me.BtnSalir)
        Me.GroupBox3.Controls.Add(Me.BtnVistaPreliminar)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 193)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(424, 43)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        '
        'DgvEmpaste
        '
        Me.DgvEmpaste.AllowUserToAddRows = False
        Me.DgvEmpaste.AllowUserToDeleteRows = False
        Me.DgvEmpaste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvEmpaste.Location = New System.Drawing.Point(156, 10)
        Me.DgvEmpaste.MultiSelect = False
        Me.DgvEmpaste.Name = "DgvEmpaste"
        Me.DgvEmpaste.ReadOnly = True
        Me.DgvEmpaste.RowHeadersVisible = False
        Me.DgvEmpaste.Size = New System.Drawing.Size(95, 27)
        Me.DgvEmpaste.TabIndex = 11
        Me.DgvEmpaste.Visible = False
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(341, 14)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(75, 23)
        Me.BtnSalir.TabIndex = 12
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnVistaPreliminar
        '
        Me.BtnVistaPreliminar.Location = New System.Drawing.Point(6, 14)
        Me.BtnVistaPreliminar.Name = "BtnVistaPreliminar"
        Me.BtnVistaPreliminar.Size = New System.Drawing.Size(121, 23)
        Me.BtnVistaPreliminar.TabIndex = 11
        Me.BtnVistaPreliminar.Text = "Vista preliminar"
        Me.BtnVistaPreliminar.UseVisualStyleBackColor = True
        '
        'Frm_CrearReporteEmpaste
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ClientSize = New System.Drawing.Size(447, 248)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Frm_CrearReporteEmpaste"
        Me.Text = "Generar reporte empaste"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DgvEmpaste, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtCodIdentificacion As System.Windows.Forms.TextBox
    Friend WithEvents CbxEstado As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents BtnVistaPreliminar As System.Windows.Forms.Button
    Friend WithEvents DgvEmpaste As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CbxVisto As System.Windows.Forms.ComboBox
    Friend WithEvents TxtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CbxUsuario As System.Windows.Forms.ComboBox
End Class
