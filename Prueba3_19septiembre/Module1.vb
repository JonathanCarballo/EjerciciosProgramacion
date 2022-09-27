Module Module1
    'Programa que calcula el precio final de una vivivienda
    'Inmobiliaria 3% del precio inicial
    'Ayuntamiento 9% del inicial
    Sub Main()
        Dim Impuesto1, Impuesto2 As Double
        Dim PrecioInicial, PrecioFinal As Double
        PrecioInicial = 120000
        Impuesto1 = PrecioInicial * 0.03
        Impuesto2 = PrecioInicial * 0.09
        PrecioFinal = PrecioInicial + Impuesto1 + Impuesto2
        Console.WriteLine("El precio inicial es de " & PrecioInicial)
        Console.WriteLine("El impuesto de inmobiliaria es de " & Impuesto1)
        Console.WriteLine("El impuesto de transferencia es de " & Impuesto2)
        Console.Write("El precio final sera " & PrecioFinal)
        Console.ReadLine()
    End Sub
End Module
