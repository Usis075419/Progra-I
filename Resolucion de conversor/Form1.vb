Public Class Form1
    Dim objConversor = New conversores()

    Private Sub cbotipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbotipo.SelectedIndexChanged
        cbode.Items.Clear()
        cbode.Text = ""
        cbode.Items.AddRange(objConversor.etiquetas(cbotipo.SelectedIndex))

        cboa.Items.Clear()
        cboa.Text = ""
        cboa.Items.AddRange(objConversor.etiquetas(cbotipo.SelectedIndex))
    End Sub

    Private Sub btnConvertir_Click(sender As Object, e As EventArgs) Handles btnConvertir.Click
        lblrespuesta.Text = "Respuesta: " + objConversor.convertir(cbotipo.SelectedIndex, cbode.SelectedIndex, cboa.SelectedIndex, txtcantidad.Text).ToString() + " " + objConversor.etiquetas(cbotipo.SelectedIndex)(cboa.SelectedIndex)
    End Sub

    Private Sub lblrespuesta_Click(sender As Object, e As EventArgs) Handles lblrespuesta.Click

    End Sub

    Private Sub lblcantidad_Click(sender As Object, e As EventArgs) Handles lblcantidad.Click

    End Sub

    Private Sub txtcantidad_TextChanged(sender As Object, e As EventArgs) Handles txtcantidad.TextChanged

    End Sub

    Private Sub lbltipo_Click(sender As Object, e As EventArgs) Handles lbltipo.Click

    End Sub

    Private Sub cboa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboa.SelectedIndexChanged

    End Sub

    Private Sub cbode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbode.SelectedIndexChanged

    End Sub

    Private Sub lbla_Click(sender As Object, e As EventArgs) Handles lbla.Click

    End Sub

    Private Sub lblde_Click(sender As Object, e As EventArgs) Handles lblde.Click

    End Sub
End Class

Class conversores
    Public etiquetas()() As String = {
        New String() {"Dolar", "Euro", "Quetzales", "Lempira", "Colon SV", "Cordoba", "Colon CR"},
        New String() {"Metro", "CM", "Pulgadas", "Pies", "Varas", "Yardas", "Km", "Millas"},
        New String() {"Libra", "Gramos", "Kilogramos", "Onzas", "Quintales", "Toneladas"},
        New String() {"MB", "Bit", "Byte", "KB", "GB", "TB"},
        New String() {"Hora", "Segundos", "Minutos", "Dias", "Semana", "Meses", "Años"}
    }
    Public valores()() As Double = {
        New Double() {1, 0.85, 7.74, 24.8, 8.75, 34.6, 597.23},
        New Double() {1, 100, 39.3701, 3.28084, 1.1963081929167, 1.09361, 0.001, 0.000621371},
        New Double() {1, 453.592, 0.453592, 16, 0.01, 0.000453592},
        New Double() {1, 8000000.0, 1000000.0, 1000, 0.001, 0.000001},
        New Double() {1, 3600, 60, 0.0416667, 0.00595238, 0.00136986, 0.000114155}
    }
    Public Function convertir(ByVal tipo As Int16, ByVal de As Int16, ByVal a As Int16, ByVal cantidad As Double)
        Return valores(tipo)(a) / valores(tipo)(de) * cantidad
    End Function
End Class

