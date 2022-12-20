Option Strict On
Module Ejercicio15
    Sub Main()
        Dim num, resultado As Integer
        resultado = 1
        Console.WriteLine("Introduzca el numero")
        num = Convert.ToInt32(Console.ReadLine)
        For i = num To 1 Step -1
            resultado = resultado * i
        Next
        Console.WriteLine(resultado)
        Console.ReadLine()
    End Sub
End Module
