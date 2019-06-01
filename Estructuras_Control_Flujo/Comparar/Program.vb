Imports System

Module Program
    Sub Main(args As String())
        Dim Valor1, Valor2 As UInt16
        Console.WriteLine("Ingrese el primer valor: ")
        Valor1 = Console.ReadLine
        Console.WriteLine("Ingrese el segundo valor: ")
        Valor2 = Console.ReadLine
        If Valor1 > Valor2 Then
            Console.WriteLine("El primer valor es el mayor")
        ElseIf Valor1 < Valor2 Then
            Console.WriteLine("El segundo valor es mayor")
        End If
        If Valor1 = Valor2 Then
            Console.WriteLine("Los dos son iguales")
        End If
    End Sub
End Module
