Option Strict On
Module Ejercicio9

    Sub Main()
        Dim litro, pago, pago2 As Double
        Console.WriteLine("Introduzca los litros gastados")
        litro = Convert.ToDouble(Console.ReadLine)
        If litro <= 50 Then
            Console.WriteLine("Debe pagar 150 euros")
        ElseIf litro >= 50 And litro < 200 Then
            pago = (litro - 50) * 10
            Console.WriteLine("El precio sera de " & pago)
        ElseIf litro > 200 Then
            pago2 = (litro - 200) * 20 + 150 * 10
            Console.WriteLine("El precio sera de " & pago2)
        End If
        Console.ReadLine()
    End Sub

End Module
