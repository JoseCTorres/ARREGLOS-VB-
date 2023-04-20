Module Module1

    Sub Main()
        Arreglo()
    End Sub
    Private Sub Arreglo()
        Dim matriz As Integer(,) = New Integer(2, 2) {}
        matriz(0, 0) = 1
        matriz(0, 0) = 65
        Dim rand As Random = New Random()
        Dim suma As Integer = 0
        Dim promedio As Integer = 0

        For i As Integer = 0 To 3 - 1

            For j As Integer = 0 To 3 - 1
                matriz(i, j) = rand.[Next](1, 100)
                suma += matriz(i, j)
            Next
        Next

        For i As Integer = 0 To 3 - 1

            For j As Integer = 0 To 3 - 1
                Console.Write(matriz(i, j) & vbTab)
            Next

            Console.WriteLine()
        Next

        Console.WriteLine("La suma es: " & suma)
        Console.WriteLine("El promedio es : " & suma / 9)
        Console.ReadLine()
    End Sub

End Module
