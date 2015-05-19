Imports System.Data
Imports System.Data.SqlClient
Public Class C_CambiarClave
    Public conexion As New C_Conexion
    Public str_cnx As String = conexion.CadenaConexion
    Public Function CambiarClave(ByVal Flat As String, ByVal Usuario As String, ByVal ClaveNueva As String, ByVal ClaveAntigua As String) As String
        Dim SQLConexion As New SqlConnection(str_cnx)
        SQLConexion.Open()
        Dim SQLComando As New SqlCommand("SP_Frm_CambiarClave", SQLConexion)
        SQLComando.CommandType = CommandType.StoredProcedure
        SQLComando.Parameters.Add("@Flat", SqlDbType.Int).Value = Flat
        SQLComando.Parameters.Add("@Usuario", SqlDbType.VarChar, 50).Value = Usuario
        SQLComando.Parameters.Add("@ClaveNueva", SqlDbType.VarChar, 30).Value = ClaveNueva
        SQLComando.Parameters.Add("@ClaveAntigua", SqlDbType.VarChar, 30).Value = ClaveAntigua
        Dim Retonar = SQLComando.ExecuteScalar
        Return Retonar
        SQLConexion.Close()
        SQLConexion.Dispose()
        SQLComando.Dispose()
    End Function
End Class
