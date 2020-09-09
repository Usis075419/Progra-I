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
        Me.btnProcesar = New System.Windows.Forms.Button()
        Me.lstTablas = New System.Windows.Forms.ListBox()
        Me.txtTabla = New System.Windows.Forms.TextBox()
        Me.lblTabla = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnProcesar
        '
        Me.btnProcesar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnProcesar.Location = New System.Drawing.Point(15, 96)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(100, 23)
        Me.btnProcesar.TabIndex = 7
        Me.btnProcesar.Text = "Generar Tabla"
        Me.btnProcesar.UseVisualStyleBackColor = False
        '
        'lstTablas
        '
        Me.lstTablas.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lstTablas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstTablas.ForeColor = System.Drawing.Color.Black
        Me.lstTablas.FormattingEnabled = True
        Me.lstTablas.Location = New System.Drawing.Point(181, 12)
        Me.lstTablas.Name = "lstTablas"
        Me.lstTablas.Size = New System.Drawing.Size(157, 132)
        Me.lstTablas.TabIndex = 6
        '
        'txtTabla
        '
        Me.txtTabla.Location = New System.Drawing.Point(52, 34)
        Me.txtTabla.Name = "txtTabla"
        Me.txtTabla.Size = New System.Drawing.Size(100, 20)
        Me.txtTabla.TabIndex = 5
        '
        'lblTabla
        '
        Me.lblTabla.AutoSize = True
        Me.lblTabla.BackColor = System.Drawing.Color.Yellow
        Me.lblTabla.Location = New System.Drawing.Point(12, 37)
        Me.lblTabla.Name = "lblTabla"
        Me.lblTabla.Size = New System.Drawing.Size(34, 13)
        Me.lblTabla.TabIndex = 4
        Me.lblTabla.Text = "Tabla"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 176)
        Me.Controls.Add(Me.btnProcesar)
        Me.Controls.Add(Me.lstTablas)
        Me.Controls.Add(Me.txtTabla)
        Me.Controls.Add(Me.lblTabla)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnProcesar As Button
    Friend WithEvents lstTablas As ListBox
    Friend WithEvents txtTabla As TextBox
    Friend WithEvents lblTabla As Label
End Class
