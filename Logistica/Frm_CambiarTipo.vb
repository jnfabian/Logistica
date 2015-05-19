Imports System.Data
Imports System.Data.SqlClient
Imports Clases.C_Conexion
Imports Clases

Public Class CAMBIAR
    Public conexion As New C_Conexion
    Public str_cnx As String = conexion.CadenaConexion
    Dim txt_codnewedicion As String
    Private Sub Frm_CambiarTipo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DirectorioDataSet.TI_TIPO_EMPASTE' Puede moverla o quitarla según sea necesario.
        Me.TI_TIPO_EMPASTETableAdapter.Fill(Me.DirectorioDataSet.TI_TIPO_EMPASTE)
        Me.txtCambiarTipo.Text = Frm_Edicion.LblCodIden.Text & Frm_Edicion.TxtCodEdi.Text
        Me.txt_NuevaEdicion.Text = Frm_Edicion.TxtCodEdi.Text
        Me.txtCodempaste.Text = Frm_Edicion.LblCodIden.Text
        Me.cbo_TipoEdicionAnterior.SelectedValue = Frm_Edicion.CbxTipo.SelectedValue
        Me.txttipo.Text = Frm_Edicion.CbxTipo.SelectedValue
        Me.lbl_EdicionAnterior.Text = Frm_Edicion.TxtCodEdi.Text
        txt_codnewedicion = Frm_Edicion.LblCodIden.Text & Frm_Edicion.TxtCodEdi.Text
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Dim ask As MsgBoxResult
        If Me.txt_NuevaEdicion.Text.Length < 6 Then
            MsgBox("Error: Debe registrar 6 caracteres", MsgBoxStyle.Information, "Editora Peru")
            Me.txt_NuevaEdicion.Focus()
            Exit Sub
        End If
        ask = MsgBox("Esta seguro de realizar el cambio?", MsgBoxStyle.YesNo, "Editora Perú")
        'se incorporo en el procedimiento tambien el cambio de Edición.
        If ask = MsgBoxResult.Yes Then
            Try
                Dim SQLConexion As New SqlConnection(str_cnx)
                SQLConexion.Open()
                Dim cmd As New SqlCommand("SP_Frm_DetalleEdicion_CambioTipo", SQLConexion)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@StringCodEmpaste", Me.txtCodempaste.Text)
                cmd.Parameters.AddWithValue("@StringCodEdicion", Me.txtCambiarTipo.Text)
                cmd.Parameters.AddWithValue("@numtipo", Me.txttipo.Text)
                cmd.Parameters.AddWithValue("@newnumtipo", Me.cboCambioTipo.SelectedValue)
                cmd.Parameters.AddWithValue("@codNewEdicion", txt_codnewedicion)
                cmd.Parameters.AddWithValue("@newEdicion", Me.txt_NuevaEdicion.Text)
                Dim DT As New SqlDataAdapter(cmd)
                Dim TABLA As New DataTable
                DT.Fill(TABLA)
                MsgBox("Se cambio el tipo de EDICION Correctamente", MsgBoxStyle.Information, "Editora Peru")
                Me.Close()
                Frm_Edicion.Close()
                SQLConexion.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information, "Editora")

                '                MsgBox("No puede realizar esta operacion por que ya existe el registro,puede cambiar de TIPO ó Eliminar el registro anterior..!!", MsgBoxStyle.Information, "Editora")
            End Try
        End If
    End Sub

    Private Sub txt_NuevaEdicion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_NuevaEdicion.TextChanged
        txt_codnewedicion = Frm_Edicion.LblCodIden.Text & Me.txt_NuevaEdicion.Text
    End Sub
End Class