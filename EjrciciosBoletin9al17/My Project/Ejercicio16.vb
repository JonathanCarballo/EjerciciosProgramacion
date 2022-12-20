Option Strict On
Module Ejercicio16
    Sub Main()
        Dim año As Integer
        Console.WriteLine("Escriba el año")
        año = Convert.ToInt32(Console.ReadLine)
        If año Mod 4 = 0 And año Mod 100 <> 0 Then
            Console.WriteLine("Año bisiesto")
        Else
            Console.WriteLine("No es un año bisiesto")
        End If
        Console.ReadLine()
    End Sub
End Module
