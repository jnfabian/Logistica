Imports System.IO
Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class Form2

    Dim ruta As String
    Dim paginas As New Clases.C_Paginas

    Private Sub btnProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesar.Click

        'Dim re As String
        're = My.Computer.FileSystem.ReadAllText("C:\")
        'MessageBox.Show(re)
        grabar()

    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mostrarUnidades()

    End Sub

    Sub mostrarUnidades()
        Dim unidades() As DriveInfo = DriveInfo.GetDrives
        For Each c As DriveInfo In unidades
            lstUnidades.Items.Add(c.Name)
        Next
    End Sub

    Private Sub lstUnidades_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstUnidades.SelectedIndexChanged
        mostrarDirectorios()
    End Sub

    Sub mostrarDirectorios()
        'recuperar la unidad seleccionada
        Dim unidad As String = lstUnidades.SelectedItem
        'recuperea el directorio seleccionado
        Dim carpetas As DirectoryInfo = New DirectoryInfo(unidad)
        Try
            lstCarpetas.Items.Clear()
            For Each c As DirectoryInfo In carpetas.GetDirectories
                lstCarpetas.Items.Add(c)
            Next
        Catch ex As Exception
            'no existen datos
            MsgBox("no existen datos")
        End Try
        ruta = unidad
        lblRuta.Text = ruta
    End Sub

    Sub mostrarObjetos()
        Dim unidad As String = lstUnidades.SelectedItem
        Dim carpetas As String = lstCarpetas.SelectedItem.ToString
        Dim file As DirectoryInfo = New DirectoryInfo(unidad & carpetas)

        Try
            lstObjetos.Items.Clear()
            For Each x As FileInfo In file.GetFiles
                lstObjetos.Items.Add(x)
            Next
        Catch ex As Exception
            Throw ex
        End Try
        lblRuta.Text = unidad + carpetas
    End Sub

    Private Sub lstCarpetas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstCarpetas.SelectedIndexChanged
        mostrarObjetos()
    End Sub

    Private Sub lstObjetos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstObjetos.SelectedIndexChanged
        Try
            Dim unidad As String = lstUnidades.SelectedItem
            Dim carpetas As String = lstCarpetas.SelectedItem.ToString
            Dim archivo As String = lstObjetos.SelectedItem.ToString
            lblRuta.Text = unidad + carpetas + "\" + archivo

            'instanciamos la cadena de conexion
            Dim cnx As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & lblRuta.Text & ";Extended Properties=""Excel 8.0;HDR=Yes;IMEX=1"""
            Dim cn As New OleDb.OleDbConnection(cnx)
            Dim cmd As New OleDbCommand
            Dim da As New OleDb.OleDbDataAdapter
            Dim dt As New DataTable

            cmd.Connection = cn
            'Consultamos la hoja llamada Clientes de nuestro archivo *.xls
            cmd.CommandText = "select * from [Hoja1$]"
            cmd.CommandType = CommandType.Text

            da.SelectCommand = cmd
            'Llenamos el datatable
            da.Fill(dt)
            'Llenamos el Datagridview
            DgDatos.DataSource = dt
            'Ajustamos las columnas del DataGridView
            DgDatos.AutoSizeColumnsMode = 6

        Catch ex As Exception
            MsgBox(" No es un archivo excel")
        End Try
    End Sub

    Sub grabar()

        'Dim archivo As String = lstObjetos.SelectedItem.ToString
        'paginas.RegistrarExcel(archivo, lblRuta.Text)
        'MessageBox.Show("se grabo correctamente")
        For Each fila As DataGridViewRow In DgDatos.Rows
            Dim op = CType((fila.Cells(0).Value), String)
            If (String.IsNullOrEmpty(op)) Then
                Exit For
            End If
            paginas.RegistraEx(fila.Cells(0).Value, fila.Cells(1).Value, fila.Cells(2).Value)
        Next

        MessageBox.Show("Se registro correctamente")
    End Sub


End Class