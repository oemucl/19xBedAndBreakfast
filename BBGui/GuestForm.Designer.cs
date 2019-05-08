namespace BBGui
{
    partial class GuestForm
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
            this.btnOpretGæst = new System.Windows.Forms.Button();
            this.txtPasnr = new System.Windows.Forms.TextBox();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.txtTlf = new System.Windows.Forms.TextBox();
            this.txtKøn = new System.Windows.Forms.TextBox();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnShowGuest = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSlet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpretGæst
            // 
            this.btnOpretGæst.Location = new System.Drawing.Point(191, 325);
            this.btnOpretGæst.Name = "btnOpretGæst";
            this.btnOpretGæst.Size = new System.Drawing.Size(112, 39);
            this.btnOpretGæst.TabIndex = 0;
            this.btnOpretGæst.Text = "Opret";
            this.btnOpretGæst.UseVisualStyleBackColor = true;
            this.btnOpretGæst.Click += new System.EventHandler(this.btnOpretGæst_Click);
            // 
            // txtPasnr
            // 
            this.txtPasnr.Location = new System.Drawing.Point(138, 63);
            this.txtPasnr.Name = "txtPasnr";
            this.txtPasnr.Size = new System.Drawing.Size(100, 26);
            this.txtPasnr.TabIndex = 1;
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(138, 95);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(100, 26);
            this.txtFname.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pasnr";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fornavn";
            // 
            // txtLname
            // 
            this.txtLname.Location = new System.Drawing.Point(138, 124);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(143, 26);
            this.txtLname.TabIndex = 5;
            // 
            // txtTlf
            // 
            this.txtTlf.Location = new System.Drawing.Point(138, 159);
            this.txtTlf.Name = "txtTlf";
            this.txtTlf.Size = new System.Drawing.Size(100, 26);
            this.txtTlf.TabIndex = 6;
            // 
            // txtKøn
            // 
            this.txtKøn.Location = new System.Drawing.Point(140, 191);
            this.txtKøn.Name = "txtKøn";
            this.txtKøn.Size = new System.Drawing.Size(30, 26);
            this.txtKøn.TabIndex = 7;
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(138, 223);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(161, 26);
            this.txtAdresse.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Efternavn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tlf";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Køn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Adresse";
            // 
            // btnShowGuest
            // 
            this.btnShowGuest.Location = new System.Drawing.Point(58, 325);
            this.btnShowGuest.Name = "btnShowGuest";
            this.btnShowGuest.Size = new System.Drawing.Size(112, 39);
            this.btnShowGuest.TabIndex = 13;
            this.btnShowGuest.Text = "Vis ";
            this.btnShowGuest.UseVisualStyleBackColor = true;
            this.btnShowGuest.Click += new System.EventHandler(this.btnShowGuest_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(333, 325);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(112, 39);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Opdater";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSlet
            // 
            this.btnSlet.Location = new System.Drawing.Point(462, 325);
            this.btnSlet.Name = "btnSlet";
            this.btnSlet.Size = new System.Drawing.Size(112, 39);
            this.btnSlet.TabIndex = 15;
            this.btnSlet.Text = "Slet";
            this.btnSlet.UseVisualStyleBackColor = true;
            this.btnSlet.Click += new System.EventHandler(this.btnSlet_Click);
            // 
            // GuestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSlet);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnShowGuest);
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
            this.Name = "GuestForm";
            this.Text = "Gæster";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpretGæst;
        private System.Windows.Forms.TextBox txtPasnr;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.TextBox txtTlf;
        private System.Windows.Forms.TextBox txtKøn;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnShowGuest;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSlet;
    }
}

