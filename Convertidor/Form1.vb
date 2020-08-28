Public Class Form1

    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click
        Dim Num1, Num2 As Double
        Num1 = Txtnum1.Text
        Num2 = TxtNum2.Text

        If optSuma.Checked Then
            LblRespuesta.Text = Num1 + Num2
        End If

        If optResta.Checked Then
            LblRespuesta.Text = Num1 - Num2
        End If

        If optMultiplicacion.Checked Then
            LblRespuesta.Text = Num1 * Num2
        End If

        If optDivision.Checked Then
            LblRespuesta.Text = Num1 / Num2
        End If

        If optMod.Checked Then
            LblRespuesta.Text = Num1 Mod Num2
        End If

        If optPotenciador.Checked Then
            LblRespuesta.Text = Num1 ^ Num2
        End If
    End Sub
End Class
