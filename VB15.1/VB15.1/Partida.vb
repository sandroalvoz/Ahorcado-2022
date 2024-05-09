Public Class Partida
    Dim palabra, display As String
    Public tiempo As Double = 0
    Public contador As Integer
    Private Sub B5_Click(sender As Object, e As EventArgs) Handles B5.Click 'al pulsar B5...
        B1.Enabled = True '... B1 se deshabilita
        B5.Enabled = False '...se habilita B5
        contador = 0 'la variable contador se iguala a 0
        T1.Start() 'se activa T1. Comienza a contar el tiempo de partida.
        Dim sql As String = "select count(*) from Tabla3;" 'se cuenta el número de filas de la Tabla3. Donde se almacenan las palabras.
        Dim n = ejecucion(sql, "Expr1000")
        n = Rnd((n * Rnd()) + 1) 'se toma un valor aleatorio del total de filas de Tabla3
        sql = "select palabra from Tabla3 where Id = " & n & ";"
        palabra = lectura(sql, "palabra") 'Acceso a la base de datos, se toma un valor aleatorio de la Tabla3, que será la palabra a adivinar en la partida.
        display = Nothing
        For i As Integer = 0 To palabra.Length - 1 '"palabra" almacena la palabra, mientras que "display" se muestra. "Display" irá variando al introducir letras.
            display += "-" '"display" tendrá el mismo número de caracteres que palabra
        Next
        L5.Text = display '"display" se muestra a través de L5.
    End Sub
    Private Sub B1_Click(sender As Object, e As EventArgs) Handles B1.Click
        Dim letra As Char
        letra = CB1.Text '"letra" almacena la selección de CB1
        If CB1.Text = Nothing Then 'se comprueba que se haya seleccionado algo en CB1, de lo contrario, no sucede nada.
        ElseIf LB1.Items.Contains(letra) = True Then 'si la letra introducida ya está almacenada en LB1, es decir, ya ha sido introducida previamente, no se añade.
            MsgBox("La letra ya ha sido introducida", vbOKOnly) 'un MsgBox avisa de ésto al usuario
        ElseIf LB1.Items.Contains(letra) = False Then 'si la letra introducida no está almacenada en LB1, se compara con palabra caracter a caracter, transformando "display" de acuerdo a ello.
            Dim fallo As Boolean = 0
            letra = CB1.Text
            LB1.Items.Add(letra)
            For i As Integer = 0 To palabra.Length - 1
                If letra = palabra.Chars(i) Then
                    fallo = 1 'si la letra introducida se encuentra en alguno de los caracteres de palabra, "fallo" se iguala a 1
                    Dim display2 As String = Nothing
                    For a As Integer = 0 To i - 1
                        display2 += display.Chars(a)
                    Next
                    display2 += palabra.Chars(i)
                    For a As Integer = i + 1 To palabra.Length - 1
                        display2 += display.Chars(a)
                    Next
                    display = display2
                    L5.Text = display2
                End If
            Next
            If fallo = 0 Then 'si la letra introducida no se encuentra en ninguno de los caracteres de palabra, "fallo" seguirá siendo 0...
                contador += 1 '... y se sumará una unidad a "contador"
                L6.Text = "Número de fallos: " & contador.ToString 'se muestra el número de fallos a través de L6
            End If
        End If
    End Sub
    Private Sub T1_Tick(sender As Object, e As EventArgs) Handles T1.Tick
        tiempo += 1 'se cuenta el tiempo. Cada 100 ms de actividad de T1, "tiempo" aumenta en una unidad
        L4.Text = "Tiempo: " & tiempo.ToString 'esto se muestra a través de L4
    End Sub
    Private Sub B2_Click(sender As Object, e As EventArgs) Handles B2.Click
        Me.Close() 'al pulsar sobre B2, se cierra Partida y se muestra Iniciarsesion
        Iniciarsesion.Show()
    End Sub
    Private Sub B6_Click(sender As Object, e As EventArgs) Handles B6.Click
        T1.Stop() 'al pulsar B6, se detiene T1, y se registra una derrota.
        registro(0, 1)
    End Sub
    Private Sub B3_Click(sender As Object, e As EventArgs) Handles B3.Click
        Me.Hide() 'al pulsar B3, se oculta Partida y se muestra Agregarpalabra
        Agregarpalabra.Show()
    End Sub
    Private Sub B4_Click(sender As Object, e As EventArgs) Handles B4.Click
        Me.Hide() 'al pulsar B4, se oculta Partida y se muestra Estadisticas
        Estadisticas.Show()
    End Sub
    Private Sub B7_Click(sender As Object, e As EventArgs) Handles B7.Click
        If TB4.Text = palabra Then 'al hacer clic sobre B7, se compara el texto introducido en TB4 con la variable "palabra"
            T1.Stop() 'si la palabra introducida es correcta, se registra una victoria
            L5.Text = palabra
            MsgBox("Correcto. La palabra era " & palabra, vbOKOnly)
            registro(1, 0)
            B5.Enabled = True
            B1.Enabled = False
        ElseIf TB4.Text <> palabra Then
            contador += 1 'si la palabra introducida no es correcta, se suma una unidad a "contador"
        End If
    End Sub
    Private Sub actualizacioncontador() Handles B7.Click, B1.Click, B5.Click 'actualizacioncontador se ejecuta a cada posible actualización de "contador"
        L6.Text = "Número de fallos: " & contador.ToString
        If contador = 9 Then 'si "contador" alcanza un valor de 9, se registra una derrota
            T1.Stop()
            L5.Text = palabra
            MsgBox("Has perdido.", vbOKOnly)
            registro(0, 1)
            B5.Enabled = True
            B1.Enabled = False
        End If
        Select Case contador 'dependiendo del valor de contador, se actualiza PB1.
            Case 0
                PB1.BackgroundImage = My.Resources._0
            Case 1
                PB1.BackgroundImage = My.Resources._1
            Case 2
                PB1.BackgroundImage = My.Resources._2
            Case 3
                PB1.BackgroundImage = My.Resources._3
            Case 4
                PB1.BackgroundImage = My.Resources._4
            Case 5
                PB1.BackgroundImage = My.Resources._5
            Case 6
                PB1.BackgroundImage = My.Resources._6
            Case 7
                PB1.BackgroundImage = My.Resources._7
            Case 8
                PB1.BackgroundImage = My.Resources._8
            Case 9
                PB1.BackgroundImage = My.Resources._9
        End Select
    End Sub
    Private Sub Partida_Activated(sender As Object, e As EventArgs) Handles Me.Shown 'al abrirse el formulario, se actualiza la información mostrada en TB1, TB2 y TB3
        TB1.Text = Iniciarsesion.TB1.Text 'se muestra el usuario con el que se haya iniciado sesión en TB1
        Dim sql As String = "select MIN(Tiempo) FROM Tabla4 WHERE usuario='" & TB1.Text & "' AND Wins = 1;"
        TB2.Text = ejecucion(sql, "Expr1000") * 100 & " ms" 'se muestra el tiempo récord del usuario en TB2
        sql = "select count(*) from Tabla4 where usuario = '" & Iniciarsesion.TB1.Text & "' and Wins = 1;"
        Dim W As Integer = ejecucion(sql, "Expr1000")
        sql = "select count(*) from Tabla4 where usuario = '" & Iniciarsesion.TB1.Text & "' and Loses = 1;"
        Dim L As Integer = ejecucion(sql, "Expr1000")
        TB3.Text = (CInt(W) / (CInt(W) + CInt(L))) * 100 'se muestra el porcentaje de victorias del usuario en TB3
        'NOTA: El cálculo de estadísticas para un nuevo usuario genera errores, ya que se realiza en base a las partidas jugadas.
        'para evitar esto, se puede generar una fila para el usuario al crearse éste. Es un posible arreglo, pero afectaría a las estadísticas
    End Sub
End Class