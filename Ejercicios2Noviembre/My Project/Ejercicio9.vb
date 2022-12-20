Option Strict On
Module Ejercicio9
    Sub Main()

        For n = 16 To 1 Step -2.5
            Dim raiz As Double
            raiz = Math.Round(Math.Sqrt(n), 5)
            Console.WriteLine("Numero: " & n & " raiz: " & raiz)
        Next
        Console.ReadLine()
    End Sub
End Module
