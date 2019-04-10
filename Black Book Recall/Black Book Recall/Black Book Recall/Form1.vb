Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim counter = 0
        'Dim readIt = IO.File.ReadAllLines("C:\Users\Jim\Desktop\VB\Black Book\Black Book\Black Book\bin\Debug\BlackBook.txt")
        Dim readIt = My.Computer.FileSystem.ReadAllText("C:\Users\Jim\Desktop\VB\Black Book\Black Book\Black Book\bin\Debug\BlackBook.txt")
        Dim SortIt
        SortIt = readIt.Split(",".ToArray)
        Dim Measure = SortIt.Length

        Dim counter2 = 0
        While counter2 < SortIt.Length

            ListBox1.Items.Add(SortIt(counter))
            counter2 = counter2 + 6
            counter = counter + 1
        End While


    End Sub

    Private Sub Names_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub
End Class
