Module Module1

    Sub Main()
        'Solicitar al usuario que ingrese un número'
        Console.Write("Ingrese un número: ")
        Dim n As Integer = Convert.ToInt32(Console.ReadLine())

        ' Inicializar la variable suma
        Dim suma As Integer = 0

        ' Calcular la suma de los números naturales desde 1 hasta n
        For i As Integer = 1 To n
            suma += i
        Next

        ' Mostrar el resultado
        Console.WriteLine("La suma de los números naturales desde 1 hasta " & n & " es: " & suma)

        ' Esperar a que el usuario presione una tecla para cerrar el programa
        Console.WriteLine("Presione cualquier tecla para salir...")
        Console.ReadKey()

    End Sub

End Module
