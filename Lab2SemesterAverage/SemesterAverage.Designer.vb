<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSemesterAverageCalculator
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
        Me.components = New System.ComponentModel.Container()
        Me.lblCourse1 = New System.Windows.Forms.Label()
        Me.txtCourseGrade1 = New System.Windows.Forms.TextBox()
        Me.lblletterGrade1 = New System.Windows.Forms.Label()
        Me.lblletterGrade2 = New System.Windows.Forms.Label()
        Me.txtCourseGrade2 = New System.Windows.Forms.TextBox()
        Me.lblCourse2 = New System.Windows.Forms.Label()
        Me.lblletterGrade3 = New System.Windows.Forms.Label()
        Me.txtCourseGrade3 = New System.Windows.Forms.TextBox()
        Me.lblCourse3 = New System.Windows.Forms.Label()
        Me.lblletterGrade4 = New System.Windows.Forms.Label()
        Me.txtCourseGrade4 = New System.Windows.Forms.TextBox()
        Me.lblCourse4 = New System.Windows.Forms.Label()
        Me.lblletterGrade5 = New System.Windows.Forms.Label()
        Me.txtCourseGrade5 = New System.Windows.Forms.TextBox()
        Me.lblCourse5 = New System.Windows.Forms.Label()
        Me.lblletterGrade6 = New System.Windows.Forms.Label()
        Me.txtCourseGrade6 = New System.Windows.Forms.TextBox()
        Me.lblCourse6 = New System.Windows.Forms.Label()
        Me.lblAverageGrade = New System.Windows.Forms.Label()
        Me.lblSemester = New System.Windows.Forms.Label()
        Me.lblErrorList = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblAverageLetterGrade = New System.Windows.Forms.Label()
        Me.SemesterGradeToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'lblCourse1
        '
        Me.lblCourse1.Location = New System.Drawing.Point(26, 35)
        Me.lblCourse1.Name = "lblCourse1"
        Me.lblCourse1.Size = New System.Drawing.Size(192, 43)
        Me.lblCourse1.TabIndex = 0
        Me.lblCourse1.Text = "Course &1: "
        Me.lblCourse1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCourseGrade1
        '
        Me.txtCourseGrade1.Location = New System.Drawing.Point(215, 35)
        Me.txtCourseGrade1.Name = "txtCourseGrade1"
        Me.txtCourseGrade1.Size = New System.Drawing.Size(192, 38)
        Me.txtCourseGrade1.TabIndex = 1
        Me.txtCourseGrade1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SemesterGradeToolTip.SetToolTip(Me.txtCourseGrade1, "Please Enter Grades for Course 1")
        '
        'lblletterGrade1
        '
        Me.lblletterGrade1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblletterGrade1.Location = New System.Drawing.Point(455, 32)
        Me.lblletterGrade1.Name = "lblletterGrade1"
        Me.lblletterGrade1.Size = New System.Drawing.Size(192, 43)
        Me.lblletterGrade1.TabIndex = 2
        Me.lblletterGrade1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SemesterGradeToolTip.SetToolTip(Me.lblletterGrade1, "Grade for Course 1")
        '
        'lblletterGrade2
        '
        Me.lblletterGrade2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblletterGrade2.Location = New System.Drawing.Point(455, 99)
        Me.lblletterGrade2.Name = "lblletterGrade2"
        Me.lblletterGrade2.Size = New System.Drawing.Size(192, 43)
        Me.lblletterGrade2.TabIndex = 5
        Me.lblletterGrade2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SemesterGradeToolTip.SetToolTip(Me.lblletterGrade2, "Grade for Course 2")
        '
        'txtCourseGrade2
        '
        Me.txtCourseGrade2.Location = New System.Drawing.Point(217, 102)
        Me.txtCourseGrade2.Name = "txtCourseGrade2"
        Me.txtCourseGrade2.Size = New System.Drawing.Size(192, 38)
        Me.txtCourseGrade2.TabIndex = 4
        Me.txtCourseGrade2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SemesterGradeToolTip.SetToolTip(Me.txtCourseGrade2, "Please Enter Grades for Course 2")
        '
        'lblCourse2
        '
        Me.lblCourse2.Location = New System.Drawing.Point(26, 102)
        Me.lblCourse2.Name = "lblCourse2"
        Me.lblCourse2.Size = New System.Drawing.Size(192, 43)
        Me.lblCourse2.TabIndex = 3
        Me.lblCourse2.Text = "Course &2: "
        Me.lblCourse2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblletterGrade3
        '
        Me.lblletterGrade3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblletterGrade3.Location = New System.Drawing.Point(455, 166)
        Me.lblletterGrade3.Name = "lblletterGrade3"
        Me.lblletterGrade3.Size = New System.Drawing.Size(192, 43)
        Me.lblletterGrade3.TabIndex = 8
        Me.lblletterGrade3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SemesterGradeToolTip.SetToolTip(Me.lblletterGrade3, "Grade for Course 3")
        '
        'txtCourseGrade3
        '
        Me.txtCourseGrade3.Location = New System.Drawing.Point(219, 169)
        Me.txtCourseGrade3.Name = "txtCourseGrade3"
        Me.txtCourseGrade3.Size = New System.Drawing.Size(192, 38)
        Me.txtCourseGrade3.TabIndex = 7
        Me.txtCourseGrade3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SemesterGradeToolTip.SetToolTip(Me.txtCourseGrade3, "Please Enter Grades for Course 3")
        '
        'lblCourse3
        '
        Me.lblCourse3.Location = New System.Drawing.Point(26, 169)
        Me.lblCourse3.Name = "lblCourse3"
        Me.lblCourse3.Size = New System.Drawing.Size(192, 43)
        Me.lblCourse3.TabIndex = 6
        Me.lblCourse3.Text = "Course &3: "
        Me.lblCourse3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblletterGrade4
        '
        Me.lblletterGrade4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblletterGrade4.Location = New System.Drawing.Point(455, 233)
        Me.lblletterGrade4.Name = "lblletterGrade4"
        Me.lblletterGrade4.Size = New System.Drawing.Size(192, 43)
        Me.lblletterGrade4.TabIndex = 11
        Me.lblletterGrade4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SemesterGradeToolTip.SetToolTip(Me.lblletterGrade4, "Grade for Course 4")
        '
        'txtCourseGrade4
        '
        Me.txtCourseGrade4.Location = New System.Drawing.Point(219, 236)
        Me.txtCourseGrade4.Name = "txtCourseGrade4"
        Me.txtCourseGrade4.Size = New System.Drawing.Size(192, 38)
        Me.txtCourseGrade4.TabIndex = 10
        Me.txtCourseGrade4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SemesterGradeToolTip.SetToolTip(Me.txtCourseGrade4, "Please Enter Grades for Course 4")
        '
        'lblCourse4
        '
        Me.lblCourse4.Location = New System.Drawing.Point(26, 236)
        Me.lblCourse4.Name = "lblCourse4"
        Me.lblCourse4.Size = New System.Drawing.Size(192, 43)
        Me.lblCourse4.TabIndex = 9
        Me.lblCourse4.Text = "Course &4: "
        Me.lblCourse4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblletterGrade5
        '
        Me.lblletterGrade5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblletterGrade5.Location = New System.Drawing.Point(455, 300)
        Me.lblletterGrade5.Name = "lblletterGrade5"
        Me.lblletterGrade5.Size = New System.Drawing.Size(192, 43)
        Me.lblletterGrade5.TabIndex = 14
        Me.lblletterGrade5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SemesterGradeToolTip.SetToolTip(Me.lblletterGrade5, "Grade for Course 5")
        '
        'txtCourseGrade5
        '
        Me.txtCourseGrade5.Location = New System.Drawing.Point(219, 303)
        Me.txtCourseGrade5.Name = "txtCourseGrade5"
        Me.txtCourseGrade5.Size = New System.Drawing.Size(192, 38)
        Me.txtCourseGrade5.TabIndex = 13
        Me.txtCourseGrade5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SemesterGradeToolTip.SetToolTip(Me.txtCourseGrade5, "Please Enter Grades for Course 5")
        '
        'lblCourse5
        '
        Me.lblCourse5.Location = New System.Drawing.Point(26, 303)
        Me.lblCourse5.Name = "lblCourse5"
        Me.lblCourse5.Size = New System.Drawing.Size(192, 43)
        Me.lblCourse5.TabIndex = 12
        Me.lblCourse5.Text = "Course &5: "
        Me.lblCourse5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblletterGrade6
        '
        Me.lblletterGrade6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblletterGrade6.Location = New System.Drawing.Point(455, 367)
        Me.lblletterGrade6.Name = "lblletterGrade6"
        Me.lblletterGrade6.Size = New System.Drawing.Size(192, 43)
        Me.lblletterGrade6.TabIndex = 17
        Me.lblletterGrade6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SemesterGradeToolTip.SetToolTip(Me.lblletterGrade6, "Grade for Course 6")
        '
        'txtCourseGrade6
        '
        Me.txtCourseGrade6.Location = New System.Drawing.Point(219, 370)
        Me.txtCourseGrade6.Name = "txtCourseGrade6"
        Me.txtCourseGrade6.Size = New System.Drawing.Size(192, 38)
        Me.txtCourseGrade6.TabIndex = 16
        Me.txtCourseGrade6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SemesterGradeToolTip.SetToolTip(Me.txtCourseGrade6, "Please Enter Grades for Course 6")
        '
        'lblCourse6
        '
        Me.lblCourse6.Location = New System.Drawing.Point(26, 370)
        Me.lblCourse6.Name = "lblCourse6"
        Me.lblCourse6.Size = New System.Drawing.Size(192, 43)
        Me.lblCourse6.TabIndex = 15
        Me.lblCourse6.Text = "Course &6: "
        Me.lblCourse6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAverageGrade
        '
        Me.lblAverageGrade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAverageGrade.Location = New System.Drawing.Point(218, 436)
        Me.lblAverageGrade.Name = "lblAverageGrade"
        Me.lblAverageGrade.Size = New System.Drawing.Size(192, 43)
        Me.lblAverageGrade.TabIndex = 19
        Me.lblAverageGrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SemesterGradeToolTip.SetToolTip(Me.lblAverageGrade, "Display Overall Grade")
        '
        'lblSemester
        '
        Me.lblSemester.Location = New System.Drawing.Point(26, 437)
        Me.lblSemester.Name = "lblSemester"
        Me.lblSemester.Size = New System.Drawing.Size(192, 43)
        Me.lblSemester.TabIndex = 18
        Me.lblSemester.Text = "&Semester: "
        Me.lblSemester.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblErrorList
        '
        Me.lblErrorList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblErrorList.Location = New System.Drawing.Point(24, 504)
        Me.lblErrorList.Name = "lblErrorList"
        Me.lblErrorList.Size = New System.Drawing.Size(693, 413)
        Me.lblErrorList.TabIndex = 21
        Me.lblErrorList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SemesterGradeToolTip.SetToolTip(Me.lblErrorList, "Displays List of Errors To Enter Grade")
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(16, 969)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(218, 52)
        Me.btnCalculate.TabIndex = 22
        Me.btnCalculate.Text = "&Calculate"
        Me.SemesterGradeToolTip.SetToolTip(Me.btnCalculate, "Calulates Grades & Average based on Given Grades")
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(262, 969)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(218, 52)
        Me.btnReset.TabIndex = 23
        Me.btnReset.Text = "&Reset"
        Me.SemesterGradeToolTip.SetToolTip(Me.btnReset, "Reset the Form to Reenter Grades Again ")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(508, 969)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(218, 52)
        Me.btnExit.TabIndex = 24
        Me.btnExit.Text = "E&xit"
        Me.SemesterGradeToolTip.SetToolTip(Me.btnExit, "Click Here to Exit")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblAverageLetterGrade
        '
        Me.lblAverageLetterGrade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAverageLetterGrade.Location = New System.Drawing.Point(455, 434)
        Me.lblAverageLetterGrade.Name = "lblAverageLetterGrade"
        Me.lblAverageLetterGrade.Size = New System.Drawing.Size(192, 43)
        Me.lblAverageLetterGrade.TabIndex = 20
        Me.lblAverageLetterGrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SemesterGradeToolTip.SetToolTip(Me.lblAverageLetterGrade, "Displays Overall Letter Grade")
        '
        'SemesterGradeToolTip
        '
        Me.SemesterGradeToolTip.ToolTipTitle = "Semester Grade Calculator"
        '
        'frmSemesterAverageCalculator
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(742, 1052)
        Me.Controls.Add(Me.lblAverageLetterGrade)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblErrorList)
        Me.Controls.Add(Me.lblAverageGrade)
        Me.Controls.Add(Me.lblSemester)
        Me.Controls.Add(Me.lblletterGrade6)
        Me.Controls.Add(Me.txtCourseGrade6)
        Me.Controls.Add(Me.lblCourse6)
        Me.Controls.Add(Me.lblletterGrade5)
        Me.Controls.Add(Me.txtCourseGrade5)
        Me.Controls.Add(Me.lblCourse5)
        Me.Controls.Add(Me.lblletterGrade4)
        Me.Controls.Add(Me.txtCourseGrade4)
        Me.Controls.Add(Me.lblCourse4)
        Me.Controls.Add(Me.lblletterGrade3)
        Me.Controls.Add(Me.txtCourseGrade3)
        Me.Controls.Add(Me.lblCourse3)
        Me.Controls.Add(Me.lblletterGrade2)
        Me.Controls.Add(Me.txtCourseGrade2)
        Me.Controls.Add(Me.lblCourse2)
        Me.Controls.Add(Me.lblletterGrade1)
        Me.Controls.Add(Me.txtCourseGrade1)
        Me.Controls.Add(Me.lblCourse1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSemesterAverageCalculator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Semester Grades Average Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCourse1 As Label
    Friend WithEvents txtCourseGrade1 As TextBox
    Friend WithEvents lblletterGrade1 As Label
    Friend WithEvents lblletterGrade2 As Label
    Friend WithEvents txtCourseGrade2 As TextBox
    Friend WithEvents lblCourse2 As Label
    Friend WithEvents lblletterGrade3 As Label
    Friend WithEvents txtCourseGrade3 As TextBox
    Friend WithEvents lblCourse3 As Label
    Friend WithEvents lblletterGrade4 As Label
    Friend WithEvents txtCourseGrade4 As TextBox
    Friend WithEvents lblCourse4 As Label
    Friend WithEvents lblletterGrade5 As Label
    Friend WithEvents txtCourseGrade5 As TextBox
    Friend WithEvents lblCourse5 As Label
    Friend WithEvents lblletterGrade6 As Label
    Friend WithEvents txtCourseGrade6 As TextBox
    Friend WithEvents lblCourse6 As Label
    Friend WithEvents lblAverageGrade As Label
    Friend WithEvents lblSemester As Label
    Friend WithEvents lblErrorList As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblAverageLetterGrade As Label
    Friend WithEvents SemesterGradeToolTip As ToolTip
End Class
