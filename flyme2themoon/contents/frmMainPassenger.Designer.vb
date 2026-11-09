<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainPassenger
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
        Me.btnAddPassenger = New System.Windows.Forms.Button()
        Me.btnUpdatePassenger = New System.Windows.Forms.Button()
        Me.btnDeletePassenger = New System.Windows.Forms.Button()
        Me.btnShowPassenger = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAddPassenger
        '
        Me.btnAddPassenger.Location = New System.Drawing.Point(12, 147)
        Me.btnAddPassenger.Name = "btnAddPassenger"
        Me.btnAddPassenger.Size = New System.Drawing.Size(166, 38)
        Me.btnAddPassenger.TabIndex = 0
        Me.btnAddPassenger.Text = "Add Passenger"
        Me.btnAddPassenger.UseVisualStyleBackColor = True
        '
        'btnUpdatePassenger
        '
        Me.btnUpdatePassenger.Location = New System.Drawing.Point(184, 147)
        Me.btnUpdatePassenger.Name = "btnUpdatePassenger"
        Me.btnUpdatePassenger.Size = New System.Drawing.Size(166, 38)
        Me.btnUpdatePassenger.TabIndex = 1
        Me.btnUpdatePassenger.Text = "Update Passenger "
        Me.btnUpdatePassenger.UseVisualStyleBackColor = True
        '
        'btnDeletePassenger
        '
        Me.btnDeletePassenger.Location = New System.Drawing.Point(356, 147)
        Me.btnDeletePassenger.Name = "btnDeletePassenger"
        Me.btnDeletePassenger.Size = New System.Drawing.Size(166, 38)
        Me.btnDeletePassenger.TabIndex = 2
        Me.btnDeletePassenger.Text = "Delete Passenger"
        Me.btnDeletePassenger.UseVisualStyleBackColor = True
        '
        'btnShowPassenger
        '
        Me.btnShowPassenger.Location = New System.Drawing.Point(528, 147)
        Me.btnShowPassenger.Name = "btnShowPassenger"
        Me.btnShowPassenger.Size = New System.Drawing.Size(166, 38)
        Me.btnShowPassenger.TabIndex = 3
        Me.btnShowPassenger.Text = "Show Passenger "
        Me.btnShowPassenger.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(700, 147)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(166, 38)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit "
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMainPassenger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(918, 271)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnShowPassenger)
        Me.Controls.Add(Me.btnDeletePassenger)
        Me.Controls.Add(Me.btnUpdatePassenger)
        Me.Controls.Add(Me.btnAddPassenger)
        Me.Name = "frmMainPassenger"
        Me.Text = "frmMainPassenger"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAddPassenger As Button
    Friend WithEvents btnUpdatePassenger As Button
    Friend WithEvents btnDeletePassenger As Button
    Friend WithEvents btnShowPassenger As Button
    Friend WithEvents btnExit As Button
End Class
