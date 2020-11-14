Imports System

Module Program
    Function Invert(ByVal InputArray() As Boolean)
        Dim OutputArray(15) As Boolean
        For i As Integer = 0 To InputArray.GetUpperBound(0)
            If InputArray(i) = True Then
                OutputArray(i) = False
            ElseIf InputArray(i) = False Then
                OutputArray(i) = True
            End If
        Next
        Return OutputArray
    End Function

    Function MapSegment(ByVal InputArray() As Boolean)
        Dim OutputMatrix(10, 10) As Boolean
        'Empty it
        For index0 = 0 To OutputMatrix.GetUpperBound(0)
            For index1 = 0 To OutputMatrix.GetUpperBound(1)
                OutputMatrix(index0, index1) = False
            Next
        Next
        'Direct mapping to elements
        'a1
        If InputArray(0) = True Then
            OutputMatrix(0, 1) = True
            OutputMatrix(0, 2) = True
            OutputMatrix(0, 3) = True
            OutputMatrix(0, 4) = True
        End If
        'a2
        If InputArray(1) = True Then
            OutputMatrix(0, 6) = True
            OutputMatrix(0, 7) = True
            OutputMatrix(0, 8) = True
            OutputMatrix(0, 9) = True
        End If
        'b
        If InputArray(2) = True Then
            OutputMatrix(1, 10) = True
            OutputMatrix(2, 10) = True
            OutputMatrix(3, 10) = True
            OutputMatrix(4, 10) = True
        End If
        'c
        If InputArray(3) = True Then
            OutputMatrix(6, 10) = True
            OutputMatrix(7, 10) = True
            OutputMatrix(8, 10) = True
            OutputMatrix(9, 10) = True
        End If
        'd1
        If InputArray(4) = True Then
            OutputMatrix(10, 1) = True
            OutputMatrix(10, 2) = True
            OutputMatrix(10, 3) = True
            OutputMatrix(10, 4) = True
        End If
        'd2
        If InputArray(5) = True Then
            OutputMatrix(10, 6) = True
            OutputMatrix(10, 7) = True
            OutputMatrix(10, 8) = True
            OutputMatrix(10, 9) = True
        End If
        'e
        If InputArray(6) = True Then
            OutputMatrix(9, 0) = True
            OutputMatrix(8, 0) = True
            OutputMatrix(7, 0) = True
            OutputMatrix(6, 0) = True
        End If
        'f
        If InputArray(7) = True Then
            OutputMatrix(4, 0) = True
            OutputMatrix(3, 0) = True
            OutputMatrix(2, 0) = True
            OutputMatrix(1, 0) = True
        End If
        'g1
        If InputArray(8) = True Then
            OutputMatrix(5, 1) = True
            OutputMatrix(5, 2) = True
            OutputMatrix(5, 3) = True
            OutputMatrix(5, 4) = True
        End If
        'g2
        If InputArray(9) = True Then
            OutputMatrix(5, 6) = True
            OutputMatrix(5, 7) = True
            OutputMatrix(5, 8) = True
            OutputMatrix(5, 9) = True
        End If
        'h
        If InputArray(10) = True Then
            OutputMatrix(1, 1) = True
            OutputMatrix(2, 2) = True
            OutputMatrix(3, 3) = True
            OutputMatrix(4, 9) = True
        End If
        'i
        If InputArray(11) = True Then
            OutputMatrix(1, 5) = True
            OutputMatrix(2, 5) = True
            OutputMatrix(3, 5) = True
            OutputMatrix(4, 5) = True
        End If
        'j
        If InputArray(12) = True Then
            OutputMatrix(1, 9) = True
            OutputMatrix(2, 8) = True
            OutputMatrix(3, 7) = True
            OutputMatrix(4, 6) = True
        End If
        'k
        If InputArray(13) = True Then
            OutputMatrix(9, 1) = True
            OutputMatrix(8, 2) = True
            OutputMatrix(7, 3) = True
            OutputMatrix(6, 4) = True
        End If
        'l
        If InputArray(14) = True Then
            OutputMatrix(6, 5) = True
            OutputMatrix(7, 5) = True
            OutputMatrix(8, 5) = True
            OutputMatrix(9, 5) = True
        End If
        'm
        If InputArray(15) = True Then
            OutputMatrix(6, 6) = True
            OutputMatrix(7, 7) = True
            OutputMatrix(8, 8) = True
            OutputMatrix(9, 9) = True
        End If
        Return OutputMatrix
    End Function

    Function PrintCanavas(ByVal InputMatrix(,) As Boolean, ByVal ConsoleW As Integer) As Boolean
        For index0 = 0 To InputMatrix.GetUpperBound(0)
            'For index1 = 0 To InputMatrix.GetUpperBound(1)
            For index1 = 0 To ConsoleW - 2
                If InputMatrix(index0, index1) = True Then
                    Console.Write("*")
                ElseIf InputMatrix(index0, index1) = False Then
                    Console.Write(" ")
                End If
            Next
            Console.WriteLine("")
        Next
        Console.WriteLine("Done Printing")
        Return True
    End Function

    Function PutCanavas(ByVal InputMatrix As Boolean(,), ByVal TargetCanavas As Boolean(,), ByVal ShiftPos As Integer, ByVal CanavasSize As Integer) As Boolean
        For index0 = 0 To InputMatrix.GetUpperBound(0)
            For index1 = 0 To InputMatrix.GetUpperBound(1)
                Dim CurrentPos As Integer = (index1 + ShiftPos)
                TargetCanavas(index0, CurrentPos) = InputMatrix(index0, index1)
            Next
        Next
        Return True
    End Function



    Function ScrollCanavas(ByVal InputMatrix As Boolean(,), ByVal ShiftPos As Integer) As Boolean(,)
        Dim OutputMatrix(,) As Boolean = InputMatrix
        For index0 = 0 To InputMatrix.GetUpperBound(0)
            For index1 = 0 To (InputMatrix.GetUpperBound(1) - ShiftPos)
                OutputMatrix(index0, index1) = InputMatrix(index0, (index1 + ShiftPos))
            Next
        Next
        Return OutputMatrix
    End Function

    Private Sub wait(ByVal seconds As Integer)
        For i As Integer = 0 To seconds * 100
            System.Threading.Thread.Sleep(10)
            'Application.DoEvents()
        Next
    End Sub

    Sub Main(args As String())
        Dim ConsoleWidth As Integer = Console.WindowWidth
        Console.WriteLine("Console Width: {0}", ConsoleWidth)
        Dim MyCanavas(10, ConsoleWidth - 1) As Boolean
        Dim TempSegment(,) As Boolean

        Dim EmptySpace() As Boolean = {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1}
        Dim H() As Boolean = {1, 1, 0, 0, 1, 1, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1}
        Dim E() As Boolean = {0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1}
        Dim L() As Boolean = {1, 1, 1, 1, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1}
        Dim O() As Boolean = {0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1}
        'Dim MyText As Boolean()() = {H, E, L, L, O}
        Dim MyText As Boolean()() = {H, E, L, L, O, EmptySpace, H, E, L, L, O}

        'Dim booldict = New Dictionary(Of String, Boolean) From {{"a1", True}, {"a2", True}, {"b", True}, {"c", False}, {"d1", False}, {"d2", False}, {"e", False}, {"f", False}, {"g1", True}, {"g2", True}, {"h", True}, {"i", False}, {"j", False}, {"k", False}, {"l", False}, {"m", False}}

        Dim StepSize As Integer = 2
        Dim SegDim As Integer = 12
        For I = 0 To MyText.GetUpperBound(0)
            Dim NextPos As Integer = I * SegDim
            If ((MyText.GetUpperBound(0) + 1) * SegDim) > ConsoleWidth Then
                ReDim Preserve MyCanavas(10, (((MyText.GetUpperBound(0) + 1) * SegDim)))
            End If
            TempSegment = MapSegment(Invert(MyText(I)))
            PutCanavas(TempSegment, MyCanavas, NextPos, ConsoleWidth)
        Next

        If MyCanavas.GetUpperBound(1) > ConsoleWidth Then
            PrintCanavas(MyCanavas, ConsoleWidth)
            Console.Clear()
            Dim index0 As Integer = 0
            While index0 <= ((ConsoleWidth / StepSize) + 5)
                Console.Clear()
                PrintCanavas(MyCanavas, ConsoleWidth)
                MyCanavas = ScrollCanavas(MyCanavas, StepSize)
                wait(0.51)
                index0 += 1
            End While
        Else
            PrintCanavas(MyCanavas, ConsoleWidth)
        End If

    End Sub

End Module
