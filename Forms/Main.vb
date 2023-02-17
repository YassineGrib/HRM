Public Class Main
    Private Sub Guna2PictureBox5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Guna2PictureBox12_Click(sender As Object, e As EventArgs)
        Me.Hide()
        employees.Show()
    End Sub

    Private Sub Guna2Shapes3_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub Guna2PictureBox2_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox2.Click


        ' Display a message box with Yes and No buttons
        Dim result As DialogResult = MessageBox.Show("Do you want to Exit?", "Confirmation", MessageBoxButtons.YesNo)

        ' Check the user's response
        If result = DialogResult.Yes Then
            End

            ' User clicked Yes
            ' Do something...
        ElseIf result = DialogResult.No Then

            ' User clicked No
            ' Do something else...
        End If
    End Sub
End Class