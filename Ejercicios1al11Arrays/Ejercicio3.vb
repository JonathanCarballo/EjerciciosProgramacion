Option Strict On
Module Ejercicio3
    Sub Main()
        Dim nums() As Integer = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10}
        nums(0) = -23
        nums(2) = -3
        nums(5) = -6
        nums(9) = -10
        For i = 0 To nums(8)
            Console.Write(nums(i) & " ")
        Next
        Console.ReadLine()
    End Sub
End Module
