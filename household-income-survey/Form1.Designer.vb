<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtYears = New System.Windows.Forms.TextBox()
        Me.txtYTD = New System.Windows.Forms.TextBox()
        Me.txtToday = New System.Windows.Forms.TextBox()
        Me.grpEmployeeInfo = New System.Windows.Forms.GroupBox()
        Me.grpStatus = New System.Windows.Forms.GroupBox()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grpOutputs = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblRate = New System.Windows.Forms.Label()
        Me.lblYTDDiscount = New System.Windows.Forms.Label()
        Me.lblTodayDiscount = New System.Windows.Forms.Label()
        Me.lblBefore = New System.Windows.Forms.Label()
        Me.lblAfter = New System.Windows.Forms.Label()
        Me.btnSummary = New System.Windows.Forms.Button()
        Me.grpEmployeeInfo.SuspendLayout()
        Me.grpStatus.SuspendLayout()
        Me.grpOutputs.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(6, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name:"
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(6, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Years Employed:"
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(6, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "YTD Purchase:"
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(6, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Today's Purchase:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(166, 32)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 22)
        Me.txtName.TabIndex = 4
        '
        'txtYears
        '
        Me.txtYears.Location = New System.Drawing.Point(166, 70)
        Me.txtYears.Name = "txtYears"
        Me.txtYears.Size = New System.Drawing.Size(100, 22)
        Me.txtYears.TabIndex = 5
        '
        'txtYTD
        '
        Me.txtYTD.Location = New System.Drawing.Point(166, 106)
        Me.txtYTD.Name = "txtYTD"
        Me.txtYTD.Size = New System.Drawing.Size(100, 22)
        Me.txtYTD.TabIndex = 6
        '
        'txtToday
        '
        Me.txtToday.Location = New System.Drawing.Point(166, 141)
        Me.txtToday.Name = "txtToday"
        Me.txtToday.Size = New System.Drawing.Size(100, 22)
        Me.txtToday.TabIndex = 7
        '
        'grpEmployeeInfo
        '
        Me.grpEmployeeInfo.Controls.Add(Me.Label1)
        Me.grpEmployeeInfo.Controls.Add(Me.txtToday)
        Me.grpEmployeeInfo.Controls.Add(Me.Label2)
        Me.grpEmployeeInfo.Controls.Add(Me.txtYTD)
        Me.grpEmployeeInfo.Controls.Add(Me.Label3)
        Me.grpEmployeeInfo.Controls.Add(Me.txtYears)
        Me.grpEmployeeInfo.Controls.Add(Me.Label4)
        Me.grpEmployeeInfo.Controls.Add(Me.txtName)
        Me.grpEmployeeInfo.Location = New System.Drawing.Point(12, 12)
        Me.grpEmployeeInfo.Name = "grpEmployeeInfo"
        Me.grpEmployeeInfo.Size = New System.Drawing.Size(272, 189)
        Me.grpEmployeeInfo.TabIndex = 8
        Me.grpEmployeeInfo.TabStop = False
        Me.grpEmployeeInfo.Text = "Employee Information"
        '
        'grpStatus
        '
        Me.grpStatus.Controls.Add(Me.cboStatus)
        Me.grpStatus.Location = New System.Drawing.Point(12, 216)
        Me.grpStatus.Name = "grpStatus"
        Me.grpStatus.Size = New System.Drawing.Size(200, 100)
        Me.grpStatus.TabIndex = 9
        Me.grpStatus.TabStop = False
        Me.grpStatus.Text = "Employee Status"
        '
        'cboStatus
        '
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Items.AddRange(New Object() {"Hourly ", "Manager"})
        Me.cboStatus.Location = New System.Drawing.Point(16, 31)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(121, 24)
        Me.cboStatus.TabIndex = 0
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(12, 605)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(88, 23)
        Me.btnCalculate.TabIndex = 10
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(122, 605)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(90, 23)
        Me.btnClear.TabIndex = 11
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(232, 605)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(84, 23)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'grpOutputs
        '
        Me.grpOutputs.Controls.Add(Me.lblAfter)
        Me.grpOutputs.Controls.Add(Me.lblBefore)
        Me.grpOutputs.Controls.Add(Me.lblTodayDiscount)
        Me.grpOutputs.Controls.Add(Me.lblYTDDiscount)
        Me.grpOutputs.Controls.Add(Me.lblRate)
        Me.grpOutputs.Controls.Add(Me.Label9)
        Me.grpOutputs.Controls.Add(Me.Label8)
        Me.grpOutputs.Controls.Add(Me.Label7)
        Me.grpOutputs.Controls.Add(Me.Label6)
        Me.grpOutputs.Controls.Add(Me.Label5)
        Me.grpOutputs.Location = New System.Drawing.Point(12, 336)
        Me.grpOutputs.Name = "grpOutputs"
        Me.grpOutputs.Size = New System.Drawing.Size(272, 219)
        Me.grpOutputs.TabIndex = 13
        Me.grpOutputs.TabStop = False
        Me.grpOutputs.Text = "Employee Discount"
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Location = New System.Drawing.Point(6, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 23)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Rate:"
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Location = New System.Drawing.Point(7, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(130, 23)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "YTD Discount:"
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Location = New System.Drawing.Point(7, 107)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(130, 23)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Today's Discount:"
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Location = New System.Drawing.Point(6, 143)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(130, 23)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Total Before:"
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Location = New System.Drawing.Point(6, 178)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(130, 23)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Total After:"
        '
        'lblRate
        '
        Me.lblRate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRate.Location = New System.Drawing.Point(166, 32)
        Me.lblRate.Name = "lblRate"
        Me.lblRate.Size = New System.Drawing.Size(100, 23)
        Me.lblRate.TabIndex = 5
        '
        'lblYTDDiscount
        '
        Me.lblYTDDiscount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblYTDDiscount.Location = New System.Drawing.Point(166, 71)
        Me.lblYTDDiscount.Name = "lblYTDDiscount"
        Me.lblYTDDiscount.Size = New System.Drawing.Size(100, 23)
        Me.lblYTDDiscount.TabIndex = 6
        '
        'lblTodayDiscount
        '
        Me.lblTodayDiscount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTodayDiscount.Location = New System.Drawing.Point(166, 107)
        Me.lblTodayDiscount.Name = "lblTodayDiscount"
        Me.lblTodayDiscount.Size = New System.Drawing.Size(100, 23)
        Me.lblTodayDiscount.TabIndex = 7
        '
        'lblBefore
        '
        Me.lblBefore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBefore.Location = New System.Drawing.Point(166, 143)
        Me.lblBefore.Name = "lblBefore"
        Me.lblBefore.Size = New System.Drawing.Size(100, 23)
        Me.lblBefore.TabIndex = 8
        '
        'lblAfter
        '
        Me.lblAfter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAfter.Location = New System.Drawing.Point(166, 178)
        Me.lblAfter.Name = "lblAfter"
        Me.lblAfter.Size = New System.Drawing.Size(100, 23)
        Me.lblAfter.TabIndex = 9
        '
        'btnSummary
        '
        Me.btnSummary.Location = New System.Drawing.Point(96, 576)
        Me.btnSummary.Name = "btnSummary"
        Me.btnSummary.Size = New System.Drawing.Size(150, 23)
        Me.btnSummary.TabIndex = 14
        Me.btnSummary.Text = "Discount Summary"
        Me.btnSummary.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 640)
        Me.Controls.Add(Me.btnSummary)
        Me.Controls.Add(Me.grpOutputs)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.grpStatus)
        Me.Controls.Add(Me.grpEmployeeInfo)
        Me.Name = "Form1"
        Me.Text = "Employee Discount"
        Me.grpEmployeeInfo.ResumeLayout(False)
        Me.grpEmployeeInfo.PerformLayout()
        Me.grpStatus.ResumeLayout(False)
        Me.grpOutputs.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtYears As TextBox
    Friend WithEvents txtYTD As TextBox
    Friend WithEvents txtToday As TextBox
    Friend WithEvents grpEmployeeInfo As GroupBox
    Friend WithEvents grpStatus As GroupBox
    Friend WithEvents cboStatus As ComboBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents grpOutputs As GroupBox
    Friend WithEvents lblYTDDiscount As Label
    Friend WithEvents lblRate As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblAfter As Label
    Friend WithEvents lblBefore As Label
    Friend WithEvents lblTodayDiscount As Label
    Friend WithEvents btnSummary As Button
End Class
