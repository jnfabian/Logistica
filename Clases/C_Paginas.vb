Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Public Class C_Paginas
    Public conexion As New C_Conexion
    Public str_cnx As String = conexion.CadenaConexion
    Public carpetaP As String = Configuration.ConfigurationSettings.AppSettings("carpetaP")
    Dim Da As SqlDataAdapter
    Dim ds As New DataSet
    Public Property inicio% = 0
    Public Property final% = 100
    Dim aumento% = 100
    Dim resultado As Boolean = vbTrue
    Dim total As Double




    Public Function CargarDatos(ByVal Flat As Integer, ByVal CodEmpaste As String, ByVal CodDetalleEmpaste As String, ByVal TipoEmpaste As Integer) As DataTable
        Dim DatoTable As New DataTable
        Dim SQLConexion As New SqlConnection(str_cnx)
        SQLConexion.Open()
        Dim SQLComando As New SqlCommand("SP_Frm_Pagina_CargarDatos", SQLConexion)
        SQLComando.CommandType = CommandType.StoredProcedure
        SQLComando.Parameters.Add("@Flat", SqlDbType.Int).Value = Flat
        SQLComando.Parameters.Add("@CodEmpaste", SqlDbType.VarChar, 11).Value = CodEmpaste
        SQLComando.Parameters.Add("@CodDetalleEmpaste", SqlDbType.VarChar, 18).Value = CodDetalleEmpaste 'de 15 a 18
        SQLComando.Parameters.Add("@TipoEmpaste", SqlDbType.Int).Value = TipoEmpaste
        Dim Da As New SqlDataAdapter
        Da.SelectCommand = SQLComando
        Da.Fill(DatoTable)
        Return DatoTable
        SQLConexion.Close()
        SQLConexion.Dispose()
        SQLComando.Dispose()
    End Function
    Public Function Gestionar_Pagina(ByVal Flat As Integer, ByVal S_CodAuxPagina As String, ByVal S_CodEmpaste As String, ByVal S_CodDetalleEmpaste As String, ByVal I_TipoEmpaste As Integer, ByVal S_CodPagina As String, ByVal I_NumPag As Integer, ByVal S_Completo As String, ByVal S_Incompleto As String, ByVal S_Roto As String, ByVal S_Manchado As String, ByVal S_Falta As String, ByVal S_Dificultad As String, ByVal S_Obser As String, ByVal S_Creador As String, ByVal S_NumTomo As String) As Integer
        Try
            Dim SQLConexion As New SqlConnection(str_cnx)
            SQLConexion.Open()
            Dim SQLComando As New SqlCommand("SP_Frm_Pagina_GestionarDatos", SQLConexion)
            SQLComando.CommandType = CommandType.StoredProcedure
            SQLComando.Parameters.Add("@Flat", SqlDbType.Int).Value = Flat
            SQLComando.Parameters.Add("@StrinCodAuxPagina", SqlDbType.VarChar, 25).Value = S_CodAuxPagina 'de 19 a 25
            SQLComando.Parameters.Add("@StringCodEmpaste", SqlDbType.VarChar, 11).Value = S_CodEmpaste
            SQLComando.Parameters.Add("@StringCodDetalleEmpaste", SqlDbType.VarChar, 18).Value = S_CodDetalleEmpaste
            SQLComando.Parameters.Add("@IntTipoDetalle", SqlDbType.Int).Value = I_TipoEmpaste
            SQLComando.Parameters.Add("@StrinCodPagina", SqlDbType.VarChar, 25).Value = S_CodPagina
            SQLComando.Parameters.Add("@IntNumPag", SqlDbType.Int).Value = I_NumPag
            SQLComando.Parameters.Add("@StringCompleto", SqlDbType.VarChar, 2).Value = S_Completo
            SQLComando.Parameters.Add("@StringIncompleto", SqlDbType.VarChar, 2).Value = S_Incompleto
            SQLComando.Parameters.Add("@StringRoto", SqlDbType.VarChar, 2).Value = S_Roto
            SQLComando.Parameters.Add("@StringManchado", SqlDbType.VarChar, 2).Value = S_Manchado
            SQLComando.Parameters.Add("@StringFalta", SqlDbType.VarChar, 2).Value = S_Falta
            SQLComando.Parameters.Add("@StringDificultad", SqlDbType.VarChar, 2).Value = S_Dificultad
            SQLComando.Parameters.Add("@StringObservaciones", SqlDbType.VarChar, 2000).Value = S_Obser
            SQLComando.Parameters.Add("@StringCreador", SqlDbType.VarChar, 16).Value = S_Creador
            SQLComando.Parameters.Add("@StringNumTomo", SqlDbType.VarChar, 6).Value = S_NumTomo
            Dim ValorDevuelto = SQLComando.ExecuteScalar
            SQLConexion.Close()
            SQLConexion.Dispose()
            SQLComando.Dispose()
            Return ValorDevuelto
        Catch ex As Exception
            MsgBox("El registro ya existe", MsgBoxStyle.Information, "Editora")
        End Try
    End Function

    Public Function Gestionar_Pagina_RetCad(ByVal Flat As Integer, ByVal S_CodAuxPagina As String, ByVal S_CodEmpaste As String, ByVal S_CodDetalleEmpaste As String, ByVal I_TipoEmpaste As Integer, ByVal S_CodPagina As String, ByVal I_NumPag As Integer, ByVal S_Completo As String, ByVal S_Incompleto As String, ByVal S_Roto As String, ByVal S_Manchado As String, ByVal S_Falta As String, ByVal S_Dificultad As String, ByVal S_Obser As String, ByVal S_Creador As String, ByVal S_NumTomo As String)
        Try
            Dim SQLConexion As New SqlConnection(str_cnx)
            SQLConexion.Open()
            Dim SQLComando As New SqlCommand("SP_Frm_Pagina_GestionarDatos", SQLConexion)
            SQLComando.CommandType = CommandType.StoredProcedure
            SQLComando.Parameters.Add("@Flat", SqlDbType.Int).Value = Flat
            SQLComando.Parameters.Add("@StrinCodAuxPagina", SqlDbType.VarChar, 25).Value = S_CodAuxPagina 'de 19 a 25
            SQLComando.Parameters.Add("@StringCodEmpaste", SqlDbType.VarChar, 11).Value = S_CodEmpaste
            SQLComando.Parameters.Add("@StringCodDetalleEmpaste", SqlDbType.VarChar, 18).Value = S_CodDetalleEmpaste
            SQLComando.Parameters.Add("@IntTipoDetalle", SqlDbType.Int).Value = I_TipoEmpaste
            SQLComando.Parameters.Add("@StrinCodPagina", SqlDbType.VarChar, 25).Value = S_CodPagina
            SQLComando.Parameters.Add("@IntNumPag", SqlDbType.Int).Value = I_NumPag
            SQLComando.Parameters.Add("@StringCompleto", SqlDbType.VarChar, 2).Value = S_Completo
            SQLComando.Parameters.Add("@StringIncompleto", SqlDbType.VarChar, 2).Value = S_Incompleto
            SQLComando.Parameters.Add("@StringRoto", SqlDbType.VarChar, 2).Value = S_Roto
            SQLComando.Parameters.Add("@StringManchado", SqlDbType.VarChar, 2).Value = S_Manchado
            SQLComando.Parameters.Add("@StringFalta", SqlDbType.VarChar, 2).Value = S_Falta
            SQLComando.Parameters.Add("@StringDificultad", SqlDbType.VarChar, 2).Value = S_Dificultad
            SQLComando.Parameters.Add("@StringObservaciones", SqlDbType.VarChar, 2000).Value = S_Obser
            SQLComando.Parameters.Add("@StringCreador", SqlDbType.VarChar, 16).Value = S_Creador
            SQLComando.Parameters.Add("@StringNumTomo", SqlDbType.VarChar, 6).Value = S_NumTomo
            Dim ValorDevuelto = SQLComando.ExecuteScalar
            SQLConexion.Close()
            SQLConexion.Dispose()
            SQLComando.Dispose()
            Return ValorDevuelto
        Catch ex As Exception
            MsgBox("El registro ya existe", MsgBoxStyle.Information, "Editora")
        End Try
    End Function

    Public Function BuscarPagina(ByVal Flat As Integer, ByVal StringCodEmpaste As String, ByVal StringCodEdicion As String, ByVal IntTipo As Integer, ByVal StringCodPagina As String)
        Dim SQLConexion As New SqlConnection(str_cnx)
        SQLConexion.Open()
        Dim SQLComando As New SqlCommand("SP_Frm_Pagina_Buscar", SQLConexion)
        SQLComando.CommandType = CommandType.StoredProcedure
        SQLComando.Parameters.Add("@Flat", SqlDbType.Int).Value = Flat
        SQLComando.Parameters.Add("@CodEmpaste", SqlDbType.VarChar, 11).Value = StringCodEmpaste
        SQLComando.Parameters.Add("@CodDetalleEmpaste", SqlDbType.VarChar, 18).Value = StringCodEdicion
        SQLComando.Parameters.Add("@TipoEmpaste", SqlDbType.Int).Value = IntTipo
        SQLComando.Parameters.Add("@CodPagina", SqlDbType.VarChar, 25).Value = StringCodPagina 'de 19 a 25
        Dim ValorDevuelto = SQLComando.ExecuteScalar
        SQLConexion.Close()
        SQLConexion.Dispose()
        SQLComando.Dispose()
        Return ValorDevuelto
    End Function

    Public Sub DigitalizarPaginas(ByVal codigoPagina As String, ByVal tipo As Integer, ByVal nombreImagen As String, ByVal usuario As String)
        Dim SQLConexion As New SqlConnection(str_cnx)
        SQLConexion.Open()
        Dim SQLComando As New SqlCommand("SP_Frm_Pagina_ActualizarImagen", SQLConexion)
        SQLComando.CommandType = CommandType.StoredProcedure
        SQLComando.Parameters.Add("@CodPagina", SqlDbType.NVarChar, 25).Value = codigoPagina
        SQLComando.Parameters.Add("@numTipo", SqlDbType.Int).Value = tipo
        SQLComando.Parameters.Add("@NombreImagen", SqlDbType.NVarChar, 250).Value = nombreImagen
        SQLComando.Parameters.Add("@usuario", SqlDbType.VarChar, 20).Value = usuario

        SQLComando.ExecuteNonQuery()
        SQLConexion.Close()
        SQLConexion.Dispose()
        SQLComando.Dispose()
    End Sub

    Public Sub PasarPaginasQA(ByVal flat As Integer, ByVal codigoPagina As String, ByVal tipo As Integer, ByVal codIncidencia As Integer, ByVal usuario As String)
        Dim SQLConexion As New SqlConnection(str_cnx)
        SQLConexion.Open()
        Dim SQLComando As New SqlCommand("SP_Frm_Pagina_PasarQA", SQLConexion)
        SQLComando.CommandType = CommandType.StoredProcedure
        SQLComando.Parameters.Add("@flat", SqlDbType.Int).Value = flat
        SQLComando.Parameters.Add("@CodPagina", SqlDbType.NVarChar, 25).Value = codigoPagina
        SQLComando.Parameters.Add("@numTipo", SqlDbType.Int).Value = tipo
        SQLComando.Parameters.Add("@codIncidencia", SqlDbType.Int).Value = codIncidencia
        SQLComando.Parameters.Add("@usuario", SqlDbType.VarChar, 20).Value = usuario

        SQLComando.ExecuteNonQuery()
        SQLConexion.Close()
        SQLConexion.Dispose()
        SQLComando.Dispose()
    End Sub

    Public Function BuscarPaginaPorAprobar(ByVal Flat As Integer, ByVal StringCodPagina As String, ByVal StringCodEdicion As String, ByVal StringCodEmpaste As String, ByVal tipo As Integer)
        Dim DatoTable As New DataTable
        Dim SQLConexion As New SqlConnection(str_cnx)
        SQLConexion.Open()
        Dim SQLComando As New SqlCommand("SP_Frm_Pagina_BuscarPorAprobar", SQLConexion)
        SQLComando.CommandType = CommandType.StoredProcedure
        SQLComando.Parameters.Add("@Flat", SqlDbType.Int).Value = Flat
        SQLComando.Parameters.Add("@CodEmpaste", SqlDbType.VarChar, 11).Value = StringCodEmpaste
        SQLComando.Parameters.Add("@CodDetalleEmpaste", SqlDbType.VarChar, 18).Value = StringCodEdicion
        SQLComando.Parameters.Add("@CodPagina", SqlDbType.VarChar, 25).Value = StringCodPagina 'de 19 a 25
        SQLComando.Parameters.Add("@TipoEmpaste", SqlDbType.Int).Value = tipo
        Da = New SqlDataAdapter
        Da.SelectCommand = SQLComando
        ds.Clear()
        Da.Fill(ds, "ListadoPaginas")
        Return ds.Tables("ListadoPaginas")
        SQLConexion.Close()
        SQLConexion.Dispose()
        SQLComando.Dispose()
    End Function
    Public Function Listado() As DataTable
        inicio = 0
        Da.Fill(ds, inicio, aumento, "Listado")
        Return ds.Tables("Listado")
    End Function
    Public Function Siguiente(ByVal valor As Double) As Boolean
        total = valor
        inicio += aumento
        If inicio < total Then
            final += aumento
            If final > Convert.ToInt32(total) Then
                ds.Clear()
                Da.Fill(ds, inicio, total - inicio, "Listado")
                resultado = vbFalse
            Else
                ds.Clear()
                Da.Fill(ds, inicio, aumento, "Listado")
                resultado = vbTrue
            End If
        Else
            resultado = vbFalse
        End If
        Return resultado
    End Function
    Public Function Atras(ByVal valor As Integer) As Boolean
        inicio -= aumento
        'final -= aumento
        'ds.Clear()
        'Da.Fill(ds, inicio, aumento, "Listado")
        'If inicio = 0 Then
        '    resultado = vbFalse
        'End If
        'Return resultado

        If resultado = vbFalse Then
            final = total - valor
            ds.Clear()
            Da.Fill(ds, inicio, aumento, "Listado")
            resultado = vbTrue
        Else
            final -= aumento
            ds.Clear()
            Da.Fill(ds, inicio, aumento, "Listado")
            resultado = vbTrue
        End If
        If inicio = 0 Then
            resultado = vbFalse
        End If
        Return resultado

    End Function
  

    Public Sub PasarPaginasFinal(ByVal codigoPagina As String, ByVal tipo As Integer, ByVal usuario As String)
        Dim SQLConexion As New SqlConnection(str_cnx)
        SQLConexion.Open()
        Dim SQLComando As New SqlCommand("SP_Frm_Pagina_PasarFinal", SQLConexion)
        SQLComando.CommandType = CommandType.StoredProcedure
        SQLComando.Parameters.Add("@CodPagina", SqlDbType.NVarChar, 25).Value = codigoPagina
        SQLComando.Parameters.Add("@numTipo", SqlDbType.Int).Value = tipo
        SQLComando.Parameters.Add("@usuario", SqlDbType.VarChar, 20).Value = usuario

        Dim ValorDevuelto As Integer = SQLComando.ExecuteNonQuery()
        SQLConexion.Close()
        SQLConexion.Dispose()
        SQLComando.Dispose()
    End Sub
    Public Sub PasarPaginasReproceso(ByVal codigoPagina As String, ByVal tipo As Integer, _
                                     ByVal tipoIncidencia As String, ByVal desc As String, ByVal usuario As String)
        Dim SQLConexion As New SqlConnection(str_cnx)
        SQLConexion.Open()
        Dim SQLComando As New SqlCommand("SP_Frm_Pagina_PasarReproceso", SQLConexion)
        SQLComando.CommandType = CommandType.StoredProcedure
        SQLComando.Parameters.Add("@CodPagina", SqlDbType.NVarChar, 25).Value = codigoPagina
        SQLComando.Parameters.Add("@numTipo", SqlDbType.Int).Value = tipo
        SQLComando.Parameters.Add("@tipoIncidencia", SqlDbType.Char).Value = tipoIncidencia
        SQLComando.Parameters.Add("@desc", SqlDbType.NVarChar).Value = desc
        SQLComando.Parameters.Add("@usuario", SqlDbType.VarChar, 20).Value = usuario

        Dim ValorDevuelto As Integer = SQLComando.ExecuteNonQuery()
        SQLConexion.Close()
        SQLConexion.Dispose()
        SQLComando.Dispose()
    End Sub


    Public Sub EliminarRegistroRechazado(ByVal codigoPagina As String)
        Dim sqlconexion As New SqlConnection(str_cnx)
        sqlconexion.Open()
        Dim sqlcomando As New SqlCommand("SP_Frm_eliminarRegistroRechazado", sqlconexion)
        sqlcomando.Parameters.AddWithValue("@codigoPagina", codigoPagina)
        sqlcomando.CommandType = CommandType.StoredProcedure

        sqlcomando.ExecuteNonQuery()
        sqlconexion.Close()
        sqlconexion.Dispose()
        sqlcomando.Dispose()

    End Sub

    Public Function getTiposDocumento() As DataTable
        Dim SQLConexion As New SqlConnection(str_cnx)
        SQLConexion.Open()
        Dim SQLComando As New SqlCommand("SP_Frm_Pagina_CargarTipos", SQLConexion)
        SQLComando.CommandType = CommandType.StoredProcedure

        Dim DatoTable As New DataTable
        Dim Da As New SqlDataAdapter
        Da.SelectCommand = SQLComando
        Da.Fill(DatoTable)

        SQLConexion.Close()
        SQLConexion.Dispose()
        SQLComando.Dispose()

        Return DatoTable
    End Function

    Public Function actualizarEstadoOnbase(ByVal codigoPagina As String, ByVal tipo As Int16) As DataTable
        Dim SQLConexion As New SqlConnection(str_cnx)
        SQLConexion.Open()
        Dim SQLComando As New SqlCommand("SP_Frm_Pagina_ActualizarEstadoOnbase", SQLConexion)
        SQLComando.CommandType = CommandType.StoredProcedure
        SQLComando.Parameters.Add("@codPagina", SqlDbType.NVarChar, 25).Value = codigoPagina
        SQLComando.Parameters.Add("@tipo", SqlDbType.Int).Value = tipo
        Dim DatoTable As New DataTable
        Dim Da As New SqlDataAdapter
        Da.SelectCommand = SQLComando
        Da.Fill(DatoTable)

        SQLConexion.Close()
        SQLConexion.Dispose()
        SQLComando.Dispose()

        Return DatoTable
    End Function

    Public Sub RegistrarExcel(ByVal nombre As String, ByVal ruta As String)
        Dim cn As New SqlConnection("server=sw-desasrv;uid=sa;pwd=12345678;database=Directorio")
        Dim cmd As New SqlCommand("RegistrarExcel", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@nombre", nombre)
        cmd.Parameters.AddWithValue("@ruta", ruta)
        Try
            cn.Open()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        End Try
        cmd.Dispose()
        cn.Dispose()
    End Sub

    Public Sub RegistraEx(ByVal op As String, ByVal item As String, ByVal valor As String)
        Dim cn As New SqlConnection("server=sw-desasrv;uid=sa;pwd=12345678;database=Directorio")
        Dim cmd As New SqlCommand("Usp_Registrar_Excel", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@op", op)
        cmd.Parameters.AddWithValue("@item", item)
        cmd.Parameters.AddWithValue("@valor", valor)
        Try
            cn.Open()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        End Try
        cmd.Dispose()
        cn.Dispose()
    End Sub

    Public Sub insertarCabecera(ByVal x As CabeceraDao, ByVal tablita As DataTable)
        Dim kit As Integer
        Try
            Dim cn As New SqlConnection("server=sw-desasrv;uid=sa;pwd=12345678;database=Directorio")
            cn.Open()
            Dim tr As SqlTransaction = cn.BeginTransaction
            Dim cmd As New SqlCommand("Usp_Registra_Cabecera", cn, tr)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@fecha", x.fechaCarga)
            cmd.Parameters.AddWithValue("@usuario", x.usuario)
            cmd.Parameters.AddWithValue("@ruta", x.ruta)
            cmd.Parameters.Add("@idCarga", SqlDbType.Int).Direction = ParameterDirection.Output

            kit = cmd.ExecuteNonQuery()
            x.idCarga = cmd.Parameters("@idCarga").Value
            If (kit = 0) Then
                MsgBox("Error al grabar")
                'detener la transaccion
                tr.Rollback()
            Else

                'Volver el ID del detalle a 0
                'variables para estado y la observacion
                Dim estado As Integer
                Dim observacion As String = ""
                'grabamos el detalle
                cmd.CommandText = "Usp_Registra_Detalle"

                'validamos la el estado de kada fila si es 1 o si es 2
                For Each fila As DataRow In tablita.Rows
                    observacion = ""
                    'Dim op As String = fila(0)
                    'Dim item As String = fila(1)
                    'Dim valor As String = fila(2)
                    'Dim correl As Integer

                    If (CStr(IsDBNull(fila(0)))) = True And (CStr(IsDBNull(fila(1)))) = True Then
                        Continue For
                    End If
                    If (CStr((IsDBNull(fila(0))))) Then
                        observacion += "'OP' con valor nulo"
                        fila(0) = ""
                    ElseIf Not (IsNumeric(fila(0))) Then
                        observacion += "'OP' no es numerico "
                    End If

                    If (CStr(IsDBNull(fila(1)))) Then
                        observacion += "'ITEM' con valor nulo "
                        fila(1) = ""
                    ElseIf Not (IsNumeric(fila(1))) Then
                        observacion += "'ITEM' no es numerico"
                    End If

                    estado = ValidarEstado(fila(0), fila(1))

                    'limpiamos los parametros de cada fila
                    cmd.Parameters.Clear()

                    cmd.Parameters.Add(New SqlParameter("@idCarga", SqlDbType.Int))
                    cmd.Parameters("@idCarga").Direction = ParameterDirection.Input
                    cmd.Parameters("@idCarga").Value = x.idCarga

                    cmd.Parameters.Add(New SqlParameter("@op", SqlDbType.VarChar, 40))
                    cmd.Parameters("@op").Direction = ParameterDirection.Input
                    cmd.Parameters("@op").Value = fila(0)

                    cmd.Parameters.Add(New SqlParameter("@item", SqlDbType.VarChar, 40))
                    cmd.Parameters("@item").Direction = ParameterDirection.Input
                    cmd.Parameters("@item").Value = fila(1)

                    cmd.Parameters.Add(New SqlParameter("@valor", SqlDbType.VarChar, 40))
                    cmd.Parameters("@valor").Direction = ParameterDirection.Input
                    cmd.Parameters("@valor").Value = fila(2)

                    cmd.Parameters.Add(New SqlParameter("@estado", SqlDbType.VarChar, 40))
                    cmd.Parameters("@estado").Direction = ParameterDirection.Input
                    cmd.Parameters("@estado").Value = estado

                    cmd.Parameters.Add(New SqlParameter("@observacion", SqlDbType.VarChar, 100))
                    cmd.Parameters("@observacion").Direction = ParameterDirection.Input
                    cmd.Parameters("@observacion").Value = observacion

                    ' cmd.Parameters.Add(New SqlParameter("@idCorrel", SqlDbType.Int)).Direction = ParameterDirection.Output
                    'correl = cmd.Parameters("@idCorrel").Direction

                    'ejecumtamos el comando
                    kit = cmd.ExecuteNonQuery
                    If kit = 0 Then
                        tr.Rollback()
                        MsgBox("Error al grabar en el detalle")
                    End If
                Next
                tr.Commit()
                MsgBox("se grabo correctamente")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function ValidarEstado(ByVal op As String, ByVal item As String) As Integer
        Dim estado As Integer

        If (IsNumeric(op.ToString) And IsNumeric(item.ToString)) Then
            estado = 1
        Else
            estado = 2
        End If

        Return estado
    End Function

End Class
