
Imports System.Data.SqlClient

Public Class employees

    Public Sub FillDataGridView()
        ''fill Employees DataGridView from DB  
        Try
            Dim SQLCMD As New SqlCommand($"select EmployeeID, CONCAT(FirstName, ' ', LastName) AS FullName    , Phone, Department, Designation, DateOfJoining, Status, Salary from Employees_TBL", SQLCONN)
            Dim adapter As New SqlDataAdapter(SQLCMD)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridView.DataSource = table
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub employees_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'fill Employees DataGridView from DB  
        FillDataGridView()


    End Sub

    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox1.Click
        End
    End Sub

    Private Sub Guna2Shapes1_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub Guna2PictureBox5_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox5.Click

    End Sub

    Private Sub Guna2PictureBox6_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox6.Click
        Main.Show()
        Me.Hide()

    End Sub

    Private Sub PasswordTextBox_TextChanged(sender As Object, e As EventArgs) Handles PasswordTextBox.TextChanged

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        AddEmployee.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2PictureBox3_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox3.Click

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