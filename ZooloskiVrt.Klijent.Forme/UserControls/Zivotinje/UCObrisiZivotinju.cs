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

namespace ZooloskiVrt.Klijent.Forme.UserControls.Zivotinje
{
    public partial class UCObrisiZivotinju : UserControl
    {
        ObrisiZivotinjuKontroler kontroler;
        public UCObrisiZivotinju()
        {
            InitializeComponent();
            kontroler = new ObrisiZivotinjuKontroler(this);
            kontroler.Inicijalizuj(this);
        }
    }
}
