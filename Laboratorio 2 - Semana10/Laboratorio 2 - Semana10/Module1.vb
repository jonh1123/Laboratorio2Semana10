Module Module1

    Sub Main()
        'Costo()
        MontodeCompra() '' esta solo da el descuento cuando supera el de 500 0 el 1000 licenciado cuando esta con esas cantidades no da nada no da el descuento


        Console.Read()


    End Sub

    Sub Costo()
        ''se declaran las cariables
        Dim costoProducto As Double
        Dim dineroEntregado As Double
        Dim cambio As Double


        ''aqui lo que le puse para que usted licenciado le poga la cantidad que desea
        Console.Write("Ingrese el costo del producto: ")
        costoProducto = Double.Parse(Console.ReadLine())


        Console.Write("Ingrese la cantidad de dinero entregada por el cliente: ")
        dineroEntregado = Double.Parse(Console.ReadLine())

        cambio = dineroEntregado - costoProducto


        If cambio > 0 Then
            Console.WriteLine("El cambio que se le devolvera a cliente es: " & cambio)
            Console.WriteLine("Entregar el Producto al cliente por favor:")


        ElseIf cambio = 0 Then
            Console.WriteLine("El cliente ha pagado el costo establecido de de el producto que desea.")
            Console.WriteLine("Entregar el Producto al cliente por favor.")
        Else


            Console.WriteLine("El cliente tendra que pagar la cantidad adicional de: " & Math.Abs(cambio))
            Console.WriteLine("El cliente no cuenta con la suficiente cantidad de dinero para cancelar el producto.")
            Console.WriteLine("MUCHAS GRACIAS POR PREFERINOS... VUELVA PRONTO LO ESPERAMOS PARA QUE LLEVE LOS PRODUCTOS QUE DESEA.")
        End If



        Console.ReadLine()
    End Sub

    Sub MontodeCompra()

        Dim montoCompra As Double
        Dim totalCompra As Double = 0


        Console.WriteLine("Ingrese los montos de las compras (ingrese un monto negativo para finalizar):")
        Do
            Console.Write("Monto de compra: ")
            montoCompra = Double.Parse(Console.ReadLine())

            If montoCompra < 0 Then
                Exit Do
            End If


            If montoCompra > 1000 Then
                montoCompra -= (montoCompra * 0.1)
            ElseIf montoCompra > 500 Then
                montoCompra -= (montoCompra * 0.05)
            End If


            totalCompra += montoCompra

        Loop


        Console.WriteLine("Total de la compra con descuentos aplicados: $" & totalCompra)


        Console.ReadLine()
    End Sub

    ''Voy yo solo
    ''Jonathan Gabriel Perez Esquina 


End Module


