﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooloskiVrt.Common.Domen;
using ZooloskiVrt.Klijent.Forme.UserControls.Posetioci;

namespace ZooloskiVrt.Klijent.Forme.GUIController
{
    public class PrijaviPosetioceNaPaketeKontroler
    {
        private UCPosetioci uc;

        public PrijaviPosetioceNaPaketeKontroler(UCPosetioci uc)
        {
            this.uc = uc;
        }

        public void Inicijalizuj()
        {
            NapuniPosetioce();
            NapuniPakete();
            uc.BtnDodaj.Click += BtnDodaj_Click;

        }

        private void BtnDodaj_Click(object sender, EventArgs e)
        {
            if (uc.DgvPaketi.SelectedRows.Count == 0)
            {
                System.Windows.Forms.MessageBox.Show("Niste odabrali paket");
                return;
            }
            if (uc.DgvPosetioci.SelectedRows.Count == 0)
            {
                System.Windows.Forms.MessageBox.Show("Niste odabrali posetioca");
                return;
            }
            if(!int.TryParse(uc.TxtBrojOsoba.Text,out int brojOsoba)||string.IsNullOrEmpty(uc.TxtBrojOsoba.Text))
            {
                System.Windows.Forms.MessageBox.Show("Greska pri unosu broja ocena!");
                return;
            }

            Prijava p = new Prijava() { IdPaketa = (uc.DgvPaketi.SelectedRows[0].DataBoundItem as Paket).IdPaketa, IdPosetioca = (uc.DgvPosetioci.SelectedRows[0].DataBoundItem as Posetilac).IdPosetioca, BrojOsoba = brojOsoba
            ,DatumPrijave=DateTime.Now};

           

            DodajPrijavu(p);
        }

        private void DodajPrijavu(Prijava p)
        {
            Komunikacija.Instance.ZahtevajBezVracanja(Common.Komunikacija.Operacija.DodajPrijavu, p);
            System.Windows.Forms.MessageBox.Show("Uspesno ste dodali novu prijavu", "Prijava", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
        }

        private void NapuniPakete()
        {
            uc.DgvPaketi.DataSource = new BindingList<Paket>(Komunikacija.Instance.ZahtevajIVratiRezultat<List<Paket>>(Common.Komunikacija.Operacija.VratiSvePakete));
        }

        private void NapuniPosetioce()
        {
            uc.DgvPosetioci.DataSource = new BindingList<Posetilac>(Komunikacija.Instance.ZahtevajIVratiRezultat<List<Posetilac>>(Common.Komunikacija.Operacija.VratiSvePosetioce));
        }
    }
}