Public Class proveedores
    Dim conexion As New db_conexion
    Dim datatable As New DataTable
    Dim posicion As Integer
    Dim cambio As String = "nuevo"
    Private Sub proveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        posicion = 0
        DataGridView1.DataSource = conexion.obtenerdata().Tables("proveedor").DefaultView
    End Sub
    Sub obtenerdatos()
        datatable = conexion.obtenerdata().Tables("proveedor")
        datatable.PrimaryKey = New DataColumn() {datatable.Columns("idproveedro")}
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim msg = conexion.proveedortabla(New String() {
            Me.Tag, TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text
           }, cambio)
        If msg = "error" Then
            MessageBox.Show("Error al intentar guardar el registro, por favor intente nuevamente.", "Registro de Clientes",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            obtenerdatos()
        End If
    End Sub

    Private Sub limpiar()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
    End Sub
End Class