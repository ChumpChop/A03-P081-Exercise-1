Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim intOne As Integer = 1
        Dim intTwo As Integer = 2

        MessageBox.Show((intOne + intTwo).ToString, "1 + 2")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim strA As String = "A"
        Dim strB As String = "B"

        MessageBox.Show(strA & strB, "A concatenated with B")
    End Sub
End Class
