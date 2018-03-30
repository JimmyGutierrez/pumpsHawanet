Public Class Form1

    Function combinationOptions(ByVal n As Integer) As Integer(,)

        Dim Combination(((2 ^ n) - 1), n - 1) As Integer
        Dim spin As Integer
        Dim spin_1 As Integer
        Dim spin_2 As Integer

        For k = 0 To n - 1
            spin = 1
            spin_1 = 2 ^ k
            For l = 0 To (2 ^ n) - 1

                If spin <= spin_1 Then
                    Combination(l, k) = 0
                    spin = spin + 1
                    spin_2 = 1
                Else
                    Combination(l, k) = 1
                    spin_2 = spin_2 + 1
                    If spin_2 <= spin_1 Then
                    Else
                        spin = 1
                    End If

                End If

            Next

        Next
        'For l = 0 To (2 ^ n) - 1
        '    Console.WriteLine("código | " + CStr(l) + " | " + CStr(Combination(l, 0)) + " | " + CStr(Combination(l, 1)) + " | " + CStr(Combination(l, 2)) + " | " + CStr(Combination(l, 3)) + " | " + CStr(Combination(l, 4)))
        'Next


        Return Combination

    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n As Integer = CDbl(TextBox1.Text)
        If n > 0 Then
            Console.WriteLine("-----------------***** START *****-------------------")
            Dim combinationOptions_1((2 ^ n) - 1, n - 1) As Integer
            combinationOptions_1 = combinationOptions(n)
            For i = 0 To (2 ^ n) - 1
                For j = 0 To n - 1
                    If j = 0 Then
                        Console.WriteLine()
                        Console.Write(combinationOptions_1(i, j))
                    Else
                        Console.Write(combinationOptions_1(i, j))
                    End If

                Next
            Next
            Console.WriteLine()
            Console.WriteLine("-----------------***** END *****-------------------")
        Else
            Console.WriteLine("-----------------***** ERROR003x1:invalid input data *****-------------------")

        End If


    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
