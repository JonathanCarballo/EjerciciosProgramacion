Option Strict On
Module CarballoJonathanEjercicio3
    Sub Main()
        Dim num As Integer
        Console.WriteLine("Escriba el número")
        num = Convert.ToInt32(Console.ReadLine)
        If num Mod 2 = 0 Then
            Console.WriteLine("El número es multiplo de 2")
        ElseIf num Mod 3 = 0 Then
            Console.WriteLine("El número es multiplo de 3")
        ElseIf num Mod 5 = 0 Then
            Console.WriteLine("El número es multiplo de 5")
        Else
            Console.WriteLine("El número no es multiplo de 2 de 3 o de 5")
        End If
        Console.ReadLine()
    End Sub
End Module
