Option Strict On
Module CarballoMenezesJonathanExamenMatrices

    Sub Main()
        Dim ejercicio As Integer
        Do
            Console.WriteLine("Selecciona un ejercicio del 1 al 6 (7=Salir) ")
            ejercicio = Convert.ToInt32(Console.ReadLine)
            Select Case ejercicio

                Case 1
                    Dim matrizPares As Integer() = {1, 77, 37, 4, 59, 6, 18, 8, 91, 10, 44, 12, 13, 164, 15}
                    Dim suma As Integer = 0

                    For i = 0 To matrizPares.Length - 1
                        suma += matrizPares(i)
                    Next
                    Dim media As Double = suma / 15
                    Console.WriteLine("Media de la matriz " & media)
                    'Contar números pares mayores que la media
                    Dim paresMayores As Integer = 0
                    For i = 0 To matrizPares.Length - 1
                        If matrizPares(i) > media And matrizPares(i) Mod 2 = 0 Then
                            paresMayores += 1
                        End If
                    Next
                    Console.WriteLine("Números pares mayores que la media " & paresMayores)

                    'Calculamos el porcentaje
                    Dim porcentaje As Double = (paresMayores / 15) * 100
                    Console.WriteLine("Porcentaje de números pares mayores que la media: " & porcentaje & "%")
                    Console.ReadLine()

                Case 2
                    Dim array As Integer() = {1, 213, 35, 42, 49, 56, 63, 70, 14, 8, 19, 77, 92, 13}
                    Dim posicion As Integer = -1

                    For i As Integer = 0 To array.Length - 1
                        'Vemos si el elemento es múltiplo de 7
                        If array(i) Mod 7 = 0 Then
                            posicion = i
                            Exit For
                        End If
                    Next

                    'Comprobamos si se ha encontrado el número
                    If posicion <> -1 Then
                        Console.WriteLine("El primer número múltiplo de 7 se encuentra en la posición " & posicion)
                    Else
                        Console.WriteLine("No se ha encontrado ningún número múltiplo de 7 en el array")
                    End If

                    Console.ReadLine()

                Case 3
                    Dim array As Integer() = {81, 27, 33, 14, 35, 76, 27, 558, 99, 1253, 5, 667, 23, 48, 323, 666, 34, 56, 78, 90}
                    Dim max As Integer = array(0)

                    'Recorrer la primera mitad del array
                    For i As Integer = 0 To (array.Length / 2) - 1
                        'Verificar si el elemento es mayor que el valor máximo actual
                        If array(i) > max Then
                            max = array(i)
                        End If
                    Next

                    Console.WriteLine("Valor máximo en la primera mitad del array: " & max)
                    Console.ReadLine()

                Case 4
                    Dim arraySuma As Integer() = {15, 12, 44, 567, 1, 2, 97, 65, 777, 999, 666, 23365, 23, 44, 99}

                    Console.WriteLine("Matriz sin cambiar")
                    For i = 0 To arraySuma.Length - 1
                        Console.Write(arraySuma(i) & " ")
                    Next

                    'Sumamos 1 a todos los numeros pares
                    For i = 0 To arraySuma.Length - 1
                        If i Mod 2 = 0 Then
                            arraySuma(i) += 1
                        End If
                    Next

                    Console.WriteLine("")
                    Console.WriteLine("Matriz Cambiada")
                    For i = 0 To arraySuma.Length - 1
                        Console.Write(arraySuma(i) & " ")
                    Next
                    Console.ReadLine()

                Case 5
                    Dim random As New Random
                    Dim matrizCeros(4, 4) As Integer
                    Dim noceros As Integer = 0

                    'Llenamos la matriz de numeros aleatorios
                    For i As Integer = 0 To matrizCeros.GetUpperBound(0)
                        For j As Integer = 0 To matrizCeros.GetUpperBound(1)
                            matrizCeros(i, j) = random.Next(50, 100)
                        Next
                    Next

                    'Buscamos la fila que contenga un cero
                    For i As Integer = 0 To matrizCeros.GetUpperBound(0)
                        For j As Integer = 0 To matrizCeros.GetUpperBound(1)
                            If matrizCeros(i, j) = 0 Then
                                Console.WriteLine("La fila " & i & " contiene un cero.")
                            Else
                                noceros = +1
                                Exit For
                            End If
                        Next
                    Next

                    If noceros <> 0 Then
                        Console.WriteLine("No hay ceros en la matriz")
                    End If
                    Console.ReadLine()

                Case 6
                    Dim lamatrix(4, 4) As Integer
                    Dim random As New Random()
                    For i As Integer = 0 To lamatrix.GetUpperBound(0)
                        For j As Integer = 0 To lamatrix.GetUpperBound(1)
                            lamatrix(i, j) = random.Next(-50, 50)
                        Next
                    Next

                    For i As Integer = 0 To lamatrix.GetUpperBound(0)
                        For j As Integer = 0 To lamatrix.GetUpperBound(1)
                            Console.Write(lamatrix(i, j) & " ")
                        Next
                        Console.WriteLine()
                    Next

                    Dim negativo1 As Integer = -1
                    Dim negativo2 As Integer = -1

                    'Actualizamos la posicion si se cumplen las condiciones
                    For i As Integer = 0 To lamatrix.GetUpperBound(0)
                        For j As Integer = 0 To lamatrix.GetUpperBound(1)
                            If lamatrix(i, j) < 0 And negativo1 = -1 And negativo2 = -1 Then
                                negativo1 = i
                                negativo2 = j
                                Exit For
                            End If
                        Next
                    Next

                    If negativo1 <> -1 And negativo2 <> -1 Then
                        Console.WriteLine("El primer numero negativo se encuentra en la fila: " & negativo1 + 1 & " y en la columna: " & negativo2 + 1)
                    Else
                        Console.WriteLine("No hay ningun numero negativo en la matriz.")
                    End If
                    Console.ReadLine()
                    Exit Do
            End Select
        Loop While ejercicio <> 7
    End Sub

End Module
