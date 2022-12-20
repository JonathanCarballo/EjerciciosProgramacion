Option Strict On
Module Ejercicio6
    Sub Main()
        Dim nums() As Double = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50}
        nums(49) = -1
        For i = 0 To nums.Length - 1
            Console.Write(nums(i) & " ")
        Next
        Console.ReadLine()
    End Sub
End Module
