Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.SelectedIndex = 0 Then
            txtResult.Text = Val(txtNum1.Text) + Val(txtNum2.Text)
        End If

        If ComboBox1.SelectedIndex = 1 Then
            txtResult.Text = Val(txtNum1.Text) - Val(txtNum2.Text)
        End If

        If ComboBox1.SelectedIndex = 2 Then
            txtResult.Text = Val(txtNum1.Text) * Val(txtNum2.Text)
        End If

        If ComboBox1.SelectedIndex = 3 Then
            txtResult.Text = Val(txtNum1.Text) / Val(txtNum2.Text)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Show()
    End Sub
End Class
