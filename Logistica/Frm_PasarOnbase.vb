Imports System.Threading
Imports System.Configuration
Imports Logistica.InterfaceOnBase
'Imports Logistica.LogisticaInterfaceOnBaseLogic
Imports YourCompany.Utils.Encryption

Public Class Frm_PasarOnbase
    Inherits System.Windows.Forms.Form

    Dim dtResgistros As New DataTable("Table")
    Dim dtTipo As Integer = 0
    Dim gstrArchivoTexto As String = ConfigurationManager.AppSettings("OnBaseArchivoLogistica")

    Private _threadProceso As Thread


    Private Sub Frm_PasarOnbase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenarTipos()
    End Sub

    Private Sub llenarTipos()
        Dim dt As DataTable = New DataTable("Tipos")
        dt.Columns.Add("Codigo")
        dt.Columns.Add("Descripcion")

        Dim dr As DataRow

        dr = dt.NewRow()
        dr("Codigo") = "0"
        dr("Descripcion") = "Página"
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("Codigo") = "1"
        dr("Descripcion") = "Edición"
        dt.Rows.Add(dr)

        Me.cbTipo.DataSource = dt
        Me.cbTipo.ValueMember = "Codigo"
        Me.cbTipo.DisplayMember = "Descripcion"
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        ActualizarGrilla()
    End Sub

    Private Sub ActualizarGrilla()
        If tbAnio.Text.Length <> 4 Then
            MsgBox("Ingrese un Año correcto", MsgBoxStyle.Exclamation, "Aviso")
        Else
            Dim cPasarOnbase As New Clases.C_Trazabilidad
            Dim value As String = cbTipo.SelectedValue()
            dtTipo = Convert.ToInt16(value)
            Dim anio As Integer = tbAnio.Text
            dtResgistros = cPasarOnbase.pasarOnbase(value, anio)
            dgvTipo.DataSource = dtResgistros
            crearColumnas(dtTipo)
        End If
    End Sub

    Private Sub crearColumnas(ByVal tipo As Integer)
        dgvTipo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvTipo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgvTipo.DefaultCellStyle.BackColor = Color.AliceBlue

        Dim hCodigo As String = "Cod. Pagina"
        Dim hTipo As String = "Tipo"
        Dim hNumPagina As String = "Num. de Pag."
        Dim hFecha As String = "Fecha Publ."
        Dim hNombre As String = "Titulo"
        Dim hSubtitulo As String = "SubTitulo"
        Dim hNombreArchivo As String = "Nomb. Imagen"

        If tipo = 0 Then
            hCodigo = "Cod. Edicion"
            hNombreArchivo = "Nomb. PDF"
        End If

        dgvTipo.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvTipo.Columns.Item(0).HeaderText = hCodigo
        dgvTipo.Columns.Item(0).Name = "Codigo"
        dgvTipo.Columns.Item(1).HeaderText = hTipo
        dgvTipo.Columns.Item(1).Name = "Tipo"
        dgvTipo.Columns.Item(2).HeaderText = hNumPagina
        dgvTipo.Columns.Item(2).Name = "NumeroPagina"
        dgvTipo.Columns.Item(3).HeaderText = hFecha
        dgvTipo.Columns.Item(3).Name = "Fecha Publ."
        dgvTipo.Columns.Item(4).HeaderText = hNombre
        dgvTipo.Columns.Item(4).Name = "Titulo"
        dgvTipo.Columns.Item(5).HeaderText = hSubtitulo
        dgvTipo.Columns.Item(5).Name = "Subtitulo"
        dgvTipo.Columns.Item(6).HeaderText = hNombreArchivo
        dgvTipo.Columns.Item(6).Name = hNombreArchivo
        dgvTipo.Columns.Item(7).Name = "CodigoTipo"
        dgvTipo.Columns.Item(7).Visible = False

    End Sub

    Private Sub ProcesarInterfacePagina()

        Dim oOnbase As New InterfaceOnBase.OnbaseDB
        Dim oItem As New InterfaceOnBase.PaginaItem
        'Dim obj As New LogisticaInterfaceOnBaseLogic

        Dim dt As DataTable
        Dim dr As DataRow



        Dim intTotal As Integer

        Dim strCodConcesionOnbase As String = "0"

        dt = dtResgistros
        intTotal = dt.Rows.Count

        If intTotal = 0 Then
            MessageBox.Show("No hay registros que enviar, seleccione otro Año", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor

        Me.lblTituloProceso.Text = "Procesando..."

        Dim strOnBaseDataSourceName As String = ConfigurationManager.AppSettings("OnBaseDataSourceName")
        Dim strOnBaseUserName As String = ConfigurationManager.AppSettings("OnBaseUserName")
        Dim strOnBasePassword As String = ConfigurationManager.AppSettings("OnBasePassword")

        oOnbase.mstrDataSourseName = strOnBaseDataSourceName
        oOnbase.mstrUserName = strOnBaseUserName
        oOnbase.mstrPassword = DesencriptarCadena(strOnBasePassword)
        oOnbase.Open()

        Try

            Me.ProgressBar1.Minimum = 1
            Me.ProgressBar1.Maximum = intTotal

            For i As Integer = 0 To dgvTipo.Rows.Count - 1

                Me.ProgressBar1.Value = (i + 1)
                Me.lblProceso.Text = "Registro " & (i + 1).ToString & " de " & intTotal.ToString
                Me.Refresh()

                dr = dt.Rows(i)

                If IsDBNull(dr.Item("Codigo")) Then
                    oItem.CodPagina = ""
                Else
                    oItem.CodPagina = CStr(dr.Item("Codigo"))
                End If

                If IsDBNull(dr.Item("Tipo")) Then
                    oItem.Tipo = ""
                Else
                    oItem.Tipo = CStr(dr.Item("Tipo"))
                End If

                If IsDBNull(dr.Item("NumeroPagina")) Then
                    oItem.NumeroPagina = ""
                Else
                    oItem.NumeroPagina = CStr(dr.Item("NumeroPagina"))
                End If

                If IsDBNull(dr.Item("FechaPublicacion")) Then
                    oItem.FechaPublicacion = ""
                Else
                    oItem.FechaPublicacion = CStr(dr.Item("FechaPublicacion")).Replace("-", "/")
                End If

                If IsDBNull(dr.Item("Nombre")) Then
                    oItem.Nombre = ""
                Else
                    oItem.Nombre = CStr(dr.Item("Nombre"))
                End If

                If IsDBNull(dr.Item("SubTitulo")) Then
                    oItem.SubTitulo = ""
                Else
                    oItem.SubTitulo = CStr(dr.Item("SubTitulo"))
                End If

                If IsDBNull(dr.Item("Archivo")) Then
                    oItem.Archivo = ""
                Else
                    oItem.Archivo = CStr(dr.Item("Archivo"))
                End If


                If IsDBNull(dr.Item("CodigoTipo")) Then
                    oItem.CodigoTipo = 1
                Else
                    oItem.CodigoTipo = Convert.ToInt16(dr.Item("CodigoTipo"))
                End If


                oItem.Archivo = ObtenerRutaPagina(CStr(dr.Item("Archivo")))

                strCodConcesionOnbase = oOnbase.AlmacenarPagina(oItem)

                cambiarEstadoOnbasePagina(oItem.CodPagina, oItem.CodigoTipo)

            Next

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MessageBox.Show("ERROR: " & ex.ToString, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            oOnbase.close()
            Exit Sub
        End Try


        oOnbase.close()

        MessageBox.Show("Proceso concluido", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)

        LimpiarDatos()

        ActualizarGrilla()

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub ProcesarInterfaceEdicion()

        Dim oOnbase As New InterfaceOnBase.OnbaseDB
        Dim oItem As New InterfaceOnBase.EdicionItem
        'Dim obj As New LogisticaInterfaceOnBaseLogic

        Dim dt As DataTable
        Dim dr As DataRow
        Dim strTmp As String = ""

        Dim intTotal As Integer

        Dim strCodConcesionOnbase As String = "0"

        dt = dtResgistros
        intTotal = dt.Rows.Count

        If intTotal = 0 Then
            MessageBox.Show("No hay registros que enviar, seleccione otro Año", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor

        Me.lblTituloProceso.Text = "Procesando..."

        Dim strOnBaseDataSourceName As String = ConfigurationManager.AppSettings("OnBaseDataSourceName")
        Dim strOnBaseUserName As String = ConfigurationManager.AppSettings("OnBaseUserName")
        Dim strOnBasePassword As String = ConfigurationManager.AppSettings("OnBasePassword")

        oOnbase.mstrDataSourseName = strOnBaseDataSourceName
        oOnbase.mstrUserName = strOnBaseUserName
        oOnbase.mstrPassword = DesencriptarCadena(strOnBasePassword)
        oOnbase.Open()

        Try

            Me.ProgressBar1.Minimum = 1
            Me.ProgressBar1.Maximum = intTotal

            For i As Integer = 0 To dgvTipo.Rows.Count - 1

                Me.ProgressBar1.Value = (i + 1)
                Me.lblProceso.Text = "Registro " & (i + 1).ToString & " de " & intTotal.ToString
                Me.Refresh()

                dr = dt.Rows(i)

                If IsDBNull(dr.Item("Codigo")) Then
                    oItem.CodEdicion = ""
                Else
                    oItem.CodEdicion = CStr(dr.Item("Codigo"))
                End If

                If IsDBNull(dr.Item("Tipo")) Then
                    oItem.Tipo = ""
                Else
                    oItem.Tipo = CStr(dr.Item("Tipo"))
                End If

                If IsDBNull(dr.Item("NumeroPagina")) Then
                    oItem.NumeroPagina = ""
                Else
                    oItem.NumeroPagina = CStr(dr.Item("NumeroPagina"))
                End If

                If IsDBNull(dr.Item("FechaPublicacion")) Then
                    oItem.FechaPublicacion = ""
                Else
                    oItem.FechaPublicacion = CStr(dr.Item("FechaPublicacion")).Replace("-", "/")
                End If

                If IsDBNull(dr.Item("Nombre")) Then
                    oItem.Nombre = ""
                Else
                    oItem.Nombre = CStr(dr.Item("Nombre"))
                End If

                If IsDBNull(dr.Item("SubTitulo")) Then
                    oItem.SubTitulo = ""
                Else
                    oItem.SubTitulo = CStr(dr.Item("SubTitulo"))
                End If

                If IsDBNull(dr.Item("Archivo")) Then
                    oItem.Archivo = ""
                Else
                    oItem.Archivo = ObtenerRutaEdicion(CStr(dr.Item("Archivo")))
                End If

                If IsDBNull(dr.Item("CodigoTipo")) Then
                    oItem.CodigoTipo = 1
                Else
                    oItem.CodigoTipo = Convert.ToInt16(dr.Item("CodigoTipo"))
                End If

                strCodConcesionOnbase = oOnbase.AlmacenarEdicion(oItem)

                cambiarEstadoOnbaseEdicion(oItem.CodEdicion, oItem.CodigoTipo)

            Next

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MessageBox.Show("ERROR: " & ex.ToString, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            oOnbase.close()
            Exit Sub
        End Try

        oOnbase.close()

        MessageBox.Show("Proceso concluido", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)

        LimpiarDatos()

        ActualizarGrilla()

        Me.Cursor = Cursors.Default

    End Sub

    Public Sub cambiarEstadoOnbasePagina(ByVal codPagina As String, ByVal codTipo As Integer)
        Dim cPagina As New Clases.C_Paginas
        cPagina.actualizarEstadoOnbase(codPagina, codTipo)
    End Sub

    Public Sub cambiarEstadoOnbaseEdicion(ByVal codEdicion As String, ByVal codTipo As Integer)
        Dim cEdicion As New Clases.C_Edicion
        cEdicion.actualizarEstadoOnbase(codEdicion, codTipo)
    End Sub

    Private Function ObtenerRutaPagina(ByVal nombre As String) As String
        Dim rutaPagina As String = ""
        Dim carpetaR As String = ConfigurationManager.AppSettings("carpetaR")

        Dim carpetaAnio As String = nombre.Substring(0, 4)
        Dim carpetaTomo As String = "TOMO-" & nombre.Substring(18, 2)
        Dim carpetaEdicion As String = nombre.Substring(0, 8) & nombre.Substring(20, 5)
        rutaPagina = carpetaR & carpetaAnio & "\" & carpetaTomo & "\" & carpetaEdicion & "\" & nombre

        Return rutaPagina
    End Function

    Private Function ObtenerRutaEdicion(ByVal nombre As String) As String
        Dim rutaEdicion As String = ""
        Dim carpetaR As String = ConfigurationManager.AppSettings("carpetaR")
        Dim carpetaAnio As String = nombre.Substring(0, 4)
        Dim carpetaEdicion As String = "PDF " & nombre.Substring(0, 4) & " CORREGIDO"
        rutaEdicion = carpetaR & carpetaAnio & "\" & carpetaEdicion & "\" & nombre

        Return rutaEdicion
    End Function

    Private Sub btnPasarOnbase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPasarOnbase.Click
        If dgvTipo.Rows.Count > 0 Then
            'CerrarHilo()
            If MessageBox.Show("Deseas pasar los archivos a - OnBase", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If dtTipo = 0 Then
                    ProcesarInterfacePagina()
                    '_threadProceso = New Thread(New ThreadStart(AddressOf ProcesarInterfacePagina))
                Else
                    ProcesarInterfaceEdicion()
                    '_threadProceso = New Thread(New ThreadStart(AddressOf ProcesarInterfaceEdicion))
                End If
                '_threadProceso.Start()
            End If
        Else
            MsgBox("No existe datos, con los campos seleccionados", MsgBoxStyle.Exclamation, "Aviso")
        End If
    End Sub

    Public Function DesencriptarCadena(ByVal pstrCadena) As String
        Try
            Dim strCadCon As String
            Dim obj As New Encryption64
            Dim strPalabraClave As String = "gespo_05"

            strCadCon = obj.DecryptFromBase64String(pstrCadena, strPalabraClave)

            Return strCadCon

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub cerrarHilo()
        Try
            If _threadProceso.IsAlive Then
                _threadProceso.Abort()
            End If

        Catch ex As Exception
        End Try
    End Sub

    'Delegate Sub SetTextCallback(ByVal [text] As String)
    Private Sub LimpiarDatos()
        Me.ProgressBar1.Value = Me.ProgressBar1.Minimum
        Me.lblProceso.Text = ""
        Me.lblTituloProceso.Text = ""
    End Sub

End Class