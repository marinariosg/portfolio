<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPracticeMenu
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
        Me.btnFutureFlights = New System.Windows.Forms.Button()
        Me.btnPassengerFlights = New System.Windows.Forms.Button()
        Me.btnPilotFlights = New System.Windows.Forms.Button()
        Me.btnAttendantFlight = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnFutureFlights
        '
        Me.btnFutureFlights.Location = New System.Drawing.Point(52, 86)
        Me.btnFutureFlights.Name = "btnFutureFlights"
        Me.btnFutureFlights.Size = New System.Drawing.Size(178, 29)
        Me.btnFutureFlights.TabIndex = 0
        Me.btnFutureFlights.Text = "Show Future Flights"
        Me.btnFutureFlights.UseVisualStyleBackColor = True
        '
        'btnPassengerFlights
        '
        Me.btnPassengerFlights.Location = New System.Drawing.Point(52, 121)
        Me.btnPassengerFlights.Name = "btnPassengerFlights"
        Me.btnPassengerFlights.Size = New System.Drawing.Size(178, 31)
        Me.btnPassengerFlights.TabIndex = 1
        Me.btnPassengerFlights.Text = "Show Passenger Flights"
        Me.btnPassengerFlights.UseVisualStyleBackColor = True
        '
        'btnPilotFlights
        '
        Me.btnPilotFlights.Location = New System.Drawing.Point(52, 158)
        Me.btnPilotFlights.Name = "btnPilotFlights"
        Me.btnPilotFlights.Size = New System.Drawing.Size(178, 33)
        Me.btnPilotFlights.TabIndex = 2
        Me.btnPilotFlights.Text = "Show Pilot Flights"
        Me.btnPilotFlights.UseVisualStyleBackColor = True
        '
        'btnAttendantFlight
        '
        Me.btnAttendantFlight.Location = New System.Drawing.Point(52, 197)
        Me.btnAttendantFlight.Name = "btnAttendantFlight"
        Me.btnAttendantFlight.Size = New System.Drawing.Size(178, 36)
        Me.btnAttendantFlight.TabIndex = 3
        Me.btnAttendantFlight.Text = "Show Attendant Flight"
        Me.btnAttendantFlight.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(100, 344)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 31)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmPracticeMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(298, 450)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnAttendantFlight)
        Me.Controls.Add(Me.btnPilotFlights)
        Me.Controls.Add(Me.btnPassengerFlights)
        Me.Controls.Add(Me.btnFutureFlights)
        Me.Name = "frmPracticeMenu"
        Me.Text = "frmPracticeMenu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnFutureFlights As Button
    Friend WithEvents btnPassengerFlights As Button
    Friend WithEvents btnPilotFlights As Button
    Friend WithEvents btnAttendantFlight As Button
    Friend WithEvents btnExit As Button
End Class
