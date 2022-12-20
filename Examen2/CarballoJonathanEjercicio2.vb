Option Strict On
Module CarballoJonathanEjercicio2

    Sub Main()
        Dim salarioneto, salariobruto, horasextra1, horasextra2, horasextra3, horastrabajadas, pagohoras, impuesto As Double
        horastrabajadas = 40
        pagohoras = 10
        salariobruto = horastrabajadas * pagohoras
        horasextra3 = (15 * pagohoras) * 1.5
        If horastrabajadas <= 25 And salariobruto < 1000 Then
            impuesto = Convert.ToInt32(salariobruto * 0.1)
            salarioneto = salariobruto - impuesto
            Console.WriteLine("El salario sera de " & salarioneto)
        ElseIf horastrabajadas > 25 And horastrabajadas <= 35 And salariobruto < 1500 Then
            impuesto = salariobruto * 0.15
            horasextra2 = pagohoras * 1.5
            horasextra1 = (horastrabajadas - 25) * pagohoras
            salarioneto = (salariobruto + horasextra1) - impuesto
            Console.WriteLine("El salario sera de " & salarioneto)
        ElseIf horastrabajadas > 35 And salariobruto < 1800 Then
            impuesto = salariobruto * 0.25
            horasextra2 = pagohoras * 1.75
            horasextra1 = (horastrabajadas - 35) * pagohoras
            salarioneto = (salariobruto + horasextra1 + horasextra3) - impuesto
            Console.WriteLine("El salario sera de " & salarioneto)
        End If
        Console.ReadLine()
    End Sub

End Module
