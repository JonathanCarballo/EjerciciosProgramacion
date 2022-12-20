Option Strict On
Module Module1

    Sub Main()
        Dim num1, num2, num3, num4, num5, num6, num7, num8, num9, num10 As Integer
        Dim num1n, num2n, num3n, num4n, num5n, num6n, num7n, num8n, num9n, num10n As Integer
        Dim num1p, num2p, num3p, num4p, num5p, num6p, num7p, num8p, num9p, num10p As Integer
        Console.Write("Valor numero 1")
        num1 = Convert.ToInt32(Console.ReadLine)
        Console.Write("Valor numero 2")
        num2 = Convert.ToInt32(Console.ReadLine)
        Console.Write("Valor numero 3")
        num3 = Convert.ToInt32(Console.ReadLine)
        Console.Write("Valor numero 4")
        num4 = Convert.ToInt32(Console.ReadLine)
        Console.Write("Valor numero 5")
        num5 = Convert.ToInt32(Console.ReadLine)
        Console.Write("Valor numero 6")
        num6 = Convert.ToInt32(Console.ReadLine)
        Console.Write("Valor numero 7")
        num7 = Convert.ToInt32(Console.ReadLine)
        Console.Write("Valor numero 8")
        num8 = Convert.ToInt32(Console.ReadLine)
        Console.Write("Valor numero 9")
        num9 = Convert.ToInt32(Console.ReadLine)
        Console.Write("Valor numero 10")
        num10 = Convert.ToInt32(Console.ReadLine)
        If num1 < 0 Then
            num1n = num1
        Else
            num1p = num1
        End If
    End Sub

End Module
