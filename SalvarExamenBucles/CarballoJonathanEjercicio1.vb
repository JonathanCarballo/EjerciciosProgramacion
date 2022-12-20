Option Strict On
Module CarballoJonathanEjercicio1
    Sub Main()
        Dim num, divisores, cuenta As Integer
        Dim media As Double
        Console.WriteLine("Introduzca numero")
        num = Convert.ToInt32(Console.ReadLine)
        cuenta = 0
        For i = 1 To num
            If num Mod i = 0 Then
                divisores += 1
                cuenta = cuenta + i
            End If
            media = cuenta / divisores
        Next
        Console.WriteLine(" La media de " & num & " entre " & divisores & " sera " & media)
        Console.ReadLine()
    End Sub
End Module
