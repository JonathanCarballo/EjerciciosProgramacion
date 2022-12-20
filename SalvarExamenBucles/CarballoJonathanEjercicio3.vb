Module CarballoJonathanEjercicio3
    Sub Main()
        Dim numero, contador As Integer
        Console.Write("Introduzca el numero: ")
        numero = Convert.ToInt32(Console.ReadLine())
        For i = 1 To numero
            For contador = 1 To i = -1
                If i Mod contador Then
                    contador = contador + contador
                End If
            Next
        Next
        Console.WriteLine(contador)
        Console.ReadLine()
    End Sub
End Module
