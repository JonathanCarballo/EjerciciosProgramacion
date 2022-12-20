Option Strict On
Module Module1

    Sub Main()
        Dim precioInicial, precioFinal As Single
        Dim descuento As Byte
        Console.WriteLine("Introduzca el precio ")
        precioInicial = Convert.ToSingle(Console.ReadLine)
        Console.WriteLine("Introduzca el descuento ")
        descuento = Convert.ToByte(Console.ReadLine)
        precioFinal = precioInicial - (descuento * precioInicial) / 100
        Console.WriteLine("El precio final es de " & precioFinal)
        Console.ReadLine()
    End Sub

End Module
