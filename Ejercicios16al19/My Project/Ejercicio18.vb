Option Strict On
Module Ejercicio18
    Sub Main()
        Dim num, a As Integer
        Console.WriteLine("Introduzca el numero")
        num = Convert.ToInt32(Console.ReadLine)
        While num < 0
            Console.WriteLine("Introduze un numero positivo")
            Console.WriteLine("Introduzca el numero")
            num = Convert.ToInt32(Console.ReadLine)
        End While
        For i = 1 To num
            If num Mod i = 0 Then
                a = a + 1
            End If
        Next
        If a <> 2 Then
            Console.WriteLine("No es primo")
        Else
            Console.WriteLine("Es primo")
        End If
        Console.ReadLine()
    End Sub
End Module
