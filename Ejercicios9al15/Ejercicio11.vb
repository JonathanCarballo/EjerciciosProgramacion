Option Strict On
Module Ejercicio11
    Sub main()
        Dim num As Integer
        Dim c, suma As Double
        Console.WriteLine("Introduzca un numero")
        num = Convert.ToInt32(Console.ReadLine)
        For i = 1 To num
            c = 1 / (i ^ 3)
            suma += c
        Next
        Console.WriteLine(suma)
        Console.ReadLine()
    End Sub
End Module
