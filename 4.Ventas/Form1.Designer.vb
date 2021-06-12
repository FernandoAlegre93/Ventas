<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventas
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
        Me.btnPro = New System.Windows.Forms.Button()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdbtnBolsa = New System.Windows.Forms.RadioButton()
        Me.txtbx1 = New System.Windows.Forms.TextBox()
        Me.txtbx2 = New System.Windows.Forms.TextBox()
        Me.rdbtnLata = New System.Windows.Forms.RadioButton()
        Me.rdbtnVidrio = New System.Windows.Forms.RadioButton()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnPro
        '
        Me.btnPro.Location = New System.Drawing.Point(399, 61)
        Me.btnPro.Name = "btnPro"
        Me.btnPro.Size = New System.Drawing.Size(75, 23)
        Me.btnPro.TabIndex = 0
        Me.btnPro.Text = "Procesar"
        Me.btnPro.UseVisualStyleBackColor = True
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(491, 45)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(70, 13)
        Me.lbl1.TabIndex = 1
        Me.lbl1.Text = "Total a pagar"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdbtnVidrio)
        Me.GroupBox1.Controls.Add(Me.rdbtnLata)
        Me.GroupBox1.Controls.Add(Me.rdbtnBolsa)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(328, 52)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'rdbtnBolsa
        '
        Me.rdbtnBolsa.AutoSize = True
        Me.rdbtnBolsa.Location = New System.Drawing.Point(29, 15)
        Me.rdbtnBolsa.Name = "rdbtnBolsa"
        Me.rdbtnBolsa.Size = New System.Drawing.Size(51, 17)
        Me.rdbtnBolsa.TabIndex = 0
        Me.rdbtnBolsa.TabStop = True
        Me.rdbtnBolsa.Text = "Bolsa"
        Me.rdbtnBolsa.UseVisualStyleBackColor = True
        '
        'txtbx1
        '
        Me.txtbx1.Location = New System.Drawing.Point(494, 61)
        Me.txtbx1.Name = "txtbx1"
        Me.txtbx1.Size = New System.Drawing.Size(100, 20)
        Me.txtbx1.TabIndex = 1
        '
        'txtbx2
        '
        Me.txtbx2.Location = New System.Drawing.Point(137, 110)
        Me.txtbx2.Name = "txtbx2"
        Me.txtbx2.Size = New System.Drawing.Size(100, 20)
        Me.txtbx2.TabIndex = 3
        '
        'rdbtnLata
        '
        Me.rdbtnLata.AutoSize = True
        Me.rdbtnLata.Location = New System.Drawing.Point(125, 15)
        Me.rdbtnLata.Name = "rdbtnLata"
        Me.rdbtnLata.Size = New System.Drawing.Size(46, 17)
        Me.rdbtnLata.TabIndex = 4
        Me.rdbtnLata.TabStop = True
        Me.rdbtnLata.Text = "Lata"
        Me.rdbtnLata.UseVisualStyleBackColor = True
        '
        'rdbtnVidrio
        '
        Me.rdbtnVidrio.AutoSize = True
        Me.rdbtnVidrio.Location = New System.Drawing.Point(232, 14)
        Me.rdbtnVidrio.Name = "rdbtnVidrio"
        Me.rdbtnVidrio.Size = New System.Drawing.Size(51, 17)
        Me.rdbtnVidrio.TabIndex = 5
        Me.rdbtnVidrio.TabStop = True
        Me.rdbtnVidrio.Text = "Vidrio"
        Me.rdbtnVidrio.UseVisualStyleBackColor = True
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Location = New System.Drawing.Point(43, 113)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(87, 13)
        Me.lbl2.TabIndex = 4
        Me.lbl2.Text = "Ingrese Cantidad"
        '
        'Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(633, 145)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.txtbx2)
        Me.Controls.Add(Me.txtbx1)
        Me.Controls.Add(Me.btnPro)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbl1)
        Me.Name = "Ventas"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnPro As System.Windows.Forms.Button
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbtnVidrio As System.Windows.Forms.RadioButton
    Friend WithEvents rdbtnLata As System.Windows.Forms.RadioButton
    Friend WithEvents rdbtnBolsa As System.Windows.Forms.RadioButton
    Friend WithEvents txtbx1 As System.Windows.Forms.TextBox
    Friend WithEvents txtbx2 As System.Windows.Forms.TextBox
    Friend WithEvents lbl2 As System.Windows.Forms.Label

End Class
