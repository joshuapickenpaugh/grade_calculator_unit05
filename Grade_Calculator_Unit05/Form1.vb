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

        'Gets number of assignments:
        Integer.TryParse(txtNumAssignments.Text, intNumAssignments)




    End Sub

    Private Sub txtNumAssignments_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumAssignments.KeyPress

        'Allows only numbers and the backspace key:
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
                e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If

    End Sub
End Class
