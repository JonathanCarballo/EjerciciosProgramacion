Option Strict On
Module Ejercicio12
    Sub Main()
        Dim num, suma As Integer
        Console.WriteLine("Introduzca un numero")
        num = Convert.ToInt32(Console.ReadLine)
        For i = 1 To num
            If num Mod i = 0 Then
                suma = suma + i
            End If
        Next
        Console.WriteLine("La suma de los divisores es " & suma)
        Console.ReadLine()
    End Sub
End Module
