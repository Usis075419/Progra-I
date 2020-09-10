<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnConvertir = New System.Windows.Forms.Button()
        Me.lblrespuesta = New System.Windows.Forms.Label()
        Me.lblcantidad = New System.Windows.Forms.Label()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.cbotipo = New System.Windows.Forms.ComboBox()
        Me.lbltipo = New System.Windows.Forms.Label()
        Me.cboa = New System.Windows.Forms.ComboBox()
        Me.cbode = New System.Windows.Forms.ComboBox()
        Me.lbla = New System.Windows.Forms.Label()
        Me.lblde = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnConvertir
        '
        Me.btnConvertir.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConvertir.Location = New System.Drawing.Point(111, 139)
        Me.btnConvertir.Name = "btnConvertir"
        Me.btnConvertir.Size = New System.Drawing.Size(172, 73)
        Me.btnConvertir.TabIndex = 25
        Me.btnConvertir.Text = "Convertir"
        Me.btnConvertir.UseVisualStyleBackColor = True
        '
        'lblrespuesta
        '
        Me.lblrespuesta.AutoSize = True
        Me.lblrespuesta.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrespuesta.Location = New System.Drawing.Point(334, 167)
        Me.lblrespuesta.Name = "lblrespuesta"
        Me.lblrespuesta.Size = New System.Drawing.Size(111, 19)
        Me.lblrespuesta.TabIndex = 24
        Me.lblrespuesta.Text = "Respuesta: ?"
        '
        'lblcantidad
        '
        Me.lblcantidad.AutoSize = True
        Me.lblcantidad.Location = New System.Drawing.Point(330, 88)
        Me.lblcantidad.Name = "lblcantidad"
        Me.lblcantidad.Size = New System.Drawing.Size(52, 13)
        Me.lblcantidad.TabIndex = 23
        Me.lblcantidad.Text = "Cantidad:"
        '
        'txtcantidad
        '
        Me.txtcantidad.Location = New System.Drawing.Point(388, 85)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(100, 20)
        Me.txtcantidad.TabIndex = 22
        '
        'cbotipo
        '
        Me.cbotipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbotipo.FormattingEnabled = True
        Me.cbotipo.Items.AddRange(New Object() {"Monedas", "Longitud", "Masa", "Almacenamiento", "Tiempo"})
        Me.cbotipo.Location = New System.Drawing.Point(203, 28)
        Me.cbotipo.Name = "cbotipo"
        Me.cbotipo.Size = New System.Drawing.Size(121, 21)
        Me.cbotipo.TabIndex = 21
        '
        'lbltipo
        '
        Me.lbltipo.AutoSize = True
        Me.lbltipo.Location = New System.Drawing.Point(166, 31)
        Me.lbltipo.Name = "lbltipo"
        Me.lbltipo.Size = New System.Drawing.Size(31, 13)
        Me.lbltipo.TabIndex = 20
        Me.lbltipo.Text = "Tipo:"
        '
        'cboa
        '
        Me.cboa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboa.FormattingEnabled = True
        Me.cboa.Location = New System.Drawing.Point(203, 88)
        Me.cboa.Name = "cboa"
        Me.cboa.Size = New System.Drawing.Size(121, 21)
        Me.cboa.TabIndex = 19
        '
        'cbode
        '
        Me.cbode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbode.FormattingEnabled = True
        Me.cbode.Location = New System.Drawing.Point(53, 88)
        Me.cbode.Name = "cbode"
        Me.cbode.Size = New System.Drawing.Size(121, 21)
        Me.cbode.TabIndex = 18
        '
        'lbla
        '
        Me.lbla.AutoSize = True
        Me.lbla.Location = New System.Drawing.Point(180, 91)
        Me.lbla.Name = "lbla"
        Me.lbla.Size = New System.Drawing.Size(17, 13)
        Me.lbla.TabIndex = 17
        Me.lbla.Text = "A:"
        '
        'lblde
        '
        Me.lblde.AutoSize = True
        Me.lblde.Location = New System.Drawing.Point(22, 91)
        Me.lblde.Name = "lblde"
        Me.lblde.Size = New System.Drawing.Size(25, 13)
        Me.lblde.TabIndex = 16
        Me.lblde.Text = "DE:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 278)
        Me.Controls.Add(Me.btnConvertir)
        Me.Controls.Add(Me.lblrespuesta)
        Me.Controls.Add(Me.lblcantidad)
        Me.Controls.Add(Me.txtcantidad)
        Me.Controls.Add(Me.cbotipo)
        Me.Controls.Add(Me.lbltipo)
        Me.Controls.Add(Me.cboa)
        Me.Controls.Add(Me.cbode)
        Me.Controls.Add(Me.lbla)
        Me.Controls.Add(Me.lblde)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnConvertir As Button
    Friend WithEvents lblrespuesta As Label
    Friend WithEvents lblcantidad As Label
    Friend WithEvents txtcantidad As TextBox
    Friend WithEvents cbotipo As ComboBox
    Friend WithEvents lbltipo As Label
    Friend WithEvents cboa As ComboBox
    Friend WithEvents cbode As ComboBox
    Friend WithEvents lbla As Label
    Friend WithEvents lblde As Label
End Class
