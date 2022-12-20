Option Strict On
Module Ejercicio16

    Sub Main()
        Dim num, multiplos As Integer
        Console.WriteLine("Introduzca un numero")
        num = Convert.ToInt32(Console.ReadLine)
        For num = num To 1 Step -1
            If num Mod 3 = 0 Then
                multiplos += 1
            End If
        Next
        Console.WriteLine("Hay " & multiplos & " multiplos")
        Console.ReadLine()
    End Sub

End Module
