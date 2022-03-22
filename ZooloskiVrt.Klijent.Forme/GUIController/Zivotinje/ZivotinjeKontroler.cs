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
            if (selektovanaZivotinja.IdZivotinje == 0)
            {
                System.Windows.Forms.MessageBox.Show("Niste odabrali zivotinju za azuriranje");
                return;
            }
            if (selektovanaZivotinja.OznakaZivotinje.ToString() != uc.TxtOznakaJedinke.Text)
            {
                if (!ProveraOznake())
                {
                    return;
                }
            }

            Zivotinja ziv;
            ziv = new Zivotinja(selektovanaZivotinja.IdZivotinje.ToString(), null, null, null, null, null, null);

            ziv.IdZivotinje = selektovanaZivotinja.IdZivotinje;
            ziv.OznakaZivotinje = int.Parse(uc.TxtOznakaJedinke.Text);
            ziv.Vrsta = uc.TxtVrsta.Text;
            ziv.Pol = (Pol)uc.CmbPol.SelectedItem;
            ziv.Starost = int.Parse(uc.TxtStarost.Text);
            ziv.Staniste = uc.TxtStaniste.Text;
            ziv.TipIshrane = (TipIshrane)uc.CmbTipIshrane.SelectedItem;

            Komunikacija.Instance.ZahtevajBezVracanja(Common.Komunikacija.Operacija.AzurirajZivotinju, ziv);
            OsveziDgv();
            selektovanaZivotinja.IdZivotinje = 0;
        }

        private bool ValidacijaAzuriranjaZivotinje()
        {
            if (string.IsNullOrEmpty(uc.TxtStaniste.Text) ||
                string.IsNullOrEmpty(uc.TxtStarost.Text) ||
                string.IsNullOrEmpty(uc.TxtOznakaJedinke.Text) ||
                string.IsNullOrEmpty(uc.TxtVrsta.Text))
            {
                System.Windows.Forms.MessageBox.Show("Sva polja su obavezna!");
                return false;
            }
            if (!int.TryParse(uc.TxtStarost.Text, out int starost) || starost <= 0)
            {
                System.Windows.Forms.MessageBox.Show("Greska pri unosu starosti");
                return false;
            }
            if (!int.TryParse(uc.TxtOznakaJedinke.Text, out int oznaka) || oznaka <= 0)
            {
                System.Windows.Forms.MessageBox.Show("Greska pri unosu oznake");
                return false;
            }

            return true;
        }

        private bool ProveraOznake()
        {
            if (Komunikacija.Instance.ZahtevajIVratiRezultat<List<Zivotinja>>(Common.Komunikacija.Operacija.VratiSveZivotinje).Count(a => a.OznakaZivotinje.ToString() == uc.TxtOznakaJedinke.Text && a.Vrsta == uc.TxtVrsta.Text) >= 1)
            {
                System.Windows.Forms.MessageBox.Show($"Vec postoji {uc.TxtVrsta.Text} sa takvom oznakom");
                return false;
            }
            return true;
        }

        private void BtnObrisi_Click(object sender, EventArgs e)
        {
            if (uc.DgvPretrazi.SelectedRows.Count == 0)
            {
                System.Windows.Forms.MessageBox.Show("Niste izabrali zivotinju");
                return;
            }

            int idZIvotinje = ((Zivotinja)uc.DgvPretrazi.SelectedRows[0].DataBoundItem).IdZivotinje;
            Zivotinja z = new Zivotinja() { Uslov = $"IdZivotinje={idZIvotinje}" };

            Komunikacija.Instance.ZahtevajBezVracanja(Common.Komunikacija.Operacija.ObrisiZivotinju, z);
            OsveziDgv();

        }

        private void BtnPrikazi_Click(object sender, EventArgs e)
        {
            if (uc.DgvPretrazi.SelectedRows.Count == 0)
            {
                System.Windows.Forms.MessageBox.Show("Niste odabrali zivotinju za prikaz");
                return;
            }
            int idZivotinje = ((Zivotinja)uc.DgvPretrazi.SelectedRows[0].DataBoundItem).IdZivotinje;
            List<Zivotinja> pom = new List<Zivotinja>();
            if ((pom = Komunikacija.Instance.ZahtevajIVratiRezultat<List<Zivotinja>>(Common.Komunikacija.Operacija.PronadjiZivotinje, new Zivotinja() { Uslov = $"IdZivotinje={idZivotinje}" })) == null)
            {
                return;
            }
            selektovanaZivotinja = pom.SingleOrDefault();
            NapuniPretragu(selektovanaZivotinja);

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
            Komunikacija.Instance.ZahtevajBezVracanja(Common.Komunikacija.Operacija.DodajZivotinju, z);
            OsveziDgv();

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
                System.Windows.Forms.MessageBox.Show("Sva polja su obavezna!");
                return false;
            }
            if (!int.TryParse(uc.TxtStarost.Text, out int starost) || starost <= 0)
            {
                System.Windows.Forms.MessageBox.Show("Greska pri unosu starosti");
                return false;
            }
            if (!int.TryParse(uc.TxtOznakaJedinke.Text, out int oznaka) || oznaka <= 0)
            {
                System.Windows.Forms.MessageBox.Show("Greska pri unosu oznake");
                return false;
            }
            return true;
        }

        private void BtnPrikaziSve_Click(object sender, EventArgs e)
        {
            List<Zivotinja> pronedjene = Komunikacija.Instance.ZahtevajIVratiRezultat<List<Zivotinja>>(Common.Komunikacija.Operacija.VratiSveZivotinje);
            if (pronedjene == null)
            {
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
                /* System.Windows.Forms.MessageBox.Show("Sistem ne moze da pronadje zivotinju po zadatoj vrednosti", "Greska", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);*/
                return;
            }
            else { OsveziDgv1(pronаdjene); }
        }

        private void OsveziDgv1(List<Zivotinja> pronedjene)
        {
            /*  System.Windows.Forms.MessageBox.Show($"Sistem je pronasao zivotinje po zadatoj vrednosti", "Pretraga", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);*/
            uc.DgvPretrazi.DataSource = new BindingList<Zivotinja>(pronedjene);
        }

        private bool Validacija()
        {
            int oznakaZivotinje = 0;
            int starost = 0;
            if (!string.IsNullOrEmpty(uc.TxtOznakaJedinke.Text))
            {
                if (int.TryParse(uc.TxtOznakaJedinke.Text, out int a) && a>0)
                {
                    oznakaZivotinje = a;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Greska pri unosu oznake");
                    return false;
                }
            }

            if (!string.IsNullOrEmpty(uc.TxtStarost.Text))
            {
                if (int.TryParse(uc.TxtStarost.Text, out int b) && b > 0)
                {
                    starost = b;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Greska pri unosu oznake");
                    return false;
                }
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
