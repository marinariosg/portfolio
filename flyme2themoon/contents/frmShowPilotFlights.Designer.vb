<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShowPilotFlights
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
        Me.cboPilots = New System.Windows.Forms.ComboBox()
        Me.lstPilotFlights = New System.Windows.Forms.ListBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cboPilots
        '
        Me.cboPilots.FormattingEnabled = True
        Me.cboPilots.Location = New System.Drawing.Point(12, 61)
        Me.cboPilots.Name = "cboPilots"
        Me.cboPilots.Size = New System.Drawing.Size(121, 24)
        Me.cboPilots.TabIndex = 0
        '
        'lstPilotFlights
        '
        Me.lstPilotFlights.FormattingEnabled = True
        Me.lstPilotFlights.ItemHeight = 16
        Me.lstPilotFlights.Location = New System.Drawing.Point(218, 35)
        Me.lstPilotFlights.Name = "lstPilotFlights"
        Me.lstPilotFlights.Size = New System.Drawing.Size(403, 644)
        Me.lstPilotFlights.TabIndex = 1
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(13, 101)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(121, 29)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmShowPilotFlights
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 768)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lstPilotFlights)
        Me.Controls.Add(Me.cboPilots)
        Me.Name = "frmShowPilotFlights"
        Me.Text = "frmShowPilotFlights"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cboPilots As ComboBox
    Friend WithEvents lstPilotFlights As ListBox
    Friend WithEvents btnExit As Button
End Class
