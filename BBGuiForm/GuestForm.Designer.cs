namespace BBGuiForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.textPasnr = new System.Windows.Forms.TextBox();
            this.textFnavn = new System.Windows.Forms.TextBox();
            this.textLnavn = new System.Windows.Forms.TextBox();
            this.textTlf = new System.Windows.Forms.TextBox();
            this.textKøn = new System.Windows.Forms.TextBox();
            this.textAdr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(573, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Opret";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textPasnr
            // 
            this.textPasnr.Location = new System.Drawing.Point(562, 138);
            this.textPasnr.Name = "textPasnr";
            this.textPasnr.Size = new System.Drawing.Size(100, 26);
            this.textPasnr.TabIndex = 1;
            this.textPasnr.Text = "P88";
            // 
            // textFnavn
            // 
            this.textFnavn.Location = new System.Drawing.Point(562, 170);
            this.textFnavn.Name = "textFnavn";
            this.textFnavn.Size = new System.Drawing.Size(100, 26);
            this.textFnavn.TabIndex = 2;
            // 
            // textLnavn
            // 
            this.textLnavn.Location = new System.Drawing.Point(562, 202);
            this.textLnavn.Name = "textLnavn";
            this.textLnavn.Size = new System.Drawing.Size(100, 26);
            this.textLnavn.TabIndex = 3;
            // 
            // textTlf
            // 
            this.textTlf.Location = new System.Drawing.Point(562, 234);
            this.textTlf.Name = "textTlf";
            this.textTlf.Size = new System.Drawing.Size(100, 26);
            this.textTlf.TabIndex = 4;
            // 
            // textKøn
            // 
            this.textKøn.Location = new System.Drawing.Point(562, 266);
            this.textKøn.Name = "textKøn";
            this.textKøn.Size = new System.Drawing.Size(100, 26);
            this.textKøn.TabIndex = 5;
            // 
            // textAdr
            // 
            this.textAdr.Location = new System.Drawing.Point(562, 298);
            this.textAdr.Name = "textAdr";
            this.textAdr.Size = new System.Drawing.Size(100, 26);
            this.textAdr.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(460, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Pasnummer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(462, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Fornavn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(460, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Efternavn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(460, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tlf";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(460, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Køn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(460, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Adresse";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(107, 234);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // GuestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textAdr);
            this.Controls.Add(this.textKøn);
            this.Controls.Add(this.textTlf);
            this.Controls.Add(this.textLnavn);
            this.Controls.Add(this.textFnavn);
            this.Controls.Add(this.textPasnr);
            this.Controls.Add(this.button1);
            this.Name = "GuestForm";
            this.Text = "Her holder du styr på alle gæsterne";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textPasnr;
        private System.Windows.Forms.TextBox textFnavn;
        private System.Windows.Forms.TextBox textLnavn;
        private System.Windows.Forms.TextBox textTlf;
        private System.Windows.Forms.TextBox textKøn;
        private System.Windows.Forms.TextBox textAdr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
    }
}

