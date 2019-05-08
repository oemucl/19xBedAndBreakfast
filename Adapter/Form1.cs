using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adapter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnHent_Click(object sender, EventArgs e)
        {
            this.guestTableAdapter.Fill(this.bBGuestDataSet.Guest);
        }

        private void btnGem_Click(object sender, EventArgs e)
        {
            this.guestTableAdapter.Update(this.bBGuestDataSet.Guest);
        }
    }
}
