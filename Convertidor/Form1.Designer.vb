<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LblNum1 = New System.Windows.Forms.Label()
        Me.Txtnum1 = New System.Windows.Forms.TextBox()
        Me.LblNum2 = New System.Windows.Forms.Label()
        Me.TxtNum2 = New System.Windows.Forms.TextBox()
        Me.optSuma = New System.Windows.Forms.RadioButton()
        Me.optResta = New System.Windows.Forms.RadioButton()
        Me.optDivision = New System.Windows.Forms.RadioButton()
        Me.optMultiplicacion = New System.Windows.Forms.RadioButton()
        Me.optMod = New System.Windows.Forms.RadioButton()
        Me.optPotenciador = New System.Windows.Forms.RadioButton()
        Me.BtnCalcular = New System.Windows.Forms.Button()
        Me.LblRespuesta = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblNum1
        '
        Me.LblNum1.AutoSize = True
        Me.LblNum1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LblNum1.Location = New System.Drawing.Point(32, 30)
        Me.LblNum1.Name = "LblNum1"
        Me.LblNum1.Size = New System.Drawing.Size(35, 13)
        Me.LblNum1.TabIndex = 5
        Me.LblNum1.Text = "Num1"
        '
        'Txtnum1
        '
        Me.Txtnum1.Location = New System.Drawing.Point(73, 30)
        Me.Txtnum1.Name = "Txtnum1"
        Me.Txtnum1.Size = New System.Drawing.Size(100, 20)
        Me.Txtnum1.TabIndex = 6
        '
        'LblNum2
        '
        Me.LblNum2.AutoSize = True
        Me.LblNum2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LblNum2.Location = New System.Drawing.Point(32, 59)
        Me.LblNum2.Name = "LblNum2"
        Me.LblNum2.Size = New System.Drawing.Size(38, 13)
        Me.LblNum2.TabIndex = 7
        Me.LblNum2.Text = "Num 2"
        '
        'TxtNum2
        '
        Me.TxtNum2.Location = New System.Drawing.Point(73, 59)
        Me.TxtNum2.Name = "TxtNum2"
        Me.TxtNum2.Size = New System.Drawing.Size(100, 20)
        Me.TxtNum2.TabIndex = 8
        '
        'optSuma
        '
        Me.optSuma.AutoSize = True
        Me.optSuma.BackColor = System.Drawing.Color.Yellow
        Me.optSuma.Location = New System.Drawing.Point(34, 110)
        Me.optSuma.Name = "optSuma"
        Me.optSuma.Size = New System.Drawing.Size(31, 17)
        Me.optSuma.TabIndex = 9
        Me.optSuma.TabStop = True
        Me.optSuma.Text = "+"
        Me.optSuma.UseVisualStyleBackColor = False
        '
        'optResta
        '
        Me.optResta.AutoSize = True
        Me.optResta.BackColor = System.Drawing.Color.Lime
        Me.optResta.Location = New System.Drawing.Point(95, 110)
        Me.optResta.Name = "optResta"
        Me.optResta.Size = New System.Drawing.Size(28, 17)
        Me.optResta.TabIndex = 10
        Me.optResta.TabStop = True
        Me.optResta.Text = "-"
        Me.optResta.UseVisualStyleBackColor = False
        '
        'optDivision
        '
        Me.optDivision.AutoSize = True
        Me.optDivision.BackColor = System.Drawing.Color.Fuchsia
        Me.optDivision.Location = New System.Drawing.Point(35, 142)
        Me.optDivision.Name = "optDivision"
        Me.optDivision.Size = New System.Drawing.Size(30, 17)
        Me.optDivision.TabIndex = 11
        Me.optDivision.TabStop = True
        Me.optDivision.Text = "/"
        Me.optDivision.UseVisualStyleBackColor = False
        '
        'optMultiplicacion
        '
        Me.optMultiplicacion.AutoSize = True
        Me.optMultiplicacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.optMultiplicacion.Location = New System.Drawing.Point(156, 110)
        Me.optMultiplicacion.Name = "optMultiplicacion"
        Me.optMultiplicacion.Size = New System.Drawing.Size(29, 17)
        Me.optMultiplicacion.TabIndex = 12
        Me.optMultiplicacion.TabStop = True
        Me.optMultiplicacion.Text = "*"
        Me.optMultiplicacion.UseVisualStyleBackColor = False
        '
        'optMod
        '
        Me.optMod.AutoSize = True
        Me.optMod.BackColor = System.Drawing.Color.Olive
        Me.optMod.Location = New System.Drawing.Point(156, 142)
        Me.optMod.Name = "optMod"
        Me.optMod.Size = New System.Drawing.Size(46, 17)
        Me.optMod.TabIndex = 13
        Me.optMod.TabStop = True
        Me.optMod.Text = "Mod"
        Me.optMod.UseVisualStyleBackColor = False
        '
        'optPotenciador
        '
        Me.optPotenciador.AutoSize = True
        Me.optPotenciador.BackColor = System.Drawing.Color.Teal
        Me.optPotenciador.Location = New System.Drawing.Point(95, 142)
        Me.optPotenciador.Name = "optPotenciador"
        Me.optPotenciador.Size = New System.Drawing.Size(31, 17)
        Me.optPotenciador.TabIndex = 14
        Me.optPotenciador.TabStop = True
        Me.optPotenciador.Text = "^"
        Me.optPotenciador.UseVisualStyleBackColor = False
        '
        'BtnCalcular
        '
        Me.BtnCalcular.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnCalcular.Location = New System.Drawing.Point(35, 176)
        Me.BtnCalcular.Name = "BtnCalcular"
        Me.BtnCalcular.Size = New System.Drawing.Size(60, 23)
        Me.BtnCalcular.TabIndex = 15
        Me.BtnCalcular.Text = "Calcular"
        Me.BtnCalcular.UseVisualStyleBackColor = False
        '
        'LblRespuesta
        '
        Me.LblRespuesta.AutoSize = True
        Me.LblRespuesta.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LblRespuesta.Location = New System.Drawing.Point(115, 181)
        Me.LblRespuesta.Name = "LblRespuesta"
        Me.LblRespuesta.Size = New System.Drawing.Size(58, 13)
        Me.LblRespuesta.TabIndex = 16
        Me.LblRespuesta.Text = "Respuesta"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(221, 242)
        Me.Controls.Add(Me.LblRespuesta)
        Me.Controls.Add(Me.BtnCalcular)
        Me.Controls.Add(Me.optPotenciador)
        Me.Controls.Add(Me.optMod)
        Me.Controls.Add(Me.optMultiplicacion)
        Me.Controls.Add(Me.optDivision)
        Me.Controls.Add(Me.optResta)
        Me.Controls.Add(Me.optSuma)
        Me.Controls.Add(Me.TxtNum2)
        Me.Controls.Add(Me.LblNum2)
        Me.Controls.Add(Me.Txtnum1)
        Me.Controls.Add(Me.LblNum1)
        Me.Name = "Form1"
        Me.Text = "Conversor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblNum1 As Label
    Friend WithEvents Txtnum1 As TextBox
    Friend WithEvents LblNum2 As Label
    Friend WithEvents TxtNum2 As TextBox
    Friend WithEvents optSuma As RadioButton
    Friend WithEvents optResta As RadioButton
    Friend WithEvents optDivision As RadioButton
    Friend WithEvents optMultiplicacion As RadioButton
    Friend WithEvents optMod As RadioButton
    Friend WithEvents optPotenciador As RadioButton
    Friend WithEvents BtnCalcular As Button
    Friend WithEvents LblRespuesta As Label
End Class
