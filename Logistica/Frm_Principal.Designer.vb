<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Principal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TsmAdministrar = New System.Windows.Forms.ToolStripMenuItem()
        Me.TsmCambiarContraseña = New System.Windows.Forms.ToolStripMenuItem()
        Me.TsmGestionar = New System.Windows.Forms.ToolStripMenuItem()
        Me.TsmInventarioEdiciones = New System.Windows.Forms.ToolStripMenuItem()
        Me.TsmReporte = New System.Windows.Forms.ToolStripMenuItem()
        Me.TsmReporteEmpaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.TsmReporteEdicion = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportePaginas = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiPaginasPorEstado = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportePorAñoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QAToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiRevisarImagenes = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiRevisarPDFs = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiImagenesDesaprobadas = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiPDFsDesaprobados = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrazabilidadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiPasarOnbase = New System.Windows.Forms.ToolStripMenuItem()
        Me.TsmSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteDeCalidadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.MenuStrip1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TsmAdministrar, Me.TsmGestionar, Me.TsmReporte, Me.QAToolStripMenuItem, Me.TsmSalir})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(874, 33)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TsmAdministrar
        '
        Me.TsmAdministrar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TsmCambiarContraseña})
        Me.TsmAdministrar.Image = CType(resources.GetObject("TsmAdministrar.Image"), System.Drawing.Image)
        Me.TsmAdministrar.Name = "TsmAdministrar"
        Me.TsmAdministrar.Size = New System.Drawing.Size(111, 29)
        Me.TsmAdministrar.Text = "Administrar"
        '
        'TsmCambiarContraseña
        '
        Me.TsmCambiarContraseña.Image = CType(resources.GetObject("TsmCambiarContraseña.Image"), System.Drawing.Image)
        Me.TsmCambiarContraseña.Name = "TsmCambiarContraseña"
        Me.TsmCambiarContraseña.Size = New System.Drawing.Size(200, 32)
        Me.TsmCambiarContraseña.Text = "Cambiar contraseña"
        '
        'TsmGestionar
        '
        Me.TsmGestionar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TsmInventarioEdiciones})
        Me.TsmGestionar.Image = CType(resources.GetObject("TsmGestionar.Image"), System.Drawing.Image)
        Me.TsmGestionar.Name = "TsmGestionar"
        Me.TsmGestionar.Size = New System.Drawing.Size(102, 29)
        Me.TsmGestionar.Text = "Inventario"
        '
        'TsmInventarioEdiciones
        '
        Me.TsmInventarioEdiciones.Image = CType(resources.GetObject("TsmInventarioEdiciones.Image"), System.Drawing.Image)
        Me.TsmInventarioEdiciones.Name = "TsmInventarioEdiciones"
        Me.TsmInventarioEdiciones.Size = New System.Drawing.Size(219, 32)
        Me.TsmInventarioEdiciones.Text = "Inventario de empastes"
        '
        'TsmReporte
        '
        Me.TsmReporte.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TsmReporteEmpaste, Me.TsmReporteEdicion, Me.ReportePaginas, Me.tsmiPaginasPorEstado, Me.ReportePorAñoToolStripMenuItem, Me.ReporteDeCalidadToolStripMenuItem})
        Me.TsmReporte.Image = CType(resources.GetObject("TsmReporte.Image"), System.Drawing.Image)
        Me.TsmReporte.Name = "TsmReporte"
        Me.TsmReporte.Size = New System.Drawing.Size(96, 29)
        Me.TsmReporte.Text = "Reportes"
        '
        'TsmReporteEmpaste
        '
        Me.TsmReporteEmpaste.Image = CType(resources.GetObject("TsmReporteEmpaste.Image"), System.Drawing.Image)
        Me.TsmReporteEmpaste.Name = "TsmReporteEmpaste"
        Me.TsmReporteEmpaste.Size = New System.Drawing.Size(207, 32)
        Me.TsmReporteEmpaste.Text = "Reporte de empastes"
        '
        'TsmReporteEdicion
        '
        Me.TsmReporteEdicion.Image = CType(resources.GetObject("TsmReporteEdicion.Image"), System.Drawing.Image)
        Me.TsmReporteEdicion.Name = "TsmReporteEdicion"
        Me.TsmReporteEdicion.Size = New System.Drawing.Size(207, 32)
        Me.TsmReporteEdicion.Text = "Reporte de ediciones"
        '
        'ReportePaginas
        '
        Me.ReportePaginas.Image = CType(resources.GetObject("ReportePaginas.Image"), System.Drawing.Image)
        Me.ReportePaginas.Name = "ReportePaginas"
        Me.ReportePaginas.Size = New System.Drawing.Size(207, 32)
        Me.ReportePaginas.Text = "Reporte de páginas"
        '
        'tsmiPaginasPorEstado
        '
        Me.tsmiPaginasPorEstado.Image = Global.Logistica.My.Resources.Resources.Reporte
        Me.tsmiPaginasPorEstado.Name = "tsmiPaginasPorEstado"
        Me.tsmiPaginasPorEstado.Size = New System.Drawing.Size(207, 32)
        Me.tsmiPaginasPorEstado.Text = "Reporte por Estado"
        '
        'ReportePorAñoToolStripMenuItem
        '
        Me.ReportePorAñoToolStripMenuItem.Image = CType(resources.GetObject("ReportePorAñoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ReportePorAñoToolStripMenuItem.Name = "ReportePorAñoToolStripMenuItem"
        Me.ReportePorAñoToolStripMenuItem.Size = New System.Drawing.Size(207, 32)
        Me.ReportePorAñoToolStripMenuItem.Text = "Reporte por Año"
        '
        'QAToolStripMenuItem
        '
        Me.QAToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QAToolStripMenuItem1, Me.tsmiImagenesDesaprobadas, Me.tsmiPDFsDesaprobados, Me.TrazabilidadToolStripMenuItem, Me.tsmiPasarOnbase})
        Me.QAToolStripMenuItem.Image = Global.Logistica.My.Resources.Resources.cc
        Me.QAToolStripMenuItem.Name = "QAToolStripMenuItem"
        Me.QAToolStripMenuItem.Size = New System.Drawing.Size(90, 29)
        Me.QAToolStripMenuItem.Text = "Proceso"
        '
        'QAToolStripMenuItem1
        '
        Me.QAToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiRevisarImagenes, Me.tsmiRevisarPDFs})
        Me.QAToolStripMenuItem1.Image = CType(resources.GetObject("QAToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.QAToolStripMenuItem1.Name = "QAToolStripMenuItem1"
        Me.QAToolStripMenuItem1.Size = New System.Drawing.Size(213, 32)
        Me.QAToolStripMenuItem1.Text = "Control de Calidad"
        '
        'tsmiRevisarImagenes
        '
        Me.tsmiRevisarImagenes.Image = Global.Logistica.My.Resources.Resources.imagen
        Me.tsmiRevisarImagenes.Name = "tsmiRevisarImagenes"
        Me.tsmiRevisarImagenes.Size = New System.Drawing.Size(187, 32)
        Me.tsmiRevisarImagenes.Text = "Revisar Imagenes"
        '
        'tsmiRevisarPDFs
        '
        Me.tsmiRevisarPDFs.Image = Global.Logistica.My.Resources.Resources.pdf
        Me.tsmiRevisarPDFs.Name = "tsmiRevisarPDFs"
        Me.tsmiRevisarPDFs.Size = New System.Drawing.Size(187, 32)
        Me.tsmiRevisarPDFs.Text = "Revisar PDFs"
        '
        'tsmiImagenesDesaprobadas
        '
        Me.tsmiImagenesDesaprobadas.Image = Global.Logistica.My.Resources.Resources.imagen_desaprobada
        Me.tsmiImagenesDesaprobadas.Name = "tsmiImagenesDesaprobadas"
        Me.tsmiImagenesDesaprobadas.Size = New System.Drawing.Size(213, 32)
        Me.tsmiImagenesDesaprobadas.Text = "Imagenes Rechazadas"
        '
        'tsmiPDFsDesaprobados
        '
        Me.tsmiPDFsDesaprobados.Image = Global.Logistica.My.Resources.Resources.pdf_desaprobado
        Me.tsmiPDFsDesaprobados.Name = "tsmiPDFsDesaprobados"
        Me.tsmiPDFsDesaprobados.Size = New System.Drawing.Size(213, 32)
        Me.tsmiPDFsDesaprobados.Text = "PDFs Rechazados"
        '
        'TrazabilidadToolStripMenuItem
        '
        Me.TrazabilidadToolStripMenuItem.Image = CType(resources.GetObject("TrazabilidadToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TrazabilidadToolStripMenuItem.Name = "TrazabilidadToolStripMenuItem"
        Me.TrazabilidadToolStripMenuItem.Size = New System.Drawing.Size(213, 32)
        Me.TrazabilidadToolStripMenuItem.Text = "Trazabilidad"
        '
        'tsmiPasarOnbase
        '
        Me.tsmiPasarOnbase.Image = Global.Logistica.My.Resources.Resources.flecha
        Me.tsmiPasarOnbase.Name = "tsmiPasarOnbase"
        Me.tsmiPasarOnbase.Size = New System.Drawing.Size(213, 32)
        Me.tsmiPasarOnbase.Text = "Pasar a Onbase"
        '
        'TsmSalir
        '
        Me.TsmSalir.Image = CType(resources.GetObject("TsmSalir.Image"), System.Drawing.Image)
        Me.TsmSalir.Name = "TsmSalir"
        Me.TsmSalir.Size = New System.Drawing.Size(71, 29)
        Me.TsmSalir.Text = "Salir"
        '
        'ReporteDeCalidadToolStripMenuItem
        '
        Me.ReporteDeCalidadToolStripMenuItem.Image = Global.Logistica.My.Resources.Resources.Reporte
        Me.ReporteDeCalidadToolStripMenuItem.Name = "ReporteDeCalidadToolStripMenuItem"
        Me.ReporteDeCalidadToolStripMenuItem.Size = New System.Drawing.Size(207, 32)
        Me.ReporteDeCalidadToolStripMenuItem.Text = "Reporte de Calidad"
        '
        'Frm_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(874, 384)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Frm_Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Principal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents TsmAdministrar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TsmGestionar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TsmReporte As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TsmSalir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TsmInventarioEdiciones As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TsmReporteEmpaste As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TsmReporteEdicion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportePaginas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TsmCambiarContraseña As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiImagenesDesaprobadas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiPDFsDesaprobados As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QAToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiRevisarImagenes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiRevisarPDFs As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TrazabilidadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiPaginasPorEstado As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiPasarOnbase As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportePorAñoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReporteDeCalidadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
