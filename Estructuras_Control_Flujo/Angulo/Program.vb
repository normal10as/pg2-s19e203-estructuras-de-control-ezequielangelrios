Imports System

Module Program
    Sub Main(args As String())
        Dim ValorAngulo As Short
        Console.WriteLine("Ingrese el valor del angulo (0° a 360°) ")
        ValorAngulo = Console.ReadLine
        Select Case ValorAngulo
            Case < 0
                Console.WriteLine("Error")
            Case 0 To 89
                Console.WriteLine("Es Agudo")
            Case = 90
                Console.WriteLine("Es Recto")
            Case 91 To 179
                Console.WriteLine("Es Obtuso")
            Case = 180
                Console.WriteLine("Es Llano")
            Case 181 To 360
                Console.WriteLine("Es Cónvavo")
            Case >= 361
                Console.WriteLine("Error")
        End Select
    End Sub
End Module
