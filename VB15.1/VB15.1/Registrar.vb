Imports System.Data.OleDb
Imports System.Data
Imports System.Data.DataTable
Public Class Registrar
    Private Sub B1_Click(sender As Object, e As EventArgs) Handles B1.Click
        Dim sql As String = "Select Id FROM Tabla1 where usuario = '" & TB1.Text & "'" 'se escribe la consulta SQL. Ésta registrará Tabla1 en la base de datos, en búsqueda de valores del campo "usuarios" que coincidan con el usuario introducido
        Dim r = consulta(sql) 'se ejecuta la consulta SQL a través de la función consulta. Se recoge el ID de la fila cuyo campo "usuario" coincida con el usuario introducido. Al no haber ninguna fila que coincida, el valor devuelto es 0. Devuelve un integer.
        If r = 0 And TB2.Text = TB3.Text Then 'si el usuario no está registrado previamente y las contraseñas introducidas coinciden, se añade el usuario y la contraseña a la base de datos.
            sql = "insert into Tabla1 (usuario, contrasena) VALUES   ('" & TB1.Text & "','" & TB2.Text & "')" 'instruccion SQL que añade el usuario y contraseña a Tabla1
            If añadir(sql) Then 'la funcion añadir registra el numero de filas afectadas por la instruccion sql que ejecuta. El valor deberá ser mayor que 0 para que ésta se haya ejecutado correctamente.
                Iniciarsesion.TB1.Text = TB1.Text
                registro(1, 1)
                Me.Hide() 'al ejecutarse la instrucción SQL correctamente, se oculta el formulario Registrar y aparece el formulario Iniciarsesion
                Iniciarsesion.Show()
            Else
                MsgBox("No se ha añadido la información en la base de datos. Pruebe de nuevo.", vbOKOnly) 'si la instrucción SQL no se ejecuta correctamente, aparece un MsgBox que lo notifica.
            End If
        Else
            MsgBox("Compruebe la información introducida", vbOKOnly) 'si la información introducida es incorrecta o el usuario ya está en la base de datos, aparece un MsgBox que avisa de ello.
        End If
    End Sub
    Private Sub B3_Click(sender As Object, e As EventArgs) Handles B3.Click
        If B3.Text = "Mostrar" Then 'el pulsado de B3 influye sobre la propiedad UseSystemPasswordChar de TB2. A la vez, cambia el texto de B3 para adecuarlo a la función que tenga en cada momento.
            TB2.UseSystemPasswordChar = True
            B3.Text = "Ocultar"
        ElseIf B3.Text = "Ocultar" Then
            TB2.UseSystemPasswordChar = False
            B3.Text = "Mostrar"
        End If
    End Sub
    Private Sub B4_Click(sender As Object, e As EventArgs) Handles B4.Click
        If B4.Text = "Mostrar" Then 'el pulsado de B4 influye sobre la propiedad UseSystemPasswordChar de TB3. A la vez, cambia el texto de B4 para adecuarlo a la función que tenga en cada momento.
            TB3.UseSystemPasswordChar = True
            B4.Text = "Ocultar"
        ElseIf B4.Text = "Ocultar" Then
            TB3.UseSystemPasswordChar = False
            B4.Text = "Mostrar"
        End If
    End Sub
    Private Sub TB3_TextChanged(sender As Object, e As EventArgs) Handles TB3.TextChanged
        If TB3.Text <> TB2.Text Then 'si las contraseñas introducidas no coinciden, aparece la etiqueta L4.
            L4.Visible = True
        ElseIf TB3.Text = TB2.Text Then 'si las contraseñas introducidas coinciden, se oculta la etiqueta L4.
            L4.Visible = False
        End If
    End Sub
    Private Sub B2_Click(sender As Object, e As EventArgs) Handles B2.Click
        Me.Close() 'B2 cierra el formulario Registrar y muestra Iniciarsesion
        Iniciarsesion.Show()
    End Sub
End Class