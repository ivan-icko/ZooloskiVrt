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
        Zivotinja z;

        public PretraziZIvotinjuKontroler(UCPretraziZivotinju uc)
        {
            this.uc = uc;
        }

        public void Inicijalizuj()
        {
            OsveziDgv();
            NapuniCmb();
            uc.BtnPretrazi.Click += BtnPretrazi_Click;
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
            List<Zivotinja> pronedjene=Komunikacija.Instance.ZahtevajIVratiRezultat<List<Zivotinja>>(Common.Komunikacija.Operacija.PronadjiZivotinje,z.Uslov);
            if (pronedjene == null)
            {
                System.Windows.Forms.MessageBox.Show("Ne postoji takva vrsta zivotinje");
                return;
            }
            else { OsveziDgv1(pronedjene); }
        }

        private void OsveziDgv1(List<Zivotinja> pronedjene)
        {
            System.Windows.Forms.MessageBox.Show($"Pronadjeno je {pronedjene.Count} zivotinja");
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

            z = new Zivotinja(vrsta,pol,star,staniste,tipIshrane);
            return true;

        }

        private void OsveziDgv()
        {
            uc.DgvPretrazi.DataSource = new BindingList<Zivotinja>(Komunikacija.Instance.ZahtevajIVratiRezultat<List<Zivotinja>>(Common.Komunikacija.Operacija.VratiSveZivotinje));

        }
    }
}
