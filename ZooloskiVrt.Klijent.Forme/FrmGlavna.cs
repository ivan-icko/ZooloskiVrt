using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZooloskiVrt.Klijent.Forme.UserControls.Paketi;
using ZooloskiVrt.Klijent.Forme.UserControls.Posetioci;
using ZooloskiVrt.Klijent.Forme.UserControls.Zivotinje;

namespace ZooloskiVrt.Klijent.Forme
{
    public partial class FrmGlavna : Form
    {
        public FrmGlavna()
        {
            InitializeComponent();
        }

        #region staro
        /*  private void dodajZivotinjuToolStripMenuItem_Click(object sender, EventArgs e)
          {
              UCDodajZivotinju dodajNovuZivotinju = new UCDodajZivotinju();
              dodajNovuZivotinju.Dock = DockStyle.Fill;
              pnlMain.Controls.Clear();
              pnlMain.Controls.Add(dodajNovuZivotinju);
          }

          private void obrisiZivotinjuToolStripMenuItem_Click(object sender, EventArgs e)
          {
              UCObrisiZivotinju uCObrisiZivotinju = new UCObrisiZivotinju();
              uCObrisiZivotinju.Dock = DockStyle.Fill;
              pnlMain.Controls.Clear();
              pnlMain.Controls.Add(uCObrisiZivotinju);
          }

          private void pretraziZivotinjuToolStripMenuItem_Click(object sender, EventArgs e)
          {
              UCZivotinje UcPretrazi = new UCZivotinje();
              UcPretrazi.Dock = DockStyle.Fill;
              pnlMain.Controls.Clear();
              pnlMain.Controls.Add(UcPretrazi);
          }
  */
        #endregion





        private void paketiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCPaketi uc = new UCPaketi(pnlMain);
            uc.Dock = DockStyle.Fill;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(uc);
        }

        private void posetiociToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCPosetioci uc = new UCPosetioci(pnlMain);
            uc.Dock = DockStyle.Fill;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(uc);
        }

        private void zivotinjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCZivotinje UcPretrazi = new UCZivotinje();
            UcPretrazi.Dock = DockStyle.Fill;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(UcPretrazi);
        }

      

        private void FrmGlavna_FormClosing(object sender, FormClosingEventArgs e)
        {
            Komunikacija.Instance.ZahtevajBezVracanja(Common.Komunikacija.Operacija.Kraj);
        }
    }
}
