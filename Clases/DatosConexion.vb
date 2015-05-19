Imports System.Data
Imports System.Data.SqlClient
Public Class DatosConexion
    Public conexion As New C_Conexion
    Public str_cnx As String = conexion.CadenaConexion

    Public Shared dominio As String
    Public Shared usuario As String
    Public Shared clave As String

    Public Sub New()
        IniciarDatos()
    End Sub

    Public Shared Function getDominio() As String
        Return dominio
    End Function
    Public Shared Function getUsuario() As String
        Return dominio
    End Function
    Public Shared Function getClave() As String
        Return dominio
    End Function

    Private Sub IniciarDatos()
        Dim SQLConexion As New SqlConnection(str_cnx)
        Dim DatoTable As New DataTable
        SQLConexion.Open()
        Dim SQLComando As New SqlCommand("SP_Frm_obtenerParametros", SQLConexion)
        SQLComando.CommandType = CommandType.StoredProcedure
        Dim Da As New SqlDataAdapter
        Da.SelectCommand = SQLComando
        Da.Fill(DatoTable)

        For i As Integer = 0 To DatoTable.Rows.Count - 1

            If DatoTable.Rows(i).Item("nombre").ToString().Equals("dominio") Then
                dominio = DatoTable.Rows(i).Item("valor").ToString()
            ElseIf DatoTable.Rows(i).Item("nombre").ToString().Equals("nombreUsuario") Then
                usuario = DatoTable.Rows(i).Item("valor").ToString()
            ElseIf DatoTable.Rows(i).Item("nombre").ToString().Equals("claveUsuario") Then
                clave = DatoTable.Rows(i).Item("valor").ToString()
            End If
        Next

        SQLConexion.Close()
        SQLConexion.Dispose()
        SQLComando.Dispose()
    End Sub
End Class
