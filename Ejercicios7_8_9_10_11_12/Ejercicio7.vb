Option Strict On
Module Ejercicio7

    Sub Main()
        Dim num1, num2, suma, raiz As Double
        Console.WriteLine("Valor número 1")
        num1 = Convert.ToDouble(Console.ReadLine)
        Console.WriteLine("Valor número 2")
        num2 = Convert.ToDouble(Console.ReadLine)
        suma = num1 + num2
        If suma >= 0 Then
            raiz = Math.Sqrt(suma)
            Console.WriteLine("La raiz de la suma es " & raiz)
        Else Console.WriteLine("No se puede calcular la raiz")
        End If
        Console.ReadLine()
    End Sub

End Module
