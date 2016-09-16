Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'Closes the app:
        Me.Close()

    End Sub

    Private Sub btnEnterGrades_Click(sender As Object, e As EventArgs) Handles btnEnterGrades.Click
        'Calculates total grade by prompting user to enter number of assignments, 
        'entering individual grades for those assignments, and printing result in 
        'the label.

        'Declares variables:
        Dim intNumAssignments As Integer
        Dim dblSingleAssignmentGrade As Double
        Dim dblTotalAssignmentGrade As Double
        Dim intCounter As Integer = 0

        'Gets number of assignments:
        Integer.TryParse(txtNumAssignments.Text, intNumAssignments)

        'prompts user to enter grade for each assignment in an inputbox, 
        'adds all grades together:
        Do While (intCounter < intNumAssignments)
            dblSingleAssignmentGrade = InputBox("Individual Grades",
                                                "Enter individual grade:")
            dblTotalAssignmentGrade = dblTotalAssignmentGrade + dblSingleAssignmentGrade
            intCounter = intCounter + 1
        Loop

        'Caculates average grade:
        dblTotalAssignmentGrade = dblTotalAssignmentGrade / intNumAssignments
        dblTotalAssignmentGrade = dblTotalAssignmentGrade.ToString("N1")

        'Process letter grade, prints result in label control:
        Select Case dblTotalAssignmentGrade
            Case 90 To 100
                lblFinalGrade.Text = "The final letter grade is: A"
            Case 80 To 89.9
                lblFinalGrade.Text = "The final letter grade is: B"
            Case 70 To 70.9
                lblFinalGrade.Text = "The final letter grade is: C"
            Case 60 To 60.9
                lblFinalGrade.Text = "The final letter grade is: D"
            Case < 60
                lblFinalGrade.Text = "You failed this class with a grade of: F"
        End Select

    End Sub

    Private Sub txtNumAssignments_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumAssignments.KeyPress

        'Validation: Allows only numbers and the backspace key:
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
                e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        'Clears the text boxes and labels for another entry:
        txtNumAssignments.Text = ""
        lblFinalGrade.Text = ""

    End Sub
End Class
