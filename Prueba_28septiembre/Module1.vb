Option Strict On
Module Module1

    Sub Main()
        Dim X As Integer = 14
        Dim Y As Integer = 4

        Dim resto As Integer = X Mod Y
        Dim divisionReal As Double = X / Y
        Dim divisionEntera As Integer = X \ Y
        Console.WriteLine("Resto " & resto)
        Console.WriteLine("Division Real " & divisionReal)
        Console.WriteLine("Division Entera " & divisionEntera)
        Console.ReadLine()
    End Sub

End Module
