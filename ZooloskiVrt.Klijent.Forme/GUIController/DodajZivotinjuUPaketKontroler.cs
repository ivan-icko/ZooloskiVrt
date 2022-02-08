using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooloskiVrt.Common.Domen;
using ZooloskiVrt.Klijent.Forme.UserControls.Paketi;

namespace ZooloskiVrt.Klijent.Forme.GUIController
{
    public class DodajZivotinjuUPaketKontroler
    {
        private UCDodajZivotinjuUPaket uc;

        public DodajZivotinjuUPaketKontroler(UCDodajZivotinjuUPaket uc)
        {
            this.uc = uc;
        }

        public void Inicijalizuj()
        {
            uc.DgvZivotinje.DataSource = new BindingList<Zivotinja>(Komunikacija.Instance.ZahtevajIVratiRezultat<List<Zivotinja>>(Common.Komunikacija.Operacija.VratiSveZivotinje));
        }
    }
}
