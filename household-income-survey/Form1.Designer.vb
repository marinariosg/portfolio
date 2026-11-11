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
        Me.lblCountyState = New System.Windows.Forms.Label()
        Me.cboCountyState = New System.Windows.Forms.ComboBox()
        Me.lblIncome = New System.Windows.Forms.Label()
        Me.lblHousehold = New System.Windows.Forms.Label()
        Me.txtIncome = New System.Windows.Forms.TextBox()
        Me.txtHousehold = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lstOutput = New System.Windows.Forms.ListBox()
        Me.btnTotals = New System.Windows.Forms.Button()
        Me.btnAverageIncome = New System.Windows.Forms.Button()
        Me.btnPoverty = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblCountyState
        '
        Me.lblCountyState.AutoSize = True
        Me.lblCountyState.Location = New System.Drawing.Point(23, 53)
        Me.lblCountyState.Name = "lblCountyState"
        Me.lblCountyState.Size = New System.Drawing.Size(86, 16)
        Me.lblCountyState.TabIndex = 0
        Me.lblCountyState.Text = "County/State:"
        '
        'cboCountyState
        '
        Me.cboCountyState.FormattingEnabled = True
        Me.cboCountyState.Items.AddRange(New Object() {"Hamilton, Ohio", "Butler, Ohio", "Boone, Kentucky", "Kenton, Kentucky"})
        Me.cboCountyState.Location = New System.Drawing.Point(255, 45)
        Me.cboCountyState.Name = "cboCountyState"
        Me.cboCountyState.Size = New System.Drawing.Size(145, 24)
        Me.cboCountyState.TabIndex = 1
        '
        'lblIncome
        '
        Me.lblIncome.AutoSize = True
        Me.lblIncome.Location = New System.Drawing.Point(23, 84)
        Me.lblIncome.Name = "lblIncome"
        Me.lblIncome.Size = New System.Drawing.Size(165, 16)
        Me.lblIncome.TabIndex = 2
        Me.lblIncome.Text = "Household Yearly Income:"
        '
        'lblHousehold
        '
        Me.lblHousehold.AutoSize = True
        Me.lblHousehold.Location = New System.Drawing.Point(23, 117)
        Me.lblHousehold.Name = "lblHousehold"
        Me.lblHousehold.Size = New System.Drawing.Size(140, 16)
        Me.lblHousehold.TabIndex = 3
        Me.lblHousehold.Text = "Number in Household:"
        '
        'txtIncome
        '
        Me.txtIncome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIncome.Location = New System.Drawing.Point(276, 84)
        Me.txtIncome.Name = "txtIncome"
        Me.txtIncome.Size = New System.Drawing.Size(124, 22)
        Me.txtIncome.TabIndex = 4
        '
        'txtHousehold
        '
        Me.txtHousehold.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHousehold.Location = New System.Drawing.Point(276, 117)
        Me.txtHousehold.Name = "txtHousehold"
        Me.txtHousehold.Size = New System.Drawing.Size(124, 22)
        Me.txtHousehold.TabIndex = 5
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(262, 156)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(138, 33)
        Me.btnSubmit.TabIndex = 6
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'lstOutput
        '
        Me.lstOutput.FormattingEnabled = True
        Me.lstOutput.ItemHeight = 16
        Me.lstOutput.Location = New System.Drawing.Point(12, 207)
        Me.lstOutput.Name = "lstOutput"
        Me.lstOutput.Size = New System.Drawing.Size(695, 420)
        Me.lstOutput.TabIndex = 7
        '
        'btnTotals
        '
        Me.btnTotals.Location = New System.Drawing.Point(13, 688)
        Me.btnTotals.Name = "btnTotals"
        Me.btnTotals.Size = New System.Drawing.Size(231, 46)
        Me.btnTotals.TabIndex = 8
        Me.btnTotals.Text = "Total Households Surveyed"
        Me.btnTotals.UseVisualStyleBackColor = True
        '
        'btnAverageIncome
        '
        Me.btnAverageIncome.Location = New System.Drawing.Point(13, 636)
        Me.btnAverageIncome.Name = "btnAverageIncome"
        Me.btnAverageIncome.Size = New System.Drawing.Size(231, 46)
        Me.btnAverageIncome.TabIndex = 9
        Me.btnAverageIncome.Text = "Average Income"
        Me.btnAverageIncome.UseVisualStyleBackColor = True
        '
        'btnPoverty
        '
        Me.btnPoverty.Location = New System.Drawing.Point(12, 740)
        Me.btnPoverty.Name = "btnPoverty"
        Me.btnPoverty.Size = New System.Drawing.Size(232, 47)
        Me.btnPoverty.TabIndex = 10
        Me.btnPoverty.Text = "Percent Households in Poverty"
        Me.btnPoverty.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(298, 776)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(102, 34)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(301, 733)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(99, 30)
        Me.btnClear.TabIndex = 12
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(719, 843)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnPoverty)
        Me.Controls.Add(Me.btnAverageIncome)
        Me.Controls.Add(Me.btnTotals)
        Me.Controls.Add(Me.lstOutput)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtHousehold)
        Me.Controls.Add(Me.txtIncome)
        Me.Controls.Add(Me.lblHousehold)
        Me.Controls.Add(Me.lblIncome)
        Me.Controls.Add(Me.cboCountyState)
        Me.Controls.Add(Me.lblCountyState)
        Me.Name = "Form1"
        Me.Text = "Household Income Survey"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCountyState As Label
    Friend WithEvents cboCountyState As ComboBox
    Friend WithEvents lblIncome As Label
    Friend WithEvents lblHousehold As Label
    Friend WithEvents txtIncome As TextBox
    Friend WithEvents txtHousehold As TextBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents lstOutput As ListBox
    Friend WithEvents btnTotals As Button
    Friend WithEvents btnAverageIncome As Button
    Friend WithEvents btnPoverty As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnClear As Button
End Class
