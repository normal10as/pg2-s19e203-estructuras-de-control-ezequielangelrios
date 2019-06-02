Imports System

Module Program
    Enum Meses
        Enero = 1
        Febrero = 2
        Marzo = 3
        Abril = 4
        Mayo = 5
        Junio = 6
        Julio = 7
        Agosto = 8
        Septiembre = 9
        Octubre = 10
        Noviembre = 11
        Diciembre = 12
    End Enum
    Sub Main(args As String())
        Dim NumeroMes As Byte
        Console.WriteLine("Ingrese un numero de mes (1-12): ")
        NumeroMes = Console.ReadLine
        Select Case NumeroMes
            Case 1
                Console.WriteLine("Corresponde al mes de " & Meses.Enero.ToString)
            Case 2
                Console.WriteLine("Corresponde al mes de " & Meses.Febrero.ToString)
            Case 3
                Console.WriteLine("Corresponde al mes de " & Meses.Marzo.ToString)
            Case 4
                Console.WriteLine("Corresponde al mes de " & Meses.Abril.ToString)
            Case 5
                Console.WriteLine("Corresponde al mes de " & Meses.Mayo.ToString)
            Case 6
                Console.WriteLine("Corresponde al mes de " & Meses.Junio.ToString)
            Case 7
                Console.WriteLine("Corresponde al mes de " & Meses.Julio.ToString)
            Case 8
                Console.WriteLine("Corresponde al mes de " & Meses.Agosto.ToString)
            Case 9
                Console.WriteLine("Corresponde al mes de " & Meses.Septiembre.ToString)
            Case 10
                Console.WriteLine("Corresponde al mes de " & Meses.Octubre.ToString)
            Case 11
                Console.WriteLine("Corresponde al mes de " & Meses.Noviembre.ToString)
            Case 12
                Console.WriteLine("Corresponde al mes de " & Meses.Diciembre.ToString)
            Case Else
                Console.Write("No pertenece a un mes de año")
        End Select
    End Sub
End Module
