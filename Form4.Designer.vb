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
        Me.spremi_podatke = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.nazivizmjere_textbox = New System.Windows.Forms.TextBox()
        Me.pdf_datotekatextbox = New System.Windows.Forms.TextBox()
        Me.broj_skenatextbox = New System.Windows.Forms.TextBox()
        Me.vrstapovratnice_textbox = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.datum_textbox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'spremi_podatke
        '
        Me.spremi_podatke.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.spremi_podatke.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.spremi_podatke.Location = New System.Drawing.Point(442, 267)
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
        Me.Label7.Size = New System.Drawing.Size(93, 15)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Vrsta povratnice"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 163)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 15)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Naziv izmjere"
        '
        'nazivizmjere_textbox
        '
        Me.nazivizmjere_textbox.Location = New System.Drawing.Point(192, 160)
        Me.nazivizmjere_textbox.Name = "nazivizmjere_textbox"
        Me.nazivizmjere_textbox.Size = New System.Drawing.Size(484, 21)
        Me.nazivizmjere_textbox.TabIndex = 6
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
        'vrstapovratnice_textbox
        '
        Me.vrstapovratnice_textbox.Location = New System.Drawing.Point(192, 120)
        Me.vrstapovratnice_textbox.Name = "vrstapovratnice_textbox"
        Me.vrstapovratnice_textbox.Size = New System.Drawing.Size(484, 21)
        Me.vrstapovratnice_textbox.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 204)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 15)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Datum"
        '
        'datum_textbox
        '
        Me.datum_textbox.Location = New System.Drawing.Point(192, 201)
        Me.datum_textbox.Name = "datum_textbox"
        Me.datum_textbox.Size = New System.Drawing.Size(484, 21)
        Me.datum_textbox.TabIndex = 8
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(688, 351)
        Me.Controls.Add(Me.vrstapovratnice_textbox)
        Me.Controls.Add(Me.broj_skenatextbox)
        Me.Controls.Add(Me.pdf_datotekatextbox)
        Me.Controls.Add(Me.nazivizmjere_textbox)
        Me.Controls.Add(Me.datum_textbox)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.spremi_podatke)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form4"
        Me.ShowIcon = False
        Me.Text = "Unesi podatke u bazu podataka"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents spremi_podatke As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents nazivizmjere_textbox As TextBox
    Friend WithEvents pdf_datotekatextbox As TextBox
    Friend WithEvents broj_skenatextbox As TextBox
    Friend WithEvents vrstapovratnice_textbox As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents datum_textbox As TextBox
End Class
