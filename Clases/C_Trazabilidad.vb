Imports System.Data
Imports System.Data.SqlClient
Public Class C_Trazabilidad
    Public conexion As New C_Conexion
    Public str_cnx As String = conexion.CadenaConexion

    Public Function cargarTrazabilidad(ByVal CodIdentificacion As String, ByVal tipo As Integer) As DataTable
        Dim DatoTable As New DataTable
        Dim SQLConexion As New SqlConnection(str_cnx)
        SQLConexion.Open()
        Dim SQLComando As New SqlCommand("SP_Frm_Trazabilidad_CargarDatos", SQLConexion)
        SQLComando.CommandType = CommandType.StoredProcedure
        SQLComando.Parameters.Add("@CodIdentificacion", SqlDbType.NVarChar, 24).Value = CodIdentificacion
        SQLComando.Parameters.Add("@Tipo", SqlDbType.Int).Value = tipo
        Dim Da As New SqlDataAdapter
        Da.SelectCommand = SQLComando
        Da.Fill(DatoTable)
        Return DatoTable
        SQLConexion.Close()
        SQLConexion.Dispose()
        SQLComando.Dispose()
    End Function

    Public Function pasarOnbase(ByVal tipo As String, ByVal anio As String) As DataTable
        Dim DatoTable As New DataTable
        Dim SQLConexion As New SqlConnection(str_cnx)
        SQLConexion.Open()
        Dim SQLComando As New SqlCommand("SP_Frm_PasarOnbase", SQLConexion)
        SQLComando.CommandType = CommandType.StoredProcedure
        SQLComando.Parameters.Add("@tipo", SqlDbType.Int).Value = tipo
        SQLComando.Parameters.Add("@anio", SqlDbType.NVarChar, 4).Value = anio
        Dim Da As New SqlDataAdapter
        Da.SelectCommand = SQLComando
        Da.Fill(DatoTable)

        SQLConexion.Close()
        SQLConexion.Dispose()
        SQLComando.Dispose()
        Return DatoTable
    End Function
End Class
