Option Strict On
Module CarballoJonathanEjercicio3
    Sub Main()
        Dim n, m, divisor, contar As Integer
        Console.Write("Introduzca n: ")
        n = Convert.ToInt32(Console.ReadLine)
        Console.Write("Introduzca m: ")
        m = Convert.ToInt32(Console.ReadLine)

        For i = n To m
            divisor = 0
            For a = 1 To i
                If i Mod a = 0 Then
                    divisor += 1
                End If
            Next
            If divisor = 2 Then
                Console.Write(i & ", ")
                contar += 1
            End If
        Next
        Console.ReadLine()
    End Sub

End Module
