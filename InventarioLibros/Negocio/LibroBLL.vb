Public Class LibroBLL
    Private libroDAL As New LibroDAL()

    ' Obtener libros
    Public Function ObtenerLibros() As DataSet
        Return libroDAL.ObtenerLibros()
    End Function

    ' Agregar nuevo libro
    Public Sub AgregarLibro(titulo As String, autor As String, cantidad As Integer)
        If String.IsNullOrEmpty(titulo) Or String.IsNullOrEmpty(autor) Or cantidad < 0 Then
            Throw New Exception("Datos inválidos. Por favor, revise los campos.")
        End If
        libroDAL.AgregarLibro(titulo, autor, cantidad)
    End Sub

    ' Actualizar libro
    Public Sub ActualizarLibro(id As Integer, cantidad As Integer)
        If cantidad < 0 Then
            Throw New Exception("La cantidad debe ser mayor o igual a 0.")
        End If
        libroDAL.ActualizarLibro(id, cantidad)
    End Sub

    ' Eliminar libro
    Public Sub EliminarLibro(id As Integer)
        libroDAL.EliminarLibro(id)
    End Sub
End Class
