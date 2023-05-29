<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form5
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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.datum_kreiranjatextbox = New System.Windows.Forms.TextBox()
        Me.kreirano_odtextbox = New System.Windows.Forms.TextBox()
        Me.naziv_izmjeretextbox = New System.Windows.Forms.TextBox()
        Me.vrsta_povratnicetextbox = New System.Windows.Forms.TextBox()
        Me.pdftextbox = New System.Windows.Forms.TextBox()
        Me.brojskenatextbox = New System.Windows.Forms.TextBox()
        Me.autoidtextbox = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.movefirst_buton = New System.Windows.Forms.Button()
        Me.moveprevious_buton = New System.Windows.Forms.Button()
        Me.movenext_buton = New System.Windows.Forms.Button()
        Me.movelast_buton = New System.Windows.Forms.Button()
        Me.delete_buton = New System.Windows.Forms.Button()
        Me.addnew_buton = New System.Windows.Forms.Button()
        Me.save_buton = New System.Windows.Forms.Button()
        Me.keywordtextbox = New System.Windows.Forms.TextBox()
        Me.search_buton = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.positionlabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.refresh_buton = New System.Windows.Forms.Button()
        Me.exit_buton = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.savecsvdlg = New System.Windows.Forms.SaveFileDialog()
        Me.exportcsv_buton = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.datum_kreiranjatextbox)
        Me.GroupBox1.Controls.Add(Me.kreirano_odtextbox)
        Me.GroupBox1.Controls.Add(Me.naziv_izmjeretextbox)
        Me.GroupBox1.Controls.Add(Me.vrsta_povratnicetextbox)
        Me.GroupBox1.Controls.Add(Me.pdftextbox)
        Me.GroupBox1.Controls.Add(Me.brojskenatextbox)
        Me.GroupBox1.Controls.Add(Me.autoidtextbox)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(395, 493)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Unos podataka"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(268, 463)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(127, 24)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "Učitaj TXT"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'datum_kreiranjatextbox
        '
        Me.datum_kreiranjatextbox.Location = New System.Drawing.Point(133, 254)
        Me.datum_kreiranjatextbox.Name = "datum_kreiranjatextbox"
        Me.datum_kreiranjatextbox.Size = New System.Drawing.Size(256, 20)
        Me.datum_kreiranjatextbox.TabIndex = 23
        '
        'kreirano_odtextbox
        '
        Me.kreirano_odtextbox.Location = New System.Drawing.Point(133, 216)
        Me.kreirano_odtextbox.Name = "kreirano_odtextbox"
        Me.kreirano_odtextbox.Size = New System.Drawing.Size(256, 20)
        Me.kreirano_odtextbox.TabIndex = 22
        '
        'naziv_izmjeretextbox
        '
        Me.naziv_izmjeretextbox.Location = New System.Drawing.Point(133, 173)
        Me.naziv_izmjeretextbox.Name = "naziv_izmjeretextbox"
        Me.naziv_izmjeretextbox.Size = New System.Drawing.Size(256, 20)
        Me.naziv_izmjeretextbox.TabIndex = 17
        '
        'vrsta_povratnicetextbox
        '
        Me.vrsta_povratnicetextbox.Location = New System.Drawing.Point(133, 137)
        Me.vrsta_povratnicetextbox.Name = "vrsta_povratnicetextbox"
        Me.vrsta_povratnicetextbox.Size = New System.Drawing.Size(256, 20)
        Me.vrsta_povratnicetextbox.TabIndex = 16
        '
        'pdftextbox
        '
        Me.pdftextbox.Location = New System.Drawing.Point(133, 102)
        Me.pdftextbox.Name = "pdftextbox"
        Me.pdftextbox.Size = New System.Drawing.Size(256, 20)
        Me.pdftextbox.TabIndex = 15
        '
        'brojskenatextbox
        '
        Me.brojskenatextbox.Location = New System.Drawing.Point(133, 63)
        Me.brojskenatextbox.Name = "brojskenatextbox"
        Me.brojskenatextbox.Size = New System.Drawing.Size(256, 20)
        Me.brojskenatextbox.TabIndex = 13
        '
        'autoidtextbox
        '
        Me.autoidtextbox.Location = New System.Drawing.Point(133, 25)
        Me.autoidtextbox.Name = "autoidtextbox"
        Me.autoidtextbox.ReadOnly = True
        Me.autoidtextbox.Size = New System.Drawing.Size(256, 20)
        Me.autoidtextbox.TabIndex = 12
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(13, 257)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(81, 13)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Datum kreiranja"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(13, 219)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Kreirano od"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 176)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Naziv izmjere"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 140)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Vrsta povratnice"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "PDF"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Broj skena"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "AutoID"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Location = New System.Drawing.Point(413, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(947, 580)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pregled podataka"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(15, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(926, 554)
        Me.DataGridView1.TabIndex = 0
        '
        'movefirst_buton
        '
        Me.movefirst_buton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.movefirst_buton.Location = New System.Drawing.Point(12, 514)
        Me.movefirst_buton.Name = "movefirst_buton"
        Me.movefirst_buton.Size = New System.Drawing.Size(77, 23)
        Me.movefirst_buton.TabIndex = 2
        Me.movefirst_buton.Text = "I<"
        Me.movefirst_buton.UseVisualStyleBackColor = True
        '
        'moveprevious_buton
        '
        Me.moveprevious_buton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.moveprevious_buton.Location = New System.Drawing.Point(125, 514)
        Me.moveprevious_buton.Name = "moveprevious_buton"
        Me.moveprevious_buton.Size = New System.Drawing.Size(73, 23)
        Me.moveprevious_buton.TabIndex = 3
        Me.moveprevious_buton.Text = "<"
        Me.moveprevious_buton.UseVisualStyleBackColor = True
        '
        'movenext_buton
        '
        Me.movenext_buton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.movenext_buton.Location = New System.Drawing.Point(220, 514)
        Me.movenext_buton.Name = "movenext_buton"
        Me.movenext_buton.Size = New System.Drawing.Size(74, 23)
        Me.movenext_buton.TabIndex = 4
        Me.movenext_buton.Text = ">"
        Me.movenext_buton.UseVisualStyleBackColor = True
        '
        'movelast_buton
        '
        Me.movelast_buton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.movelast_buton.Location = New System.Drawing.Point(334, 514)
        Me.movelast_buton.Name = "movelast_buton"
        Me.movelast_buton.Size = New System.Drawing.Size(73, 23)
        Me.movelast_buton.TabIndex = 5
        Me.movelast_buton.Text = ">I"
        Me.movelast_buton.UseVisualStyleBackColor = True
        '
        'delete_buton
        '
        Me.delete_buton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.delete_buton.ForeColor = System.Drawing.Color.DarkRed
        Me.delete_buton.Location = New System.Drawing.Point(12, 562)
        Me.delete_buton.Name = "delete_buton"
        Me.delete_buton.Size = New System.Drawing.Size(94, 23)
        Me.delete_buton.TabIndex = 6
        Me.delete_buton.Text = "Briši"
        Me.delete_buton.UseVisualStyleBackColor = True
        '
        'addnew_buton
        '
        Me.addnew_buton.Location = New System.Drawing.Point(154, 562)
        Me.addnew_buton.Name = "addnew_buton"
        Me.addnew_buton.Size = New System.Drawing.Size(103, 23)
        Me.addnew_buton.TabIndex = 7
        Me.addnew_buton.Text = "Dodaj novi"
        Me.addnew_buton.UseVisualStyleBackColor = True
        '
        'save_buton
        '
        Me.save_buton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.save_buton.ForeColor = System.Drawing.Color.DarkRed
        Me.save_buton.Location = New System.Drawing.Point(307, 562)
        Me.save_buton.Name = "save_buton"
        Me.save_buton.Size = New System.Drawing.Size(100, 23)
        Me.save_buton.TabIndex = 8
        Me.save_buton.Text = "Spremi"
        Me.save_buton.UseVisualStyleBackColor = True
        '
        'keywordtextbox
        '
        Me.keywordtextbox.Location = New System.Drawing.Point(12, 612)
        Me.keywordtextbox.Name = "keywordtextbox"
        Me.keywordtextbox.Size = New System.Drawing.Size(245, 20)
        Me.keywordtextbox.TabIndex = 24
        '
        'search_buton
        '
        Me.search_buton.Location = New System.Drawing.Point(307, 607)
        Me.search_buton.Name = "search_buton"
        Me.search_buton.Size = New System.Drawing.Size(100, 24)
        Me.search_buton.TabIndex = 25
        Me.search_buton.Text = "Traži"
        Me.search_buton.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.positionlabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 642)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1379, 22)
        Me.StatusStrip1.TabIndex = 26
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'positionlabel
        '
        Me.positionlabel.Name = "positionlabel"
        Me.positionlabel.Size = New System.Drawing.Size(75, 17)
        Me.positionlabel.Text = "positionlabel"
        '
        'refresh_buton
        '
        Me.refresh_buton.Location = New System.Drawing.Point(458, 608)
        Me.refresh_buton.Name = "refresh_buton"
        Me.refresh_buton.Size = New System.Drawing.Size(150, 24)
        Me.refresh_buton.TabIndex = 27
        Me.refresh_buton.Text = "Osvježi podatke"
        Me.refresh_buton.UseVisualStyleBackColor = True
        '
        'exit_buton
        '
        Me.exit_buton.Location = New System.Drawing.Point(800, 607)
        Me.exit_buton.Name = "exit_buton"
        Me.exit_buton.Size = New System.Drawing.Size(150, 24)
        Me.exit_buton.TabIndex = 28
        Me.exit_buton.Text = "Izlaz"
        Me.exit_buton.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'exportcsv_buton
        '
        Me.exportcsv_buton.Location = New System.Drawing.Point(632, 608)
        Me.exportcsv_buton.Name = "exportcsv_buton"
        Me.exportcsv_buton.Size = New System.Drawing.Size(150, 24)
        Me.exportcsv_buton.TabIndex = 31
        Me.exportcsv_buton.Text = "CSV export"
        Me.exportcsv_buton.UseVisualStyleBackColor = True
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1379, 664)
        Me.ControlBox = False
        Me.Controls.Add(Me.exportcsv_buton)
        Me.Controls.Add(Me.exit_buton)
        Me.Controls.Add(Me.refresh_buton)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.search_buton)
        Me.Controls.Add(Me.keywordtextbox)
        Me.Controls.Add(Me.save_buton)
        Me.Controls.Add(Me.addnew_buton)
        Me.Controls.Add(Me.delete_buton)
        Me.Controls.Add(Me.movelast_buton)
        Me.Controls.Add(Me.movenext_buton)
        Me.Controls.Add(Me.moveprevious_buton)
        Me.Controls.Add(Me.movefirst_buton)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form5"
        Me.ShowIcon = False
        Me.Text = "Pregled skeniranih podataka"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents datum_kreiranjatextbox As TextBox
    Friend WithEvents kreirano_odtextbox As TextBox
    Friend WithEvents naziv_izmjeretextbox As TextBox
    Friend WithEvents vrsta_povratnicetextbox As TextBox
    Friend WithEvents pdftextbox As TextBox
    Friend WithEvents brojskenatextbox As TextBox
    Friend WithEvents autoidtextbox As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents movefirst_buton As Button
    Friend WithEvents movenext_buton As Button
    Friend WithEvents movelast_buton As Button
    Friend WithEvents delete_buton As Button
    Friend WithEvents addnew_buton As Button
    Friend WithEvents save_buton As Button
    Friend WithEvents keywordtextbox As TextBox
    Friend WithEvents search_buton As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents moveprevious_buton As Button
    Friend WithEvents refresh_buton As Button
    Friend WithEvents exit_buton As Button
    Friend WithEvents positionlabel As ToolStripStatusLabel
    Friend WithEvents Button1 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents savecsvdlg As SaveFileDialog
    Friend WithEvents exportcsv_buton As Button
End Class
