Module Module1

    Sub Main()
        Console.Write("Ingrese un número: ")
        Dim numero As Integer = Convert.ToInt32(Console.ReadLine())

        ' Generar y mostrar la tabla de multiplicar
        For i As Integer = 1 To 10
            Console.WriteLine(numero & " x " & i & " = " & (numero * i))
        Next

        ' Esperar a que el usuario presione una tecla para cerrar el programa
        Console.WriteLine("Presione cualquier tecla para salir...")
        Console.ReadKey()

    End Sub

End Module
