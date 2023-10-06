Module Module1

    Sub Main()
        ' Declaración de variables
        Dim costo As Double
        Dim dineroEntregado As Double
        Dim cambio As Double

        ' Solicitar el costo del artículo
        Console.Write("Ingrese el costo del artículo: ")
        costo = Double.Parse(Console.ReadLine())

        ' Solicitar la cantidad de dinero entregado por el cliente
        Console.Write("Ingrese la cantidad de dinero entregado por el cliente: ")
        dineroEntregado = Double.Parse(Console.ReadLine())

        ' Verificar el pago y calcular el cambio o la cantidad faltante
        If dineroEntregado > costo Then
            cambio = dineroEntregado - costo
            Console.WriteLine("Cambio a entregar: $" & cambio.ToString("0.00"))
        ElseIf dineroEntregado = costo Then
            Console.WriteLine("Entrega del producto.")
        Else
            Console.WriteLine("El pago es insuficiente. Falta pagar: $" & (costo - dineroEntregado).ToString("0.00"))
            Console.WriteLine("Lo sentimos, no podemos entregar el producto en este momento.")

        End If
        Console.WriteLine("Vuelva pronto por el producto que desea.")
        ' Esperar a que el usuario presione una tecla antes de salir
        Console.WriteLine("Presione cualquier tecla para salir...")
        Console.ReadKey()
        Console.WriteLine("Laboratorio 2 de Programacion 2 Ing. Jonathan Carballo")
        Console.WriteLine("Desarrollado por Mario Enrique Menjivar Abarca.")
        Console.WriteLine("Fecha 05/10/2023")
    End Sub

End Module
