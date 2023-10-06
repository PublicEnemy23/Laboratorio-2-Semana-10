Module Module1

    Sub Main()
        Dim totalCompra As Double = 0

        Console.WriteLine("Ingrese los montos de las compras (ingrese un monto negativo para finalizar):")

        ' Bucle para ingresar los montos de las compras
        While True
            Console.Write("Monto de la compra: $")
            Dim montoCompra As Double = Double.Parse(Console.ReadLine())

            ' Verificar si se ingresó un monto negativo para finalizar
            If montoCompra < 0 Then
                Exit While
            End If

            ' Acumular el monto de la compra al total
            totalCompra += montoCompra

            ' Aplicar descuentos según las condiciones
            If totalCompra > 999 Then
                totalCompra *= 0.9 ' Aplicar un 10% de descuento
            ElseIf totalCompra > 499 Then
                totalCompra *= 0.95 ' Aplicar un 5% de descuento
            End If
        End While

        ' Mostrar el total de la compra después de aplicar descuentos
        Console.WriteLine("Total de la compra después de descuentos: $" & totalCompra.ToString("0.00"))

        ' Esperar a que el usuario presione una tecla antes de salir
        Console.WriteLine("Presione cualquier tecla para salir...")
        Console.ReadKey()
        Console.WriteLine("Parcial 2 de Programacion 2 Ing. Jonathan Carballo")
        Console.WriteLine("Desarrollado por Mario Enrique Menjivar Abarca.")
        Console.WriteLine("Fecha 05/10/2023")
    End Sub

End Module
