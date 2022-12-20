Option Strict On
Module Ejercicio8
    Sub Main()
        Dim numsrandom(99) As Integer
        Dim random As New Random

        For i = 0 To numsrandom.Length - 1
            Dim valores As Integer = random.Next(0, 10)
            numsrandom(i) = valores
            Console.Write(numsrandom(i) & " ")
        Next
        Console.ReadLine
    End Sub
End Module
