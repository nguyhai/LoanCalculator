<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoanCalculator
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radAmount = New System.Windows.Forms.RadioButton()
        Me.radInterest = New System.Windows.Forms.RadioButton()
        Me.radDuration = New System.Windows.Forms.RadioButton()
        Me.radMonthlyPayment = New System.Windows.Forms.RadioButton()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.txtInterest = New System.Windows.Forms.TextBox()
        Me.txtDuration = New System.Windows.Forms.TextBox()
        Me.txtMonthlyPayment = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radMonthlyPayment)
        Me.GroupBox1.Controls.Add(Me.radDuration)
        Me.GroupBox1.Controls.Add(Me.radInterest)
        Me.GroupBox1.Controls.Add(Me.radAmount)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 207)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Check Value To Calculate"
        '
        'radAmount
        '
        Me.radAmount.AutoSize = True
        Me.radAmount.Location = New System.Drawing.Point(22, 30)
        Me.radAmount.Name = "radAmount"
        Me.radAmount.Size = New System.Drawing.Size(102, 17)
        Me.radAmount.TabIndex = 0
        Me.radAmount.TabStop = True
        Me.radAmount.Text = "Amount Of Loan"
        Me.radAmount.UseVisualStyleBackColor = True
        '
        'radInterest
        '
        Me.radInterest.AutoSize = True
        Me.radInterest.Location = New System.Drawing.Point(22, 74)
        Me.radInterest.Name = "radInterest"
        Me.radInterest.Size = New System.Drawing.Size(86, 17)
        Me.radInterest.TabIndex = 1
        Me.radInterest.TabStop = True
        Me.radInterest.Text = "Interest Rate"
        Me.radInterest.UseVisualStyleBackColor = True
        '
        'radDuration
        '
        Me.radDuration.AutoSize = True
        Me.radDuration.Location = New System.Drawing.Point(22, 116)
        Me.radDuration.Name = "radDuration"
        Me.radDuration.Size = New System.Drawing.Size(104, 17)
        Me.radDuration.TabIndex = 2
        Me.radDuration.TabStop = True
        Me.radDuration.Text = "Duration of Loan"
        Me.radDuration.UseVisualStyleBackColor = True
        '
        'radMonthlyPayment
        '
        Me.radMonthlyPayment.AutoSize = True
        Me.radMonthlyPayment.Location = New System.Drawing.Point(22, 155)
        Me.radMonthlyPayment.Name = "radMonthlyPayment"
        Me.radMonthlyPayment.Size = New System.Drawing.Size(106, 17)
        Me.radMonthlyPayment.TabIndex = 3
        Me.radMonthlyPayment.TabStop = True
        Me.radMonthlyPayment.Text = "Monthly Payment"
        Me.radMonthlyPayment.UseVisualStyleBackColor = True
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(259, 51)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(100, 20)
        Me.txtAmount.TabIndex = 4
        '
        'txtInterest
        '
        Me.txtInterest.Location = New System.Drawing.Point(259, 95)
        Me.txtInterest.Name = "txtInterest"
        Me.txtInterest.Size = New System.Drawing.Size(100, 20)
        Me.txtInterest.TabIndex = 5
        '
        'txtDuration
        '
        Me.txtDuration.Location = New System.Drawing.Point(259, 135)
        Me.txtDuration.Name = "txtDuration"
        Me.txtDuration.Size = New System.Drawing.Size(100, 20)
        Me.txtDuration.TabIndex = 6
        '
        'txtMonthlyPayment
        '
        Me.txtMonthlyPayment.Location = New System.Drawing.Point(259, 176)
        Me.txtMonthlyPayment.Name = "txtMonthlyPayment"
        Me.txtMonthlyPayment.Size = New System.Drawing.Size(100, 20)
        Me.txtMonthlyPayment.TabIndex = 7
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(120, 259)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(168, 23)
        Me.btnCalculate.TabIndex = 8
        Me.btnCalculate.Text = "Calculate Value"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(120, 288)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(168, 23)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear All Values"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'frmLoanCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 337)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtMonthlyPayment)
        Me.Controls.Add(Me.txtDuration)
        Me.Controls.Add(Me.txtInterest)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmLoanCalculator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loan Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radMonthlyPayment As RadioButton
    Friend WithEvents radDuration As RadioButton
    Friend WithEvents radInterest As RadioButton
    Friend WithEvents radAmount As RadioButton
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents txtInterest As TextBox
    Friend WithEvents txtDuration As TextBox
    Friend WithEvents txtMonthlyPayment As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
End Class
