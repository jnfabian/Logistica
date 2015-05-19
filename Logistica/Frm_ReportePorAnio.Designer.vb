<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ReportePorAnio
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
        Me.CrvReporteAnio = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CrvReporteAnio
        '
        Me.CrvReporteAnio.ActiveViewIndex = -1
        Me.CrvReporteAnio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrvReporteAnio.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrvReporteAnio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrvReporteAnio.Location = New System.Drawing.Point(0, 0)
        Me.CrvReporteAnio.Name = "CrvReporteAnio"
        Me.CrvReporteAnio.Size = New System.Drawing.Size(521, 380)
        Me.CrvReporteAnio.TabIndex = 0
        Me.CrvReporteAnio.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Frm_ReportePorAnio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(521, 380)
        Me.Controls.Add(Me.CrvReporteAnio)
        Me.Name = "Frm_ReportePorAnio"
        Me.Text = "Frm_ReportePorAnio"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CrvReporteAnio As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
