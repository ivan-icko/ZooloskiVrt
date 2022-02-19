using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZooloskiVrt.Common.Domen;

namespace ZooloskiVrt.Klijent.Forme.GUIController
{

    class PrijavaKontroler
    {
        public Zaposleni Korisnik { get; set; }
        public void Prijava(FrmLogin frmLogin)
        {
            string korisnickoIme = frmLogin.TxtKorisnickoIme.Text;
            string sifra = frmLogin.TxtSifra.Text;
            if (string.IsNullOrEmpty(korisnickoIme) || string.IsNullOrEmpty(sifra))
            {
                System.Windows.Forms.MessageBox.Show("Sva polja su obavezna");
                return;
            }
            Zaposleni korisnik = new Zaposleni(null, null, korisnickoIme, sifra);

            try
            {
                Komunikacija.Instance.PoveziSe();
                korisnik = Komunikacija.Instance.ZahtevajIVratiRezultat<Zaposleni>(Common.Komunikacija.Operacija.Prijava, korisnik);
                if (korisnik != null)
                {
                    frmLogin.DialogResult = DialogResult.OK;
                }
            }

            #region
            /* {
                 MessageBox.Show("Sistem ne moze da prodanje zaposlenog sa zadatim podacima!", "Prijava zaposlenog", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 return;
             }
             Sesija.Instance.Korisnici = Komunikacija.Instance.ZahtevajIVratiRezultat<List<Zaposleni>>(Common.Komunikacija.Operacija.VratiSvePrijavljeneZaposlene);

             if (!Sesija.Instance.Korisnici.Contains(korisnik))
             {

                 MessageBox.Show("Sistem je nasao zaposlenog sa zadataim podacima!", "Prijava zaposlenog", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 Sesija.Instance.BrojPrijavljenih++;
                 frmLogin.DialogResult = DialogResult.OK;
             }
             else
             {
                 MessageBox.Show("Taj zaposleni je vec prijavljen na sistem!", "Prijava zaposlenog", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 return;
             }
         }*/
            #endregion
            catch (SocketException ex)
            {
                System.Windows.Forms.MessageBox.Show("Greska u komunikaciji sa serverom", "Greska", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                //Environment.Exit(0);
                Application.Exit();
            }
        }
    }
}
