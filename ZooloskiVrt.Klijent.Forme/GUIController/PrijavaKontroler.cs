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
            Zaposleni korisnik = new Zaposleni(null,null,korisnickoIme,sifra);

            try
            {
                Komunikacija.Instance.PoveziSe();
                Sesija.Instance.Korisnik = Komunikacija.Instance.ZahtevajIVratiRezultat<Zaposleni>(Common.Komunikacija.Operacija.Prijava, korisnik.Uslov);
                if (Sesija.Instance.Korisnik != null)
                {
                    
                    MessageBox.Show($"Dobrodosli, {Sesija.Instance.Korisnik.Ime} {Sesija.Instance.Korisnik.Prezime}!");
                    frmLogin.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Nema takvog zaposlenog!");
                }
            }
            /*catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }*/
            catch (SocketException ex)
            {
                MessageBox.Show("Greska u komunikaciji sa serverom!");
            }
        }
    }
}
