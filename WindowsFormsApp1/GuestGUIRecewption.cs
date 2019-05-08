using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _19xBedAndBreakfast;

namespace WindowsFormsApp1
{
    public partial class GuestGUIRecewption : Form
    {
        BBController bbc = new BBController();
        public GuestGUIRecewption()
        {
            InitializeComponent();
        }

        private void btnOpret_Click(object sender, EventArgs e)
        {
            bbc.InsertGuest("P88",675,"Ole","M", 'M', "ikjuyt");
        }
    }
}
