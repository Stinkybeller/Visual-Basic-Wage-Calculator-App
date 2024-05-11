'Program: Wage Calculator App'
'Developer: Izabella Fortunata'
'Date: 1/2/24'
'Purpose: Helps the user calculate total wage after taxes and health insurance dedections'
Public Class frmWageCalculatorApp
    'Percentage for each tax and deduction as decimals'
    Const cdecFederalTax As Decimal = 0.2135D
    Const cdecStateTax As Decimal = 0.0525D
    Const cdecHealthInsurance As Decimal = 135
    Private Sub frmWageCalculatorApp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtHourlyWage.Text = ""
        txtHoursWorked.Text = ""
        txtFederalTax.Text = ""
        txtGrossPay.Text = ""
        txtStateTax.Text = ""
        txtHealthInsurance.Text = ""
        txtNetPay.Text = ""
        txtHoursWorked.Focus()
    End Sub
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'When the user clicks the calculate button, it calculates and displays the taxes for each label'
        'Defining variables'
        Dim decHoursWorked As Decimal
        Dim decHourlyWage As Decimal
        Dim decFederalTax As Decimal
        Dim decStateTax As Decimal
        Dim decHealthInsurance As Decimal
        Dim decGrossPay As Decimal
        Dim decNetPay As Decimal

        'Did the user enter a numeric value?'
        'Converting variables'
        If (Decimal.TryParse(txtHourlyWage.Text, decNetPay) = True) Then
            If IsNumeric(txtHourlyWage.Text) Then
                decHourlyWage = Convert.ToDecimal(txtHourlyWage.Text)
                If IsNumeric(txtHoursWorked.Text) Then
                    decHoursWorked = Convert.ToDecimal(txtHoursWorked.Text)

                    'When the user selects the full time radio button and clicks calculate'
                    If radFullTime.Checked And decHoursWorked <= 39 Then
                        'Calculation, hours under 39'
                        decGrossPay = decHoursWorked * decHourlyWage
                        decFederalTax = decGrossPay * cdecFederalTax
                        decStateTax = decGrossPay * cdecStateTax
                        decHealthInsurance = decGrossPay - cdecHealthInsurance
                        decNetPay = decGrossPay - decFederalTax - decStateTax - cdecHealthInsurance

                        'Displaying the new calculated values'
                        txtGrossPay.Text = decGrossPay.ToString("C")
                        txtFederalTax.Text = decFederalTax.ToString("C")
                        txtStateTax.Text = decStateTax.ToString("C")
                        txtHealthInsurance.Text = decHealthInsurance.ToString("C")
                        txtNetPay.Text = decNetPay.ToString("C")
                    Else
                        'Calculating time and a half if user works over 40 hours'
                        decGrossPay = (40 * decHourlyWage) + (decHoursWorked - 40) * (1.5 * decHourlyWage)
                        decFederalTax = decGrossPay * cdecFederalTax
                        decStateTax = decGrossPay * cdecStateTax
                        decHealthInsurance = decGrossPay - cdecHealthInsurance
                        decNetPay = decGrossPay - decFederalTax - decStateTax - cdecHealthInsurance

                        'Displaying the values'
                        txtGrossPay.Text = decGrossPay.ToString("C")
                        txtFederalTax.Text = decFederalTax.ToString("C")
                        txtStateTax.Text = decStateTax.ToString("C")
                        txtHealthInsurance.Text = decHealthInsurance.ToString("C")
                        txtNetPay.Text = decNetPay.ToString("C")
                    End If

                    If radPartTime.Checked Then
                        'Calculation, hours under 20'
                        decGrossPay = decHoursWorked * decHourlyWage
                        decFederalTax = decGrossPay * cdecFederalTax
                        decStateTax = decGrossPay * cdecStateTax
                        decHealthInsurance = cdecHealthInsurance * 0
                        decNetPay = decGrossPay - decFederalTax - decStateTax

                        'Displaying the new calculated values'
                        txtGrossPay.Text = decGrossPay.ToString("C")
                        txtFederalTax.Text = decFederalTax.ToString("C")
                        txtStateTax.Text = decStateTax.ToString("C")
                        txtHealthInsurance.Text = decHealthInsurance.ToString("C")
                        txtNetPay.Text = decNetPay.ToString("C")

                        'If the user inputs more than 21 hours an error will appear'
                        If decHoursWorked >= 21 Then
                            MsgBox("Enter a number less than or equal to 20", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Input Error")
                            txtHourlyWage.Text = ""
                            txtHoursWorked.Text = ""
                            txtFederalTax.Text = ""
                            txtGrossPay.Text = ""
                            txtStateTax.Text = ""
                            txtHealthInsurance.Text = ""
                            txtNetPay.Text = ""
                        End If
                    End If
                End If
                If decHoursWorked < 0 Then
                    'If a negative number in this text field, an error message will display'
                    MsgBox("You entered " & decHoursWorked.ToString() & ". Enter a Positive Number", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Input Error")
                    txtHourlyWage.Text = ""
                    txtHoursWorked.Text = ""
                    txtFederalTax.Text = ""
                    txtGrossPay.Text = ""
                    txtStateTax.Text = ""
                    txtHealthInsurance.Text = ""
                    txtNetPay.Text = ""
                End If
                If decHourlyWage < 0 Then
                    'If a negative number in this text field, an error message will display'
                    MsgBox("You entered " & decHourlyWage.ToString() & ". Enter a Positive Number", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Input Error")
                    txtHourlyWage.Text = ""
                    txtHoursWorked.Text = ""
                    txtFederalTax.Text = ""
                    txtGrossPay.Text = ""
                    txtStateTax.Text = ""
                    txtHealthInsurance.Text = ""
                    txtNetPay.Text = ""
                End If
            End If
        Else
            'If nothing, a letter, or special character is entered, this message will display'
            MsgBox("Please enter a numerical value", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Input Error")
            txtHourlyWage.Text = ""
            txtHoursWorked.Text = ""
        End If
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clearing out the values'
        txtHourlyWage.Text = ""
        txtHoursWorked.Text = ""
        txtFederalTax.Text = ""
        txtGrossPay.Text = ""
        txtStateTax.Text = ""
        txtHealthInsurance.Text = ""
        txtNetPay.Text = ""
        txtHoursWorked.Clear()
    End Sub
End Class
