Option Strict On
Module Ejercicio19
    Sub Main()
        Dim num, num2, multiplo As Integer
        Console.WriteLine("Introduzca el numero")
        num = Convert.ToInt32(Console.ReadLine)
        Console.WriteLine("Introduzca el numero 2")
        num2 = Convert.ToInt32(Console.ReadLine)
        For i = num To num2
            If i Mod 3 = 0 And i Mod 5 = 0 And i Mod 7 = 0 Then
                multiplo = multiplo + 1
            End If
        Next
        Console.WriteLine(multiplo & " es el primer numero entre " & num & " y " & num2 & "multiplo de 3,5 y 7")
        Console.ReadLine()
    End Sub
End Module
