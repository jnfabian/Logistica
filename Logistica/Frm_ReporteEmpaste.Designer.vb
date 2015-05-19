<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ReporteEmpaste
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_ReporteEmpaste))
        Me.CrvEmpaste = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'CrvEmpaste
        '
        Me.CrvEmpaste.ActiveViewIndex = -1
        Me.CrvEmpaste.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrvEmpaste.DisplayGroupTree = False
        Me.CrvEmpaste.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrvEmpaste.Location = New System.Drawing.Point(0, 0)
        Me.CrvEmpaste.Name = "CrvEmpaste"
        Me.CrvEmpaste.SelectionFormula = ""
        Me.CrvEmpaste.Size = New System.Drawing.Size(1042, 566)
        Me.CrvEmpaste.TabIndex = 0
        Me.CrvEmpaste.ViewTimeSelectionFormula = ""
        '
        'Frm_ReporteEmpaste
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1042, 566)
        Me.Controls.Add(Me.CrvEmpaste)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_ReporteEmpaste"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vista preliminar de reporte de empaste"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CrvEmpaste As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
