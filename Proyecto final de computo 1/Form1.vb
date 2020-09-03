Public Class Form1
    Private Sub TabPage1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles rdoconversorpropio.CheckedChanged
        TabPrincipal.SelectedTab = TabPrincipal.TabPages.Item(0)
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles rdoconversordearea.CheckedChanged
        TabPrincipal.SelectedTab = TabPrincipal.TabPages.Item(1)
    End Sub

    Private Sub TabPage1_Click_1(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub rdo1_CheckedChanged(sender As Object, e As EventArgs) Handles rdo1.CheckedChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnConversordearea.Click


        '------------------------------------Superficie-------------------------------------------------------
        '---------------------------------Yardas Cuadradas-----------------------------------------------------
        If cbode.Text = ("Vara Cuadrada") And cboa.Text = ("Vara Cuadrada") Then
            lblrespuesta.Text = Val(txtvalor.Text)
            lbl2.Text = ("Varas cuadradas")
        End If

        If cbode.Text = ("Vara Cuadrada") And cboa.Text = ("Yarda cuadrada") Then
            lblrespuesta.Text = Math.Round(Val(txtvalor.Text) * 0.84, 3)
            lbl2.Text = ("Yardas cuadradas")
        End If

        If cbode.Text = ("Vara Cuadrada") And cboa.Text = ("Metro cuadrado") Then
            lblrespuesta.Text = Val(txtvalor.Text) * 0.7
            lbl2.Text = ("Metros Cuadrados")
        End If

        If cbode.Text = ("Vara Cuadrada") And cboa.Text = ("Tarea") Then
            lblrespuesta.Text = Val(txtvalor.Text) * 0.001117
            lbl2.Text = ("Tareas")
        End If

        If cbode.Text = ("Vara Cuadrada") And cboa.Text = ("Manzana") Then
            lblrespuesta.Text = Val(txtvalor.Text) * 0.001
            lbl2.Text = ("Manzanas")
        End If

        If cbode.Text = ("Vara Cuadrada") And cboa.Text = ("Hectarea") Then
            lblrespuesta.Text = Val(txtvalor.Text) * 0.00006987
            lbl2.Text = ("Hectareas")
        End If

        '--------------------------------Yardas Cuadradas----------------------------------------------------------
        If cbode.Text = ("Yarda cuadrada") And cboa.Text = ("Vara Cuadrada") Then
            lblrespuesta.Text = Val(txtvalor.Text)
            lbl2.Text = ("Varas cuadradas") * 14.280934618
        End If

        If cbode.Text = ("Yarda cuadrada") And cboa.Text = ("Yarda cuadrada") Then
            lblrespuesta.Text = Val(txtvalor.Text)
            lbl2.Text = ("Yardas cuadradas")
        End If

        If cbode.Text = ("Yarda cuadrada") And cboa.Text = ("Metro cuadrado") Then
            lblrespuesta.Text = Val(txtvalor.Text) / 1.196
            lbl2.Text = ("Metros Cuadrados")
        End If

        If cbode.Text = ("Yarda cuadrada") And cboa.Text = ("Tarea") Then
            lblrespuesta.Text = Val(txtvalor.Text) * 0.001329719084
            lbl2.Text = ("Tareas")
        End If

        If cbode.Text = ("Yarda cuadrada") And cboa.Text = ("Manzana") Then
            lblrespuesta.Text = Val(txtvalor.Text) * 0.00011870064736
            lbl2.Text = ("Manzanas")
        End If

        If cbode.Text = ("Yarda cuadrada") And cboa.Text = ("Hectarea") Then
            lblrespuesta.Text = Val(txtvalor.Text) / 11960
            lbl2.Text = ("Hectareas")
        End If

        '--------------------------------Metros Cuadrados---------------------------------------------------------
        If cbode.Text = ("Metro cuadrado") And cboa.Text = ("Vara Cuadrada") Then
            lblrespuesta.Text = Val(txtvalor.Text) / 1.431
            lbl2.Text = ("Varas cuadradas")
        End If

        If cbode.Text = ("Metro cuadrado") And cboa.Text = ("Yarda cuadrada") Then
            lblrespuesta.Text = Val(txtvalor.Text) * 1.196
            lbl2.Text = ("Yardas cuadradas")
        End If

        If cbode.Text = ("Metro cuadrado") And cboa.Text = ("Metro cuadrado") Then
            lblrespuesta.Text = Val(txtvalor.Text)
            lbl2.Text = ("Metros Cuadrados")
        End If

        If cbode.Text = ("Metro cuadrado") And cboa.Text = ("Tarea") Then
            lblrespuesta.Text = Val(txtvalor.Text) * 0.0015903307888
            lbl2.Text = ("Tareas")
        End If

        If cbode.Text = ("Metro cuadrado") And cboa.Text = ("Manzana") Then
            lblrespuesta.Text = Val(txtvalor.Text) / 7000
            lbl2.Text = ("Manzanas")
        End If

        If cbode.Text = ("Metro cuadrado") And cboa.Text = ("Hectarea") Then
            lblrespuesta.Text = Val(txtvalor.Text) * 10000
            lbl2.Text = ("Hectareas")
        End If

        '--------------------------------Tareas---------------------------------------------------------
        If cbode.Text = ("Tarea") And cboa.Text = ("Vara Cuadrada") Then
            lblrespuesta.Text = Val(txtvalor.Text) / 894.98443634
            lbl2.Text = ("Varas cuadradas")
        End If

        If cbode.Text = ("Tarea") And cboa.Text = ("Yarda cuadrada") Then
            lblrespuesta.Text = Val(txtvalor.Text) * 752.03854111
            lbl2.Text = ("Yardas cuadradas")
        End If

        If cbode.Text = ("Tarea") And cboa.Text = ("Metro cuadrado") Then
            lblrespuesta.Text = Val(txtvalor.Text) / 628.8
            lbl2.Text = ("Metros Cuadrados")
        End If

        If cbode.Text = ("Tarea") And cboa.Text = ("Tarea") Then
            lblrespuesta.Text = Val(txtvalor.Text)
            lbl2.Text = ("Tareas")
        End If

        If cbode.Text = ("Tarea") And cboa.Text = ("Manzana") Then
            lblrespuesta.Text = Val(txtvalor.Text) * 0.08926746167
            lbl2.Text = ("Manzanas")
        End If

        If cbode.Text = ("Tarea") And cboa.Text = ("Hectarea") Then
            lblrespuesta.Text = Val(txtvalor.Text) * 0.06288
            lbl2.Text = ("Hectareas")
        End If

        '---------------------------------Manzanas--------------------------------------------------------
        If cbode.Text = ("Manzana") And cboa.Text = ("Vara Cuadrada") Then
            lblrespuesta.Text = Val(txtvalor.Text) / 10000
            lbl2.Text = ("Varas cuadradas")
        End If

        If cbode.Text = ("Manzana") And cboa.Text = ("Yarda cuadrada") Then
            lblrespuesta.Text = Val(txtvalor.Text) / 8424.5538861
            lbl2.Text = ("Yardas cuadradas")
        End If

        If cbode.Text = ("Manzana") And cboa.Text = ("Metro cuadrado") Then
            lblrespuesta.Text = Val(txtvalor.Text) / 7000
            lbl2.Text = ("Metros Cuadrados")
        End If

        If cbode.Text = ("Manzana") And cboa.Text = ("Tarea") Then
            lblrespuesta.Text = Val(txtvalor.Text) / 11.202290076
            lbl2.Text = ("Tareas")
        End If

        If cbode.Text = ("Manzana") And cboa.Text = ("Manzana") Then
            lblrespuesta.Text = Val(txtvalor.Text)
            lbl2.Text = ("Manzanas")
        End If

        If cbode.Text = ("Manzana") And cboa.Text = ("Hectarea") Then
            lblrespuesta.Text = Val(txtvalor.Text) / 0.705
            lbl2.Text = ("Hectareas")
        End If

        '---------------------------------Hectareas----------------------------------------------------------
        If cbode.Text = ("Hectareas") And cboa.Text = ("Vara Cuadrada") Then
            lblrespuesta.Text = Val(txtvalor.Text) / 14233.213046
            lbl2.Text = ("Varas cuadradas")
        End If

        If cbode.Text = ("Hectareas") And cboa.Text = ("Yarda cuadrada") Then
            lblrespuesta.Text = Val(txtvalor.Text) / 11959.900463
            lbl2.Text = ("Yardas cuadradas")
        End If

        If cbode.Text = ("Hectareas") And cboa.Text = ("Metro cuadrado") Then
            lblrespuesta.Text = Val(txtvalor.Text) / 10000
            lbl2.Text = ("Metros Cuadrados")
        End If

        If cbode.Text = ("Hectareas") And cboa.Text = ("Tarea") Then
            lblrespuesta.Text = Val(txtvalor.Text) / 15.903307888
            lbl2.Text = ("Tareas")
        End If

        If cbode.Text = ("Hectareas") And cboa.Text = ("Manzana") Then
            lblrespuesta.Text = Val(txtvalor.Text) / 1.4196479273
            lbl2.Text = ("Manzanas")
        End If

        If cbode.Text = ("Hectareas") And cboa.Text = ("Hectarea") Then
            lblrespuesta.Text = Val(txtvalor.Text)
            lbl2.Text = ("Hectareas")
        End If










    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click


        txtvalor.Clear()


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click


        MessageBox.Show("Tenga un lido dia, bendiciones :)")
        End

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtunidad.TextChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click


        txtcantidad.Clear()
        txtunidad.Clear()
        txtcajas.Clear()


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        MessageBox.Show("Tenga un lindo dias, Bendiciones :)")
        End


    End Sub
End Class
