Public Class Iniciarsesion
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles L3.Click
        Me.Hide() 'al hacer clic en L3, se oculta el formulario Iniciarsesion y se muestra Registrar
        Registrar.Show()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles B1.Click
        Dim sql As String = "Select Id FROM Tabla1 where usuario = '" & TB1.Text & "' AND contrasena ='" & TB2.Text & "'" 'instruccion SQL que comprueba 
        Dim r = consulta(sql)
        If r <> 0 Then 'se comprueba que el usuario y la contraseña introducidos estén registrados en la base de datos.
            Me.Hide() 'si el usuario y contraseña son correctos, se oculta el formulario Iniciarsesion y se muestra Partida.
            Partida.Show()
        Else
            MsgBox("El usuario y la contraseña introducidos no son correctos. No se puede iniciar sesión", vbYes, "ERROR AL INICIAR SESIÓN")
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles B2.Click
        Me.Close() 'al pulsar B2, se cierra el formulario.
    End Sub
End Class