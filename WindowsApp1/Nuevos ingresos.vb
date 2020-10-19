Public Class Nuevos_ingresos
    Dim conexion As New db_conexion
    Dim datatable As New DataTable
    Dim posicion As Integer
    Dim cambio As String = "nuevo"

    Private Sub Nuevos_ingresos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        posicion = 0
        DataGridView1.DataSource = conexion.obtenerdata().Tables("ingresos").DefaultView
    End Sub
    Sub obtenerdatos()
        datatable = conexion.obtenerdata().Tables("ingresos")
        datatable.PrimaryKey = New DataColumn() {datatable.Columns("id")}
    End Sub





    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim msg = conexion.ningresostabla(New String() {
            Me.Tag, TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text
            }, cambio)
        If msg = "error" Then
            MessageBox.Show("Error al intentar guardar el registro, por favor intente nuevamente.", "Registro de Nuevos Ingresos",
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

    End Sub

    Private Sub datagridnewuser_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class