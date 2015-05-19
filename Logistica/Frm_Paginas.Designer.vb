<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Paginas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Paginas))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TgpPagina = New System.Windows.Forms.TabPage
        Me.TxtNumTomo = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.TxtCodPag = New System.Windows.Forms.TextBox
        Me.LblCodIdenEmDe = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.TxtObservaciones = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CkxDificultad = New System.Windows.Forms.CheckBox
        Me.CkxFalta = New System.Windows.Forms.CheckBox
        Me.CkxManchada = New System.Windows.Forms.CheckBox
        Me.CkxRota = New System.Windows.Forms.CheckBox
        Me.CkxIncompleta = New System.Windows.Forms.CheckBox
        Me.CkxCompleta = New System.Windows.Forms.CheckBox
        Me.TxtNumPagina = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.TlsGuardar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.TabControl1.SuspendLayout()
        Me.TgpPagina.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TgpPagina)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(7, 6)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(592, 267)
        Me.TabControl1.TabIndex = 0
        '
        'TgpPagina
        '
        Me.TgpPagina.Controls.Add(Me.TxtNumTomo)
        Me.TgpPagina.Controls.Add(Me.Label2)
        Me.TgpPagina.Controls.Add(Me.GroupBox2)
        Me.TgpPagina.Controls.Add(Me.Label16)
        Me.TgpPagina.Controls.Add(Me.TxtObservaciones)
        Me.TgpPagina.Controls.Add(Me.Label3)
        Me.TgpPagina.Controls.Add(Me.GroupBox1)
        Me.TgpPagina.Controls.Add(Me.TxtNumPagina)
        Me.TgpPagina.Controls.Add(Me.Label1)
        Me.TgpPagina.Controls.Add(Me.ToolStrip1)
        Me.TgpPagina.Location = New System.Drawing.Point(4, 25)
        Me.TgpPagina.Name = "TgpPagina"
        Me.TgpPagina.Padding = New System.Windows.Forms.Padding(3)
        Me.TgpPagina.Size = New System.Drawing.Size(584, 238)
        Me.TgpPagina.TabIndex = 0
        Me.TgpPagina.Text = "Página"
        Me.TgpPagina.UseVisualStyleBackColor = True
        '
        'TxtNumTomo
        '
        Me.TxtNumTomo.Location = New System.Drawing.Point(164, 121)
        Me.TxtNumTomo.MaxLength = 6
        Me.TxtNumTomo.Name = "TxtNumTomo"
        Me.TxtNumTomo.Size = New System.Drawing.Size(50, 22)
        Me.TxtNumTomo.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 16)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Número de tomo"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtCodPag)
        Me.GroupBox2.Controls.Add(Me.LblCodIdenEmDe)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 40)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(237, 46)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Código de Identificación *"
        '
        'TxtCodPag
        '
        Me.TxtCodPag.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodPag.Location = New System.Drawing.Point(156, 16)
        Me.TxtCodPag.MaxLength = 3
        Me.TxtCodPag.Name = "TxtCodPag"
        Me.TxtCodPag.Size = New System.Drawing.Size(50, 24)
        Me.TxtCodPag.TabIndex = 2
        '
        'LblCodIdenEmDe
        '
        Me.LblCodIdenEmDe.AutoSize = True
        Me.LblCodIdenEmDe.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCodIdenEmDe.Location = New System.Drawing.Point(6, 19)
        Me.LblCodIdenEmDe.Name = "LblCodIdenEmDe"
        Me.LblCodIdenEmDe.Size = New System.Drawing.Size(82, 18)
        Me.LblCodIdenEmDe.TabIndex = 0
        Me.LblCodIdenEmDe.Text = "LblCodIden"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(300, 146)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(232, 15)
        Me.Label16.TabIndex = 25
        Me.Label16.Text = "NOTA : ( * ) Campo obligatorio a ingresar."
        '
        'TxtObservaciones
        '
        Me.TxtObservaciones.Location = New System.Drawing.Point(9, 165)
        Me.TxtObservaciones.MaxLength = 2000
        Me.TxtObservaciones.Multiline = True
        Me.TxtObservaciones.Name = "TxtObservaciones"
        Me.TxtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtObservaciones.Size = New System.Drawing.Size(569, 61)
        Me.TxtObservaciones.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Observaciones"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CkxDificultad)
        Me.GroupBox1.Controls.Add(Me.CkxFalta)
        Me.GroupBox1.Controls.Add(Me.CkxManchada)
        Me.GroupBox1.Controls.Add(Me.CkxRota)
        Me.GroupBox1.Controls.Add(Me.CkxIncompleta)
        Me.GroupBox1.Controls.Add(Me.CkxCompleta)
        Me.GroupBox1.Location = New System.Drawing.Point(295, 62)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(283, 65)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Estado *"
        '
        'CkxDificultad
        '
        Me.CkxDificultad.AutoSize = True
        Me.CkxDificultad.Location = New System.Drawing.Point(204, 39)
        Me.CkxDificultad.Name = "CkxDificultad"
        Me.CkxDificultad.Size = New System.Drawing.Size(82, 20)
        Me.CkxDificultad.TabIndex = 11
        Me.CkxDificultad.Text = "Dificultad"
        Me.CkxDificultad.UseVisualStyleBackColor = True
        '
        'CkxFalta
        '
        Me.CkxFalta.AutoSize = True
        Me.CkxFalta.Location = New System.Drawing.Point(204, 16)
        Me.CkxFalta.Name = "CkxFalta"
        Me.CkxFalta.Size = New System.Drawing.Size(57, 20)
        Me.CkxFalta.TabIndex = 10
        Me.CkxFalta.Text = "Falta"
        Me.CkxFalta.UseVisualStyleBackColor = True
        '
        'CkxManchada
        '
        Me.CkxManchada.AutoSize = True
        Me.CkxManchada.Location = New System.Drawing.Point(108, 39)
        Me.CkxManchada.Name = "CkxManchada"
        Me.CkxManchada.Size = New System.Drawing.Size(91, 20)
        Me.CkxManchada.TabIndex = 9
        Me.CkxManchada.Text = "Manchada"
        Me.CkxManchada.UseVisualStyleBackColor = True
        '
        'CkxRota
        '
        Me.CkxRota.AutoSize = True
        Me.CkxRota.Location = New System.Drawing.Point(108, 16)
        Me.CkxRota.Name = "CkxRota"
        Me.CkxRota.Size = New System.Drawing.Size(56, 20)
        Me.CkxRota.TabIndex = 8
        Me.CkxRota.Text = "Rota"
        Me.CkxRota.UseVisualStyleBackColor = True
        '
        'CkxIncompleta
        '
        Me.CkxIncompleta.AutoSize = True
        Me.CkxIncompleta.Location = New System.Drawing.Point(8, 39)
        Me.CkxIncompleta.Name = "CkxIncompleta"
        Me.CkxIncompleta.Size = New System.Drawing.Size(93, 20)
        Me.CkxIncompleta.TabIndex = 7
        Me.CkxIncompleta.Text = "Incompleta"
        Me.CkxIncompleta.UseVisualStyleBackColor = True
        '
        'CkxCompleta
        '
        Me.CkxCompleta.AutoSize = True
        Me.CkxCompleta.Location = New System.Drawing.Point(8, 16)
        Me.CkxCompleta.Name = "CkxCompleta"
        Me.CkxCompleta.Size = New System.Drawing.Size(85, 20)
        Me.CkxCompleta.TabIndex = 6
        Me.CkxCompleta.Text = "Completa"
        Me.CkxCompleta.UseVisualStyleBackColor = True
        '
        'TxtNumPagina
        '
        Me.TxtNumPagina.Location = New System.Drawing.Point(164, 91)
        Me.TxtNumPagina.MaxLength = 6
        Me.TxtNumPagina.Name = "TxtNumPagina"
        Me.TxtNumPagina.Size = New System.Drawing.Size(50, 22)
        Me.TxtNumPagina.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Número de página"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.TlsGuardar, Me.ToolStripSeparator2})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(578, 32)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 32)
        '
        'TlsGuardar
        '
        Me.TlsGuardar.Image = CType(resources.GetObject("TlsGuardar.Image"), System.Drawing.Image)
        Me.TlsGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TlsGuardar.Name = "TlsGuardar"
        Me.TlsGuardar.Size = New System.Drawing.Size(83, 29)
        Me.TlsGuardar.Text = "Guardar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 32)
        '
        'Frm_Paginas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ClientSize = New System.Drawing.Size(605, 277)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Frm_Paginas"
        Me.Text = "Páginas"
        Me.TabControl1.ResumeLayout(False)
        Me.TgpPagina.ResumeLayout(False)
        Me.TgpPagina.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TgpPagina As System.Windows.Forms.TabPage
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TlsGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtNumPagina As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CkxDificultad As System.Windows.Forms.CheckBox
    Friend WithEvents CkxFalta As System.Windows.Forms.CheckBox
    Friend WithEvents CkxManchada As System.Windows.Forms.CheckBox
    Friend WithEvents CkxRota As System.Windows.Forms.CheckBox
    Friend WithEvents CkxIncompleta As System.Windows.Forms.CheckBox
    Friend WithEvents CkxCompleta As System.Windows.Forms.CheckBox
    Friend WithEvents TxtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents LblCodIdenEmDe As System.Windows.Forms.Label
    Friend WithEvents TxtCodPag As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtNumTomo As System.Windows.Forms.TextBox
End Class
