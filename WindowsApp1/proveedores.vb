Public Class proveedores
    Dim objconexion As New db_conexion
    Dim datatable As New DataTable


    Private Sub proveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        obtenerdatos()
    End Sub

    Sub obtenerdatos()
        datatable = objconexion.obtenerdata()("proveedores")

    End Sub

    Sub mostrardatos()
        MessageBox.Show("nombre:" + datatable.Rows(0).ItemArray(1).ToString())


    End Sub
End Class