' Write a program in which user specifies a value to calculate, enters three other values, and clicks on the Calculate button
' Before calculations are made, use a function to validate that radio button is checked and that the values entered into the three text
' boxes corresponding to unchecked radio buttons are valid

' Duration is in months

' These are built in functions inside of VB for calculations
' Total Monthly Payment = pmt(interest rate / 1200, duration, - amount)
' Interest Rate = 1200 * Rate(duration, monthly payment, -amount)
' Loan Amount = PV(interest rate / 1200, duration, -monthly payment)
' Duration in months = Nper(interest rate / 1200, monthly payment, -amount)

Public Class frmLoanCalculator
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtAmount.Clear()
        txtDuration.Clear()
        txtInterest.Clear()
        txtMonthlyPayment.Clear()

    End Sub
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim amount As String = txtAmount.Text
        Dim intRate As String = txtInterest.Text
        Dim duration As String = txtDuration.Text
        Dim payment As String = txtMonthlyPayment.Text

        ' Depending on what radio button is clicked, we will take 3 values and put them into the validate function

        If radAmount.Checked And Validate(intRate, duration, payment) Then
            txtAmount.Text = (PV(CDbl(intRate) / 1200, CDbl(duration), -CDbl(payment))).ToString("C2")
        ElseIf radInterest.Checked And Validate(amount, duration, payment) Then
            txtInterest.Text = (1200 * Rate(CDbl(duration), CDbl(payment), -CDbl(amount)) * 0.01).ToString("P")
        ElseIf radDuration.Checked And Validate(amount, intRate, payment) Then
            txtDuration.Text = (NPer(CDbl(intRate) / 1200, CDbl(payment), -CDbl(amount))).ToString("N0")
        ElseIf radMonthlyPayment.Checked And Validate(amount, duration, intRate) Then
            txtMonthlyPayment.Text = (Pmt(CDbl(intRate) / 1200, CDbl(duration), -CDbl(amount))).ToString("C")
        Else
            MessageBox.Show("Please correct your input", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' Validation method
    Private Function Validate(val1 As String, val2 As String, val3 As String) As Boolean
        If IsNumeric(val1) And IsNumeric(val2) And IsNumeric(val3) Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
