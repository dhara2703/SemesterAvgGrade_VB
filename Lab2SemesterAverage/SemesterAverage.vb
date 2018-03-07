Option Strict On

''' 
''' Name:           Lab2SemesterAverage
''' Student Name:   Dhara Savaliya
''' Student ID:     100648840
''' Date:           12-Feb-2018
''' Description:    We are calulating grades based on given input If user enters invalid 
'''                 entry it displays error messages. If user enter all grades properly 
'''                 then, it calulates overall grade and letter grade. 
'''                 

Public Class frmSemesterAverageCalculator
    'Declaring Global variables 
    Dim allGrades(5) As Double
    Dim validTextInput As Double
    Dim perCourseletterGrade As String
    Dim doubleValueCheck As String
    Dim isError(5) As Integer
    Dim focusBox As Integer = 0
    Dim stdErrMsg As String = "Please ensure that what you input Is a number between 0 And 100"

    Private Sub frmSemesterAverageCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ResetForm()
    End Sub

    'Calculates grades and finds overall average
    Private Sub CalculateSum()
        Dim counterForGrades As Integer
        Dim sumOfGrades As Double = 0
        Dim averageOfGrades As Double = 0
        Dim overallletterGrade As String = String.Empty
        Const totalCourses As Integer = 6
        For counterForGrades = 0 To 5
            sumOfGrades += allGrades(counterForGrades)
        Next counterForGrades
        DisableUserInputs()
        averageOfGrades = sumOfGrades / totalCourses
        lblAverageGrade.Text = averageOfGrades.ToString("n2")
        overallletterGrade = InitializeLetterGrades(averageOfGrades, perCourseletterGrade)
        lblAverageLetterGrade.Text = overallletterGrade
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        PrintErrorsCalcGrade() 'If user input is invalid it prints errors else calculates overall grade and letter grade
    End Sub

    'Verifies the letter grade according to given grade
    Private Function InitializeLetterGrades(checkLetterGrade As Double, letterGrade As String) As String
        Select Case checkLetterGrade
            Case 90 To 100
                letterGrade = "A+"
                Return letterGrade
            Case 85 To 89
                letterGrade = "A"
                Return letterGrade
            Case 80 To 84
                letterGrade = "A-"
                Return letterGrade
            Case 77 To 79
                letterGrade = "B+"
                Return letterGrade
            Case 73 To 76
                letterGrade = "B"
                Return letterGrade
            Case 70 To 72
                letterGrade = "B-"
                Return letterGrade
            Case 67 To 69
                letterGrade = "C+"
                Return letterGrade
            Case 63 To 66
                letterGrade = "C"
                Return letterGrade
            Case 60 To 62
                letterGrade = "C-"
                Return letterGrade
            Case 57 To 59
                letterGrade = "D+"
                Return letterGrade
            Case 53 To 56
                letterGrade = "D"
                Return letterGrade
            Case 50 To 52
                letterGrade = "D+"
                Return letterGrade
            Case 0 To 49
                letterGrade = "F"
                Return letterGrade
            Case Else
                letterGrade = String.Empty
                Return letterGrade
        End Select
    End Function

    'Here it validates user input
    Private Function LoopArray(doubleValueChecking As String, identifierFlag As Integer) As Double
        If Double.TryParse(doubleValueChecking, validTextInput) Then
            perCourseletterGrade = InitializeLetterGrades(validTextInput, perCourseletterGrade)
            If perCourseletterGrade = String.Empty Then
                validTextInput = -998
                isError(identifierFlag - 1) = 1
            End If
        Else
            isError(identifierFlag - 1) = 1
            validTextInput = -999

        End If
        Return validTextInput
    End Function
    Private Sub txtCourseGrade1_LostFocus(sender As Object, e As EventArgs) Handles txtCourseGrade1.LostFocus
        allGrades(0) = LoopArray(txtCourseGrade1.Text, 1)
        If allGrades(0) = -999 Then
            If txtCourseGrade1.Text <> "" Or CStr(allGrades(0)) <> "" Then
                lblErrorList.Text = stdErrMsg
                txtCourseGrade1.SelectAll()
                txtCourseGrade1.Focus()
            End If
        ElseIf allGrades(0) = -998 Then
            isError(0) = 1
        Else
            allGrades(0) = validTextInput
            lblletterGrade1.Text = perCourseletterGrade
            isError(0) = 0
            lblErrorList.Text = ""
        End If
    End Sub

    Private Sub txtCourseGrade2_LostFocus(sender As Object, e As EventArgs) Handles txtCourseGrade2.LostFocus
        allGrades(1) = LoopArray(txtCourseGrade2.Text, 2)
        If allGrades(1) = -999 Then
            If txtCourseGrade2.Text <> "" Or CStr(allGrades(1)) <> "" Then
                lblErrorList.Text = stdErrMsg
                txtCourseGrade2.SelectAll()
                txtCourseGrade2.Focus()
            End If
        ElseIf allGrades(1) = -998 Then
            isError(1) = 1
        Else
            allGrades(1) = validTextInput
            lblletterGrade2.Text = perCourseletterGrade
            isError(1) = 0
        End If
    End Sub

    Private Sub txtCourseGrade3_LostFocus(sender As Object, e As EventArgs) Handles txtCourseGrade3.LostFocus
        allGrades(2) = LoopArray(txtCourseGrade3.Text, 3)
        If allGrades(2) = -999 Then
            If txtCourseGrade3.Text <> "" Or CStr(allGrades(2)) <> "" Then
                lblErrorList.Text = stdErrMsg
                txtCourseGrade3.SelectAll()
                txtCourseGrade3.Focus()
            End If
        ElseIf allGrades(2) = -998 Then
            isError(2) = 1
        Else
            allGrades(2) = validTextInput
            lblletterGrade3.Text = perCourseletterGrade
            isError(2) = 0
        End If

    End Sub

    Private Sub txtCourseGrade4_LostFocus(sender As Object, e As EventArgs) Handles txtCourseGrade4.LostFocus
        allGrades(3) = LoopArray(txtCourseGrade4.Text, 4)
        If allGrades(3) = -999 Then
            If txtCourseGrade4.Text <> "" Or CStr(allGrades(3)) <> "" Then
                lblErrorList.Text = stdErrMsg
                txtCourseGrade4.SelectAll()
                txtCourseGrade4.Focus()
            End If
        ElseIf allGrades(3) = -998 Then
            isError(3) = 1
        Else
            allGrades(3) = validTextInput
            lblletterGrade4.Text = perCourseletterGrade
            isError(3) = 0
        End If
    End Sub

    Private Sub txtCourseGrade5_LostFocus(sender As Object, e As EventArgs) Handles txtCourseGrade5.LostFocus
        allGrades(4) = LoopArray(txtCourseGrade5.Text, 5)
        If allGrades(4) = -999 Then
            If txtCourseGrade5.Text <> "" Or CStr(allGrades(4)) <> "" Then
                lblErrorList.Text = stdErrMsg
                txtCourseGrade5.SelectAll()
                txtCourseGrade5.Focus()
            End If
        ElseIf allGrades(4) = -998 Then
            isError(4) = 1
        Else
            allGrades(4) = validTextInput
            lblletterGrade5.Text = perCourseletterGrade
            isError(4) = 0
        End If
    End Sub

    Private Sub txtCourseGrade6_LostFocus(sender As Object, e As EventArgs) Handles txtCourseGrade6.LostFocus
        allGrades(5) = LoopArray(txtCourseGrade6.Text, 6)
        If allGrades(5) = -999 Then
            If txtCourseGrade6.Text <> "" Or CStr(allGrades(5)) <> "" Then
                lblErrorList.Text = stdErrMsg
                txtCourseGrade6.SelectAll()
                txtCourseGrade6.Focus()
            End If
        ElseIf allGrades(5) = -998 Then
            isError(5) = 1
        Else
            allGrades(5) = validTextInput
            lblletterGrade6.Text = perCourseletterGrade
            isError(5) = 0
        End If
    End Sub

    'If user clicks calulate button it will disable all input controls
    Private Sub DisableUserInputs()
        txtCourseGrade1.ReadOnly = True
        txtCourseGrade2.ReadOnly = True
        txtCourseGrade3.ReadOnly = True
        txtCourseGrade4.ReadOnly = True
        txtCourseGrade5.ReadOnly = True
        txtCourseGrade6.ReadOnly = True
        btnCalculate.Enabled = False
    End Sub

    ' It resets form
    Private Sub ResetForm()
        txtCourseGrade1.ReadOnly = False
        txtCourseGrade2.ReadOnly = False
        txtCourseGrade3.ReadOnly = False
        txtCourseGrade4.ReadOnly = False
        txtCourseGrade5.ReadOnly = False
        txtCourseGrade6.ReadOnly = False
        btnCalculate.Enabled = True
        txtCourseGrade1.Text = ""
        lblletterGrade1.Text = ""
        txtCourseGrade2.Text = ""
        lblletterGrade2.Text = ""
        txtCourseGrade3.Text = ""
        lblletterGrade3.Text = ""
        txtCourseGrade4.Text = ""
        lblletterGrade4.Text = ""
        txtCourseGrade5.Text = ""
        lblletterGrade5.Text = ""
        txtCourseGrade6.Text = ""
        lblletterGrade6.Text = ""
        lblAverageGrade.Text = ""
        lblAverageLetterGrade.Text = ""
        lblErrorList.Text = ""
        txtCourseGrade1.Focus()
    End Sub

    'It prints errors and calculates sum
    Private Sub PrintErrorsCalcGrade()
        lblErrorList.Text = ""
        For counter As Integer = 0 To 5
            If isError(counter) = 1 Then
                If focusBox = 0 Then focusBox = counter + 1
                lblErrorList.Text &= "Please ensure that your input in Course" & counter + 1 & " is a number between 0 and 100!" + vbCrLf
            End If
        Next
        If focusBox > 0 Then
            setFocusToFirstBox(focusBox)
        Else
            CalculateSum()
        End If
    End Sub

    'It sets focus on offender
    Private Sub setFocusToFirstBox(txtboxnumber As Integer)
        Select Case txtboxnumber
            Case 1
                focusBox = 0
                txtCourseGrade1.SelectAll()
                txtCourseGrade1.Focus()
            Case 2
                focusBox = 0
                txtCourseGrade2.SelectAll()
                txtCourseGrade2.Focus()
            Case 3
                focusBox = 0
                txtCourseGrade3.SelectAll()
                txtCourseGrade3.Focus()
            Case 4
                focusBox = 0
                txtCourseGrade4.SelectAll()
                txtCourseGrade4.Focus()
            Case 5
                focusBox = 0
                txtCourseGrade5.SelectAll()
                txtCourseGrade5.Focus()
            Case 6
                focusBox = 0
                txtCourseGrade6.SelectAll()
                txtCourseGrade6.Focus()
            Case Else
                CalculateSum()
        End Select
    End Sub
End Class
