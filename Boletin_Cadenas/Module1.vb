Option Strict On
Module Module1

    Sub Main()
        Dim matriculas() As String = {"8777-KPG", "1314-CCP", "2932-KJG", "3740-PXR", "7384-RPK", "5005-SPF", "2739-LMA", "2542-KDP", "2013-YXZ", "9813-ETB", "1902-DMR"}

        For i = 0 To matriculas.Length - 1
            For Each matricula In matriculas
                If matricula.EndsWith("Z") Then
                    Console.WriteLine("Matriculas que acaban en Z: " & matricula)
                    Console.ReadLine()
                End If
            Next
        Next

    End Sub
End Module