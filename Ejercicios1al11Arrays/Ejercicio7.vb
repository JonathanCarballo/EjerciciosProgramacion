Option Strict On
Module Ejercicio7
    Sub Main()
        Dim Variable As Integer
        Console.WriteLine("Introduzca el numero de capacidad")
        Variable = Convert.ToInt32(Console.ReadLine)
        Dim nums(Variable - 1) As Integer
        For i = 0 To nums.Length - 1
            Console.WriteLine("Introduzca un numero")
            nums(i) = Convert.ToInt32(Console.ReadLine)
        Next
        Console.WriteLine("Numeros sin modificar")
        For i = 0 To nums.Length - 1
            Console.Write(nums(i) & " ")
        Next
        Console.WriteLine(" ")
        Console.WriteLine("Modifica la primera posicion")
        nums(0) = Convert.ToInt32(Console.ReadLine)
        Console.WriteLine("Modifica la ultima posicion")
        nums(Variable - 1) = Convert.ToInt32(Console.ReadLine)
        Console.WriteLine("Numeros modificados")
        For i = 0 To nums.Length - 1
            Console.Write(nums(i) & " ")
        Next
        Console.ReadLine()
    End Sub
End Module
