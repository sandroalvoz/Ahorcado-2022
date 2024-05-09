<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Iniciarsesion
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
        Me.L1 = New System.Windows.Forms.Label()
        Me.L2 = New System.Windows.Forms.Label()
        Me.TB1 = New System.Windows.Forms.TextBox()
        Me.TB2 = New System.Windows.Forms.TextBox()
        Me.L3 = New System.Windows.Forms.Label()
        Me.B1 = New System.Windows.Forms.Button()
        Me.B2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'L1
        '
        Me.L1.AutoSize = True
        Me.L1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L1.Location = New System.Drawing.Point(12, 9)
        Me.L1.Name = "L1"
        Me.L1.Size = New System.Drawing.Size(151, 20)
        Me.L1.TabIndex = 0
        Me.L1.Text = "Nombre de usuario"
        '
        'L2
        '
        Me.L2.AutoSize = True
        Me.L2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L2.Location = New System.Drawing.Point(12, 69)
        Me.L2.Name = "L2"
        Me.L2.Size = New System.Drawing.Size(95, 20)
        Me.L2.TabIndex = 1
        Me.L2.Text = "Contraseña"
        '
        'TB1
        '
        Me.TB1.Location = New System.Drawing.Point(16, 32)
        Me.TB1.Name = "TB1"
        Me.TB1.Size = New System.Drawing.Size(187, 22)
        Me.TB1.TabIndex = 2
        '
        'TB2
        '
        Me.TB2.Location = New System.Drawing.Point(16, 92)
        Me.TB2.Name = "TB2"
        Me.TB2.Size = New System.Drawing.Size(187, 22)
        Me.TB2.TabIndex = 3
        Me.TB2.UseSystemPasswordChar = True
        '
        'L3
        '
        Me.L3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L3.Location = New System.Drawing.Point(15, 151)
        Me.L3.Name = "L3"
        Me.L3.Size = New System.Drawing.Size(199, 61)
        Me.L3.TabIndex = 4
        Me.L3.Text = "¿No te has registrado? Haz clic aquí para crear un usuario"
        '
        'B1
        '
        Me.B1.Location = New System.Drawing.Point(12, 218)
        Me.B1.Name = "B1"
        Me.B1.Size = New System.Drawing.Size(77, 48)
        Me.B1.TabIndex = 5
        Me.B1.Text = "Acceder"
        Me.B1.UseVisualStyleBackColor = True
        '
        'B2
        '
        Me.B2.Location = New System.Drawing.Point(128, 218)
        Me.B2.Name = "B2"
        Me.B2.Size = New System.Drawing.Size(75, 48)
        Me.B2.TabIndex = 6
        Me.B2.Text = "Salir"
        Me.B2.UseVisualStyleBackColor = True
        '
        'Iniciarsesion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(215, 278)
        Me.Controls.Add(Me.B2)
        Me.Controls.Add(Me.B1)
        Me.Controls.Add(Me.L3)
        Me.Controls.Add(Me.TB2)
        Me.Controls.Add(Me.TB1)
        Me.Controls.Add(Me.L2)
        Me.Controls.Add(Me.L1)
        Me.Name = "Iniciarsesion"
        Me.Text = "Iniciar sesión"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents L1 As Label
    Friend WithEvents L2 As Label
    Friend WithEvents TB1 As TextBox
    Friend WithEvents TB2 As TextBox
    Friend WithEvents L3 As Label
    Friend WithEvents B1 As Button
    Friend WithEvents B2 As Button
End Class
