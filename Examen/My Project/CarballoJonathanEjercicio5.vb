Option Strict On
Module CarballoJonathanEjercicio5
    Sub Main()
        Const IMPUESTOREVAL As Single = 3.4
        Dim Antiguedad, CI, precioVenta As Double
        Dim precioCatastral, precioInicial, importe As Single
        Antiguedad = 8
        precioInicial = 200000
        precioCatastral = 60000
        importe = precioInicial
        CI = importe * 0.03
        precioVenta = Math.Round(importe + CI + (IMPUESTOREVAL * Antiguedad / 100) * precioCatastral)
        Console.WriteLine("El precio final sera de " & precioVenta)
        Console.ReadLine()

    End Sub
End Module
