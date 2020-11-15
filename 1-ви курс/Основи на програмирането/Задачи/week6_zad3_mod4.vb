Imports System
Module Module1
    Sub Main()
        Dim n, x As Integer
        Randomize()
        n = CInt(Math.Ceiling(Rnd() * 19)) + 1
        Console.WriteLine("----==== G U E S S   T H E   N U M B E R ====----")
        While x <> n
            For i As Integer = 1 To 2
                Console.Write("Your chois is between 1 and 20: ")
                x = CInt(Console.ReadLine())
                If x = n Then
                    Console.WriteLine("YESSSS!")
                Else
                    If (x < n) Then
                        Console.WriteLine("The number is bigger!")
                    Else
                        Console.WriteLine("The number is smaller!")
                    End If
                End If
            Next
        End While
        Console.ReadKey()
    End Sub
End Module