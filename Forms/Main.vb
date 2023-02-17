Imports System.Data.SqlClient

Public Class Main
    Private Sub Guna2PictureBox5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Dim SQLCMD As New SqlCommand($"select EmployeeID from Employees_TBL ", SQLCONN)
            Dim adapter As New SqlDataAdapter(SQLCMD)
            Dim table As New DataTable()
            adapter.Fill(table)
            TotalEmployee.Text = "0" & table.Rows.Count
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub

    Private Sub Guna2PictureBox12_Click(sender As Object, e As EventArgs)

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

    Private Sub Guna2PictureBox5_Click_1(sender As Object, e As EventArgs) Handles Guna2PictureBox5.Click
        Me.Hide()
        employees.Show()
    End Sub

    Private Sub Guna2PictureBox3_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox3.Click

    End Sub

    Private Sub Guna2PictureBox12_Click_1(sender As Object, e As EventArgs) Handles Guna2PictureBox12.Click

    End Sub
End Class