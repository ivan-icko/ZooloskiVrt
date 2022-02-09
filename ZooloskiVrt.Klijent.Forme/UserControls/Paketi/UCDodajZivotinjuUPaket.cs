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

namespace ZooloskiVrt.Klijent.Forme.UserControls.Paketi
{
    public partial class UCDodajZivotinjuUPaket : UserControl
    {
        DodajZivotinjuUPaketKontroler kontroler;

        public UCDodajZivotinjuUPaket(int idPaketa)
        {
            InitializeComponent();
            kontroler = new DodajZivotinjuUPaketKontroler(this,idPaketa);
            kontroler.Inicijalizuj();
        }
    }
}
