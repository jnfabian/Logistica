Namespace InterfaceOnBase

    Public Class PaginaItem
        Public CodPagina As String
        Public Tipo As String
        Public NumeroPagina As String
        Public FechaPublicacion As String
        Public Nombre As String
        Public SubTitulo As String
        Public Archivo As String
        Public CodigoTipo As Integer
    End Class

    Public Class EdicionItem
        Public CodEdicion As String
        Public Tipo As String
        Public NumeroPagina As String
        Public FechaPublicacion As String
        Public Nombre As String
        Public SubTitulo As String
        Public Archivo As String
        Public CodigoTipo As Integer
    End Class

    Public Class OnbaseDB

        Public mstrDataSourseName As String = "OBSERVER"
        Public mstrUserName As String
        Public mstrPassword As String

        Dim gobjDataSourceManager
        Dim gobjDataSource
        Dim gobjSession

        Public Sub Open()
            Try

                gobjDataSourceManager = CreateObject("DMCoreX.OBXDataSourceManager")
                gobjDataSource = gobjDataSourceManager.GetDataSourceByName(mstrDataSourseName)
                gobjDataSource.Open()
                gobjSession = gobjDataSource.NewSession(mstrUserName, mstrPassword)
                gobjSession.Connect()

            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Function AlmacenarPagina(ByVal oData As PaginaItem) As String
            Try

                Const DOC_TYPE_ID = 175
                Const FILE_TYPE_ID = 2             '2 es JPG y TIFF, 16 es PDF, 1 es TEXTO

                If Dir(oData.Archivo, FileAttribute.Archive) = "" Then
                    Throw New Exception("Archivo : " & oData.Archivo & " no encontrado o no accesible")
                End If

                Dim objPresentationServices
                objPresentationServices = gobjSession.CreateServicesModule("OnBase.PresentationServices")

                Dim objStorageProvider
                objStorageProvider = objPresentationServices.CreateStorageProvider

                Dim objArchivalToken
                objArchivalToken = objStorageProvider.CreateArchivalToken

                objArchivalToken.Action = "NewDocument"

                objArchivalToken.TypeID = DOC_TYPE_ID

                objArchivalToken.FileTypeID = FILE_TYPE_ID

                objArchivalToken.Date = oData.FechaPublicacion 'Format(Date.Now, "MM/dd/yyyy").ToString

                'Antiguo
                'If oData.FechaPublicacion <> "" Then objArchivalToken.AddKeywordByName("Fecha Publicacion", oData.FechaPublicacion)
                'If oData.Nombre <> "" Then objArchivalToken.AddKeywordByName("Titulo", oData.Nombre)
                'If oData.SubTitulo <> "" Then objArchivalToken.AddKeywordByName("Sub Titulo", oData.SubTitulo)
                'If oData.NumeroPagina <> "" Then objArchivalToken.AddKeywordByName("Numero Pagina", oData.NumeroPagina)
                'Nuevo
                If oData.FechaPublicacion <> "" Then objArchivalToken.AddKeywordByName("Fecha Publicacion", oData.FechaPublicacion)
                If oData.Nombre <> "" Then objArchivalToken.AddKeywordByName("Descripcion", oData.Nombre)
                If oData.NumeroPagina <> "" Then objArchivalToken.AddKeywordByName("Pagina", oData.NumeroPagina)


                objArchivalToken.AddPageFromFile(oData.Archivo)

                ' Si todo esta bien podemos almacenar la informacion
                Dim strArchivalTokenInfo
                strArchivalTokenInfo = objArchivalToken.SaveToken(1)

                Dim objPropertyBag
                objPropertyBag = objStorageProvider.ProcessArchivalTokenEx(objArchivalToken)

                Dim lngDocumentID
                lngDocumentID = objPropertyBag.GetProperty("documentID")

                Return lngDocumentID.ToString

            Catch ex As Exception
                Throw ex
            End Try

        End Function

        Public Function AlmacenarEdicion(ByVal oData As EdicionItem) As String
            Try

                Const DOC_TYPE_ID = 174
                Const FILE_TYPE_ID = 16             '2 es JPG y TIFF, 16 es PDF, 1 es TEXTO

                If Dir(oData.Archivo, FileAttribute.Archive) = "" Then
                    Throw New Exception("Archivo : " & oData.Archivo & " no encontrado o no accesible")
                End If

                Dim objPresentationServices
                objPresentationServices = gobjSession.CreateServicesModule("OnBase.PresentationServices")

                Dim objStorageProvider
                objStorageProvider = objPresentationServices.CreateStorageProvider

                Dim objArchivalToken
                objArchivalToken = objStorageProvider.CreateArchivalToken

                objArchivalToken.Action = "NewDocument"

                objArchivalToken.TypeID = DOC_TYPE_ID

                objArchivalToken.FileTypeID = FILE_TYPE_ID

                objArchivalToken.Date = oData.FechaPublicacion 'Format(Date.Now, "MM/dd/yyyy").ToString

                'If oData.CodEdicion <> "" Then objArchivalToken.AddKeywordByName("Codigo", oData.CodEdicion)
                'If oData.Tipo <> "" Then objArchivalToken.AddKeywordByName("Tipo", CType(oData.Tipo, Double))
                If oData.FechaPublicacion <> "" Then objArchivalToken.AddKeywordByName("Fecha Publicacion", oData.FechaPublicacion)
                If oData.Nombre <> "" Then objArchivalToken.AddKeywordByName("Titulo", oData.Nombre)
                If oData.SubTitulo <> "" Then objArchivalToken.AddKeywordByName("Sub Titulo", oData.SubTitulo)

                objArchivalToken.AddPageFromFile(oData.Archivo)

                ' Si todo esta bien podemos almacenar la informacion
                Dim strArchivalTokenInfo
                strArchivalTokenInfo = objArchivalToken.SaveToken(1)

                Dim objPropertyBag
                objPropertyBag = objStorageProvider.ProcessArchivalTokenEx(objArchivalToken)

                Dim lngDocumentID As String = ""
                'lngDocumentID = objPropertyBag.GetProperty("documentID")

                Return lngDocumentID

            Catch ex As Exception
                Throw ex
            End Try

        End Function




        Public Sub close()
            Try
                gobjSession.Disconnect()
            Catch ex As Exception
                Throw ex
            End Try

        End Sub

    End Class

End Namespace



