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
        Me.TabPrincipal = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.rdo1 = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.LblValor = New System.Windows.Forms.Label()
        Me.TxtA = New System.Windows.Forms.TextBox()
        Me.LblA = New System.Windows.Forms.Label()
        Me.LblDe = New System.Windows.Forms.Label()
        Me.TxtDE = New System.Windows.Forms.TextBox()
        Me.BtnConversordearea = New System.Windows.Forms.Button()
        Me.rdo7 = New System.Windows.Forms.RadioButton()
        Me.rdo5 = New System.Windows.Forms.RadioButton()
        Me.rdo6 = New System.Windows.Forms.RadioButton()
        Me.rdo4 = New System.Windows.Forms.RadioButton()
        Me.rdo2 = New System.Windows.Forms.RadioButton()
        Me.rdo3 = New System.Windows.Forms.RadioButton()
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
        Me.TabPrincipal.Size = New System.Drawing.Size(507, 362)
        Me.TabPrincipal.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.TabPage1.Controls.Add(Me.rdo1)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(499, 336)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
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
        Me.Button1.Location = New System.Drawing.Point(259, 241)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Convertir"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.LblValor)
        Me.TabPage2.Controls.Add(Me.TxtA)
        Me.TabPage2.Controls.Add(Me.LblA)
        Me.TabPage2.Controls.Add(Me.LblDe)
        Me.TabPage2.Controls.Add(Me.TxtDE)
        Me.TabPage2.Controls.Add(Me.BtnConversordearea)
        Me.TabPage2.Controls.Add(Me.rdo7)
        Me.TabPage2.Controls.Add(Me.rdo5)
        Me.TabPage2.Controls.Add(Me.rdo6)
        Me.TabPage2.Controls.Add(Me.rdo4)
        Me.TabPage2.Controls.Add(Me.rdo2)
        Me.TabPage2.Controls.Add(Me.rdo3)
        Me.TabPage2.Controls.Add(Me.PictureBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(499, 336)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'LblValor
        '
        Me.LblValor.AutoSize = True
        Me.LblValor.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LblValor.Location = New System.Drawing.Point(318, 49)
        Me.LblValor.Name = "LblValor"
        Me.LblValor.Size = New System.Drawing.Size(80, 13)
        Me.LblValor.TabIndex = 21
        Me.LblValor.Text = "Ingrese el Valor"
        '
        'TxtA
        '
        Me.TxtA.Location = New System.Drawing.Point(289, 136)
        Me.TxtA.Name = "TxtA"
        Me.TxtA.Size = New System.Drawing.Size(133, 20)
        Me.TxtA.TabIndex = 20
        '
        'LblA
        '
        Me.LblA.AutoSize = True
        Me.LblA.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LblA.Location = New System.Drawing.Point(269, 139)
        Me.LblA.Name = "LblA"
        Me.LblA.Size = New System.Drawing.Size(14, 13)
        Me.LblA.TabIndex = 19
        Me.LblA.Text = "A"
        '
        'LblDe
        '
        Me.LblDe.AutoSize = True
        Me.LblDe.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LblDe.Location = New System.Drawing.Point(262, 100)
        Me.LblDe.Name = "LblDe"
        Me.LblDe.Size = New System.Drawing.Size(21, 13)
        Me.LblDe.TabIndex = 18
        Me.LblDe.Text = "De"
        '
        'TxtDE
        '
        Me.TxtDE.Location = New System.Drawing.Point(289, 97)
        Me.TxtDE.Name = "TxtDE"
        Me.TxtDE.Size = New System.Drawing.Size(133, 20)
        Me.TxtDE.TabIndex = 17
        '
        'BtnConversordearea
        '
        Me.BtnConversordearea.BackColor = System.Drawing.Color.Crimson
        Me.BtnConversordearea.Image = Global.Proyecto_final_de_computo_1.My.Resources.Resources.PIA18847_hires
        Me.BtnConversordearea.Location = New System.Drawing.Point(347, 256)
        Me.BtnConversordearea.Name = "BtnConversordearea"
        Me.BtnConversordearea.Size = New System.Drawing.Size(75, 23)
        Me.BtnConversordearea.TabIndex = 16
        Me.BtnConversordearea.Text = "Convertir"
        Me.BtnConversordearea.UseVisualStyleBackColor = False
        '
        'rdo7
        '
        Me.rdo7.AllowDrop = True
        Me.rdo7.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdo7.AutoSize = True
        Me.rdo7.BackgroundImage = Global.Proyecto_final_de_computo_1.My.Resources.Resources.fondo_dibujos_animados_elementos_matematicas_23_21481678062
        Me.rdo7.FlatAppearance.BorderColor = System.Drawing.Color.Yellow
        Me.rdo7.FlatAppearance.BorderSize = 0
        Me.rdo7.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.rdo7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.rdo7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.rdo7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdo7.Location = New System.Drawing.Point(23, 194)
        Me.rdo7.Name = "rdo7"
        Me.rdo7.Size = New System.Drawing.Size(61, 23)
        Me.rdo7.TabIndex = 15
        Me.rdo7.TabStop = True
        Me.rdo7.Text = "Hectarea"
        Me.rdo7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdo7.UseVisualStyleBackColor = True
        '
        'rdo5
        '
        Me.rdo5.AllowDrop = True
        Me.rdo5.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdo5.AutoSize = True
        Me.rdo5.BackgroundImage = Global.Proyecto_final_de_computo_1.My.Resources.Resources.fondo_dibujos_animados_elementos_matematicas_23_21481678061
        Me.rdo5.FlatAppearance.BorderColor = System.Drawing.Color.Yellow
        Me.rdo5.FlatAppearance.BorderSize = 0
        Me.rdo5.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.rdo5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.rdo5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.rdo5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdo5.Location = New System.Drawing.Point(24, 136)
        Me.rdo5.Name = "rdo5"
        Me.rdo5.Size = New System.Drawing.Size(50, 23)
        Me.rdo5.TabIndex = 14
        Me.rdo5.TabStop = True
        Me.rdo5.Text = "Tareas"
        Me.rdo5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdo5.UseVisualStyleBackColor = True
        '
        'rdo6
        '
        Me.rdo6.AllowDrop = True
        Me.rdo6.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdo6.AutoSize = True
        Me.rdo6.BackgroundImage = Global.Proyecto_final_de_computo_1.My.Resources.Resources.fondo_dibujos_animados_elementos_matematicas_23_2148167806
        Me.rdo6.FlatAppearance.BorderColor = System.Drawing.Color.Yellow
        Me.rdo6.FlatAppearance.BorderSize = 0
        Me.rdo6.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.rdo6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.rdo6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.rdo6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdo6.Location = New System.Drawing.Point(24, 165)
        Me.rdo6.Name = "rdo6"
        Me.rdo6.Size = New System.Drawing.Size(61, 23)
        Me.rdo6.TabIndex = 13
        Me.rdo6.TabStop = True
        Me.rdo6.Text = "Manzana"
        Me.rdo6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdo6.UseVisualStyleBackColor = True
        '
        'rdo4
        '
        Me.rdo4.AllowDrop = True
        Me.rdo4.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdo4.AutoSize = True
        Me.rdo4.BackgroundImage = Global.Proyecto_final_de_computo_1.My.Resources.Resources.fondo_dibujos_animados_elementos_matematicas_23_21481678062
        Me.rdo4.FlatAppearance.BorderColor = System.Drawing.Color.Yellow
        Me.rdo4.FlatAppearance.BorderSize = 0
        Me.rdo4.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.rdo4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.rdo4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.rdo4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdo4.Location = New System.Drawing.Point(24, 107)
        Me.rdo4.Name = "rdo4"
        Me.rdo4.Size = New System.Drawing.Size(93, 23)
        Me.rdo4.TabIndex = 12
        Me.rdo4.TabStop = True
        Me.rdo4.Text = "Metro Cuadrado"
        Me.rdo4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdo4.UseVisualStyleBackColor = True
        '
        'rdo2
        '
        Me.rdo2.AllowDrop = True
        Me.rdo2.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdo2.AutoSize = True
        Me.rdo2.BackgroundImage = Global.Proyecto_final_de_computo_1.My.Resources.Resources.fondo_dibujos_animados_elementos_matematicas_23_2148167806
        Me.rdo2.FlatAppearance.BorderColor = System.Drawing.Color.Yellow
        Me.rdo2.FlatAppearance.BorderSize = 0
        Me.rdo2.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.rdo2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.rdo2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.rdo2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdo2.Location = New System.Drawing.Point(23, 49)
        Me.rdo2.Name = "rdo2"
        Me.rdo2.Size = New System.Drawing.Size(88, 23)
        Me.rdo2.TabIndex = 11
        Me.rdo2.TabStop = True
        Me.rdo2.Text = "Vara Cuadrada"
        Me.rdo2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdo2.UseVisualStyleBackColor = True
        '
        'rdo3
        '
        Me.rdo3.AllowDrop = True
        Me.rdo3.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdo3.AutoSize = True
        Me.rdo3.BackgroundImage = Global.Proyecto_final_de_computo_1.My.Resources.Resources.fondo_dibujos_animados_elementos_matematicas_23_2148167806
        Me.rdo3.FlatAppearance.BorderColor = System.Drawing.Color.Yellow
        Me.rdo3.FlatAppearance.BorderSize = 0
        Me.rdo3.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.rdo3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.rdo3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.rdo3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdo3.Location = New System.Drawing.Point(23, 78)
        Me.rdo3.Name = "rdo3"
        Me.rdo3.Size = New System.Drawing.Size(94, 23)
        Me.rdo3.TabIndex = 10
        Me.rdo3.TabStop = True
        Me.rdo3.Text = "Yarda Cuadrada"
        Me.rdo3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdo3.UseVisualStyleBackColor = True
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
        Me.Panel1.Size = New System.Drawing.Size(507, 51)
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
        Me.ClientSize = New System.Drawing.Size(507, 362)
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
    Friend WithEvents TxtA As TextBox
    Friend WithEvents LblA As Label
    Friend WithEvents LblDe As Label
    Friend WithEvents TxtDE As TextBox
    Friend WithEvents BtnConversordearea As Button
    Friend WithEvents rdo7 As RadioButton
    Friend WithEvents rdo5 As RadioButton
    Friend WithEvents rdo6 As RadioButton
    Friend WithEvents rdo4 As RadioButton
    Friend WithEvents rdo2 As RadioButton
    Friend WithEvents rdo3 As RadioButton
    Friend WithEvents PictureBox1 As PictureBox
End Class
