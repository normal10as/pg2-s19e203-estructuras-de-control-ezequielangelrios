Imports System
Imports System.Math
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
        Dim Mes, Anio As Integer

        Console.WriteLine("Ingrese el Año: ")
        Anio = Console.ReadLine
        Console.WriteLine("Ingrese el Mes: ")
        Mes = Console.ReadLine

        Select Case Mes
            Case 1
                Console.WriteLine("Año {0} Mes {1}, tiene 31 dias ", Anio, Meses.Enero.ToString())

            Case 2
                If Anio Mod 4 = 0 And (Anio Mod 400 = 0 Or Not Anio Mod 100 = 0) Then
                    Console.WriteLine("Año {0} Mes {1}, tiene 29 dias ", Anio, Meses.Febrero.ToString())
                Else
                    Console.WriteLine("Año {0} Mes {1}, tiene 28 dias ", Anio, Meses.Febrero.ToString())
                End If
            Case 3
                Console.WriteLine("Año {0} Mes {1}, tiene 31 dias ", Anio, Meses.Marzo.ToString)
            Case 4
                Console.WriteLine("Año {0} Mes {1}, tiene 30 dias ", Anio, Meses.Abril.ToString)
            Case 5
                Console.WriteLine("Año {0} Mes {1}, tiene 31 dias ", Anio, Meses.Mayo.ToString)
            Case 6
                Console.WriteLine("Año {0} Mes {1}, tiene 30 dias ", Anio, Meses.Junio.ToString)
            Case 7
                Console.WriteLine("Año {0} Mes {1}, tiene 31 dias ", Anio, Meses.Julio.ToString)
            Case 8
                Console.WriteLine("Año {0} Mes {1}, tiene 31 dias ", Anio, Meses.Agosto.ToString)
            Case 9
                Console.WriteLine("Año {0} Mes {1}, tiene 30 dias ", Anio, Meses.Septiembre.ToString)
            Case 10
                Console.WriteLine("Año {0} Mes {1}, tiene 31 dias ", Anio, Meses.Octubre.ToString)
            Case 11
                Console.WriteLine("Año {0} Mes {1}, tiene 30 dias ", Anio, Meses.Noviembre.ToString)
            Case 12
                Console.WriteLine("Año {0} Mes {1}, tiene 31 dias ", Anio, Meses.Diciembre.ToString)
            Case Else
                Console.WriteLine("Error")
        End Select
    End Sub
End Module
