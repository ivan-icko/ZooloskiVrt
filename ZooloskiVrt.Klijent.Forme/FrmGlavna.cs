using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZooloskiVrt.Klijent.Forme.UserControls.Zivotinje;

namespace ZooloskiVrt.Klijent.Forme
{
    public partial class FrmGlavna : Form
    {
        public FrmGlavna()
        {
            InitializeComponent();
        }

        private void dodajZivotinjuToolStripMenuItem_Click(object sender, EventArgs e)
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
            UCPretraziZivotinju UcPretrazi = new UCPretraziZivotinju();
            UcPretrazi.Dock = DockStyle.Fill;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(UcPretrazi);
        }
    }
}
