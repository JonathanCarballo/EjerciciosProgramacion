Option Strict On
Module Module1

    Sub Main()
        Dim array() As Integer = {5, 7, 2, 4}
        Dim minimo As Integer = array(0)
        For i = 1 To array.Length - 1 Step 1
            If minimo > array(i) Then
                minimo = array(i)
            End If
        Next
        Console.WriteLine("El valor mas pequeño es " & minimo)
        Console.ReadLine()
    End Sub

End Module
