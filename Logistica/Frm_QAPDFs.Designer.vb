<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_QAPDFs
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.cbTipoDocumento = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbCodigoEmpaste = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbCodigoEdicion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnDesaprobar = New System.Windows.Forms.Button()
        Me.btnPasarQA = New System.Windows.Forms.Button()
        Me.btnAprobar = New System.Windows.Forms.Button()
        Me.dgvPDFs = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvPDFs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.cbTipoDocumento)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.tbCodigoEmpaste)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.tbCodigoEdicion)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(644, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Busqueda"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(431, 61)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 6
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'cbTipoDocumento
        '
        Me.cbTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoDocumento.FormattingEnabled = True
        Me.cbTipoDocumento.Location = New System.Drawing.Point(443, 22)
        Me.cbTipoDocumento.Name = "cbTipoDocumento"
        Me.cbTipoDocumento.Size = New System.Drawing.Size(179, 21)
        Me.cbTipoDocumento.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(333, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Tipo de Documento:"
        '
        'tbCodigoEmpaste
        '
        Me.tbCodigoEmpaste.Location = New System.Drawing.Point(131, 68)
        Me.tbCodigoEmpaste.Name = "tbCodigoEmpaste"
        Me.tbCodigoEmpaste.Size = New System.Drawing.Size(158, 20)
        Me.tbCodigoEmpaste.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Código de Empaste:"
        '
        'tbCodigoEdicion
        '
        Me.tbCodigoEdicion.Location = New System.Drawing.Point(131, 22)
        Me.tbCodigoEdicion.Name = "tbCodigoEdicion"
        Me.tbCodigoEdicion.Size = New System.Drawing.Size(158, 20)
        Me.tbCodigoEdicion.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código de Edición:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnDesaprobar)
        Me.GroupBox2.Controls.Add(Me.btnPasarQA)
        Me.GroupBox2.Controls.Add(Me.btnAprobar)
        Me.GroupBox2.Controls.Add(Me.dgvPDFs)
        Me.GroupBox2.Location = New System.Drawing.Point(21, 135)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(644, 314)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Resultados"
        '
        'btnDesaprobar
        '
        Me.btnDesaprobar.Location = New System.Drawing.Point(413, 277)
        Me.btnDesaprobar.Name = "btnDesaprobar"
        Me.btnDesaprobar.Size = New System.Drawing.Size(75, 23)
        Me.btnDesaprobar.TabIndex = 3
        Me.btnDesaprobar.Text = "Desaprobar"
        Me.btnDesaprobar.UseVisualStyleBackColor = True
        '
        'btnPasarQA
        '
        Me.btnPasarQA.Location = New System.Drawing.Point(297, 277)
        Me.btnPasarQA.Name = "btnPasarQA"
        Me.btnPasarQA.Size = New System.Drawing.Size(75, 23)
        Me.btnPasarQA.TabIndex = 2
        Me.btnPasarQA.Text = "Pasar a QA"
        Me.btnPasarQA.UseVisualStyleBackColor = True
        '
        'btnAprobar
        '
        Me.btnAprobar.Location = New System.Drawing.Point(174, 277)
        Me.btnAprobar.Name = "btnAprobar"
        Me.btnAprobar.Size = New System.Drawing.Size(75, 23)
        Me.btnAprobar.TabIndex = 1
        Me.btnAprobar.Text = "Aprobar"
        Me.btnAprobar.UseVisualStyleBackColor = True
        '
        'dgvPDFs
        '
        Me.dgvPDFs.AllowUserToAddRows = False
        Me.dgvPDFs.AllowUserToDeleteRows = False
        Me.dgvPDFs.AllowUserToResizeColumns = False
        Me.dgvPDFs.AllowUserToResizeRows = False
        Me.dgvPDFs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvPDFs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPDFs.Location = New System.Drawing.Point(21, 19)
        Me.dgvPDFs.MultiSelect = False
        Me.dgvPDFs.Name = "dgvPDFs"
        Me.dgvPDFs.ReadOnly = True
        Me.dgvPDFs.RowHeadersVisible = False
        Me.dgvPDFs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPDFs.Size = New System.Drawing.Size(601, 240)
        Me.dgvPDFs.TabIndex = 0
        '
        'Frm_QAPDFs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(697, 449)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Frm_QAPDFs"
        Me.Text = "PDFs por Aprobar"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvPDFs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbCodigoEdicion As System.Windows.Forms.TextBox
    Friend WithEvents tbCodigoEmpaste As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents cbTipoDocumento As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvPDFs As System.Windows.Forms.DataGridView
    Friend WithEvents btnDesaprobar As System.Windows.Forms.Button
    Friend WithEvents btnPasarQA As System.Windows.Forms.Button
    Friend WithEvents btnAprobar As System.Windows.Forms.Button
End Class
