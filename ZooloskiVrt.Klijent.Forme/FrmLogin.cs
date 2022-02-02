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

namespace ZooloskiVrt.Klijent.Forme
{
    public partial class FrmLogin : Form
    {
        private PrijavaKontroler prijavaController;
        public FrmLogin()
        {
            InitializeComponent();
            prijavaController = new PrijavaKontroler();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            prijavaController.Prijava(this);
            if (DialogResult == DialogResult.OK)
            {
                FrmGlavna glavna = new FrmGlavna();
                this.Visible = false;
                glavna.ShowDialog();
                this.Visible = true;
            }
        }
    }
}
