﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Me.vrsta_akta_combobox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'vrsta_akta_combobox
        '
        Me.vrsta_akta_combobox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.vrsta_akta_combobox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.vrsta_akta_combobox.FormattingEnabled = True
        Me.vrsta_akta_combobox.Location = New System.Drawing.Point(114, 40)
        Me.vrsta_akta_combobox.Name = "vrsta_akta_combobox"
        Me.vrsta_akta_combobox.Size = New System.Drawing.Size(495, 21)
        Me.vrsta_akta_combobox.Sorted = True
        Me.vrsta_akta_combobox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Izaberi vrstu akta"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(274, 124)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(127, 40)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Potvrdi izbor"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 176)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.vrsta_akta_combobox)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form7"
        Me.ShowIcon = False
        Me.Text = "Vrsta akta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents vrsta_akta_combobox As ComboBox
End Class
