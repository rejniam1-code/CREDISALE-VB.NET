Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("Welcome to the System!", "System", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' LOGIN BUTTON → Go to Form2
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' EXIT BUTTON
        Application.Exit()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' SIGN UP BUTTON → Go to Form3
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        MessageBox.Show("This is the logo.", "Info")
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
        MessageBox.Show("Image clicked!", "Info")
    End Sub

End Class