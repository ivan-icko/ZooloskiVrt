using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZooloskiVrt.Common.Domen;
using ZooloskiVrt.Klijent.Forme.UserControls.Paketi;

namespace ZooloskiVrt.Klijent.Forme.GUIController
{
    public class PaketiKontroler
    {
        private UCPaketi uc;
        private Panel pnlMain;
        private List<Zivotinja> zivotinjeUPaketu = new List<Zivotinja>();
        private Paket izabraniPaket = new Paket();
        private Paket noviPaket = new Paket();


        public PaketiKontroler(UCPaketi uc, Panel pnlMain)
        {
            this.uc = uc;
            this.pnlMain = pnlMain;
        }

        public void Inicijalizuj()
        {
            OsveziDgv();
            uc.BtnDodaj.Click += BtnDodaj_Click;
            uc.BtnDodajZivotinju.Click += BtnDodajZivotinju_Click;
            uc.BtnPrikazi.Click += BtnPrikazi_Click;
            uc.BtnOcistiPretragu.Click += BtnOcistiPretragu_Click;
            uc.BtnPrikaziSve.Click += BtnPrikaziSve_Click;
            uc.BtnAzuriraj.Click += BtnAzuriraj_Click;
            uc.BtnPretrazi.Click += BtnPretrazi_Click;
            uc.BtnObrisiZivotinju.Click += BtnObrisiZivotinju_Click;
        }

        private void BtnObrisiZivotinju_Click(object sender, EventArgs e)
        {
            if (uc.DgvZivotinjeUPaketu.SelectedRows.Count == 0)
            {
                System.Windows.Forms.MessageBox.Show("Niste izabrali zivotinju za brisanje");
                return;
            }
            int IdZivotinje = (uc.DgvZivotinjeUPaketu.SelectedRows[0].DataBoundItem as Zivotinja).IdZivotinje;
            Sesija.Instance.ListaZivotinjaUPaketu.RemoveAll(a => a.IdZivotinje == IdZivotinje);
            NapuniDgvZivotinje();
        }

        private void BtnPretrazi_Click(object sender, EventArgs e)
        {
            if (!ValidacijaPretrage())
            {
                return;
            }
            List<Paket> pronadjeni = Komunikacija.Instance.ZahtevajIVratiRezultat<List<Paket>>(Common.Komunikacija.Operacija.PronadjiPakete, noviPaket);
            if (pronadjeni == null)
            {
                return;
            }
            else { OsveziDgv1(pronadjeni); }
        }

        private void OsveziDgv1(List<Paket> pronadjeni)
        {
            uc.DgvPretrazi.DataSource = new BindingList<Paket>(pronadjeni);
        }

        private bool ValidacijaPretrage()
        {
            double cenaPaketa = 0;
            DateTime datumDo = new DateTime();
            if (!string.IsNullOrEmpty(uc.TxtCena.Text))
            {
                if (!double.TryParse(uc.TxtCena.Text, out double cena))
                {
                    System.Windows.Forms.MessageBox.Show("Greska pri unosu cene");
                    return false;
                }
                cenaPaketa = cena;
            }

            if (!string.IsNullOrEmpty(uc.TxtDatumDo.Text))
            {
                if (!DateTime.TryParse(uc.TxtDatumDo.Text, out DateTime datum))
                {
                    System.Windows.Forms.MessageBox.Show("Greska pri unosu datuma");
                    return false;
                }
                datumDo = datum;
            }
            noviPaket = NapuniPaket(uc.TxtNazivPaketa.Text, cenaPaketa, datumDo);
            return true;
        }

        private Paket NapuniPaket(string naziv, double cena, DateTime datum)
        {
            Paket p = new Paket(null, naziv, cena == 0 ? null : cena.ToString(), datum == new DateTime() ? null : datum.ToString("yyyy-MM-dd"));
            return p;
        }

        private void BtnAzuriraj_Click(object sender, EventArgs e)
        {
            if (!ValidacijaAzuriranja())
            {
                return;
            }
            Paket p = new Paket(izabraniPaket.IdPaketa.ToString(), null, null, null);
            p.IdPaketa = izabraniPaket.IdPaketa;
            p.NazivPaketa = uc.TxtNazivPaketa.Text;
            p.Cena = double.Parse(uc.TxtCena.Text);
            p.DatumDo = DateTime.Parse(uc.TxtDatumDo.Text);

            foreach (var z in Sesija.Instance.ListaZivotinjaUPaketu)
            {
                p.ListaIdjevaZivotinja.Add(z.IdZivotinje);
            }
            Komunikacija.Instance.ZahtevajBezVracanja(Common.Komunikacija.Operacija.AzurirajPaket, p);

        }

        private bool ValidacijaAzuriranja()
        {
            if (string.IsNullOrEmpty(uc.TxtCena.Text) || string.IsNullOrEmpty(uc.TxtDatumDo.Text) || string.IsNullOrEmpty(uc.TxtNazivPaketa.Text))
            {
                System.Windows.Forms.MessageBox.Show("Sva polja su obavezna");
                return false;
            }
            if (!double.TryParse(uc.TxtCena.Text, out double cena))
            {
                System.Windows.Forms.MessageBox.Show("Greska pri unosu cene");
                return false;
            }
            if (!DateTime.TryParse(uc.TxtDatumDo.Text, out DateTime datum) || datum <= DateTime.Now)
            {
                System.Windows.Forms.MessageBox.Show("Datum nije u dobrom formatu");
                return false;
            }
            return true;
        }

        private void BtnPrikaziSve_Click(object sender, EventArgs e)
        {
            OsveziDgv();
        }

        private void BtnOcistiPretragu_Click(object sender, EventArgs e)
        {
            uc.TxtCena.Text = "";
            uc.TxtDatumDo.Text = "";
            uc.TxtNazivPaketa.Text = "";
            uc.DgvZivotinjeUPaketu.DataSource = null;
        }

        private void BtnPrikazi_Click(object sender, EventArgs e)
        {
            if (uc.DgvPretrazi.SelectedRows.Count == 0)
            {
                System.Windows.Forms.MessageBox.Show("Niste odabrali paket za prikaz");
                return;
            }

            int idPaketa = ((Paket)uc.DgvPretrazi.SelectedRows[0].DataBoundItem).IdPaketa;
            List<Paket> pom = new List<Paket>();
            if ((pom = Komunikacija.Instance.ZahtevajIVratiRezultat<List<Paket>>(Common.Komunikacija.Operacija.PronadjiPakete, new Paket() { Uslov = $"IdPaketa={idPaketa}" })) == null)
            {
                return;
            }
            izabraniPaket = pom.SingleOrDefault();

            NapuniPretragu(izabraniPaket);

            Sesija.Instance.ListaZivotinjaUPaketu = NapuniListuTrenutnihZivotinja(izabraniPaket.IdPaketa);
            NapuniDgvZivotinje();
        }

        private void NapuniDgvZivotinje()
        {
            uc.DgvZivotinjeUPaketu.DataSource = new BindingList<Zivotinja>(Sesija.Instance.ListaZivotinjaUPaketu);
        }

        private List<Zivotinja> NapuniListuTrenutnihZivotinja(int idPaketa)
        {
            return (Komunikacija.Instance.ZahtevajIVratiRezultat<List<Zivotinja>>(Common.Komunikacija.Operacija.VratiZIvotinjeZaPakete, new Zivotinja() { JoinUslov = "join PaketZivotinja on Zivotinja.IdZivotinje=PaketZivotinja.IdZivotinje", Uslov = $"where PaketZivotinja.IdPaketa={idPaketa}" }));
        }

        private void NapuniPretragu(Paket izabraniPaket)
        {
            uc.TxtCena.Text = izabraniPaket.Cena.ToString();
            uc.TxtDatumDo.Text = izabraniPaket.DatumDo.ToString("d");
            uc.TxtNazivPaketa.Text = izabraniPaket.NazivPaketa;
        }

        private void BtnDodajZivotinju_Click(object sender, EventArgs e)
        {
            if (uc.DgvPretrazi.SelectedRows.Count == 0)
            {
                System.Windows.Forms.MessageBox.Show("Niste odabrali paket za prikaz");
                return;
            }
            UCDodajZivotinjuUPaket uc1 = new UCDodajZivotinjuUPaket((uc.DgvPretrazi.SelectedRows[0].DataBoundItem as Paket).IdPaketa);
            uc1.Dock = DockStyle.Fill;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(uc1);
        }
        private void BtnDodaj_Click(object sender, EventArgs e)
        {
            if (!Validacija())
            {
                return;
            }
            Paket p = new Paket();
            p = NapuniPaket(p);
            Komunikacija.Instance.ZahtevajBezVracanja(Common.Komunikacija.Operacija.DodajPaket, p);
            OsveziDgv();
           

        }

        private void OsveziDgv()
        {
            uc.DgvPretrazi.DataSource = new BindingList<Paket>(Komunikacija.Instance.ZahtevajIVratiRezultat<List<Paket>>(Common.Komunikacija.Operacija.VratiSvePakete));
        }

        private Paket NapuniPaket(Paket p)
        {

            p.NazivPaketa = uc.TxtNazivPaketa.Text;
            p.Cena = double.Parse(uc.TxtCena.Text);
            p.DatumDo = (DateTime.Parse(uc.TxtDatumDo.Text)).Date;
            return p;
        }

        private bool Validacija()
        {
            if (string.IsNullOrEmpty(uc.TxtCena.Text) || string.IsNullOrEmpty(uc.TxtDatumDo.Text) || string.IsNullOrEmpty(uc.TxtNazivPaketa.Text))
            {
                System.Windows.Forms.MessageBox.Show("Sva polja su obavezna");
                return false;
            }
            if (!double.TryParse(uc.TxtCena.Text, out double cena))
            {
                System.Windows.Forms.MessageBox.Show("Greska pri unosu cene");
                return false;
            }
            if (!DateTime.TryParse(uc.TxtDatumDo.Text, out DateTime datum) || datum <= DateTime.Now)
            {
                System.Windows.Forms.MessageBox.Show("Greska pri unosu datuma");
                return false;
            }
            return true;
        }
    }
}
