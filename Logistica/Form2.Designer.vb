<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.btnProcesar = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.lstUnidades = New System.Windows.Forms.ListBox
        Me.lstObjetos = New System.Windows.Forms.ListBox
        Me.lstCarpetas = New System.Windows.Forms.ListBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblRuta = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.DgDatos = New System.Windows.Forms.DataGridView
        CType(Me.DgDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnProcesar
        '
        Me.btnProcesar.Location = New System.Drawing.Point(129, 604)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(299, 42)
        Me.btnProcesar.TabIndex = 2
        Me.btnProcesar.Text = "PROCESAR"
        Me.btnProcesar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "LISTA DE UNIDADES"
        '
        'lstUnidades
        '
        Me.lstUnidades.FormattingEnabled = True
        Me.lstUnidades.Location = New System.Drawing.Point(29, 105)
        Me.lstUnidades.Name = "lstUnidades"
        Me.lstUnidades.Size = New System.Drawing.Size(91, 173)
        Me.lstUnidades.TabIndex = 4
        '
        'lstObjetos
        '
        Me.lstObjetos.FormattingEnabled = True
        Me.lstObjetos.Location = New System.Drawing.Point(383, 105)
        Me.lstObjetos.Name = "lstObjetos"
        Me.lstObjetos.Size = New System.Drawing.Size(166, 173)
        Me.lstObjetos.TabIndex = 6
        '
        'lstCarpetas
        '
        Me.lstCarpetas.FormattingEnabled = True
        Me.lstCarpetas.Location = New System.Drawing.Point(164, 105)
        Me.lstCarpetas.Name = "lstCarpetas"
        Me.lstCarpetas.Size = New System.Drawing.Size(178, 173)
        Me.lstCarpetas.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(83, 301)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "RUTA"
        '
        'lblRuta
        '
        Me.lblRuta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRuta.Location = New System.Drawing.Point(164, 291)
        Me.lblRuta.Name = "lblRuta"
        Me.lblRuta.Size = New System.Drawing.Size(178, 23)
        Me.lblRuta.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(161, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "LISTA DE CARPETAS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(380, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "LISTA DE ARCHIVOS"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(124, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(289, 25)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "REGISTRO DE ARCHIVOS"
        '
        'DgDatos
        '
        Me.DgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgDatos.Location = New System.Drawing.Point(29, 328)
        Me.DgDatos.Name = "DgDatos"
        Me.DgDatos.ReadOnly = True
        Me.DgDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgDatos.Size = New System.Drawing.Size(520, 261)
        Me.DgDatos.TabIndex = 13
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(591, 658)
        Me.Controls.Add(Me.DgDatos)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblRuta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lstCarpetas)
        Me.Controls.Add(Me.lstObjetos)
        Me.Controls.Add(Me.lstUnidades)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnProcesar)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.DgDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnProcesar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lstUnidades As System.Windows.Forms.ListBox
    Friend WithEvents lstObjetos As System.Windows.Forms.ListBox
    Friend WithEvents lstCarpetas As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblRuta As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DgDatos As System.Windows.Forms.DataGridView
End Class
