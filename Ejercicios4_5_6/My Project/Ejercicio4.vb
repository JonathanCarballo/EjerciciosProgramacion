Option Strict On
Module Ejercicio4
    Sub Main()
        Dim a, b, c, d, menor As Double
        Console.WriteLine("Número A")
        a = Convert.ToDouble(Console.ReadLine)
        Console.WriteLine("Número B")
        b = Convert.ToDouble(Console.ReadLine)
        Console.WriteLine("Número C")
        c = Convert.ToDouble(Console.ReadLine)
        Console.WriteLine("Número D")
        d = Convert.ToDouble(Console.ReadLine)
        If a > b Then
            menor = b
        Else
            menor = a
        End If
        If menor > c Then
            menor = c
        End If
        If menor > d Then
            menor = d
        End If
        Console.WriteLine("El número menor es " & menor)
        Console.ReadLine()
    End Sub
End Module
