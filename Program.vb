Imports System
' Code writted by AligProgrammer
' Implementation of Binary Search

Module Program
    Dim MyNumbers() As Integer = {9, 10, 11, 25, 45, 50, 70, 71, 90, 100} ' the list is already ordered, we need to do this for binary search to work
    ' if not already ordered we can order it using insertion sort or bubble sort (only ones we can use for A-Level)

    Function BinarySearch(ByVal item As Integer) As Boolean
        Dim Middle As Integer
        Dim higherBound As Integer = 9
        Dim lowerBound As Integer = 0


        While lowerBound <= higherBound
            Middle = (higherBound + lowerBound) / 2
            If item = MyNumbers(Middle) Then
                Return True
            ElseIf item < MyNumbers(Middle) Then
                higherBound = Middle - 1
            Else
                lowerBound = Middle + 1
            End If
        End While


        Return False


    End Function

    Sub Main()
        Dim condition As Boolean
        Dim userAnswer As Integer

        While True
            Console.WriteLine("Please enter a number to search for in the array: ")
            userAnswer = Int(Console.ReadLine())

            condition = BinarySearch(userAnswer)

            If condition = True Then
                Console.WriteLine("Item is in the array")
            Else
                Console.WriteLine("Item is not in the array")
            End If
            Console.WriteLine("--------------------------")
        End While

    End Sub
End Module
