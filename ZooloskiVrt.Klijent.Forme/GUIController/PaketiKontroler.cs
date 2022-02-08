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
            
        }

        private void BtnPrikazi_Click(object sender, EventArgs e)
        {
            if (uc.DgvPretrazi.SelectedRows.Count == 0)
            {
                System.Windows.Forms.MessageBox.Show("Niste odabrali paket za prikaz");
                return;
            }
            izabraniPaket = (Paket)uc.DgvPretrazi.SelectedRows[0].DataBoundItem;
            NapuniPretragu(izabraniPaket);
            NapuniDgvSaZivotinjama(izabraniPaket.IdPaketa);
        }

        private void NapuniDgvSaZivotinjama(int idPaketa)
        {
            uc.DgvZivotinjeUPaketu.DataSource = new BindingList<Zivotinja>(Komunikacija.Instance.ZahtevajIVratiRezultat<List<Zivotinja>>(Common.Komunikacija.Operacija.VratiZIvotinjeZaPakete,new Zivotinja() {JoinUslov="join PaketZivotinja on Zivotinja.IdZivotinje=PaketZivotinja.IdZivotinje",Uslov=$"where PaketZivotinja.IdPaketa={idPaketa}"}));
        }

        private void NapuniPretragu(Paket izabraniPaket)
        {
            uc.TxtCena.Text = izabraniPaket.Cena.ToString();
            uc.TxtDatumDo.Text = izabraniPaket.DatumDo.ToString("d");
            uc.TxtNazivPaketa.Text = izabraniPaket.NazivPaketa;
        }

        private void BtnDodajZivotinju_Click(object sender, EventArgs e)
        {
            UCDodajZivotinjuUPaket uc = new UCDodajZivotinjuUPaket();
            uc.Dock = DockStyle.Fill;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(uc);
        }
        private void BtnDodaj_Click(object sender, EventArgs e)
        {
            if (!Validacija())
            {
                return;
            }
            Paket p = new Paket();
            p = NapuniPaket(p);
            Komunikacija.Instance.ZahtevajBezVracanja(Common.Komunikacija.Operacija.DodajPaket,p);
            OsveziDgv();
            System.Windows.Forms.MessageBox.Show("Sistem je zapamtio paket", "Dodavanje paketa", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);

        }

        private void OsveziDgv()
        {
            uc.DgvPretrazi.DataSource = new BindingList<Paket>(Komunikacija.Instance.ZahtevajIVratiRezultat<List<Paket>>(Common.Komunikacija.Operacija.VratiSvePakete));
        }

        private Paket NapuniPaket(Paket p)
        {
            
            p.NazivPaketa = uc.TxtNazivPaketa.Text;
            p.Cena = double.Parse(uc.TxtCena.Text);
            p.DatumDo =(DateTime.Parse(uc.TxtDatumDo.Text)).Date;
            return p;
        }

        private bool Validacija()
        {
            if(string.IsNullOrEmpty(uc.TxtCena.Text) || string.IsNullOrEmpty(uc.TxtDatumDo.Text) || string.IsNullOrEmpty(uc.TxtNazivPaketa.Text))
            {
                System.Windows.Forms.MessageBox.Show("Sva polja su obavezna");
                return false;
            }
            if(!double.TryParse(uc.TxtCena.Text,out double cena))
            {
                System.Windows.Forms.MessageBox.Show("Greska pri unosu cene");
                return false;
            }
            if(!DateTime.TryParse(uc.TxtDatumDo.Text,out DateTime datum))
            {
                System.Windows.Forms.MessageBox.Show("Datum nije u dobrom formatu");
                return false;
            }
            return true;
        }
    }
}
