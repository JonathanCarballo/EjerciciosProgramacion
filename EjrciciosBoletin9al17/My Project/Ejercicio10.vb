Option Strict On
Module Ejercicio10
    Sub Main()
        Dim articulo1, articulo2, articulo3, suma As Double
        Console.WriteLine("Introduzca precio articulo 1")
        articulo1 = Convert.ToDouble(Console.ReadLine)
        Console.WriteLine("Introduzca precio articulo 2")
        articulo2 = Convert.ToDouble(Console.ReadLine)
        Console.WriteLine("Introduzca precio articulo 3")
        articulo3 = Convert.ToDouble(Console.ReadLine)
        suma = articulo1 + articulo2 + articulo3
        If suma <= 500 Then
            Console.WriteLine("El precio sera " & suma)
        ElseIf suma > 500 And suma <= 1000 Then
            suma = suma * 0.97
            Console.WriteLine("El precio sera de " & suma)
        ElseIf suma > 1000 And suma <= 2000 Then
            suma = suma * 0.95
            Console.WriteLine("El precio sera de " & suma)
        ElseIf suma >= 2000 And suma < 3000 Then
            suma = suma * 0.93
            Console.WriteLine("El precio sera de " & suma)
        ElseIf suma >= 3000 Then
            suma = suma * 0.9
            Console.WriteLine("El precio sera de " & suma)
        End If
        Console.ReadLine()
    End Sub
End Module
