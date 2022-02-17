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
    public partial class UCZivotinje : UserControl
    {
        ZivotinjeKontroler kontroler;
        public UCZivotinje()
        {
            InitializeComponent();
            kontroler = new ZivotinjeKontroler(this);
            kontroler.Inicijalizuj();
        }
        
    }
}
