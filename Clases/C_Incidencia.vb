Imports System.Data
Imports System.Data.SqlClient
Public Class C_Incidencia
    Public conexion As New C_Conexion
    Public str_cnx As String = conexion.CadenaConexion

    Public Function CargarTiposIncidencia(ByVal tipoDocumento As String) As DataTable
        Dim DatoTable As New DataTable
        Dim SQLConexion As New SqlConnection(str_cnx)
        SQLConexion.Open()
        Dim SQLComando As New SqlCommand("SP_Frm_Incidencia_Tipos", SQLConexion)
        SQLComando.CommandType = CommandType.StoredProcedure
        SQLComando.Parameters.Add("@tipoDocumento", SqlDbType.NVarChar).Value = tipoDocumento
        Dim Da As New SqlDataAdapter
        Da.SelectCommand = SQLComando
        Da.Fill(DatoTable)
        Return DatoTable
        SQLConexion.Close()
        SQLConexion.Dispose()
        SQLComando.Dispose()
    End Function

    Public Function getIncidenciaByCodigo(ByVal codigo As Integer) As DataTable
        Dim DatoTable As New DataTable
        Dim SQLConexion As New SqlConnection(str_cnx)
        SQLConexion.Open()
        Dim SQLComando As New SqlCommand("SP_Frm_Incidencia_ObtenerIncidencia", SQLConexion)
        SQLComando.CommandType = CommandType.StoredProcedure
        SQLComando.Parameters.Add("@CodIncidencia", SqlDbType.Int).Value = codigo

        Dim Da As New SqlDataAdapter
        Da.SelectCommand = SQLComando
        Da.Fill(DatoTable)
        Return DatoTable
        SQLConexion.Close()
        SQLConexion.Dispose()
        SQLComando.Dispose()
    End Function
    Public Function getIncidenciaByCodigo2(ByVal codigoPagina As String) As DataTable
        Dim DatoTable As New DataTable
        Dim SQLConexion As New SqlConnection(str_cnx)
        SQLConexion.Open()
        Dim SQLComando As New SqlCommand("SP_Frm_Incidencia_ObtenerIncidencia2", SQLConexion)
        SQLComando.CommandType = CommandType.StoredProcedure
        SQLComando.Parameters.Add("@CodPagina", SqlDbType.NVarChar).Value = codigoPagina

        Dim Da As New SqlDataAdapter
        Da.SelectCommand = SQLComando
        Da.Fill(DatoTable)
        Return DatoTable
        SQLConexion.Close()
        SQLConexion.Dispose()
        SQLComando.Dispose()
    End Function
    Public Function ObtenerIncidenciaEdicion(ByVal codigoEdicion As String) As DataTable
        Dim DatoTable As New DataTable
        Dim SQLConexion As New SqlConnection(str_cnx)
        SQLConexion.Open()
        Dim SQLComando As New SqlCommand("SP_Frm_Incidencia_ObtenerIncidencia3", SQLConexion)
        SQLComando.CommandType = CommandType.StoredProcedure
        SQLComando.Parameters.Add("@CodEdicion", SqlDbType.NVarChar).Value = codigoEdicion

        Dim Da As New SqlDataAdapter
        Da.SelectCommand = SQLComando
        Da.Fill(DatoTable)
        Return DatoTable
        SQLConexion.Close()
        SQLConexion.Dispose()
        SQLComando.Dispose()
    End Function
End Class
