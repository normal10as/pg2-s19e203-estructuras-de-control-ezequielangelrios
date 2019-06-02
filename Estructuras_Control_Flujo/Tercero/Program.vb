Imports System
Imports System.Math
Module Program
    Sub Main(args As String())
        Dim Valor1, Valor2, Valor3, Valor4, Valor5 As Integer

        Console.WriteLine("Ingrese Cinco valores consecutivamente: ")
        Valor1 = Console.ReadLine
        Valor2 = Console.ReadLine
        Valor3 = Console.ReadLine
        Valor4 = Console.ReadLine
        Valor5 = Console.ReadLine

        If Valor1 > Max(Valor2, Valor3) And Valor1 > Max(Valor4, Valor5) Then
            Console.WriteLine("El primer numero es el mayor valor")
        End If
        If Valor2 > Max(Valor1, Valor3) And Valor2 > Max(Valor4, Valor5) Then
            Console.WriteLine("El segundo numero es el mayor valor")
        End If
        If Valor3 > Max(Valor1, Valor2) And Valor3 > Max(Valor4, Valor5) Then
            Console.WriteLine("El tercero numero es el mayor valor")
        End If
        If Valor4 > Max(Valor1, Valor2) And Valor4 > Max(Valor3, Valor5) Then
            Console.WriteLine("El cuarto numero es el mayor valor")
        End If
        If Valor5 > Max(Valor1, Valor2) And Valor5 > Max(Valor3, Valor4) Then
            Console.WriteLine("El quinto numero es el mayor valor")
        End If
    End Sub
End Module
