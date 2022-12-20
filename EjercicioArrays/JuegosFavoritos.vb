Option Strict On

Module JuegosFavoritos

    Sub Main()
        Dim nombres() As String = {"Anxo", "Sergio", "Martin", "Hugo", "Boris"}
        Dim edades() As Integer = {16, 17, 17, 16, 18}
        Dim juegosfav() As String = {"Rust", "Zelda: Ocarina of Time", "ARK", "Stray", "Dragon Ball"}
        For i = 0 To 4
            Console.WriteLine("Nombre: " & nombres(i) & " Edad: " & edades(i) & " Juego Favorito: " & juegosfav(i))
        Next
        Console.ReadLine()
    End Sub

End Module
