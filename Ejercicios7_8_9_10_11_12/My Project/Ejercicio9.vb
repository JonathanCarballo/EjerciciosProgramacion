Option Strict On
Module Ejercicio9
    Sub Main()
        Dim num1, num2, potencia As Single
        Console.WriteLine("Valor número 1")
        num1 = Convert.ToSingle(Console.ReadLine)
        Console.WriteLine("Valor número 2")
        num2 = Convert.ToSingle(Console.ReadLine)
        If num1 > num2 Then
            potencia = Convert.ToSingle(Math.Pow(num1, num2))
            Console.WriteLine("La pontencia sera de " & potencia)
        Else
            potencia = Convert.ToSingle(Math.Pow(num2, num1))
            Console.WriteLine("La pontencia sera de " & potencia)
        End If
        Console.ReadLine()
    End Sub
End Module
