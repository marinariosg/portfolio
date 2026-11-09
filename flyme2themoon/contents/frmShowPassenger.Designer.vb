<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShowPassenger
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
        Me.lstPassengers = New System.Windows.Forms.ListBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstPassengers
        '
        Me.lstPassengers.FormattingEnabled = True
        Me.lstPassengers.ItemHeight = 16
        Me.lstPassengers.Location = New System.Drawing.Point(46, 12)
        Me.lstPassengers.Name = "lstPassengers"
        Me.lstPassengers.Size = New System.Drawing.Size(413, 596)
        Me.lstPassengers.TabIndex = 0
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(216, 636)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 46)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmShowPassenger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(539, 707)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lstPassengers)
        Me.Name = "frmShowPassenger"
        Me.Text = "frmShowPassenger"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstPassengers As ListBox
    Friend WithEvents btnExit As Button
End Class
