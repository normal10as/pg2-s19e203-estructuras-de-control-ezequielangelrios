Imports System

Module Program
    Sub Main(args As String())
        Dim CantidadProducto As UInt16
        Dim PrecioUnitario As Single
        Dim SubTotal As Single
        Dim Total As Single
        Dim MontoADescontar As Single
        Const Descuento1 As Byte = 5
        Const Descuento2 As Byte = 10
        Const Descuento3 As Byte = 20
        Console.WriteLine("Ingrese la cantidad de Productos: ")
        CantidadProducto = Console.ReadLine
        Console.WriteLine("Ingrese el Precio Unitario: ")
        PrecioUnitario = Console.ReadLine
        If CantidadProducto >= 10 And CantidadProducto <= 50 Then
            SubTotal = PrecioUnitario * CantidadProducto
            MontoADescontar = SubTotal * Descuento1 / 100
            Total = SubTotal - MontoADescontar
            Console.WriteLine("El SubTotal es {0}, Porcentaje descontado {1}%", SubTotal, Descuento1)
            Console.WriteLine("Monto descontado ${0}, Total ${1}", MontoADescontar, Total)
        End If
        If CantidadProducto >= 51 And CantidadProducto <= 250 Then
            SubTotal = PrecioUnitario * CantidadProducto
            MontoADescontar = SubTotal * Descuento2 / 100
            Total = SubTotal - MontoADescontar
            Console.WriteLine("El SubTotal es {0}, Porcentaje descontado {1}%", SubTotal, Descuento2)
            Console.WriteLine("Monto descontado ${0}, Total ${1}", MontoADescontar, Total)
        End If
        If CantidadProducto >= 251 Then
            SubTotal = PrecioUnitario * CantidadProducto
            MontoADescontar = SubTotal * Descuento3 / 100
            Total = SubTotal - MontoADescontar
            Console.WriteLine("El SubTotal es {0}, Porcentaje descontado {1}%", SubTotal, Descuento3)
            Console.WriteLine("Monto descontado ${0}, Total ${1}", MontoADescontar, Total)
        End If

    End Sub
End Module
