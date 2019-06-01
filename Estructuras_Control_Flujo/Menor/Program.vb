Imports System

Module Program
    Sub Main(args As String())
        Dim Valor1, Valor2, Valor3 As UInt16
        Console.WriteLine("Ingrese los Tres valores consecutivamente: ")
        Valor1 = Console.ReadLine
        Valor2 = Console.ReadLine
        Valor3 = Console.ReadLine

        If Valor1 < Valor2 And Valor1 < Valor3 Then
            Console.WriteLine("El primer valor es menor")
        ElseIf Valor2 < Valor1 And Valor2 < Valor3 Then
            Console.WriteLine("El segundo valor es menor")

        Else Console.WriteLine("El tercer valor es menor")
        End If

    End Sub
End Module
