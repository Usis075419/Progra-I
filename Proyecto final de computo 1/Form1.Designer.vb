﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.TabPrincipal = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtcajas = New System.Windows.Forms.TextBox()
        Me.txtunidad = New System.Windows.Forms.TextBox()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.rdo1 = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboa = New System.Windows.Forms.ComboBox()
        Me.cbode = New System.Windows.Forms.ComboBox()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lblrespuesta = New System.Windows.Forms.Label()
        Me.LblValor = New System.Windows.Forms.Label()
        Me.txtvalor = New System.Windows.Forms.TextBox()
        Me.LblA = New System.Windows.Forms.Label()
        Me.LblDe = New System.Windows.Forms.Label()
        Me.BtnConversordearea = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rdoconversordearea = New System.Windows.Forms.RadioButton()
        Me.rdoconversorpropio = New System.Windows.Forms.RadioButton()
        Me.TabPrincipal.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabPrincipal
        '
        Me.TabPrincipal.Controls.Add(Me.TabPage1)
        Me.TabPrincipal.Controls.Add(Me.TabPage2)
        Me.TabPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.TabPrincipal.Name = "TabPrincipal"
        Me.TabPrincipal.SelectedIndex = 0
        Me.TabPrincipal.Size = New System.Drawing.Size(507, 352)
        Me.TabPrincipal.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Aqua
        Me.TabPage1.BackgroundImage = Global.Proyecto_final_de_computo_1.My.Resources.Resources.unnamed
        Me.TabPage1.Controls.Add(Me.Button5)
        Me.TabPage1.Controls.Add(Me.Button4)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.txtcajas)
        Me.TabPage1.Controls.Add(Me.txtunidad)
        Me.TabPage1.Controls.Add(Me.txtcantidad)
        Me.TabPage1.Controls.Add(Me.rdo1)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.TabPage1.Size = New System.Drawing.Size(499, 326)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Crimson
        Me.Button5.Image = Global.Proyecto_final_de_computo_1.My.Resources.Resources.PIA18847_hires
        Me.Button5.Location = New System.Drawing.Point(62, 283)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 10
        Me.Button5.Text = "Salir"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Crimson
        Me.Button4.Image = Global.Proyecto_final_de_computo_1.My.Resources.Resources.PIA18847_hires
        Me.Button4.Location = New System.Drawing.Point(319, 283)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "Limpiar"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(176, 57)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Conversor de cajas."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(122, 188)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Cajas/Unidades:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(239, 111)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Unidad :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(59, 111)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Cantidad :"
        '
        'txtcajas
        '
        Me.txtcajas.Location = New System.Drawing.Point(220, 188)
        Me.txtcajas.Margin = New System.Windows.Forms.Padding(2)
        Me.txtcajas.Name = "txtcajas"
        Me.txtcajas.Size = New System.Drawing.Size(119, 20)
        Me.txtcajas.TabIndex = 4
        '
        'txtunidad
        '
        Me.txtunidad.Location = New System.Drawing.Point(301, 111)
        Me.txtunidad.Margin = New System.Windows.Forms.Padding(2)
        Me.txtunidad.Name = "txtunidad"
        Me.txtunidad.Size = New System.Drawing.Size(96, 20)
        Me.txtunidad.TabIndex = 3
        '
        'txtcantidad
        '
        Me.txtcantidad.Location = New System.Drawing.Point(124, 111)
        Me.txtcantidad.Margin = New System.Windows.Forms.Padding(2)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(94, 20)
        Me.txtcantidad.TabIndex = 2
        '
        'rdo1
        '
        Me.rdo1.AllowDrop = True
        Me.rdo1.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdo1.AutoSize = True
        Me.rdo1.BackColor = System.Drawing.Color.Fuchsia
        Me.rdo1.BackgroundImage = Global.Proyecto_final_de_computo_1.My.Resources.Resources.PIA18847_hires
        Me.rdo1.FlatAppearance.BorderColor = System.Drawing.Color.Yellow
        Me.rdo1.FlatAppearance.BorderSize = 0
        Me.rdo1.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.rdo1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.rdo1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.rdo1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.rdo1.Location = New System.Drawing.Point(-194, -108)
        Me.rdo1.Name = "rdo1"
        Me.rdo1.Size = New System.Drawing.Size(81, 23)
        Me.rdo1.TabIndex = 1
        Me.rdo1.TabStop = True
        Me.rdo1.Text = "Pie Cuadrado"
        Me.rdo1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdo1.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Crimson
        Me.Button1.Image = Global.Proyecto_final_de_computo_1.My.Resources.Resources.PIA18847_hires
        Me.Button1.Location = New System.Drawing.Point(178, 225)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Convertir"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Button3)
        Me.TabPage2.Controls.Add(Me.Button2)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.cboa)
        Me.TabPage2.Controls.Add(Me.cbode)
        Me.TabPage2.Controls.Add(Me.lbl2)
        Me.TabPage2.Controls.Add(Me.lblrespuesta)
        Me.TabPage2.Controls.Add(Me.LblValor)
        Me.TabPage2.Controls.Add(Me.txtvalor)
        Me.TabPage2.Controls.Add(Me.LblA)
        Me.TabPage2.Controls.Add(Me.LblDe)
        Me.TabPage2.Controls.Add(Me.BtnConversordearea)
        Me.TabPage2.Controls.Add(Me.PictureBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.TabPage2.Size = New System.Drawing.Size(499, 326)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Crimson
        Me.Button3.Image = Global.Proyecto_final_de_computo_1.My.Resources.Resources.PIA18847_hires
        Me.Button3.Location = New System.Drawing.Point(8, 288)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 28
        Me.Button3.Text = "Salir"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Crimson
        Me.Button2.Image = Global.Proyecto_final_de_computo_1.My.Resources.Resources.PIA18847_hires
        Me.Button2.Location = New System.Drawing.Point(127, 184)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 27
        Me.Button2.Text = "Limpiar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(109, 225)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Respuesta :"
        '
        'cboa
        '
        Me.cboa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboa.FormattingEnabled = True
        Me.cboa.Items.AddRange(New Object() {"Pie cuadrado", "Vara Cuadrada", "Yarda cuadrada", "Metro cuadrado", "Tarea", "Manzana", "Hectarea"})
        Me.cboa.Location = New System.Drawing.Point(310, 60)
        Me.cboa.Name = "cboa"
        Me.cboa.Size = New System.Drawing.Size(150, 21)
        Me.cboa.TabIndex = 25
        '
        'cbode
        '
        Me.cbode.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
        Me.cbode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbode.FormattingEnabled = True
        Me.cbode.Items.AddRange(New Object() {"Pie cuadrado", "Vara Cuadrada", "Yarda cuadrada", "Metro cuadrado", "Tarea", "Manzana", "Hectarea"})
        Me.cbode.Location = New System.Drawing.Point(66, 60)
        Me.cbode.Name = "cbode"
        Me.cbode.Size = New System.Drawing.Size(152, 21)
        Me.cbode.TabIndex = 24
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Location = New System.Drawing.Point(193, 259)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(96, 13)
        Me.lbl2.TabIndex = 23
        Me.lbl2.Text = "Unidad de medida."
        '
        'lblrespuesta
        '
        Me.lblrespuesta.AutoSize = True
        Me.lblrespuesta.Location = New System.Drawing.Point(233, 225)
        Me.lblrespuesta.Name = "lblrespuesta"
        Me.lblrespuesta.Size = New System.Drawing.Size(13, 13)
        Me.lblrespuesta.TabIndex = 22
        Me.lblrespuesta.Text = "?"
        '
        'LblValor
        '
        Me.LblValor.AutoSize = True
        Me.LblValor.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LblValor.Location = New System.Drawing.Point(209, 153)
        Me.LblValor.Name = "LblValor"
        Me.LblValor.Size = New System.Drawing.Size(80, 13)
        Me.LblValor.TabIndex = 21
        Me.LblValor.Text = "Ingrese el Valor"
        '
        'txtvalor
        '
        Me.txtvalor.Location = New System.Drawing.Point(185, 119)
        Me.txtvalor.Name = "txtvalor"
        Me.txtvalor.Size = New System.Drawing.Size(133, 20)
        Me.txtvalor.TabIndex = 20
        '
        'LblA
        '
        Me.LblA.AutoSize = True
        Me.LblA.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LblA.Location = New System.Drawing.Point(290, 63)
        Me.LblA.Name = "LblA"
        Me.LblA.Size = New System.Drawing.Size(14, 13)
        Me.LblA.TabIndex = 19
        Me.LblA.Text = "A"
        '
        'LblDe
        '
        Me.LblDe.AutoSize = True
        Me.LblDe.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LblDe.Location = New System.Drawing.Point(23, 63)
        Me.LblDe.Name = "LblDe"
        Me.LblDe.Size = New System.Drawing.Size(21, 13)
        Me.LblDe.TabIndex = 18
        Me.LblDe.Text = "De"
        '
        'BtnConversordearea
        '
        Me.BtnConversordearea.BackColor = System.Drawing.Color.Crimson
        Me.BtnConversordearea.Image = Global.Proyecto_final_de_computo_1.My.Resources.Resources.PIA18847_hires
        Me.BtnConversordearea.Location = New System.Drawing.Point(293, 184)
        Me.BtnConversordearea.Name = "BtnConversordearea"
        Me.BtnConversordearea.Size = New System.Drawing.Size(75, 23)
        Me.BtnConversordearea.TabIndex = 16
        Me.BtnConversordearea.Text = "Convertir"
        Me.BtnConversordearea.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Proyecto_final_de_computo_1.My.Resources.Resources.yeah
        Me.PictureBox1.Location = New System.Drawing.Point(-27, -80)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(557, 444)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.rdoconversordearea)
        Me.Panel1.Controls.Add(Me.rdoconversorpropio)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(507, 36)
        Me.Panel1.TabIndex = 1
        '
        'rdoconversordearea
        '
        Me.rdoconversordearea.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoconversordearea.AutoSize = True
        Me.rdoconversordearea.BackgroundImage = Global.Proyecto_final_de_computo_1.My.Resources.Resources.fondo_dibujos_animados_elementos_matematicas_23_2148167806
        Me.rdoconversordearea.FlatAppearance.BorderColor = System.Drawing.Color.Yellow
        Me.rdoconversordearea.FlatAppearance.BorderSize = 0
        Me.rdoconversordearea.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.rdoconversordearea.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.rdoconversordearea.Location = New System.Drawing.Point(297, 12)
        Me.rdoconversordearea.Name = "rdoconversordearea"
        Me.rdoconversordearea.Size = New System.Drawing.Size(105, 23)
        Me.rdoconversordearea.TabIndex = 1
        Me.rdoconversordearea.Text = "Conversor de Area"
        Me.rdoconversordearea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoconversordearea.UseVisualStyleBackColor = True
        '
        'rdoconversorpropio
        '
        Me.rdoconversorpropio.AllowDrop = True
        Me.rdoconversorpropio.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoconversorpropio.AutoSize = True
        Me.rdoconversorpropio.BackgroundImage = Global.Proyecto_final_de_computo_1.My.Resources.Resources.fondo_dibujos_animados_elementos_matematicas_23_2148167806
        Me.rdoconversorpropio.Checked = True
        Me.rdoconversorpropio.FlatAppearance.BorderColor = System.Drawing.Color.Yellow
        Me.rdoconversorpropio.FlatAppearance.BorderSize = 0
        Me.rdoconversorpropio.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.rdoconversorpropio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.rdoconversorpropio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.rdoconversorpropio.Location = New System.Drawing.Point(93, 12)
        Me.rdoconversorpropio.Name = "rdoconversorpropio"
        Me.rdoconversorpropio.Size = New System.Drawing.Size(98, 23)
        Me.rdoconversorpropio.TabIndex = 0
        Me.rdoconversorpropio.TabStop = True
        Me.rdoconversorpropio.Text = "Conversor Propio"
        Me.rdoconversorpropio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoconversorpropio.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(507, 352)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TabPrincipal)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TabPrincipal.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabPrincipal As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents rdoconversordearea As RadioButton
    Friend WithEvents rdoconversorpropio As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents rdo1 As RadioButton
    Friend WithEvents LblValor As Label
    Friend WithEvents LblA As Label
    Friend WithEvents LblDe As Label
    Friend WithEvents BtnConversordearea As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtvalor As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cboa As ComboBox
    Friend WithEvents cbode As ComboBox
    Friend WithEvents lbl2 As Label
    Friend WithEvents lblrespuesta As Label
    Friend WithEvents txtunidad As TextBox
    Friend WithEvents txtcantidad As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtcajas As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
End Class
