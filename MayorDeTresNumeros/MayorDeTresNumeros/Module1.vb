Module Module1

    Sub Main()
        Dim num1, num2, num3 As Integer
        Dim mayor As Integer


        Console.WriteLine("ingrese el primer numero")
        num1 = Console.ReadLine()

        Console.WriteLine("ingrese el segundo numero")
        num2 = Console.ReadLine()

        Console.WriteLine("ingrese el tercer numero")
        num3 = Console.ReadLine()


        If num1 > num2 Then
            mayor = num1

        Else
            mayor = num2
        End If

        If num3 > num2 Then

            mayor = num3
        Else
            Console.WriteLine("los 3 numeros son iguales")


        End If



        Console.WriteLine("el numero mayor es:" & mayor)




        Console.ReadKey()











    End Sub

End Module
