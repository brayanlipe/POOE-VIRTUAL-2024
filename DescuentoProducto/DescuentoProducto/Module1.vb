Module Module1

    Sub Main()
        Console.WriteLine("ingrese el monto de compra")
        Dim montoCompra As Double
        Dim descuento1 As Double
        Dim descuento2 As Double
        Dim descuento3 As Double
        Dim descuento4 As Double
        Dim totalPagar As Double

        descuento1 = 1000.0 * 30.0 / 100
        descuento2 = 500.0 * 20.0 / 100
        descuento3 = 250.0 * 10.0 / 100
        descuento4 = 249.99 * 5.0 / 100
        montoCompra = Console.ReadLine()

        If montoCompra >= 1000.0 Then
            totalPagar = montoCompra - descuento1
            Console.WriteLine("se aplico el 30% de descuento")

        ElseIf montoCompra >= 500.0 Then
            totalPagar = montoCompra - descuento2
            Console.WriteLine("se aplico el 20% de descuento")


        ElseIf montoCompra >= 250.0 Then
            totalPagar = montoCompra - descuento3
            Console.WriteLine("se aplico el 10% de descuento")


        Else
            totalPagar = montoCompra - descuento4
            Console.WriteLine("se aplico el 5% de descuento")


        End If

        Console.WriteLine("total a pagar  $" & totalPagar)





        Console.ReadKey()

    End Sub

End Module
