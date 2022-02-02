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
    public class ObrisiZivotinjuKontroler
    {
        private UCObrisiZivotinju uc;

        public ObrisiZivotinjuKontroler(UCObrisiZivotinju uc)
        {
            this.uc = uc;
        }

        public void Inicijalizuj(UCObrisiZivotinju uc)
        {
            OsveziDgv();
            uc.BtnObrisi.Click += BtnObrisi_Click;
        }

        private void BtnObrisi_Click(object sender, EventArgs e)
        {
            if (uc.DgvZivotinje.SelectedRows.Count == 0)
            {
                System.Windows.Forms.MessageBox.Show("Niste izabrali zivotinju");
                return;
            }
            Komunikacija.Instance.ZahtevajBezVracanja(Common.Komunikacija.Operacija.ObrisiZivotinju, (Zivotinja)uc.DgvZivotinje.SelectedRows[0].DataBoundItem);
            System.Windows.Forms.MessageBox.Show("Uspesno ste obrisali zivotinju");
            OsveziDgv();
        }

        private void OsveziDgv()
        {
            uc.DgvZivotinje.DataSource = new BindingList<Zivotinja>(Komunikacija.Instance.ZahtevajIVratiRezultat<List<Zivotinja>>(Common.Komunikacija.Operacija.VratiSveZivotinje));
        }
    }
}
