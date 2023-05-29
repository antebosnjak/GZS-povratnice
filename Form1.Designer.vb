<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.skeniraj_buton = New System.Windows.Forms.Button()
        Me.metapodaci_buton = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.zavrsi_dan_buton = New System.Windows.Forms.Button()
        Me.start_radnog_dana_buton = New System.Windows.Forms.Button()
        Me.zelena_kvacica_1 = New System.Windows.Forms.PictureBox()
        Me.zelena_kvacica_5 = New System.Windows.Forms.PictureBox()
        Me.zelena_kvacica_6 = New System.Windows.Forms.PictureBox()
        Me.crveni_kriz_2 = New System.Windows.Forms.PictureBox()
        Me.crveni_kriz_3 = New System.Windows.Forms.PictureBox()
        Me.novi_sken_buton = New System.Windows.Forms.Button()
        Me.zelena_kvacica_s = New System.Windows.Forms.PictureBox()
        Me.zelena_kvacica_m = New System.Windows.Forms.PictureBox()
        Me.sken_check = New System.Windows.Forms.CheckBox()
        Me.metapodaci_check = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.broj_skena_textbox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.zelena_kvacica_v = New System.Windows.Forms.PictureBox()
        Me.vrsta_akta_checkbox = New System.Windows.Forms.CheckBox()
        Me.kreiran_pdf_check = New System.Windows.Forms.CheckBox()
        Me.zelena_kvacica_k = New System.Windows.Forms.PictureBox()
        Me.kreiraj_pdf_buton = New System.Windows.Forms.Button()
        Me.reset_skena_buton = New System.Windows.Forms.Button()
        Me.pregled_skeniranih_podataka_buton = New System.Windows.Forms.Button()
        Me.o_programu_buton = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.vrsta_akta_buton = New System.Windows.Forms.Button()
        Me.CircularProgressBar1 = New CircularProgressBar.CircularProgressBar()
        CType(Me.zelena_kvacica_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.zelena_kvacica_5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.zelena_kvacica_6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.crveni_kriz_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.crveni_kriz_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.zelena_kvacica_s, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.zelena_kvacica_m, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.zelena_kvacica_v, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.zelena_kvacica_k, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'skeniraj_buton
        '
        Me.skeniraj_buton.Image = CType(resources.GetObject("skeniraj_buton.Image"), System.Drawing.Image)
        Me.skeniraj_buton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.skeniraj_buton.Location = New System.Drawing.Point(12, 197)
        Me.skeniraj_buton.Name = "skeniraj_buton"
        Me.skeniraj_buton.Size = New System.Drawing.Size(110, 40)
        Me.skeniraj_buton.TabIndex = 0
        Me.skeniraj_buton.Text = "Skeniraj"
        Me.skeniraj_buton.UseVisualStyleBackColor = True
        '
        'metapodaci_buton
        '
        Me.metapodaci_buton.Image = CType(resources.GetObject("metapodaci_buton.Image"), System.Drawing.Image)
        Me.metapodaci_buton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.metapodaci_buton.Location = New System.Drawing.Point(12, 363)
        Me.metapodaci_buton.Name = "metapodaci_buton"
        Me.metapodaci_buton.Size = New System.Drawing.Size(110, 40)
        Me.metapodaci_buton.TabIndex = 1
        Me.metapodaci_buton.Text = "Unesi metapod."
        Me.metapodaci_buton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.metapodaci_buton.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(12, 71)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(110, 40)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Postavke lokacije skeniranja"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(12, 12)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(110, 40)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Postavke programa"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'zavrsi_dan_buton
        '
        Me.zavrsi_dan_buton.Location = New System.Drawing.Point(346, 197)
        Me.zavrsi_dan_buton.Name = "zavrsi_dan_buton"
        Me.zavrsi_dan_buton.Size = New System.Drawing.Size(110, 40)
        Me.zavrsi_dan_buton.TabIndex = 7
        Me.zavrsi_dan_buton.Text = "Završi dan"
        Me.zavrsi_dan_buton.UseVisualStyleBackColor = True
        '
        'start_radnog_dana_buton
        '
        Me.start_radnog_dana_buton.Location = New System.Drawing.Point(12, 132)
        Me.start_radnog_dana_buton.Name = "start_radnog_dana_buton"
        Me.start_radnog_dana_buton.Size = New System.Drawing.Size(110, 40)
        Me.start_radnog_dana_buton.TabIndex = 8
        Me.start_radnog_dana_buton.Text = "Start radnog dana"
        Me.start_radnog_dana_buton.UseVisualStyleBackColor = True
        '
        'zelena_kvacica_1
        '
        Me.zelena_kvacica_1.Image = CType(resources.GetObject("zelena_kvacica_1.Image"), System.Drawing.Image)
        Me.zelena_kvacica_1.Location = New System.Drawing.Point(161, 132)
        Me.zelena_kvacica_1.Name = "zelena_kvacica_1"
        Me.zelena_kvacica_1.Size = New System.Drawing.Size(40, 40)
        Me.zelena_kvacica_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.zelena_kvacica_1.TabIndex = 9
        Me.zelena_kvacica_1.TabStop = False
        Me.zelena_kvacica_1.Visible = False
        '
        'zelena_kvacica_5
        '
        Me.zelena_kvacica_5.Image = CType(resources.GetObject("zelena_kvacica_5.Image"), System.Drawing.Image)
        Me.zelena_kvacica_5.Location = New System.Drawing.Point(161, 71)
        Me.zelena_kvacica_5.Name = "zelena_kvacica_5"
        Me.zelena_kvacica_5.Size = New System.Drawing.Size(40, 40)
        Me.zelena_kvacica_5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.zelena_kvacica_5.TabIndex = 11
        Me.zelena_kvacica_5.TabStop = False
        Me.zelena_kvacica_5.Visible = False
        '
        'zelena_kvacica_6
        '
        Me.zelena_kvacica_6.Image = CType(resources.GetObject("zelena_kvacica_6.Image"), System.Drawing.Image)
        Me.zelena_kvacica_6.Location = New System.Drawing.Point(161, 12)
        Me.zelena_kvacica_6.Name = "zelena_kvacica_6"
        Me.zelena_kvacica_6.Size = New System.Drawing.Size(40, 40)
        Me.zelena_kvacica_6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.zelena_kvacica_6.TabIndex = 12
        Me.zelena_kvacica_6.TabStop = False
        Me.zelena_kvacica_6.Visible = False
        '
        'crveni_kriz_2
        '
        Me.crveni_kriz_2.Image = CType(resources.GetObject("crveni_kriz_2.Image"), System.Drawing.Image)
        Me.crveni_kriz_2.Location = New System.Drawing.Point(161, 71)
        Me.crveni_kriz_2.Name = "crveni_kriz_2"
        Me.crveni_kriz_2.Size = New System.Drawing.Size(40, 40)
        Me.crveni_kriz_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.crveni_kriz_2.TabIndex = 13
        Me.crveni_kriz_2.TabStop = False
        Me.crveni_kriz_2.Visible = False
        '
        'crveni_kriz_3
        '
        Me.crveni_kriz_3.Image = CType(resources.GetObject("crveni_kriz_3.Image"), System.Drawing.Image)
        Me.crveni_kriz_3.Location = New System.Drawing.Point(161, 12)
        Me.crveni_kriz_3.Name = "crveni_kriz_3"
        Me.crveni_kriz_3.Size = New System.Drawing.Size(40, 40)
        Me.crveni_kriz_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.crveni_kriz_3.TabIndex = 14
        Me.crveni_kriz_3.TabStop = False
        Me.crveni_kriz_3.Visible = False
        '
        'novi_sken_buton
        '
        Me.novi_sken_buton.Image = CType(resources.GetObject("novi_sken_buton.Image"), System.Drawing.Image)
        Me.novi_sken_buton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.novi_sken_buton.Location = New System.Drawing.Point(12, 417)
        Me.novi_sken_buton.Name = "novi_sken_buton"
        Me.novi_sken_buton.Size = New System.Drawing.Size(110, 40)
        Me.novi_sken_buton.TabIndex = 17
        Me.novi_sken_buton.Text = "Novi sken"
        Me.novi_sken_buton.UseVisualStyleBackColor = True
        '
        'zelena_kvacica_s
        '
        Me.zelena_kvacica_s.Image = CType(resources.GetObject("zelena_kvacica_s.Image"), System.Drawing.Image)
        Me.zelena_kvacica_s.Location = New System.Drawing.Point(106, 7)
        Me.zelena_kvacica_s.Name = "zelena_kvacica_s"
        Me.zelena_kvacica_s.Size = New System.Drawing.Size(40, 40)
        Me.zelena_kvacica_s.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.zelena_kvacica_s.TabIndex = 18
        Me.zelena_kvacica_s.TabStop = False
        Me.zelena_kvacica_s.Visible = False
        '
        'zelena_kvacica_m
        '
        Me.zelena_kvacica_m.Image = CType(resources.GetObject("zelena_kvacica_m.Image"), System.Drawing.Image)
        Me.zelena_kvacica_m.Location = New System.Drawing.Point(106, 173)
        Me.zelena_kvacica_m.Name = "zelena_kvacica_m"
        Me.zelena_kvacica_m.Size = New System.Drawing.Size(40, 40)
        Me.zelena_kvacica_m.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.zelena_kvacica_m.TabIndex = 20
        Me.zelena_kvacica_m.TabStop = False
        Me.zelena_kvacica_m.Visible = False
        '
        'sken_check
        '
        Me.sken_check.AutoSize = True
        Me.sken_check.Location = New System.Drawing.Point(4, 20)
        Me.sken_check.Name = "sken_check"
        Me.sken_check.Size = New System.Drawing.Size(74, 17)
        Me.sken_check.TabIndex = 26
        Me.sken_check.Text = "Skenirano"
        Me.sken_check.UseVisualStyleBackColor = True
        '
        'metapodaci_check
        '
        Me.metapodaci_check.AutoSize = True
        Me.metapodaci_check.Location = New System.Drawing.Point(0, 182)
        Me.metapodaci_check.Name = "metapodaci_check"
        Me.metapodaci_check.Size = New System.Drawing.Size(100, 17)
        Me.metapodaci_check.TabIndex = 28
        Me.metapodaci_check.Text = "Unešeni podaci"
        Me.metapodaci_check.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(157, 480)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 20)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Broj skena"
        '
        'broj_skena_textbox
        '
        Me.broj_skena_textbox.BackColor = System.Drawing.SystemColors.Window
        Me.broj_skena_textbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.broj_skena_textbox.ForeColor = System.Drawing.Color.Red
        Me.broj_skena_textbox.Location = New System.Drawing.Point(266, 477)
        Me.broj_skena_textbox.Name = "broj_skena_textbox"
        Me.broj_skena_textbox.ReadOnly = True
        Me.broj_skena_textbox.Size = New System.Drawing.Size(81, 26)
        Me.broj_skena_textbox.TabIndex = 30
        '
        'GroupBox1
        '
        Me.GroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GroupBox1.Controls.Add(Me.zelena_kvacica_v)
        Me.GroupBox1.Controls.Add(Me.vrsta_akta_checkbox)
        Me.GroupBox1.Controls.Add(Me.kreiran_pdf_check)
        Me.GroupBox1.Controls.Add(Me.zelena_kvacica_k)
        Me.GroupBox1.Controls.Add(Me.metapodaci_check)
        Me.GroupBox1.Controls.Add(Me.zelena_kvacica_m)
        Me.GroupBox1.Controls.Add(Me.sken_check)
        Me.GroupBox1.Controls.Add(Me.zelena_kvacica_s)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Location = New System.Drawing.Point(144, 193)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(152, 264)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        '
        'zelena_kvacica_v
        '
        Me.zelena_kvacica_v.Image = CType(resources.GetObject("zelena_kvacica_v.Image"), System.Drawing.Image)
        Me.zelena_kvacica_v.Location = New System.Drawing.Point(106, 63)
        Me.zelena_kvacica_v.Name = "zelena_kvacica_v"
        Me.zelena_kvacica_v.Size = New System.Drawing.Size(40, 40)
        Me.zelena_kvacica_v.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.zelena_kvacica_v.TabIndex = 32
        Me.zelena_kvacica_v.TabStop = False
        Me.zelena_kvacica_v.Visible = False
        '
        'vrsta_akta_checkbox
        '
        Me.vrsta_akta_checkbox.AutoSize = True
        Me.vrsta_akta_checkbox.Location = New System.Drawing.Point(4, 76)
        Me.vrsta_akta_checkbox.Name = "vrsta_akta_checkbox"
        Me.vrsta_akta_checkbox.Size = New System.Drawing.Size(93, 17)
        Me.vrsta_akta_checkbox.TabIndex = 31
        Me.vrsta_akta_checkbox.Text = "Izabrana vrsta"
        Me.vrsta_akta_checkbox.UseVisualStyleBackColor = True
        '
        'kreiran_pdf_check
        '
        Me.kreiran_pdf_check.AutoSize = True
        Me.kreiran_pdf_check.Location = New System.Drawing.Point(4, 132)
        Me.kreiran_pdf_check.Name = "kreiran_pdf_check"
        Me.kreiran_pdf_check.Size = New System.Drawing.Size(83, 17)
        Me.kreiran_pdf_check.TabIndex = 30
        Me.kreiran_pdf_check.Text = "Kreiran PDF"
        Me.kreiran_pdf_check.UseVisualStyleBackColor = True
        '
        'zelena_kvacica_k
        '
        Me.zelena_kvacica_k.Image = CType(resources.GetObject("zelena_kvacica_k.Image"), System.Drawing.Image)
        Me.zelena_kvacica_k.Location = New System.Drawing.Point(106, 119)
        Me.zelena_kvacica_k.Name = "zelena_kvacica_k"
        Me.zelena_kvacica_k.Size = New System.Drawing.Size(40, 40)
        Me.zelena_kvacica_k.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.zelena_kvacica_k.TabIndex = 29
        Me.zelena_kvacica_k.TabStop = False
        Me.zelena_kvacica_k.Visible = False
        '
        'kreiraj_pdf_buton
        '
        Me.kreiraj_pdf_buton.Image = CType(resources.GetObject("kreiraj_pdf_buton.Image"), System.Drawing.Image)
        Me.kreiraj_pdf_buton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.kreiraj_pdf_buton.Location = New System.Drawing.Point(12, 309)
        Me.kreiraj_pdf_buton.Name = "kreiraj_pdf_buton"
        Me.kreiraj_pdf_buton.Size = New System.Drawing.Size(110, 40)
        Me.kreiraj_pdf_buton.TabIndex = 33
        Me.kreiraj_pdf_buton.Text = "Kreiraj PDF"
        Me.kreiraj_pdf_buton.UseVisualStyleBackColor = True
        '
        'reset_skena_buton
        '
        Me.reset_skena_buton.Location = New System.Drawing.Point(346, 253)
        Me.reset_skena_buton.Name = "reset_skena_buton"
        Me.reset_skena_buton.Size = New System.Drawing.Size(110, 95)
        Me.reset_skena_buton.TabIndex = 34
        Me.reset_skena_buton.Text = "Reset tekućeg skena"
        Me.reset_skena_buton.UseVisualStyleBackColor = True
        '
        'pregled_skeniranih_podataka_buton
        '
        Me.pregled_skeniranih_podataka_buton.Location = New System.Drawing.Point(346, 363)
        Me.pregled_skeniranih_podataka_buton.Name = "pregled_skeniranih_podataka_buton"
        Me.pregled_skeniranih_podataka_buton.Size = New System.Drawing.Size(110, 94)
        Me.pregled_skeniranih_podataka_buton.TabIndex = 35
        Me.pregled_skeniranih_podataka_buton.Text = "Pregled skeniranih podataka"
        Me.pregled_skeniranih_podataka_buton.UseVisualStyleBackColor = True
        '
        'o_programu_buton
        '
        Me.o_programu_buton.Location = New System.Drawing.Point(346, 12)
        Me.o_programu_buton.Name = "o_programu_buton"
        Me.o_programu_buton.Size = New System.Drawing.Size(110, 40)
        Me.o_programu_buton.TabIndex = 36
        Me.o_programu_buton.Text = "O programu"
        Me.o_programu_buton.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'vrsta_akta_buton
        '
        Me.vrsta_akta_buton.Image = CType(resources.GetObject("vrsta_akta_buton.Image"), System.Drawing.Image)
        Me.vrsta_akta_buton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.vrsta_akta_buton.Location = New System.Drawing.Point(12, 253)
        Me.vrsta_akta_buton.Name = "vrsta_akta_buton"
        Me.vrsta_akta_buton.Size = New System.Drawing.Size(110, 40)
        Me.vrsta_akta_buton.TabIndex = 37
        Me.vrsta_akta_buton.Text = "Vrsta povratnice"
        Me.vrsta_akta_buton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.vrsta_akta_buton.UseVisualStyleBackColor = True
        '
        'CircularProgressBar1
        '
        Me.CircularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner
        Me.CircularProgressBar1.AnimationSpeed = 500
        Me.CircularProgressBar1.BackColor = System.Drawing.Color.Transparent
        Me.CircularProgressBar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.CircularProgressBar1.ForeColor = System.Drawing.Color.Red
        Me.CircularProgressBar1.InnerColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CircularProgressBar1.InnerMargin = 2
        Me.CircularProgressBar1.InnerWidth = -1
        Me.CircularProgressBar1.Location = New System.Drawing.Point(249, 12)
        Me.CircularProgressBar1.MarqueeAnimationSpeed = 100000
        Me.CircularProgressBar1.Name = "CircularProgressBar1"
        Me.CircularProgressBar1.OuterColor = System.Drawing.Color.LightGray
        Me.CircularProgressBar1.OuterMargin = -25
        Me.CircularProgressBar1.OuterWidth = 26
        Me.CircularProgressBar1.ProgressColor = System.Drawing.Color.LimeGreen
        Me.CircularProgressBar1.ProgressWidth = 20
        Me.CircularProgressBar1.SecondaryFont = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.CircularProgressBar1.Size = New System.Drawing.Size(175, 175)
        Me.CircularProgressBar1.StartAngle = 180
        Me.CircularProgressBar1.Step = 1
        Me.CircularProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.CircularProgressBar1.SubscriptColor = System.Drawing.Color.Red
        Me.CircularProgressBar1.SubscriptMargin = New System.Windows.Forms.Padding(10, -35, 0, 0)
        Me.CircularProgressBar1.SubscriptText = ""
        Me.CircularProgressBar1.SuperscriptColor = System.Drawing.Color.Red
        Me.CircularProgressBar1.SuperscriptMargin = New System.Windows.Forms.Padding(10, 35, 0, 0)
        Me.CircularProgressBar1.SuperscriptText = "%"
        Me.CircularProgressBar1.TabIndex = 38
        Me.CircularProgressBar1.TextMargin = New System.Windows.Forms.Padding(8, 8, 0, 0)
        Me.CircularProgressBar1.Value = 68
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(474, 526)
        Me.Controls.Add(Me.CircularProgressBar1)
        Me.Controls.Add(Me.vrsta_akta_buton)
        Me.Controls.Add(Me.o_programu_buton)
        Me.Controls.Add(Me.pregled_skeniranih_podataka_buton)
        Me.Controls.Add(Me.reset_skena_buton)
        Me.Controls.Add(Me.kreiraj_pdf_buton)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.broj_skena_textbox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.novi_sken_buton)
        Me.Controls.Add(Me.crveni_kriz_3)
        Me.Controls.Add(Me.crveni_kriz_2)
        Me.Controls.Add(Me.zelena_kvacica_6)
        Me.Controls.Add(Me.zelena_kvacica_5)
        Me.Controls.Add(Me.zelena_kvacica_1)
        Me.Controls.Add(Me.start_radnog_dana_buton)
        Me.Controls.Add(Me.zavrsi_dan_buton)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.metapodaci_buton)
        Me.Controls.Add(Me.skeniraj_buton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "GZS povratnice"
        CType(Me.zelena_kvacica_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.zelena_kvacica_5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.zelena_kvacica_6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.crveni_kriz_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.crveni_kriz_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.zelena_kvacica_s, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.zelena_kvacica_m, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.zelena_kvacica_v, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.zelena_kvacica_k, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents skeniraj_buton As Button
    Friend WithEvents metapodaci_buton As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents zavrsi_dan_buton As Button
    Friend WithEvents start_radnog_dana_buton As Button
    Friend WithEvents zelena_kvacica_1 As PictureBox
    Friend WithEvents zelena_kvacica_5 As PictureBox
    Friend WithEvents zelena_kvacica_6 As PictureBox
    Friend WithEvents crveni_kriz_2 As PictureBox
    Friend WithEvents crveni_kriz_3 As PictureBox
    Friend WithEvents novi_sken_buton As Button
    Friend WithEvents zelena_kvacica_s As PictureBox
    Friend WithEvents zelena_kvacica_m As PictureBox
    Friend WithEvents sken_check As CheckBox
    Friend WithEvents metapodaci_check As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents broj_skena_textbox As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents kreiran_pdf_check As CheckBox
    Friend WithEvents zelena_kvacica_k As PictureBox
    Friend WithEvents kreiraj_pdf_buton As Button
    Friend WithEvents reset_skena_buton As Button
    Friend WithEvents pregled_skeniranih_podataka_buton As Button
    Friend WithEvents o_programu_buton As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents zelena_kvacica_v As PictureBox
    Friend WithEvents vrsta_akta_checkbox As CheckBox
    Friend WithEvents vrsta_akta_buton As Button
    Friend WithEvents CircularProgressBar1 As CircularProgressBar.CircularProgressBar
End Class
