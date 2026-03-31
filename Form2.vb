Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Optional: clear fields when form opens
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' LOGIN BUTTON

        ' Check if empty
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MessageBox.Show("Please fill in all fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Check credentials from Form3 (created account)
        If TextBox1.Text = Form3.createdUsername AndAlso TextBox2.Text = Form3.createdPassword Then

            MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Form4.Show()
            Me.Hide()

        Else
            MessageBox.Show("Invalid Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' BACK BUTTON
        Form1.Show()
        Me.Hide()
    End Sub

    ' OPTIONAL: LIVE VALIDATION (ARRANGED TEXTBOX LOGIC)
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        ValidateLoginInputs()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        ValidateLoginInputs()
    End Sub

    ' VALIDATION FUNCTION
    Private Sub ValidateLoginInputs()
        If TextBox1.Text <> "" AndAlso TextBox2.Text <> "" Then
            Button1.Enabled = True
        Else
            Button1.Enabled = False
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        MessageBox.Show("Login Image Clicked")
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
        MessageBox.Show("Another Image Clicked")
    End Sub

End Class