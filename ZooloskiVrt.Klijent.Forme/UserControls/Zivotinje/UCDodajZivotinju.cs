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
    public partial class UCDodajZivotinju : UserControl
    {
        DodajZivotinjuKontroler kontroler;
        public UCDodajZivotinju()
        {
            InitializeComponent();
            kontroler = new DodajZivotinjuKontroler(this);
            kontroler.Inicijalizuj(this);
        }

        
    }
}
