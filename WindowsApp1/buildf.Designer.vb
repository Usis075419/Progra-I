<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class buildf
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.datagridbuild = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nbuild = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.format = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descrip = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.preci = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        CType(Me.datagridbuild, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'datagridbuild
        '
        Me.datagridbuild.AllowUserToAddRows = False
        Me.datagridbuild.AllowUserToDeleteRows = False
        Me.datagridbuild.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.datagridbuild.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridbuild.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.nbuild, Me.format, Me.descrip, Me.preci})
        Me.datagridbuild.Location = New System.Drawing.Point(345, 55)
        Me.datagridbuild.Margin = New System.Windows.Forms.Padding(2)
        Me.datagridbuild.Name = "datagridbuild"
        Me.datagridbuild.ReadOnly = True
        Me.datagridbuild.RowHeadersWidth = 62
        Me.datagridbuild.RowTemplate.Height = 28
        Me.datagridbuild.Size = New System.Drawing.Size(423, 214)
        Me.datagridbuild.TabIndex = 41
        '
        'id
        '
        Me.id.DataPropertyName = "(id)"
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        '
        'nbuild
        '
        Me.nbuild.DataPropertyName = "nbuild"
        Me.nbuild.HeaderText = "NOMBRE DE COMBO / BUILD"
        Me.nbuild.MinimumWidth = 8
        Me.nbuild.Name = "nbuild"
        Me.nbuild.ReadOnly = True
        Me.nbuild.Width = 250
        '
        'format
        '
        Me.format.DataPropertyName = "format"
        Me.format.HeaderText = "FORMATO"
        Me.format.MinimumWidth = 8
        Me.format.Name = "format"
        Me.format.ReadOnly = True
        Me.format.Width = 150
        '
        'descrip
        '
        Me.descrip.DataPropertyName = "descrip"
        Me.descrip.HeaderText = "DESCRIPCION"
        Me.descrip.MinimumWidth = 8
        Me.descrip.Name = "descrip"
        Me.descrip.ReadOnly = True
        Me.descrip.Width = 150
        '
        'preci
        '
        Me.preci.DataPropertyName = "preci"
        Me.preci.HeaderText = "PRECIO"
        Me.preci.MinimumWidth = 8
        Me.preci.Name = "preci"
        Me.preci.ReadOnly = True
        Me.preci.Width = 150
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.Location = New System.Drawing.Point(306, 386)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(124, 63)
        Me.Button2.TabIndex = 40
        Me.Button2.Text = "Salir"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(210, 106)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 39
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(210, 143)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 38
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(210, 180)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 37
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(65, 317)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 63)
        Me.Button1.TabIndex = 36
        Me.Button1.Text = "AGREGAR NUEVO"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(41, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "CONTIENE:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(41, 187)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "PRECIO:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(41, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "FORMATO:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(210, 55)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 32
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(41, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 13)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "NOMBRE DE COMBO / BUILD:"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(231, 317)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(124, 63)
        Me.Button3.TabIndex = 42
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button4.Location = New System.Drawing.Point(398, 317)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(124, 63)
        Me.Button4.TabIndex = 43
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button5.Location = New System.Drawing.Point(561, 317)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(124, 63)
        Me.Button5.TabIndex = 44
        Me.Button5.UseVisualStyleBackColor = False
        '
        'buildf
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.datagridbuild)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "buildf"
        Me.Text = "Build y combos."
        CType(Me.datagridbuild, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents datagridbuild As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents nbuild As DataGridViewTextBoxColumn
    Friend WithEvents format As DataGridViewTextBoxColumn
    Friend WithEvents descrip As DataGridViewTextBoxColumn
    Friend WithEvents preci As DataGridViewTextBoxColumn
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
End Class
