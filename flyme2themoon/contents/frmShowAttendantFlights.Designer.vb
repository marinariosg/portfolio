<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShowAttendantFlights
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
        Me.lstAttendantFlights = New System.Windows.Forms.ListBox()
        Me.cboAttendants = New System.Windows.Forms.ComboBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstAttendantFlights
        '
        Me.lstAttendantFlights.FormattingEnabled = True
        Me.lstAttendantFlights.ItemHeight = 16
        Me.lstAttendantFlights.Location = New System.Drawing.Point(221, 33)
        Me.lstAttendantFlights.Name = "lstAttendantFlights"
        Me.lstAttendantFlights.Size = New System.Drawing.Size(401, 644)
        Me.lstAttendantFlights.TabIndex = 0
        '
        'cboAttendants
        '
        Me.cboAttendants.FormattingEnabled = True
        Me.cboAttendants.Location = New System.Drawing.Point(12, 52)
        Me.cboAttendants.Name = "cboAttendants"
        Me.cboAttendants.Size = New System.Drawing.Size(121, 24)
        Me.cboAttendants.TabIndex = 1
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(13, 96)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(120, 29)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmShowAttendantFlights
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 769)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.cboAttendants)
        Me.Controls.Add(Me.lstAttendantFlights)
        Me.Name = "frmShowAttendantFlights"
        Me.Text = "frmShowAttendantFlights"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstAttendantFlights As ListBox
    Friend WithEvents cboAttendants As ComboBox
    Friend WithEvents btnExit As Button
End Class
