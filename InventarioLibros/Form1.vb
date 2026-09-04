Public Class Form1
    Private libroBLL As New LibroBLL()

    ' Cargar libros en el DataGridView
    Private Sub CargarLibros()
        Dim ds As DataSet = libroBLL.ObtenerLibros()
        dgvLibros.DataSource = ds.Tables("Libros")
    End Sub

    ' Cargar libros al iniciar el formulario
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarLibros()
    End Sub

    ' Agregar un nuevo libro
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            libroBLL.AgregarLibro(txtTitulo.Text, txtAutor.Text, Convert.ToInt32(txtCantidad.Text))
            MessageBox.Show("Libro agregado correctamente.")
            CargarLibros()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ' Actualizar libro
    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Try
            Dim id As Integer = Convert.ToInt32(dgvLibros.CurrentRow.Cells("id").Value)
            libroBLL.ActualizarLibro(id, Convert.ToInt32(txtCantidad.Text))
            MessageBox.Show("Cantidad actualizada correctamente.")
            CargarLibros()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ' Eliminar libro
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            Dim id As Integer = Convert.ToInt32(dgvLibros.CurrentRow.Cells("id").Value)
            libroBLL.EliminarLibro(id)
            MessageBox.Show("Libro eliminado correctamente.")
            CargarLibros()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class
