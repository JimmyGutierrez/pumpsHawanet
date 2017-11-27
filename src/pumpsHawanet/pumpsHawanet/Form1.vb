Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BrowserINP_Click(sender As Object, e As EventArgs) Handles BrowserINP.Click
        Dim openFileDialogINP As New OpenFileDialog()
        openFileDialogINP.Filter = Nothing
        openFileDialogINP.Title = "Select INP File"

        If openFileDialogINP.ShowDialog() = DialogResult.OK Then
            TextBoxINP.Text = openFileDialogINP.FileName
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim epatoolclas As epatool = New epatool(TextBoxINP.Text)
        Dim presures As Double()
        presures = epatoolclas.getPressuresINP(CDbl(TextBox1.Text))
        epatoolclas.closeEpatool()

        'For i = 1 To presures.Length - 1
        '    MessageBox.Show(presures(i))
        'Next
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
