using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooloskiVrt.Common.Domen;
using ZooloskiVrt.Klijent.Forme.UserControls.Zivotinje;

namespace ZooloskiVrt.Klijent.Forme.GUIController
{
    public class DodajZivotinjuKontroler
    {
        private UCDodajZivotinju uCDodajZivotinju;
        private Zivotinja zivotinja = new Zivotinja();

        public DodajZivotinjuKontroler(UCDodajZivotinju uCDodajZivotinju)
        {
            this.uCDodajZivotinju = uCDodajZivotinju;
        }

        public void Inicijalizuj(UCDodajZivotinju uc)
        {
            uc.CmbPol.DataSource = Enum.GetValues(typeof(Pol));
            uc.CmbTipIshrane.DataSource = Enum.GetValues(typeof(TipIshrane));
            OsveziDgv(uc);
            uc.BtnDodaj.Click += BtnDodaj_Click;
        }

        private void OsveziDgv(UCDodajZivotinju uc)
        {
            uc.DgvZivotinje.DataSource = new BindingList<Zivotinja>(Komunikacija.Instance.ZahtevajIVratiRezultat<List<Zivotinja>>(Common.Komunikacija.Operacija.VratiSveZivotinje));
        }

        private void BtnDodaj_Click(object sender, EventArgs e)
        {
            if (!ValidacijaDodavanjaZivotinje())
            {
                return;
            }
            NapuniZivotinju(uCDodajZivotinju);
            Komunikacija.Instance.ZahtevajBezVracanja(Common.Komunikacija.Operacija.DodajZivotinju, zivotinja);
            OsveziDgv(uCDodajZivotinju);
            System.Windows.Forms.MessageBox.Show("Uspesno dodavanje");
        }

        private void NapuniZivotinju(UCDodajZivotinju uc)
        {
            zivotinja.Pol = (Pol)uc.CmbPol.SelectedItem;
            zivotinja.Staniste = uc.TxtStaniste.Text;
            zivotinja.Starost = int.Parse(uc.TxtStarost.Text);
            zivotinja.TipIshrane = (TipIshrane)uc.CmbTipIshrane.SelectedItem;
            zivotinja.Vrsta = uc.TxtVrsta.Text;
        }

        private bool ValidacijaDodavanjaZivotinje()
        {
            if(string.IsNullOrEmpty(uCDodajZivotinju.TxtStaniste.Text)||
                string.IsNullOrEmpty(uCDodajZivotinju.TxtStarost.Text)||
                string.IsNullOrEmpty(uCDodajZivotinju.TxtVrsta.Text))
            {
                System.Windows.Forms.MessageBox.Show("Sva polja su obavezna!");
                return false;
            }
            else if(!int.TryParse(uCDodajZivotinju.TxtStarost.Text,out int starost))
            {
                System.Windows.Forms.MessageBox.Show("Starost mora biti ceo broj");
                return false;
            }
            return true;
        }
    }
}
