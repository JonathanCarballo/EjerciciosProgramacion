Option Strict On
Module Module1

    Sub Main()
        For i = 1 To 5
            For a = 1 To i
                Console.Write("*")
            Next
            Console.WriteLine(" ")
        Next
        Console.ReadLine()
    End Sub
End Module
