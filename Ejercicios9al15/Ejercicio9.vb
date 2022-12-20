Option Strict On
Module Ejercicio9

    Sub Main()
        Dim raiz As Double
        For i = 16 To 1 Step -2.5
            raiz = Math.Round(Math.Sqrt(i), 5)
            Console.WriteLine("Numero: " & i & " Raiz " & raiz)
        Next
        Console.ReadLine()
    End Sub

End Module
