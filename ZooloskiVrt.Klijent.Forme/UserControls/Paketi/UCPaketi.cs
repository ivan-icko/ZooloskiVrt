using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZooloskiVrt.Common.Domen;
using ZooloskiVrt.Klijent.Forme.GUIController;

namespace ZooloskiVrt.Klijent.Forme.UserControls.Paketi
{
    public partial class UCPaketi : UserControl
    {
        PaketiKontroler kontroler;
        private Panel pnlMain;
        public UCPaketi(Panel pnlMain)
        {
            InitializeComponent();
            this.pnlMain = pnlMain;
            kontroler = new PaketiKontroler(this,pnlMain);
            kontroler.Inicijalizuj();
        }

        
    }
}
