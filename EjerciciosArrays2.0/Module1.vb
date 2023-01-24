Option Strict On
Module Module1

    Sub Main()
        Dim ejercicio As Integer
        Do
            Console.WriteLine("Selecciona un ejercicio del 1 al 15 (16=Salir) ")
            ejercicio = Convert.ToInt32(Console.ReadLine)
            Select Case ejercicio

                Case 1
                    Dim matriz(2, 2) As Integer
                    matriz(0, 0) = 78
                    matriz(0, 1) = 5
                    matriz(0, 2) = 12

                    matriz(1, 0) = 76
                    matriz(1, 1) = 34
                    matriz(1, 2) = 1

                    matriz(2, 0) = 6
                    matriz(2, 1) = 92
                    matriz(2, 2) = 4

                    Dim fila As Integer
                    Console.WriteLine("Escoja una fila para ver sus valores")
                    fila = Convert.ToInt32(Console.ReadLine)
                    fila = fila - 1

                    Dim columna As Integer
                    For columna = 0 To 2
                        Console.WriteLine(matriz(fila, columna))
                    Next

                    matriz(0, 2) = 0
                    matriz(1, 2) = 0
                    matriz(2, 2) = 0

                    Dim suma As Integer
                    suma = 0
                    For columna = 0 To 2
                        suma = suma + matriz(0, columna)
                    Next
                    Console.WriteLine()
                    Console.WriteLine("La suma de los valores de la primera fila sera " & suma)

                    Dim contador As Integer
                    contador = 0
                    For fila = 0 To 2
                        If matriz(fila, 1) = 0 Then
                            contador = contador + 1
                        End If
                    Next
                    Console.WriteLine("Hay " & contador & " ceros en la segunda columna ")
                    Console.ReadLine()

                Case 2
                    Dim matriz(2, 2) As Integer

                    Dim random As New Random()
                    For i As Integer = 0 To 2
                        For j As Integer = 0 To 2
                            matriz(i, j) = random.Next(1, 100)
                        Next
                    Next

                    For i As Integer = 0 To 2 Step 1
                        For j = 0 To 2 Step 1
                            Console.Write(matriz(i, j) & " ")
                        Next
                        Console.WriteLine()
                    Next

                    Dim suma As Double = 0
                    For i As Integer = 0 To 2
                        For j As Integer = 0 To 2
                            suma += matriz(i, j)
                        Next
                    Next
                    Dim media As Double = suma / (3 * 3)

                    Console.WriteLine("La media de los elementos de la matriz es: " & media)
                    Console.ReadLine()

                Case 3
                    Dim rnd As New Random()
                    Dim temp As Double(,) = New Double(11, 29) {}

                    For m As Integer = 0 To 11
                        For d As Integer = 0 To 29
                            temp(m, d) = rnd.Next(-10, 50)
                        Next
                    Next

                    Dim tempMensual As Double() = New Double(11) {}
                    For m As Integer = 0 To 11
                        For d As Integer = 0 To 29
                            tempMensual(m) += temp(m, d)
                        Next
                        tempMensual(m) = tempMensual(m) / 30
                    Next

                    For m As Integer = 0 To 11
                        Console.WriteLine("La temperatura promedio del mes " & m + 1 & " es " & tempMensual(m))
                    Next

                Case 4
                    Dim matriz(2, 2) As Integer
                    Dim numCeros As Integer = 0
                    matriz(0, 0) = 23
                    matriz(0, 1) = 0
                    matriz(0, 2) = 0
                    matriz(1, 0) = 2
                    matriz(1, 1) = 45
                    matriz(1, 2) = 9
                    matriz(2, 0) = 13
                    matriz(2, 1) = 0
                    matriz(2, 2) = 777

                    For i As Integer = 0 To 2
                        For j As Integer = 0 To 2
                            If matriz(i, j) = 0 Then
                                numCeros += 1
                            End If
                        Next
                    Next

                    Dim porcentajeCeros As Double = numCeros / (3 * 3) * 100
                    Console.WriteLine("El porcentaje de ceros en la matriz es: " & porcentajeCeros & "%")

                Case 5
                    Dim matrizOriginal(2, 2) As Integer
                    matrizOriginal(0, 0) = 23
                    matrizOriginal(0, 1) = 0
                    matrizOriginal(0, 2) = 0
                    matrizOriginal(1, 0) = 2
                    matrizOriginal(1, 1) = 45
                    matrizOriginal(1, 2) = 9
                    matrizOriginal(2, 0) = 13
                    matrizOriginal(2, 1) = 0
                    matrizOriginal(2, 2) = 777

                    Dim matrizTraspuesta(2, 2) As Integer
                    For i As Integer = 0 To 2
                        For j As Integer = 0 To 2
                            matrizTraspuesta(j, i) = matrizOriginal(i, j)
                        Next
                    Next

                    Dim Simetrica As Boolean = True
                    For i As Integer = 0 To 2
                        For j As Integer = 0 To 2
                            If matrizOriginal(i, j) <> matrizOriginal(j, i) Then
                                Simetrica = False
                                Exit For
                            End If
                        Next
                        If Not Simetrica Then Exit For
                    Next

                    If Simetrica Then
                        Console.WriteLine("La matriz original es simétrica")
                    Else
                        Console.WriteLine("La matriz original no es simétrica")
                    End If

                Case 6
                    Dim matriz(2, 2) As Integer
                    matriz(0, 0) = 23
                    matriz(0, 1) = 0
                    matriz(0, 2) = 7
                    matriz(1, 0) = 2
                    matriz(1, 1) = 45
                    matriz(1, 2) = 9
                    matriz(2, 0) = 13
                    matriz(2, 1) = 0
                    matriz(2, 2) = 777

                    Dim suma As Integer = 0
                    For j As Integer = 0 To 2
                        suma += matriz(0, j)
                    Next
                    Console.WriteLine("La suma de los elementos de la primera fila es: " & suma)

                Case 7
                    Dim matriz(2, 2) As Integer
                    matriz(0, 0) = 23
                    matriz(0, 1) = 0
                    matriz(0, 2) = 7
                    matriz(1, 0) = 2
                    matriz(1, 1) = 45
                    matriz(1, 2) = 9
                    matriz(2, 0) = 13
                    matriz(2, 1) = 0
                    matriz(2, 2) = 777

                    Dim suma As Integer = 0
                    For i As Integer = 0 To 2
                        suma += matriz(i, 2)
                    Next
                    Console.WriteLine("La suma de los elementos de la ultima columna es: " & suma)

                Case 8

            End Select
        Loop While ejercicio <> 16
    End Sub

End Module
