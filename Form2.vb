'Author:    Robert Zeelie
'Version:   1.0.0

'A small Windows Form Application that accepts user input and prints out a greeting to the user. The first form is used to give the user instructions before entering the info on the next form

Imports System.Text.RegularExpressions

Public Class Form2
    'declare the variables that will be used
    Dim Title As String
    Dim FirstName As String
    Dim LastName As String

    Private Sub MrRadioBtn_CheckedChanged(sender As Object, e As EventArgs) Handles MrRadioBtn.CheckedChanged
        'radio button used to set title of user to Mr
        Title = ("Mr. ")
    End Sub

    Private Sub MrsRadioBtn_CheckedChanged(sender As Object, e As EventArgs) Handles MrsRadioBtn.CheckedChanged
        'radio button used to set title of user to Mrs
        Title = ("Mrs. ")
    End Sub

    Private Sub MissRadioBtn_CheckedChanged(sender As Object, e As EventArgs) Handles MissRadioBtn.CheckedChanged
        'radio button used to set title of user to Miss
        Title = ("Miss. ")
    End Sub

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        'cancel button to exit form
        Me.Close()
    End Sub

    Private Sub SubmitBtn_Click(sender As Object, e As EventArgs) Handles SubmitBtn.Click
        'This is the submit button that checks if there is input in the boxs then prints out the users information and then closes the app
        If Not (String.IsNullOrWhiteSpace(FirstName) AndAlso String.IsNullOrWhiteSpace(LastName)) Then
            MessageBox.Show("Welcome " & Title & FirstName & LastName & vbNewLine & vbNewLine & "Thank you for filling in your information! It has been processed and I would like to thank you for using my Application!" & vbNewLine & vbNewLine & vbNewLine & vbNewLine & vbNewLine & "Robert Zeelie" & vbTab & "version 1.0.0")
            Me.Close()
        Else
            MessageBox.Show("Please enter your name!")
        End If
    End Sub





    Private Sub FNameBox_TextChanged(sender As Object, e As EventArgs) Handles FNameBox.TextChanged
        'check if more than 10 characters entered
        If (FNameBox.Text.Length > 10) Then
            'display warning and remove letter
            MessageBox.Show("**WARNING**" & vbNewLine & vbNewLine & "Only 10 characters allowed!")
            FNameBox.Text = FNameBox.Text.Substring(0, FNameBox.Text.Length - 1)
        End If

        'Creat temp variable
        Dim TempVal As String

        If (FNameBox.Text.Length < 2) Then
            'if statment to save the last thing entered in textbox to temp
            TempVal = FNameBox.Text
        Else
            TempVal = FNameBox.Text.Substring(FNameBox.Text.Length - 1)
        End If

        'if statement to check if its not a letter
        If Regex.IsMatch(TempVal, "^[0-9]+$") Then
            'if it is warn user and delete last input
            MessageBox.Show("Please only use Letters!")
            FNameBox.Text = FNameBox.Text.Substring(0, FNameBox.Text.Length - 1)
        End If

        'save text from first name box in variable
        FirstName = (FNameBox.Text & " ")
    End Sub

    Private Sub LNameBox_TextChanged(sender As Object, e As EventArgs) Handles LNameBox.TextChanged
        'check if more than 10 characters entered
        If (LNameBox.Text.Length > 10) Then
            'display warning and remove letter
            MessageBox.Show("**WARNING**" & vbNewLine & vbNewLine & "Only 10 characters allowed!")
            LNameBox.Text = LNameBox.Text.Substring(0, LNameBox.Text.Length - 1)
        End If

        'Creat temp variable
        Dim TempVal As String

        'if statment to save the last thing entered in textbox to temp
        If (LNameBox.Text.Length < 2) Then
            TempVal = LNameBox.Text
        Else
            TempVal = LNameBox.Text.Substring(LNameBox.Text.Length - 1)
        End If

        'if statement to check if its not a letter
        If Regex.IsMatch(TempVal, "^[0-9]+$") Then
            'if it is warn user and delete last input
            MessageBox.Show("Please only use Letters!")
            LNameBox.Text = LNameBox.Text.Substring(0, LNameBox.Text.Length - 1)
        End If

        'save text from last name box in variable
        LastName = (LNameBox.Text & ",")
    End Sub
End Class