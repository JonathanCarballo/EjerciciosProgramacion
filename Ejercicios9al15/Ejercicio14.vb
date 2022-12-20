Option Strict On
Module Ejercicio14
    Sub Main()
        Dim num, suma As Integer
        Console.WriteLine("Introduzca un numero")
        num = Convert.ToInt32(Console.ReadLine)
        For i = num To 1 Step -1
            If i Mod 5 = 0 Then
                suma = suma + i
            End If
        Next
        Console.WriteLine(suma)
        Console.ReadLine()
    End Sub
End Module
