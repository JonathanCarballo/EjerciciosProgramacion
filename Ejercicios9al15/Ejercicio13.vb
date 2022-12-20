Option Strict On
Module Ejercicio13
    Sub Main()
        Dim num, suma As Integer
        Console.WriteLine("Introduzca el numero")
        num = Convert.ToInt32(Console.ReadLine)
        For i = 1 To num
            If num Mod i = 0 Then
                suma = suma + i
            End If
        Next
        If suma - num = num Then
            Console.WriteLine("Numero perfecto")
        Else
            Console.WriteLine("Numero no es perfecto")
        End If
        Console.ReadLine()
    End Sub
End Module
