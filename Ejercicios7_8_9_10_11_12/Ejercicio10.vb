Option Strict On
Module Ejercicio10
    Sub Main()
        Dim presion, temperatura As Double
        Console.WriteLine("Introduzca temperatura actual")
        temperatura = Convert.ToDouble(Console.ReadLine)
        Console.WriteLine("Introduzca presion actual")
        presion = Convert.ToDouble(Console.ReadLine)
        If presion <= 2 And temperatura <= 500 Then
            Console.WriteLine("Todo en orden")
        End If
        If presion > 2 Then
            Console.WriteLine("Abrir valvula de seguridad")
        End If
        If temperatura > 500 Then
            Console.WriteLine("Reducir temperatura")
        End If
        Console.ReadLine()
    End Sub
End Module
