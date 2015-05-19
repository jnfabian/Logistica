<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Reporte
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
        Me.CryReporte = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CryReporte
        '
        Me.CryReporte.ActiveViewIndex = -1
        Me.CryReporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CryReporte.Cursor = System.Windows.Forms.Cursors.Default
        Me.CryReporte.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CryReporte.Location = New System.Drawing.Point(0, 0)
        Me.CryReporte.Name = "CryReporte"
        Me.CryReporte.Size = New System.Drawing.Size(345, 288)
        Me.CryReporte.TabIndex = 0
        Me.CryReporte.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Frm_Reporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(345, 288)
        Me.Controls.Add(Me.CryReporte)
        Me.Name = "Frm_Reporte"
        Me.Text = "Frm_Reporte"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CryReporte As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
