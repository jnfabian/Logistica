Imports System.Data
Imports System.Data.SqlClient
Public Class C_ReporteEmpaste
    Public conexion As New C_Conexion
    Public str_cnx As String = conexion.CadenaConexion
    Public Function CargarDatos(ByVal Flat As Integer, ByVal CodIdentificacion As String, ByVal Estado As Integer, ByVal Visto As Integer, ByVal Usuario As String, ByVal Observacion As String) As DataTable
        Dim DatoTable As New DataTable
        Dim SQLConexion As New SqlConnection(str_cnx)
        SQLConexion.Open()
        Dim SQLComando As New SqlCommand("SP_Frm_ReporteEmpasteN", SQLConexion)
        SQLComando.CommandType = CommandType.StoredProcedure
        SQLComando.Parameters.Add("@Flat", SqlDbType.Int).Value = Flat
        SQLComando.Parameters.Add("@CodIdentificacion", SqlDbType.VarChar, 11).Value = CodIdentificacion
        SQLComando.Parameters.Add("@Estado", SqlDbType.Int).Value = Estado
        SQLComando.Parameters.Add("@Visto", SqlDbType.Int).Value = Visto
        SQLComando.Parameters.Add("@Usuario", SqlDbType.VarChar, 30).Value = Usuario
        SQLComando.Parameters.Add("@Observacion", SqlDbType.VarChar, 256).Value = Observacion
        Dim Da As New SqlDataAdapter
        Da.SelectCommand = SQLComando
        Da.Fill(DatoTable)
        Return DatoTable
        SQLConexion.Close()
        SQLConexion.Dispose()
        SQLComando.Dispose()
    End Function
End Class
