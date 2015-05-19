Imports System.IO
Imports System.Collections
Imports System.Data.SqlClient
Public Class C_Conexion
    Dim objReader As New StreamReader("C:\LOG\ControlLogistica.ccii")
    'Dim objReader As New StreamReader("C:\LOG\ControlPrueba.ccii")

    Public Function CadenaConexion() As String
        Dim sLine As String = ""
        Dim arrText As New ArrayList()
        Dim NombreServidor As String = ""
        Dim baseDatos As String = ""
        Dim user As String = ""
        Dim pass As String = ""

        Do
            sLine = objReader.ReadLine()
            If Not sLine Is Nothing Then
                arrText.Add(sLine)
            End If
        Loop Until sLine Is Nothing

        For i As Integer = 0 To arrText.Count - 1
            If i = 0 Then
                NombreServidor = arrText.Item(0).ToString
            End If
            If i = 1 Then
                baseDatos = arrText.Item(1).ToString
            End If
            If i = 2 Then
                user = arrText.Item(2).ToString
            End If
            If i = 3 Then
                pass = arrText.Item(3).ToString
            End If
        Next i

        objReader.Close()
        objReader.Dispose()

        Return "Data Source=" & NombreServidor & "; Initial Catalog=" & baseDatos & "; User Id=" & user & "; Password=" & pass & ";"
    End Function
End Class
