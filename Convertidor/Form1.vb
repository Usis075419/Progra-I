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
End Class
