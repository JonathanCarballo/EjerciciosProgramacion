Option Strict On
Module Ejercicio5

    Sub Main()
        Dim numero As Integer
        Console.WriteLine("Escriba el número")
        numero = Convert.ToInt32(Console.ReadLine)
        If numero Mod 2 = 0 Then
            Console.WriteLine("Su número es par")
        Else
            Console.WriteLine("Su número es inpar")
        End If
        Console.ReadLine()
    End Sub

End Module
