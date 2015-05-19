<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ReporteEdicion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_ReporteEdicion))
        Me.CrvEdicion = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'CrvEdicion
        '
        Me.CrvEdicion.ActiveViewIndex = -1
        Me.CrvEdicion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrvEdicion.DisplayGroupTree = False
        Me.CrvEdicion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrvEdicion.Location = New System.Drawing.Point(0, 0)
        Me.CrvEdicion.Name = "CrvEdicion"
        Me.CrvEdicion.SelectionFormula = ""
        Me.CrvEdicion.Size = New System.Drawing.Size(886, 555)
        Me.CrvEdicion.TabIndex = 0
        Me.CrvEdicion.ViewTimeSelectionFormula = ""
        '
        'Frm_ReporteEdicion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(886, 555)
        Me.Controls.Add(Me.CrvEdicion)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_ReporteEdicion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vista preliminar de reporte de ediciones"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CrvEdicion As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
