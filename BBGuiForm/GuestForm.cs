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

namespace BBGuiForm
{
    public partial class GuestForm : Form
    {
        BBController bbc = new BBController();
        public GuestForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            string pasnr = textPasnr.Text;
            string fnavn = textFnavn.Text;
            string lnavn = textLnavn.Text;
            string adr = textAdr.Text;
            char køn  = Convert.ToChar(textKøn.Text);
            int tlf = Convert.ToInt32(textTlf.Text);
            bbc.InsertGuest(pasnr, tlf, fnavn, lnavn,køn,adr);
            MessageBox.Show("Gæst oprettet");
        }

    }
}
