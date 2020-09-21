'Author:    Robert Zeelie
'Version:   1.0.0

'A small Windows Form Application that accepts user input and prints out a greeting to the user. The first form is used to give the user instructions before entering the info on the next form

Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ProceedBtn_Click(sender As Object, e As EventArgs) Handles ProceedBtn.Click
        'proceed button to display the next form and close current form
        Form2.Show()
        Me.Close()
    End Sub
End Class
