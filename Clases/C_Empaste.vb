Imports System.Data
Imports System.Data.SqlClient
Public Class C_Empaste
    Public conexion As New C_Conexion
    Public str_cnx As String = conexion.CadenaConexion
    Public Function CargarDatos(ByVal Flat As Integer, ByVal CodIdentificacion As String, ByVal Observacion As String) As DataTable
        Dim DatoTable As New DataTable
        Dim SQLConexion As New SqlConnection(str_cnx)
        SQLConexion.Open()
        Dim SQLComando As New SqlCommand("SP_Frm_Empaste_CargarDatos", SQLConexion)
        SQLComando.CommandType = CommandType.StoredProcedure
        SQLComando.Parameters.Add("@Flat", SqlDbType.Int).Value = Flat
        SQLComando.Parameters.Add("@CodIdentificacion", SqlDbType.VarChar, 11).Value = CodIdentificacion
        SQLComando.Parameters.Add("@Observacion", SqlDbType.VarChar, 300).Value = Observacion
        Dim Da As New SqlDataAdapter
        Da.SelectCommand = SQLComando

        Da.Fill(DatoTable)
        Return DatoTable
        SQLConexion.Close()
        SQLConexion.Dispose()
        SQLComando.Dispose()
    End Function
    Public Function Registrar_Empaste(ByVal Flat As Integer, ByVal StringCodAuxiliar As String, ByVal FecInicio As DateTime, ByVal FecTermino As DateTime, ByVal IntLargo As Integer, ByVal IntAncho As Integer, ByVal IntAltura As Integer, ByVal IntEstadoEmpaste As Integer, ByVal IntNumEdiciones As Integer, ByVal IntNumSuplementos As Integer, ByVal IntNumSemestre As Integer, ByVal IntNumPaginas As Integer, ByVal StringCodIdentificacion As String, ByVal StringEdifaltante As String, ByVal IntVisto As Integer, ByVal IntAnaquel As Integer, ByVal IntNivel As Integer, ByVal StringObservaciones As String, ByVal StringCreador As String)
        Dim SQLConexion As New SqlConnection(str_cnx)
        SQLConexion.Open()
        Dim SQLComando As New SqlCommand("SP_Frm_Empaste_GestionarDatos", SQLConexion)
        SQLComando.CommandType = CommandType.StoredProcedure
        SQLComando.Parameters.Add("@Flat", SqlDbType.Int).Value = Flat
        SQLComando.Parameters.Add("@CodAuxiliar", SqlDbType.VarChar, 11).Value = StringCodAuxiliar
        SQLComando.Parameters.Add("@FecInicio", SqlDbType.DateTime).Value = FecInicio
        SQLComando.Parameters.Add("@FecTermino", SqlDbType.DateTime).Value = FecTermino
        SQLComando.Parameters.Add("@IntLargo", SqlDbType.Int).Value = IntLargo
        SQLComando.Parameters.Add("@IntAncho", SqlDbType.Int).Value = IntAncho
        SQLComando.Parameters.Add("@IntAltura", SqlDbType.Int).Value = IntAltura
        SQLComando.Parameters.Add("@IntEstadoEmpaste", SqlDbType.Int).Value = IntEstadoEmpaste
        SQLComando.Parameters.Add("@IntNumEdiciones", SqlDbType.Int).Value = IntNumEdiciones
        SQLComando.Parameters.Add("@IntNumSuplementos", SqlDbType.Int).Value = IntNumSuplementos
        SQLComando.Parameters.Add("@IntNumExtraordinario", SqlDbType.Int).Value = IntNumSemestre
        SQLComando.Parameters.Add("@IntNumPaginas", SqlDbType.Int).Value = IntNumPaginas
        SQLComando.Parameters.Add("@StringCodIdentificacion", SqlDbType.VarChar, 11).Value = StringCodIdentificacion
        SQLComando.Parameters.Add("@StringEdifaltante", SqlDbType.VarChar, 200).Value = StringEdifaltante
        SQLComando.Parameters.Add("@IntVisto", SqlDbType.Int).Value = IntVisto
        SQLComando.Parameters.Add("@IntAnaquel", SqlDbType.Int).Value = IntAnaquel
        SQLComando.Parameters.Add("@IntNivel", SqlDbType.Int).Value = IntNivel
        SQLComando.Parameters.Add("@StringObservaciones", SqlDbType.VarChar, 2000).Value = StringObservaciones 'se cambio de 300 a 2000
        SQLComando.Parameters.Add("@StringCreador", SqlDbType.VarChar, 16).Value = StringCreador
        Dim ValorDevuelto = SQLComando.ExecuteScalar
        SQLConexion.Close()
        SQLConexion.Dispose()
        SQLComando.Dispose()
        Return ValorDevuelto
    End Function
    Public Function BuscarEmpaste(ByVal Flat As Integer, ByVal CodPEmpaste As String)
        Dim SQLConexion As New SqlConnection(str_cnx)
        SQLConexion.Open()
        Dim SQLComando As New SqlCommand("SP_Frm_Empaste_Buscar", SQLConexion)
        SQLComando.CommandType = CommandType.StoredProcedure
        SQLComando.Parameters.Add("@Flat", SqlDbType.Int).Value = Flat
        SQLComando.Parameters.Add("@CodAuxiliar", SqlDbType.VarChar, 11).Value = CodPEmpaste
        Dim ValorDevuelto = SQLComando.ExecuteScalar
        SQLConexion.Close()
        SQLConexion.Dispose()
        SQLComando.Dispose()
        Return ValorDevuelto
    End Function
End Class
