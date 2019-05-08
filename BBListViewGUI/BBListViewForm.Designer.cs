namespace BBListViewGUI
{
    partial class BBListViewForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvGuests = new System.Windows.Forms.ListView();
            this.btnGetAll = new System.Windows.Forms.Button();
            this.btnSlet = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.txtKøn = new System.Windows.Forms.TextBox();
            this.txtTlf = new System.Windows.Forms.TextBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.txtPasnr = new System.Windows.Forms.TextBox();
            this.btnOpretGæst = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvGuests
            // 
            this.lvGuests.FullRowSelect = true;
            this.lvGuests.GridLines = true;
            this.lvGuests.Location = new System.Drawing.Point(374, 33);
            this.lvGuests.Name = "lvGuests";
            this.lvGuests.Size = new System.Drawing.Size(756, 511);
            this.lvGuests.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvGuests.TabIndex = 0;
            this.lvGuests.UseCompatibleStateImageBehavior = false;
            this.lvGuests.SelectedIndexChanged += new System.EventHandler(this.lvGuests_SelectedIndexChanged);
            // 
            // btnGetAll
            // 
            this.btnGetAll.Location = new System.Drawing.Point(28, 564);
            this.btnGetAll.Name = "btnGetAll";
            this.btnGetAll.Size = new System.Drawing.Size(128, 39);
            this.btnGetAll.TabIndex = 1;
            this.btnGetAll.Text = "Hent alle";
            this.btnGetAll.UseVisualStyleBackColor = true;
            this.btnGetAll.Click += new System.EventHandler(this.btnGetAll_Click);
            // 
            // btnSlet
            // 
            this.btnSlet.Location = new System.Drawing.Point(448, 564);
            this.btnSlet.Name = "btnSlet";
            this.btnSlet.Size = new System.Drawing.Size(112, 39);
            this.btnSlet.TabIndex = 31;
            this.btnSlet.Text = "Slet";
            this.btnSlet.UseVisualStyleBackColor = true;
            this.btnSlet.Click += new System.EventHandler(this.btnSlet_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(319, 564);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(112, 39);
            this.btnUpdate.TabIndex = 30;
            this.btnUpdate.Text = "Opdater";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 465);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "Adresse";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 436);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Køn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 404);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Tlf";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Efternavn";
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(124, 462);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(161, 26);
            this.txtAdresse.TabIndex = 24;
            // 
            // txtKøn
            // 
            this.txtKøn.Location = new System.Drawing.Point(126, 430);
            this.txtKøn.Name = "txtKøn";
            this.txtKøn.Size = new System.Drawing.Size(30, 26);
            this.txtKøn.TabIndex = 23;
            // 
            // txtTlf
            // 
            this.txtTlf.Location = new System.Drawing.Point(124, 398);
            this.txtTlf.Name = "txtTlf";
            this.txtTlf.Size = new System.Drawing.Size(100, 26);
            this.txtTlf.TabIndex = 22;
            // 
            // txtLname
            // 
            this.txtLname.Location = new System.Drawing.Point(124, 363);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(143, 26);
            this.txtLname.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Fornavn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Pasnr";
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(124, 334);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(100, 26);
            this.txtFname.TabIndex = 18;
            // 
            // txtPasnr
            // 
            this.txtPasnr.Location = new System.Drawing.Point(124, 302);
            this.txtPasnr.Name = "txtPasnr";
            this.txtPasnr.Size = new System.Drawing.Size(100, 26);
            this.txtPasnr.TabIndex = 17;
            // 
            // btnOpretGæst
            // 
            this.btnOpretGæst.Location = new System.Drawing.Point(177, 564);
            this.btnOpretGæst.Name = "btnOpretGæst";
            this.btnOpretGæst.Size = new System.Drawing.Size(112, 39);
            this.btnOpretGæst.TabIndex = 16;
            this.btnOpretGæst.Text = "Opret";
            this.btnOpretGæst.UseVisualStyleBackColor = true;
            this.btnOpretGæst.Click += new System.EventHandler(this.btnOpretGæst_Click);
            // 
            // BBListViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 622);
            this.Controls.Add(this.btnSlet);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.txtKøn);
            this.Controls.Add(this.txtTlf);
            this.Controls.Add(this.txtLname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.txtPasnr);
            this.Controls.Add(this.btnOpretGæst);
            this.Controls.Add(this.btnGetAll);
            this.Controls.Add(this.lvGuests);
            this.Name = "BBListViewForm";
            this.Text = "BBListViewForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGetAll;
        internal System.Windows.Forms.ListView lvGuests;
        private System.Windows.Forms.Button btnSlet;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.TextBox txtKøn;
        private System.Windows.Forms.TextBox txtTlf;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.TextBox txtPasnr;
        private System.Windows.Forms.Button btnOpretGæst;
    }
}

