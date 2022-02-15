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
                Sesija.Instance.Korisnik = Komunikacija.Instance.ZahtevajIVratiRezultat<Zaposleni>(Common.Komunikacija.Operacija.Prijava, korisnik);
                if (Sesija.Instance.Korisnik != null)
                {
                    
                    MessageBox.Show("Sistem je nasao zaposlenog sa zadataim podacima!","Prijava zaposlenog",MessageBoxButtons.OK,MessageBoxIcon.Information);
                   
                    frmLogin.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Sistem ne moze da pronadje zaposlenog na osnovu ucitanih vrednosti!", "Prijava zaposlenog", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
