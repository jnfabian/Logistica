Imports System.Data
Imports System.Data.SqlClient

Public Class C_ReportePorAnio


    Dim conn As New C_Conexion
    Dim strConexion As String = conn.CadenaConexion

    Public Function ListarAnio() As DataTable

        Dim con As New SqlConnection(strConexion)
        Dim cmd As New SqlCommand
        cmd.Connection = con
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "Usp_listar_año"
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        Return dt

    End Function

    Public Function ListadoXaño(ByVal anio As String) As DataTable
        Dim con As New SqlConnection(strConexion)
        Using cmd As New SqlCommand
            cmd.Connection = con
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "ListadoXaño"
            cmd.Parameters.Add("@año", SqlDbType.NVarChar).Value = anio
            Using da As New SqlDataAdapter(cmd)
                Using dt As New DataTable
                    da.Fill(dt)
                    Return dt
                End Using
            End Using
        End Using
    End Function

End Class
