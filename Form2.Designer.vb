<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.spremi_postavke_buton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.reset_dana_buton = New System.Windows.Forms.Button()
        Me.ftp_slanje_checkbox = New System.Windows.Forms.CheckBox()
        Me.ftp_postavke_buton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Zadaj putanju  POVRATNICE"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Button1.Location = New System.Drawing.Point(207, 46)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(73, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "......................"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'spremi_postavke_buton
        '
        Me.spremi_postavke_buton.Location = New System.Drawing.Point(610, 204)
        Me.spremi_postavke_buton.Name = "spremi_postavke_buton"
        Me.spremi_postavke_buton.Size = New System.Drawing.Size(129, 42)
        Me.spremi_postavke_buton.TabIndex = 3
        Me.spremi_postavke_buton.Text = "Spremi postavke"
        Me.spremi_postavke_buton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Ime i prezime operatora"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox1.Location = New System.Drawing.Point(298, 48)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(441, 20)
        Me.TextBox1.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(298, 93)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(441, 20)
        Me.TextBox2.TabIndex = 5
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(298, 142)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(441, 20)
        Me.TextBox3.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Naziv grupe"
        '
        'reset_dana_buton
        '
        Me.reset_dana_buton.Location = New System.Drawing.Point(453, 204)
        Me.reset_dana_buton.Name = "reset_dana_buton"
        Me.reset_dana_buton.Size = New System.Drawing.Size(129, 42)
        Me.reset_dana_buton.TabIndex = 9
        Me.reset_dana_buton.Text = "Reset radnog dana"
        Me.reset_dana_buton.UseVisualStyleBackColor = True
        '
        'ftp_slanje_checkbox
        '
        Me.ftp_slanje_checkbox.AutoSize = True
        Me.ftp_slanje_checkbox.Location = New System.Drawing.Point(15, 218)
        Me.ftp_slanje_checkbox.Name = "ftp_slanje_checkbox"
        Me.ftp_slanje_checkbox.Size = New System.Drawing.Size(184, 17)
        Me.ftp_slanje_checkbox.TabIndex = 10
        Me.ftp_slanje_checkbox.Text = "FTP slanje podataka u toku rada "
        Me.ftp_slanje_checkbox.UseVisualStyleBackColor = True
        '
        'ftp_postavke_buton
        '
        Me.ftp_postavke_buton.Location = New System.Drawing.Point(298, 204)
        Me.ftp_postavke_buton.Name = "ftp_postavke_buton"
        Me.ftp_postavke_buton.Size = New System.Drawing.Size(129, 42)
        Me.ftp_postavke_buton.TabIndex = 11
        Me.ftp_postavke_buton.Text = "FTP postavke"
        Me.ftp_postavke_buton.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(754, 262)
        Me.Controls.Add(Me.ftp_postavke_buton)
        Me.Controls.Add(Me.ftp_slanje_checkbox)
        Me.Controls.Add(Me.reset_dana_buton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.spremi_postavke_buton)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form2"
        Me.ShowIcon = False
        Me.Text = "Postavke programa"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents spremi_postavke_buton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents reset_dana_buton As Button
    Friend WithEvents ftp_slanje_checkbox As CheckBox
    Friend WithEvents ftp_postavke_buton As Button
End Class
