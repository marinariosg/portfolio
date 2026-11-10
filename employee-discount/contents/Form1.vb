Public Class Form1

    'parallel arrays
    Private arrCounty() As String
    Private arrState() As String
    Private arrIncome() As Decimal
    Private arrHouseHold() As Integer

    'number of records stored
    Private intIndex As Integer

    'validate user input and store survey data
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim strCounty As String = ""
        Dim strState As String = ""
        Dim decIncome As Decimal
        Dim intHousehold As Integer

        'validate county/state
        If cboCountyState.SelectedIndex = -1 Then
            MessageBox.Show("County/State is required.")
            cboCountyState.Focus()
            Exit Sub

        End If

        'validate income input
        If Not Decimal.TryParse(txtIncome.Text, decIncome) Then
            MessageBox.Show("Income must be numeric.")
            txtIncome.Focus()
            Exit Sub

        End If

        'validate income is greater than zero
        If decIncome <= 0 Then
            MessageBox.Show("Income must be greater than 0.")
            txtIncome.Focus()
            Exit Sub

        End If

        'validate household size
        If Not Integer.TryParse(txtHousehold.Text, intHousehold) Then
            MessageBox.Show("Household size must be numeric.")
            txtHousehold.Focus()
            Exit Sub

        End If

        If intHousehold <= 0 Then

            MessageBox.Show("Household size must be greater than 0.")
            txtHousehold.Focus()
            Exit Sub
        End If

        ' Break apart county and state from the ComboBox
        If cboCountyState.Text = "Hamilton, Ohio" Then

            strCounty = "Hamilton"
            strState = "Ohio"

        Else
            If cboCountyState.Text = "Butler, Ohio" Then

                strCounty = "Butler"
                strState = "Ohio"

            Else
                If cboCountyState.Text = "Boone, Kentucky" Then

                    strCounty = "Boone"
                    strState = "Kentucky"

                Else
                    If cboCountyState.Text = "Kenton, Kentucky" Then

                        strCounty = "Kenton"
                        strState = "Kentucky"

                    End If
                End If
            End If
        End If

        'store survey data into parallel arrays
        Load_Data_Into_Arrays(strCounty, strState, decIncome, intHousehold)
        MessageBox.Show("Survey Data Saved.")

        'clear input controls for next entry
        cboCountyState.SelectedIndex = -1
        txtIncome.Clear()
        txtHousehold.Clear()
        cboCountyState.Focus()


    End Sub

    'exit form
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
    'load survey information into parallel arrays
    Private Sub Load_Data_Into_Arrays(ByVal strCounty As String, ByVal strState As String, ByVal decIncome As Decimal, ByVal intHousehold As Integer)

        ReDim Preserve arrCounty(intIndex)
        ReDim Preserve arrState(intIndex)
        ReDim Preserve arrIncome(intIndex)
        ReDim Preserve arrHousehold(intIndex)

        arrCounty(intIndex) = strCounty
        arrState(intIndex) = strState
        arrIncome(intIndex) = decIncome
        arrHousehold(intIndex) = intHousehold

        intIndex += 1
    End Sub

    'calculate and display total households surveyed 
    Private Sub btnTotals_Click(sender As Object, e As EventArgs) Handles btnTotals.Click

        Dim intHamiltonCount As Integer
        Dim intButlerCount As Integer
        Dim intBooneCount As Integer
        Dim intKentonCount As Integer

        Dim intOhioTotal As Integer
        Dim intKentuckyTotal As Integer

        lstOutput.Items.Clear()

        If intIndex = 0 Then

            MessageBox.Show("No survey data has been entered.")
            Exit Sub

        End If

        For intArrayIndex As Integer = 0 To arrCounty.Length - 1
            Select Case arrCounty(intArrayIndex)
                Case "Hamilton"
                    intHamiltonCount += 1
                Case "Butler"
                    intButlerCount += 1
                Case "Boone"
                    intBooneCount += 1
                Case "Kenton"
                    intKentonCount += 1


            End Select

        Next

        intOhioTotal = intHamiltonCount + intButlerCount
        intKentuckyTotal = intBooneCount + intKentonCount

        lstOutput.Items.Add("Number of Households Surveyed")
        lstOutput.Items.Add("")

        lstOutput.Items.Add("Ohio:" & intOhioTotal)
        lstOutput.Items.Add(" Hamilton: " & intHamiltonCount)

        lstOutput.Items.Add(" Butler: " & intButlerCount)
        lstOutput.Items.Add("")

        lstOutput.Items.Add("Kentucky: " & intKentuckyTotal)
        lstOutput.Items.Add(" Boone: " & intBooneCount)
        lstOutput.Items.Add(" Kenton: " & intKentonCount)



    End Sub

    'calculate and display average household income
    Private Sub btnAverageIncome_CLick(sender As Object, e As EventArgs) Handles btnAverageIncome.Click

        Dim decHamiltonTotal As Decimal
        Dim decButlerTotal As Decimal
        Dim decBooneTotal As Decimal
        Dim decKentonTotal As Decimal

        Dim intHamiltonCount As Integer
        Dim intButlerCount As Integer
        Dim intBooneCount As Integer
        Dim intKentonCount As Integer

        Dim decHamiltonAverage As Decimal
        Dim decButlerAverage As Decimal
        Dim decBooneAverage As Decimal
        Dim decKentonAverage As Decimal

        Dim decOhioAverage As Decimal
        Dim decKentuckyAverage As Decimal

        lstOutput.Items.Clear()

        If intIndex = 0 Then
            MessageBox.Show("No survey data has been entered.")
            Exit Sub
        End If

        For intArrayIndex As Integer = 0 To arrCounty.Length - 1
            Select Case arrCounty(intArrayIndex)
                Case "Hamilton"
                    decHamiltonTotal += arrIncome(intArrayIndex)
                    intHamiltonCount += 1
                Case "Butler"
                    decButlerTotal += arrIncome(intArrayIndex)
                    intButlerCount += 1
                Case "Boone"
                    decBooneTotal += arrIncome(intArrayIndex)
                    intBooneCount += 1
                Case "Kenton"
                    decKentonTotal += arrIncome(intArrayIndex)
                    intKentonCount += 1

            End Select




        Next
        If intHamiltonCount > 0 Then
            decHamiltonAverage = decHamiltonTotal / intHamiltonCount
        End If
        If intButlerCount > 0 Then
            decButlerAverage = decButlerTotal / intButlerCount
        End If
        If intBooneCount > 0 Then
            decBooneAverage = decBooneTotal / intBooneCount
        End If

        If intKentonCount > 0 Then
            decKentonAverage = decKentonTotal / intKentonCount
        End If

        If (intHamiltonCount + intButlerCount) > 0 Then
            decOhioAverage = (decHamiltonTotal + decButlerTotal) / (intHamiltonCount + intButlerCount)
        End If
        If (intBooneCount + intKentonCount) > 0 Then
            decKentuckyAverage = (decBooneTotal + decKentonTotal) / (intBooneCount + intKentonCount)

        End If
        lstOutput.Items.Add("Average Household Income")
        lstOutput.Items.Add("")

        lstOutput.Items.Add("Ohio: " & decOhioAverage.ToString("C"))
        lstOutput.Items.Add(" Hamilton: " & decHamiltonAverage.ToString("C"))
        lstOutput.Items.Add(" Butler: " & decButlerAverage.ToString("C"))
        lstOutput.Items.Add("")
        lstOutput.Items.Add("Kentucky: " & decKentuckyAverage.ToString("C"))
        lstOutput.Items.Add(" Boone: " & decBooneAverage.ToString("C"))
        lstOutput.Items.Add(" Kenton: " & decKentonAverage.ToString("C"))

    End Sub
    'calculate and display poverty percentages 
    Private Sub btnPoverty_Click(Sender As Object, e As EventArgs) Handles btnPoverty.Click

        Dim intHamiltonPoverty As Integer
        Dim intButlerPoverty As Integer
        Dim intBoonePoverty As Integer
        Dim intKentonPoverty As Integer

        Dim intHamiltonCount As Integer
        Dim intButlerCount As Integer
        Dim intBooneCount As Integer
        Dim intKentonCount As Integer

        Dim decHamiltonPercent As Decimal
        Dim decButlerPercent As Decimal
        Dim decBoonePercent As Decimal
        Dim decKentonPercent As Decimal

        Dim decOhioPercent As Decimal
        Dim decKentuckyPercent As Decimal


        lstOutput.Items.Clear()
        If intIndex = 0 Then
            MessageBox.Show("No survey data has been entered.")
            Exit Sub

        End If
        For intArrayIndex As Integer = 0 To arrCounty.Length - 1
            Select Case arrCounty(intArrayIndex)

                Case "Hamilton"

                    intHamiltonCount += 1

                    If Determine_Poverty_Status(arrHouseHold(intArrayIndex),
                             arrIncome(intArrayIndex)) Then

                        intHamiltonPoverty += 1

                    End If

                Case "Butler"

                    intButlerCount += 1

                    If Determine_Poverty_Status(arrHouseHold(intArrayIndex),
                             arrIncome(intArrayIndex)) Then

                        intButlerPoverty += 1

                    End If

                Case "Boone"

                    intBooneCount += 1

                    If Determine_Poverty_Status(arrHouseHold(intArrayIndex),
                             arrIncome(intArrayIndex)) Then

                        intBoonePoverty += 1

                    End If

                Case "Kenton"

                    intKentonCount += 1

                    If Determine_Poverty_Status(arrHouseHold(intArrayIndex),
                             arrIncome(intArrayIndex)) Then

                        intKentonPoverty += 1

                    End If

            End Select

        Next
        If intHamiltonCount > 0 Then
            decHamiltonPercent = (intHamiltonPoverty / intHamiltonCount) * 100

        End If
        If intButlerCount > 0 Then
            decButlerPercent = (intButlerPoverty / intButlerCount) * 100

        End If
        If intBooneCount > 0 Then
            decBoonePercent = (intBoonePoverty / intBooneCount) * 100

        End If
        If intKentonCount > 0 Then
            decKentonPercent = (intKentonPoverty / intKentonCount) * 100

        End If
        If (intHamiltonCount + intButlerCount) > 0 Then
            decOhioPercent = ((intHamiltonPoverty + intButlerPoverty) / (intHamiltonCount + intButlerCount)) * 100
        End If
        If (intBooneCount + intKentonCount) > 0 Then
            decKentuckyPercent = ((intBoonePoverty + intKentonPoverty) / (intBooneCount + intKentonCount)) * 100

        End If

        lstOutput.Items.Add("Percent Households in Poverty")
        lstOutput.Items.Add("")
        lstOutput.Items.Add("Ohio: " & decOhioPercent.ToString("N0") & "%")
        lstOutput.Items.Add("   Hamilton: " & decHamiltonPercent.ToString("N0") & "%")
        lstOutput.Items.Add("   Butler: " & decButlerPercent.ToString("N0") & "%")

        lstOutput.Items.Add("")

        lstOutput.Items.Add("Kentucky: " & decKentuckyPercent.ToString("N0") & "%")
        lstOutput.Items.Add("   Boone: " & decBoonePercent.ToString("N0") & "%")
        lstOutput.Items.Add("   Kenton: " & decKentonPercent.ToString("N0") & "%")

    End Sub
    Private Function Determine_Poverty_Status(ByVal intHousehold As Integer, ByVal decIncome As Decimal) As Boolean
        'household size 2-3
        If intHousehold >= 2 And intHousehold <= 3 Then

            Return decIncome < 10000

            'household size 4-5

        Else
            If intHousehold >= 4 And intHousehold <= 5 Then

                Return decIncome < 25000

                'household size greater than 5
            Else
                If intHousehold > 5 Then

                    Return decIncome < 35000

                End If
            End If
        End If

        Return False

    End Function

    'clear the input controls and output list box
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        cboCountyState.SelectedIndex = -1
        txtIncome.Clear()
        txtHousehold.Clear()

        lstOutput.Items.Clear()


        cboCountyState.Focus()

    End Sub

End Class

