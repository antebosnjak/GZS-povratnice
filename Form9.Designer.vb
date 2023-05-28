<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form9
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
        Me.ftp_radiobuton = New System.Windows.Forms.RadioButton()
        Me.rc_radiobuton = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ftp_radiobuton
        '
        Me.ftp_radiobuton.AutoSize = True
        Me.ftp_radiobuton.Location = New System.Drawing.Point(30, 47)
        Me.ftp_radiobuton.Name = "ftp_radiobuton"
        Me.ftp_radiobuton.Size = New System.Drawing.Size(45, 17)
        Me.ftp_radiobuton.TabIndex = 0
        Me.ftp_radiobuton.TabStop = True
        Me.ftp_radiobuton.Text = "FTP"
        Me.ftp_radiobuton.UseVisualStyleBackColor = True
        '
        'rc_radiobuton
        '
        Me.rc_radiobuton.AutoSize = True
        Me.rc_radiobuton.Location = New System.Drawing.Point(30, 99)
        Me.rc_radiobuton.Name = "rc_radiobuton"
        Me.rc_radiobuton.Size = New System.Drawing.Size(85, 17)
        Me.rc_radiobuton.TabIndex = 1
        Me.rc_radiobuton.TabStop = True
        Me.rc_radiobuton.Text = "ROBOCOPY"
        Me.rc_radiobuton.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(79, 152)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 32)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Potvrdi izbor"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(253, 210)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.rc_radiobuton)
        Me.Controls.Add(Me.ftp_radiobuton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form9"
        Me.ShowIcon = False
        Me.Text = "Izaberi vrstu prijenosa podataka"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ftp_radiobuton As RadioButton
    Friend WithEvents rc_radiobuton As RadioButton
    Friend WithEvents Button1 As Button
End Class
