Public Class Estadisticas 'calculo de estadisticas
    Private Sub B1_Click(sender As Object, e As EventArgs) Handles B1.Click
        Me.Close()
        Partida.Show()
    End Sub
    Public a1, b2, c1, d1, e1, f1, g1, h1, i1, j1, k1, l2, m1, n1, o1, p1, q1, r1, s1, t1, u1, v1, w1, x1, y1, z1 As Integer
    Private Function comparacion(x As Integer) As Boolean
        Dim salida As Boolean = 0
        If x >= a1 And x >= b2 And x >= c1 And x >= d1 And x >= e1 And x >= f1 And x >= g1 And x >= h1 And x >= i1 And x >= j1 And x >= k1 And x >= l2 And x >= m1 And x >= n1 And x >= o1 And x >= o1 And x >= p1 And x >= q1 And x >= r1 And x >= s1 And x >= t1 And x >= x1 And x >= y1 And x >= z1 Then
            salida = 1
        End If
        Return salida
    End Function
    Private Sub Estadisticas_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim sql As String = "select count(*) from Tabla4 where usuario='" & TB1.Text & "' and Wins = 1;"
        Dim W As Integer = ejecucion(sql, "Expr1000")
        sql = "select count(*) from Tabla4 where usuario = '" & Iniciarsesion.TB1.Text & "' and Loses = 1;"
        Dim L As Integer = ejecucion(sql, "Expr1000")
        TB1.Text = (CInt(W) / (CInt(W) + CInt(L))) * 100
        TB2.Text = W
        TB3.Text = L
        sql = "select MIN(Tiempo) from Tabla4 where usuario='" & Partida.TB1.Text & "' AND Wins = 1;"
        TB5.Text = ejecucion(sql, "Expr1000") * 100 & " ms"
        sql = "select sum(NFallos) from Tabla4 where usuario = '" & Iniciarsesion.TB1.Text & "';"
        Dim nfallos As Integer = CInt(ejecucion(sql, "Expr1000"))
        sql = "select count(*) from Tabla4 where usuario = '" & Iniciarsesion.TB1.Text & "';"
        Dim N As Integer = CInt(ejecucion(sql, "Expr1000"))
        TB6.Text = N
        TB7.Text = CInt(nfallos) / N
        sql = "select sum(Tiempo) from Tabla4 where usuario = '" & Iniciarsesion.TB1.Text & "';"
        Dim t As Integer = ejecucion(sql, "Expr1000")
        TB4.Text = CInt(t) / N
        sql = "select sum(a) as Expr1000 from Tabla4 where usuario = '" & Iniciarsesion.TB1.Text & "';"
        a1 = CInt(ejecucion(sql, "Expr1000"))
        sql = "select sum(b) as Expr1000 from Tabla4 where usuario = '" & Iniciarsesion.TB1.Text & "';"
        b2 = CInt(ejecucion(sql, "Expr1000"))
        sql = "select sum(c) as Expr1000 from Tabla4 where usuario = '" & Iniciarsesion.TB1.Text & "';"
        c1 = CInt(ejecucion(sql, "Expr1000"))
        sql = "select sum(d) as Expr1000 from Tabla4 where usuario = '" & Iniciarsesion.TB1.Text & "';"
        d1 = CInt(ejecucion(sql, "Expr1000"))
        sql = "select sum(e) as Expr1000 from Tabla4 where usuario = '" & Iniciarsesion.TB1.Text & "';"
        e1 = CInt(ejecucion(sql, "Expr1000"))
        sql = "select sum(f) as Expr1000 from Tabla4 where usuario = '" & Iniciarsesion.TB1.Text & "';"
        f1 = CInt(ejecucion(sql, "Expr1000"))
        sql = "select sum(g) as Expr1000 from Tabla4 where usuario = '" & Iniciarsesion.TB1.Text & "';"
        g1 = CInt(ejecucion(sql, "Expr1000"))
        sql = "select sum(h) as Expr1000 from Tabla4 where usuario = '" & Iniciarsesion.TB1.Text & "';"
        h1 = CInt(ejecucion(sql, "Expr1000"))
        sql = "select sum(i) as Expr1000 from Tabla4 where usuario = '" & Iniciarsesion.TB1.Text & "';"
        i1 = CInt(ejecucion(sql, "Expr1000"))
        sql = "select sum(j) as Expr1000 from Tabla4 where usuario = '" & Iniciarsesion.TB1.Text & "';"
        j1 = CInt(ejecucion(sql, "Expr1000"))
        sql = "select sum(k) as Expr1000 from Tabla4 where usuario = '" & Iniciarsesion.TB1.Text & "';"
        k1 = CInt(ejecucion(sql, "Expr1000"))
        sql = "select sum(l) as Expr1000 from Tabla4 where usuario = '" & Iniciarsesion.TB1.Text & "';"
        l2 = CInt(ejecucion(sql, "Expr1000"))
        sql = "select sum(m) as Expr1000 from Tabla4 where usuario = '" & Iniciarsesion.TB1.Text & "';"
        m1 = CInt(ejecucion(sql, "Expr1000"))
        sql = "select sum(n) as Expr1000 from Tabla4 where usuario = '" & Iniciarsesion.TB1.Text & "';"
        n1 = CInt(ejecucion(sql, "Expr1000"))
        sql = "select sum(o) as Expr1000 from Tabla4 where usuario = '" & Iniciarsesion.TB1.Text & "';"
        o1 = CInt(ejecucion(sql, "Expr1000"))
        sql = "select sum(p) as Expr1000 from Tabla4 where usuario = '" & Iniciarsesion.TB1.Text & "';"
        p1 = CInt(ejecucion(sql, "Expr1000"))
        sql = "select sum(q) as Expr1000 from Tabla4 where usuario = '" & Iniciarsesion.TB1.Text & "';"
        q1 = CInt(ejecucion(sql, "Expr1000"))
        sql = "select sum(r) as Expr1000 from Tabla4 where usuario = '" & Iniciarsesion.TB1.Text & "';"
        r1 = CInt(ejecucion(sql, "Expr1000"))
        sql = "select sum(s) as Expr1000 from Tabla4 where usuario = '" & Iniciarsesion.TB1.Text & "';"
        s1 = CInt(ejecucion(sql, "Expr1000"))
        sql = "select sum(t) as Expr1000 from Tabla4 where usuario = '" & Iniciarsesion.TB1.Text & "';"
        t1 = CInt(ejecucion(sql, "Expr1000"))
        sql = "select sum(u) as Expr1000 from Tabla4 where usuario = '" & Iniciarsesion.TB1.Text & "';"
        u1 = CInt(ejecucion(sql, "Expr1000"))
        sql = "select sum(v) as Expr1000 from Tabla4 where usuario = '" & Iniciarsesion.TB1.Text & "';"
        v1 = CInt(ejecucion(sql, "Expr1000"))
        sql = "select sum(w) as Expr1000 from Tabla4 where usuario = '" & Iniciarsesion.TB1.Text & "';"
        w1 = CInt(ejecucion(sql, "Expr1000"))
        sql = "select sum(x) as Expr1000 from Tabla4 where usuario = '" & Iniciarsesion.TB1.Text & "';"
        x1 = CInt(ejecucion(sql, "Expr1000"))
        sql = "select sum(y) as Expr1000 from Tabla4 where usuario = '" & Iniciarsesion.TB1.Text & "';"
        y1 = CInt(ejecucion(sql, "Expr1000"))
        sql = "select sum(z) as Expr1000 from Tabla4 where usuario = '" & Iniciarsesion.TB1.Text & "';"
        z1 = CInt(ejecucion(sql, "Expr1000"))
        If comparacion(a1) = True Then
            TB8.Text = "a"
        ElseIf comparacion(b2) = True Then
            TB8.Text = "b"
        ElseIf comparacion(c1) = True Then
            TB8.Text = "c"
        ElseIf comparacion(d1) = True Then
            TB8.Text = "d"
        ElseIf comparacion(e1) = True Then
            TB8.Text = "e"
        ElseIf comparacion(f1) = True Then
            TB8.Text = "f"
        ElseIf comparacion(g1) = True Then
            TB8.Text = "g"
        ElseIf comparacion(h1) = True Then
            TB8.Text = "h"
        ElseIf comparacion(i1) = True Then
            TB8.Text = "i"
        ElseIf comparacion(j1) = True Then
            TB8.Text = "j"
        ElseIf comparacion(k1) = True Then
            TB8.Text = "k"
        ElseIf comparacion(l2) = True Then
            TB8.Text = "l"
        ElseIf comparacion(m1) = True Then
            TB8.Text = "m"
        ElseIf comparacion(n1) = True Then
            TB8.Text = "n"
        ElseIf comparacion(o1) = True Then
            TB8.Text = "o"
        ElseIf comparacion(p1) = True Then
            TB8.Text = "p"
        ElseIf comparacion(q1) = True Then
            TB8.Text = "q"
        ElseIf comparacion(r1) = True Then
            TB8.Text = "r"
        ElseIf comparacion(s1) = True Then
            TB8.Text = "s"
        ElseIf comparacion(t1) = True Then
            TB8.Text = "t"
        ElseIf comparacion(u1) = True Then
            TB8.Text = "u"
        ElseIf comparacion(v1) = True Then
            TB8.Text = "v"
        ElseIf comparacion(w1) = True Then
            TB8.Text = "w"
        ElseIf comparacion(x1) = True Then
            TB8.Text = "x"
        ElseIf comparacion(y1) = True Then
            TB8.Text = "y"
        ElseIf comparacion(z1) = True Then
            TB8.Text = "z"
        End If
        L8.Text = "Mostrando información para el usuario " & Partida.TB1.Text
    End Sub
End Class