Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim SaveIt As String = "BlackBook.txt"

        Dim FormatIt As String = TextBox1.Text & "," & TextBox2.Text & "," & TextBox3.Text & "," & TextBox4.Text & "," & TextBox5.Text & "," & TextBox6.Text

        My.Computer.FileSystem.WriteAllText(SaveIt, FormatIt, True)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
