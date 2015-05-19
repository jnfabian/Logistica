<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ReporteEstado
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
        Me.CrvEstado = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'CrvEstado
        '
        Me.CrvEstado.ActiveViewIndex = -1
        Me.CrvEstado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrvEstado.DisplayGroupTree = False
        Me.CrvEstado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrvEstado.Location = New System.Drawing.Point(0, 0)
        Me.CrvEstado.Name = "CrvEstado"
        Me.CrvEstado.SelectionFormula = ""
        Me.CrvEstado.Size = New System.Drawing.Size(1062, 319)
        Me.CrvEstado.TabIndex = 0
        Me.CrvEstado.ViewTimeSelectionFormula = ""
        '
        'Frm_ReporteEstado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1062, 319)
        Me.Controls.Add(Me.CrvEstado)
        Me.Name = "Frm_ReporteEstado"
        Me.Text = "Frm_ReporteEstado"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CrvEstado As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
