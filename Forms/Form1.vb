Imports System.Data.SqlClient
Public Class Form1

    Private Sub Guna2HtmlLabel1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        End

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Make Password crypted 
        PasswordTextBox.UseSystemPasswordChar = True

        'fill Username ComboBox from DB
        Try
            Dim SQLCMD As New SqlCommand($"select Username from Users_TBL", SQLCONN)
            Dim adapter As New SqlDataAdapter(SQLCMD)
            Dim table As New DataTable()
            adapter.Fill(table)
            UsernameComboBox.DataSource = table
            UsernameComboBox.DisplayMember = "Username"
            UsernameComboBox.ValueMember = "Username"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        'Chack for Password of username Selected 
        If PasswordTextBox.Text = String.Empty Then
            MsgBox("Please entry the password!", MsgBoxStyle.Exclamation)

        ElseIf UsernameComboBox.Text = String.Empty Then
            MsgBox("Please select the User!", MsgBoxStyle.Exclamation)
        Else
            Try
                Dim SQLCMD As New SqlCommand($"select Username,Password from Users_TBL where username='{UsernameComboBox.Text}' and Password='{PasswordTextBox.Text}'", SQLCONN)
                Dim adapter As New SqlDataAdapter(SQLCMD)
                Dim table As New DataTable()
                adapter.Fill(table)
                If table.Rows.Count = 0 Then
                    MsgBox("Wrong Password!", MsgBoxStyle.Exclamation)
                Else
                    Me.Hide()
                    Main.Show()


                    'Rest password
                    PasswordTextBox.Text = ""
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Guna2ToggleSwitch1_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2ToggleSwitch1.CheckedChanged
        If Guna2ToggleSwitch1.Checked = True Then
            PasswordTextBox.UseSystemPasswordChar = False
        Else
            PasswordTextBox.UseSystemPasswordChar = True
        End If

    End Sub

    Private Sub Guna2PictureBox2_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox2.Click

    End Sub
End Class
