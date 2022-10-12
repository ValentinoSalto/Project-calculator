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
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.btn0 = New System.Windows.Forms.Button()
        Me.sum = New System.Windows.Forms.Button()
        Me.res = New System.Windows.Forms.Button()
        Me.mul = New System.Windows.Forms.Button()
        Me.div = New System.Windows.Forms.Button()
        Me.igual = New System.Windows.Forms.Button()
        Me.TXT1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(14, 62)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(63, 55)
        Me.btn1.TabIndex = 0
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Location = New System.Drawing.Point(95, 62)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(63, 55)
        Me.btn2.TabIndex = 1
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Location = New System.Drawing.Point(176, 62)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(63, 55)
        Me.btn3.TabIndex = 2
        Me.btn3.Text = "3"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.Location = New System.Drawing.Point(257, 62)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(63, 55)
        Me.btn4.TabIndex = 3
        Me.btn4.Text = "4"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btn5
        '
        Me.btn5.Location = New System.Drawing.Point(338, 62)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(63, 55)
        Me.btn5.TabIndex = 4
        Me.btn5.Text = "5"
        Me.btn5.UseVisualStyleBackColor = True
        '
        'btn6
        '
        Me.btn6.Location = New System.Drawing.Point(14, 138)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(63, 55)
        Me.btn6.TabIndex = 5
        Me.btn6.Text = "6"
        Me.btn6.UseVisualStyleBackColor = True
        '
        'btn7
        '
        Me.btn7.Location = New System.Drawing.Point(95, 138)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(63, 55)
        Me.btn7.TabIndex = 6
        Me.btn7.Text = "7"
        Me.btn7.UseVisualStyleBackColor = True
        '
        'btn8
        '
        Me.btn8.Location = New System.Drawing.Point(176, 138)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(63, 55)
        Me.btn8.TabIndex = 7
        Me.btn8.Text = "8"
        Me.btn8.UseVisualStyleBackColor = True
        '
        'btn9
        '
        Me.btn9.Location = New System.Drawing.Point(257, 138)
        Me.btn9.Name = "btn9"
        Me.btn9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn9.Size = New System.Drawing.Size(63, 55)
        Me.btn9.TabIndex = 8
        Me.btn9.Text = "9"
        Me.btn9.UseVisualStyleBackColor = True
        '
        'btn0
        '
        Me.btn0.Location = New System.Drawing.Point(338, 138)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(63, 55)
        Me.btn0.TabIndex = 9
        Me.btn0.Text = "0"
        Me.btn0.UseVisualStyleBackColor = True
        '
        'sum
        '
        Me.sum.Location = New System.Drawing.Point(425, 65)
        Me.sum.Name = "sum"
        Me.sum.Size = New System.Drawing.Size(63, 55)
        Me.sum.TabIndex = 10
        Me.sum.Text = "+"
        Me.sum.UseVisualStyleBackColor = True
        '
        'res
        '
        Me.res.Location = New System.Drawing.Point(425, 151)
        Me.res.Name = "res"
        Me.res.Size = New System.Drawing.Size(63, 55)
        Me.res.TabIndex = 11
        Me.res.Text = "-"
        Me.res.UseVisualStyleBackColor = True
        '
        'mul
        '
        Me.mul.Location = New System.Drawing.Point(425, 239)
        Me.mul.Name = "mul"
        Me.mul.Size = New System.Drawing.Size(63, 55)
        Me.mul.TabIndex = 12
        Me.mul.Text = "X"
        Me.mul.UseVisualStyleBackColor = True
        '
        'div
        '
        Me.div.Location = New System.Drawing.Point(344, 239)
        Me.div.Name = "div"
        Me.div.Size = New System.Drawing.Size(63, 55)
        Me.div.TabIndex = 13
        Me.div.Text = "/"
        Me.div.UseVisualStyleBackColor = True
        '
        'igual
        '
        Me.igual.Location = New System.Drawing.Point(14, 230)
        Me.igual.Name = "igual"
        Me.igual.Size = New System.Drawing.Size(63, 55)
        Me.igual.TabIndex = 14
        Me.igual.Text = "="
        Me.igual.UseVisualStyleBackColor = True
        '
        'TXT1
        '
        Me.TXT1.Location = New System.Drawing.Point(12, 12)
        Me.TXT1.Name = "TXT1"
        Me.TXT1.Size = New System.Drawing.Size(476, 20)
        Me.TXT1.TabIndex = 15
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 306)
        Me.Controls.Add(Me.TXT1)
        Me.Controls.Add(Me.igual)
        Me.Controls.Add(Me.div)
        Me.Controls.Add(Me.mul)
        Me.Controls.Add(Me.res)
        Me.Controls.Add(Me.sum)
        Me.Controls.Add(Me.btn0)
        Me.Controls.Add(Me.btn9)
        Me.Controls.Add(Me.btn8)
        Me.Controls.Add(Me.btn7)
        Me.Controls.Add(Me.btn6)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn1 As System.Windows.Forms.Button
    Friend WithEvents btn2 As System.Windows.Forms.Button
    Friend WithEvents btn3 As System.Windows.Forms.Button
    Friend WithEvents btn4 As System.Windows.Forms.Button
    Friend WithEvents btn5 As System.Windows.Forms.Button
    Friend WithEvents btn6 As System.Windows.Forms.Button
    Friend WithEvents btn7 As System.Windows.Forms.Button
    Friend WithEvents btn8 As System.Windows.Forms.Button
    Friend WithEvents btn9 As System.Windows.Forms.Button
    Friend WithEvents btn0 As System.Windows.Forms.Button
    Friend WithEvents sum As System.Windows.Forms.Button
    Friend WithEvents res As System.Windows.Forms.Button
    Friend WithEvents mul As System.Windows.Forms.Button
    Friend WithEvents div As System.Windows.Forms.Button
    Friend WithEvents igual As System.Windows.Forms.Button
    Friend WithEvents TXT1 As System.Windows.Forms.TextBox

End Class
