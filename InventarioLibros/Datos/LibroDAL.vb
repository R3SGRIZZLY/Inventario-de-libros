Imports System.Data.SqlClient

Public Class LibroDAL
    Private connectionString As String = "Data Source=LAPTOP-PAHTQ5QE\SQLEXPRESS
;Initial Catalog=Libreria;Integrated Security=True"

    ' Obtener todos los libros
    Public Function ObtenerLibros() As DataSet
        Dim ds As New DataSet()
        Using connection As New SqlConnection(connectionString)
            Dim query As String = "SELECT * FROM Libros"
            Dim adapter As New SqlDataAdapter(query, connection)
            connection.Open()
            adapter.Fill(ds, "Libros")
        End Using
        Return ds
    End Function

    ' Agregar un nuevo libro
    Public Sub AgregarLibro(titulo As String, autor As String, cantidad As Integer)
        Using connection As New SqlConnection(connectionString)
            Dim query As String = "INSERT INTO Libros (Titulo, Autor, CantidadDisponible) VALUES (@Titulo, @Autor, @Cantidad)"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@Titulo", titulo)
            command.Parameters.AddWithValue("@Autor", autor)
            command.Parameters.AddWithValue("@Cantidad", cantidad)
            connection.Open()
            command.ExecuteNonQuery()
        End Using
    End Sub

    ' Actualizar la cantidad de un libro
    Public Sub ActualizarLibro(id As Integer, cantidad As Integer)
        Using connection As New SqlConnection(connectionString)
            Dim query As String = "UPDATE Libros SET CantidadDisponible = @Cantidad WHERE id = @Id"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@Cantidad", cantidad)
            command.Parameters.AddWithValue("@Id", id)
            connection.Open()
            command.ExecuteNonQuery()
        End Using
    End Sub

    ' Eliminar un libro
    Public Sub EliminarLibro(id As Integer)
        Using connection As New SqlConnection(connectionString)
            Dim query As String = "DELETE FROM Libros WHERE id = @Id"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@Id", id)
            connection.Open()
            command.ExecuteNonQuery()
        End Using
    End Sub
End Class
