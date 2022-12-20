Option Strict On
Module Ejercicio8
    Sub Main()
        Dim contraseña, contraseña1 As String
        Console.WriteLine("Introduzca la contraseña")
        contraseña = Console.ReadLine
        contraseña1 = "pedro"
        If contraseña = contraseña1 Then
            Console.WriteLine("Contraseña correcta")
        Else Console.WriteLine("contraseña incorrecta")
        End If
        Console.ReadLine()
    End Sub
End Module
