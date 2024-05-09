<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Registrar
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
        Me.L1 = New System.Windows.Forms.Label()
        Me.L2 = New System.Windows.Forms.Label()
        Me.L3 = New System.Windows.Forms.Label()
        Me.L4 = New System.Windows.Forms.Label()
        Me.TB1 = New System.Windows.Forms.TextBox()
        Me.TB2 = New System.Windows.Forms.TextBox()
        Me.TB3 = New System.Windows.Forms.TextBox()
        Me.B1 = New System.Windows.Forms.Button()
        Me.B2 = New System.Windows.Forms.Button()
        Me.B3 = New System.Windows.Forms.Button()
        Me.B4 = New System.Windows.Forms.Button()
        Me.Tabla2TableAdapter1 = New VB15._1.BDDDataSetTableAdapters.Tabla2TableAdapter()
        Me.Tabla3TableAdapter1 = New VB15._1.BDD3TableAdapters.Tabla3TableAdapter()
        Me.RegistrarusuarioToolStrip = New System.Windows.Forms.ToolStrip()
        Me.RegistrarusuarioToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.Tabla1TableAdapter1 = New VB15._1.BDD1TableAdapters.Tabla1TableAdapter()
        Me.BDD1 = New VB15._1.BDD1()
        Me.RegistrarusuarioToolStrip.SuspendLayout()
        CType(Me.BDD1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'L1
        '
        Me.L1.AutoSize = True
        Me.L1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L1.Location = New System.Drawing.Point(12, 9)
        Me.L1.Name = "L1"
        Me.L1.Size = New System.Drawing.Size(254, 20)
        Me.L1.TabIndex = 0
        Me.L1.Text = "Introduzca un nombre de usuario"
        '
        'L2
        '
        Me.L2.AutoSize = True
        Me.L2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L2.Location = New System.Drawing.Point(12, 68)
        Me.L2.Name = "L2"
        Me.L2.Size = New System.Drawing.Size(207, 20)
        Me.L2.TabIndex = 1
        Me.L2.Text = "Introduzca una contraseña"
        '
        'L3
        '
        Me.L3.AutoSize = True
        Me.L3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L3.Location = New System.Drawing.Point(11, 126)
        Me.L3.Name = "L3"
        Me.L3.Size = New System.Drawing.Size(254, 20)
        Me.L3.TabIndex = 2
        Me.L3.Text = "Vuelva a introducir la contraseña"
        '
        'L4
        '
        Me.L4.AutoSize = True
        Me.L4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L4.Location = New System.Drawing.Point(11, 199)
        Me.L4.Name = "L4"
        Me.L4.Size = New System.Drawing.Size(237, 20)
        Me.L4.TabIndex = 3
        Me.L4.Text = "Las contraseñas no coinciden."
        '
        'TB1
        '
        Me.TB1.Location = New System.Drawing.Point(15, 32)
        Me.TB1.Name = "TB1"
        Me.TB1.Size = New System.Drawing.Size(258, 22)
        Me.TB1.TabIndex = 4
        '
        'TB2
        '
        Me.TB2.Location = New System.Drawing.Point(15, 101)
        Me.TB2.Name = "TB2"
        Me.TB2.Size = New System.Drawing.Size(158, 22)
        Me.TB2.TabIndex = 5
        Me.TB2.UseSystemPasswordChar = True
        '
        'TB3
        '
        Me.TB3.Location = New System.Drawing.Point(16, 162)
        Me.TB3.Name = "TB3"
        Me.TB3.Size = New System.Drawing.Size(157, 22)
        Me.TB3.TabIndex = 6
        Me.TB3.UseSystemPasswordChar = True
        '
        'B1
        '
        Me.B1.Location = New System.Drawing.Point(12, 250)
        Me.B1.Name = "B1"
        Me.B1.Size = New System.Drawing.Size(87, 47)
        Me.B1.TabIndex = 7
        Me.B1.Text = "Confirmar"
        Me.B1.UseVisualStyleBackColor = True
        '
        'B2
        '
        Me.B2.Location = New System.Drawing.Point(189, 250)
        Me.B2.Name = "B2"
        Me.B2.Size = New System.Drawing.Size(87, 47)
        Me.B2.TabIndex = 8
        Me.B2.Text = "Volver"
        Me.B2.UseVisualStyleBackColor = True
        '
        'B3
        '
        Me.B3.Location = New System.Drawing.Point(194, 100)
        Me.B3.Name = "B3"
        Me.B3.Size = New System.Drawing.Size(75, 23)
        Me.B3.TabIndex = 9
        Me.B3.Text = "Mostrar"
        Me.B3.UseVisualStyleBackColor = True
        '
        'B4
        '
        Me.B4.Location = New System.Drawing.Point(194, 161)
        Me.B4.Name = "B4"
        Me.B4.Size = New System.Drawing.Size(75, 23)
        Me.B4.TabIndex = 10
        Me.B4.Text = "Mostrar"
        Me.B4.UseVisualStyleBackColor = True
        '
        'Tabla2TableAdapter1
        '
        Me.Tabla2TableAdapter1.ClearBeforeFill = True
        '
        'Tabla3TableAdapter1
        '
        Me.Tabla3TableAdapter1.ClearBeforeFill = True
        '
        'RegistrarusuarioToolStrip
        '
        Me.RegistrarusuarioToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.RegistrarusuarioToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistrarusuarioToolStripButton})
        Me.RegistrarusuarioToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.RegistrarusuarioToolStrip.Name = "RegistrarusuarioToolStrip"
        Me.RegistrarusuarioToolStrip.Size = New System.Drawing.Size(285, 27)
        Me.RegistrarusuarioToolStrip.TabIndex = 11
        Me.RegistrarusuarioToolStrip.Text = "RegistrarusuarioToolStrip"
        '
        'RegistrarusuarioToolStripButton
        '
        Me.RegistrarusuarioToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.RegistrarusuarioToolStripButton.Name = "RegistrarusuarioToolStripButton"
        Me.RegistrarusuarioToolStripButton.Size = New System.Drawing.Size(116, 24)
        Me.RegistrarusuarioToolStripButton.Text = "registrarusuario"
        '
        'Tabla1TableAdapter1
        '
        Me.Tabla1TableAdapter1.ClearBeforeFill = True
        '
        'BDD1
        '
        Me.BDD1.DataSetName = "BDD1"
        Me.BDD1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Registrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(285, 317)
        Me.Controls.Add(Me.RegistrarusuarioToolStrip)
        Me.Controls.Add(Me.B4)
        Me.Controls.Add(Me.B3)
        Me.Controls.Add(Me.B2)
        Me.Controls.Add(Me.B1)
        Me.Controls.Add(Me.TB3)
        Me.Controls.Add(Me.TB2)
        Me.Controls.Add(Me.TB1)
        Me.Controls.Add(Me.L4)
        Me.Controls.Add(Me.L3)
        Me.Controls.Add(Me.L2)
        Me.Controls.Add(Me.L1)
        Me.Name = "Registrar"
        Me.Text = "Registrar"
        Me.RegistrarusuarioToolStrip.ResumeLayout(False)
        Me.RegistrarusuarioToolStrip.PerformLayout()
        CType(Me.BDD1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents L1 As Label
    Friend WithEvents L2 As Label
    Friend WithEvents L3 As Label
    Friend WithEvents L4 As Label
    Friend WithEvents TB1 As TextBox
    Friend WithEvents TB2 As TextBox
    Friend WithEvents TB3 As TextBox
    Friend WithEvents B1 As Button
    Friend WithEvents B2 As Button
    Friend WithEvents B3 As Button
    Friend WithEvents B4 As Button
    Friend WithEvents Tabla1TableAdapter1 As BDD1TableAdapters.Tabla1TableAdapter
    Friend WithEvents Tabla2TableAdapter1 As BDDDataSetTableAdapters.Tabla2TableAdapter
    Friend WithEvents Tabla3TableAdapter1 As BDD3TableAdapters.Tabla3TableAdapter
    Friend WithEvents BDD1 As BDD1
    Friend WithEvents RegistrarusuarioToolStrip As ToolStrip
    Friend WithEvents RegistrarusuarioToolStripButton As ToolStripButton
End Class
