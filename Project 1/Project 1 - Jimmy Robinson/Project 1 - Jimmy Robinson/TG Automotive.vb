Public Class Form1

    Dim Total = 0.0

    Function ValidateInputs() As Boolean
        If TextBox1.Text > 0 = True Then
            Total += TextBox1.Text
        End If
        If TextBox2.Text > 0 = True Then
            Total += TextBox2.Text
        End If
        Return Total
    End Function

    Function CalcOilLubeCharges() As Decimal
        If CheckBox1.Checked = True Then
            Total += 36.0
        End If
        If CheckBox2.Checked = True Then
            Total += 28.0
        End If
        Return Total
    End Function

    Function CalcFlushCharges() As Decimal
        If CheckBox6.Checked = True Then
            Total += 50
        End If
        If CheckBox7.Checked = True Then
            Total += 120
        End If
        Return Total
    End Function

    Function CalcMiscCharges() As Decimal
        If CheckBox3.Checked = True Then
            Total += 15
        End If
        If CheckBox4.Checked = True Then
            Total += 200
        End If
        If CheckBox5.Checked = True Then
            Total += 20
        End If
        Label16.Text = Total - TextBox2.Text
        Label17.Text = TextBox2.Text
        Label18.Text = TextBox2.Text * 0.1
        Total += Label18.Text
        Return Total
    End Function

    Sub CalculateTotalCharges()
        Label19.Text = Total
    End Sub

    Sub ClearOilLube()
        CheckBox1.Checked = False
        CheckBox2.Checked = False
    End Sub

    Sub ClearFlushes()
        CheckBox6.Checked = False
        CheckBox7.Checked = False
    End Sub

    Sub ClearMisc()
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False
    End Sub

    Sub ClearOther()
        TextBox2.Text = 0
        TextBox1.Text = 0
        Total = 0
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged

    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged

    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged


    End Sub

    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox7.CheckedChanged


    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click
        Label17.Text = TextBox2.Text
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ClearOilLube()
        ClearFlushes()
        ClearMisc()
        ClearOther()
        Total = 0
        Label16.Text = 0
        Label17.Text = 0
        Label18.Text = 0
        Label19.Text = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ValidateInputs()
        CalcFlushCharges()
        CalcMiscCharges()
        CalcOilLubeCharges()
        CalculateTotalCharges()
        Total = 0
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class
