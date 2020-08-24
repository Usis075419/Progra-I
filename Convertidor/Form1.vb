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

    Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox5.SelectedIndexChanged

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Panel8_Paint(sender As Object, e As PaintEventArgs)


    End Sub

    Private Sub BtnConvertidor_Click(sender As Object, e As EventArgs) Handles BtnConvertidormonedas.Click



        'dolar----------------------------------------------------------
        If cbode.Text = "Dolar" And cboa.Text = "Dolar" Then
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
            lblrespuestaDivisas.Text = Val(TxtValorDivisas.Text) * 0.046

        End If

        If cbode.Text = "Peso mx" And cboa.Text = "Euro" Then
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

    Private Sub lblrespuesta_Click(sender As Object, e As EventArgs) Handles lblrespuestaDivisas.Click

    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click

        TxtValorDivisas.Clear()


    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        MessageBox.Show("Gracias por utilizar el conversor, bonito dia :)")

        End

    End Sub


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
