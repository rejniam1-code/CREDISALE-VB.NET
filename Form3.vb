Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class Form3

    ' STORE CREATED ACCOUNT
    Public Shared createdUsername As String = ""
    Public Shared createdPassword As String = ""

    ' USERNAME INPUT
    Private Sub TextBox1_(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text.Length < 3 Then
            TextBox1.BackColor = Color.LightPink
        Else
            TextBox1.BackColor = Color.White
        End If

        ValidateInputs()
    End Sub

    ' PASSWORD INPUT
    Private Sub TextBox2_(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If TextBox2.Text.Length < 4 Then
            TextBox2.BackColor = Color.LightPink
        Else
            TextBox2.BackColor = Color.White
        End If

        ValidateInputs()
    End Sub

    ' VALIDATION FUNCTION
    Private Sub ValidateInputs()
        If TextBox1.Text <> "" AndAlso TextBox2.Text <> "" AndAlso
           TextBox1.Text.Length >= 3 AndAlso TextBox2.Text.Length >= 4 Then

            Button1.Enabled = True
        Else
            Button1.Enabled = False
        End If
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Enabled = False
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
    End Sub

    ' SIGN UP BUTTON
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ' SAVE ACCOUNT
        createdUsername = TextBox1.Text
        createdPassword = TextBox2.Text

        MessageBox.Show("Account Created Successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)

        TextBox1.Clear()
        TextBox2.Clear()
        Button1.Enabled = False

        ' GO TO LOGIN
        Form2.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) 

    End Sub
End Class