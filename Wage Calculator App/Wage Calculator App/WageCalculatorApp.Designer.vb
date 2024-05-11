<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWageCalculatorApp
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
        Me.lblHealthInsurance = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblNetPay = New System.Windows.Forms.Label()
        Me.lblStateTax = New System.Windows.Forms.Label()
        Me.lblFederalTax = New System.Windows.Forms.Label()
        Me.lblGrossPay = New System.Windows.Forms.Label()
        Me.txtHourlyWage = New System.Windows.Forms.TextBox()
        Me.lblHourlyWage = New System.Windows.Forms.Label()
        Me.txtHoursWorked = New System.Windows.Forms.TextBox()
        Me.lblHoursWorked = New System.Windows.Forms.Label()
        Me.radPartTime = New System.Windows.Forms.RadioButton()
        Me.radFullTime = New System.Windows.Forms.RadioButton()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.txtGrossPay = New System.Windows.Forms.TextBox()
        Me.txtFederalTax = New System.Windows.Forms.TextBox()
        Me.txtStateTax = New System.Windows.Forms.TextBox()
        Me.txtNetPay = New System.Windows.Forms.TextBox()
        Me.txtHealthInsurance = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblHealthInsurance
        '
        Me.lblHealthInsurance.AutoSize = True
        Me.lblHealthInsurance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHealthInsurance.Location = New System.Drawing.Point(138, 299)
        Me.lblHealthInsurance.Name = "lblHealthInsurance"
        Me.lblHealthInsurance.Size = New System.Drawing.Size(134, 19)
        Me.lblHealthInsurance.TabIndex = 37
        Me.lblHealthInsurance.Text = "Health Insurance:"
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.Window
        Me.btnClear.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(366, 406)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 35)
        Me.btnClear.TabIndex = 36
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.SystemColors.Window
        Me.btnCalculate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(96, 406)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(100, 35)
        Me.btnCalculate.TabIndex = 35
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'lblNetPay
        '
        Me.lblNetPay.AutoSize = True
        Me.lblNetPay.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNetPay.Location = New System.Drawing.Point(203, 329)
        Me.lblNetPay.Name = "lblNetPay"
        Me.lblNetPay.Size = New System.Drawing.Size(69, 19)
        Me.lblNetPay.TabIndex = 33
        Me.lblNetPay.Text = "Net Pay:"
        '
        'lblStateTax
        '
        Me.lblStateTax.AutoSize = True
        Me.lblStateTax.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStateTax.Location = New System.Drawing.Point(191, 267)
        Me.lblStateTax.Name = "lblStateTax"
        Me.lblStateTax.Size = New System.Drawing.Size(81, 19)
        Me.lblStateTax.TabIndex = 31
        Me.lblStateTax.Text = "State Tax:"
        '
        'lblFederalTax
        '
        Me.lblFederalTax.AutoSize = True
        Me.lblFederalTax.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFederalTax.Location = New System.Drawing.Point(173, 229)
        Me.lblFederalTax.Name = "lblFederalTax"
        Me.lblFederalTax.Size = New System.Drawing.Size(97, 19)
        Me.lblFederalTax.TabIndex = 29
        Me.lblFederalTax.Text = "Federal Tax:"
        '
        'lblGrossPay
        '
        Me.lblGrossPay.AutoSize = True
        Me.lblGrossPay.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrossPay.Location = New System.Drawing.Point(185, 191)
        Me.lblGrossPay.Name = "lblGrossPay"
        Me.lblGrossPay.Size = New System.Drawing.Size(85, 19)
        Me.lblGrossPay.TabIndex = 27
        Me.lblGrossPay.Text = "Gross pay:"
        '
        'txtHourlyWage
        '
        Me.txtHourlyWage.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHourlyWage.Location = New System.Drawing.Point(401, 117)
        Me.txtHourlyWage.MaxLength = 5
        Me.txtHourlyWage.Name = "txtHourlyWage"
        Me.txtHourlyWage.Size = New System.Drawing.Size(100, 27)
        Me.txtHourlyWage.TabIndex = 26
        '
        'lblHourlyWage
        '
        Me.lblHourlyWage.AutoSize = True
        Me.lblHourlyWage.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHourlyWage.Location = New System.Drawing.Point(298, 125)
        Me.lblHourlyWage.Name = "lblHourlyWage"
        Me.lblHourlyWage.Size = New System.Drawing.Size(106, 19)
        Me.lblHourlyWage.TabIndex = 25
        Me.lblHourlyWage.Text = "Hourly Wage:"
        '
        'txtHoursWorked
        '
        Me.txtHoursWorked.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoursWorked.Location = New System.Drawing.Point(177, 117)
        Me.txtHoursWorked.MaxLength = 4
        Me.txtHoursWorked.Name = "txtHoursWorked"
        Me.txtHoursWorked.Size = New System.Drawing.Size(100, 27)
        Me.txtHoursWorked.TabIndex = 24
        '
        'lblHoursWorked
        '
        Me.lblHoursWorked.AutoSize = True
        Me.lblHoursWorked.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHoursWorked.Location = New System.Drawing.Point(64, 125)
        Me.lblHoursWorked.Name = "lblHoursWorked"
        Me.lblHoursWorked.Size = New System.Drawing.Size(121, 19)
        Me.lblHoursWorked.TabIndex = 23
        Me.lblHoursWorked.Text = "Hours Worked: "
        '
        'radPartTime
        '
        Me.radPartTime.AutoSize = True
        Me.radPartTime.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radPartTime.Location = New System.Drawing.Point(283, 71)
        Me.radPartTime.Name = "radPartTime"
        Me.radPartTime.Size = New System.Drawing.Size(127, 23)
        Me.radPartTime.TabIndex = 22
        Me.radPartTime.Text = "Part-Time Job"
        Me.radPartTime.UseVisualStyleBackColor = True
        '
        'radFullTime
        '
        Me.radFullTime.AutoSize = True
        Me.radFullTime.Checked = True
        Me.radFullTime.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radFullTime.Location = New System.Drawing.Point(154, 71)
        Me.radFullTime.Name = "radFullTime"
        Me.radFullTime.Size = New System.Drawing.Size(124, 23)
        Me.radFullTime.TabIndex = 21
        Me.radFullTime.TabStop = True
        Me.radFullTime.Text = "Full-Time Job"
        Me.radFullTime.UseVisualStyleBackColor = True
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(126, 20)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(313, 39)
        Me.lblHeading.TabIndex = 20
        Me.lblHeading.Text = "Wage Calculator App"
        '
        'txtGrossPay
        '
        Me.txtGrossPay.BackColor = System.Drawing.SystemColors.Control
        Me.txtGrossPay.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtGrossPay.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGrossPay.Location = New System.Drawing.Point(275, 191)
        Me.txtGrossPay.MaxLength = 10
        Me.txtGrossPay.Name = "txtGrossPay"
        Me.txtGrossPay.Size = New System.Drawing.Size(100, 20)
        Me.txtGrossPay.TabIndex = 28
        '
        'txtFederalTax
        '
        Me.txtFederalTax.BackColor = System.Drawing.SystemColors.Control
        Me.txtFederalTax.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFederalTax.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFederalTax.Location = New System.Drawing.Point(276, 225)
        Me.txtFederalTax.MaxLength = 10
        Me.txtFederalTax.Name = "txtFederalTax"
        Me.txtFederalTax.Size = New System.Drawing.Size(100, 20)
        Me.txtFederalTax.TabIndex = 30
        '
        'txtStateTax
        '
        Me.txtStateTax.BackColor = System.Drawing.SystemColors.Control
        Me.txtStateTax.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtStateTax.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStateTax.Location = New System.Drawing.Point(275, 266)
        Me.txtStateTax.MaxLength = 10
        Me.txtStateTax.Name = "txtStateTax"
        Me.txtStateTax.Size = New System.Drawing.Size(100, 20)
        Me.txtStateTax.TabIndex = 32
        '
        'txtNetPay
        '
        Me.txtNetPay.BackColor = System.Drawing.SystemColors.Control
        Me.txtNetPay.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNetPay.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNetPay.Location = New System.Drawing.Point(275, 328)
        Me.txtNetPay.MaxLength = 10
        Me.txtNetPay.Name = "txtNetPay"
        Me.txtNetPay.Size = New System.Drawing.Size(100, 20)
        Me.txtNetPay.TabIndex = 34
        '
        'txtHealthInsurance
        '
        Me.txtHealthInsurance.BackColor = System.Drawing.SystemColors.Control
        Me.txtHealthInsurance.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtHealthInsurance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHealthInsurance.Location = New System.Drawing.Point(275, 298)
        Me.txtHealthInsurance.MaxLength = 10
        Me.txtHealthInsurance.Name = "txtHealthInsurance"
        Me.txtHealthInsurance.Size = New System.Drawing.Size(100, 20)
        Me.txtHealthInsurance.TabIndex = 38
        '
        'frmWageCalculatorApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 474)
        Me.Controls.Add(Me.txtHealthInsurance)
        Me.Controls.Add(Me.lblHealthInsurance)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtNetPay)
        Me.Controls.Add(Me.lblNetPay)
        Me.Controls.Add(Me.txtStateTax)
        Me.Controls.Add(Me.lblStateTax)
        Me.Controls.Add(Me.txtFederalTax)
        Me.Controls.Add(Me.lblFederalTax)
        Me.Controls.Add(Me.txtGrossPay)
        Me.Controls.Add(Me.lblGrossPay)
        Me.Controls.Add(Me.txtHourlyWage)
        Me.Controls.Add(Me.lblHourlyWage)
        Me.Controls.Add(Me.txtHoursWorked)
        Me.Controls.Add(Me.lblHoursWorked)
        Me.Controls.Add(Me.radPartTime)
        Me.Controls.Add(Me.radFullTime)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "frmWageCalculatorApp"
        Me.Text = "Wage Calculator App"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHealthInsurance As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblNetPay As Label
    Friend WithEvents lblStateTax As Label
    Friend WithEvents lblFederalTax As Label
    Friend WithEvents lblGrossPay As Label
    Friend WithEvents txtHourlyWage As TextBox
    Friend WithEvents lblHourlyWage As Label
    Friend WithEvents txtHoursWorked As TextBox
    Friend WithEvents lblHoursWorked As Label
    Friend WithEvents radPartTime As RadioButton
    Friend WithEvents radFullTime As RadioButton
    Friend WithEvents lblHeading As Label
    Friend WithEvents txtGrossPay As TextBox
    Friend WithEvents txtFederalTax As TextBox
    Friend WithEvents txtStateTax As TextBox
    Friend WithEvents txtNetPay As TextBox
    Friend WithEvents txtHealthInsurance As TextBox
End Class
