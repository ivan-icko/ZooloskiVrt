using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZooloskiVrt.Klijent.Forme.GUIController;

namespace ZooloskiVrt.Klijent.Forme.UserControls.Posetioci
{
    public partial class UCPosetioci : UserControl
    {
        private PrijaviPosetioceNaPaketeKontroler kontroler;
        private Panel pnlMain;
        public UCPosetioci(Panel pnlMain)
        {
            InitializeComponent();
            this.pnlMain = pnlMain;
            kontroler = new PrijaviPosetioceNaPaketeKontroler(this);
            kontroler.Inicijalizuj();

        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            UCPrikaziPrijave uc = new UCPrikaziPrijave();
            uc.Dock = DockStyle.Fill;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(uc);
        }
    }
}
