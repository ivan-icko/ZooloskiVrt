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
    public partial class UCPrikaziPrijave : UserControl
    {
        PrikaziPrijaveKontroler kontroler;
        public UCPrikaziPrijave()
        {
            InitializeComponent();
            kontroler = new PrikaziPrijaveKontroler(this);
            kontroler.Inicijalizuj();
        }
    }
}
