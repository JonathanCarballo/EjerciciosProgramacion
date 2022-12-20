Option Strict On
Module Ejercicio17
    Sub Main()
        Dim num, divisores As Integer
        Console.WriteLine("Introduzca numero")
        num = Convert.ToInt32(Console.ReadLine)
        For i = 1 To num
            If num Mod i = 0 Then
                divisores += 1
            End If
        Next
        Console.WriteLine("El numero tiene " & divisores & " divisores")
        Console.ReadLine()
    End Sub
End Module
