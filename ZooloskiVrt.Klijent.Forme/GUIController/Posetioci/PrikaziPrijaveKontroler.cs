using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooloskiVrt.Common.Domen;
using ZooloskiVrt.Klijent.Forme.UserControls.Posetioci;

namespace ZooloskiVrt.Klijent.Forme.GUIController
{
    public class PrikaziPrijaveKontroler
    {
        private UCPrikaziPrijave uc;

        public PrikaziPrijaveKontroler(UCPrikaziPrijave uc)
        {
            this.uc = uc;
        }

        public void Inicijalizuj()
        {
            NapuniPrijave();
        }

        private void NapuniPrijave()
        {
            uc.DgvPrijave.DataSource = new BindingList<PosetilacPrijava>(Komunikacija.Instance.ZahtevajIVratiRezultat<List<PosetilacPrijava>>(Common.Komunikacija.Operacija.VratiSvePrijaveZaPosetioce, new PosetilacPrijava() { JoinUslov = "join Prijava on(Prijava.IdPosetioca = Posetilac.IdPosetioca) join Paket on(Paket.IdPaketa=Prijava.IdPaketa)", Uslov = null }));
        }
    }
}
