<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Agregarpalabra
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
        Me.TB1 = New System.Windows.Forms.TextBox()
        Me.L1 = New System.Windows.Forms.Label()
        Me.B1 = New System.Windows.Forms.Button()
        Me.B2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TB1
        '
        Me.TB1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB1.Location = New System.Drawing.Point(12, 48)
        Me.TB1.Name = "TB1"
        Me.TB1.Size = New System.Drawing.Size(368, 38)
        Me.TB1.TabIndex = 0
        '
        'L1
        '
        Me.L1.AutoSize = True
        Me.L1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L1.Location = New System.Drawing.Point(12, 20)
        Me.L1.Name = "L1"
        Me.L1.Size = New System.Drawing.Size(168, 25)
        Me.L1.TabIndex = 1
        Me.L1.Text = "Introducir palabra:"
        '
        'B1
        '
        Me.B1.Location = New System.Drawing.Point(271, 135)
        Me.B1.Name = "B1"
        Me.B1.Size = New System.Drawing.Size(109, 52)
        Me.B1.TabIndex = 2
        Me.B1.Text = "Volver"
        Me.B1.UseVisualStyleBackColor = True
        '
        'B2
        '
        Me.B2.Location = New System.Drawing.Point(12, 135)
        Me.B2.Name = "B2"
        Me.B2.Size = New System.Drawing.Size(109, 52)
        Me.B2.TabIndex = 3
        Me.B2.Text = "Agregar"
        Me.B2.UseVisualStyleBackColor = True
        '
        'Agregarpalabra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 199)
        Me.Controls.Add(Me.B2)
        Me.Controls.Add(Me.B1)
        Me.Controls.Add(Me.L1)
        Me.Controls.Add(Me.TB1)
        Me.Name = "Agregarpalabra"
        Me.Text = "Agregar palabra"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TB1 As TextBox
    Friend WithEvents L1 As Label
    Friend WithEvents B1 As Button
    Friend WithEvents B2 As Button
End Class
