Option Strict On
Module Ejercicio15
    Sub Main()
        Dim coeficiente1, coeficiente2, coeficiente3, ecuacion, x1, x2 As Double
        Console.WriteLine("Introduzca el primer coeficiente(A)")
        coeficiente1 = Convert.ToDouble(Console.ReadLine)
        Console.WriteLine("Introduzca el primer coeficiente(B)")
        coeficiente2 = Convert.ToDouble(Console.ReadLine)
        Console.WriteLine("Introduzca el primer coeficiente(C)")
        coeficiente3 = Convert.ToDouble(Console.ReadLine)
        If coeficiente1 = 0 Then
            x1 = -(coeficiente3 / coeficiente2)
        End If
    End Sub
End Module
