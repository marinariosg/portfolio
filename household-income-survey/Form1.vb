Public Class Form1
    Dim decDayTotalBefore As Decimal
    Dim decDayTotalAfter As Decimal
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        ' Declare variables
        Dim intYears As Integer
        Dim decYTD As Decimal
        Dim decToday As Decimal
        Dim decRate As Decimal
        Dim decYTDDiscount As Decimal
        Dim decDiscountAmount As Decimal
        Dim decTodayDiscount As Decimal
        Dim decTotalBefore As Decimal
        Dim decTotalAfter As Decimal

        'Get and Validate Inputs
        If txtName.Text = String.Empty Then
            MessageBox.Show("Name is required")
            txtName.Focus()
            Exit Sub
        End If

        If IsNumeric(txtYears.Text) Then
            intYears = txtYears.Text
            If (intYears > 0) Then
            Else
                MessageBox.Show("Years Employed must be greater than 0")
                txtYears.Focus()
                Exit Sub
            End If
        Else
            MessageBox.Show("Years Employed is required and must be numeric")
            txtYears.Focus()
            Exit Sub
        End If

        If IsNumeric(txtYTD.Text) Then
            decYTD = txtYTD.Text
            If decYTD >= 0 Then
            Else
                MessageBox.Show("YTD Purchases must be 0 or greater")
                txtYTD.Focus()
                Exit Sub
            End If
        Else
            MessageBox.Show("YTD Purchases is required and must be numeric")
            txtYTD.Focus()
            Exit Sub
        End If

        'Validate Today's Purchase
        If IsNumeric(txtToday.Text) Then
            decToday = txtToday.Text
            If decToday >= 0 Then
            Else
                MessageBox.Show("Today's Purchase must be 0 or greater")
                txtToday.Focus()
                Exit Sub
            End If
        Else
            MessageBox.Show("Today's Purchase is required and must be numeric")
            txtToday.Focus()
            Exit Sub
        End If
        If cboStatus.Text = "" Then
            MessageBox.Show("Employee Status is required")
            cboStatus.Focus()
            Exit Sub
        End If

        'Validate Employee Status 

        If cboStatus.Text = "Manager" Then
            If intYears <= 3 Then
                decRate = 0.2
            ElseIf intYears <= 6 Then
                decRate = 0.24
            ElseIf intYears <= 10 Then
                decRate = 0.3
            ElseIf intYears <= 15 Then
                decRate = 0.35
            Else
                decRate = 0.4
            End If
        Else
            If intYears <= 3 Then
                decRate = 0.1
            ElseIf intYears <= 6 Then
                decRate = 0.14
            ElseIf intYears <= 10 Then
                decRate = 0.2
            ElseIf intYears <= 15 Then
                decRate = 0.25
            Else
                decRate = 0.3
            End If
        End If

        'Calculations
        decYTDDiscount = decYTD * decRate
        decDiscountAmount = decToday * decRate

        If (decYTDDiscount >= 200) Then
            MessageBox.Show("Accumulated Discount is " & FormatCurrency(decYTDDiscount) & vbCr & "Maximum Discount for the Year is $200.00")
            decTodayDiscount = 0
        Else
            If (decYTDDiscount + decDiscountAmount) <= 200 Then
                decTodayDiscount = decDiscountAmount
            Else
                MessageBox.Show("Accumulated Discount is " & FormatCurrency(decYTDDiscount + decDiscountAmount) & vbCr & "Maximum Discount for the Year is $200.00")
                decTodayDiscount = 200 - decYTDDiscount
            End If
        End If

        decTotalBefore = decToday
        decTotalAfter = decToday - decTodayDiscount

        'Daily totals
        decDayTotalBefore += decTotalBefore
        decDayTotalAfter += decTotalAfter

        'Display Outputs
        lblRate.Text = decRate
        lblYTDDiscount.Text = FormatCurrency(decYTDDiscount)
        lblTodayDiscount.Text = FormatCurrency(decTodayDiscount)
        lblBefore.Text = FormatCurrency(decTotalBefore)
        lblAfter.Text = FormatCurrency(decTotalAfter)

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtName.Clear()
        txtYears.Clear()
        txtYTD.Clear()
        txtToday.Clear()
        cboStatus.Text = ""


        lblRate.Text = ""
        lblYTDDiscount.Text = ""
        lblTodayDiscount.Text = ""
        lblBefore.Text = ""
        lblAfter.Text = ""

        txtName.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnSummary_Click(sender As Object, e As EventArgs) Handles btnSummary.Click
        MessageBox.Show("Total Before Discount for the Day " & FormatCurrency(decDayTotalBefore) & vbCr &
        "Total After Discount for the Day " & FormatCurrency(decDayTotalAfter))

    End Sub
End Class
