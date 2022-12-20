Option Strict On
Module CarballoJonathanEjercicio4

    Sub Main()
        Dim A, B As Integer
        Dim X, k As Double
        Dim y, z As Double
        Dim NumMenor As Double
        Console.WriteLine("Escriba valor de A ")
        A = Convert.ToInt32(Console.ReadLine)
        Console.WriteLine("Escriba valor de B ")
        B = Convert.ToInt32(Console.ReadLine)
        X = Math.Pow(A, 4) / Math.Pow(B, 3)
        Console.WriteLine("El resultado de x es " & X)
        y = Math.Sqrt(A + (Math.Pow(B, 2)))
        Console.WriteLine("El resultado de y es " & y)
        z = Math.Sqrt(3 - A)
        Console.WriteLine("El resultado de z es " & z)
        k = Math.Min(X, y)
        NumMenor = Math.Min(k, z)
        Console.WriteLine("El número mas pequeño sera " & NumMenor)
        Console.ReadLine()

    End Sub

End Module
