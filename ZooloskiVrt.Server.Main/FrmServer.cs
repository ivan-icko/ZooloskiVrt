using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooloskiVrt.Server.Main
{
    public partial class FrmServer : Form
    {
        private Server server;
        public FrmServer()
        {
            InitializeComponent();
            
        }

        private void btnPokreni_Click(object sender, EventArgs e)
        {
            server = new Server();
            if (server.Start())
            {
                btnPokreni.Enabled = false;
                btnPokreni.BackColor = Color.Green;
                btnZaustavi.BackColor = default;
                btnZaustavi.Enabled = true;
                Thread nit = new Thread(()=> { server.Osluskuj(); });
                nit.IsBackground = true;
                nit.Start();

            }
        }

        private void btnZaustavi_Click(object sender, EventArgs e)
        {
            server?.Stop();
            server = null;
            btnPokreni.Enabled = true;
            btnZaustavi.Enabled = false;
            btnZaustavi.BackColor = Color.Red;
            btnPokreni.BackColor = default;
        }

        private void FrmServer_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            Environment.Exit(0);
        }
    }
}
