<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_CrearReportePorAnio
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboReporte = New System.Windows.Forms.ComboBox()
        Me.btnMostrarReporte = New System.Windows.Forms.Button()
        Me.DgReporteXanio = New System.Windows.Forms.DataGridView()
        CType(Me.DgReporteXanio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(347, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LISTADO DE PÁGINA POR AÑO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(66, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Año de Publicación"
        '
        'cboReporte
        '
        Me.cboReporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboReporte.FormattingEnabled = True
        Me.cboReporte.Location = New System.Drawing.Point(203, 84)
        Me.cboReporte.Name = "cboReporte"
        Me.cboReporte.Size = New System.Drawing.Size(121, 21)
        Me.cboReporte.TabIndex = 2
        '
        'btnMostrarReporte
        '
        Me.btnMostrarReporte.Location = New System.Drawing.Point(146, 125)
        Me.btnMostrarReporte.Name = "btnMostrarReporte"
        Me.btnMostrarReporte.Size = New System.Drawing.Size(178, 27)
        Me.btnMostrarReporte.TabIndex = 3
        Me.btnMostrarReporte.Text = "Mostrar Reporte"
        Me.btnMostrarReporte.UseVisualStyleBackColor = True
        '
        'DgReporteXanio
        '
        Me.DgReporteXanio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgReporteXanio.Location = New System.Drawing.Point(50, 210)
        Me.DgReporteXanio.Name = "DgReporteXanio"
        Me.DgReporteXanio.Size = New System.Drawing.Size(59, 10)
        Me.DgReporteXanio.TabIndex = 4
        '
        'Frm_CrearReportePorAnio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 167)
        Me.Controls.Add(Me.DgReporteXanio)
        Me.Controls.Add(Me.btnMostrarReporte)
        Me.Controls.Add(Me.cboReporte)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Frm_CrearReportePorAnio"
        Me.Text = "Frm_CrearReportePorAnio"
        CType(Me.DgReporteXanio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboReporte As System.Windows.Forms.ComboBox
    Friend WithEvents btnMostrarReporte As System.Windows.Forms.Button
    Friend WithEvents DgReporteXanio As System.Windows.Forms.DataGridView
End Class
