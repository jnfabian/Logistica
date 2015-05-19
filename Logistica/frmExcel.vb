Imports System.Data.OleDb

Public Class frmExcel

    Dim pagina As New Clases.C_Paginas
    Dim extension As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim op As New OpenFileDialog
        op.Filter = "Excel 2003(*.xls)|*.xls|excel 2007(*.xlsx)|*.xlsx"

        If op.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtArchivo.Text = op.FileName
            extension = txtArchivo.Text.Substring(txtArchivo.Text.Length - 3, 3)
            '  MsgBox(extension)
        End If

    End Sub

    Public Function TraerTabla() As DataTable
        Dim cnx As String

        If (extension.Equals("xls")) Then
            cnx = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & txtArchivo.Text & ";Extended Properties=""Excel 8.0;HDR=Yes;IMEX=1"""
        Else
            cnx = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & txtArchivo.Text & ";Extended Properties=""Excel 12.0 Xml;HDR=YES;IMEX=1"""
        End If
        'instanciamos la cadena de conexion
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
        Return dt
    End Function

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim objeto As New Clases.CabeceraDao

        objeto.fechaCarga = DateTime.Now
        objeto.usuario = "carloncho"
        objeto.ruta = txtArchivo.Text

        Dim mitablita As New DataTable
        mitablita = TraerTabla()
        'For Each fila As DataRow In mitablita.Rows
        '    MsgBox(fila(0).ToString)
        '    MsgBox(fila.Item(1).ToString)
        '    MsgBox(fila(2))
        'Next
        'si kiero ver los datos que me trae la tabla || DgDetalle.DataSource = mitablita||
        '      For Each fila As DataRow In mitablita.Rows
        'pagina.RegistraEx(fila.Item(0).ToString, fila.Item(1).ToString, fila.Item(2).ToString)
        '   Next

        pagina.insertarCabecera(objeto, mitablita)

    End Sub

    Private Sub frmExcel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class