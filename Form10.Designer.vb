<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form10
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.putanja_grupe_textbox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.putanja_servera_textbox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Putanja grupe"
        '
        'putanja_grupe_textbox
        '
        Me.putanja_grupe_textbox.Location = New System.Drawing.Point(162, 29)
        Me.putanja_grupe_textbox.Name = "putanja_grupe_textbox"
        Me.putanja_grupe_textbox.Size = New System.Drawing.Size(399, 20)
        Me.putanja_grupe_textbox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Putanja grupe na serveru"
        '
        'putanja_servera_textbox
        '
        Me.putanja_servera_textbox.Location = New System.Drawing.Point(162, 73)
        Me.putanja_servera_textbox.Name = "putanja_servera_textbox"
        Me.putanja_servera_textbox.Size = New System.Drawing.Size(399, 20)
        Me.putanja_servera_textbox.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(159, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(207, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "\\adresa_servera\share_folder\ime_grupe"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(185, 169)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(230, 37)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Šalji dnevne podatke na server"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(28, 169)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(105, 37)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Otvori LOG"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(463, 169)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(105, 37)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Izlaz"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 238)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.putanja_servera_textbox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.putanja_grupe_textbox)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form10"
        Me.ShowIcon = False
        Me.Text = "Slanje podataka"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents putanja_grupe_textbox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents putanja_servera_textbox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
