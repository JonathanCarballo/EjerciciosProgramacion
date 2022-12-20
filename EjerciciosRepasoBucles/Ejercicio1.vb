Option Strict On
Module Ejercicio1

    Sub Main()
        For i = 1 To 4
            For a = 1 To i
                Console.Write(a)
            Next
            Console.WriteLine(" ")
        Next
        For b = 3 To 1 Step -1
            For c = 1 To b
                Console.Write(c)
            Next
            Console.WriteLine(" ")
        Next
        Console.ReadLine()
    End Sub

End Module
