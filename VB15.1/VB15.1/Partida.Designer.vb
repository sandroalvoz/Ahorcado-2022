<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Partida
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
        Me.components = New System.ComponentModel.Container()
        Me.GB1 = New System.Windows.Forms.GroupBox()
        Me.B1 = New System.Windows.Forms.Button()
        Me.CB1 = New System.Windows.Forms.ComboBox()
        Me.GB2 = New System.Windows.Forms.GroupBox()
        Me.LB1 = New System.Windows.Forms.ListBox()
        Me.TB1 = New System.Windows.Forms.TextBox()
        Me.TB2 = New System.Windows.Forms.TextBox()
        Me.TB3 = New System.Windows.Forms.TextBox()
        Me.L1 = New System.Windows.Forms.Label()
        Me.L2 = New System.Windows.Forms.Label()
        Me.L3 = New System.Windows.Forms.Label()
        Me.B2 = New System.Windows.Forms.Button()
        Me.B3 = New System.Windows.Forms.Button()
        Me.B4 = New System.Windows.Forms.Button()
        Me.B5 = New System.Windows.Forms.Button()
        Me.B6 = New System.Windows.Forms.Button()
        Me.L4 = New System.Windows.Forms.Label()
        Me.T1 = New System.Windows.Forms.Timer(Me.components)
        Me.L5 = New System.Windows.Forms.Label()
        Me.L6 = New System.Windows.Forms.Label()
        Me.PB1 = New System.Windows.Forms.PictureBox()
        Me.TB4 = New System.Windows.Forms.TextBox()
        Me.L7 = New System.Windows.Forms.Label()
        Me.B7 = New System.Windows.Forms.Button()
        Me.GB1.SuspendLayout()
        Me.GB2.SuspendLayout()
        CType(Me.PB1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GB1
        '
        Me.GB1.Controls.Add(Me.B1)
        Me.GB1.Controls.Add(Me.CB1)
        Me.GB1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB1.Location = New System.Drawing.Point(12, 12)
        Me.GB1.Name = "GB1"
        Me.GB1.Size = New System.Drawing.Size(200, 112)
        Me.GB1.TabIndex = 0
        Me.GB1.TabStop = False
        Me.GB1.Text = "Introducir letra."
        '
        'B1
        '
        Me.B1.Enabled = False
        Me.B1.Location = New System.Drawing.Point(18, 68)
        Me.B1.Name = "B1"
        Me.B1.Size = New System.Drawing.Size(164, 33)
        Me.B1.TabIndex = 1
        Me.B1.Text = "Enviar"
        Me.B1.UseVisualStyleBackColor = True
        '
        'CB1
        '
        Me.CB1.FormattingEnabled = True
        Me.CB1.Items.AddRange(New Object() {"a", "b", "c", "d", "e", "f", "g", "h", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"})
        Me.CB1.Location = New System.Drawing.Point(18, 29)
        Me.CB1.Name = "CB1"
        Me.CB1.Size = New System.Drawing.Size(164, 33)
        Me.CB1.TabIndex = 0
        '
        'GB2
        '
        Me.GB2.Controls.Add(Me.LB1)
        Me.GB2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB2.Location = New System.Drawing.Point(218, 12)
        Me.GB2.Name = "GB2"
        Me.GB2.Size = New System.Drawing.Size(200, 112)
        Me.GB2.TabIndex = 1
        Me.GB2.TabStop = False
        Me.GB2.Text = "Letras introducidas"
        '
        'LB1
        '
        Me.LB1.FormattingEnabled = True
        Me.LB1.ItemHeight = 25
        Me.LB1.Location = New System.Drawing.Point(6, 29)
        Me.LB1.Name = "LB1"
        Me.LB1.ScrollAlwaysVisible = True
        Me.LB1.Size = New System.Drawing.Size(147, 79)
        Me.LB1.TabIndex = 0
        '
        'TB1
        '
        Me.TB1.Enabled = False
        Me.TB1.Location = New System.Drawing.Point(596, 26)
        Me.TB1.Name = "TB1"
        Me.TB1.Size = New System.Drawing.Size(159, 22)
        Me.TB1.TabIndex = 2
        '
        'TB2
        '
        Me.TB2.Enabled = False
        Me.TB2.Location = New System.Drawing.Point(596, 55)
        Me.TB2.Name = "TB2"
        Me.TB2.Size = New System.Drawing.Size(159, 22)
        Me.TB2.TabIndex = 3
        '
        'TB3
        '
        Me.TB3.Enabled = False
        Me.TB3.Location = New System.Drawing.Point(596, 88)
        Me.TB3.Name = "TB3"
        Me.TB3.Size = New System.Drawing.Size(159, 22)
        Me.TB3.TabIndex = 4
        '
        'L1
        '
        Me.L1.AutoSize = True
        Me.L1.Location = New System.Drawing.Point(424, 29)
        Me.L1.Name = "L1"
        Me.L1.Size = New System.Drawing.Size(54, 16)
        Me.L1.TabIndex = 5
        Me.L1.Text = "Usuario"
        '
        'L2
        '
        Me.L2.AutoSize = True
        Me.L2.Location = New System.Drawing.Point(424, 55)
        Me.L2.Name = "L2"
        Me.L2.Size = New System.Drawing.Size(96, 16)
        Me.L2.TabIndex = 6
        Me.L2.Text = "Tiempo récord"
        '
        'L3
        '
        Me.L3.AutoSize = True
        Me.L3.Location = New System.Drawing.Point(424, 91)
        Me.L3.Name = "L3"
        Me.L3.Size = New System.Drawing.Size(144, 16)
        Me.L3.TabIndex = 7
        Me.L3.Text = "Porcentaje de victorias"
        '
        'B2
        '
        Me.B2.Location = New System.Drawing.Point(525, 405)
        Me.B2.Name = "B2"
        Me.B2.Size = New System.Drawing.Size(232, 33)
        Me.B2.TabIndex = 8
        Me.B2.Text = "Salir"
        Me.B2.UseVisualStyleBackColor = True
        '
        'B3
        '
        Me.B3.Location = New System.Drawing.Point(12, 405)
        Me.B3.Name = "B3"
        Me.B3.Size = New System.Drawing.Size(232, 33)
        Me.B3.TabIndex = 9
        Me.B3.Text = "Añadir palabra"
        Me.B3.UseVisualStyleBackColor = True
        '
        'B4
        '
        Me.B4.Location = New System.Drawing.Point(268, 405)
        Me.B4.Name = "B4"
        Me.B4.Size = New System.Drawing.Size(232, 33)
        Me.B4.TabIndex = 10
        Me.B4.Text = "Ver estadísticas"
        Me.B4.UseVisualStyleBackColor = True
        '
        'B5
        '
        Me.B5.Location = New System.Drawing.Point(12, 357)
        Me.B5.Name = "B5"
        Me.B5.Size = New System.Drawing.Size(164, 33)
        Me.B5.TabIndex = 11
        Me.B5.Text = "Comenzar partida"
        Me.B5.UseVisualStyleBackColor = True
        '
        'B6
        '
        Me.B6.Location = New System.Drawing.Point(591, 357)
        Me.B6.Name = "B6"
        Me.B6.Size = New System.Drawing.Size(164, 33)
        Me.B6.TabIndex = 12
        Me.B6.Text = "Rendirse"
        Me.B6.UseVisualStyleBackColor = True
        '
        'L4
        '
        Me.L4.AutoSize = True
        Me.L4.Location = New System.Drawing.Point(229, 365)
        Me.L4.Name = "L4"
        Me.L4.Size = New System.Drawing.Size(68, 16)
        Me.L4.TabIndex = 13
        Me.L4.Text = "Tiempo: X"
        '
        'T1
        '
        '
        'L5
        '
        Me.L5.AutoSize = True
        Me.L5.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L5.Location = New System.Drawing.Point(82, 178)
        Me.L5.Name = "L5"
        Me.L5.Size = New System.Drawing.Size(215, 69)
        Me.L5.TabIndex = 14
        Me.L5.Text = "prueba"
        '
        'L6
        '
        Me.L6.AutoSize = True
        Me.L6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L6.Location = New System.Drawing.Point(424, 365)
        Me.L6.Name = "L6"
        Me.L6.Size = New System.Drawing.Size(122, 16)
        Me.L6.TabIndex = 15
        Me.L6.Text = "Número de fallos: 0"
        '
        'PB1
        '
        Me.PB1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB1.Location = New System.Drawing.Point(346, 164)
        Me.PB1.Name = "PB1"
        Me.PB1.Size = New System.Drawing.Size(210, 158)
        Me.PB1.TabIndex = 16
        Me.PB1.TabStop = False
        '
        'TB4
        '
        Me.TB4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB4.Location = New System.Drawing.Point(589, 197)
        Me.TB4.Name = "TB4"
        Me.TB4.Size = New System.Drawing.Size(166, 30)
        Me.TB4.TabIndex = 17
        '
        'L7
        '
        Me.L7.AutoSize = True
        Me.L7.Location = New System.Drawing.Point(593, 178)
        Me.L7.Name = "L7"
        Me.L7.Size = New System.Drawing.Size(93, 16)
        Me.L7.TabIndex = 18
        Me.L7.Text = "La palabra es:"
        '
        'B7
        '
        Me.B7.Location = New System.Drawing.Point(589, 233)
        Me.B7.Name = "B7"
        Me.B7.Size = New System.Drawing.Size(164, 32)
        Me.B7.TabIndex = 19
        Me.B7.Text = "Enviar palabra"
        Me.B7.UseVisualStyleBackColor = True
        '
        'Partida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(769, 450)
        Me.Controls.Add(Me.B7)
        Me.Controls.Add(Me.L7)
        Me.Controls.Add(Me.TB4)
        Me.Controls.Add(Me.PB1)
        Me.Controls.Add(Me.L6)
        Me.Controls.Add(Me.L5)
        Me.Controls.Add(Me.L4)
        Me.Controls.Add(Me.B6)
        Me.Controls.Add(Me.B5)
        Me.Controls.Add(Me.B4)
        Me.Controls.Add(Me.B3)
        Me.Controls.Add(Me.B2)
        Me.Controls.Add(Me.L3)
        Me.Controls.Add(Me.L2)
        Me.Controls.Add(Me.L1)
        Me.Controls.Add(Me.TB3)
        Me.Controls.Add(Me.TB2)
        Me.Controls.Add(Me.TB1)
        Me.Controls.Add(Me.GB2)
        Me.Controls.Add(Me.GB1)
        Me.Name = "Partida"
        Me.Text = "Partida"
        Me.GB1.ResumeLayout(False)
        Me.GB2.ResumeLayout(False)
        CType(Me.PB1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GB1 As GroupBox
    Friend WithEvents B1 As Button
    Friend WithEvents CB1 As ComboBox
    Friend WithEvents GB2 As GroupBox
    Friend WithEvents LB1 As ListBox
    Friend WithEvents TB1 As TextBox
    Friend WithEvents TB2 As TextBox
    Friend WithEvents TB3 As TextBox
    Friend WithEvents L1 As Label
    Friend WithEvents L2 As Label
    Friend WithEvents L3 As Label
    Friend WithEvents B2 As Button
    Friend WithEvents B3 As Button
    Friend WithEvents B4 As Button
    Friend WithEvents B5 As Button
    Friend WithEvents B6 As Button
    Friend WithEvents L4 As Label
    Friend WithEvents T1 As Timer
    Friend WithEvents L5 As Label
    Friend WithEvents L6 As Label
    Friend WithEvents PB1 As PictureBox
    Friend WithEvents TB4 As TextBox
    Friend WithEvents L7 As Label
    Friend WithEvents B7 As Button
End Class
