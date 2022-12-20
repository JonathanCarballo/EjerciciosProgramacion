Option Strict On
Module Ejercicio5
    Sub Main()
        Dim nums(3) As Short
        For i = 0 To nums.Length - 1
            Console.WriteLine("Introduzca los numeros")
            nums(i) = Convert.ToInt16(Console.ReadLine)
        Next
        For i = 0 To nums.Length - 1
            Console.Write(nums(i) & " ")
        Next
        Console.ReadLine()
    End Sub
End Module
