Public Class Form1
    Private Sub TableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TableBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.RnRDataSet1)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RnRDataSet1.Table' table. You can move, or remove it, as needed.
        Me.TableTableAdapter.Fill(Me.RnRDataSet1.Table)

    End Sub

    Private Sub TitleComboBox_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ISBNTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class
