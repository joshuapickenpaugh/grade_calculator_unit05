<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtNumAssignments = New System.Windows.Forms.TextBox()
        Me.btnEnterGrades = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblFinalGrade = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtNumAssignments
        '
        Me.txtNumAssignments.Location = New System.Drawing.Point(12, 28)
        Me.txtNumAssignments.Name = "txtNumAssignments"
        Me.txtNumAssignments.Size = New System.Drawing.Size(196, 20)
        Me.txtNumAssignments.TabIndex = 1
        Me.txtNumAssignments.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnEnterGrades
        '
        Me.btnEnterGrades.Location = New System.Drawing.Point(12, 52)
        Me.btnEnterGrades.Name = "btnEnterGrades"
        Me.btnEnterGrades.Size = New System.Drawing.Size(196, 40)
        Me.btnEnterGrades.TabIndex = 2
        Me.btnEnterGrades.Text = "&Enter Grades"
        Me.btnEnterGrades.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(51, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter # of assignments:"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(13, 242)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(196, 33)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblFinalGrade
        '
        Me.lblFinalGrade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFinalGrade.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinalGrade.Location = New System.Drawing.Point(12, 96)
        Me.lblFinalGrade.Name = "lblFinalGrade"
        Me.lblFinalGrade.Size = New System.Drawing.Size(196, 105)
        Me.lblFinalGrade.TabIndex = 4
        Me.lblFinalGrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(13, 205)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(196, 33)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(220, 286)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblFinalGrade)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnEnterGrades)
        Me.Controls.Add(Me.txtNumAssignments)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Grade Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNumAssignments As TextBox
    Friend WithEvents btnEnterGrades As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents lblFinalGrade As Label
    Friend WithEvents btnClear As Button
End Class
