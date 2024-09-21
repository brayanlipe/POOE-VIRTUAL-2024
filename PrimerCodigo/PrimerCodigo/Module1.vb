Module Module1

    Sub Main()
        Console.WriteLine("ingrese num1")
        Dim num1 As Double
        num1 = Console.ReadLine  ' double.parse(console.readLine()) esta lienea me permite almacenar en la variable sino me da una suma decimal '

        Console.WriteLine("ingrese el num2")
        Dim num2 As Double
        num2 = Console.ReadLine



        Console.WriteLine("la suma de los dos numero es: " & num1 + num2)


        Console.ReadKey() 'pausa a consola de windows'

    End Sub

End Module
