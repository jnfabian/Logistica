Imports System.Data
Imports System.Data.SqlClient
Public Class C_Edicion
    Public conexion As New C_Conexion
    Public str_cnx As String = conexion.CadenaConexion
    Public Function CargarDatos(ByVal Flat As Integer, ByVal CodIdentificacion As String, ByVal Observacion As String) As DataTable
        Dim DatoTable As New DataTable
        Dim SQLConexion As New SqlConnection(str_cnx)
        SQLConexion.Open()
        Dim SQLComando As New SqlCommand("SP_Frm_Edicion_CargarDatos", SQLConexion)
        SQLComando.CommandType = CommandType.StoredProcedure
        SQLComando.Parameters.Add("@Flat", SqlDbType.Int).Value = Flat
        SQLComando.Parameters.Add("@CodIdentificacion", SqlDbType.VarChar, 18).Value = CodIdentificacion
        SQLComando.Parameters.Add("@Observacion", SqlDbType.VarChar, 2000).Value = Observacion
        Dim Da As New SqlDataAdapter
        Da.SelectCommand = SQLComando
        Da.Fill(DatoTable)
        Return DatoTable
        SQLConexion.Close()
        SQLConexion.Dispose()
        SQLComando.Dispose()
    End Function
    Public Function Gestionar_Edicion(ByVal Flat As Integer, ByVal StringCodEmpaste As String, ByVal StringCodEdicionAux As String, ByVal StringCodEdicion As String, ByVal IntTipo As Integer, ByVal StringNumEdicion As String, ByVal IntNumPaginas As Integer, ByVal FechaEdicion As DateTime, ByVal StringDirector As String, ByVal StringPagFaltantes As String, ByVal StringBueno As String, ByVal StringDelgado As String, ByVal StringGrueso As String, ByVal StringDeteriorado As String, ByVal StringObservaciones As String, ByVal StringCreador As String, ByVal StringTitulo As String, ByVal StringSubtitulo As String)
        Dim SQLConexion As New SqlConnection(str_cnx)
        SQLConexion.Open()
        Dim SQLComando As New SqlCommand("SP_Frm_Edicion_GestionarDatos", SQLConexion)
        SQLComando.CommandType = CommandType.StoredProcedure
        SQLComando.Parameters.Add("@Flat", SqlDbType.Int).Value = Flat
        SQLComando.Parameters.Add("@StringCodEmpaste", SqlDbType.VarChar, 11).Value = StringCodEmpaste
        SQLComando.Parameters.Add("@StringCodEdicionAux", SqlDbType.VarChar, 18).Value = StringCodEdicionAux 'de 15 a 18
        SQLComando.Parameters.Add("@StringCodEdicion", SqlDbType.VarChar, 18).Value = StringCodEdicion 'se cambio de 15 a 18
        SQLComando.Parameters.Add("@IntTipo", SqlDbType.Int).Value = IntTipo
        SQLComando.Parameters.Add("@StringNumEdicion", SqlDbType.VarChar, 6).Value = StringNumEdicion ' se cambio de 3 a 6
        SQLComando.Parameters.Add("@IntNumPaginas", SqlDbType.Int).Value = IntNumPaginas
        SQLComando.Parameters.Add("@FechaEdicion", SqlDbType.DateTime).Value = FechaEdicion
        SQLComando.Parameters.Add("@StringDirector", SqlDbType.VarChar, 256).Value = StringDirector
        SQLComando.Parameters.Add("@StringPagFaltantes", SqlDbType.VarChar, 200).Value = StringPagFaltantes
        SQLComando.Parameters.Add("@StringBueno", SqlDbType.VarChar, 2).Value = StringBueno
        SQLComando.Parameters.Add("@StringDelgado", SqlDbType.VarChar, 2).Value = StringDelgado
        SQLComando.Parameters.Add("@StringGrueso", SqlDbType.VarChar, 2).Value = StringGrueso
        SQLComando.Parameters.Add("@StringDeteriorado", SqlDbType.VarChar, 2).Value = StringDeteriorado
        SQLComando.Parameters.Add("@StringObservaciones", SqlDbType.VarChar, 2000).Value = StringObservaciones 'se cambio de 900 a 2000
        SQLComando.Parameters.Add("@StringCreador", SqlDbType.VarChar, 16).Value = StringCreador
        SQLComando.Parameters.Add("@StringNombreEdicion", SqlDbType.NVarChar, 250).Value = StringTitulo
        SQLComando.Parameters.Add("@StringSubtituloEdicion", SqlDbType.NVarChar, 250).Value = StringSubtitulo

        Dim ValorDevuelto = SQLComando.ExecuteScalar
        SQLConexion.Close()
        SQLConexion.Dispose()
        SQLComando.Dispose()
        Return ValorDevuelto
    End Function
    Public Function BuscarEdicion(ByVal Flat As Integer, ByVal StringCodEmpaste As String, ByVal StringCodEdicion As String, ByVal IntTipo As Integer)
        Dim SQLConexion As New SqlConnection(str_cnx)
        SQLConexion.Open()
        Dim SQLComando As New SqlCommand("SP_Frm_Edicion_Buscar", SQLConexion)
        SQLComando.CommandType = CommandType.StoredProcedure
        SQLComando.Parameters.Add("@Flat", SqlDbType.Int).Value = Flat
        SQLComando.Parameters.Add("@StringCodEmpaste", SqlDbType.VarChar, 11).Value = StringCodEmpaste
        SQLComando.Parameters.Add("@StringCodEdicion", SqlDbType.VarChar, 18).Value = StringCodEdicion
        SQLComando.Parameters.Add("@IntTipo", SqlDbType.Int).Value = IntTipo
        Dim ValorDevuelto = SQLComando.ExecuteScalar
        SQLConexion.Close()
        SQLConexion.Dispose()
        SQLComando.Dispose()
        Return ValorDevuelto
    End Function

    Public Function Cambiar_Tipo(ByVal numtipo As Integer, ByVal StringCodEdicion As String)
        'NEN para llamar al proc, lo llamo directamente desde el boton y conparo desde la BD
        Dim SQLConexion As New SqlConnection(str_cnx)
        SQLConexion.Open()
        Dim SQLComando As New SqlCommand("SP_Frm_DetalleEdicion_CambioTipo", SQLConexion)
        SQLComando.CommandType = CommandType.StoredProcedure
        SQLComando.Parameters.Add("@numTipo", SqlDbType.Int).Value = numtipo
        SQLComando.Parameters.Add("@StringCodEdicion", SqlDbType.VarChar, 18).Value = StringCodEdicion
        Dim ValorDevuelto = SQLComando.ExecuteScalar
        SQLConexion.Close()
        SQLConexion.Dispose()
        SQLComando.Dispose()
        Return ValorDevuelto

    End Function

    Public Sub DigitalizarEdicionPDF(ByVal codigoEdicion As String, ByVal tipo As Integer, ByVal nombrePDF As String, ByVal usuario As String)
        Dim SQLConexion As New SqlConnection(str_cnx)
        SQLConexion.Open()
        Dim SQLComando As New SqlCommand("SP_Frm_Edicion_ActualizarPDF", SQLConexion)
        SQLComando.CommandType = CommandType.StoredProcedure
        SQLComando.Parameters.Add("@CodEdicion", SqlDbType.NVarChar, 25).Value = codigoEdicion
        SQLComando.Parameters.Add("@numTipo", SqlDbType.Int).Value = tipo
        SQLComando.Parameters.Add("@NombrePDF", SqlDbType.NVarChar, 250).Value = nombrePDF
        SQLComando.Parameters.Add("@usuario", SqlDbType.VarChar, 20).Value = usuario

        Dim ValorDevuelto As Integer = SQLComando.ExecuteNonQuery()
        SQLConexion.Close()
        SQLConexion.Dispose()
        SQLComando.Dispose()
    End Sub

    Public Sub PasarEdicionesQA(ByVal flat As Integer, ByVal codigoEdicion As String, ByVal tipo As Integer, ByVal codigoIncidencia As Integer, ByVal usuario As String)
        Dim SQLConexion As New SqlConnection(str_cnx)
        SQLConexion.Open()
        Dim SQLComando As New SqlCommand("SP_Frm_Edicion_PasarQA", SQLConexion)
        SQLComando.CommandType = CommandType.StoredProcedure
        SQLComando.Parameters.Add("@flat", SqlDbType.NVarChar, 25).Value = flat
        SQLComando.Parameters.Add("@CodEdicion", SqlDbType.NVarChar, 25).Value = codigoEdicion
        SQLComando.Parameters.Add("@numTipo", SqlDbType.Int).Value = tipo
        SQLComando.Parameters.Add("@codIncidencia", SqlDbType.Int).Value = codigoIncidencia
        SQLComando.Parameters.Add("@usuario", SqlDbType.VarChar, 20).Value = usuario

        Dim ValorDevuelto As Integer = SQLComando.ExecuteNonQuery()
        SQLConexion.Close()
        SQLConexion.Dispose()
        SQLComando.Dispose()
    End Sub

    Public Function BuscarPdfPorAprobar(ByVal Flat As Integer, ByVal StringCodEdicion As String, ByVal StringCodEmpaste As String, ByVal tipo As Integer)
        Dim DatoTable As New DataTable
        Dim SQLConexion As New SqlConnection(str_cnx)
        SQLConexion.Open()
        Dim SQLComando As New SqlCommand("SP_Frm_Edicion_BuscarPorAprobar", SQLConexion)
        SQLComando.CommandType = CommandType.StoredProcedure
        SQLComando.Parameters.Add("@Flat", SqlDbType.Int).Value = Flat
        SQLComando.Parameters.Add("@CodEmpaste", SqlDbType.VarChar, 11).Value = StringCodEmpaste
        SQLComando.Parameters.Add("@CodDetalleEmpaste", SqlDbType.VarChar, 18).Value = StringCodEdicion
        SQLComando.Parameters.Add("@TipoEmpaste", SqlDbType.Int).Value = tipo
        Dim Da As New SqlDataAdapter
        Da.SelectCommand = SQLComando
        Da.Fill(DatoTable)
        Return DatoTable
        SQLConexion.Close()
        SQLConexion.Dispose()
        SQLComando.Dispose()
    End Function

    Public Sub PasarEdicionesFinal(ByVal codigoEdicion As String, ByVal tipo As Integer, ByVal usuario As String)
        Dim SQLConexion As New SqlConnection(str_cnx)
        SQLConexion.Open()
        Dim SQLComando As New SqlCommand("SP_Frm_Edicion_PasarFinal", SQLConexion)
        SQLComando.CommandType = CommandType.StoredProcedure
        SQLComando.Parameters.Add("@CodEdicion", SqlDbType.NVarChar, 25).Value = codigoEdicion
        SQLComando.Parameters.Add("@numTipo", SqlDbType.Int).Value = tipo
        SQLComando.Parameters.Add("@usuario", SqlDbType.VarChar, 20).Value = usuario

        Dim ValorDevuelto As Integer = SQLComando.ExecuteNonQuery()
        SQLConexion.Close()
        SQLConexion.Dispose()
        SQLComando.Dispose()
    End Sub

    Public Sub PasarEdicionesReproceso(ByVal codigoEdicion As String, ByVal tipo As Integer, _
                                     ByVal tipoIncidencia As String, ByVal desc As String, ByVal usuario As String)
        Dim SQLConexion As New SqlConnection(str_cnx)
        SQLConexion.Open()
        Dim SQLComando As New SqlCommand("SP_Frm_Edicion_PasarReproceso", SQLConexion)
        SQLComando.CommandType = CommandType.StoredProcedure
        SQLComando.Parameters.Add("@CodEdicion", SqlDbType.NVarChar, 25).Value = codigoEdicion
        SQLComando.Parameters.Add("@numTipo", SqlDbType.Int).Value = tipo
        SQLComando.Parameters.Add("@tipoIncidencia", SqlDbType.Char).Value = tipoIncidencia
        SQLComando.Parameters.Add("@desc", SqlDbType.NVarChar).Value = desc
        SQLComando.Parameters.Add("@usuario", SqlDbType.VarChar, 20).Value = usuario

        Dim ValorDevuelto As Integer = SQLComando.ExecuteNonQuery()
        SQLConexion.Close()
        SQLConexion.Dispose()
        SQLComando.Dispose()
    End Sub

    Public Function actualizarEstadoOnbase(ByVal codigoEdicion As String, ByVal tipo As Int16) As DataTable
        Dim SQLConexion As New SqlConnection(str_cnx)
        SQLConexion.Open()
        Dim SQLComando As New SqlCommand("SP_Frm_Edicion_ActualizarEstadoOnbase", SQLConexion)
        SQLComando.CommandType = CommandType.StoredProcedure
        SQLComando.Parameters.Add("@codEdicion", SqlDbType.VarChar, 18).Value = codigoEdicion
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

    Public Function EliminarRegistroRechazadosPDF(ByVal codigo As String, ByVal tipoDocumento As String)
        Dim SQLConexion As New SqlConnection(str_cnx)
        SQLConexion.Open()
        Dim SQLComando As New SqlCommand("SP_Frm_EliminarRegistrosRechazadosPDF", SQLConexion)
        SQLComando.CommandType = CommandType.StoredProcedure
        SQLComando.Parameters.Add("@codigo", SqlDbType.NVarChar, 50).Value = codigo
        SQLComando.Parameters.Add("@tipoDocumento", SqlDbType.NVarChar, 50).Value = tipoDocumento
        SQLComando.ExecuteNonQuery()
        SQLConexion.Close()
        SQLConexion.Dispose()
        SQLComando.Dispose()
        'Dim px As String = ""
        'Return px
    End Function
End Class
