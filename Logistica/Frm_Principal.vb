Public Class Frm_Principal

    Public Shared datosUsuario As String
    Private aa As New Clases.AccesoArchivos()

    Private Sub TsmSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TsmSalir.Click

        aa.RedDesconectarTodo()
        Application.Exit()
        Me.Close()
        Me.Dispose()

        KillProcess("Logistica.exe")
        CerrarVentanas()
    End Sub

    Private Sub Frm_Principal_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        aa.RedDesconectarTodo()
        Application.Exit()
        KillProcess("Logistica.exe")
        CerrarVentanas()
    End Sub

    Public Sub CerrarVentanas()
        aa.RedDesconectarTodo()

        Frm_Edicion.Close()
        Frm_Paginas.Close()


    End Sub

    Public Sub KillProcess(ByVal processName As String)
        On Error GoTo ErrHandler
        Dim oWMI
        Dim ret
        Dim sService
        Dim oWMIServices
        Dim oWMIService
        Dim oServices
        Dim oService
        Dim servicename
        oWMI = GetObject("winmgmts:")
        oServices = oWMI.InstancesOf("win32_process")
        For Each oService In oServices
            servicename = LCase(Trim(CStr(oService.Name) & ""))
            If InStr(1, servicename, LCase(processName), vbTextCompare) > 0 Then
                ret = oService.Terminate
            End If
        Next
        oServices = Nothing
        oWMI = Nothing
ErrHandler:
        Err.Clear()
    End Sub

    Private Sub TsmInventarioEdiciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TsmInventarioEdiciones.Click
        Dim Inventario As Frm_Empaste = New Frm_Empaste
        Inventario.MdiParent = Me
        Inventario.Show()
    End Sub

    Private Sub TsmReporteEmpaste_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TsmReporteEmpaste.Click
        Dim REmpaste As Frm_CrearReporteEmpaste = New Frm_CrearReporteEmpaste
        REmpaste.MdiParent = Me
        REmpaste.Show()
    End Sub

    Private Sub TsmReporteEdicion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TsmReporteEdicion.Click
        Dim REdicion As Frm_CrearReporteEdicion = New Frm_CrearReporteEdicion
        REdicion.MdiParent = Me
        REdicion.Show()
    End Sub

    Private Sub ReportePaginas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportePaginas.Click
        Dim RPagina As Frm_CrearReportePagina = New Frm_CrearReportePagina
        RPagina.MdiParent = Me
        RPagina.Show()
    End Sub

    Private Sub TsmCambiarContraseña_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TsmCambiarContraseña.Click
        Dim Cambiar As Frm_CambiarClave = New Frm_CambiarClave
        Cambiar.MdiParent = Me
        Cambiar.Show()
    End Sub

    Private Sub tsmiImagenesDesaprobadas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiImagenesDesaprobadas.Click
        Dim QA_imagenes_desaprobadas As Frm_QAimagen = New Frm_QAimagen(2)
        QA_imagenes_desaprobadas.MdiParent = Me
        QA_imagenes_desaprobadas.Show()
    End Sub

    Private Sub tsmiRevisarImagenes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiRevisarImagenes.Click
        Dim QA_imagenes As Frm_QAimagen = New Frm_QAimagen(1)
        QA_imagenes.MdiParent = Me
        QA_imagenes.Show()
    End Sub

    Private Sub tsmiRevisarPDFs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiRevisarPDFs.Click
        Dim QA_PDF As Frm_QAPDFs = New Frm_QAPDFs(1)
        QA_PDF.MdiParent = Me
        QA_PDF.Show()
    End Sub

    Private Sub tsmiPDFsDesaprobados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiPDFsDesaprobados.Click
        Dim QA_PDF_desaprobados As Frm_QAPDFs = New Frm_QAPDFs(2)
        QA_PDF_desaprobados.MdiParent = Me
        QA_PDF_desaprobados.Show()
    End Sub

    Private Sub TrazabilidadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrazabilidadToolStripMenuItem.Click
        Dim Trazabilidad As Frm_Trazabilidad = New Frm_Trazabilidad()
        Trazabilidad.MdiParent = Me
        Trazabilidad.Show()
    End Sub

    Private Sub tsmiPaginasPorEstado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiPaginasPorEstado.Click
        Dim ReporteEstado As Frm_CrearReporteEstado = New Frm_CrearReporteEstado()
        ReporteEstado.MdiParent = Me
        ReporteEstado.Show()
    End Sub

    Private Sub tsmiPasarOnbase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiPasarOnbase.Click
        Dim PasarOnbase As Frm_PasarOnbase = New Frm_PasarOnbase()
        PasarOnbase.MdiParent = Me
        PasarOnbase.Show()
    End Sub

    Private Sub ReportePorAñoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportePorAñoToolStripMenuItem.Click
        Dim ReporteAnio As Frm_CrearReportePorAnio = New Frm_CrearReportePorAnio()
        ReporteAnio.MdiParent = Me
        ReporteAnio.Show()
    End Sub

    Private Sub Frm_Principal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '*******************Metodo para la obtencion del usuario de windows*************
        ' MessageBox.Show(Environment.UserDomainName & vbNewLine & Environment.UserName)
    End Sub

    Private Sub ReporteDeCalidadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReporteDeCalidadToolStripMenuItem.Click
        Dim ReporteCalidad As Frm_CrearReporteCalidad = New Frm_CrearReporteCalidad()
        ReporteCalidad.MdiParent = Me
        ReporteCalidad.Show()
    End Sub
End Class