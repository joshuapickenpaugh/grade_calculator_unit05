' Joshua Pickenpaugh
' September 16th, 2016
' "Grade Calculator", Unit 5 Project, CPT 432

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
        Dim dblTotalAssignmentGrade As Double

        'Gets number of assignments:
        Integer.TryParse(txtNumAssignments.Text, intNumAssignments)

        'Calls function to prompt user for individual grades and calculates 
        'average grade:
        dblTotalAssignmentGrade = PromptUserAndGetAverageGrade(intNumAssignments)

        'Calls sub procedure to process letter grade, print result:
        Call ProcessLetterGrade(dblTotalAssignmentGrade)

    End Sub

    Private Function PromptUserAndGetAverageGrade(ByVal intNA As Integer) As Double

        Dim intCounter As Integer = 0
        Dim dblSingleAssignmentGrade As Double
        Dim dblTotalAssignmentGradeInFunction As Double

        'prompts user to enter grade for each assignment in an inputbox, 
        'adds all grades together:
        Do While (intCounter < intNA)
            dblSingleAssignmentGrade = InputBox("Individual Grades",
                                    "Enter individual grade:")
            dblTotalAssignmentGradeInFunction = dblTotalAssignmentGradeInFunction + dblSingleAssignmentGrade
            intCounter = intCounter + 1
        Loop

        'Caculates average grade:
        dblTotalAssignmentGradeInFunction = dblTotalAssignmentGradeInFunction / intNA
        dblTotalAssignmentGradeInFunction = dblTotalAssignmentGradeInFunction.ToString("N1")
        Return dblTotalAssignmentGradeInFunction

    End Function
    Private Sub ProcessLetterGrade(ByVal dblTAG As Double)

        'Process letter grade, prints result in label control:
        Select Case dblTAG
            Case 90 To 100
                lblFinalGrade.Text = "The final letter grade is: A"
            Case 80 To 89.9
                lblFinalGrade.Text = "The final letter grade is: B"
            Case 70 To 79.9
                lblFinalGrade.Text = "The final letter grade is: C"
            Case 60 To 69.9
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

        'Sets focus back on the text box:
        txtNumAssignments.Focus()

    End Sub
End Class
