Public Class Frm_Incidencia
    Dim estado As Integer = 0
    Dim tipoDocumento As String = ""
    Dim codigoPagina As String = ""

    Public Sub New(ByVal tipoIncidencia As String, ByVal descripcion As String, ByVal tipoDocumento As String)
        MyBase.New()
        InitializeComponent()
        tipoDocumento = tipoDocumento
        llenarTipoIncidencia(tipoIncidencia)
        ocultarBotones()
    End Sub

    Public Sub New(ByVal tipoDocumento As String)
        MyBase.New()
        InitializeComponent()
        Me.tipoDocumento = tipoDocumento
    End Sub

    Public Sub New(ByVal codigoIncidencia As Integer, ByVal tipoDocumento As String)
        MyBase.New()
        InitializeComponent()
        Me.tipoDocumento = tipoDocumento
        llenarDatos(codigoIncidencia)
        ocultarBotones()
    End Sub

    Public Sub New(ByVal codigo As String, ByVal tipoDocumento As String)
        MyBase.New()
        InitializeComponent()
        Me.tipoDocumento = tipoDocumento
        If tipoDocumento.Equals("IMAGEN") Then
            llenarDatos2(codigo)
        Else
            llenarDatos3(codigo)
        End If

        'Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ocultarBotones()
    End Sub

    Private Sub llenarDatos(ByVal codigoIncidencia As Integer)
        Dim cIncidencia As New Clases.C_Incidencia

        Dim dt As DataTable = cIncidencia.getIncidenciaByCodigo(codigoIncidencia)

        Dim tipoIncidencia As String = dt.Rows(0).Item(0).ToString()
        Dim descripcion As String = dt.Rows(0).Item(1).ToString()
        llenarTipoIncidencia(tipoIncidencia)
        llenarDescripcion(descripcion)

    End Sub
    Private Sub llenarDatos2(ByVal codigoPagina As String)
        Dim cIncidencia As New Clases.C_Incidencia

        Dim dt As DataTable = cIncidencia.getIncidenciaByCodigo2(codigoPagina)

        Dim tipoIncidencia As String = dt.Rows(0).Item(0).ToString()
        Dim descripcion As String = dt.Rows(0).Item(1).ToString()
        llenarTipoIncidencia(tipoIncidencia)
        llenarDescripcion(descripcion)

    End Sub
    Private Sub llenarDatos3(ByVal codigoEdicion As String)
        Dim cIncidencia As New Clases.C_Incidencia

        Dim dt As DataTable = cIncidencia.ObtenerIncidenciaEdicion(codigoEdicion)

        Dim tipoIncidencia As String = dt.Rows(0).Item(0).ToString()
        Dim descripcion As String = dt.Rows(0).Item(1).ToString()
        llenarTipoIncidencia(tipoIncidencia)
        llenarDescripcion(descripcion)
    End Sub
    Private Sub llenarDescripcion(ByVal descripcion As String)
        Me.tbDescripcion.Text = descripcion
        Me.tbDescripcion.Enabled = True
    End Sub

    Public Sub llenarTipoIncidencia(ByVal tipo As String)
        cargarTipos()
        cbIncidencia.SelectedValue = tipo
        cbIncidencia.Enabled = False
    End Sub

    Public Sub ocultarBotones()
        Me.btnAceptar.Visible = False
        Me.btnCancelar.Visible = False
    End Sub

    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub

    Public Function getDescripcion() As String
        Return Me.tbDescripcion.Text
    End Function
    Public Function getEstado() As Integer
        Return estado
    End Function

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If cbIncidencia.SelectedIndex = -1 Then
            MsgBox("Seleccione una incidencia", MsgBoxStyle.Exclamation, "Aviso")
        Else
            estado = 1
            Me.Close()
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        estado = 2
        Me.Close()
    End Sub

    Private Sub Frm_Incidencia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarTipos()
    End Sub

    Private Sub cargarTipos()
        Dim cIncidencia As New Clases.C_Incidencia
        cbIncidencia.DataSource = cIncidencia.CargarTiposIncidencia(tipoDocumento)
        cbIncidencia.ValueMember = "TIPO"
        cbIncidencia.DisplayMember = "DESCRIPCION"
    End Sub

    Public Function getIncidencia() As String
        Dim incidencia As String = ""
        If cbIncidencia.SelectedIndex <> -1 Then
            Return cbIncidencia.SelectedValue
        End If
        Return incidencia
    End Function
End Class