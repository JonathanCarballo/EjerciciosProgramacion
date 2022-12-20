Option Strict On
Module BoletinArrays

    Sub Main()

        Dim ejercicio As Integer
        Do
            Console.WriteLine("Selecciona un ejercicio del 1 al 10 (11=Salir) ")
            ejercicio = Convert.ToInt32(Console.ReadLine)
            Select Case ejercicio
                Case 1 'Jonathan Carballo Menezes Ejercicio 1 
                    'Crear un array con capacidad para n valores. Llenarlo con valores aleatorios entre 0 y 10. (1 pto)
                    'a.Calcular la media de los elementos del Array.
                    'b.Calcular el porcentaje de valores que están por encima de la media.
                    'c.Si la media es inferior a 5 muestra un mensaje informado de que la nota es suspenso.
                    'd.Si la media está entre 5 y 7 muestra un mensaje informado de que la nota es aprobado.
                    'e.Si la media está entre 7 y 9 muestra un mensaje informado de que la nota es notable.
                    'f.Si la media está entre 9 y 10 muestra un mensaje informado de que la nota es sobresaliente.
                    'En cualquier otro caso manda un mensaje de error.

                    Dim valorarray, suma As Integer
                    Dim random As New Random
                    Dim media, porcentaje As Double
                    Console.WriteLine("Introduzca el valor del array")
                    valorarray = Convert.ToInt32(Console.ReadLine)
                    Dim array(valorarray - 1) As Integer
                    For i = 0 To array.Length - 1
                        Dim valores As Integer = random.Next(0, 10)
                        array(i) = valores
                        Console.Write(array(i) & " ")
                        suma += array(i)
                    Next
                    porcentaje = 0
                    media = suma / array.Length
                    For i = 0 To array.Length - 1
                        If array(i) > media Then
                            porcentaje = porcentaje + 1
                        End If
                    Next
                    porcentaje = porcentaje / array.Length * 100
                    Console.WriteLine()
                    Console.WriteLine("El porcentaje de valores por encima de la media es: " & porcentaje)
                    Console.WriteLine("La media es de: " & media)
                    If media < 5 Then
                        Console.Write("Estas suspenso")
                    End If
                    If media >= 5 And media <= 7 Then
                        Console.Write("Aprobado")
                    End If
                    If media > 7 And media <= 9 Then
                        Console.Write("Notable")
                    End If
                    If media > 9 And media <= 10 Then
                        Console.Write("Sobresaliente")
                    End If
                    If media > 10 Then
                        Console.WriteLine("Error")
                    End If
                    Console.ReadLine()

                Case 2 'Jonathan Carballo Menezes Ejercicio 2  
                    'Diseñar un programa que calcule y muestre la desviación con respecto
                    'a la media de cada elemento de un array de enteros de tamaño n. 
                    'Ahora modificarlo para que calcule la desviación media de un array.
                    'Es decir la media de todas las desviaciones.

                    Dim valorarray, suma As Integer
                    Dim random As New Random
                    Dim media As Double
                    Console.WriteLine("Introduzca el valor del array")
                    valorarray = Convert.ToInt32(Console.ReadLine)
                    Dim array(valorarray - 1) As Integer
                    For i = 0 To array.Length - 1
                        Dim valores As Integer = random.Next(0, 10)
                        array(i) = valores
                        Console.Write(array(i) & " ")
                        suma += array(i)
                    Next
                    Console.WriteLine()
                    media = suma / valorarray
                    Console.Write("La media sera de " & media)
                    Console.WriteLine()
                    For i = 0 To array.Length - 1
                        Dim desviacion As Double
                        desviacion = Convert.ToDouble(array(i) - media)
                        Console.Write("La desviacion de " & array(i) & " sera de " & desviacion & " ")
                    Next
                    Console.ReadLine()

                Case 3 'Jonathan Carballo Menezes Ejercicio 3
                    'Declarar dos arrays de 5 elementos, pedir los datos del primero por teclado al usuario.
                    'A continuación darle valores al segundo array de manera que cada posición
                    'almacenará el mismo valor que la misma posición del primer array más 10.
                    'Mostrar ambos arrays por pantalla.

                    Dim array1(4) As Integer
                    Dim array2(4) As Integer
                    For i = 0 To 4
                        Console.WriteLine("Introduzca un valor: ")
                        array1(i) = Convert.ToInt32(Console.ReadLine)
                    Next
                    For i = 0 To 4
                        array2(i) = array1(i) + 10
                    Next
                    For i = 0 To 4
                        Console.WriteLine("Valor del elemento " & (i + 1) & " del primer array: " & array1(i))
                        Console.WriteLine("Valor del elemento " & (i + 1) & " del segundo array: " & array2(i))
                    Next
                    Console.ReadLine()

                Case 4 'Jonathan Carballo Menezes Ejercicio 4
                    'Escribir un programa que calcule el módulo de un array de n valores.

                    Dim valor, indice As Integer
                    Console.Write("Introduzca valor del array ")
                    valor = Convert.ToInt32(Console.ReadLine)
                    Dim random As New Random
                    Dim array(valor - 1) As Integer
                    Dim sumaCuadrados As Double
                    For i = 0 To array.Length - 1
                        Dim valores As Integer = random.Next(0, 10)
                        array(i) = valores
                        Console.Write(array(i) & " ")
                    Next
                    For indice = 0 To array.Length - 1
                        sumaCuadrados += Math.Pow(array(indice), 2)
                    Next
                    Dim modulo As Double = Math.Sqrt(sumaCuadrados)
                    Console.WriteLine("El módulo del array es " & modulo)
                    Console.ReadLine()

                Case 5 'Jonathan Carballo Menezes Ejercicio 5
                    'Diseñar un programa que detecte la posición del primer número negativo en un  array.
                    'Mostrará por pantalla el valor y el índice.

                    Dim array As Integer() = {1, -2, 3, 4, -5, 6, 7, -8, 9, 10}
                    Dim numnegativo As Integer = -1
                    For i = 0 To array.Length - 1
                        Console.Write(array(i) & " ")
                    Next
                    For i As Integer = 0 To array.Length - 1
                        If array(i) < 0 Then
                            numnegativo = i
                            Exit For
                        End If
                    Next
                    Console.WriteLine()
                    If numnegativo <> -1 Then
                        Console.Write("El primer número negativo es " & array(numnegativo) & " y se encuentra en la posición " & numnegativo & " del array.")
                    Else
                        Console.WriteLine("No se ha encontrado ningún número negativo en el array")
                    End If
                    Console.ReadLine()

                Case 6 'Jonathan Carballo Menezes Ejercicio 6
                    'Diseñar un programa que busque un número introducido por el usuario.
                    'Es decir si el usuario introduce un 3 el programa buscará si en el array hay alguna posición que almacene ese valor,
                    'en cuyo caso muestra por pantalla el índice.
                    'Si hay más de una aparición las muestra todas, si no hay ninguna informa de dicha circunstancia.

                    Dim numeros() As Integer = {15, 7, 3, 41, 98}
                    Dim numeroABuscar, contador As Integer
                    Dim indice As Integer
                    Console.WriteLine("Introduce el número a buscar:")
                    numeroABuscar = Convert.ToInt32(Console.ReadLine())
                    For indice = 0 To numeros.Length - 1
                        If numeros(indice) = numeroABuscar Then
                            Console.WriteLine("El número se encuentra en la posición " & indice)
                        Else
                            contador += 1
                        End If
                    Next
                    If contador > 4 Then
                        Console.WriteLine("El número no se encuentra en el array")
                    End If
                    Console.ReadLine()

                Case 7 'Jonathan Carballo Menezes Ejercicio 7
                    'Declarar una matriz con capacidad para 100 Strings y presentar un menú al usuario
                    Dim array(99) As String
                    Dim opcion As Integer
                    Do
                        Console.WriteLine("1. Introducir nombres")
                        Console.WriteLine("2. Mostrar nombres")
                        Console.WriteLine("3. Contar nombres")
                        Console.WriteLine("4. Mostrar espacio")
                        Console.WriteLine("5. Buscar nombre")
                        Console.WriteLine("6. Eliminar nombre")
                        Console.WriteLine("7. Salir")
                        opcion = Convert.ToInt32(Console.ReadLine)
                        Select Case opcion
                            Case 1
                                Dim nombre As String
                                Console.WriteLine("Ingrese su nombre:")
                                nombre = Console.ReadLine
                                For i = 0 To 99
                                    If array(i) = "" Then
                                        array(i) = nombre
                                        Exit For
                                    End If
                                Next
                            Case 2
                                Dim contador As Integer
                                For i = 0 To 99
                                    If array(i) <> "" Then
                                        Console.WriteLine("Nombre " & (i + 1) & ": " & array(i))
                                    Else
                                        contador += 1
                                    End If
                                Next
                                If contador > 99 Then
                                    Console.WriteLine("No hay nombres registrados")
                                End If
                            Case 3
                                Dim contador As Integer
                                For i = 0 To 99
                                    If array(i) <> "" Then
                                        contador += 1
                                    End If
                                Next
                                Console.WriteLine("Hay " & contador & " nombres")
                            Case 4
                                Dim espacio As Integer
                                For i = 0 To array.Length - 1
                                    If array(i) Is Nothing Then
                                        espacio = espacio + 1
                                    End If
                                Next
                                Console.WriteLine("Hay " & espacio & " posiciones vacías en la matriz.")

                            Case 5
                                Console.WriteLine("Introduce el nombre a buscar:")
                                Dim nombre As String = Console.ReadLine()
                                Dim indice As Integer
                                For indice = 0 To array.Length - 1
                                    If array(indice) = nombre Then
                                        Console.WriteLine("El nombre se encuentra en la posición " & indice & " de la matriz.")
                                        Exit For
                                    End If
                                Next
                                If indice = array.Length Then
                                    Console.WriteLine("No se ha encontrado el nombre en la matriz.")
                                End If

                            Case 6
                                    Console.WriteLine("Introduce el nombre a eliminar:")
                                Dim nombre As String = Console.ReadLine()
                                Dim indice As Integer
                                For indice = 0 To array.Length - 1
                                    If array(indice) = nombre Then
                                        array(indice) = Nothing

                                        Dim indice2 As Integer
                                        For indice2 = indice To array.Length - 2
                                            array(indice2) = array(indice2 + 1)
                                        Next
                                        array(array.Length - 1) = Nothing
                                        Exit For
                                    End If
                                Next
                                If indice = array.Length Then
                                    Console.WriteLine("No se ha encontrado el nombre")
                                End If
                            Case 7
                        End Select
                    Loop While opcion <> 7
                    Console.ReadLine()

                Case 8 'Jonathan Carballo Menezes Ejercicio 8
                    'Crear un programa que permita generar n valores enteros entre dos límites que son introducidos por el usuario.
                    'A continuación , el programa muestra la siguiente información:

                Case 9 'Jonathan Carballo Menezes Ejercicio 9
                    'Diseñar un programa que permita calcular el valor más alto de una matriz.(sin ordenarlo)

                    Dim matriz(8) As Integer
                    Dim fila As Integer
                    Dim valorMasAlto As Integer
                    matriz(0) = 12
                    matriz(1) = 289
                    matriz(2) = 32
                    matriz(3) = 67
                    matriz(4) = 5
                    matriz(5) = 63
                    matriz(6) = 7
                    matriz(7) = 15
                    matriz(8) = 9
                    valorMasAlto = matriz(0)
                    For fila = 0 To matriz.GetUpperBound(0)
                        If matriz(fila) > valorMasAlto Then
                            valorMasAlto = matriz(fila)
                        End If
                    Next
                    Console.WriteLine("El valor más alto de la matriz es " & valorMasAlto)
                    Console.ReadLine()

                Case 10 'Jonathn Carballo Menezes Ejercicio 10
                    'Utiliza la librería Array

                Case 11
                    Exit Do
            End Select
        Loop While ejercicio <> 11

    End Sub

End Module
