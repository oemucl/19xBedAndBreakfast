namespace BBDataGridViewFom
{
    partial class DGForm
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
            this.dgvGuests = new System.Windows.Forms.DataGridView();
            this.btnGetAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuests)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGuests
            // 
            this.dgvGuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGuests.Location = new System.Drawing.Point(197, 49);
            this.dgvGuests.Name = "dgvGuests";
            this.dgvGuests.RowTemplate.Height = 28;
            this.dgvGuests.Size = new System.Drawing.Size(958, 380);
            this.dgvGuests.TabIndex = 0;
            // 
            // btnGetAll
            // 
            this.btnGetAll.Location = new System.Drawing.Point(50, 49);
            this.btnGetAll.Name = "btnGetAll";
            this.btnGetAll.Size = new System.Drawing.Size(123, 42);
            this.btnGetAll.TabIndex = 1;
            this.btnGetAll.Text = "Hent Alle";
            this.btnGetAll.UseVisualStyleBackColor = true;
            this.btnGetAll.Click += new System.EventHandler(this.btnGetAll_Click);
            // 
            // DGForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 493);
            this.Controls.Add(this.btnGetAll);
            this.Controls.Add(this.dgvGuests);
            this.Name = "DGForm";
            this.Text = "DGForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuests)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGuests;
        private System.Windows.Forms.Button btnGetAll;
    }
}

