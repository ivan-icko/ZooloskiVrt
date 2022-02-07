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
    public class PretraziZIvotinjuKontroler
    {
        private UCPretraziZivotinju uc;
        Zivotinja z=new Zivotinja();
        Zivotinja selektovanaZivotinja = new Zivotinja();

        public PretraziZIvotinjuKontroler(UCPretraziZivotinju uc)
        {
            this.uc = uc;
        }

        public void Inicijalizuj()
        {
            OsveziDgv();
            NapuniCmb();
            uc.BtnPretrazi.Click += BtnPretrazi_Click;
            uc.BtnPrikaziSve.Click += BtnPrikaziSve_Click;
            uc.BtnDodaj.Click += BtnDodaj_Click;
            uc.BtnPrikazi.Click += BtnPrikazi_Click;
            uc.BtnObrisi.Click += BtnObrisi_Click;
            uc.BtnAzuriraj.Click += BtnAzuriraj_Click;
        }

        private void BtnAzuriraj_Click(object sender, EventArgs e)
        {
            if (!ValidacijaDodavanjaZivotinje())
            {
                return;
            }
            Zivotinja ziv = new Zivotinja(selektovanaZivotinja.IdZivotinje.ToString(),selektovanaZivotinja.Vrsta,selektovanaZivotinja.Pol.ToString(),selektovanaZivotinja.Starost.ToString(),selektovanaZivotinja.Staniste,selektovanaZivotinja.TipIshrane.ToString());

            ziv.IdZivotinje = int.Parse(uc.TxtId.Text);
            ziv.Vrsta = uc.TxtVrsta.Text;
            ziv.Pol = (Pol)uc.CmbPol.SelectedItem;
            ziv.Starost = int.Parse(uc.TxtStarost.Text);
            ziv.Staniste = uc.TxtStaniste.Text;
            ziv.TipIshrane = (TipIshrane)uc.CmbTipIshrane.SelectedItem;


            Komunikacija.Instance.ZahtevajBezVracanja(Common.Komunikacija.Operacija.AzurirajZivotinju, ziv);
            OsveziDgv();
            System.Windows.Forms.MessageBox.Show("Uspesno ste azurirali zivotinju");

        }

        private void BtnObrisi_Click(object sender, EventArgs e)
        {
            if (uc.DgvPretrazi.SelectedRows.Count == 0)
            {
                System.Windows.Forms.MessageBox.Show("Niste izabrali zivotinju");
                return;
            }

            Zivotinja z = (Zivotinja)uc.DgvPretrazi.SelectedRows[0].DataBoundItem;
            z = new Zivotinja(z.IdZivotinje.ToString(), z.Vrsta, z.Pol.ToString(),z.Starost.ToString(), z.Staniste, z.TipIshrane.ToString());
            Komunikacija.Instance.ZahtevajBezVracanja(Common.Komunikacija.Operacija.ObrisiZivotinju, z);
            System.Windows.Forms.MessageBox.Show("Uspesno ste obrisali zivotinju");
            OsveziDgv();
        }

        private void BtnPrikazi_Click(object sender, EventArgs e)
        {
            if (uc.DgvPretrazi.SelectedRows.Count == 0)
            {
                System.Windows.Forms.MessageBox.Show("Niste odabrali zivotinju za prikaz");
                return;
            }
            selektovanaZivotinja = (Zivotinja)uc.DgvPretrazi.SelectedRows[0].DataBoundItem;
            NapuniPretragu(selektovanaZivotinja);
        }

        private void NapuniPretragu(Zivotinja z)
        {
            uc.TxtId.Text = z.IdZivotinje.ToString();
            uc.TxtVrsta.Text = z.Vrsta.ToString();
            uc.TxtStarost.Text = z.Starost.ToString();
            uc.TxtStaniste.Text = z.Staniste.ToString();
            uc.CmbPol.SelectedItem = z.Pol;
            uc.CmbTipIshrane.SelectedItem = z.TipIshrane;
        }

        private void BtnDodaj_Click(object sender, EventArgs e)
        {
            if (!ValidacijaDodavanjaZivotinje())
            {
                return;
            }
            NapuniZivotinju();
            Komunikacija.Instance.ZahtevajBezVracanja(Common.Komunikacija.Operacija.DodajZivotinju, z);
            OsveziDgv();
            System.Windows.Forms.MessageBox.Show("Uspesno dodavanje");
        }

        private void NapuniZivotinju()
        {
            z.Pol = (Pol)uc.CmbPol.SelectedItem;
            z.Staniste = uc.TxtStaniste.Text;
            z.Starost = int.Parse(uc.TxtStarost.Text);
            z.TipIshrane = (TipIshrane)uc.CmbTipIshrane.SelectedItem;
            z.Vrsta = uc.TxtVrsta.Text;
        }

        private bool ValidacijaDodavanjaZivotinje()
        {
            if (string.IsNullOrEmpty(uc.TxtStaniste.Text) ||
                string.IsNullOrEmpty(uc.TxtStarost.Text) ||
                string.IsNullOrEmpty(uc.TxtVrsta.Text))
            {
                System.Windows.Forms.MessageBox.Show("Sva polja su obavezna!");
                return false;
            }
            else if (!int.TryParse(uc.TxtStarost.Text, out int starost))
            {
                System.Windows.Forms.MessageBox.Show("Starost mora biti ceo broj");
                return false;
            }
            return true;
        }

        private void BtnPrikaziSve_Click(object sender, EventArgs e)
        {
            List<Zivotinja> pronedjene = Komunikacija.Instance.ZahtevajIVratiRezultat<List<Zivotinja>>(Common.Komunikacija.Operacija.VratiSveZivotinje);
            if (pronedjene == null)
            {
                System.Windows.Forms.MessageBox.Show("Ne postoji takva vrsta zivotinje");
                return;
            }
            else { OsveziDgv1(pronedjene); }
        }

        private void NapuniCmb()
        {
            uc.CmbPol.DataSource = Enum.GetValues(typeof(Pol));
            uc.CmbTipIshrane.DataSource = Enum.GetValues(typeof(TipIshrane));
        }

        private void BtnPretrazi_Click(object sender, EventArgs e)
        {
            if (!Validacija())
            {
                return;
            }       
            List<Zivotinja> pronedjene=Komunikacija.Instance.ZahtevajIVratiRezultat<List<Zivotinja>>(Common.Komunikacija.Operacija.PronadjiZivotinje,z);
            if (pronedjene == null)
            {
                System.Windows.Forms.MessageBox.Show("Ne postoji takva vrsta zivotinje");
                return;
            }
            else { OsveziDgv1(pronedjene); }
        }

        private void OsveziDgv1(List<Zivotinja> pronedjene)
        {
            System.Windows.Forms.MessageBox.Show($"Sistem je pronasao zivotinje po zadatoj vrednosti","Pretraga",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Information);
            uc.DgvPretrazi.DataSource = new BindingList<Zivotinja>(pronedjene);
        }

        private bool Validacija()
        {
            if(!int.TryParse(uc.TxtStarost.Text,out int starost) && !string.IsNullOrEmpty(uc.TxtStarost.Text))
            {
                System.Windows.Forms.MessageBox.Show("Starost mora biti ceo broj");
                return false;
            }
            string pol = ((Pol)uc.CmbPol.SelectedItem).ToString();
            string tipIshrane = ((TipIshrane)uc.CmbTipIshrane.SelectedItem).ToString();
            string vrsta = uc.TxtVrsta.Text;
            string staniste = uc.TxtStaniste.Text;
            string star = starost == 0 ? null : starost.ToString();

            z = new Zivotinja(null,vrsta,pol,star,staniste,tipIshrane);
            return true;

        }

        private void OsveziDgv()
        {
            uc.DgvPretrazi.DataSource = new BindingList<Zivotinja>(Komunikacija.Instance.ZahtevajIVratiRezultat<List<Zivotinja>>(Common.Komunikacija.Operacija.VratiSveZivotinje));

        }
    }
}
