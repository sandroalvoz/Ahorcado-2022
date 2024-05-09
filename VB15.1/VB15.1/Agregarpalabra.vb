Public Class Agregarpalabra
    Private Sub B1_Click(sender As Object, e As EventArgs) Handles B1.Click
        Me.Close() 'al pulsar B1, se cierra Agregarpalabra y se muestra Partida
        Partida.Show()
    End Sub
    Private Sub B2_Click(sender As Object, e As EventArgs) Handles B2.Click 'al pulsar B2, se añade la palabra introducida a Tabla3
        Dim sql As String = "Select Id FROM Tabla3 where palabra = '" & TB1.Text & "'" 'previamente se comprueba que la palabra no esté registrada.
        Dim r = consulta(sql)
        If r = 0 Then
            sql = "insert into Tabla3 (palabra) VALUES ('" & TB1.Text & "')"
            añadir(sql)
            MsgBox("La palabra se ha añadido correctamente.")
        Else
            MsgBox("La palabra que ha introducido ya se encuentra registrada.")
        End If
    End Sub
End Class