Option Strict On
Module Ejercicio6
    Sub Main()
        Dim num1, num2, num3 As Double
        Dim media As Double
        Console.WriteLine("Escriba nota primer examen")
        num1 = Convert.ToDouble(Console.ReadLine)
        Console.WriteLine("Escriba nota segundo examen")
        num2 = Convert.ToDouble(Console.ReadLine)
        Console.WriteLine("Escriba nota tercer examen")
        num3 = Convert.ToDouble(Console.ReadLine)
        media = (num1 + num2 + num3) / 3
        If media >= 5 Then
            Console.WriteLine("Estas aprobado")
        Else
            Console.WriteLine("Estas suspenso")
        End If
        Console.ReadLine()
    End Sub
End Module
