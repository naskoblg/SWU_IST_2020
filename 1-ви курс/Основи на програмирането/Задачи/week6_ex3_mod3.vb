Imports System
Module Module1
    Sub Main()
        Dim n, x As Integer
        Randomize()
        n = CInt(Math.Ceiling(Rnd() * 19)) + 1
        Console.WriteLine("----==== G U E S S   T H E   N U M B E R ====----")
        Do
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
        Loop Until x = n
        Console.ReadKey()
    End Sub
End Module
