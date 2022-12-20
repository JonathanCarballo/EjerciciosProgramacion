Module CarballoJonathanEjercicio4
    Sub Main()
        Dim factorial As Integer = 1
        For i As Integer = 1 To 10 Step 1
            factorial *= i
            Console.WriteLine(factorial)
        Next
        Console.ReadLine()
    End Sub
End Module
