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
        private int idPaketa;
        private List<Zivotinja> sveZivotinje = new List<Zivotinja>();
        private List<Zivotinja> zivotinjeUPaketu = new List<Zivotinja>();
        private List<Zivotinja> zivotinjeZaDodavanje = new List<Zivotinja>();

        public DodajZivotinjuUPaketKontroler(UCDodajZivotinjuUPaket uc, int idPaketa)
        {
            this.uc = uc;
            this.idPaketa = idPaketa;
        }

        public void Inicijalizuj()
        {
            sveZivotinje = Komunikacija.Instance.ZahtevajIVratiRezultat<List<Zivotinja>>(Common.Komunikacija.Operacija.VratiSveZivotinje);
            zivotinjeUPaketu = Komunikacija.Instance.ZahtevajIVratiRezultat<List<Zivotinja>>(Common.Komunikacija.Operacija.VratiZIvotinjeZaPakete, new Zivotinja() { JoinUslov = "join PaketZivotinja on Zivotinja.IdZivotinje=PaketZivotinja.IdZivotinje", Uslov = $"where PaketZivotinja.IdPaketa={idPaketa}"});

            zivotinjeZaDodavanje = sveZivotinje.Where(x => !zivotinjeUPaketu.Contains(x)).ToList();

            uc.DgvZivotinje.DataSource = new BindingList<Zivotinja>(zivotinjeZaDodavanje);
        }
    }
}
