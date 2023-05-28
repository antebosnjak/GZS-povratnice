<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.datum_aktatextbox = New System.Windows.Forms.TextBox()
        Me.neodostajuca_stranicatextbox = New System.Windows.Forms.TextBox()
        Me.ostecena_stranicatextbox = New System.Windows.Forms.TextBox()
        Me.spremi_podatke = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.zupanijatextbox = New System.Windows.Forms.TextBox()
        Me.upravni_odjeltextbox = New System.Windows.Forms.TextBox()
        Me.ispostavatextbox = New System.Windows.Forms.TextBox()
        Me.pdf_datotekatextbox = New System.Windows.Forms.TextBox()
        Me.broj_skenatextbox = New System.Windows.Forms.TextBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tipdozvole_textbox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 276)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 15)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Datum rješenja akta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 357)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 15)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Broj stranice koja nedostaje"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 317)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 15)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Broj oštećene stranice"
        '
        'datum_aktatextbox
        '
        Me.datum_aktatextbox.Cursor = System.Windows.Forms.Cursors.Default
        Me.datum_aktatextbox.Location = New System.Drawing.Point(192, 273)
        Me.datum_aktatextbox.Name = "datum_aktatextbox"
        Me.datum_aktatextbox.Size = New System.Drawing.Size(168, 21)
        Me.datum_aktatextbox.TabIndex = 1
        '
        'neodostajuca_stranicatextbox
        '
        Me.neodostajuca_stranicatextbox.Cursor = System.Windows.Forms.Cursors.Default
        Me.neodostajuca_stranicatextbox.Location = New System.Drawing.Point(192, 354)
        Me.neodostajuca_stranicatextbox.Name = "neodostajuca_stranicatextbox"
        Me.neodostajuca_stranicatextbox.Size = New System.Drawing.Size(168, 21)
        Me.neodostajuca_stranicatextbox.TabIndex = 3
        '
        'ostecena_stranicatextbox
        '
        Me.ostecena_stranicatextbox.Cursor = System.Windows.Forms.Cursors.Default
        Me.ostecena_stranicatextbox.Location = New System.Drawing.Point(192, 314)
        Me.ostecena_stranicatextbox.Name = "ostecena_stranicatextbox"
        Me.ostecena_stranicatextbox.Size = New System.Drawing.Size(168, 21)
        Me.ostecena_stranicatextbox.TabIndex = 2
        '
        'spremi_podatke
        '
        Me.spremi_podatke.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.spremi_podatke.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.spremi_podatke.Location = New System.Drawing.Point(442, 314)
        Me.spremi_podatke.Name = "spremi_podatke"
        Me.spremi_podatke.Size = New System.Drawing.Size(234, 61)
        Me.spremi_podatke.TabIndex = 4
        Me.spremi_podatke.Text = "Spremi podatke"
        Me.spremi_podatke.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 15)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Broj skena"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 15)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "PDF datoteka"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 123)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 15)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Tip dozvole"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 163)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 15)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Ispostava"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label9.Location = New System.Drawing.Point(9, 197)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 15)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Upravni odjel"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label10.Location = New System.Drawing.Point(9, 239)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 15)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Županija"
        '
        'zupanijatextbox
        '
        Me.zupanijatextbox.Location = New System.Drawing.Point(192, 236)
        Me.zupanijatextbox.Name = "zupanijatextbox"
        Me.zupanijatextbox.Size = New System.Drawing.Size(484, 21)
        Me.zupanijatextbox.TabIndex = 8
        '
        'upravni_odjeltextbox
        '
        Me.upravni_odjeltextbox.Location = New System.Drawing.Point(192, 197)
        Me.upravni_odjeltextbox.Name = "upravni_odjeltextbox"
        Me.upravni_odjeltextbox.Size = New System.Drawing.Size(484, 21)
        Me.upravni_odjeltextbox.TabIndex = 7
        '
        'ispostavatextbox
        '
        Me.ispostavatextbox.Location = New System.Drawing.Point(192, 160)
        Me.ispostavatextbox.Name = "ispostavatextbox"
        Me.ispostavatextbox.Size = New System.Drawing.Size(484, 21)
        Me.ispostavatextbox.TabIndex = 6
        '
        'pdf_datotekatextbox
        '
        Me.pdf_datotekatextbox.Location = New System.Drawing.Point(192, 78)
        Me.pdf_datotekatextbox.Name = "pdf_datotekatextbox"
        Me.pdf_datotekatextbox.ReadOnly = True
        Me.pdf_datotekatextbox.Size = New System.Drawing.Size(484, 21)
        Me.pdf_datotekatextbox.TabIndex = 9
        Me.pdf_datotekatextbox.TabStop = False
        '
        'broj_skenatextbox
        '
        Me.broj_skenatextbox.Location = New System.Drawing.Point(192, 38)
        Me.broj_skenatextbox.Name = "broj_skenatextbox"
        Me.broj_skenatextbox.ReadOnly = True
        Me.broj_skenatextbox.Size = New System.Drawing.Size(168, 21)
        Me.broj_skenatextbox.TabIndex = 8
        Me.broj_skenatextbox.TabStop = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(15, 414)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(661, 20)
        Me.ProgressBar1.TabIndex = 21
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label11.Location = New System.Drawing.Point(324, 396)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 15)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Label11"
        '
        'tipdozvole_textbox
        '
        Me.tipdozvole_textbox.Location = New System.Drawing.Point(192, 120)
        Me.tipdozvole_textbox.Name = "tipdozvole_textbox"
        Me.tipdozvole_textbox.Size = New System.Drawing.Size(484, 21)
        Me.tipdozvole_textbox.TabIndex = 5
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(688, 446)
        Me.Controls.Add(Me.tipdozvole_textbox)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.broj_skenatextbox)
        Me.Controls.Add(Me.pdf_datotekatextbox)
        Me.Controls.Add(Me.ispostavatextbox)
        Me.Controls.Add(Me.upravni_odjeltextbox)
        Me.Controls.Add(Me.zupanijatextbox)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.spremi_podatke)
        Me.Controls.Add(Me.ostecena_stranicatextbox)
        Me.Controls.Add(Me.neodostajuca_stranicatextbox)
        Me.Controls.Add(Me.datum_aktatextbox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form4"
        Me.ShowIcon = False
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents datum_aktatextbox As TextBox
    Friend WithEvents neodostajuca_stranicatextbox As TextBox
    Friend WithEvents ostecena_stranicatextbox As TextBox
    Friend WithEvents spremi_podatke As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents zupanijatextbox As TextBox
    Friend WithEvents upravni_odjeltextbox As TextBox
    Friend WithEvents ispostavatextbox As TextBox
    Friend WithEvents pdf_datotekatextbox As TextBox
    Friend WithEvents broj_skenatextbox As TextBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label11 As Label
    Friend WithEvents tipdozvole_textbox As TextBox
End Class
