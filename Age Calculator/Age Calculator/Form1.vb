Public Class Form1
    ' Purpose: To calculate the age of the user
    ' Date: 12 February 2024
    ' Author: Ihsaan Ifzal
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' This button executes the code to read in the user's name and birthday

        Dim strName As String = txtName.Text
        ' This declares the variable that will handle the user's name

        dtpToday.Value = DateTime.Now
        ' This will display today's date in the DateTimePicker object

        Dim dateAge As Integer = DateDiff(DateInterval.Year, dtpBirthday.Value, dtpToday.Value)
        ' This declares dateAge as a variable to handle the age of the user
        ' The line also finds the difference between the two dates displayed in the two DateTimePicker objects
        ' It returns the difference in years

        If String.IsNullOrEmpty(strName) Then
            ' This if statement checks if the user's name has not been entered
            MsgBox("Please enter your name. This field is required.")
            txtName.Focus()
            Return
            ' If the user's name has not been entered a message box is opened and returns a warning
            ' The rest of the code below will be skipped
        End If
        ' If the user's name has been entered then the if statement is skipped and the message box is not opened

        If dtpToday.Value < dtpBirthday.Value.AddYears(dateAge) Then
            ' This if statement checks if the user's birthday has not passed
            dateAge -= 1
            'If the user's birthday has not passed then the dateAge variable is subtracted by 1
        End If
        ' If the user's birthday has passed then the if statement is skipped and the dateAge variable remains the same

        MsgBox(strName & " you are " & dateAge & " years old.")
        ' This opens a message box and returns the user's name and age
    End Sub
End Class
