using System;
using System.Windows.Forms;
using _19xBedAndBreakfast;

namespace BBGui
{
    public partial class GuestForm : Form
    {
        BBController bbc = new BBController();
        public GuestForm()
        {
            InitializeComponent();
        }
        private void btnOpretGæst_Click(object sender, EventArgs e)
        {
            bbc.InsertGuest(txtPasnr.Text
                , Convert.ToInt32(txtTlf.Text)
                , txtFname.Text
                , txtLname.Text
                , Convert.ToChar(txtKøn.Text)
                , txtAdresse.Text);
            MessageBox.Show("Gæst oprettet");
        }

        private void btnShowGuest_Click(object sender, EventArgs e)
        {
            bool found = bbc.GetGuestByPassPortNo(txtPasnr.Text);
            if (found)
            {
                txtPasnr.Text = bbc.g.PassPortNo;
                txtTlf.Text = bbc.g.PhoneNo.ToString();
                txtFname.Text = bbc.g.FName;
                txtLname.Text = bbc.g.LName;
                txtKøn.Text = bbc.g.Gender.ToString();
                txtAdresse.Text = bbc.g.Address;
            }
            else
            {
                MessageBox.Show("Gæst blev ikke fundet");
                foreach (Control c in this.Controls)
                {
                    if (c.GetType() == typeof(TextBox))
                    {
                        c.Text = "";
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bbc.UpdateGuest(txtPasnr.Text
                , Convert.ToInt32(txtTlf.Text)
                , txtFname.Text
                , txtLname.Text
                , Convert.ToChar(txtKøn.Text)
                , txtAdresse.Text);
            MessageBox.Show("Gæst opdateret");
        }

        private void btnSlet_Click(object sender, EventArgs e)
        {
            bbc.DeleteGuest(txtPasnr.Text);
            MessageBox.Show("Gæst slettet");
        }
    }
}
