Public Class loguin
    Dim objconexion As New db_conexion


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MessageBox.Show("La coneccion a la BD establecida.")

    End Sub
End Class