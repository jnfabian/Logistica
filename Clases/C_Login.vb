Imports System.Data
Imports System.Data.SqlClient
Public Class C_Login
    Public conexion As New C_Conexion
    Public str_cnx As String = conexion.CadenaConexion
    Public Function Validar(ByVal Usuario As String) As DataTable
        Dim DatoTable As New DataTable
        Dim SQLConexion As New SqlConnection(str_cnx)
        SQLConexion.Open()
        Dim SQLComando As New SqlCommand("SP_Frm_Login_ValidarUsuario", SQLConexion)
        SQLComando.CommandType = CommandType.StoredProcedure
        SQLComando.Parameters.Add("@Usuario", SqlDbType.VarChar, 50).Value = Usuario
        Dim Da As New SqlDataAdapter
        Da.SelectCommand = SQLComando
        Da.Fill(DatoTable)
        Return DatoTable
        SQLConexion.Close()
        SQLConexion.Dispose()
        SQLComando.Dispose()
    End Function
    Public Function UsuarioAutentificaRed(ByVal IdParametro As Integer) As DataTable
        Dim DatoTable As New DataTable
        Dim SQLConexion As New SqlConnection(str_cnx)
        SQLConexion.Open()
        Dim SQLComando As New SqlCommand("SP_Frm_Usuario_Red", SQLConexion)
        SQLComando.CommandType = CommandType.StoredProcedure
        SQLComando.Parameters.Add("@idParametro", SqlDbType.Int).Value = IdParametro
        Dim Da As New SqlDataAdapter
        Da.SelectCommand = SQLComando
        Da.Fill(DatoTable)
        Return DatoTable
        SQLConexion.Close()
        SQLConexion.Dispose()
        SQLComando.Dispose()
    End Function

End Class
