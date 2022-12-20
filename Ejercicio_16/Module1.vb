Option Strict On
Module Module1

    Sub Main()
        Dim a, b, c, y, x As Single
        Dim resultado, resultado2, resultado3, resultado4 As Single
        Console.WriteLine("Introduzca valor de a")
        a = Convert.ToSingle(Console.ReadLine)
        Console.WriteLine("Introduzca valor de b")
        b = Convert.ToSingle(Console.ReadLine)
        Console.WriteLine("Introduzca valor de c")
        c = Convert.ToSingle(Console.ReadLine)
        y = Math.Max(a, b)
        x = Math.Min(a, b)
        resultado = Convert.ToSingle(Math.Sqrt(Math.Max(c, y) ^ Math.Min(c, x)) + a ^ 5)
        resultado2 = Convert.ToSingle(Math.Floor(resultado))
        resultado3 = Convert.ToSingle(Math.Ceiling(resultado))
        resultado4 = Convert.ToSingle(Math.Round(resultado, 2))
        Console.WriteLine("El resultado de la primera operación es " & resultado)
        Console.WriteLine("El resultado de la segunda operación es " & resultado2)
        Console.WriteLine("El resultado de la tercera operación es " & resultado3)
        Console.WriteLine("El resultado de la cuarta operación es " & resultado4)
        Console.ReadLine()
    End Sub

End Module
