Public Class ventana1
    Dim conexion As New db_conexion()
    Private Sub ventana1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = conexion.obtenerdata().Tables("proveedor").DefaultView
    End Sub
End Class