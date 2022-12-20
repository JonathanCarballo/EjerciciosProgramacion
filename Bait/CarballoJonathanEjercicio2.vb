Option Strict On
Module CarballoJonathanEjercicio2
    Sub Main()
        Dim i As Integer = 0
        While i <> 1

            Console.WriteLine("1) Calcula el factorial de un número introduccido")
            Console.WriteLine("2) Comprueba si el numero es perfecto")
            Console.WriteLine("3) Comprueba si el numero es primo")
            Console.WriteLine("4) Comprueba si ese numero es impar")

            Dim seleccion As Byte
            Dim numero, resultado As Integer
            Console.Write("Que ejercicio deseas hacer: ")
            seleccion = Convert.ToByte(Console.ReadLine())

            Select Case seleccion
                Case 1

                    Console.Write("Introduce el numero: ")
                    numero = Convert.ToInt32(Console.ReadLine())
                    For i = numero To 1 Step -1

                        Console.Write(i & " x ")

                    Next

                Case 2

                    Console.Write("Introduce el numero: ")
                    numero = Convert.ToInt32(Console.ReadLine())
                    For i = 1 To numero - 1
                        If numero Mod i = 0 Then
                            resultado += i
                        End If
                    Next
                    If resultado = numero Then
                        Console.WriteLine("Numero perfecto")
                    Else
                        Console.WriteLine("El nuemero no es perfecto")
                    End If

                Case 3

                    Console.Write("Introduce el numero: ")
                    numero = Convert.ToInt32(Console.ReadLine())

                    For i = 1 To numero
                        If numero Mod i = 0 Then
                            resultado += 1
                        End If
                        If resultado <> 2 Then
                            Console.WriteLine("El numero no es primo")
                        Else
                            Console.WriteLine("El numero es primo")
                        End If
                    Next

                Case 4

                    Console.Write("Introduce el numero: ")
                    numero = Convert.ToInt32(Console.ReadLine())

                    If numero Mod 2 = 0 Then
                        Console.Write("Numero par")
                    Else
                        Console.Write("Numero impar")
                    End If

            End Select
            Console.ReadLine()
            Console.Clear()
        End While


    End Sub

End Module
