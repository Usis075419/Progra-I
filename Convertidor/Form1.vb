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

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged

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
        End If

        '........................................................

        'Peso Mexicano----------------------------------------------------------
        If cbode.Text = "Peso mx" And cboa.Text = "Dolar" Then
            lblrespuesta.Text = Val(TxtValor.Text) * 0.046

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
        End If

        '........................................................




    End Sub



    Private Sub TabPage4_Click(sender As Object, e As EventArgs) Handles TabPage4.Click

    End Sub

    Private Sub TabPage6_Click(sender As Object, e As EventArgs) Handles TabPage6.Click

    End Sub

    Private Sub lblrespuesta_Click(sender As Object, e As EventArgs) Handles lblrespuesta.Click

    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click

        TxtValor.Clear()


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
    End Sub
End Class
