Option Strict On
Module Ejercicio14
    Sub Main()
        Dim num As Double
        Console.WriteLine("Escriba un número")
        num = Convert.ToDouble(Console.ReadLine)
        If num >= 1 And num < 10 Then
            Console.WriteLine("El número tiene una cifras")
        ElseIf num >= 10 And num < 100 Then
            Console.WriteLine("El número tiene dos cifras")
        ElseIf num >= 100 And num < 1000 Then
            Console.WriteLine("El número tiene tres cifras")
        ElseIf num >= 1000 And num < 10000 Then
            Console.WriteLine("El número tiene cuatro cifras")
        ElseIf num >= 10000 And num < 100000 Then
            Console.WriteLine("El número tiene cinco cifras")
        ElseIf num >= 100000 And num < 1000000 Then
            Console.WriteLine("El número tiene seis cifras")
        End If
        Console.ReadLine()
    End Sub
End Module
