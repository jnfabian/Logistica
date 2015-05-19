Public Class CabeceraDao
    Private id_Carga As String
    Private fecha_Carga As Date
    Private usuario_ As String
    Private ruta_ As String

    Public Property idCarga() As String
        Get
            Return id_Carga
        End Get
        Set(ByVal value As String)
            id_Carga = value
        End Set
    End Property
    Public Property fechaCarga() As Date
        Get
            Return fecha_Carga
        End Get
        Set(ByVal value As Date)
            fecha_Carga = value
        End Set
    End Property
    Public Property usuario() As String
        Get
            Return usuario_
        End Get
        Set(ByVal value As String)
            usuario_ = value
        End Set
    End Property
    Public Property ruta() As String
        Get
            Return ruta_
        End Get
        Set(ByVal value As String)
            ruta_ = value
        End Set
    End Property
End Class
