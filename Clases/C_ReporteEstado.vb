Imports System.Data
Imports System.Data.SqlClient
Public Class C_ReporteEstado
    Public conexion As New C_Conexion
    Public str_cnx As String = conexion.CadenaConexion
    Public Function CargarEstados(ByVal tipo As String) As DataTable
        Dim DatoTable As New DataTable
        Dim SQLConexion As New SqlConnection(str_cnx)
        SQLConexion.Open()
        Dim SQLComando As New SqlCommand("SP_Frm_ReporteObtenerEstados", SQLConexion)
        SQLComando.CommandType = CommandType.StoredProcedure
        SQLComando.Parameters.Add("@tipo", SqlDbType.NVarChar, 3).Value = tipo
        Dim Da As New SqlDataAdapter
        Da.SelectCommand = SQLComando
        Da.Fill(DatoTable)
        Return DatoTable
        SQLConexion.Close()
        SQLConexion.Dispose()
        SQLComando.Dispose()
    End Function

    Public Function CargarDatos(ByVal flat As Integer, ByVal estado As String, ByVal anio As Integer) As DataTable
        Dim DatoTable As New DataTable
        Dim SQLConexion As New SqlConnection(str_cnx)
        SQLConexion.Open()
        Dim SQLComando As New SqlCommand("SP_Frm_ReporteEstado", SQLConexion)
        SQLComando.CommandType = CommandType.StoredProcedure
        SQLComando.Parameters.Add("@flat", SqlDbType.Int).Value = flat
        SQLComando.Parameters.Add("@estado", SqlDbType.NVarChar, 3).Value = estado
        SQLComando.Parameters.Add("@anio", SqlDbType.Int).Value = anio
        Dim Da As New SqlDataAdapter
        Da.SelectCommand = SQLComando
        Da.Fill(DatoTable)

        SQLConexion.Close()
        SQLConexion.Dispose()
        SQLComando.Dispose()
        Return DatoTable
        
    End Function
End Class
