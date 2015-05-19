<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_QAimagen
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbTipoDocumento = New System.Windows.Forms.ComboBox()
        Me.tbCodigoEmpaste = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbCodigoEdicion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.tbCodigoPagina = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnPasarQA = New System.Windows.Forms.Button()
        Me.btnDesaprobar = New System.Windows.Forms.Button()
        Me.dgvImagenes = New System.Windows.Forms.DataGridView()
        Me.btnAprobar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblInicio = New System.Windows.Forms.Label()
        Me.lblFinal = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvImagenes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cbTipoDocumento)
        Me.GroupBox1.Controls.Add(Me.tbCodigoEmpaste)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.tbCodigoEdicion)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.tbCodigoPagina)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(703, 128)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Busqueda"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(371, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Tipo de Documento:"
        '
        'cbTipoDocumento
        '
        Me.cbTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoDocumento.FormattingEnabled = True
        Me.cbTipoDocumento.Location = New System.Drawing.Point(507, 55)
        Me.cbTipoDocumento.Name = "cbTipoDocumento"
        Me.cbTipoDocumento.Size = New System.Drawing.Size(121, 21)
        Me.cbTipoDocumento.TabIndex = 7
        '
        'tbCodigoEmpaste
        '
        Me.tbCodigoEmpaste.Location = New System.Drawing.Point(148, 61)
        Me.tbCodigoEmpaste.Name = "tbCodigoEmpaste"
        Me.tbCodigoEmpaste.Size = New System.Drawing.Size(156, 20)
        Me.tbCodigoEmpaste.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Código de Empaste:"
        '
        'tbCodigoEdicion
        '
        Me.tbCodigoEdicion.Location = New System.Drawing.Point(507, 22)
        Me.tbCodigoEdicion.Name = "tbCodigoEdicion"
        Me.tbCodigoEdicion.Size = New System.Drawing.Size(158, 20)
        Me.tbCodigoEdicion.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(371, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Código de Edición:"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(339, 99)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'tbCodigoPagina
        '
        Me.tbCodigoPagina.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCodigoPagina.Location = New System.Drawing.Point(148, 24)
        Me.tbCodigoPagina.Name = "tbCodigoPagina"
        Me.tbCodigoPagina.Size = New System.Drawing.Size(158, 21)
        Me.tbCodigoPagina.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código de Pagina: "
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.lblFinal)
        Me.GroupBox2.Controls.Add(Me.lblInicio)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.lblTotal)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.btnAtras)
        Me.GroupBox2.Controls.Add(Me.btnSiguiente)
        Me.GroupBox2.Controls.Add(Me.btnPasarQA)
        Me.GroupBox2.Controls.Add(Me.btnDesaprobar)
        Me.GroupBox2.Controls.Add(Me.dgvImagenes)
        Me.GroupBox2.Controls.Add(Me.btnAprobar)
        Me.GroupBox2.Location = New System.Drawing.Point(27, 159)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(712, 360)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Resultados"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(77, 316)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(39, 13)
        Me.lblTotal.TabIndex = 7
        Me.lblTotal.Text = "Label6"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 315)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "total"
        '
        'btnAtras
        '
        Me.btnAtras.Location = New System.Drawing.Point(169, 316)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(36, 23)
        Me.btnAtras.TabIndex = 5
        Me.btnAtras.Text = "<<"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Location = New System.Drawing.Point(229, 316)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(36, 23)
        Me.btnSiguiente.TabIndex = 5
        Me.btnSiguiente.Text = ">>"
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'btnPasarQA
        '
        Me.btnPasarQA.Location = New System.Drawing.Point(507, 315)
        Me.btnPasarQA.Name = "btnPasarQA"
        Me.btnPasarQA.Size = New System.Drawing.Size(75, 23)
        Me.btnPasarQA.TabIndex = 4
        Me.btnPasarQA.Text = "Pasar a QA"
        Me.btnPasarQA.UseVisualStyleBackColor = True
        '
        'btnDesaprobar
        '
        Me.btnDesaprobar.Location = New System.Drawing.Point(611, 315)
        Me.btnDesaprobar.Name = "btnDesaprobar"
        Me.btnDesaprobar.Size = New System.Drawing.Size(75, 23)
        Me.btnDesaprobar.TabIndex = 3
        Me.btnDesaprobar.Text = "Desaprobar"
        Me.btnDesaprobar.UseVisualStyleBackColor = True
        '
        'dgvImagenes
        '
        Me.dgvImagenes.AllowUserToAddRows = False
        Me.dgvImagenes.AllowUserToDeleteRows = False
        Me.dgvImagenes.AllowUserToResizeColumns = False
        Me.dgvImagenes.AllowUserToResizeRows = False
        Me.dgvImagenes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvImagenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvImagenes.Location = New System.Drawing.Point(20, 20)
        Me.dgvImagenes.MultiSelect = False
        Me.dgvImagenes.Name = "dgvImagenes"
        Me.dgvImagenes.ReadOnly = True
        Me.dgvImagenes.RowHeadersVisible = False
        Me.dgvImagenes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvImagenes.Size = New System.Drawing.Size(666, 253)
        Me.dgvImagenes.TabIndex = 0
        '
        'btnAprobar
        '
        Me.btnAprobar.Location = New System.Drawing.Point(397, 315)
        Me.btnAprobar.Name = "btnAprobar"
        Me.btnAprobar.Size = New System.Drawing.Size(75, 23)
        Me.btnAprobar.TabIndex = 2
        Me.btnAprobar.Text = "Aprobar"
        Me.btnAprobar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 285)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(21, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "De"
        '
        'lblInicio
        '
        Me.lblInicio.AutoSize = True
        Me.lblInicio.Location = New System.Drawing.Point(67, 285)
        Me.lblInicio.Name = "lblInicio"
        Me.lblInicio.Size = New System.Drawing.Size(39, 13)
        Me.lblInicio.TabIndex = 9
        Me.lblInicio.Text = "Label7"
        '
        'lblFinal
        '
        Me.lblFinal.AutoSize = True
        Me.lblFinal.Location = New System.Drawing.Point(184, 285)
        Me.lblFinal.Name = "lblFinal"
        Me.lblFinal.Size = New System.Drawing.Size(39, 13)
        Me.lblFinal.TabIndex = 10
        Me.lblFinal.Text = "Label7"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(135, 285)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "a"
        '
        'Frm_QAimagen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(771, 531)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Frm_QAimagen"
        Me.Text = "QA Imagenes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvImagenes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents tbCodigoPagina As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvImagenes As System.Windows.Forms.DataGridView
    Friend WithEvents tbCodigoEdicion As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbCodigoEmpaste As System.Windows.Forms.TextBox
    Friend WithEvents btnAprobar As System.Windows.Forms.Button
    Friend WithEvents btnDesaprobar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbTipoDocumento As System.Windows.Forms.ComboBox
    Friend WithEvents btnPasarQA As System.Windows.Forms.Button
    Friend WithEvents btnAtras As System.Windows.Forms.Button
    Friend WithEvents btnSiguiente As System.Windows.Forms.Button
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblFinal As System.Windows.Forms.Label
    Friend WithEvents lblInicio As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
