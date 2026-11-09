<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDeletePassenger
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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblPassenger = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cboPassengers
        '
        Me.cboPassengers.FormattingEnabled = True
        Me.cboPassengers.Location = New System.Drawing.Point(109, 68)
        Me.cboPassengers.Name = "cboPassengers"
        Me.cboPassengers.Size = New System.Drawing.Size(128, 24)
        Me.cboPassengers.TabIndex = 0
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(109, 139)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 35)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblPassenger
        '
        Me.lblPassenger.AutoSize = True
        Me.lblPassenger.Location = New System.Drawing.Point(27, 71)
        Me.lblPassenger.Name = "lblPassenger"
        Me.lblPassenger.Size = New System.Drawing.Size(76, 16)
        Me.lblPassenger.TabIndex = 2
        Me.lblPassenger.Text = "Passenger:"
        '
        'frmDeletePassenger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(275, 246)
        Me.Controls.Add(Me.lblPassenger)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.cboPassengers)
        Me.Name = "frmDeletePassenger"
        Me.Text = "frmDeletePassenger"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboPassengers As ComboBox
    Friend WithEvents btnExit As Button
    Friend WithEvents lblPassenger As Label
End Class
