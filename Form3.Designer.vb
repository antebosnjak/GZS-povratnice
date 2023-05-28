<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.combobox_zupanija = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.combobox_tip_odjela = New System.Windows.Forms.ComboBox()
        Me.combobox_nadlezni_odjel = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Županija"
        '
        'combobox_zupanija
        '
        Me.combobox_zupanija.AllowDrop = True
        Me.combobox_zupanija.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.combobox_zupanija.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.combobox_zupanija.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combobox_zupanija.FormattingEnabled = True
        Me.combobox_zupanija.Items.AddRange(New Object() {"Bjelovarsko-bilogorska županija", "Brodsko-posavska županija", "Dubrovačko-neretvanska županija", "Grad Zagreb", "Istarska županija", "Karlovačka županija", "Koprivničko-križevačka županija", "Krapinsko-zagorska županija", "Ličko-senjska županija", "Međimurska županija", "Osječko-baranjska županija", "Požeško-slavonska županija", "Sisačko-moslavačka Županija", "Splitsko-dalmatinska županija", "Šibensko-kninska županija", "Varaždinska županija", "Virovitičko-podravska županija", "Vukovarsko-srijemska županija", "Zadarska županija", "Zagrebačka županija"})
        Me.combobox_zupanija.Location = New System.Drawing.Point(179, 44)
        Me.combobox_zupanija.Name = "combobox_zupanija"
        Me.combobox_zupanija.Size = New System.Drawing.Size(687, 21)
        Me.combobox_zupanija.Sorted = True
        Me.combobox_zupanija.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(742, 195)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 50)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Spremi postavke"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(153, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Tip nadležnog upravnog odjela"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nadležni upravni odjel"
        '
        'combobox_tip_odjela
        '
        Me.combobox_tip_odjela.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.combobox_tip_odjela.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.combobox_tip_odjela.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combobox_tip_odjela.FormattingEnabled = True
        Me.combobox_tip_odjela.Location = New System.Drawing.Point(179, 98)
        Me.combobox_tip_odjela.Name = "combobox_tip_odjela"
        Me.combobox_tip_odjela.Size = New System.Drawing.Size(687, 21)
        Me.combobox_tip_odjela.Sorted = True
        Me.combobox_tip_odjela.TabIndex = 5
        '
        'combobox_nadlezni_odjel
        '
        Me.combobox_nadlezni_odjel.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar
        Me.combobox_nadlezni_odjel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.combobox_nadlezni_odjel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.combobox_nadlezni_odjel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combobox_nadlezni_odjel.FormattingEnabled = True
        Me.combobox_nadlezni_odjel.Location = New System.Drawing.Point(179, 143)
        Me.combobox_nadlezni_odjel.Name = "combobox_nadlezni_odjel"
        Me.combobox_nadlezni_odjel.Size = New System.Drawing.Size(687, 21)
        Me.combobox_nadlezni_odjel.Sorted = True
        Me.combobox_nadlezni_odjel.TabIndex = 6
        '
        'Form3
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(878, 257)
        Me.Controls.Add(Me.combobox_nadlezni_odjel)
        Me.Controls.Add(Me.combobox_tip_odjela)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.combobox_zupanija)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form3"
        Me.ShowIcon = False
        Me.Text = "Postavke lokacije skeniranja"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents combobox_zupanija As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents combobox_tip_odjela As ComboBox
    Friend WithEvents combobox_nadlezni_odjel As ComboBox
End Class
