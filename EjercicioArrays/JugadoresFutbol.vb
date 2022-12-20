Option Strict On
Module JugadoresFutbol
    Sub Main()
        Dim CantidadJugadores As Integer
        Console.WriteLine("Introduzca la cantidad de jugadores")
        CantidadJugadores = Convert.ToInt32(Console.ReadLine)
        Dim nombres(CantidadJugadores - 1), nacionalidades(CantidadJugadores - 1) As String
        Dim goles(CantidadJugadores - 1), asistencias(CantidadJugadores - 1) As Integer

        For i = 0 To CantidadJugadores - 1
            Console.WriteLine("Nombre del jugador: ")
            nombres(i) = Console.ReadLine
            Console.WriteLine("Nacionalidad del jugador: ")
            nacionalidades(i) = Console.ReadLine
            Console.WriteLine("Goles del jugador: ")
            goles(i) = Convert.ToInt32(Console.ReadLine)
            Console.WriteLine("Asistencias del jugador: ")
            asistencias(i) = Convert.ToInt32(Console.ReadLine)
        Next

        For i = 0 To CantidadJugadores - 1
            Console.WriteLine(nombres(i) & " " & nacionalidades(i) & " " & goles(i) & " " & asistencias(i))
        Next
        Console.ReadLine()
    End Sub
End Module
