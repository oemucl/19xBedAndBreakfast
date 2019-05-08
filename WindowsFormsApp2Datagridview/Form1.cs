using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2Datagridview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bBDataSetGuest.Guest' table. You can move, or remove it, as needed.
            this.guestTableAdapter.Fill(this.bBDataSetGuest.Guest);

        }

        private void btnGem_Click(object sender, EventArgs e)
        {
            this.guestTableAdapter.Update(this.bBDataSetGuest.Guest);
        }
    }
}
