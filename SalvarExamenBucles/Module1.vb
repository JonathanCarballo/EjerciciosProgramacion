Module Module1
    Sub Main()
        Dim numero, contador, j As Integer
        Console.Write("Introduzca el numero: ")
        numero = Convert.ToInt32(Console.ReadLine())
        For i = 1 To numero
            For j = 1 To i = -1
                If i Mod j Then
                    contador = contador + j
                End If
            Next
        Next
        Console.WriteLine(contador)
        Console.ReadLine()
    End Sub
End Module
