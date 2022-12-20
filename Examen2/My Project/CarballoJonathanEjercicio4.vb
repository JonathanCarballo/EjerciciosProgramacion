Option Strict On
Module CarballoJonathanEjercicio4
    Sub Main()
        Dim opcion, opciones, num As Integer
        Console.WriteLine("Introduzca un número del 1 al 4")
        num = Convert.ToInt32(Console.ReadLine)
        Select Case opcion
            Case opciones
                If num = 1 Or num = 2 Then
                    Console.WriteLine("Introdujiste un 1 o un 2")
                ElseIf num = 3 Then
                    Console.WriteLine("Introdujiste un 3")
                ElseIf num = 4 Then
                    Console.WriteLine("Introdujiste un 4")
                ElseIf num >= 5 Then
                Console.WriteLine("Error en el número introducido")
                End If
        End Select
        Console.ReadLine()
    End Sub
End Module
