Module Conexion
    Public con As New System.Data.OleDb.OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source = C:\Users\Sandro\Desktop\Archivos Clase\Radiocomunicaciones\Practicas\Practicas Visual Basic\VB141516\BDD.accdb; Persist Security Info=False;") 'se añade la direccion del archivo de la base de datos con la que se va a trabajar
    Public Sub Connect() 'la aplicacion se conecta a la base de datos a traves de Connect()
        If con.State = ConnectionState.Closed Then con.Open()
    End Sub
    Public Function consulta(ByVal sql As String) As Integer 'funcion consulta. Se utiliza para consultar la base de datos en busca de valores que coinciden con los itnroducidos durante la ejecución del programa, sin llegar a extraer información de ésta (sólo compara a través de una consulta SQL))
        Connect()
        Dim cmd As New OleDb.OleDbCommand(sql, con)
        Dim a As Object = cmd.ExecuteScalar()
        con.Close()
        Return a 'devolverá un valor Integer, que será el Id resultante de la consulta SQL. Cuando este Id es 0, la consulta SQL no habrá encontrado ningún valor.
    End Function
    Public Function ejecucion(ByVal sql As String, b As String) As Integer 'funcion ejecucion. Ejecuta una consulta SQL introducida y devuelve un Integer.
        Connect()
        Dim q As String = Nothing
        Dim cmd As New OleDb.OleDbCommand(sql, con)
        Dim a As OleDb.OleDbDataReader = cmd.ExecuteReader()
        While a.Read
            q = a(b).ToString
        End While
        q = CInt(q)
        Return q 'se usa para extraer números enteros de la base de datos.
    End Function
    Public Function lectura(ByVal sql As String, b As String) As String 'funcion lectura. Ejecuta una consulta SQL introducida y devuelve un String
        Connect()
        Dim q As String = Nothing
        Dim cmd As New OleDb.OleDbCommand(sql, con)
        Dim a As OleDb.OleDbDataReader = cmd.ExecuteReader()
        While a.Read
            q = a(b).ToString
        End While
        Return q 'se usa para extraer información de tipo String de la base de datos
    End Function
    Public Function añadir(ByVal sql As String) As Boolean 'funcion añadir. Se usa para escribir en la base de datos. Ejecuta una consulta SQL introducida.
        Connect()
        Dim cmd As New OleDb.OleDbCommand(sql, con)
        Return cmd.ExecuteNonQuery() > 0 'creo que la comparación sirve para comprobar que la consulta SQL se ha realizado correctamente. Si la comparación resulta ser cierta, se habrá realizado correctamente al haber afectado a una fila.
    End Function
    Public Function registro(W As Integer, L As Integer) 'función registro. Utiliza las demás funciones para escribir en la Tabla4 de la base de datos, dónde se almacena la información de todos los usuarios
        Dim ID As Integer
        Dim sql As String = "insert into Tabla4 (usuario, NFallos, Tiempo, Wins, Loses) VALUES ('" & Iniciarsesion.TB1.Text & "','" & Partida.contador & "','" & Partida.tiempo * 10 & "','" & W & "','" & L & "')"
        Dim r As Boolean = 0
        r = añadir(sql)
        r = 0 'quizá sobre pero no quiero quitarlo.
        sql = "select Id from Tabla4 where (Tabla4.Id)" 'el resultado de la consulta es el mayor valor de Id de la tabla4, que corresponde a la última fila (la más nueva)
        ID = ejecucion(sql, "Id")
        For i As Integer = 0 To Partida.LB1.Items.Count - 1 'para escribir los datos de los campos a-z. Se utiliza un bucle for en el que se escribe un 1 en todos los campos correspondientes a las letras introducidas durante la partida.
            Dim campo As Char = Partida.LB1.Items.Item(i)
            sql = "update Tabla4 set " & campo & " =" & 1 & " where Id = " & ID & ""
            r = añadir(sql)
        Next
        Partida.LB1.Items.Clear() 'la listbox que almacena las letras introducidas durante la partida se limpia.
        Return Nothing
    End Function
End Module