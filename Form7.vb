Public Class Form7
    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        vrsta_akta_combobox.Items.Add("Lokacijska dozvola")
        vrsta_akta_combobox.Items.Add("Načelna suglasnost")
        vrsta_akta_combobox.Items.Add("Načelna dozvola")
        vrsta_akta_combobox.Items.Add("Građevinska dozvola")
        vrsta_akta_combobox.Items.Add("Rješenje o izmjeni i dopuni građevinske dozvole")
        vrsta_akta_combobox.Items.Add("Rješenje o poništenju građevinske dozvole")
        vrsta_akta_combobox.Items.Add("Uporabna dozvola za građevine izgrađene do 15.02.1968.")
        vrsta_akta_combobox.Items.Add("Potvrda glavnog projekta")
        vrsta_akta_combobox.Items.Add("Rješenje o uvjetima građenja")
        vrsta_akta_combobox.Items.Add("Rješenje za građenje")
        vrsta_akta_combobox.Items.Add("Uporabna dozvola")
        vrsta_akta_combobox.Items.Add("Potvrda upravnog tijela da je dostavljeno završno izvješće nadzornog inženjera")
        vrsta_akta_combobox.Items.Add("Uvjerenje za uporabu")
        vrsta_akta_combobox.Items.Add("Pravomoćna građevinska dozvola")
        vrsta_akta_combobox.Items.Add("Drugi odgovarajući akt izdan do 19. lipnja 1991. s potvrdom građevinske inspekcije da nije u tijeku postupak građevinske inspekcije")
        vrsta_akta_combobox.Items.Add("Dozvola za upotrebu")
        vrsta_akta_combobox.Items.Add("Uvjerenje katastarskog ureda, odnosno Središnjeg ureda Državne geodetske uprave da je zgrada izgrađena do 15. veljače 1968.")
        vrsta_akta_combobox.Items.Add("Uvjerenje upravnog tijela da je zgrada izgrađena do 15. veljače 1968.")
        vrsta_akta_combobox.Items.Add("Uporabna dozvola za građevinu izgrađenu na temelju akta za građenje izdanog do 1. listopada 2007.")
        vrsta_akta_combobox.Items.Add("Uporabna dozvola za građevinu izgrađenu, rekonstruiranu, obnovljenu ili saniranu u provedbi propisa o obnovi, odnosno propisa o područjima posebne državne skrbi")
        vrsta_akta_combobox.Items.Add("Uporabna dozvola za građevine čiji je akt za građenje uništen ili nedostupan")
        vrsta_akta_combobox.Items.Add("Uporabna dozvola za građevinu koju je Republika Hrvatska kupila u svrhu stambenog zbrinjavanja")
        vrsta_akta_combobox.Items.Add("Obavijest o prijavi početka građenja")
        vrsta_akta_combobox.Items.Add("Obavijest o prijavi početka uklanjanja")
        vrsta_akta_combobox.Items.Add("Obavijest o prijavi početka pokusnog rada")
        vrsta_akta_combobox.Items.Add("Rješenje o produženju važenja građevinske dozvole")
        vrsta_akta_combobox.Items.Add("Građevna dozvola")
        vrsta_akta_combobox.Items.Add("Rješenje o produženju važenja građevne dozvole")
        vrsta_akta_combobox.Items.Add("Izmjene i dopune potvrde glavnog projekta")
        vrsta_akta_combobox.Items.Add("Rješenje o izmjeni i dopuni rješenja o uvjetima građenja")
        vrsta_akta_combobox.Items.Add("Dopuna rješenja za građenje")
        vrsta_akta_combobox.Items.Add("Rješenje o građevinskoj dozvoli")
        vrsta_akta_combobox.Items.Add("Rješenje o građevnoj dozvoli")
        vrsta_akta_combobox.Items.Add("Rješenje o izmjeni i dopuni građevne dozvole")
        vrsta_akta_combobox.Items.Add("Građevna dozvola za privođenje konačnoj namjeni")
        vrsta_akta_combobox.Items.Add("Građevna dozvola za jednostavnu građevinu")
        vrsta_akta_combobox.Items.Add("Građevna dozvola za privremeni objekt")
        vrsta_akta_combobox.Items.Add("Rješenje o promjeni investitora")
        vrsta_akta_combobox.Items.Add("Rješenje o izvedenom stanju")
        vrsta_akta_combobox.Items.Add("Rješenje o uvjetima uređenja prostora")
        vrsta_akta_combobox.Items.Add("Uvjerenje o uvjetima uređenja prostora")
        vrsta_akta_combobox.Items.Add("Dozvola za promjenu namjene i uporabu građevine")
        vrsta_akta_combobox.Items.Add("Rješenje o izmjeni i dopuni lokacijske dozvole")
        vrsta_akta_combobox.Items.Add("Rješenje o produženju važenja lokacijske dozvole")
        vrsta_akta_combobox.Items.Add("Uvjerenje o vremenu građenja građevine")
        vrsta_akta_combobox.Items.Add("Odobrenje za građenje")
        vrsta_akta_combobox.Items.Add("Odluka o uklanjanju zgrade (Stožer CZ RH)")


















        vrsta_akta_combobox.SelectedIndex = 0

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        vrsta_akta = vrsta_akta_combobox.SelectedItem


        If vrsta_akta = "" Then

            vrsta_akta = vrsta_akta_combobox.Text
        End If

        Me.Close()

    End Sub
End Class