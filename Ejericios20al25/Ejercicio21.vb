Option Strict On
Module Ejercicio21
    Sub Main()
        Dim inicio As Integer = 1
        Dim resultado As Integer
        While inicio < 11
            For i = 1 To 10
                resultado = inicio * i
                Console.WriteLine(resultado)
            Next
            inicio = inicio + 1
            Console.WriteLine("-----------------------------------------")
        End While
        Console.ReadLine()
    End Sub
End Module
