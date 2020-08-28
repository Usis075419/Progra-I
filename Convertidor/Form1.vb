Public Class Form1
    Private Sub TabPage1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_2(sender As Object, e As EventArgs)



    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbode2.SelectedIndexChanged

    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxselect.SelectedIndexChanged

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Panel8_Paint(sender As Object, e As PaintEventArgs)


    End Sub

    Private Sub BtnConvertidor_Click(sender As Object, e As EventArgs) Handles BtnConvertidormonedas.Click



        'dolar----------------------------------------------------------
        If cbode.Text = "Dolar" And cboa.Text = "Dolar" Then
            lblrespuesta.Text = Val(TxtValor.Text)
        End If

        If cbode.Text = "Dolar" And cboa.Text = "Euro" Then
            lblrespuesta.Text = Val(TxtValor.Text) * 0.85
        End If

        If cbode.Text = "Dolar" And cboa.Text = "Yen" Then
            lblrespuesta.Text = Val(TxtValor.Text) * 105.8
        End If

        If cbode.Text = "Dolar" And cboa.Text = "Peso mx" Then
            lblrespuesta.Text = Val(TxtValor.Text) * 21.98
        End If

        If cbode.Text = "Dolar" And cboa.Text = "Dolar aus" Then
            lblrespuesta.Text = Val(TxtValor.Text) * 1.4
        End If

        If cbode.Text = "Dolar" And cboa.Text = "Franco" Then
            lblrespuesta.Text = Val(TxtValor.Text) * 0.91
        End If

        If cbode.Text = "Dolar" And cboa.Text = "Dolar c" Then
            lblrespuesta.Text = Val(TxtValor.Text) * 1.32
        End If

        If cbode.Text = "Dolar" And cboa.Text = "Afgani" Then
            lblrespuesta.Text = Val(TxtValor.Text) * 78.04
        End If

        If cbode.Text = "Dolar" And cboa.Text = "Peso Chileno" Then
            lblrespuesta.Text = Val(TxtValor.Text) * 793.1
        End If

        If cbode.Text = "Dolar" And cboa.Text = "Colon cr" Then
            lblrespuesta.Text = Val(TxtValor.Text) * 595.4
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text)
        End If

        If cbode.Text = "Dolar" And cboa.Text = "Euro" Then
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text) * 0.85
        End If

        If cbode.Text = "Dolar" And cboa.Text = "Yen" Then
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text) * 105.8
        End If

        If cbode.Text = "Dolar" And cboa.Text = "Peso mx" Then
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text) * 21.98
        End If

        If cbode.Text = "Dolar" And cboa.Text = "Dolar aus" Then
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text) * 1.4
        End If

        If cbode.Text = "Dolar" And cboa.Text = "Franco" Then
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text) * 0.91
        End If

        If cbode.Text = "Dolar" And cboa.Text = "Dolar c" Then
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text) * 1.32
        End If

        If cbode.Text = "Dolar" And cboa.Text = "Afgani" Then
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text) * 78.04
        End If

        If cbode.Text = "Dolar" And cboa.Text = "Peso Chileno" Then
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text) * 793.1
        End If

        If cbode.Text = "Dolar" And cboa.Text = "Colon cr" Then
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text) * 595.4
        End If

        '........................................................


        'Euro----------------------------------------------------------
        If cbode.Text = "Euro" And cboa.Text = "Dolar" Then
            lblrespuesta.Text = Val(TxtValor.Text) * 1.18
        End If

        If cbode.Text = "Euro" And cboa.Text = "Euro" Then
            lblrespuesta.Text = Val(TxtValor.Text)
        End If

        If cbode.Text = "Euro" And cboa.Text = "Yen" Then
            lblrespuesta.Text = Val(TxtValor.Text) * 124.79
        End If

        If cbode.Text = "Euro" And cboa.Text = "Peso mx" Then
            lblrespuesta.Text = Val(TxtValor.Text) * 25.92
        End If

        If cbode.Text = "Euro" And cboa.Text = "Dolar aus" Then
            lblrespuesta.Text = Val(TxtValor.Text) * 1.65
        End If

        If cbode.Text = "Euro" And cboa.Text = "Franco" Then
            lblrespuesta.Text = Val(TxtValor.Text) * 1.07
        End If

        If cbode.Text = "Euro" And cboa.Text = "Dolar c" Then
            lblrespuesta.Text = Val(TxtValor.Text) * 1.55
        End If

        If cbode.Text = "Euro" And cboa.Text = "Afgani" Then
            lblrespuesta.Text = Val(TxtValor.Text) * 92.06
        End If

        If cbode.Text = "Euro" And cboa.Text = "Peso Chileno" Then
            lblrespuesta.Text = Val(TxtValor.Text) * 935.5
        End If

        If cbode.Text = "Euro" And cboa.Text = "Colon cr" Then
            lblrespuesta.Text = Val(TxtValor.Text) * 702.31
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text) * 1.18
        End If

        If cbode.Text = "Euro" And cboa.Text = "Euro" Then
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text)
        End If

        If cbode.Text = "Euro" And cboa.Text = "Yen" Then
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text) * 124.79
        End If

        If cbode.Text = "Euro" And cboa.Text = "Peso mx" Then
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text) * 25.92
        End If

        If cbode.Text = "Euro" And cboa.Text = "Dolar aus" Then
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text) * 1.65
        End If

        If cbode.Text = "Euro" And cboa.Text = "Franco" Then
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text) * 1.07
        End If

        If cbode.Text = "Euro" And cboa.Text = "Dolar c" Then
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text) * 1.55
        End If

        If cbode.Text = "Euro" And cboa.Text = "Afgani" Then
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text) * 92.06
        End If

        If cbode.Text = "Euro" And cboa.Text = "Peso Chileno" Then
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text) * 935.5
        End If

        If cbode.Text = "Euro" And cboa.Text = "Colon cr" Then
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text) * 702.31
        End If

        '........................................................


        'Yen Japones----------------------------------------------------------
        If cbode.Text = "Yen" And cboa.Text = "Dolar" Then
            lblrespuesta.Text = Val(TxtValor.Text) * 0.0095
        End If

        If cbode.Text = "Yen" And cboa.Text = "Euro" Then
            lblrespuesta.Text = Val(TxtValor.Text) * 0.008
        End If

        If cbode.Text = "Yen" And cboa.Text = "Yen" Then
            lblrespuesta.Text = Val(TxtValor.Text)
        End If

        If cbode.Text = "Yen" And cboa.Text = "Peso mx" Then
            lblrespuesta.Text = Val(TxtValor.Text) * 0.21
        End If

        If cbode.Text = "Yen" And cboa.Text = "Dolar aus" Then
            lblrespuesta.Text = Val(TxtValor.Text) * 0.013
        End If

        If cbode.Text = "Yen" And cboa.Text = "Franco" Then
            lblrespuesta.Text = Val(TxtValor.Text) * 0.0086
        End If

        If cbode.Text = "Yen" And cboa.Text = "Dolar c" Then
            lblrespuesta.Text = Val(TxtValor.Text) * 0.012
        End If

        If cbode.Text = "Yen" And cboa.Text = "Afgani" Then
            lblrespuesta.Text = Val(TxtValor.Text) * 0.74
        End If

        If cbode.Text = "Yen" And cboa.Text = "Peso Chileno" Then
            lblrespuesta.Text = Val(TxtValor.Text) * 7.5
        End If

        If cbode.Text = "Yen" And cboa.Text = "Colon cr" Then
            lblrespuesta.Text = Val(TxtValor.Text) * 5.63
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text) * 0.0095
        End If

        If cbode.Text = "Yen" And cboa.Text = "Euro" Then
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text) * 0.008
        End If

        If cbode.Text = "Yen" And cboa.Text = "Yen" Then
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text)
        End If

        If cbode.Text = "Yen" And cboa.Text = "Peso mx" Then
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text) * 0.21
        End If

        If cbode.Text = "Yen" And cboa.Text = "Dolar aus" Then
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text) * 0.013
        End If

        If cbode.Text = "Yen" And cboa.Text = "Franco" Then
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text) * 0.0086
        End If

        If cbode.Text = "Yen" And cboa.Text = "Dolar c" Then
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text) * 0.012
        End If

        If cbode.Text = "Yen" And cboa.Text = "Afgani" Then
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text) * 0.74
        End If

        If cbode.Text = "Yen" And cboa.Text = "Peso Chileno" Then
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text) * 7.5
        End If

        If cbode.Text = "Yen" And cboa.Text = "Colon cr" Then
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text) * 5.63
        End If

        '........................................................

        'Peso Mexicano----------------------------------------------------------
        If cbode.Text = "Peso mx" And cboa.Text = "Dolar" Then
            lblrespuesta.Text = Val(TxtValor.Text) * 0.046
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text) * 0.046

        End If

        If cbode.Text = "Peso mx" And cboa.Text = "Euro" Then
            lblrespuesta.Text = Val(TxtValor.Text) * 0.039
        End If

        If cbode.Text = "Peso mx" And cboa.Text = "Yen" Then
            lblrespuesta.Text = Val(TxtValor.Text) * 4.81
        End If

        If cbode.Text = "Peso mx" And cboa.Text = "Peso mx" Then
            lblrespuesta.Text = Val(TxtValor.Text)
        End If

        If cbode.Text = "Peso mx" And cboa.Text = "Dolar aus" Then
            lblrespuesta.Text = Val(TxtValor.Text) * 0.064
        End If

        If cbode.Text = "Peso mx" And cboa.Text = "Franco" Then
            lblrespuesta.Text = Val(TxtValor.Text) * 0.041
        End If

        If cbode.Text = "Peso mx" And cboa.Text = "Dolar c" Then
            lblrespuesta.Text = Val(TxtValor.Text) * 0.06
        End If

        If cbode.Text = "Peso mx" And cboa.Text = "Afgani" Then
            lblrespuesta.Text = Val(TxtValor.Text) * 3.55
        End If

        If cbode.Text = "Peso mx" And cboa.Text = "Peso Chileno" Then
            lblrespuesta.Text = Val(TxtValor.Text) * 36.09
        End If

        If cbode.Text = "Peso mx" And cboa.Text = "Colon cr" Then
            lblrespuesta.Text = Val(TxtValor.Text) * 27.09
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text) * 0.039
        End If

        If cbode.Text = "Peso mx" And cboa.Text = "Yen" Then
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text) * 4.81
        End If

        If cbode.Text = "Peso mx" And cboa.Text = "Peso mx" Then
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text)
        End If

        If cbode.Text = "Peso mx" And cboa.Text = "Dolar aus" Then
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text) * 0.064
        End If

        If cbode.Text = "Peso mx" And cboa.Text = "Franco" Then
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text) * 0.041
        End If

        If cbode.Text = "Peso mx" And cboa.Text = "Dolar c" Then
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text) * 0.06
        End If

        If cbode.Text = "Peso mx" And cboa.Text = "Afgani" Then
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text) * 3.55
        End If

        If cbode.Text = "Peso mx" And cboa.Text = "Peso Chileno" Then
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text) * 36.09
        End If

        If cbode.Text = "Peso mx" And cboa.Text = "Colon cr" Then
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text) * 27.09
        End If

        '........................................................

        'Dolar australiano----------------------------------------------------------
        If cbode.Text = "Dolar aus" And cboa.Text = "Dolar" Then
            lblrespuesta.Text = Val(TxtValor.Text) * 0.72
        End If

        If cbode.Text = "Dolar aus" And cboa.Text = "Euro" Then
            lblrespuesta.Text = Val(TxtValor.Text) * 0.61
        End If

        If cbode.Text = "Dolar aus" And cboa.Text = "Yen" Then
            lblrespuesta.Text = Val(TxtValor.Text) * 75.75
        End If

        If cbode.Text = "Dolar aus" And cboa.Text = "Peso mx" Then
            lblrespuesta.Text = Val(TxtValor.Text) * 15.74
        End If

        If cbode.Text = "Dolar aus" And cboa.Text = "Dolar aus" Then
            lblrespuesta.Text = Val(TxtValor.Text)
        End If

        If cbode.Text = "Dolar aus" And cboa.Text = "Franco" Then
            lblrespuesta.Text = Val(TxtValor.Text) * 0.65
        End If

        If cbode.Text = "Dolar aus" And cboa.Text = "Dolar c" Then
            lblrespuesta.Text = Val(TxtValor.Text) * 0.94
        End If

        If cbode.Text = "Dolar aus" And cboa.Text = "Afgani" Then
            lblrespuesta.Text = Val(TxtValor.Text) * 55.88
        End If

        If cbode.Text = "Dolar aus" And cboa.Text = "Peso Chileno" Then
            lblrespuesta.Text = Val(TxtValor.Text) * 567.88
        End If

        If cbode.Text = "Dolar aus" And cboa.Text = "Colon cr" Then
            lblrespuesta.Text = Val(TxtValor.Text) * 426.32
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text) * 0.72
        End If

        If cbode.Text = "Dolar aus" And cboa.Text = "Euro" Then
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text) * 0.61
        End If

        If cbode.Text = "Dolar aus" And cboa.Text = "Yen" Then
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text) * 75.75
        End If

        If cbode.Text = "Dolar aus" And cboa.Text = "Peso mx" Then
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text) * 15.74
        End If

        If cbode.Text = "Dolar aus" And cboa.Text = "Dolar aus" Then
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text)
        End If

        If cbode.Text = "Dolar aus" And cboa.Text = "Franco" Then
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text) * 0.65
        End If

        If cbode.Text = "Dolar aus" And cboa.Text = "Dolar c" Then
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text) * 0.94
        End If

        If cbode.Text = "Dolar aus" And cboa.Text = "Afgani" Then
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text) * 55.88
        End If

        If cbode.Text = "Dolar aus" And cboa.Text = "Peso Chileno" Then
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text) * 567.88
        End If

        If cbode.Text = "Dolar aus" And cboa.Text = "Colon cr" Then
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text) * 426.32
        End If

        '........................................................


        'Franco suizo----------------------------------------------------------
        If cbode.Text = "Franco" And cboa.Text = "Dolar" Then
            lblrespuesta.Text = Val(TxtValor.Text) * 1.1
        End If

        If cbode.Text = "Franco" And cboa.Text = "Euro" Then
            lblrespuesta.Text = Val(TxtValor.Text) * 0.93
        End If

        If cbode.Text = "Franco" And cboa.Text = "Yen" Then
            lblrespuesta.Text = Val(TxtValor.Text) * 116.1
        End If

        If cbode.Text = "Franco" And cboa.Text = "Peso mx" Then
            lblrespuesta.Text = Val(TxtValor.Text) * 24.12
        End If

        If cbode.Text = "Franco" And cboa.Text = "Dolar aus" Then
            lblrespuesta.Text = Val(TxtValor.Text) * 1.53
        End If

        If cbode.Text = "Franco" And cboa.Text = "Franco" Then
            lblrespuesta.Text = Val(TxtValor.Text)
        End If

        If cbode.Text = "Franco" And cboa.Text = "Dolar c" Then
            lblrespuesta.Text = Val(TxtValor.Text) * 1.45
        End If

        If cbode.Text = "Franco" And cboa.Text = "Peso Chileno" Then
            lblrespuesta.Text = Val(TxtValor.Text) * 870.37
        End If

        If cbode.Text = "Franco" And cboa.Text = "Colon cr" Then
            lblrespuesta.Text = Val(TxtValor.Text) * 653.41
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text) * 1.1
        End If

        If cbode.Text = "Franco" And cboa.Text = "Euro" Then
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text) * 0.93
        End If

        If cbode.Text = "Franco" And cboa.Text = "Yen" Then
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text) * 116.1
        End If

        If cbode.Text = "Franco" And cboa.Text = "Peso mx" Then
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text) * 24.12
        End If

        If cbode.Text = "Franco" And cboa.Text = "Dolar aus" Then
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text) * 1.53
        End If

        If cbode.Text = "Franco" And cboa.Text = "Franco" Then
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text)
        End If

        If cbode.Text = "Franco" And cboa.Text = "Dolar c" Then
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text) * 1.45
        End If

        If cbode.Text = "Franco" And cboa.Text = "Peso Chileno" Then
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text) * 870.37
        End If

        If cbode.Text = "Franco" And cboa.Text = "Colon cr" Then
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text) * 653.41
        End If

        '........................................................



        'Dolar Canadiense----------------------------------------------------------
        If cbode.Text = "Dolar c" And cboa.Text = "Dolar" Then
            lblrespuesta.Text = Val(TxtValor.Text) * 0.76
        End If

        If cbode.Text = "Dolar c" And cboa.Text = "Euro" Then
            lblrespuesta.Text = Val(TxtValor.Text) * 0.64
        End If

        If cbode.Text = "Dolar c" And cboa.Text = "Yen" Then
            lblrespuesta.Text = Val(TxtValor.Text) * 80.3
        End If

        If cbode.Text = "Dolar c" And cboa.Text = "Peso mx" Then
            lblrespuesta.Text = Val(TxtValor.Text) * 16.74
        End If

        If cbode.Text = "Dolar c" And cboa.Text = "Dolar aus" Then
            lblrespuesta.Text = Val(TxtValor.Text) * 1.06
        End If

        If cbode.Text = "Dolar c" And cboa.Text = "Franco" Then
            lblrespuesta.Text = Val(TxtValor.Text) * 0.69
        End If

        If cbode.Text = "Dolar c" And cboa.Text = "Dolar c" Then
            lblrespuesta.Text = Val(TxtValor.Text)
        End If

        If cbode.Text = "Dolar c" And cboa.Text = "Afgani" Then
            lblrespuesta.Text = Val(TxtValor.Text) * 59.23
        End If

        If cbode.Text = "Dolar c" And cboa.Text = "Peso Chileno" Then
            lblrespuesta.Text = Val(TxtValor.Text) * 602.03
        End If

        If cbode.Text = "Dolar c" And cboa.Text = "Colon cr" Then
            lblrespuesta.Text = Val(TxtValor.Text) * 451.9
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text) * 0.76
        End If

        If cbode.Text = "Dolar c" And cboa.Text = "Euro" Then
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text) * 0.64
        End If

        If cbode.Text = "Dolar c" And cboa.Text = "Yen" Then
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text) * 80.3
        End If

        If cbode.Text = "Dolar c" And cboa.Text = "Peso mx" Then
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text) * 16.74
        End If

        If cbode.Text = "Dolar c" And cboa.Text = "Dolar aus" Then
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text) * 1.06
        End If

        If cbode.Text = "Dolar c" And cboa.Text = "Franco" Then
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text) * 0.69
        End If

        If cbode.Text = "Dolar c" And cboa.Text = "Dolar c" Then
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text)
        End If

        If cbode.Text = "Dolar c" And cboa.Text = "Afgani" Then
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text) * 59.23
        End If

        If cbode.Text = "Dolar c" And cboa.Text = "Peso Chileno" Then
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text) * 602.03
        End If

        If cbode.Text = "Dolar c" And cboa.Text = "Colon cr" Then
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text) * 451.9
        End If

        '........................................................


        'Afgani----------------------------------------------------------
        If cbode.Text = "afgani" And cboa.Text = "Dolar" Then
            lblrespuesta.Text = Val(TxtValor.Text) * 0.013
        End If

        If cbode.Text = "Afgani" And cboa.Text = "Euro" Then
            lblrespuesta.Text = Val(TxtValor.Text) * 0.011
        End If

        If cbode.Text = "Afgani" And cboa.Text = "Yen" Then
            lblrespuesta.Text = Val(TxtValor.Text) * 1.37
        End If

        If cbode.Text = "Afgani" And cboa.Text = "Peso mx" Then
            lblrespuesta.Text = Val(TxtValor.Text) * 0.28
        End If

        If cbode.Text = "Afgani" And cboa.Text = "Dolar aus" Then
            lblrespuesta.Text = Val(TxtValor.Text) * 0.18
        End If

        If cbode.Text = "Afgani" And cboa.Text = "Franco" Then
            lblrespuesta.Text = Val(TxtValor.Text) * 0.12
        End If

        If cbode.Text = "Afgani" And cboa.Text = "Dolar c" Then
            lblrespuesta.Text = Val(TxtValor.Text) * 0.17
        End If

        If cbode.Text = "Afgani" And cboa.Text = "Afgani" Then
            lblrespuesta.Text = Val(TxtValor.Text)
        End If

        If cbode.Text = "Afgani" And cboa.Text = "Peso Chileno" Then
            lblrespuesta.Text = Val(TxtValor.Text) * 10.27
        End If

        If cbode.Text = "Afgani" And cboa.Text = "Colon cr" Then
            lblrespuesta.Text = Val(TxtValor.Text) * 7.71
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text) * 0.013
        End If

        If cbode.Text = "Afgani" And cboa.Text = "Euro" Then
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text) * 0.011
        End If

        If cbode.Text = "Afgani" And cboa.Text = "Yen" Then
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text) * 1.37
        End If

        If cbode.Text = "Afgani" And cboa.Text = "Peso mx" Then
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text) * 0.28
        End If

        If cbode.Text = "Afgani" And cboa.Text = "Dolar aus" Then
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text) * 0.18
        End If

        If cbode.Text = "Afgani" And cboa.Text = "Franco" Then
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text) * 0.12
        End If

        If cbode.Text = "Afgani" And cboa.Text = "Dolar c" Then
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text) * 0.17
        End If

        If cbode.Text = "Afgani" And cboa.Text = "Afgani" Then
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text)
        End If

        If cbode.Text = "Afgani" And cboa.Text = "Peso Chileno" Then
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text) * 10.27
        End If

        If cbode.Text = "Afgani" And cboa.Text = "Colon cr" Then
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text) * 7.71
        End If

        '........................................................


        'Peso Chileno----------------------------------------------------------
        If cbode.Text = "Peso Chileno" And cboa.Text = "Dolar" Then
            lblrespuesta.Text = Val(TxtValor.Text) * 0.0013
        End If

        If cbode.Text = "Peso Chileno" And cboa.Text = "Euro" Then
            lblrespuesta.Text = Val(TxtValor.Text) * 0.0011
        End If

        If cbode.Text = "Peso Chileno" And cboa.Text = "Yen" Then
            lblrespuesta.Text = Val(TxtValor.Text) * 0.13
        End If

        If cbode.Text = "Peso Chileno" And cboa.Text = "Peso mx" Then
            lblrespuesta.Text = Val(TxtValor.Text) * 0.028
        End If

        If cbode.Text = "Peso Chileno" And cboa.Text = "Dolar aus" Then
            lblrespuesta.Text = Val(TxtValor.Text) * 0.0018
        End If

        If cbode.Text = "Peso Chileno" And cboa.Text = "Franco" Then
            lblrespuesta.Text = Val(TxtValor.Text) * 0.0011
        End If

        If cbode.Text = "Peso Chileno" And cboa.Text = "Dolar c" Then
            lblrespuesta.Text = Val(TxtValor.Text) * 0.0017
        End If

        If cbode.Text = "Peso Chileno" And cboa.Text = "Afgani" Then
            lblrespuesta.Text = Val(TxtValor.Text) * 0.098
        End If

        If cbode.Text = "Peso chileno" And cboa.Text = "Peso Chileno" Then
            lblrespuesta.Text = Val(TxtValor.Text)
        End If

        If cbode.Text = "Peso Chileno" And cboa.Text = "Colon cr" Then
            lblrespuesta.Text = Val(TxtValor.Text) * 0.75
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text) * 0.0013
        End If

        If cbode.Text = "Peso Chileno" And cboa.Text = "Euro" Then
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text) * 0.0011
        End If

        If cbode.Text = "Peso Chileno" And cboa.Text = "Yen" Then
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text) * 0.13
        End If

        If cbode.Text = "Peso Chileno" And cboa.Text = "Peso mx" Then
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text) * 0.028
        End If

        If cbode.Text = "Peso Chileno" And cboa.Text = "Dolar aus" Then
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text) * 0.0018
        End If

        If cbode.Text = "Peso Chileno" And cboa.Text = "Franco" Then
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text) * 0.0011
        End If

        If cbode.Text = "Peso Chileno" And cboa.Text = "Dolar c" Then
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text) * 0.0017
        End If

        If cbode.Text = "Peso Chileno" And cboa.Text = "Afgani" Then
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text) * 0.098
        End If

        If cbode.Text = "Peso chileno" And cboa.Text = "Peso Chileno" Then
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text)
        End If

        If cbode.Text = "Peso Chileno" And cboa.Text = "Colon cr" Then
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text) * 0.75
        End If

        '........................................................

        'Colon Costarricense----------------------------------------------------------
        If cbode.Text = "Colon cr" And cboa.Text = "Dolar" Then
            lblrespuesta.Text = Val(TxtValor.Text) * 0.0017
        End If

        If cbode.Text = "Colon cr" And cboa.Text = "Euro" Then
            lblrespuesta.Text = Val(TxtValor.Text) * 0.0014
        End If

        If cbode.Text = "Colon cr" And cboa.Text = "Yen" Then
            lblrespuesta.Text = Val(TxtValor.Text) * 0.18
        End If

        If cbode.Text = "Colon cr" And cboa.Text = "Peso mx" Then
            lblrespuesta.Text = Val(TxtValor.Text) * 0.037
        End If

        If cbode.Text = "Colon cr" And cboa.Text = "Dolar aus" Then
            lblrespuesta.Text = Val(TxtValor.Text) * 0.0023
        End If

        If cbode.Text = "Colon cr" And cboa.Text = "Franco" Then
            lblrespuesta.Text = Val(TxtValor.Text) * 0.0015
        End If

        If cbode.Text = "Colon cr" And cboa.Text = "Dolar c" Then
            lblrespuesta.Text = Val(TxtValor.Text) * 0.0022
        End If

        If cbode.Text = "Colon cr" And cboa.Text = "Afgani" Then
            lblrespuesta.Text = Val(TxtValor.Text) * 0.13
        End If

        If cbode.Text = "Colon cr" And cboa.Text = "Peso Chileno" Then
            lblrespuesta.Text = Val(TxtValor.Text) * 1.33
        End If

        If cbode.Text = "Colon cr" And cboa.Text = "Colon cr" Then
            lblrespuesta.Text = Val(TxtValor.Text)
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text) * 0.0017
        End If

        If cbode.Text = "Colon cr" And cboa.Text = "Euro" Then
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text) * 0.0014
        End If

        If cbode.Text = "Colon cr" And cboa.Text = "Yen" Then
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text) * 0.18
        End If

        If cbode.Text = "Colon cr" And cboa.Text = "Peso mx" Then
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text) * 0.037
        End If

        If cbode.Text = "Colon cr" And cboa.Text = "Dolar aus" Then
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text) * 0.0023
        End If

        If cbode.Text = "Colon cr" And cboa.Text = "Franco" Then
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text) * 0.0015
        End If

        If cbode.Text = "Colon cr" And cboa.Text = "Dolar c" Then
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text) * 0.0022
        End If

        If cbode.Text = "Colon cr" And cboa.Text = "Afgani" Then
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text) * 0.13
        End If

        If cbode.Text = "Colon cr" And cboa.Text = "Peso Chileno" Then
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text) * 1.33
        End If

        If cbode.Text = "Colon cr" And cboa.Text = "Colon cr" Then
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text)
        End If

        '........................................................




    End Sub



    Private Sub TabPage4_Click(sender As Object, e As EventArgs) Handles TabPage4.Click

    End Sub

    Private Sub TabPage6_Click(sender As Object, e As EventArgs) Handles TabPage6.Click

    End Sub

    Private Sub lblrespuesta_Click(sender As Object, e As EventArgs) Handles lblrespuesta.Click
    Private Sub lblrespuesta_Click(sender As Object, e As EventArgs) Handles lblrespuestaDivisas.Click

    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click

        TxtValor.Clear()
        TxtValorDivisas.Clear()


    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        MessageBox.Show("Gracias por utilizar el conversor, bonito dia :)")

        End

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnconver.Click
        'Galon----------------------------------------------------------
        If cbxselect.Text = "Galon" And cbxselect2.Text = "Galon" Then
            lblr.Text = Val(txtvalor3.Text)
        End If

        If cbxselect.Text = "Galon" And cbxselect2.Text = "Litro" Then
            lblr.Text = Val(txtvalor3.Text) * 3.78541
        End If

        If cbxselect.Text = "Galon" And cbxselect2.Text = "Cuarto (qt)" Then
            lblr.Text = Val(txtvalor3.Text) * 4
        End If

        If cbxselect.Text = "Galon" And cbxselect2.Text = "Barril" Then
            lblr.Text = Val(txtvalor3.Text) * 0.02381
        End If

        If cbxselect.Text = "Galon" And cbxselect2.Text = "Metro Cubico" Then
            lblr.Text = Val(txtvalor3.Text) / 264
        End If

        If cbxselect.Text = "Galon" And cbxselect2.Text = "Mililitro" Then
            lblr.Text = Val(txtvalor3.Text) * 3785
        End If

        If cbxselect.Text = "Galon" And cbxselect2.Text = "Pie Cubico" Then
            lblr.Text = Val(txtvalor3.Text) / 7.481
        End If

        If cbxselect.Text = "Galon" And cbxselect2.Text = "Pulgada Cubica" Then
            lblr.Text = Val(txtvalor3.Text) * 231
        End If

        If cbxselect.Text = "Galon" And cbxselect2.Text = "Yarda Cubica" Then
            lblr.Text = Val(txtvalor3.Text) / 202
        End If

        If cbxselect.Text = "Galon" And cbxselect2.Text = "Microlitro" Then
            lblr.Text = Val(txtvalor3.Text) * 3785000.0
        End If

        '........................................................

        'Litro...................................................
        If cbxselect.Text = "Litro" And cbxselect2.Text = "Galon" Then
            lblr.Text = Val(txtvalor3.Text) / 3.785
        End If

        If cbxselect.Text = "Litro" And cbxselect2.Text = "Litro" Then
            lblr.Text = Val(txtvalor3.Text)
        End If

        If cbxselect.Text = "Litro" And cbxselect2.Text = "Cuarto (qt)" Then
            lblr.Text = Val(txtvalor3.Text) * 1.0567
        End If

        If cbxselect.Text = "Litro" And cbxselect2.Text = "Barril" Then
            lblr.Text = Val(txtvalor3.Text) * 0.00628981
        End If

        If cbxselect.Text = "Litro" And cbxselect2.Text = "Metro Cubico" Then
            lblr.Text = Val(txtvalor3.Text) / 1000
        End If

        If cbxselect.Text = "Litro" And cbxselect2.Text = "Mililitro" Then
            lblr.Text = Val(txtvalor3.Text) * 1000
        End If

        If cbxselect.Text = "Litro" And cbxselect2.Text = "Pie Cubico" Then
            lblr.Text = Val(txtvalor3.Text) / 28.317
        End If

        If cbxselect.Text = "Litro" And cbxselect2.Text = "Pulgada Cubica" Then
            lblr.Text = Val(txtvalor3.Text) * 61.0237
        End If

        If cbxselect.Text = "Litro" And cbxselect2.Text = "Yarda Cubica" Then
            lblr.Text = Val(txtvalor3.Text) / 765
        End If

        If cbxselect.Text = "Litro" And cbxselect2.Text = "Microlitro" Then
            lblr.Text = Val(txtvalor3.Text) * 1000000.0
        End If

        '.........................................................

        'Cuarto (qt)..............................................
        If cbxselect.Text = "Cuarto (qt)" And cbxselect2.Text = "Galon" Then
            lblr.Text = Val(txtvalor3.Text) * 0.25
        End If

        If cbxselect.Text = "Cuarto (qt)" And cbxselect2.Text = "Litro" Then
            lblr.Text = Val(txtvalor3.Text) * 0.9464
        End If

        If cbxselect.Text = "Cuarto (qt)" And cbxselect2.Text = "Cuarto (qt)" Then
            lblr.Text = Val(txtvalor3.Text)
        End If

        If cbxselect.Text = "Cuarto (qt)" And cbxselect2.Text = "Barril" Then
            lblr.Text = Val(txtvalor3.Text) * 0.005952
        End If

        If cbxselect.Text = "Cuarto (qt)" And cbxselect2.Text = "Metro Cubico" Then
            lblr.Text = Val(txtvalor3.Text) * 0.000946
        End If

        If cbxselect.Text = "Cuarto (qt)" And cbxselect2.Text = "Mililitro" Then
            lblr.Text = Val(txtvalor3.Text) * 946.353
        End If

        If cbxselect.Text = "Cuarto (qt)" And cbxselect2.Text = "Pie Cubico" Then
            lblr.Text = Val(txtvalor3.Text) * 0.03342
        End If

        If cbxselect.Text = "Cuarto (qt)" And cbxselect2.Text = "Pulgada Cubica" Then
            lblr.Text = Val(txtvalor3.Text) * 57.75
        End If

        If cbxselect.Text = "Cuarto (qt)" And cbxselect2.Text = "Yarda Cubica" Then
            lblr.Text = Val(txtvalor3.Text) * 0.001238
        End If

        If cbxselect.Text = "Cuarto (qt)" And cbxselect2.Text = "Microlitro" Then
            lblr.Text = Val(txtvalor3.Text) * 946352.95
        End If

        '..........................................................................

        'Barril....................................................................
        If cbxselect.Text = "Barril" And cbxselect2.Text = "Galon" Then
            lblr.Text = Val(txtvalor3.Text) * 42
        End If

        If cbxselect.Text = "Barril" And cbxselect2.Text = "Litro" Then
            lblr.Text = Val(txtvalor3.Text) * 158.99
        End If

        If cbxselect.Text = "Barril" And cbxselect2.Text = "Cuarto (qt)" Then
            lblr.Text = Val(txtvalor3.Text) * 168
        End If

        If cbxselect.Text = "Barril" And cbxselect2.Text = "Barril" Then
            lblr.Text = Val(txtvalor3.Text)
        End If

        If cbxselect.Text = "Barril" And cbxselect2.Text = "Metro Cubico" Then
            lblr.Text = Val(txtvalor3.Text) * 0.158987
        End If

        If cbxselect.Text = "Barril" And cbxselect2.Text = "Mililitro" Then
            lblr.Text = Val(txtvalor3.Text) * 158987.24
        End If

        If cbxselect.Text = "Barril" And cbxselect2.Text = "Pie Cubico" Then
            lblr.Text = Val(txtvalor3.Text) * 5.6146
        End If

        If cbxselect.Text = "Barril" And cbxselect2.Text = "Pulgada Cubica" Then
            lblr.Text = Val(txtvalor3.Text) * 9702
        End If

        If cbxselect.Text = "Barril" And cbxselect2.Text = "Yarda Cubica" Then
            lblr.Text = Val(txtvalor3.Text) * 0.207948
        End If

        If cbxselect.Text = "Barril" And cbxselect2.Text = "Microlitro" Then
            lblr.Text = Val(txtvalor3.Text) * 158987238.57
        End If

        '..........................................................................

        'Metro Cubico..............................................................
        If cbxselect.Text = "Metro Cubico" And cbxselect2.Text = "Galon" Then
            lblr.Text = Val(txtvalor3.Text) * 227.02
        End If

        If cbxselect.Text = "Metro Cubico" And cbxselect2.Text = "Litro" Then
            lblr.Text = Val(txtvalor3.Text) * 1000
        End If

        If cbxselect.Text = "Metro Cubico" And cbxselect2.Text = "Cuarto (qt)" Then
            lblr.Text = Val(txtvalor3.Text) * 1056.69
        End If

        If cbxselect.Text = "Metro Cubico" And cbxselect2.Text = "Barril" Then
            lblr.Text = Val(txtvalor3.Text) * 6.28981
        End If

        If cbxselect.Text = "Metro Cubico" And cbxselect2.Text = "Metro Cubico" Then
            lblr.Text = Val(txtvalor3.Text)
        End If

        If cbxselect.Text = "Metro Cubico" And cbxselect2.Text = "Mililitro" Then
            lblr.Text = Val(txtvalor3.Text) * 1000000
        End If

        If cbxselect.Text = "Metro Cubico" And cbxselect2.Text = "Pie Cubico" Then
            lblr.Text = Val(txtvalor3.Text) * 35.3147
        End If

        If cbxselect.Text = "Metro Cubico" And cbxselect2.Text = "Pulgada Cubica" Then
            lblr.Text = Val(txtvalor3.Text) * 61023.76
        End If

        If cbxselect.Text = "Metro Cubico" And cbxselect2.Text = "Yarda Cubica" Then
            lblr.Text = Val(txtvalor3.Text) * 1.308
        End If

        If cbxselect.Text = "Metro Cubico" And cbxselect2.Text = "Microlitro" Then
            lblr.Text = Val(txtvalor3.Text) * 1000000000
        End If

        '..........................................................................

        'Mililitro................................................................
        If cbxselect.Text = "Mililitro" And cbxselect2.Text = "Galon" Then
            lblr.Text = Val(txtvalor3.Text) * 0.00026417
        End If

        If cbxselect.Text = "Mililitro" And cbxselect2.Text = "Litro" Then
            lblr.Text = Val(txtvalor3.Text) * 0.001
        End If

        If cbxselect.Text = "Mililitro" And cbxselect2.Text = "Cuarto (qt)" Then
            lblr.Text = Val(txtvalor3.Text) * 0.00105669
        End If

        If cbxselect.Text = "Mililitro" And cbxselect2.Text = "Barril" Then
            lblr.Text = Val(txtvalor3.Text) * 0.00000629
        End If

        If cbxselect.Text = "Mililitro" And cbxselect2.Text = "Metro Cubico" Then
            lblr.Text = Val(txtvalor3.Text) * 0.000001
        End If

        If cbxselect.Text = "Mililitro" And cbxselect2.Text = "Mililitro" Then
            lblr.Text = Val(txtvalor3.Text)
        End If

        If cbxselect.Text = "Mililitro" And cbxselect2.Text = "Pie Cubico" Then
            lblr.Text = Val(txtvalor3.Text) * 0.0000353147
        End If

        If cbxselect.Text = "Mililitro" And cbxselect2.Text = "Pulgada Cubica" Then
            lblr.Text = Val(txtvalor3.Text) * 0.061024
        End If

        If cbxselect.Text = "Mililitro" And cbxselect2.Text = "Yarda Cubica" Then
            lblr.Text = Val(txtvalor3.Text) * 0.000001308
        End If

        If cbxselect.Text = "Mililitro" And cbxselect2.Text = "Microlitro" Then
            lblr.Text = Val(txtvalor3.Text) * 1000
        End If

        '..........................................................................

        'Pie Cubico................................................................
        If cbxselect.Text = "Pie Cubico" And cbxselect2.Text = "Galon" Then
            lblr.Text = Val(txtvalor3.Text) * 7.4805
        End If

        If cbxselect.Text = "Pie Cubico" And cbxselect2.Text = "Litro" Then
            lblr.Text = Val(txtvalor3.Text) * 28.3168
        End If

        If cbxselect.Text = "Pie Cubico" And cbxselect2.Text = "Cuarto (qt)" Then
            lblr.Text = Val(txtvalor3.Text) * 25.714
        End If

        If cbxselect.Text = "Pie Cubico" And cbxselect2.Text = "Barril" Then
            lblr.Text = Val(txtvalor3.Text) * 0.17811
        End If

        If cbxselect.Text = "Pie Cubico" And cbxselect2.Text = "Metro Cubico" Then
            lblr.Text = Val(txtvalor3.Text) * 0.028317
        End If

        If cbxselect.Text = "Pie Cubico" And cbxselect2.Text = "Mililitro" Then
            lblr.Text = Val(txtvalor3.Text) * 28316.84
        End If

        If cbxselect.Text = "Pie Cubico" And cbxselect2.Text = "Pie Cubico" Then
            lblr.Text = Val(txtvalor3.Text)
        End If

        If cbxselect.Text = "Pie Cubico" And cbxselect2.Text = "Pulgada Cubica" Then
            lblr.Text = Val(txtvalor3.Text) * 1728
        End If

        If cbxselect.Text = "Pie Cubico" And cbxselect2.Text = "Yarda Cubica" Then
            lblr.Text = Val(txtvalor3.Text) * 0.037037
        End If

        If cbxselect.Text = "Pie Cubico" And cbxselect2.Text = "Microlitro" Then
            lblr.Text = Val(txtvalor3.Text) * 28316835.94
        End If

        '..........................................................................

        'Pie Cubico................................................................
        If cbxselect.Text = "Pulgada Cubica" And cbxselect2.Text = "Galon" Then
            lblr.Text = Val(txtvalor3.Text) * 0.0037202
        End If

        If cbxselect.Text = "Pulgada Cubica" And cbxselect2.Text = "Litro" Then
            lblr.Text = Val(txtvalor3.Text) * 0.016387
        End If

        If cbxselect.Text = "Pulgada Cubica" And cbxselect2.Text = "Cuarto (qt)" Then
            lblr.Text = Val(txtvalor3.Text) * 0.017316
        End If

        If cbxselect.Text = "Pulgada Cubica" And cbxselect2.Text = "Barril" Then
            lblr.Text = Val(txtvalor3.Text) * 0.0001031
        End If

        If cbxselect.Text = "Pulgada Cubica" And cbxselect2.Text = "Metro Cubico" Then
            lblr.Text = Val(txtvalor3.Text) * 0.0000163871
        End If

        If cbxselect.Text = "Pulgada Cubica" And cbxselect2.Text = "Mililitro" Then
            lblr.Text = Val(txtvalor3.Text) * 16.3871
        End If

        If cbxselect.Text = "Pulgada Cubica" And cbxselect2.Text = "Pie Cubico" Then
            lblr.Text = Val(txtvalor3.Text) * 0.0005787
        End If

        If cbxselect.Text = "Pulgada Cubica" And cbxselect2.Text = "Pulgada Cubica" Then
            lblr.Text = Val(txtvalor3.Text)
        End If

        If cbxselect.Text = "Pulgada Cubica" And cbxselect2.Text = "Yarda Cubica" Then
            lblr.Text = Val(txtvalor3.Text) * 0.0000214335
        End If

        If cbxselect.Text = "Pulgada Cubica" And cbxselect2.Text = "Microlitro" Then
            lblr.Text = Val(txtvalor3.Text) * 16387.06
        End If

        '..........................................................................

        'Yarda Cubica................................................................
        If cbxselect.Text = "Yarda Cubica" And cbxselect2.Text = "Galon" Then
            lblr.Text = Val(txtvalor3.Text) * 201.97
        End If

        If cbxselect.Text = "Yarda Cubica" And cbxselect2.Text = "Litro" Then
            lblr.Text = Val(txtvalor3.Text) * 764.55
        End If

        If cbxselect.Text = "Yarda Cubica" And cbxselect2.Text = "Cuarto (qt)" Then
            lblr.Text = Val(txtvalor3.Text) * 807.9
        End If

        If cbxselect.Text = "Yarda Cubica" And cbxselect2.Text = "Barril" Then
            lblr.Text = Val(txtvalor3.Text) * 4.80891
        End If

        If cbxselect.Text = "Yarda Cubica" And cbxselect2.Text = "Metro Cubico" Then
            lblr.Text = Val(txtvalor3.Text) * 0.764555
        End If

        If cbxselect.Text = "Yarda Cubica" And cbxselect2.Text = "Mililitro" Then
            lblr.Text = Val(txtvalor3.Text) * 764554.64
        End If

        If cbxselect.Text = "Yarda Cubica" And cbxselect2.Text = "Pie Cubico" Then
            lblr.Text = Val(txtvalor3.Text) * 27
        End If

        If cbxselect.Text = "Yarda Cubica" And cbxselect2.Text = "Pulgada Cubica" Then
            lblr.Text = Val(txtvalor3.Text) * 46656
        End If

        If cbxselect.Text = "Yarda Cubica" And cbxselect2.Text = "Yarda Cubica" Then
            lblr.Text = Val(txtvalor3.Text)
        End If

        If cbxselect.Text = "Yarda Cubica" And cbxselect2.Text = "Microlitro" Then
            lblr.Text = Val(txtvalor3.Text) * 764554635.46
        End If

        '..........................................................................

        'Microlitro................................................................
        If cbxselect.Text = "Microlitro" And cbxselect2.Text = "Galon" Then
            lblr.Text = Val(txtvalor3.Text) * 2.641722 * 10 ^ -7
        End If

        If cbxselect.Text = "Microlitro" And cbxselect2.Text = "Litro" Then
            lblr.Text = Val(txtvalor3.Text) * 0.000001
        End If

        If cbxselect.Text = "Microlitro" And cbxselect2.Text = "Cuarto (qt)" Then
            lblr.Text = Val(txtvalor3.Text) * 0.0000010567
        End If

        If cbxselect.Text = "Microlitro" And cbxselect2.Text = "Barril" Then
            lblr.Text = Val(txtvalor3.Text) * 6.289813 * 10 ^ -9
        End If

        If cbxselect.Text = "Microlitro" And cbxselect2.Text = "Metro Cubico" Then
            lblr.Text = Val(txtvalor3.Text) * 1 * 10 ^ -9
        End If

        If cbxselect.Text = "Microlitro" And cbxselect2.Text = "Mililitro" Then
            lblr.Text = Val(txtvalor3.Text) * 0.001
        End If

        If cbxselect.Text = "Microlitro" And cbxselect2.Text = "Pie Cubico" Then
            lblr.Text = Val(txtvalor3.Text) * 3.531468 * 10 ^ -8
        End If

        If cbxselect.Text = "Microlitro" And cbxselect2.Text = "Pulgada Cubica" Then
            lblr.Text = Val(txtvalor3.Text) * 0.0000610238
        End If

        If cbxselect.Text = "Microlitro" And cbxselect2.Text = "Yarda Cubica" Then
            lblr.Text = Val(txtvalor3.Text) * 1.307951 * 10 ^ -9
        End If

        If cbxselect.Text = "Microlitro" And cbxselect2.Text = "Microlitro" Then
            lblr.Text = Val(txtvalor3.Text)
        End If

        '..........................................................................

    End Sub

    Private Sub ComboBox6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxselect2.SelectedIndexChanged

    End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        txtvalor3.Clear()
    End Sub



    Private Sub btnlongitud_Click(sender As Object, e As EventArgs) Handles btnlongitud.Click
        If cbxentrada.Text = "Milimetros" And cbxsalida.Text = "Milimetros" Then
            lblres.Text = Val(txtcodigo.Text)
            lblnum.Text = "mm"
        ElseIf cbxentrada.Text = "Milimetros" And cbxsalida.Text = "Centimetros" Then
            lblres.Text = Val(txtcodigo.Text) / 10
            lblnum.Text = "cm"
        ElseIf cbxentrada.Text = "Milimetros" And cbxsalida.Text = "Metros" Then
            lblres.Text = Val(txtcodigo.Text) / 1000
            lblnum.Text = "m"
        ElseIf cbxentrada.Text = "Milimetros" And cbxsalida.Text = "Kilometros" Then
            lblres.Text = Val(txtcodigo.Text) / 1000000
            lblnum.Text = "km"
        ElseIf cbxentrada.Text = "Milimetros" And cbxsalida.Text = "Pulgada" Then
            lblres.Text = Val(txtcodigo.Text) * 0.0394
            lblnum.Text = "pulg"
        ElseIf cbxentrada.Text = "Milimetros" And cbxsalida.Text = "Pie" Then
            lblres.Text = Val(txtcodigo.Text) * 0.00328084
            lblnum.Text = "pastel"
        ElseIf cbxentrada.Text = "Milimetros" And cbxsalida.Text = "Yarda" Then
            lblres.Text = Val(txtcodigo.Text) * 0.00109361
            lblnum.Text = "yarda"
        ElseIf cbxentrada.Text = "Milimetros" And cbxsalida.Text = "Milla" Then
            lblres.Text = Val(txtcodigo.Text) * 0.000000621371
            lblnum.Text = "milla"
        ElseIf cbxentrada.Text = "Milimetros" And cbxsalida.Text = "Decámetro" Then
            lblres.Text = Val(txtcodigo.Text) * 0.0001
            lblnum.Text = "presa"
        ElseIf cbxentrada.Text = "Milimetros" And cbxsalida.Text = "Decímetro" Then
            lblres.Text = Val(txtcodigo.Text) * 0.01
            lblnum.Text = "dm"

        ElseIf cbxentrada.Text = "Centimetros" And cbxsalida.Text = "Milimetros" Then
            lblres.Text = Val(txtcodigo.Text) * 10
            lblnum.Text = "mm"
        ElseIf cbxentrada.Text = "Centimetros" And cbxsalida.Text = "Centimetros" Then
            lblres.Text = Val(txtcodigo.Text)
            lblnum.Text = "cm"
        ElseIf cbxentrada.Text = "Centimetros" And cbxsalida.Text = "Metros" Then
            lblres.Text = Val(txtcodigo.Text) / 100
            lblnum.Text = "m"
        ElseIf cbxentrada.Text = "Centimetros" And cbxsalida.Text = "Kilometros" Then
            lblres.Text = Val(txtcodigo.Text) / 100000
            lblnum.Text = "km"
        ElseIf cbxentrada.Text = "Centimetros" And cbxsalida.Text = "Pulgada" Then
            lblres.Text = Val(txtcodigo.Text) * 0.393701
            lblnum.Text = "pulg"
        ElseIf cbxentrada.Text = "Centimetros" And cbxsalida.Text = "Pie" Then
            lblres.Text = Val(txtcodigo.Text) * 0.0328084
            lblnum.Text = "pastel"
        ElseIf cbxentrada.Text = "Centimetros" And cbxsalida.Text = "Yarda" Then
            lblres.Text = Val(txtcodigo.Text) * 0.0109361
            lblnum.Text = "yarda"
        ElseIf cbxentrada.Text = "Centimetros" And cbxsalida.Text = "Milla" Then
            lblres.Text = Val(txtcodigo.Text) * 0.00000621371
            lblnum.Text = "Milla"
        ElseIf cbxentrada.Text = "Centimetros" And cbxsalida.Text = "Decámetro" Then
            lblres.Text = Val(txtcodigo.Text) * 0.001
            lblnum.Text = "presa"
        ElseIf cbxentrada.Text = "Centimetros" And cbxsalida.Text = "Decímetro" Then
            lblres.Text = Val(txtcodigo.Text) * 0.1
            lblnum.Text = "dm"

        ElseIf cbxentrada.Text = "Metros" And cbxsalida.Text = "Milimetros" Then
            lblres.Text = Val(txtcodigo.Text) * 1000
            lblnum.Text = "mm"
        ElseIf cbxentrada.Text = "Metros" And cbxsalida.Text = "Centimetros" Then
            lblres.Text = Val(txtcodigo.Text) * 100
            lblnum.Text = "cm"
        ElseIf cbxentrada.Text = "Metros" And cbxsalida.Text = "Metros" Then
            lblres.Text = Val(txtcodigo.Text)
            lblnum.Text = "m"
        ElseIf cbxentrada.Text = "Metros" And cbxsalida.Text = "Kilometros" Then
            lblres.Text = Val(txtcodigo.Text) / 1000
            lblnum.Text = "km"
        ElseIf cbxentrada.Text = "Metros" And cbxsalida.Text = "Pulgada" Then
            lblres.Text = Val(txtcodigo.Text) * 39.3701
            lblnum.Text = "pulg"
        ElseIf cbxentrada.Text = "Metros" And cbxsalida.Text = "Pie" Then
            lblres.Text = Val(txtcodigo.Text) * 3.28084
            lblnum.Text = "pastel"
        ElseIf cbxentrada.Text = "Metros" And cbxsalida.Text = "Yarda" Then
            lblres.Text = Val(txtcodigo.Text) * 1.09361
            lblnum.Text = "yarda"
        ElseIf cbxentrada.Text = "Metros" And cbxsalida.Text = "Milla" Then
            lblres.Text = Val(txtcodigo.Text) * 0.000621371
            lblnum.Text = "milla"
        ElseIf cbxentrada.Text = "Metros" And cbxsalida.Text = "Decámetro" Then
            lblres.Text = Val(txtcodigo.Text) * 0.1
            lblnum.Text = "presa"
        ElseIf cbxentrada.Text = "Metros" And cbxsalida.Text = "Decímetro" Then
            lblres.Text = Val(txtcodigo.Text) * 10
            lblnum.Text = "dm"


        ElseIf cbxentrada.Text = "Kilometros" And cbxsalida.Text = "Milimetros" Then
            lblres.Text = Val(txtcodigo.Text) * 1000000.0
            lblnum.Text = "mm"
        ElseIf cbxentrada.Text = "Kilometros" And cbxsalida.Text = "Centimetros" Then
            lblres.Text = Val(txtcodigo.Text) * 100000
            lblnum.Text = "cm"
        ElseIf cbxentrada.Text = "Kilometros" And cbxsalida.Text = "Metros" Then
            lblres.Text = Val(txtcodigo.Text) * 1000
            lblnum.Text = "m"
        ElseIf cbxentrada.Text = "Kilometros" And cbxsalida.Text = "Kilometros" Then
            lblres.Text = Val(txtcodigo.Text)
            lblnum.Text = "km"
        ElseIf cbxentrada.Text = "Kilometros" And cbxsalida.Text = "Pulgada" Then
            lblres.Text = Val(txtcodigo.Text) * 39370
            lblnum.Text = "pulg"
        ElseIf cbxentrada.Text = "Kilometros" And cbxsalida.Text = "Pie" Then
            lblres.Text = Val(txtcodigo.Text) * 3281
            lblnum.Text = "pastel"
        ElseIf cbxentrada.Text = "Kilometros" And cbxsalida.Text = "Yarda" Then
            lblres.Text = Val(txtcodigo.Text) * 1094
            lblnum.Text = "yarda"
        ElseIf cbxentrada.Text = "Kilometros" And cbxsalida.Text = "Milla" Then
            lblres.Text = Val(txtcodigo.Text) / 1.609
            lblnum.Text = "milla"
        ElseIf cbxentrada.Text = "Kilometros" And cbxsalida.Text = "Decámetro" Then
            lblres.Text = Val(txtcodigo.Text) * 100
            lblnum.Text = "presa"
        ElseIf cbxentrada.Text = "Kilometros" And cbxsalida.Text = "Decímetro" Then
            lblres.Text = Val(txtcodigo.Text) * 10000
            lblnum.Text = "dm"


        ElseIf cbxentrada.Text = "Pulgada" And cbxsalida.Text = "Milimetros" Then
            lblres.Text = Val(txtcodigo.Text) * 25.4
            lblnum.Text = "mm"
        ElseIf cbxentrada.Text = "Pulgada" And cbxsalida.Text = "Centimetros" Then
            lblres.Text = Val(txtcodigo.Text) * 2.54
            lblnum.Text = "cm"
        ElseIf cbxentrada.Text = "Pulgada" And cbxsalida.Text = "Metros" Then
            lblres.Text = Val(txtcodigo.Text) / 39.97
            lblnum.Text = "m"
        ElseIf cbxentrada.Text = "Pulgada" And cbxsalida.Text = "Kilometros" Then
            lblres.Text = Val(txtcodigo.Text) / 39370
            lblnum.Text = "km"
        ElseIf cbxentrada.Text = "Pulgada" And cbxsalida.Text = "Pulgada" Then
            lblres.Text = Val(txtcodigo.Text)
            lblnum.Text = "pulg"
        ElseIf cbxentrada.Text = "Pulgada" And cbxsalida.Text = "Pie" Then
            lblres.Text = Val(txtcodigo.Text) / 12
            lblnum.Text = "pastel"
        ElseIf cbxentrada.Text = "Pulgada" And cbxsalida.Text = "Yarda" Then
            lblres.Text = Val(txtcodigo.Text) / 36
            lblnum.Text = "yarda"
        ElseIf cbxentrada.Text = "Pulgada" And cbxsalida.Text = "Milla" Then
            lblres.Text = Val(txtcodigo.Text) / 63360
            lblnum.Text = "milla"
        ElseIf cbxentrada.Text = "Pulgada" And cbxsalida.Text = "Decámetro" Then
            lblres.Text = Val(txtcodigo.Text) / 394
            lblnum.Text = "presa"
        ElseIf cbxentrada.Text = "Pulgada" And cbxsalida.Text = "Decímetro" Then
            lblres.Text = Val(txtcodigo.Text) / 3.937
            lblnum.Text = "dm"


        ElseIf cbxentrada.Text = "Pie" And cbxsalida.Text = "Milimetros" Then
            lblres.Text = Val(txtcodigo.Text) * 305
            lblnum.Text = "mm"
        ElseIf cbxentrada.Text = "Pie" And cbxsalida.Text = "Centimetros" Then
            lblres.Text = Val(txtcodigo.Text) * 30.48
            lblnum.Text = "cm"
        ElseIf cbxentrada.Text = "Pie" And cbxsalida.Text = "Metros" Then
            lblres.Text = Val(txtcodigo.Text) / 3.281
            lblnum.Text = "m"
        ElseIf cbxentrada.Text = "Pie" And cbxsalida.Text = "Kilometros" Then
            lblres.Text = Val(txtcodigo.Text) / 3281
            lblnum.Text = "km"
        ElseIf cbxentrada.Text = "Pie" And cbxsalida.Text = "Pulgada" Then
            lblres.Text = Val(txtcodigo.Text) * 12
            lblnum.Text = "pulg"
        ElseIf cbxentrada.Text = "Pie" And cbxsalida.Text = "Pie" Then
            lblres.Text = Val(txtcodigo.Text)
            lblnum.Text = "pastel"
        ElseIf cbxentrada.Text = "Pie" And cbxsalida.Text = "Yarda" Then
            lblres.Text = Val(txtcodigo.Text) / 3
            lblnum.Text = "yarda"
        ElseIf cbxentrada.Text = "Pie" And cbxsalida.Text = "Milla" Then
            lblres.Text = Val(txtcodigo.Text) / 5280
            lblnum.Text = "milla"
        ElseIf cbxentrada.Text = "Pie" And cbxsalida.Text = "Decámetro" Then
            lblres.Text = Val(txtcodigo.Text) / 32.808
            lblnum.Text = "presa"
        ElseIf cbxentrada.Text = "Pie" And cbxsalida.Text = "Decímetro" Then
            lblres.Text = Val(txtcodigo.Text) * 3.048
            lblnum.Text = "dm"


        ElseIf cbxentrada.Text = "Yarda" And cbxsalida.Text = "Milimetros" Then
            lblres.Text = Val(txtcodigo.Text) * 914
            lblnum.Text = "mm"
        ElseIf cbxentrada.Text = "Yarda" And cbxsalida.Text = "Centimetros" Then
            lblres.Text = Val(txtcodigo.Text) * 91.44
            lblnum.Text = "cm"
        ElseIf cbxentrada.Text = "Yarda" And cbxsalida.Text = "Metros" Then
            lblres.Text = Val(txtcodigo.Text) / 1.094
            lblnum.Text = "m"
        ElseIf cbxentrada.Text = "Yarda" And cbxsalida.Text = "Kilometros" Then
            lblres.Text = Val(txtcodigo.Text) / 1094
            lblnum.Text = "km"
        ElseIf cbxentrada.Text = "Yarda" And cbxsalida.Text = "Pulgada" Then
            lblres.Text = Val(txtcodigo.Text) * 36
            lblnum.Text = "pulg"
        ElseIf cbxentrada.Text = "Yarda" And cbxsalida.Text = "Pie" Then
            lblres.Text = Val(txtcodigo.Text) * 3
            lblnum.Text = "pastel"
        ElseIf cbxentrada.Text = "Yarda" And cbxsalida.Text = "Yarda" Then
            lblres.Text = Val(txtcodigo.Text)
            lblnum.Text = "yarda"
        ElseIf cbxentrada.Text = "Yarda" And cbxsalida.Text = "Milla" Then
            lblres.Text = Val(txtcodigo.Text) / 1760
            lblnum.Text = "milla"
        ElseIf cbxentrada.Text = "Yarda" And cbxsalida.Text = "Decámetro" Then
            lblres.Text = Val(txtcodigo.Text) / 10.936
            lblnum.Text = "presa"
        ElseIf cbxentrada.Text = "Yarda" And cbxsalida.Text = "Decímetro" Then
            lblres.Text = Val(txtcodigo.Text) * 9.144
            lblnum.Text = "dm"


        ElseIf cbxentrada.Text = "Milla" And cbxsalida.Text = "Milimetros" Then
            lblres.Text = Val(txtcodigo.Text) * 1609000.0
            lblnum.Text = "mm"
        ElseIf cbxentrada.Text = "Milla" And cbxsalida.Text = "Centimetros" Then
            lblres.Text = Val(txtcodigo.Text) * 160934
            lblnum.Text = "cm"
        ElseIf cbxentrada.Text = "Milla" And cbxsalida.Text = "Metros" Then
            lblres.Text = Val(txtcodigo.Text) * 1609
            lblnum.Text = "m"
        ElseIf cbxentrada.Text = "Milla" And cbxsalida.Text = "Kilometros" Then
            lblres.Text = Val(txtcodigo.Text) * 1.609
            lblnum.Text = "km"
        ElseIf cbxentrada.Text = "Milla" And cbxsalida.Text = "Pulgada" Then
            lblres.Text = Val(txtcodigo.Text) * 63360
            lblnum.Text = "pulg"
        ElseIf cbxentrada.Text = "Milla" And cbxsalida.Text = "Pie" Then
            lblres.Text = Val(txtcodigo.Text) * 5280
            lblnum.Text = "pastel"
        ElseIf cbxentrada.Text = "Milla" And cbxsalida.Text = "Yarda" Then
            lblres.Text = Val(txtcodigo.Text) * 1760
            lblnum.Text = "yarda"
        ElseIf cbxentrada.Text = "Milla" And cbxsalida.Text = "Milla" Then
            lblres.Text = Val(txtcodigo.Text)
            lblnum.Text = "milla"
        ElseIf cbxentrada.Text = "Milla" And cbxsalida.Text = "Decámetro" Then
            lblres.Text = Val(txtcodigo.Text) * 161
            lblnum.Text = "presa"
        ElseIf cbxentrada.Text = "Milla" And cbxsalida.Text = "Decímetro" Then
            lblres.Text = Val(txtcodigo.Text) * 16093
            lblnum.Text = "dm"

        ElseIf cbxentrada.Text = "Decámetro" And cbxsalida.Text = "Milimetros" Then
            lblres.Text = Val(txtcodigo.Text) * 10000
            lblnum.Text = "mm"
        ElseIf cbxentrada.Text = "Decámetro" And cbxsalida.Text = "Centimetros" Then
            lblres.Text = Val(txtcodigo.Text) * 1000
            lblnum.Text = "cm"
        ElseIf cbxentrada.Text = "Decámetro" And cbxsalida.Text = "Metros" Then
            lblres.Text = Val(txtcodigo.Text) * 10
            lblnum.Text = "m"
        ElseIf cbxentrada.Text = "Decámetro" And cbxsalida.Text = "Kilometros" Then
            lblres.Text = Val(txtcodigo.Text) / 100
            lblnum.Text = "km"
        ElseIf cbxentrada.Text = "Decámetro" And cbxsalida.Text = "Pulgada" Then
            lblres.Text = Val(txtcodigo.Text) * 394
            lblnum.Text = "pulg"
        ElseIf cbxentrada.Text = "Decámetro" And cbxsalida.Text = "Pie" Then
            lblres.Text = Val(txtcodigo.Text) * 32.808
            lblnum.Text = "pastel"
        ElseIf cbxentrada.Text = "Decámetro" And cbxsalida.Text = "Yarda" Then
            lblres.Text = Val(txtcodigo.Text) * 10.936
            lblnum.Text = "yarda"
        ElseIf cbxentrada.Text = "Decámetro" And cbxsalida.Text = "Milla" Then
            lblres.Text = Val(txtcodigo.Text) / 161
            lblnum.Text = "milla"
        ElseIf cbxentrada.Text = "Decámetro" And cbxsalida.Text = "Decámetro" Then
            lblres.Text = Val(txtcodigo.Text)
            lblnum.Text = "presa"
        ElseIf cbxentrada.Text = "Decámetro" And cbxsalida.Text = "Decímetro" Then
            lblres.Text = Val(txtcodigo.Text) * 100
            lblnum.Text = "dm"


        ElseIf cbxentrada.Text = "Decímetro" And cbxsalida.Text = "Milimetros" Then
            lblres.Text = Val(txtcodigo.Text) * 100
            lblnum.Text = "mm"
        ElseIf cbxentrada.Text = "Decímetro" And cbxsalida.Text = "Centimetros" Then
            lblres.Text = Val(txtcodigo.Text) * 10
            lblnum.Text = "cm"
        ElseIf cbxentrada.Text = "Decímetro" And cbxsalida.Text = "Metros" Then
            lblres.Text = Val(txtcodigo.Text) / 10
            lblnum.Text = "m"
        ElseIf cbxentrada.Text = "Decímetro" And cbxsalida.Text = "Kilometros" Then
            lblres.Text = Val(txtcodigo.Text) / 10000
            lblnum.Text = "km"
        ElseIf cbxentrada.Text = "Decímetro" And cbxsalida.Text = "Pulgada" Then
            lblres.Text = Val(txtcodigo.Text) * 3.937
            lblnum.Text = "pulg"
        ElseIf cbxentrada.Text = "Decímetro" And cbxsalida.Text = "Pie" Then
            lblres.Text = Val(txtcodigo.Text) / 3.048
            lblnum.Text = "pastel"
        ElseIf cbxentrada.Text = "Decímetro" And cbxsalida.Text = "Yarda" Then
            lblres.Text = Val(txtcodigo.Text) / 9.144
            lblnum.Text = "yarda"
        ElseIf cbxentrada.Text = "Decímetro" And cbxsalida.Text = "Milla" Then
            lblres.Text = Val(txtcodigo.Text) / 16093
            lblnum.Text = "milla"
        ElseIf cbxentrada.Text = "Decímetro" And cbxsalida.Text = "Decámetro" Then
            lblres.Text = Val(txtcodigo.Text) / 100
            lblnum.Text = "presa"
        ElseIf cbxentrada.Text = "Decímetro" And cbxsalida.Text = "Decímetro" Then
            lblres.Text = Val(txtcodigo.Text)
            lblnum.Text = "dm"
        End If
    End Sub

    Private Sub btnnue_Click(sender As Object, e As EventArgs) Handles btnnue.Click
        txtcodigo.Clear()
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        MessageBox.Show("Gracias por utilizar el conversor, bonito dia :)")
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        MessageBox.Show("Gracias por utilizar el conversor, bonito dia :)")
  
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '-------------------Empezamos con el conversore de masa----------------
        '----------------------........TONELADAS...........---------------------
        If cbode2.Text = "Tonelada" And cboa2.Text = "Tonelada" Then
            lblrespuesta2.Text = Val(txtvalor2.Text)
            lblno.Text = "Toneladas"
        End If


        If cbode2.Text = "Tonelada" And cboa2.Text = "Decagramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 100000
            lblno.Text = "DG"
        End If

        If cbode2.Text = "Tonelada" And cboa2.Text = "Kilogramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 1000
            lblno.Text = "KG"
        End If

        If cbode2.Text = "Tonelada" And cboa2.Text = "Hectogramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 10000
            lblno.Text = "HG"
        End If

        If cbode2.Text = "Tonelada" And cboa2.Text = "Gramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 1000000
            lblno.Text = "G"
        End If

        If cbode2.Text = "Tonelada" And cboa2.Text = "Quilate" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 50000000
            lblno.Text = "Q"
        End If

        If cbode2.Text = "Tonelada" And cboa2.Text = "Centigramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 100000000
            lblno.Text = "CG"
        End If

        If cbode2.Text = "Tonelada" And cboa2.Text = "Miligramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 1000000000
            lblno.Text = "MG"
        End If

        If cbode2.Text = "Tonelada" And cboa2.Text = "Libra" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 2204.62
            lblno.Text = "LB"
        End If

        If cbode2.Text = "Tonelada" And cboa2.Text = "Quintal" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 10
            lblno.Text = "Quintal"
        End If




        '----------------------........Decagramos...........---------------------
        If cbode2.Text = "Decagramo" And cboa2.Text = "Tonelada" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) / 100000
            lblno.Text = "Tonelada"
        End If


        If cbode2.Text = "Decagramo" And cboa2.Text = "Decagramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text)
            lblno.Text = "DG"
        End If

        If cbode2.Text = "Decagramo" And cboa2.Text = "Kilogramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) / 100
            lblno.Text = "KG"
        End If

        If cbode2.Text = "Decagramo" And cboa2.Text = "Hectogramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) / 0.1
            lblno.Text = "HG"
        End If

        If cbode2.Text = "Decagramo" And cboa2.Text = "Gramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 10
            lblno.Text = "G"
        End If

        If cbode2.Text = "Decagramo" And cboa2.Text = "Quilate" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 50
            lblno.Text = "Q"
        End If

        If cbode2.Text = "Decagramo" And cboa2.Text = "Centigramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 1000
            lblno.Text = "CG"
        End If

        If cbode2.Text = "Decagramo" And cboa2.Text = "Miligramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 10000
            lblno.Text = "MG"
        End If

        If cbode2.Text = "Decagramo" And cboa2.Text = "Libra" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) / 45.359
            lblno.Text = "LB"
        End If

        If cbode2.Text = "Decagramo" And cboa2.Text = "Quintal" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) / 10000
            lblno.Text = "Quintal"
        End If





        '----------------------........Kilogramo...........---------------------
        If cbode2.Text = "Kilogramo" And cboa2.Text = "Tonelada" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) / 1000
            lblno.Text = "Tonelada"
        End If


        If cbode2.Text = "Kilogramo" And cboa2.Text = "Decagramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 100
            lblno.Text = "DG"
        End If

        If cbode2.Text = "Kilogramo" And cboa2.Text = "Kilogramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text)
            lblno.Text = "KG"
        End If

        If cbode2.Text = "Kilogramo" And cboa2.Text = "Hectogramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 10
            lblno.Text = "HG"
        End If

        If cbode2.Text = "Kilogramo" And cboa2.Text = "Gramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 1000
            lblno.Text = "G"
        End If

        If cbode2.Text = "Kilogramo" And cboa2.Text = "Quilate" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 5000
            lblno.Text = "Q"
        End If

        If cbode2.Text = "Kilogramo" And cboa2.Text = "Centigramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 100000
            lblno.Text = "CG"
        End If

        If cbode2.Text = "Kilogramo" And cboa2.Text = "Miligramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 1000000
            lblno.Text = "MG"
        End If

        If cbode2.Text = "Kilogramo" And cboa2.Text = "Libra" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 2.205
            lblno.Text = "LB"
        End If

        If cbode2.Text = "Kilogramo" And cboa2.Text = "Quintal" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) / 100
            lblno.Text = "Quintal"
        End If




        '----------------------........Hectogramo...........---------------------
        If cbode2.Text = "Hectogramo" And cboa2.Text = "Tonelada" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) / 10000
            lblno.Text = "Tonelada"
        End If


        If cbode2.Text = "Hectogramo" And cboa2.Text = "Decagramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 10
            lblno.Text = "DG"
        End If

        If cbode2.Text = "Hectogramo" And cboa2.Text = "Kilogramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) / 10
            lblno.Text = "KG"
        End If

        If cbode2.Text = "Hectogramo" And cboa2.Text = "Hectogramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text)
            lblno.Text = "HG"
        End If

        If cbode2.Text = "Hectogramo" And cboa2.Text = "Gramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 100
            lblno.Text = "G"
        End If

        If cbode2.Text = "Hectogramo" And cboa2.Text = "Quilate" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 500
            lblno.Text = "Q"
        End If

        If cbode2.Text = "Hectogramo" And cboa2.Text = "Centigramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 10000
            lblno.Text = "CG"
        End If

        If cbode2.Text = "Hectogramo" And cboa2.Text = "Miligramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 100000
            lblno.Text = "MG"
        End If

        If cbode2.Text = "Hectogramo" And cboa2.Text = "Libra" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) / 4.536
            lblno.Text = "LB"
        End If

        If cbode2.Text = "Hectogramo" And cboa2.Text = "Quintal" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) / 1000
            lblno.Text = "Quintal"
        End If



        '----------------------........Gramo...........---------------------
        If cbode2.Text = "Gramo" And cboa2.Text = "Tonelada" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) / 1000000
            lblno.Text = "Tonelada"
        End If


        If cbode2.Text = "Gramo" And cboa2.Text = "Decagramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 10
            lblno.Text = "DG"
        End If

        If cbode2.Text = "Gramo" And cboa2.Text = "Kilogramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) / 1000
            lblno.Text = "KG"
        End If

        If cbode2.Text = "Gramo" And cboa2.Text = "Hectogramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 100
            lblno.Text = "HG"
        End If

        If cbode2.Text = "Gramo" And cboa2.Text = "Gramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text)
            lblno.Text = "G"
        End If

        If cbode2.Text = "Gramo" And cboa2.Text = "Quilate" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 5
            lblno.Text = "Q"
        End If

        If cbode2.Text = "Gramo" And cboa2.Text = "Centigramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 100
            lblno.Text = "CG"
        End If

        If cbode2.Text = "Gramo" And cboa2.Text = "Miligramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 1000
            lblno.Text = "MG"
        End If

        If cbode2.Text = "Gramo" And cboa2.Text = "Libra" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) / 454
            lblno.Text = "LB"
        End If

        If cbode2.Text = "Gramo" And cboa2.Text = "Quintal" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) / 100000
            lblno.Text = "Quintal"
        End If


        '----------------------........Quilate...........---------------------
        If cbode2.Text = "Quilate" And cboa2.Text = "Tonelada" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) / 5000000.0
            lblno.Text = "Tonelada"
        End If


        If cbode2.Text = "Quilate" And cboa2.Text = "Decagramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) / 50
            lblno.Text = "DG"
        End If

        If cbode2.Text = "Quilate" And cboa2.Text = "Kilogramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) / 5000
            lblno.Text = "KG"
        End If

        If cbode2.Text = "Quilate" And cboa2.Text = "Hectogramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) / 500
            lblno.Text = "HG"
        End If

        If cbode2.Text = "Quilate" And cboa2.Text = "Gramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) / 5
            lblno.Text = "G"
        End If

        If cbode2.Text = "Quilate" And cboa2.Text = "Quilate" Then
            lblrespuesta2.Text = Val(txtvalor2.Text)
            lblno.Text = "Q"
        End If

        If cbode2.Text = "Quilate" And cboa2.Text = "Centigramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 20
            lblno.Text = "CG"
        End If

        If cbode2.Text = "Quilate" And cboa2.Text = "Miligramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 200
            lblno.Text = "MG"
        End If

        If cbode2.Text = "Quilate" And cboa2.Text = "Libra" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) / 2268
            lblno.Text = "LB"
        End If

        If cbode2.Text = "Quilate" And cboa2.Text = "Quintal" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) / 500000
            lblno.Text = "Quintal"
        End If




        '----------------------........Centigramo...........---------------------
        If cbode2.Text = "Centigramo" And cboa2.Text = "Tonelada" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) / 100000000.0

            lblno.Text = "Tonelada"
        End If


        If cbode2.Text = "Centigramo" And cboa2.Text = "Decagramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 1000
            lblno.Text = "DG"
        End If

        If cbode2.Text = "Centigramo" And cboa2.Text = "Kilogramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) / 100000
            lblno.Text = "KG"
        End If

        If cbode2.Text = "Centigramo" And cboa2.Text = "Hectogramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 10000
            lblno.Text = "HG"
        End If

        If cbode2.Text = "Centigramo" And cboa2.Text = "Gramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) / 100
            lblno.Text = "G"
        End If

        If cbode2.Text = "Centigramo" And cboa2.Text = "Quilate" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) / 20
            lblno.Text = "Q"
        End If

        If cbode2.Text = "Centigramo" And cboa2.Text = "Centigramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text)
            lblno.Text = "CG"
        End If

        If cbode2.Text = "Centigramo" And cboa2.Text = "Miligramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 10
            lblno.Text = "MG"
        End If

        If cbode2.Text = "Centigramo" And cboa2.Text = "Libra" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) / 45359
            lblno.Text = "LB"
        End If

        If cbode2.Text = "Centigramo" And cboa2.Text = "Quintal" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) / 10000000.0
            lblno.Text = "Quintal"
        End If


        '----------------------........Miligramo...........---------------------
        If cbode2.Text = "Miligramo" And cboa2.Text = "Tonelada" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) / 1000000000.0
            lblno.Text = "Tonelada"
        End If


        If cbode2.Text = "Miligramo" And cboa2.Text = "Decagramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) / 10000
            lblno.Text = "DG"
        End If

        If cbode2.Text = "Miligramo" And cboa2.Text = "Kilogramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) / 100
            lblno.Text = "KG"
        End If

        If cbode2.Text = "Miligramo" And cboa2.Text = "Hectogramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 10
            lblno.Text = "HG"
        End If

        If cbode2.Text = "Miligramo" And cboa2.Text = "Gramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 10
            lblno.Text = "G"
        End If

        If cbode2.Text = "Miligramo" And cboa2.Text = "Quilate" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 50
            lblno.Text = "Q"
        End If

        If cbode2.Text = "Miligramo" And cboa2.Text = "Centigramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 1000
            lblno.Text = "CG"
        End If

        If cbode2.Text = "Miligramo" And cboa2.Text = "Miligramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text)
            lblno.Text = "MG"
        End If

        If cbode2.Text = "Miligramo" And cboa2.Text = "Libra" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) / 45.359
            lblno.Text = "LB"
        End If

        If cbode2.Text = "Miligramo" And cboa2.Text = "Quintal" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) / 10000
            lblno.Text = "Quintal"
        End If



        '----------------------........Libra...........---------------------
        If cbode2.Text = "Libra" And cboa2.Text = "Tonelada" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) / 2205
            lblno.Text = "Tonelada"
        End If


        If cbode2.Text = "Libra" And cboa2.Text = "Decagramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 45.359
            lblno.Text = "DG"
        End If

        If cbode2.Text = "Libra" And cboa2.Text = "Kilogramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) / 2.205
            lblno.Text = "KG"
        End If

        If cbode2.Text = "Libra" And cboa2.Text = "Hectogramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 4.536
            lblno.Text = "HG"
        End If

        If cbode2.Text = "Libra" And cboa2.Text = "Gramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 454
            lblno.Text = "G"
        End If

        If cbode2.Text = "Libra" And cboa2.Text = "Quilate" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 2268
            lblno.Text = "Q"
        End If

        If cbode2.Text = "Libra" And cboa2.Text = "Centigramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 45359
            lblno.Text = "CG"
        End If

        If cbode2.Text = "Libra" And cboa2.Text = "Miligramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 453592
            lblno.Text = "MG"
        End If

        If cbode2.Text = "Libra" And cboa2.Text = "Libra" Then
            lblrespuesta2.Text = Val(txtvalor2.Text)
            lblno.Text = "LB"
        End If

        If cbode2.Text = "Libra" And cboa2.Text = "Quintal" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) / 220
            lblno.Text = "Quintal"
        End If




        '----------------------........Quintal...........---------------------
        If cbode2.Text = "Quintal" And cboa2.Text = "Tonelada" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) / 10
            lblno.Text = "Tonelada"
        End If


        If cbode2.Text = "Quintal" And cboa2.Text = "Decagramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 10000
            lblno.Text = "DG"
        End If

        If cbode2.Text = "Quintal" And cboa2.Text = "Kilogramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) / 100
            lblno.Text = "KG"
        End If

        If cbode2.Text = "Quintal" And cboa2.Text = "Hectogramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 1000
            lblno.Text = "HG"
        End If

        If cbode2.Text = "Quintal" And cboa2.Text = "Gramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 100000
            lblno.Text = "G"
        End If

        If cbode2.Text = "Quintal" And cboa2.Text = "Quilate" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 500000
            lblno.Text = "Q"
        End If

        If cbode2.Text = "Quintal" And cboa2.Text = "Centigramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 10000000.0
            lblno.Text = "CG"
        End If

        If cbode2.Text = "Quintal" And cboa2.Text = "Miligramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 100000000.0
            lblno.Text = "MG"
        End If

        If cbode2.Text = "Quintal" And cboa2.Text = "Libra" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 220
            lblno.Text = "LB"
        End If

        If cbode2.Text = "Quintal" And cboa2.Text = "Quintal" Then
            lblrespuesta2.Text = Val(txtvalor2.Text)
            lblno.Text = "Quintal"
        End If





    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles txtb7.Click

        txtvalor2.Clear()


    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        MessageBox.Show("Gracias por usar el conversor, bonito dia :)")

        End



    Private Sub TabPage1_Click_1(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub BtnConvertir_Click(sender As Object, e As EventArgs) Handles BtnConvertirTemp.Click
        'Kilobyte....
        If CboAlma1.Text = "Kilobyte" And CboAlma2.Text = "Kilobyte" Then
            LblRespTemp.Text = Val(TxtValTemp.Text)
        End If

        If CboAlma1.Text = "Kilobyte" And CboAlma2.Text = "Kilobit" Then
            LblRespTemp.Text = Val(TxtValTemp.Text) * 8
        End If

        If CboAlma1.Text = "Kilobyte" And CboAlma2.Text = "Kibibit" Then
            LblRespTemp.Text = Val(TxtValTemp.Text) * 7.812
        End If


        If CboAlma1.Text = "Kilobyte" And CboAlma2.Text = "Megabit" Then
            LblRespTemp.Text = Val(TxtValTemp.Text) / 125
        End If

        If CboAlma1.Text = "Kilobyte" And CboAlma2.Text = "Mebibit" Then
            LblRespTemp.Text = Val(TxtValTemp.Text) / 131
        End If



        If CboAlma1.Text = "Kilobyte" And CboAlma2.Text = "Gigabit" Then
            LblRespTemp.Text = Val(TxtValTemp.Text) / 125000
        End If


        If CboAlma1.Text = "Kilobyte" And CboAlma2.Text = "Terabit" Then
            LblRespTemp.Text = Val(TxtValTemp.Text) / 125000000.0
        End If

        If CboAlma1.Text = "Kilobyte" And CboAlma2.Text = "Byte" Then
            LblRespTemp.Text = Val(TxtValTemp.Text) / 1000
        End If

        If CboAlma1.Text = "Kilobyte" And CboAlma2.Text = "Gibibit" Then
            LblRespTemp.Text = Val(TxtValTemp.Text) / 134218
        End If

        If CboAlma1.Text = "Kilobyte" And CboAlma2.Text = "Tebibit" Then
            LblRespTemp.Text = Val(TxtValTemp.Text) / 137400000.0
        End If

        'Kilobit..........................

        If CboAlma1.Text = "Kilobit" And CboAlma2.Text = "Kilobyte" Then
            LblRespTemp.Text = Val(TxtValTemp.Text) / 8
        End If

        If CboAlma1.Text = "Kilobit" And CboAlma2.Text = "Kilobit" Then
            LblRespTemp.Text = Val(TxtValTemp.Text)
        End If

        If CboAlma1.Text = "Kilobit" And CboAlma2.Text = "Kibibit" Then
            LblRespTemp.Text = Val(TxtValTemp.Text) / 1.024
        End If


        If CboAlma1.Text = "Kilobit" And CboAlma2.Text = "Megabit" Then
            LblRespTemp.Text = Val(TxtValTemp.Text) / 1000
        End If

        If CboAlma1.Text = "Kilobit" And CboAlma2.Text = "Mebibit" Then
            LblRespTemp.Text = Val(TxtValTemp.Text) / 1049
        End If

        If CboAlma1.Text = "Kilobit" And CboAlma2.Text = "Gigabit" Then
            LblRespTemp.Text = Val(TxtValTemp.Text) / 1000000.0
        End If


        If CboAlma1.Text = "Kilobit" And CboAlma2.Text = "Terabit" Then
            LblRespTemp.Text = Val(TxtValTemp.Text) / 1000000000.0
        End If

        If CboAlma1.Text = "Kilobit" And CboAlma2.Text = "Byte" Then
            LblRespTemp.Text = Val(TxtValTemp.Text) * 125
        End If

        If CboAlma1.Text = "Kilobit" And CboAlma2.Text = "Gibibit" Then
            LblRespTemp.Text = Val(TxtValTemp.Text) / 1074000.0
        End If

        If CboAlma1.Text = "Kilobit" And CboAlma2.Text = "Tebibit" Then
            LblRespTemp.Text = Val(TxtValTemp.Text) / 1100000000.0

        End If

        'Kibibit............

        If CboAlma1.Text = "Kibibit" And CboAlma2.Text = "Kilobyte" Then
            LblRespTemp.Text = Val(TxtValTemp.Text) / 7.812
        End If

        If CboAlma1.Text = "Kibibit" And CboAlma2.Text = "Kilobit" Then
            LblRespTemp.Text = Val(TxtValTemp.Text) * 1.024
        End If

        If CboAlma1.Text = "Kibibit" And CboAlma2.Text = "Kibibit" Then
            LblRespTemp.Text = Val(TxtValTemp.Text)
        End If

        If CboAlma1.Text = "Kibibit" And CboAlma2.Text = "Megabit" Then
            LblRespTemp.Text = Val(TxtValTemp.Text) / 977
        End If

        If CboAlma1.Text = "Kibibit" And CboAlma2.Text = "Mebibit" Then
            LblRespTemp.Text = Val(TxtValTemp.Text) / 1024
        End If

        If CboAlma1.Text = "Kibibit" And CboAlma2.Text = "Gigabit" Then
            LblRespTemp.Text = Val(TxtValTemp.Text) / 976562
        End If

        If CboAlma1.Text = "Kibibit" And CboAlma2.Text = "Terabit" Then
            LblRespTemp.Text = Val(TxtValTemp.Text) / 976600000.0
        End If

        If CboAlma1.Text = "Kibibit" And CboAlma2.Text = "Byte" Then
            LblRespTemp.Text = Val(TxtValTemp.Text) * 128

        End If

        If CboAlma1.Text = "Kibibit" And CboAlma2.Text = "Gibibit" Then
            LblRespTemp.Text = Val(TxtValTemp.Text) / 1049000.0
        End If

        If CboAlma1.Text = "Kibibit" And CboAlma2.Text = "Tebibit" Then
            LblRespTemp.Text = Val(TxtValTemp.Text) / 1074000000.0
        End If

        'Megabit..........................

        If CboAlma1.Text = "Megabit" And CboAlma2.Text = "Kilobyte" Then
            LblRespTemp.Text = Val(TxtValTemp.Text) * 125
        End If

        If CboAlma1.Text = "Megabit" And CboAlma2.Text = "Kilobit" Then
            LblRespTemp.Text = Val(TxtValTemp.Text) * 1000
        End If

        If CboAlma1.Text = "Megabit" And CboAlma2.Text = "Kibibit" Then
            LblRespTemp.Text = Val(TxtValTemp.Text) * 977
        End If

        If CboAlma1.Text = "Megabit" And CboAlma2.Text = "Megabit" Then
            LblRespTemp.Text = Val(TxtValTemp.Text)
        End If


        If CboAlma1.Text = "Megabit" And CboAlma2.Text = "Mebibit" Then
            LblRespTemp.Text = Val(TxtValTemp.Text) / 1.049
        End If

        If CboAlma1.Text = "Megabit" And CboAlma2.Text = "Gigabit" Then
            LblRespTemp.Text = Val(TxtValTemp.Text) / 1000
        End If

        If CboAlma1.Text = "Megabit" And CboAlma2.Text = "Terabit" Then
            LblRespTemp.Text = Val(TxtValTemp.Text) / 1000000.0
        End If

        If CboAlma1.Text = "Megabit" And CboAlma2.Text = "Byte" Then
            LblRespTemp.Text = Val(TxtValTemp.Text) * 125000
        End If

        If CboAlma1.Text = "Megabit" And CboAlma2.Text = "Gibibit" Then
            LblRespTemp.Text = Val(TxtValTemp.Text) / 1074
        End If

        If CboAlma1.Text = "Megabit" And CboAlma2.Text = "Tebibit" Then
            LblRespTemp.Text = Val(TxtValTemp.Text) / 1100000.0
        End If


        ' Mebibit...........................

        If CboAlma1.Text = "Mebibit" And CboAlma2.Text = "Kilobyte" Then
            LblRespTemp.Text = Val(TxtValTemp.Text) * 131
        End If

        If CboAlma1.Text = "Mebibit" And CboAlma2.Text = "Kilobit" Then
            LblRespTemp.Text = Val(TxtValTemp.Text) * 1049
        End If

        If CboAlma1.Text = "Mebibit" And CboAlma2.Text = "Kibibit" Then
            LblRespTemp.Text = Val(TxtValTemp.Text) * 1024
        End If

        If CboAlma1.Text = "Mebibit" And CboAlma2.Text = "Megabit" Then
            LblRespTemp.Text = Val(TxtValTemp.Text) * 1.049
        End If

        If CboAlma1.Text = "Mebibit" And CboAlma2.Text = "Mebibit" Then
            LblRespTemp.Text = Val(TxtValTemp.Text)
        End If

        If CboAlma1.Text = "Mebibit" And CboAlma2.Text = "Gigabit" Then
            LblRespTemp.Text = Val(TxtValTemp.Text) / 954
        End If

        If CboAlma1.Text = "Mebibit" And CboAlma2.Text = "Terabit" Then
            LblRespTemp.Text = Val(TxtValTemp.Text) / 953674
        End If

        If CboAlma1.Text = "Mebibit" And CboAlma2.Text = "Byte" Then
            LblRespTemp.Text = Val(TxtValTemp.Text) * 131072
        End If

        If CboAlma1.Text = "Mebibit" And CboAlma2.Text = "Gibibit" Then
            LblRespTemp.Text = Val(TxtValTemp.Text) / 1024
        End If

        If CboAlma1.Text = "Mebibit" And CboAlma2.Text = "Tebibit" Then
            LblRespTemp.Text = Val(TxtValTemp.Text) / 1049000.0
        End If


        ' Gigabit............................................
        If CboAlma1.Text = "Gigabit" And CboAlma2.Text = "Kilobyte" Then
            LblRespTemp.Text = Val(TxtValTemp.Text) * 125000
        End If

        If CboAlma1.Text = "Gigabit" And CboAlma2.Text = "Kilobit" Then
            LblRespTemp.Text = Val(TxtValTemp.Text) * 1000000.0
        End If

        If CboAlma1.Text = "Gigabit" And CboAlma2.Text = "Kibibit" Then
            LblRespTemp.Text = Val(TxtValTemp.Text) * 976563
        End If

        If CboAlma1.Text = "Gigabit" And CboAlma2.Text = "Megabit" Then
            LblRespTemp.Text = Val(TxtValTemp.Text) * 1000
        End If

        If CboAlma1.Text = "Gigabit" And CboAlma2.Text = "Mebibit" Then
            LblRespTemp.Text = Val(TxtValTemp.Text) * 954
        End If

        If CboAlma1.Text = "Gigabit" And CboAlma2.Text = "Gigabit" Then
            LblRespTemp.Text = Val(TxtValTemp.Text)
        End If

        If CboAlma1.Text = "Gigabit" And CboAlma2.Text = "Terabit" Then
            LblRespTemp.Text = Val(TxtValTemp.Text) / 1000
        End If

        If CboAlma1.Text = "Gigabit" And CboAlma2.Text = "Byte" Then
            LblRespTemp.Text = Val(TxtValTemp.Text) * 125000000.0
        End If

        If CboAlma1.Text = "Gigabit" And CboAlma2.Text = "Gibibit" Then
            LblRespTemp.Text = Val(TxtValTemp.Text) / 1.074
        End If

        If CboAlma1.Text = "Gigabit" And CboAlma2.Text = "Tebibit" Then
            LblRespTemp.Text = Val(TxtValTemp.Text) / 1100
        End If

        ' Terabit...................

        If CboAlma1.Text = "Terabit" And CboAlma2.Text = "Kilobyte" Then
            LblRespTemp.Text = Val(TxtValTemp.Text) / 1000
        End If

        If CboAlma1.Text = "Terabit" And CboAlma2.Text = "Kilobit" Then
            LblRespTemp.Text = Val(TxtValTemp.Text) * 1000000.0
        End If

        If CboAlma1.Text = "Terabit" And CboAlma2.Text = "Kibibit" Then
            LblRespTemp.Text = Val(TxtValTemp.Text) * 976600000.0
        End If

        If CboAlma1.Text = "Terabit" And CboAlma2.Text = "Megabit" Then
            LblRespTemp.Text = Val(TxtValTemp.Text) * 1000000.0
        End If

        If CboAlma1.Text = "Terabit" And CboAlma2.Text = "Mebibit" Then
            LblRespTemp.Text = Val(TxtValTemp.Text) * 953674
        End If

        If CboAlma1.Text = "Terabit" And CboAlma2.Text = "Gigabit" Then
            LblRespTemp.Text = Val(TxtValTemp.Text) * 1000
        End If

        If CboAlma1.Text = "Terabit" And CboAlma2.Text = "Terabit" Then
            LblRespTemp.Text = Val(TxtValTemp.Text)
        End If

        If CboAlma1.Text = "Terabit" And CboAlma2.Text = "Byte" Then
            LblRespTemp.Text = Val(TxtValTemp.Text) * 125000000000.0
        End If

        If CboAlma1.Text = "Terabit" And CboAlma2.Text = "Gibibit" Then
            LblRespTemp.Text = Val(TxtValTemp.Text) * 931
        End If

        If CboAlma1.Text = "Terabit" And CboAlma2.Text = "Tebibit" Then
            LblRespTemp.Text = Val(TxtValTemp.Text) / 1.1
        End If


        ' Byte.................................................
        If CboAlma1.Text = "Byte" And CboAlma2.Text = "Kilobyte" Then
            LblRespTemp.Text = Val(TxtValTemp.Text) / 1000
        End If

        If CboAlma1.Text = "Byte" And CboAlma2.Text = "Kilobit" Then
            LblRespTemp.Text = Val(TxtValTemp.Text) / 125
        End If

        If CboAlma1.Text = "Byte" And CboAlma2.Text = "Kibibit" Then
            LblRespTemp.Text = Val(TxtValTemp.Text) / 128
        End If

        If CboAlma1.Text = "Byte" And CboAlma2.Text = "Megabit" Then
            LblRespTemp.Text = Val(TxtValTemp.Text) / 125000
        End If

        If CboAlma1.Text = "Byte" And CboAlma2.Text = "Mebibit" Then
            LblRespTemp.Text = Val(TxtValTemp.Text) / 131072
        End If

        If CboAlma1.Text = "Byte" And CboAlma2.Text = "Gigabit" Then
            LblRespTemp.Text = Val(TxtValTemp.Text) / 125000000.0
        End If

        If CboAlma1.Text = "Byte" And CboAlma2.Text = "Terabit" Then
            LblRespTemp.Text = Val(TxtValTemp.Text) / 125000000000.0
        End If

        If CboAlma1.Text = "Byte" And CboAlma2.Text = "Byte" Then
            LblRespTemp.Text = Val(TxtValTemp.Text)
        End If

        If CboAlma1.Text = "Byte" And CboAlma2.Text = "Gibibit" Then
            LblRespTemp.Text = Val(TxtValTemp.Text) / 134200000.0
        End If

        If CboAlma1.Text = "Byte" And CboAlma2.Text = "Tebibit" Then
            LblRespTemp.Text = Val(TxtValTemp.Text) / 137400000000.0
        End If

        ' Gibibit.............................

        If CboAlma1.Text = "Gibibit" And CboAlma2.Text = "Kilobyte" Then
            LblRespTemp.Text = Val(TxtValTemp.Text) * 134218
        End If

        If CboAlma1.Text = "Gibibit" And CboAlma2.Text = "Kilobit" Then
            LblRespTemp.Text = Val(TxtValTemp.Text) * 1074000.0
        End If

        If CboAlma1.Text = "Gibibit" And CboAlma2.Text = "Kibibit" Then
            LblRespTemp.Text = Val(TxtValTemp.Text) * 1049000.0
        End If

        If CboAlma1.Text = "Gibibit" And CboAlma2.Text = "Megabit" Then
            LblRespTemp.Text = Val(TxtValTemp.Text) * 1074
        End If

        If CboAlma1.Text = "Gibibit" And CboAlma2.Text = "Mebibit" Then
            LblRespTemp.Text = Val(TxtValTemp.Text) * 1024
        End If

        If CboAlma1.Text = "Gibibit" And CboAlma2.Text = "Gigabit" Then
            LblRespTemp.Text = Val(TxtValTemp.Text) * 1.074
        End If

        If CboAlma1.Text = "Gibibit" And CboAlma2.Text = "Terabit" Then
            LblRespTemp.Text = Val(TxtValTemp.Text) / 931
        End If

        If CboAlma1.Text = "Gibibit" And CboAlma2.Text = "Byte" Then
            LblRespTemp.Text = Val(TxtValTemp.Text) * 134200000.0
        End If

        If CboAlma1.Text = "Gibibit" And CboAlma2.Text = "Gibibit" Then
            LblRespTemp.Text = Val(TxtValTemp.Text)
        End If

        If CboAlma1.Text = "Gibibit" And CboAlma2.Text = "Tebibit" Then
            LblRespTemp.Text = Val(TxtValTemp.Text) / 1024

        End If

        'Tebibit.............................................


        If CboAlma1.Text = "Tebibit" And CboAlma2.Text = "Kilobyte" Then
            LblRespTemp.Text = Val(TxtValTemp.Text) * 137400000.0
        End If

        If CboAlma1.Text = "Tebibit" And CboAlma2.Text = "Kilobit" Then
            LblRespTemp.Text = Val(TxtValTemp.Text) * 1100000000.0
        End If

        If CboAlma1.Text = "Tebibit" And CboAlma2.Text = "Kibibit" Then
            LblRespTemp.Text = Val(TxtValTemp.Text) * 1074000000.0
        End If

        If CboAlma1.Text = "Tebibit" And CboAlma2.Text = "Megabit" Then
            LblRespTemp.Text = Val(TxtValTemp.Text) * 1100000.0
        End If

        If CboAlma1.Text = "Tebibit" And CboAlma2.Text = "Mebibit" Then
            LblRespTemp.Text = Val(TxtValTemp.Text) * 1049000.0
        End If

        If CboAlma1.Text = "Tebibit" And CboAlma2.Text = "Gigabit" Then
            LblRespTemp.Text = Val(TxtValTemp.Text) * 1100
        End If

        If CboAlma1.Text = "Tebibit" And CboAlma2.Text = "Terabit" Then
            LblRespTemp.Text = Val(TxtValTemp.Text) * 1.1
        End If

        If CboAlma1.Text = "Tebibit" And CboAlma2.Text = "Byte" Then
            LblRespTemp.Text = Val(TxtValTemp.Text) * 137400000000.0
        End If

        If CboAlma1.Text = "Tebibit" And CboAlma2.Text = "Gibibit" Then
            LblRespTemp.Text = Val(TxtValTemp.Text) * 1100
        End If

        If CboAlma1.Text = "Tebibit" And CboAlma2.Text = "Tebibit" Then
            LblRespTemp.Text = Val(TxtValTemp.Text) / 1100

        End If
    End Sub

    Private Sub CboAlma2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboAlma2.SelectedIndexChanged

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click

        MessageBox.Show("Gracias por utilizar el conversor, bonito dia :)")

    End Sub

    Private Sub BtnConversortiempo_Click(sender As Object, e As EventArgs) Handles BtnConversortiempo.Click

        'Nanosegundo....................
        If CboTiempo1.Text = "Nanosegundos" And CboTiempo2.Text = "Nanosegundo" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text)
        End If

        If CboTiempo1.Text = "Nanosegundos" And CboTiempo2.Text = "Microsegundo" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text) / 100
        End If

        If CboTiempo1.Text = "Nanosegundos" And CboTiempo2.Text = "Milisegundo" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text) / 1000000.0
        End If

        If CboTiempo1.Text = "Nanosegundos" And CboTiempo2.Text = "Segundo" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text) / 1000000000.0

        End If

        If CboTiempo1.Text = "Nanosegundos" And CboTiempo2.Text = "Minuto" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text) / 60000000000.0
        End If

        If CboTiempo1.Text = "Nanosegundos" And CboTiempo2.Text = "Hora" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text) / 3600000000000.0
        End If

        If CboTiempo1.Text = "Nanosegundos" And CboTiempo2.Text = "Dia" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text) / 86400000000000.0
        End If

        If CboTiempo1.Text = "Nanosegundos" And CboTiempo2.Text = "Semana" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text) / 604800000000000.0
        End If

        If CboTiempo1.Text = "Nanosegundos" And CboTiempo2.Text = "Mes" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text) / 2.628E+15
        End If


        If CboTiempo1.Text = "Nanosegundo" And CboTiempo2.Text = "Año" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text) / 3.154E+16
        End If

        'Microsegundo-...........

        If CboTiempo1.Text = "Microsegundo" And CboTiempo2.Text = "Nanosegundo" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text) * 1000
        End If

        If CboTiempo1.Text = "Microsegundo" And CboTiempo2.Text = "Microsegundo" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text)
        End If

        If CboTiempo1.Text = "Microsegundo" And CboTiempo2.Text = "Milisegundo" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text) / 1000
        End If

        If CboTiempo1.Text = "Microsegundo" And CboTiempo2.Text = "Segundo" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text) / 1000000.0

        End If

        If CboTiempo1.Text = "Microsegundo" And CboTiempo2.Text = "Minuto" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text) / 60000000.0
        End If

        If CboTiempo1.Text = "Microsegundo" And CboTiempo2.Text = "Hora" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text) / 3600000000.0
        End If

        If CboTiempo1.Text = "Microsegundo" And CboTiempo2.Text = "Dia" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text) / 86400000000.0

        End If

        If CboTiempo1.Text = "Microsegundo" And CboTiempo2.Text = "Semana" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text) / 604800000000.0
        End If

        If CboTiempo1.Text = "Microsegundo" And CboTiempo2.Text = "Mes" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text) / 2628000000000.0

        End If

        If CboTiempo1.Text = "Microsegundo" And CboTiempo2.Text = "Año" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text) / 31540000000000.0
        End If

        'Milisegundo......................

        If CboTiempo1.Text = "Milisegundo" And CboTiempo2.Text = "Nanosegundo" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text) * 1000000.0
        End If

        If CboTiempo1.Text = "Milisegundo" And CboTiempo2.Text = "Microsegundo" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text) * 1000
        End If

        If CboTiempo1.Text = "Milisegundo" And CboTiempo2.Text = "Milisegundo" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text)
        End If

        If CboTiempo1.Text = "Milisegundo" And CboTiempo2.Text = "Segundo" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text) / 1000
        End If

        If CboTiempo1.Text = "Milisegundo" And CboTiempo2.Text = "Minuto" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text) / 60000
        End If

        If CboTiempo1.Text = "Milisegundo" And CboTiempo2.Text = "Hora" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text) / 3600000.0

        End If

        If CboTiempo1.Text = "Milisegundo" And CboTiempo2.Text = "Dia" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text) / 86400000.0

        End If

        If CboTiempo1.Text = "Milisegundo" And CboTiempo2.Text = "Semana" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text) / 604800000.0

        End If

        If CboTiempo1.Text = "Milisegundo" And CboTiempo2.Text = "Mes" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text) / 2628000000.0

        End If

        If CboTiempo1.Text = "Milisegundo" And CboTiempo2.Text = "Año" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text) / 31540000000.0
        End If




        'Segundo...........................

        If CboTiempo1.Text = "Segundo" And CboTiempo2.Text = "Nanosegundo" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text) * 1000000000.0
        End If

        If CboTiempo1.Text = "Segundo" And CboTiempo2.Text = "Microsegundo" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text) * 1000000.0

        End If

        If CboTiempo1.Text = "Segundo" And CboTiempo2.Text = "Milisegundo" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text) * 1000
        End If

        If CboTiempo1.Text = "Segundo" And CboTiempo2.Text = "Segundo" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text)
        End If

        If CboTiempo1.Text = "Segundo" And CboTiempo2.Text = "Minuto" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text) / 60
        End If

        If CboTiempo1.Text = "Segundo" And CboTiempo2.Text = "Hora" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text) / 3600
        End If

        If CboTiempo1.Text = "Segundo" And CboTiempo2.Text = "Dia" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text) / 86400

        End If

        If CboTiempo1.Text = "Segundo" And CboTiempo2.Text = "Semana" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text) / 604800

        End If

        If CboTiempo1.Text = "Segundo" And CboTiempo2.Text = "Mes" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text) / 2628000.0

        End If

        If CboTiempo1.Text = "Segundo" And CboTiempo2.Text = "Año" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text) / 31540000.0

        End If

        'Minuto...........................

        If CboTiempo1.Text = "Minuto" And CboTiempo2.Text = "Nanosegundo" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text) * 60000000000.0
        End If

        If CboTiempo1.Text = "Minuto" And CboTiempo2.Text = "Microsegundo" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text) * 60000000.0

        End If

        If CboTiempo1.Text = "Minuto" And CboTiempo2.Text = "Milisegundo" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text) * 60000
        End If

        If CboTiempo1.Text = "Minuto" And CboTiempo2.Text = "Segundo" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text) * 60
        End If

        If CboTiempo1.Text = "Minuto" And CboTiempo2.Text = "Minuto" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text)

        End If

        If CboTiempo1.Text = "Minuto" And CboTiempo2.Text = "Hora" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text) / 60

        End If

        If CboTiempo1.Text = "Minuto" And CboTiempo2.Text = "Dia" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text) / 1440

        End If

        If CboTiempo1.Text = "Minuto" And CboTiempo2.Text = "Semana" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text) / 10080

        End If

        If CboTiempo1.Text = "Minuto" And CboTiempo2.Text = "Mes" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text) / 43800

        End If

        If CboTiempo1.Text = "Minuto" And CboTiempo2.Text = "Año" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text) / 525600

        End If





        'Hora...........................

        If CboTiempo1.Text = "Hora" And CboTiempo2.Text = "Nanosegundo" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text) * 3600000000000.0
        End If

        If CboTiempo1.Text = "Hora" And CboTiempo2.Text = "Microsegundo" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text) * 3600000000.0

        End If

        If CboTiempo1.Text = "Hora" And CboTiempo2.Text = "Milisegundo" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text) * 3600000.0
        End If

        If CboTiempo1.Text = "Hora" And CboTiempo2.Text = "Segundo" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text) * 3600

        End If

        If CboTiempo1.Text = "Hora" And CboTiempo2.Text = "Minuto" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text) * 60
        End If

        If CboTiempo1.Text = "Hora" And CboTiempo2.Text = "Hora" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text)

        End If

        If CboTiempo1.Text = "Hora" And CboTiempo2.Text = "Dia" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text) / 24

        End If

        If CboTiempo1.Text = "Hora" And CboTiempo2.Text = "Semana" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text) / 168

        End If

        If CboTiempo1.Text = "Hora" And CboTiempo2.Text = "Mes" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text) / 730

        End If

        If CboTiempo1.Text = "Hora" And CboTiempo2.Text = "Año" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text) / 8760

        End If



        'Dia...........................

        If CboTiempo1.Text = "Dia" And CboTiempo2.Text = "Nanosegundo" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text) * 86400000000000.0

        End If

        If CboTiempo1.Text = "Dia" And CboTiempo2.Text = "Microsegundo" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text) * 86400000000.0

        End If

        If CboTiempo1.Text = "Dia" And CboTiempo2.Text = "Milisegundo" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text) * 86400000.0
        End If

        If CboTiempo1.Text = "Dia" And CboTiempo2.Text = "Segundo" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text) * 86400
        End If

        If CboTiempo1.Text = "Dia" And CboTiempo2.Text = "Minuto" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text) * 1440

        End If

        If CboTiempo1.Text = "Dia" And CboTiempo2.Text = "Hora" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text) * 24

        End If

        If CboTiempo1.Text = "Dia" And CboTiempo2.Text = "Dia" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text)

        End If

        If CboTiempo1.Text = "Dia" And CboTiempo2.Text = "Semana" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text) / 7

        End If

        If CboTiempo1.Text = "Dia" And CboTiempo2.Text = "Mes" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text) / 30.417

        End If

        If CboTiempo1.Text = "Dia" And CboTiempo2.Text = "Año" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text) / 365

        End If


        ' Semana...........................

        If CboTiempo1.Text = "Semana" And CboTiempo2.Text = "Nanosegundo" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text) * 604800000000000.0

        End If

        If CboTiempo1.Text = "Semana" And CboTiempo2.Text = "Microsegundo" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text) * 604800000000.0


        End If

        If CboTiempo1.Text = "Semana" And CboTiempo2.Text = "Milisegundo" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text) * 604800000.0
        End If

        If CboTiempo1.Text = "Semana" And CboTiempo2.Text = "Segundo" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text) * 604800
        End If

        If CboTiempo1.Text = "Semana" And CboTiempo2.Text = "Minuto" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text) * 10080

        End If

        If CboTiempo1.Text = "Semana" And CboTiempo2.Text = "Hora" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text) * 168
        End If

        If CboTiempo1.Text = "Semana" And CboTiempo2.Text = "Dia" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text) * 7

        End If

        If CboTiempo1.Text = "Semana" And CboTiempo2.Text = "Semana" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text)

        End If

        If CboTiempo1.Text = "Semana" And CboTiempo2.Text = "Mes" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text) / 4.345

        End If

        If CboTiempo1.Text = "Semana" And CboTiempo2.Text = "Año" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text) / 52.143

        End If





        ' Mes...........................

        If CboTiempo1.Text = "Mes" And CboTiempo2.Text = "Nanosegundo" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text) * 2.628E+15

        End If

        If CboTiempo1.Text = "Mes" And CboTiempo2.Text = "Microsegundo" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text) * 2628000000000.0

        End If

        If CboTiempo1.Text = "Mes" And CboTiempo2.Text = "Milisegundo" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text) * 2628000000.0
        End If

        If CboTiempo1.Text = "Mes" And CboTiempo2.Text = "Segundo" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text) * 2628000.0
        End If

        If CboTiempo1.Text = "Mes" And CboTiempo2.Text = "Minuto" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text) * 43800

        End If

        If CboTiempo1.Text = "Mes" And CboTiempo2.Text = "Hora" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text) * 730
        End If

        If CboTiempo1.Text = "Mes" And CboTiempo2.Text = "Dia" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text) * 30.417

        End If

        If CboTiempo1.Text = "Mes" And CboTiempo2.Text = "Semana" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text) * 4.345

        End If

        If CboTiempo1.Text = "Mes" And CboTiempo2.Text = "Mes" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text) / 4.345

        End If

        If CboTiempo1.Text = "Mes" And CboTiempo2.Text = "Año" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text) / 12

        End If

        ' Año...........................

        If CboTiempo1.Text = "Año" And CboTiempo2.Text = "Nanosegundo" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text) * 3.154E+16

        End If

        If CboTiempo1.Text = "Año" And CboTiempo2.Text = "Microsegundo" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text) * 31540000000000.0
        End If

        If CboTiempo1.Text = "Año" And CboTiempo2.Text = "Milisegundo" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text) * 31540000000.0
        End If

        If CboTiempo1.Text = "Año" And CboTiempo2.Text = "Segundo" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text) * 31540000.0
        End If

        If CboTiempo1.Text = "Año" And CboTiempo2.Text = "Minuto" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text) * 525600
        End If

        If CboTiempo1.Text = "Año" And CboTiempo2.Text = "Hora" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text) * 8760
        End If

        If CboTiempo1.Text = "Año" And CboTiempo2.Text = "Dia" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text) * 365
        End If

        If CboTiempo1.Text = "Año" And CboTiempo2.Text = "Semana" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text) * 52.143
        End If

        If CboTiempo1.Text = "Año" And CboTiempo2.Text = "Mes" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text) * 12

        End If

        If CboTiempo1.Text = "Año" And CboTiempo2.Text = "Año" Then
            LblTiemporesultante.Text = Val(TxtIntroductor.Text)
        End If
    End Sub

    Private Sub Btnnvo_Click(sender As Object, e As EventArgs) Handles Btnnvo.Click

        TxtValTemp.Clear()
    End Sub

    Private Sub BnSalis_Click(sender As Object, e As EventArgs) Handles BnSalis.Click
        MessageBox.Show("Gracias por utilizar el conversor, bonito dia :)")
    End Sub

    Private Sub BtnNewis_Click(sender As Object, e As EventArgs) Handles BtnNewis.Click
        TxtIntroductor.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        '-------------------Empezamos con el conversore de masa----------------
        '----------------------........TONELADAS...........---------------------
        If cbode2.Text = "Tonelada" And cboa2.Text = "Tonelada" Then
            lblrespuesta2.Text = Val(txtvalor2.Text)
            lblno.Text = "Toneladas"
        End If


        If cbode2.Text = "Tonelada" And cboa2.Text = "Decagramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 100000
            lblno.Text = "DG"
        End If

        If cbode2.Text = "Tonelada" And cboa2.Text = "Kilogramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 1000
            lblno.Text = "KG"
        End If

        If cbode2.Text = "Tonelada" And cboa2.Text = "Hectogramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 10000
            lblno.Text = "HG"
        End If

        If cbode2.Text = "Tonelada" And cboa2.Text = "Gramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 1000000
            lblno.Text = "G"
        End If

        If cbode2.Text = "Tonelada" And cboa2.Text = "Quilate" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 50000000
            lblno.Text = "Q"
        End If

        If cbode2.Text = "Tonelada" And cboa2.Text = "Centigramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 100000000
            lblno.Text = "CG"
        End If

        If cbode2.Text = "Tonelada" And cboa2.Text = "Miligramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 1000000000
            lblno.Text = "MG"
        End If

        If cbode2.Text = "Tonelada" And cboa2.Text = "Libra" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 2204.62
            lblno.Text = "LB"
        End If

        If cbode2.Text = "Tonelada" And cboa2.Text = "Quintal" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 10
            lblno.Text = "Quintal"
        End If




        '----------------------........Decagramos...........---------------------
        If cbode2.Text = "Decagramo" And cboa2.Text = "Tonelada" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) / 100000
            lblno.Text = "Tonelada"
        End If


        If cbode2.Text = "Decagramo" And cboa2.Text = "Decagramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text)
            lblno.Text = "DG"
        End If

        If cbode2.Text = "Decagramo" And cboa2.Text = "Kilogramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) / 100
            lblno.Text = "KG"
        End If

        If cbode2.Text = "Decagramo" And cboa2.Text = "Hectogramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) / 0.1
            lblno.Text = "HG"
        End If

        If cbode2.Text = "Decagramo" And cboa2.Text = "Gramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 10
            lblno.Text = "G"
        End If

        If cbode2.Text = "Decagramo" And cboa2.Text = "Quilate" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 50
            lblno.Text = "Q"
        End If

        If cbode2.Text = "Decagramo" And cboa2.Text = "Centigramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 1000
            lblno.Text = "CG"
        End If

        If cbode2.Text = "Decagramo" And cboa2.Text = "Miligramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 10000
            lblno.Text = "MG"
        End If

        If cbode2.Text = "Decagramo" And cboa2.Text = "Libra" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) / 45.359
            lblno.Text = "LB"
        End If

        If cbode2.Text = "Decagramo" And cboa2.Text = "Quintal" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) / 10000
            lblno.Text = "Quintal"
        End If





        '----------------------........Kilogramo...........---------------------
        If cbode2.Text = "Kilogramo" And cboa2.Text = "Tonelada" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) / 1000
            lblno.Text = "Tonelada"
        End If


        If cbode2.Text = "Kilogramo" And cboa2.Text = "Decagramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 100
            lblno.Text = "DG"
        End If

        If cbode2.Text = "Kilogramo" And cboa2.Text = "Kilogramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text)
            lblno.Text = "KG"
        End If

        If cbode2.Text = "Kilogramo" And cboa2.Text = "Hectogramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 10
            lblno.Text = "HG"
        End If

        If cbode2.Text = "Kilogramo" And cboa2.Text = "Gramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 1000
            lblno.Text = "G"
        End If

        If cbode2.Text = "Kilogramo" And cboa2.Text = "Quilate" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 5000
            lblno.Text = "Q"
        End If

        If cbode2.Text = "Kilogramo" And cboa2.Text = "Centigramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 100000
            lblno.Text = "CG"
        End If

        If cbode2.Text = "Kilogramo" And cboa2.Text = "Miligramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 1000000
            lblno.Text = "MG"
        End If

        If cbode2.Text = "Kilogramo" And cboa2.Text = "Libra" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 2.205
            lblno.Text = "LB"
        End If

        If cbode2.Text = "Kilogramo" And cboa2.Text = "Quintal" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) / 100
            lblno.Text = "Quintal"
        End If




        '----------------------........Hectogramo...........---------------------
        If cbode2.Text = "Hectogramo" And cboa2.Text = "Tonelada" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) / 10000
            lblno.Text = "Tonelada"
        End If


        If cbode2.Text = "Hectogramo" And cboa2.Text = "Decagramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 10
            lblno.Text = "DG"
        End If

        If cbode2.Text = "Hectogramo" And cboa2.Text = "Kilogramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) / 10
            lblno.Text = "KG"
        End If

        If cbode2.Text = "Hectogramo" And cboa2.Text = "Hectogramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text)
            lblno.Text = "HG"
        End If

        If cbode2.Text = "Hectogramo" And cboa2.Text = "Gramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 100
            lblno.Text = "G"
        End If

        If cbode2.Text = "Hectogramo" And cboa2.Text = "Quilate" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 500
            lblno.Text = "Q"
        End If

        If cbode2.Text = "Hectogramo" And cboa2.Text = "Centigramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 10000
            lblno.Text = "CG"
        End If

        If cbode2.Text = "Hectogramo" And cboa2.Text = "Miligramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 100000
            lblno.Text = "MG"
        End If

        If cbode2.Text = "Hectogramo" And cboa2.Text = "Libra" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) / 4.536
            lblno.Text = "LB"
        End If

        If cbode2.Text = "Hectogramo" And cboa2.Text = "Quintal" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) / 1000
            lblno.Text = "Quintal"
        End If



        '----------------------........Gramo...........---------------------
        If cbode2.Text = "Gramo" And cboa2.Text = "Tonelada" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) / 1000000
            lblno.Text = "Tonelada"
        End If


        If cbode2.Text = "Gramo" And cboa2.Text = "Decagramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 10
            lblno.Text = "DG"
        End If

        If cbode2.Text = "Gramo" And cboa2.Text = "Kilogramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) / 1000
            lblno.Text = "KG"
        End If

        If cbode2.Text = "Gramo" And cboa2.Text = "Hectogramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 100
            lblno.Text = "HG"
        End If

        If cbode2.Text = "Gramo" And cboa2.Text = "Gramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text)
            lblno.Text = "G"
        End If

        If cbode2.Text = "Gramo" And cboa2.Text = "Quilate" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 5
            lblno.Text = "Q"
        End If

        If cbode2.Text = "Gramo" And cboa2.Text = "Centigramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 100
            lblno.Text = "CG"
        End If

        If cbode2.Text = "Gramo" And cboa2.Text = "Miligramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 1000
            lblno.Text = "MG"
        End If

        If cbode2.Text = "Gramo" And cboa2.Text = "Libra" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) / 454
            lblno.Text = "LB"
        End If

        If cbode2.Text = "Gramo" And cboa2.Text = "Quintal" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) / 100000
            lblno.Text = "Quintal"
        End If


        '----------------------........Quilate...........---------------------
        If cbode2.Text = "Quilate" And cboa2.Text = "Tonelada" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) / 5000000.0
            lblno.Text = "Tonelada"
        End If


        If cbode2.Text = "Quilate" And cboa2.Text = "Decagramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) / 50
            lblno.Text = "DG"
        End If

        If cbode2.Text = "Quilate" And cboa2.Text = "Kilogramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) / 5000
            lblno.Text = "KG"
        End If

        If cbode2.Text = "Quilate" And cboa2.Text = "Hectogramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) / 500
            lblno.Text = "HG"
        End If

        If cbode2.Text = "Quilate" And cboa2.Text = "Gramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) / 5
            lblno.Text = "G"
        End If

        If cbode2.Text = "Quilate" And cboa2.Text = "Quilate" Then
            lblrespuesta2.Text = Val(txtvalor2.Text)
            lblno.Text = "Q"
        End If

        If cbode2.Text = "Quilate" And cboa2.Text = "Centigramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 20
            lblno.Text = "CG"
        End If

        If cbode2.Text = "Quilate" And cboa2.Text = "Miligramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 200
            lblno.Text = "MG"
        End If

        If cbode2.Text = "Quilate" And cboa2.Text = "Libra" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) / 2268
            lblno.Text = "LB"
        End If

        If cbode2.Text = "Quilate" And cboa2.Text = "Quintal" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) / 500000
            lblno.Text = "Quintal"
        End If




        '----------------------........Centigramo...........---------------------
        If cbode2.Text = "Centigramo" And cboa2.Text = "Tonelada" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) / 100000000.0

            lblno.Text = "Tonelada"
        End If


        If cbode2.Text = "Centigramo" And cboa2.Text = "Decagramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 1000
            lblno.Text = "DG"
        End If

        If cbode2.Text = "Centigramo" And cboa2.Text = "Kilogramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) / 100000
            lblno.Text = "KG"
        End If

        If cbode2.Text = "Centigramo" And cboa2.Text = "Hectogramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 10000
            lblno.Text = "HG"
        End If

        If cbode2.Text = "Centigramo" And cboa2.Text = "Gramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) / 100
            lblno.Text = "G"
        End If

        If cbode2.Text = "Centigramo" And cboa2.Text = "Quilate" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) / 20
            lblno.Text = "Q"
        End If

        If cbode2.Text = "Centigramo" And cboa2.Text = "Centigramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text)
            lblno.Text = "CG"
        End If

        If cbode2.Text = "Centigramo" And cboa2.Text = "Miligramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 10
            lblno.Text = "MG"
        End If

        If cbode2.Text = "Centigramo" And cboa2.Text = "Libra" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) / 45359
            lblno.Text = "LB"
        End If

        If cbode2.Text = "Centigramo" And cboa2.Text = "Quintal" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) / 10000000.0
            lblno.Text = "Quintal"
        End If


        '----------------------........Miligramo...........---------------------
        If cbode2.Text = "Miligramo" And cboa2.Text = "Tonelada" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) / 1000000000.0
            lblno.Text = "Tonelada"
        End If


        If cbode2.Text = "Miligramo" And cboa2.Text = "Decagramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) / 10000
            lblno.Text = "DG"
        End If

        If cbode2.Text = "Miligramo" And cboa2.Text = "Kilogramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) / 100
            lblno.Text = "KG"
        End If

        If cbode2.Text = "Miligramo" And cboa2.Text = "Hectogramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 10
            lblno.Text = "HG"
        End If

        If cbode2.Text = "Miligramo" And cboa2.Text = "Gramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 10
            lblno.Text = "G"
        End If

        If cbode2.Text = "Miligramo" And cboa2.Text = "Quilate" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 50
            lblno.Text = "Q"
        End If

        If cbode2.Text = "Miligramo" And cboa2.Text = "Centigramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 1000
            lblno.Text = "CG"
        End If

        If cbode2.Text = "Miligramo" And cboa2.Text = "Miligramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text)
            lblno.Text = "MG"
        End If

        If cbode2.Text = "Miligramo" And cboa2.Text = "Libra" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) / 45.359
            lblno.Text = "LB"
        End If

        If cbode2.Text = "Miligramo" And cboa2.Text = "Quintal" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) / 10000
            lblno.Text = "Quintal"
        End If



        '----------------------........Libra...........---------------------
        If cbode2.Text = "Libra" And cboa2.Text = "Tonelada" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) / 2205
            lblno.Text = "Tonelada"
        End If


        If cbode2.Text = "Libra" And cboa2.Text = "Decagramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 45.359
            lblno.Text = "DG"
        End If

        If cbode2.Text = "Libra" And cboa2.Text = "Kilogramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) / 2.205
            lblno.Text = "KG"
        End If

        If cbode2.Text = "Libra" And cboa2.Text = "Hectogramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 4.536
            lblno.Text = "HG"
        End If

        If cbode2.Text = "Libra" And cboa2.Text = "Gramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 454
            lblno.Text = "G"
        End If

        If cbode2.Text = "Libra" And cboa2.Text = "Quilate" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 2268
            lblno.Text = "Q"
        End If

        If cbode2.Text = "Libra" And cboa2.Text = "Centigramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 45359
            lblno.Text = "CG"
        End If

        If cbode2.Text = "Libra" And cboa2.Text = "Miligramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 453592
            lblno.Text = "MG"
        End If

        If cbode2.Text = "Libra" And cboa2.Text = "Libra" Then
            lblrespuesta2.Text = Val(txtvalor2.Text)
            lblno.Text = "LB"
        End If

        If cbode2.Text = "Libra" And cboa2.Text = "Quintal" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) / 220
            lblno.Text = "Quintal"
        End If




        '----------------------........Quintal...........---------------------
        If cbode2.Text = "Quintal" And cboa2.Text = "Tonelada" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) / 10
            lblno.Text = "Tonelada"
        End If


        If cbode2.Text = "Quintal" And cboa2.Text = "Decagramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 10000
            lblno.Text = "DG"
        End If

        If cbode2.Text = "Quintal" And cboa2.Text = "Kilogramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) / 100
            lblno.Text = "KG"
        End If

        If cbode2.Text = "Quintal" And cboa2.Text = "Hectogramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 1000
            lblno.Text = "HG"
        End If

        If cbode2.Text = "Quintal" And cboa2.Text = "Gramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 100000
            lblno.Text = "G"
        End If

        If cbode2.Text = "Quintal" And cboa2.Text = "Quilate" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 500000
            lblno.Text = "Q"
        End If

        If cbode2.Text = "Quintal" And cboa2.Text = "Centigramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 10000000.0
            lblno.Text = "CG"
        End If

        If cbode2.Text = "Quintal" And cboa2.Text = "Miligramo" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 100000000.0
            lblno.Text = "MG"
        End If

        If cbode2.Text = "Quintal" And cboa2.Text = "Libra" Then
            lblrespuesta2.Text = Val(txtvalor2.Text) * 220
            lblno.Text = "LB"
        End If

        If cbode2.Text = "Quintal" And cboa2.Text = "Quintal" Then
            lblrespuesta2.Text = Val(txtvalor2.Text)
            lblno.Text = "Quintal"
        End If





    End Sub
End Class
