Option Strict On
Module Ejercicio2
    Sub Main()
        Dim valor, valorfinal, impuesto As Integer
        Console.WriteLine("Introduzca el valor")
        valor = Convert.ToInt32(Console.ReadLine)
        If valor >= 0 And valor <= 1999 Then
            impuesto = 0
            Console.WriteLine("No debe pagar impuestos")
        ElseIf valor >= 2000 And valor <= 2999 Then
            impuesto = Convert.ToInt32(valor * 0.1)
            valorfinal = impuesto + valor
        End If
    End Sub
End Module
