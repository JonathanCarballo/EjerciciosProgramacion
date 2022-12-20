Option Strict On
Module Ejercicio10
    Sub Main()
        Dim numero, suma As Integer
        Console.WriteLine("Introduzca un número")
        numero = Convert.ToInt32(Console.ReadLine)
        While (numero < 0)
            Console.Clear()
            Console.WriteLine("Numero negativo")
            Console.Write("Introduzca un numero")
            numero = Convert.ToInt32(Console.ReadLine)
        End While
        For i = numero To 1 Step -1
            suma = suma + 1
        Next
        Console.WriteLine(suma)
        Console.ReadLine()
    End Sub
End Module
