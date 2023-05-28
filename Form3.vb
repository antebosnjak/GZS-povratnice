Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        zupanija_skeniranja = combobox_zupanija.Text
        tip_odjela = combobox_tip_odjela.Text
        nadlezni_odjel = combobox_nadlezni_odjel.Text

        My.Settings.zupanija_skeniranja = zupanija_skeniranja
        My.Settings.tip_odjela = tip_odjela
        My.Settings.nadlezni_odjel = nadlezni_odjel


        If zupanija_skeniranja = "" Or tip_odjela = "" Or nadlezni_odjel = "" Then

            MsgBox("Unesi sve postavke! ", MsgBoxStyle.Exclamation, "GZS sken")
            Exit Sub
        End If



        If zupanija_skeniranja <> "" And tip_odjela <> "" Or nadlezni_odjel = "" Then
            Form1.zelena_kvacica_5.Visible = True
            Form1.crveni_kriz_2.Visible = False
        Else
            Form1.crveni_kriz_2.Visible = True
            Form1.zelena_kvacica_5.Visible = False
        End If




        If zupanija_skeniranja <> "" And tip_odjela <> "" And nadlezni_odjel <> "" Then

            Form1.start_radnog_dana_buton.Enabled = True
            Form1.zelena_kvacica_1.Visible = False


            Form1.skeniraj_buton.Enabled = False
            Form1.sken_check.Enabled = False
            Form1.potpis_check.Enabled = False
            Form1.metapodaci_check.Enabled = False

            Form1.digitalni_potpis_buton.Enabled = False
            Form1.metapodaci_buton.Enabled = False
            Form1.novi_sken_buton.Enabled = False
            Form1.zavrsi_dan_buton.Enabled = False
            Form1.reset_skena_buton.Enabled = False
        Else
            Form1.start_radnog_dana_buton.Enabled = False
            Form1.zelena_kvacica_1.Visible = False


            Form1.skeniraj_buton.Enabled = False
            Form1.sken_check.Enabled = False
            Form1.potpis_check.Enabled = False
            Form1.metapodaci_check.Enabled = False

            Form1.digitalni_potpis_buton.Enabled = False
            Form1.metapodaci_buton.Enabled = False
            Form1.novi_sken_buton.Enabled = False
            Form1.zavrsi_dan_buton.Enabled = False
            Form1.reset_skena_buton.Enabled = False
        End If



        Me.Close()

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If start_radnog_dana = True Then
            combobox_zupanija.Enabled = False
            combobox_tip_odjela.Enabled = False
            combobox_nadlezni_odjel.Enabled = False

            Button1.Enabled = False


        End If




        zupanija_skeniranja = My.Settings.zupanija_skeniranja
        tip_odjela = My.Settings.tip_odjela
        nadlezni_odjel = My.Settings.nadlezni_odjel



        combobox_zupanija.Text = zupanija_skeniranja
        combobox_tip_odjela.Text = tip_odjela
        combobox_nadlezni_odjel.Text = nadlezni_odjel





        If combobox_zupanija.Items.Count > 0 And zupanija_skeniranja = "" Then
            combobox_zupanija.SelectedIndex = 0    ' The first item has index 0 '

        Else
            combobox_zupanija.Text = zupanija_skeniranja
        End If

        If combobox_tip_odjela.Items.Count > 0 And tip_odjela = "" Then
            combobox_zupanija.SelectedIndex = 0    ' The first item has index 0 '

        Else
            combobox_tip_odjela.Text = tip_odjela
        End If




    End Sub











    Private Sub tip_odjela_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combobox_tip_odjela.SelectedIndexChanged







        combobox_nadlezni_odjel.Items.Clear()
        combobox_nadlezni_odjel.Text = ""



        If combobox_tip_odjela.SelectedItem = "Ured" And combobox_zupanija.SelectedItem = "Bjelovarsko-bilogorska županija" Then
            combobox_nadlezni_odjel.Items.Add("Grad Bjelovar, Upravni odjel za komunalne djelatnosti i uređenje prostora")



            combobox_nadlezni_odjel.SelectedIndex = 0

        ElseIf combobox_tip_odjela.SelectedItem = "Ispostava" And combobox_zupanija.SelectedItem = "Bjelovarsko-bilogorska županija" Then

            combobox_nadlezni_odjel.Items.Add("Odsjek za prostorno uređenje i gradnju Bjelovar")
            combobox_nadlezni_odjel.Items.Add("Pododsjek Čazma")
            combobox_nadlezni_odjel.Items.Add("Pododsjek Grubišno Polje")
            combobox_nadlezni_odjel.Items.Add("Odsjek Daruvar")
            combobox_nadlezni_odjel.Items.Add("Odsjek Garešnica")


            combobox_nadlezni_odjel.SelectedIndex = 0
        ElseIf combobox_tip_odjela.SelectedItem = "Ured" And combobox_zupanija.SelectedItem = "Brodsko-posavska županija" Then
            combobox_nadlezni_odjel.Items.Add("Grad Slavonski Brod, Upravni odjel za graditeljstvo, prostorno uređenje i zaštitu okoliša")



            combobox_nadlezni_odjel.SelectedIndex = 0
        ElseIf combobox_tip_odjela.SelectedItem = "Ispostava" And combobox_zupanija.SelectedItem = "Brodsko-posavska županija" Then

            combobox_nadlezni_odjel.Items.Add("Sjedište Slavonski Brod")
            combobox_nadlezni_odjel.Items.Add("Ispostava Nova Gradiška")


            combobox_nadlezni_odjel.SelectedIndex = 0
            '***************
        ElseIf combobox_tip_odjela.SelectedItem = "Ured" And combobox_zupanija.SelectedItem = "Dubrovačko-neretvanska županija" Then
            combobox_nadlezni_odjel.Items.Add("Grad Dubrovnik, Upravni odjel za izdavanje i provedbu dokumenata prostornog uređenja i gradnje")
            combobox_nadlezni_odjel.Items.Add("Grad Dubrovnik, Upravni odjel za urbanizam, prostorno planiranje i zaštitu okoliša")



            combobox_nadlezni_odjel.SelectedIndex = 0


        ElseIf combobox_tip_odjela.SelectedItem = "Ispostava" And combobox_zupanija.SelectedItem = "Dubrovačko-neretvanska županija" Then

            '*******************
            combobox_nadlezni_odjel.Items.Add("Ispostava Konavle")
            combobox_nadlezni_odjel.Items.Add("Ispostava Korčula")
            combobox_nadlezni_odjel.Items.Add("Ispostava Metković")
            combobox_nadlezni_odjel.Items.Add("Sjedište Dubrovnik")
            combobox_nadlezni_odjel.Items.Add("Ispostava Ploče")
            combobox_nadlezni_odjel.Items.Add("Ispostava Vela Luka")
            combobox_nadlezni_odjel.SelectedIndex = 0
            '***************
        ElseIf combobox_tip_odjela.SelectedItem = "Ured" And combobox_zupanija.SelectedItem = "Istarska županija" Then

            combobox_nadlezni_odjel.Items.Add("Grad Poreč, Upravni odjel za prostorno uređenje i gradnju")
            combobox_nadlezni_odjel.Items.Add("Grad Pula, Upravni odjel za prostorno planiranje i zaštitu okoliša, Odsjek za gradnju")
            combobox_nadlezni_odjel.Items.Add("Općina Medulin, Upravni odjel za prostorno planiranje i zaštitu okoliša")
            combobox_nadlezni_odjel.Items.Add("Općina Tar-Vabriga - Torre-Abrega, Jedinstveni upravni odjel")
            combobox_nadlezni_odjel.Items.Add("Općina Višnjan, Jedinstveni upravni odjel, Odsjek za komunalni sustav, prostorno planiranje i gradnju")
            combobox_nadlezni_odjel.Items.Add("Grad Rovinj-Rovigno, Upravni odjel za prostorno planiranje, zaštitu okoliša i izdavanje akata")
            combobox_nadlezni_odjel.Items.Add("Grad Vodnjan-Dignano, Upravni odjel za prostorno uređenje, komunalni sustav, gradnju i zaštitu okoliša")
            combobox_nadlezni_odjel.Items.Add("Grad Pazin, Upravni odjel za komunalni sustav, prostorno uređenje i graditeljstvo")
            combobox_nadlezni_odjel.Items.Add("Grad Umag, Upravni odjel za komunalni sustav i prostorno planiranje")
            combobox_nadlezni_odjel.Items.Add("Grad Labin, Upravni odjel za prostorno uređenje, zaštitu okoliša i izdavanje akata za gradnju, Odsjek za prostorno uređenje i izdavanje akata za gradnju")
            combobox_nadlezni_odjel.Items.Add("Grad Novigrad - Cittanova, Upravni odjel za komunalni sustav, prostorno uređenje, zaštitu okoliša, Odsjek za prostorno uređenje i graditeljstvo")




            combobox_nadlezni_odjel.SelectedIndex = 0

        ElseIf combobox_tip_odjela.SelectedItem = "Ispostava" And combobox_zupanija.SelectedItem = "Istarska županija" Then

            '*******************

            combobox_nadlezni_odjel.Items.Add("Odsjek za prostorno uređenje i gradnju Buje-Buie")
            combobox_nadlezni_odjel.Items.Add("Odsjek za prostorno uređenje i gradnju Buzet")
            combobox_nadlezni_odjel.Items.Add("Odsjek za prostorno uređenje i gradnju Labin")
            combobox_nadlezni_odjel.Items.Add("Odsjek za prostorno uređenje i gradnju Pazin")
            combobox_nadlezni_odjel.Items.Add("Odsjek za prostorno uređenje i gradnju Poreč-Parenzo")
            combobox_nadlezni_odjel.Items.Add("Odsjek za prostorno uređenje i gradnju Pula-Pola")
            combobox_nadlezni_odjel.Items.Add("Odsjek za prostorno uređenje i gradnju Rovinj-Rovigno")

            combobox_nadlezni_odjel.Items.Add("Sjedište Pula")

            combobox_nadlezni_odjel.SelectedIndex = 0

            '***************
        ElseIf combobox_tip_odjela.SelectedItem = "Ured" And combobox_zupanija.SelectedItem = "Karlovačka županija" Then



            combobox_nadlezni_odjel.Items.Add("Grad Karlovac, Upravni odjel za prostorno uređenje i poslove provedbe dokumenata prostornog uređenja")





            combobox_nadlezni_odjel.SelectedIndex = 0

        ElseIf combobox_tip_odjela.SelectedItem = "Ispostava" And combobox_zupanija.SelectedItem = "Karlovačka županija" Then


            combobox_nadlezni_odjel.Items.Add("Odsjek za prostorno uređenje i graditeljstvo")

            '*******************

            'combobox_nadlezni_odjel.SelectedIndex = 0
            '***************
        ElseIf combobox_tip_odjela.SelectedItem = "Ured" And combobox_zupanija.SelectedItem = "Koprivničko-križevačka županija" Then

            combobox_nadlezni_odjel.Items.Add("Grad Koprivnica, Upravni odjel za prostorno uređenje")





            combobox_nadlezni_odjel.SelectedIndex = 0

        ElseIf combobox_tip_odjela.SelectedItem = "Ispostava" And combobox_zupanija.SelectedItem = "Koprivničko-križevačka županija" Then

            '*******************
            combobox_nadlezni_odjel.Items.Add("Sjedište Koprivnica")
            combobox_nadlezni_odjel.Items.Add("Izdvojeno mjesto rada u Križevcima")
            combobox_nadlezni_odjel.Items.Add("Izdvojeno mjesto rada u Đurđevcu")

            combobox_nadlezni_odjel.SelectedIndex = 0

            '***************
        ElseIf combobox_tip_odjela.SelectedItem = "Ured" And combobox_zupanija.SelectedItem = "Krapinsko-zagorska županija" Then



            combobox_nadlezni_odjel.Items.Add("Grad Krapina, Upravni odjel za prostorno uređenje, gradnju, zaštitu okoliša i komunalno gospodarstvo, Odsjek  za prostorno uređenje, gradnju i zaštitu okoliša")





            combobox_nadlezni_odjel.SelectedIndex = 0


        ElseIf combobox_tip_odjela.SelectedItem = "Ispostava" And combobox_zupanija.SelectedItem = "Krapinsko-zagorska županija" Then

            '*******************

            combobox_nadlezni_odjel.Items.Add("Ispostava Zabok")

            combobox_nadlezni_odjel.Items.Add("Ispostava Zlatar")

            combobox_nadlezni_odjel.Items.Add("Sjedište Krapina")

            combobox_nadlezni_odjel.Items.Add("Ispostava Pregrada")

            combobox_nadlezni_odjel.Items.Add("Ispostava Klanjec")

            combobox_nadlezni_odjel.Items.Add("Ispostava Donja Stubica")
            combobox_nadlezni_odjel.SelectedIndex = 0
            '***************
        ElseIf combobox_tip_odjela.SelectedItem = "Ured" And combobox_zupanija.SelectedItem = "Ličko-senjska županija" Then
            combobox_nadlezni_odjel.Items.Add("Grad Gospić, Gradski upravni odjel za prostorno uređenje i gradnju")






            combobox_nadlezni_odjel.SelectedIndex = 0


        ElseIf combobox_tip_odjela.SelectedItem = "Ispostava" And combobox_zupanija.SelectedItem = "Ličko-senjska županija" Then

            '*******************

            combobox_nadlezni_odjel.Items.Add("Izdvojeno mjesto rada Otočac")
            combobox_nadlezni_odjel.Items.Add("Izdvojeno mjesto rada Senj")


            combobox_nadlezni_odjel.Items.Add("Izdvojeno mjesto rada Korenica")
            combobox_nadlezni_odjel.Items.Add("Izdvojeno mjesto rada Novalja")
            combobox_nadlezni_odjel.Items.Add("Sjedište Gospić")
            combobox_nadlezni_odjel.SelectedIndex = 0
            '***************
        ElseIf combobox_tip_odjela.SelectedItem = "Ured" And combobox_zupanija.SelectedItem = "Međimurska županija" Then

            combobox_nadlezni_odjel.Items.Add("Grad Čakovec, Upravni odjel za prostorno planiranje, urbanizam i zaštitu okoliša, Odsjek za izdavanje akata o gradnji")





            combobox_nadlezni_odjel.SelectedIndex = 0

        ElseIf combobox_tip_odjela.SelectedItem = "Ispostava" And combobox_zupanija.SelectedItem = "Međimurska županija" Then

            '*******************

            combobox_nadlezni_odjel.Items.Add("Sjedište Čakovec")
            combobox_nadlezni_odjel.Items.Add("Ispostava Prelog")
            combobox_nadlezni_odjel.SelectedIndex = 0
            '***************
        ElseIf combobox_tip_odjela.SelectedItem = "Ured" And combobox_zupanija.SelectedItem = "Osječko-baranjska županija" Then

            combobox_nadlezni_odjel.Items.Add("Đakovo")
            combobox_nadlezni_odjel.Items.Add("Donji Miholjac")

            combobox_nadlezni_odjel.Items.Add("Beli Manastir")
            combobox_nadlezni_odjel.Items.Add("Grad Osijek, Upravni odjel za urbanizam")
            combobox_nadlezni_odjel.Items.Add("Valpovo")



            combobox_nadlezni_odjel.SelectedIndex = 0

        ElseIf combobox_tip_odjela.SelectedItem = "Ispostava" And combobox_zupanija.SelectedItem = "Osječko-baranjska županija" Then

            '*******************
            combobox_nadlezni_odjel.Items.Add("Osijek")
            combobox_nadlezni_odjel.Items.Add("Našice")

            combobox_nadlezni_odjel.SelectedIndex = 0
            '***************
        ElseIf combobox_tip_odjela.SelectedItem = "Ured" And combobox_zupanija.SelectedItem = "Požeško-slavonska županija" Then

        ElseIf combobox_tip_odjela.SelectedItem = "Ispostava" And combobox_zupanija.SelectedItem = "Požeško-slavonska županija" Then

            '*******************
            combobox_nadlezni_odjel.Items.Add("Sjedište Požega")


            combobox_nadlezni_odjel.Items.Add("Ispostava Pakrac")
            combobox_nadlezni_odjel.SelectedIndex = 0
            '***************
        ElseIf combobox_tip_odjela.SelectedItem = "Ured" And combobox_zupanija.SelectedItem = "Primorsko-goranska županija" Then

            combobox_nadlezni_odjel.Items.Add("Grad Rijeka, Odjel za provedbu dokumenata prostornog uređenja i građenje")




            combobox_nadlezni_odjel.SelectedIndex = 0

        ElseIf combobox_tip_odjela.SelectedItem = "Ispostava" And combobox_zupanija.SelectedItem = "Primorsko-goranska županija" Then

            '*******************


            combobox_nadlezni_odjel.Items.Add("Sjedište Rijeka")


            combobox_nadlezni_odjel.Items.Add("Ispostava Krk")


            combobox_nadlezni_odjel.Items.Add("Ispostava Mali Lošinj")
            combobox_nadlezni_odjel.Items.Add("Ispostava Opatija")

            combobox_nadlezni_odjel.Items.Add("Ispostava Rab")

            combobox_nadlezni_odjel.Items.Add("Ispostava Crikvenica")
            combobox_nadlezni_odjel.Items.Add("Ispostava Delnice")

            combobox_nadlezni_odjel.SelectedIndex = 0


            '***************
        ElseIf combobox_tip_odjela.SelectedItem = "Ured" And combobox_zupanija.SelectedItem = "Sisačko-moslavačka Županija" Then

            combobox_nadlezni_odjel.Items.Add("Grad Kutina, Upravni odjel za prostorno uređenje i graditeljstvo")

            combobox_nadlezni_odjel.Items.Add("Grad Sisak, Upravni odjel za prostorno uređenje i zaštitu okoliša")

            combobox_nadlezni_odjel.Items.Add("Grad Petrinja, Upravni odjel za prostorno uređenje, graditeljstvo i komunalne djelatnosti")




            combobox_nadlezni_odjel.SelectedIndex = 0


        ElseIf combobox_tip_odjela.SelectedItem = "Ispostava" And combobox_zupanija.SelectedItem = "Sisačko-moslavačka Županija" Then

            '*******************
            combobox_nadlezni_odjel.Items.Add("Sjedište Sisak")

            combobox_nadlezni_odjel.Items.Add("Ispostava Popovača")
            combobox_nadlezni_odjel.Items.Add("Ispostava Novska")

            combobox_nadlezni_odjel.Items.Add("Ispostava Glina")

            combobox_nadlezni_odjel.SelectedIndex = 0
            '***************
        ElseIf combobox_tip_odjela.SelectedItem = "Ured" And combobox_zupanija.SelectedItem = "Splitsko-dalmatinska županija" Then

            combobox_nadlezni_odjel.Items.Add("Grad Makarska, Upravni odjel za prostorno uređenje i graditeljstvo,  Odsjek za graditeljstvo i zaštitu okoliša")
            combobox_nadlezni_odjel.Items.Add("Grad Kaštela, Upravni odjel za prostorno uređenje i zaštitu okoliša")

            combobox_nadlezni_odjel.Items.Add("Grad Split, Upravni odjel za prostorno planiranje, uređenje i zaštitu okoliša")
            combobox_nadlezni_odjel.Items.Add("Grad Trogir, Upravni odjel za urbanizam i prostorno uređenje")




            combobox_nadlezni_odjel.SelectedIndex = 0


        ElseIf combobox_tip_odjela.SelectedItem = "Ispostava" And combobox_zupanija.SelectedItem = "Splitsko-dalmatinska županija" Then

            '*******************
            combobox_nadlezni_odjel.Items.Add("Ispostava Hvar")
            combobox_nadlezni_odjel.Items.Add("Ispostava Imotski")
            combobox_nadlezni_odjel.Items.Add("Ispostava Sinj")
            combobox_nadlezni_odjel.Items.Add("Ispostava Solin")
            combobox_nadlezni_odjel.Items.Add("Ispostava Supetar")

            combobox_nadlezni_odjel.Items.Add("Sjedište Split")
            combobox_nadlezni_odjel.Items.Add("Ispostava Trogir")
            combobox_nadlezni_odjel.Items.Add("Ispostava Makarska")
            combobox_nadlezni_odjel.Items.Add("Ispostava Vis")
            combobox_nadlezni_odjel.Items.Add("Ispostava Vrgorac")

            combobox_nadlezni_odjel.Items.Add("Ispostava Omiš")

            combobox_nadlezni_odjel.SelectedIndex = 0

            '***************
        ElseIf combobox_tip_odjela.SelectedItem = "Ured" And combobox_zupanija.SelectedItem = "Šibensko-kninska županija" Then





            combobox_nadlezni_odjel.Items.Add("Grad Šibenik, Upravni odjel za provedbu dokumenata prostornog uređenja i gradnju")





            combobox_nadlezni_odjel.SelectedIndex = 0


        ElseIf combobox_tip_odjela.SelectedItem = "Ispostava" And combobox_zupanija.SelectedItem = "Šibensko-kninska županija" Then

            '*******************
            combobox_nadlezni_odjel.Items.Add("Ispostava Knin")
            combobox_nadlezni_odjel.Items.Add("Sjedište Šibenik")
            combobox_nadlezni_odjel.Items.Add("Ispostava Rogoznica")
            combobox_nadlezni_odjel.Items.Add("Ispostava Drniš")

            combobox_nadlezni_odjel.SelectedIndex = 0

            '***************
        ElseIf combobox_tip_odjela.SelectedItem = "Ured" And combobox_zupanija.SelectedItem = "Varaždinska županija" Then





            combobox_nadlezni_odjel.Items.Add("Grad Varaždin, Upravni odjel za gradnju i komunalno gospodarstvo, Odsjek za provedbu dokumenata prostornog uređenja i građenja")




            combobox_nadlezni_odjel.SelectedIndex = 0

        ElseIf combobox_tip_odjela.SelectedItem = "Ispostava" And combobox_zupanija.SelectedItem = "Varaždinska županija" Then

            '*******************
            combobox_nadlezni_odjel.Items.Add("Ispostava Ludbreg")
            combobox_nadlezni_odjel.Items.Add("Ispostava Ivanec")
            combobox_nadlezni_odjel.Items.Add("Sjedište Varaždin")
            combobox_nadlezni_odjel.Items.Add("Ispostava Novi Marof")
            '***************
            combobox_nadlezni_odjel.SelectedIndex = 0
        ElseIf combobox_tip_odjela.SelectedItem = "Ured" And combobox_zupanija.SelectedItem = "Virovitičko-podravska županija" Then



            combobox_nadlezni_odjel.Items.Add("Grad Virovitica, Upravni odjel za komunalne poslove, prostorno uređenje i graditeljstvo, Odsjek za prostorno uređenje")




            combobox_nadlezni_odjel.SelectedIndex = 0

        ElseIf combobox_tip_odjela.SelectedItem = "Ispostava" And combobox_zupanija.SelectedItem = "Virovitičko-podravska županija" Then

            '*******************
            combobox_nadlezni_odjel.Items.Add("Sjedište Virovitica")
            combobox_nadlezni_odjel.Items.Add("Izdvojeno mjesto rada Slatina")
            combobox_nadlezni_odjel.Items.Add("Izdvojeno mjesto rada Orahovica")
            combobox_nadlezni_odjel.SelectedIndex = 0

            '***************
        ElseIf combobox_tip_odjela.SelectedItem = "Ured" And combobox_zupanija.SelectedItem = "Vukovarsko-srijemska županija" Then


            combobox_nadlezni_odjel.Items.Add("Ilok")


            combobox_nadlezni_odjel.Items.Add("Grad Vukovar, Upravni odjel za prostorno uređenje i imovinu")
            combobox_nadlezni_odjel.Items.Add("Grad Vinkovci, Upravni odjel za prostorno uređenje, gradnju i zaštitu okoliša")



            combobox_nadlezni_odjel.SelectedIndex = 0
        ElseIf combobox_tip_odjela.SelectedItem = "Ispostava" And combobox_zupanija.SelectedItem = "Vukovarsko-srijemska županija" Then

            '*******************
            combobox_nadlezni_odjel.Items.Add("Vinkovci")
            combobox_nadlezni_odjel.Items.Add("Vukovar")
            combobox_nadlezni_odjel.Items.Add("Županja")
            combobox_nadlezni_odjel.Items.Add("Otok")

            combobox_nadlezni_odjel.SelectedIndex = 0

            '***************
        ElseIf combobox_tip_odjela.SelectedItem = "Ured" And combobox_zupanija.SelectedItem = "Zadarska županija" Then




            combobox_nadlezni_odjel.Items.Add("Grad Zadar, Upravni odjel za prostorno uređenje i graditeljstvo")





            combobox_nadlezni_odjel.SelectedIndex = 0


        ElseIf combobox_tip_odjela.SelectedItem = "Ispostava" And combobox_zupanija.SelectedItem = "Zadarska županija" Then

            '*******************
            combobox_nadlezni_odjel.Items.Add("Zadar")

            combobox_nadlezni_odjel.Items.Add("Benkovac")
            combobox_nadlezni_odjel.Items.Add("Biograd na Moru")

            combobox_nadlezni_odjel.Items.Add("Gračac")

            combobox_nadlezni_odjel.Items.Add("Obrovac")

            combobox_nadlezni_odjel.Items.Add("Pag")


            combobox_nadlezni_odjel.SelectedIndex = 0
            '***************
        ElseIf combobox_tip_odjela.SelectedItem = "Ured" And combobox_zupanija.SelectedItem = "Zagrebačka županija" Then

            combobox_nadlezni_odjel.Items.Add("Grad Samobor, Upravni odjel za provođenje dokumenata prostornog uređenja i gradnju")


            combobox_nadlezni_odjel.Items.Add("Grad Velika Gorica, Upravni odjel za provedbu dokumenata prostornog uređenja i građenja")





            combobox_nadlezni_odjel.SelectedIndex = 0
        ElseIf combobox_tip_odjela.SelectedItem = "Ispostava" And combobox_zupanija.SelectedItem = "Zagrebačka županija" Then

            '*******************
            combobox_nadlezni_odjel.Items.Add("Ispostava Dugo Selo")

            combobox_nadlezni_odjel.Items.Add("Ispostava Zaprešić")
            combobox_nadlezni_odjel.Items.Add("Ispostava Velika Gorica")
            combobox_nadlezni_odjel.Items.Add("Ispostava Sveta Nedelja")
            combobox_nadlezni_odjel.Items.Add("Ispostava Sveti Ivan Zelina")
            combobox_nadlezni_odjel.Items.Add("Ispostava Jastrebarsko")
            combobox_nadlezni_odjel.Items.Add("Ispostava Ivanić-Grad")

            combobox_nadlezni_odjel.Items.Add("Ispostava Vrbovec")

            combobox_nadlezni_odjel.SelectedIndex = 0
            '***************
        ElseIf combobox_tip_odjela.SelectedItem = "Ured" And combobox_zupanija.SelectedItem = "Grad Zagreb" Then

            combobox_nadlezni_odjel.Items.Add("Četvrti područni odsjek za graditeljstvo (za PU Susedgrad)")

            combobox_nadlezni_odjel.Items.Add("Drugi područni odsjek za graditeljstvo (za PU Novi Zagreb i Peščenica)")
            combobox_nadlezni_odjel.Items.Add("Drugi područni odsjek za prostorno uređenje (za PU Novi Zagreb i Peščenica)")
            combobox_nadlezni_odjel.Items.Add("Šesti područni odsjek za graditeljstvo (za PU Dubrava)")
            combobox_nadlezni_odjel.Items.Add("Grad Zagreb")
            combobox_nadlezni_odjel.Items.Add("Treći područni odsjek za graditeljstvo (za PU Sesvete)")



            combobox_nadlezni_odjel.SelectedIndex = 0

        ElseIf combobox_tip_odjela.SelectedItem = "Ispostava" And combobox_zupanija.SelectedItem = "Grad Zagreb" Then

            '*******************
            combobox_nadlezni_odjel.Items.Add("Sjedište Zagreb")
            combobox_nadlezni_odjel.Items.Add("Susedgrad i Trešnjevka")
            combobox_nadlezni_odjel.Items.Add("Peti područni odsjek za graditeljstvo (za PU Trešnjevka)")
            combobox_nadlezni_odjel.Items.Add("Maksimir i Medveščak")

            combobox_nadlezni_odjel.SelectedIndex = 0

            '***************
        ElseIf combobox_tip_odjela.SelectedItem = "Ured" And combobox_zupanija.SelectedItem = "Ministarstvo prostornog uređenja, graditeljstva i državne imovine" Then


            combobox_nadlezni_odjel.Items.Add("Ministarstvo prostornoga uređenja, graditeljstva i državne imovine, Sektor građevinskih i uporabnih dozvola")
            combobox_nadlezni_odjel.Items.Add("Ministarstvo prostornoga uređenja, graditeljstva i državne imovine, Sektor lokacijskih dozvola i investicija")





            combobox_nadlezni_odjel.SelectedIndex = 0


        ElseIf combobox_tip_odjela.SelectedItem = "Ispostava" And combobox_zupanija.SelectedItem = "Ministarstvo prostornog uređenja, graditeljstva i državne imovine" Then

            '*******************
            combobox_nadlezni_odjel.Items.Add("Središnji odsjek za graditeljstvo")
            combobox_nadlezni_odjel.Items.Add("Središnji odsjek za prostorno uređenje")

            combobox_nadlezni_odjel.SelectedIndex = 0

        End If





    End Sub

    Private Sub combobox_tip_odjela_MouseClick(sender As Object, e As MouseEventArgs) Handles combobox_tip_odjela.MouseClick



        combobox_nadlezni_odjel.Items.Clear()
        combobox_nadlezni_odjel.Text = ""
    End Sub

    Private Sub combobox_zupanija_MouseClick(sender As Object, e As MouseEventArgs) Handles combobox_zupanija.MouseClick



        'combobox_tip_odjela.Items.Clear()
        'combobox_tip_odjela.Text = ""


    End Sub

    Private Sub combobox_zupanija_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combobox_zupanija.SelectedIndexChanged

        combobox_nadlezni_odjel.Items.Clear()
        combobox_nadlezni_odjel.Text = ""
        combobox_tip_odjela.Items.Clear()
        combobox_tip_odjela.Text = ""

        combobox_tip_odjela.Items.Add("Ispostava")
        combobox_tip_odjela.Items.Add("Ured")




    End Sub
End Class