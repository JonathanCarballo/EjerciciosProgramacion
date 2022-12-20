Option Strict On
Module Ejercicio20

    Sub Main()
        Dim num1, num2, resultado As Integer
        Console.WriteLine("Introduzca el primer número")
        num1 = Convert.ToInt32(Console.ReadLine)
        Console.WriteLine("Introduzca el segundo número")
        num2 = Convert.ToInt32(Console.ReadLine)
        For i = 1 To num2
            resultado = num1 * i
            Console.WriteLine(num1 & " por " & i & " " & resultado)
        Next
        Console.ReadLine()
    End Sub

End Module
