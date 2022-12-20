Option Strict On
Module Module1

    Sub Main()
        For i As Integer = 0 To 100
            If i Mod 5 = 0 And i Mod 7 = 0 Then
                Console.WriteLine(i & " es múltiplo de 5 y 7")
            End If
        Next
        Console.ReadLine()
    End Sub

End Module
