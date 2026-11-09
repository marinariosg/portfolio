<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShowPassengerFlights
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
        Me.cboPassengers = New System.Windows.Forms.ComboBox()
        Me.lstPassengerFlights = New System.Windows.Forms.ListBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cboPassengers
        '
        Me.cboPassengers.FormattingEnabled = True
        Me.cboPassengers.Location = New System.Drawing.Point(12, 58)
        Me.cboPassengers.Name = "cboPassengers"
        Me.cboPassengers.Size = New System.Drawing.Size(121, 24)
        Me.cboPassengers.TabIndex = 0
        '
        'lstPassengerFlights
        '
        Me.lstPassengerFlights.FormattingEnabled = True
        Me.lstPassengerFlights.ItemHeight = 16
        Me.lstPassengerFlights.Location = New System.Drawing.Point(218, 35)
        Me.lstPassengerFlights.Name = "lstPassengerFlights"
        Me.lstPassengerFlights.Size = New System.Drawing.Size(402, 644)
        Me.lstPassengerFlights.TabIndex = 1
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(12, 104)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(121, 37)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmShowPassengerFlights
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 768)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lstPassengerFlights)
        Me.Controls.Add(Me.cboPassengers)
        Me.Name = "frmShowPassengerFlights"
        Me.Text = "frmShowPassengerFlights"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cboPassengers As ComboBox
    Friend WithEvents lstPassengerFlights As ListBox
    Friend WithEvents btnExit As Button
End Class
