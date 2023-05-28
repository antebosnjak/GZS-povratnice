<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Me.salji_buton = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.host_textbox = New System.Windows.Forms.TextBox()
        Me.password_textbox = New System.Windows.Forms.TextBox()
        Me.test_buton = New System.Windows.Forms.Button()
        Me.username_textbox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.google_drive_checkbox = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.port_textbox = New System.Windows.Forms.TextBox()
        Me.grupa_textbox = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.fingerprint_textbox = New System.Windows.Forms.TextBox()
        Me.fingerprint_label = New System.Windows.Forms.Label()
        Me.sftp_checkbox = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'salji_buton
        '
        Me.salji_buton.Location = New System.Drawing.Point(24, 398)
        Me.salji_buton.Name = "salji_buton"
        Me.salji_buton.Size = New System.Drawing.Size(258, 36)
        Me.salji_buton.TabIndex = 0
        Me.salji_buton.Text = "Šalji dnevne podatke na server"
        Me.salji_buton.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(24, 453)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(259, 28)
        Me.ProgressBar1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(144, 380)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "%"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Ftp hostname:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Ftp password:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 225)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Ftp port:"
        '
        'host_textbox
        '
        Me.host_textbox.Location = New System.Drawing.Point(123, 112)
        Me.host_textbox.Name = "host_textbox"
        Me.host_textbox.Size = New System.Drawing.Size(159, 20)
        Me.host_textbox.TabIndex = 6
        '
        'password_textbox
        '
        Me.password_textbox.Location = New System.Drawing.Point(123, 186)
        Me.password_textbox.Name = "password_textbox"
        Me.password_textbox.Size = New System.Drawing.Size(159, 20)
        Me.password_textbox.TabIndex = 7
        Me.password_textbox.UseSystemPasswordChar = True
        '
        'test_buton
        '
        Me.test_buton.Location = New System.Drawing.Point(123, 324)
        Me.test_buton.Name = "test_buton"
        Me.test_buton.Size = New System.Drawing.Size(159, 36)
        Me.test_buton.TabIndex = 9
        Me.test_buton.Text = "Test veze"
        Me.test_buton.UseVisualStyleBackColor = True
        '
        'username_textbox
        '
        Me.username_textbox.Location = New System.Drawing.Point(124, 148)
        Me.username_textbox.Name = "username_textbox"
        Me.username_textbox.Size = New System.Drawing.Size(159, 20)
        Me.username_textbox.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 151)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Ftp username:"
        '
        'google_drive_checkbox
        '
        Me.google_drive_checkbox.AutoSize = True
        Me.google_drive_checkbox.Location = New System.Drawing.Point(123, 76)
        Me.google_drive_checkbox.Name = "google_drive_checkbox"
        Me.google_drive_checkbox.Size = New System.Drawing.Size(114, 17)
        Me.google_drive_checkbox.TabIndex = 12
        Me.google_drive_checkbox.Text = "Google Drive FTP "
        Me.google_drive_checkbox.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Grupa:"
        '
        'port_textbox
        '
        Me.port_textbox.Location = New System.Drawing.Point(123, 222)
        Me.port_textbox.Name = "port_textbox"
        Me.port_textbox.Size = New System.Drawing.Size(159, 20)
        Me.port_textbox.TabIndex = 8
        '
        'grupa_textbox
        '
        Me.grupa_textbox.BackColor = System.Drawing.SystemColors.Control
        Me.grupa_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grupa_textbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.grupa_textbox.Location = New System.Drawing.Point(123, 22)
        Me.grupa_textbox.Name = "grupa_textbox"
        Me.grupa_textbox.ReadOnly = True
        Me.grupa_textbox.Size = New System.Drawing.Size(159, 14)
        Me.grupa_textbox.TabIndex = 14
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(191, 453)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(92, 38)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "Izlaz"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'fingerprint_textbox
        '
        Me.fingerprint_textbox.Location = New System.Drawing.Point(123, 257)
        Me.fingerprint_textbox.Multiline = True
        Me.fingerprint_textbox.Name = "fingerprint_textbox"
        Me.fingerprint_textbox.Size = New System.Drawing.Size(159, 51)
        Me.fingerprint_textbox.TabIndex = 16
        '
        'fingerprint_label
        '
        Me.fingerprint_label.AutoSize = True
        Me.fingerprint_label.Location = New System.Drawing.Point(12, 260)
        Me.fingerprint_label.Name = "fingerprint_label"
        Me.fingerprint_label.Size = New System.Drawing.Size(101, 13)
        Me.fingerprint_label.TabIndex = 17
        Me.fingerprint_label.Text = "Host key fingerprint:"
        '
        'sftp_checkbox
        '
        Me.sftp_checkbox.AutoSize = True
        Me.sftp_checkbox.Location = New System.Drawing.Point(123, 53)
        Me.sftp_checkbox.Name = "sftp_checkbox"
        Me.sftp_checkbox.Size = New System.Drawing.Size(53, 17)
        Me.sftp_checkbox.TabIndex = 18
        Me.sftp_checkbox.Text = "SFTP"
        Me.sftp_checkbox.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 52)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 15)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "FTP "
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(303, 506)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.sftp_checkbox)
        Me.Controls.Add(Me.fingerprint_label)
        Me.Controls.Add(Me.fingerprint_textbox)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.grupa_textbox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.google_drive_checkbox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.username_textbox)
        Me.Controls.Add(Me.test_buton)
        Me.Controls.Add(Me.port_textbox)
        Me.Controls.Add(Me.password_textbox)
        Me.Controls.Add(Me.host_textbox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.salji_buton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form6"
        Me.ShowIcon = False
        Me.Text = "FTP slanje skeniranih podataka na  server"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents salji_buton As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents host_textbox As TextBox
    Friend WithEvents password_textbox As TextBox
    Friend WithEvents test_buton As Button
    Friend WithEvents username_textbox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents google_drive_checkbox As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents port_textbox As TextBox
    Friend WithEvents grupa_textbox As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents fingerprint_textbox As TextBox
    Friend WithEvents fingerprint_label As Label
    Friend WithEvents sftp_checkbox As CheckBox
    Friend WithEvents Label7 As Label
End Class
