Module Module1

    Sub Main()
        'numero para o impar'
        Dim numero As Double
        Dim continuar = "s"

        While continuar = "s"



            Console.WriteLine("ingrese el numero a comparar")
            numero = Console.ReadLine()

            If numero Mod 2 = 0 Then
                Console.WriteLine("el numero es ingresado es par ")


            Else
                Console.WriteLine("el numero es impar")

            End If


            Console.WriteLine("desea continuar? s/n")
            continuar = Console.ReadLine()


        End While

        Console.ReadKey()


    End Sub

End Module
