Option Strict On
Module Ejercicio4
    Sub Main()
        Dim libros() As String = {"Laisladeltesoro", "ManifiestoComunista", "RebelionEnLaGranja", "ElArteDeLaGuerra", "ElLibroTroll"}
        For i = 0 To libros.Length - 1
            Console.WriteLine(libros(i))
        Next
        Console.ReadLine()
    End Sub
End Module
