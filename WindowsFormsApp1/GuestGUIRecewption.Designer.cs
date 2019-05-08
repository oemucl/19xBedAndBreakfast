namespace WindowsFormsApp1
{
    partial class GuestGUIRecewption
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
            this.btnOpret = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpret
            // 
            this.btnOpret.Location = new System.Drawing.Point(551, 333);
            this.btnOpret.Name = "btnOpret";
            this.btnOpret.Size = new System.Drawing.Size(86, 32);
            this.btnOpret.TabIndex = 0;
            this.btnOpret.Text = "Opret";
            this.btnOpret.UseVisualStyleBackColor = true;
            this.btnOpret.Click += new System.EventHandler(this.btnOpret_Click);
            // 
            // GuestGUIRecewption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOpret);
            this.Name = "GuestGUIRecewption";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpret;
    }
}

