Public Class Form1
    Private Sub btnProcesar_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click
        Dim ntabla, i As SByte
        ntabla = txtTabla.Text
        lstTablas.Items.Clear()
        If ntabla <= 12 Then

            For i = 1 To 9
                lstTablas.Items.Add(ntabla.ToString() + "X" + i.ToString() + "=" + (ntabla * i).ToString())
            Next
        Else
            lstTablas.Items.Add("Porfavor Ingrese tablas menores o igual a 9")
        End If
    End Sub
End Class
