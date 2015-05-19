<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ReportePagina
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_ReportePagina))
        Me.CrvPagina = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'CrvPagina
        '
        Me.CrvPagina.ActiveViewIndex = -1
        Me.CrvPagina.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrvPagina.DisplayGroupTree = False
        Me.CrvPagina.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrvPagina.Location = New System.Drawing.Point(0, 0)
        Me.CrvPagina.Name = "CrvPagina"
        Me.CrvPagina.SelectionFormula = ""
        Me.CrvPagina.Size = New System.Drawing.Size(1042, 566)
        Me.CrvPagina.TabIndex = 0
        Me.CrvPagina.ViewTimeSelectionFormula = ""
        '
        'Frm_ReportePagina
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1042, 566)
        Me.Controls.Add(Me.CrvPagina)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_ReportePagina"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vista preliminar de reporte de páginas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CrvPagina As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
