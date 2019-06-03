Imports System

Module Program
    Sub Main(args As String())
        Dim Pie, Pulgadas, Yardas, Centimetros, Metro, Valor As Single
        Dim Opcion As Short
        Console.WriteLine("Elija que unidad desea convertir: 1-Pulgadas; 2-Pie; 3-Yardas; 4-Cm; 5-Metro")
        Opcion = Console.ReadLine
        Console.WriteLine("Ingrese el valor a convertir: ")
        Valor = Console.ReadLine
        Select Case Opcion
            Case 1
                Pie = Valor / 12
                Yardas = Valor / 36 ' 1 pie = 12 pulgadas => 1 yarda = 3 pies* 12pulgadas = 36
                Centimetros = Valor * 2.54
                Metro = Valor / 39.37 '1 pulgada = 2.54cm => 100cm / 2.54 cm = 39.37 pulgadas
                Console.WriteLine("Pies {0}; Yardas {1}; Centímetros {2}; Metros {3}", Pie, Yardas, Centimetros, Metro)
            Case 2
                Pulgadas = Valor * 12
                Yardas = Valor / 3
                Centimetros = Valor * 30.48 '12 pulgadas * 2.54 cm 
                Metro = Valor * 0.3048 '1 pie = 30.48cm => 1 pie a metro = 30.48cm/100cm
                Console.WriteLine("Pulgadas {0}; Yardas {1}; Centímetros {2}; Metros {3}", Pulgadas, Yardas, Centimetros, Metro)
            Case 3
                Pulgadas = Valor * 36 '1 pie= 12 pulgadas=>1 yarda = 3 pies = 36 pulgadas
                Pie = Valor * 3
                Centimetros = Valor * 91.44 '1 pulgada = 2.54 cm=> 36 pulgadas = 91.44 cm
                Metro = Valor / 1.09 '1 yarda = 91.44 cm => 100cm = 1.09 yardas
                Console.WriteLine("Pies {0}; Pulgadas {1}; Centímetros {2}; Metros {3}", Pie, Pulgadas, Centimetros, Metro)
            Case 4
                Pulgadas = Valor / 2.54
                Yardas = Valor / 91.44 '1 yarda = 3 pies = 36 pulgadas => 36 pulgadas*2.54cm = 91.44
                Pie = Valor / 30.48 '1 pie = 12 pulgadas => 1 pie = 12pulgadas * 2.54 cm
                Metro = Valor / 100
                Console.WriteLine("Pies {0}; Pulgadas {1}; Yardas {2}; Metros {3}", Pie, Pulgadas, Yardas, Metro)
            Case 5
                Pulgadas = Valor * 39.37 '1 pulgada = 2.54cm => 100cm / 2.54 = 39.37 pulgadas = 1 metro
                Yardas = Valor * 1.09
                Pie = Valor / 0.3048
                Centimetros = Valor * 100
                Console.WriteLine("Pies {0}; Pulgadas {1}; Yardas {2}; Centimetros {3}", Pie, Pulgadas, Yardas, Centimetros)
            Case Else
                Console.WriteLine("Error")
        End Select


    End Sub
End Module
