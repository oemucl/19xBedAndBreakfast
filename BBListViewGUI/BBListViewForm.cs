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

namespace BBListViewGUI
{
    public partial class BBListViewForm : Form
    {
        BBController bbc = new BBController();
        Guest  _selectedGuest;

        public BBListViewForm()
        {
            InitializeComponent();
        }

        private void btnGetAll_Click(object sender, EventArgs e)
        {
            ClearGrid();
            foreach (var g in bbc.GetAllGuests())
                AddGuestToGrid(g);

            SetSelectedUserInGrid(bbc.gæster[0].PassPortNo);

        }

        private void btnOpretGæst_Click(object sender, EventArgs e)
        {
            _selectedGuest = new Guest(""/*pasnr*/,
                                        0, /* tlf */
                                     "" /*fname*/,
                                     ""  /*lname*/,
                                     'M' /*gender*/,
                                     "" /*address*/);

            this.updateViewDetailValues(_selectedGuest);
            this.CanModifyID = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateUserWithViewValues(_selectedGuest);
            if (!this.bbc.gæster.Contains(_selectedGuest))
            {
                // Add new user
                this.AddGuestToGrid(_selectedGuest);
                bbc.InsertGuest(txtPasnr.Text
                    , Convert.ToInt32(txtTlf.Text)
                    , txtFname.Text
                    , txtLname.Text
                    , Convert.ToChar(txtKøn.Text)
                    , txtAdresse.Text);
                MessageBox.Show("Gæst oprettet");
            }
            else
            {
                // Update existing
                bbc.UpdateGuest(txtPasnr.Text
                    , Convert.ToInt32(txtTlf.Text)
                    , txtFname.Text
                    , txtLname.Text
                    , Convert.ToChar(txtKøn.Text)
                    , txtAdresse.Text);
                this.UpdateGridWithChangedUser(_selectedGuest);
                MessageBox.Show("Gæst opdateret");
            }
            SetSelectedUserInGrid(txtPasnr.Text);
            this.CanModifyID = false;

        }

        private void btnSlet_Click(object sender, EventArgs e)
        {
            string pasnr = this.GetIdOfSelectedUserInGrid();
            Guest guestToRemove = null;

            if (pasnr != "")
            {
                foreach (var g in bbc.gæster)
                {
                    if (g.PassPortNo == pasnr)
                    {
                        guestToRemove = g;
                        break;
                    }
                }

                if (guestToRemove != null)
                {
                    int newSelectedIndex = this.bbc.gæster.IndexOf(guestToRemove);
                    this.bbc.gæster.Remove(guestToRemove);
                    this.RemoveUserFromGrid(guestToRemove);

                    if (newSelectedIndex > -1 && newSelectedIndex < bbc.gæster.Count)
                    {
                        this.SetSelectedUserInGrid(bbc.gæster[newSelectedIndex].PassPortNo);
                    }
                    bbc.DeleteGuest(guestToRemove.PassPortNo);
                    MessageBox.Show("Gæst slettet");
                }
            }
        }

        private void lvGuests_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lvGuests.SelectedItems.Count > 0)
                this.SelectedUserChanged(this.lvGuests.SelectedItems[0].Text);
        }

        public void ClearGrid()
        {
            // Define columns in grid
            this.lvGuests.Columns.Clear();

            this.lvGuests.Columns.Add("Pasno",   100,  HorizontalAlignment.Left);
            this.lvGuests.Columns.Add("Tlf", 100, HorizontalAlignment.Left);
            this.lvGuests.Columns.Add("Fornavn",  100,  HorizontalAlignment.Left);
            this.lvGuests.Columns.Add("Efternavn", 100,  HorizontalAlignment.Left);
            this.lvGuests.Columns.Add("Køn", 25, HorizontalAlignment.Left);
            this.lvGuests.Columns.Add("Adr", 100, HorizontalAlignment.Left);

            // Add rows to grid
            this.lvGuests.Items.Clear();
        }

        public void AddGuestToGrid(Guest g)
        {
            ListViewItem parent;
            parent = this.lvGuests.Items.Add(g.PassPortNo);
            parent.SubItems.Add(g.PhoneNo.ToString());
            parent.SubItems.Add(g.FName);
            parent.SubItems.Add(g.LName);
            parent.SubItems.Add(g.Gender.ToString());
            parent.SubItems.Add(g.Address);
        }

        public void UpdateGridWithChangedUser(Guest g)
        {
            ListViewItem rowToUpdate = null;

            foreach (ListViewItem row in this.lvGuests.Items)
            {
                if (row.Text == g.PassPortNo)
                {
                    rowToUpdate = row;
                }
            }

            if (rowToUpdate != null)
            {
                rowToUpdate.Text = g.PassPortNo;
                rowToUpdate.SubItems[1].Text = g.PhoneNo.ToString();
                rowToUpdate.SubItems[2].Text = g.FName;
                rowToUpdate.SubItems[3].Text = g.LName;
                rowToUpdate.SubItems[4].Text = g.Gender.ToString();
                rowToUpdate.SubItems[5].Text = g.Address;
            }
        }

        public void RemoveUserFromGrid(Guest g)
        {

            ListViewItem rowToRemove = null;

            foreach (ListViewItem row in this.lvGuests.Items)
            {
                if (row.Text == g.PassPortNo)
                {
                    rowToRemove = row;
                }
            }

            if (rowToRemove != null)
            {
                this.lvGuests.Items.Remove(rowToRemove);
                this.lvGuests.Focus();
            }
        }

        public string GetIdOfSelectedUserInGrid()
        {
            if (this.lvGuests.SelectedItems.Count > 0)
                return this.lvGuests.SelectedItems[0].Text;
            else
                return "";
        }

        public void SetSelectedUserInGrid(string pasnr)
        {
            foreach (ListViewItem row in this.lvGuests.Items)
            {
                if (row.Text == pasnr)
                {
                    row.Selected = true;
                }
            }
        }

        private void updateViewDetailValues(Guest g)
        {
            Fname= g.FName;
            Lname= g.LName;
            Pasnr= g.PassPortNo;
            Address = g.Address;
            Tlfnr = g.PhoneNo;
            Gender = g.Gender;
        }

        private void updateUserWithViewValues(Guest g)
        {
            g.FName = Fname;
            g.LName = Lname;
            g.PassPortNo = Pasnr;
            g.Address= Address;
            g.PhoneNo= Tlfnr;
            g.Gender= Gender;
        }


        public void SelectedUserChanged(string selectedUserId)
        {
            foreach (var g in bbc.gæster)
            {
                if (g.PassPortNo== selectedUserId)
                {
                    _selectedGuest = g;
                    updateViewDetailValues(g);
                    SetSelectedUserInGrid(g.PassPortNo);
                    this.CanModifyID = false;
                    break;
                }
            }
        }

                public string Fname
                {
                    get { return this.txtFname.Text; }
                    set { this.txtFname.Text = value; }
                }

                public string Lname
                {
                    get { return this.txtLname.Text; }
                    set { this.txtLname.Text = value; }
                }

                public string Pasnr
                {
                    get { return this.txtPasnr.Text; }
                    set { this.txtPasnr.Text = value; }
                }

        public int Tlfnr
        {
            get { return Convert.ToInt32(txtTlf.Text); }
            set { txtTlf.Text= value.ToString(); }
        }
        public char Gender
        {
            get { return Convert.ToChar(txtKøn.Text); }
            set
            {
                if (value == 'M' || value == 'F')
                {
                    txtKøn.Text= value.ToString();
                }
                else
                {
                    throw new ArgumentException("Køn skal være 'M' el 'F'");
                }
            }
        }
        public string Address
        {
            get { return txtAdresse.Text; }
            set { txtAdresse.Text= value; }
        }

        public bool CanModifyID
                {
                    set { this.txtPasnr.Enabled = value;
                          this.btnOpretGæst.Enabled = !value;
                        }
               }

    }
}
