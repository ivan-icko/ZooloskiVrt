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
    public class ZivotinjeKontroler
    {
        private UCZivotinje uc;
        Zivotinja z = new Zivotinja();
        Zivotinja selektovanaZivotinja = new Zivotinja();



        public ZivotinjeKontroler(UCZivotinje uc)
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
            uc.BtnOcistiPretragu.Click += BtnOcistiPretragu_Click;
        }

        private void BtnOcistiPretragu_Click(object sender, EventArgs e)
        {
            //uc.TxtId.Text = "";
            uc.TxtStaniste.Text = "";
            uc.TxtStarost.Text = "";
            uc.TxtVrsta.Text = "";
            uc.TxtOznakaJedinke.Text = "";
            uc.CmbPol.SelectedItem = null;
            uc.CmbTipIshrane.SelectedItem = null;
        }

        private void BtnAzuriraj_Click(object sender, EventArgs e)
        {
            if (!ValidacijaAzuriranjaZivotinje())
            {
                return;
            }

            if (selektovanaZivotinja.OznakaZivotinje.ToString() != uc.TxtOznakaJedinke.Text)
            {
                if (!ProveraOznake())
                {
                    return;
                }
            }

            Zivotinja ziv = new Zivotinja(selektovanaZivotinja.IdZivotinje.ToString(), null, null, null, null, null, null);

            ziv.IdZivotinje = selektovanaZivotinja.IdZivotinje;
            ziv.OznakaZivotinje = int.Parse(uc.TxtOznakaJedinke.Text);
            ziv.Vrsta = uc.TxtVrsta.Text;
            ziv.Pol = (Pol)uc.CmbPol.SelectedItem;
            ziv.Starost = int.Parse(uc.TxtStarost.Text);
            ziv.Staniste = uc.TxtStaniste.Text;
            ziv.TipIshrane = (TipIshrane)uc.CmbTipIshrane.SelectedItem;

            if (Komunikacija.Instance.ZahtevajBezVracanja(Common.Komunikacija.Operacija.AzurirajZivotinju, ziv))
            {
                OsveziDgv();
                System.Windows.Forms.MessageBox.Show("Sistem je uspesno azurirao podatke o zivotinji", "Azuriranje", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Sistem ne moze da azurira podatke o zivotinji", "Azuriranje", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return;
            }

        }

        private bool ValidacijaAzuriranjaZivotinje()
        {
            if (string.IsNullOrEmpty(uc.TxtStaniste.Text) ||
                string.IsNullOrEmpty(uc.TxtStarost.Text) ||
                string.IsNullOrEmpty(uc.TxtOznakaJedinke.Text) ||
                string.IsNullOrEmpty(uc.TxtVrsta.Text))
            {
                System.Windows.Forms.MessageBox.Show("Sistem ne moze da azurira podatke o zivotinji", "Greska", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                System.Windows.Forms.MessageBox.Show("Sva polja su obavezna!");
                return false;
            }
            else if (!int.TryParse(uc.TxtStarost.Text, out int starost) || !int.TryParse(uc.TxtOznakaJedinke.Text, out int oznaka))
            {
                System.Windows.Forms.MessageBox.Show("Sistem ne moze da azurira podatke o zivotinji", "Greska", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                System.Windows.Forms.MessageBox.Show("Starost mora biti ceo broj");
                return false;
            }
            return true;
        }

        private bool ProveraOznake()
        {
            if (Komunikacija.Instance.ZahtevajIVratiRezultat<List<Zivotinja>>(Common.Komunikacija.Operacija.VratiSveZivotinje).Count(a => a.OznakaZivotinje.ToString() == uc.TxtOznakaJedinke.Text && a.Vrsta == selektovanaZivotinja.Vrsta) >= 1)
            {
                System.Windows.Forms.MessageBox.Show("Sistem ne moze da zapamti zivotinju", "Unos zivotinje", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                System.Windows.Forms.MessageBox.Show($"Vec postoji {uc.TxtVrsta.Text} sa takvom oznakom");
                return false;
            }
            return true;
        }

        private void BtnObrisi_Click(object sender, EventArgs e)
        {
            if (uc.DgvPretrazi.SelectedRows.Count == 0)
            {
                System.Windows.Forms.MessageBox.Show("Sistem ne moze da obrise zivotinju", "Greska", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                System.Windows.Forms.MessageBox.Show("Niste izabrali zivotinju");
                return;
            }

            /*Zivotinja z = (Zivotinja)uc.DgvPretrazi.SelectedRows[0].DataBoundItem;
            z = new Zivotinja(z.IdZivotinje.ToString(), z.OznakaZivotinje.ToString(), z.Vrsta, z.Pol.ToString(), z.Starost.ToString(), z.Staniste, z.TipIshrane.ToString());*/

            int idZIvotinje = ((Zivotinja)uc.DgvPretrazi.SelectedRows[0].DataBoundItem).IdZivotinje;
            Zivotinja z = new Zivotinja() { Uslov = $"IdZivotinje={idZIvotinje}" };
            
            if (Komunikacija.Instance.ZahtevajBezVracanja(Common.Komunikacija.Operacija.ObrisiZivotinju, z))
            {
                System.Windows.Forms.MessageBox.Show("Sistem je obrisao zivotinju", "Brisanje", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                OsveziDgv();
            }

            else { System.Windows.Forms.MessageBox.Show("Sistem ne moze da obrise zivotinju","Greska",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);return; }



        }

        private void BtnPrikazi_Click(object sender, EventArgs e)
        {
            if (uc.DgvPretrazi.SelectedRows.Count == 0)
            {
                System.Windows.Forms.MessageBox.Show("Sistem ne moze da ucita podatke o zivotinji", "Greska", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                System.Windows.Forms.MessageBox.Show("Niste odabrali zivotinju za prikaz");
                return;
            }
            int idZivotinje = ((Zivotinja)uc.DgvPretrazi.SelectedRows[0].DataBoundItem).IdZivotinje;
            selektovanaZivotinja = Komunikacija.Instance.ZahtevajIVratiRezultat<List<Zivotinja>>(Common.Komunikacija.Operacija.PronadjiZivotinje, new Zivotinja() { Uslov = $"IdZivotinje={idZivotinje}" }).SingleOrDefault();
            NapuniPretragu(selektovanaZivotinja);
            System.Windows.Forms.MessageBox.Show("Sistem je ucitao podatke o zivotinji", "Ucitavanje", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
        }

        private void NapuniPretragu(Zivotinja z)
        {
            //uc.TxtId.Text = z.IdZivotinje.ToString();
            uc.TxtOznakaJedinke.Text = z.OznakaZivotinje.ToString();
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
            if (!ProveraOznake())
            {
                return;
            }
            if (Komunikacija.Instance.ZahtevajBezVracanja(Common.Komunikacija.Operacija.DodajZivotinju, z))
            {
                OsveziDgv();
                System.Windows.Forms.MessageBox.Show("Sistem je zapamtio zivotinju", "Dodavanje zivotinje", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Sistem ne moze da zapamti zivotinju", "Greska", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        private void NapuniZivotinju()
        {
            z.OznakaZivotinje = int.Parse(uc.TxtOznakaJedinke.Text);
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
                string.IsNullOrEmpty(uc.TxtOznakaJedinke.Text) ||
                string.IsNullOrEmpty(uc.TxtVrsta.Text))
            {
                System.Windows.Forms.MessageBox.Show("Sistem ne moze da zapamti zivotinju", "Greska", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                System.Windows.Forms.MessageBox.Show("Sva polja su obavezna!");
                return false;
            }
            else if (!int.TryParse(uc.TxtStarost.Text, out int starost) || !int.TryParse(uc.TxtOznakaJedinke.Text, out int oznaka))
            {
                System.Windows.Forms.MessageBox.Show("Sistem ne moze da zapamti zivotinju", "Greska", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
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
                System.Windows.Forms.MessageBox.Show("Ne postoje zivotinje");
                return;
            }
            else { OsveziDgv1(pronedjene); }
        }

        private void NapuniCmb()
        {
            uc.CmbPol.DataSource = Enum.GetValues(typeof(Pol));
            uc.CmbPol.SelectedItem = null;
            uc.CmbTipIshrane.DataSource = Enum.GetValues(typeof(TipIshrane));
            uc.CmbTipIshrane.SelectedItem = null;
        }

        private void BtnPretrazi_Click(object sender, EventArgs e)
        {
            if (!Validacija())
            {
                return;
            }
            List<Zivotinja> pronаdjene = Komunikacija.Instance.ZahtevajIVratiRezultat<List<Zivotinja>>(Common.Komunikacija.Operacija.PronadjiZivotinje, z);
            if (pronаdjene == null)
            {
                System.Windows.Forms.MessageBox.Show("Sistem ne moze da pronadje zivotinju po zadatoj vrednosti", "Greska", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return;
            }
            else { OsveziDgv1(pronаdjene); }
        }

        private void OsveziDgv1(List<Zivotinja> pronedjene)
        {
            System.Windows.Forms.MessageBox.Show($"Sistem je pronasao zivotinje po zadatoj vrednosti", "Pretraga", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
            uc.DgvPretrazi.DataSource = new BindingList<Zivotinja>(pronedjene);
        }

        private bool Validacija()
        {
            if ((!int.TryParse(uc.TxtOznakaJedinke.Text, out int oznakaZivotinje) && !string.IsNullOrEmpty(uc.TxtOznakaJedinke.Text)) || (!int.TryParse(uc.TxtStarost.Text, out int starost) && !string.IsNullOrEmpty(uc.TxtStarost.Text)))
            {
                System.Windows.Forms.MessageBox.Show("Starost mora biti ceo broj");
                return false;
            }
            string oznaka = oznakaZivotinje == 0 ? null : oznakaZivotinje.ToString();
            string pol = uc.CmbPol.SelectedItem != null ? (((Pol)uc.CmbPol.SelectedItem).ToString()) : null;
            string tipIshrane = uc.CmbTipIshrane.SelectedItem != null ? (((TipIshrane)uc.CmbTipIshrane.SelectedItem).ToString()) : null;
            string vrsta = uc.TxtVrsta.Text;
            string staniste = uc.TxtStaniste.Text;
            string star = starost == 0 ? null : starost.ToString();

            z = new Zivotinja(null, oznaka, vrsta, pol, star, staniste, tipIshrane);
            return true;

        }

        private void OsveziDgv()
        {
            uc.DgvPretrazi.DataSource = new BindingList<Zivotinja>(Komunikacija.Instance.ZahtevajIVratiRezultat<List<Zivotinja>>(Common.Komunikacija.Operacija.VratiSveZivotinje));

        }
    }
}
