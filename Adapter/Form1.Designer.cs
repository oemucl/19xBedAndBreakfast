namespace Adapter
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bBGuestDataSet = new Adapter.BBGuestDataSet();
            this.guestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.guestTableAdapter = new Adapter.BBGuestDataSetTableAdapters.GuestTableAdapter();
            this.pasnrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fnavnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enavnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kønDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnHent = new System.Windows.Forms.Button();
            this.btnGem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bBGuestDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pasnrDataGridViewTextBoxColumn,
            this.fnavnDataGridViewTextBoxColumn,
            this.enavnDataGridViewTextBoxColumn,
            this.tlfDataGridViewTextBoxColumn,
            this.adrDataGridViewTextBoxColumn,
            this.kønDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.guestBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(105, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(991, 295);
            this.dataGridView1.TabIndex = 0;
            // 
            // bBGuestDataSet
            // 
            this.bBGuestDataSet.DataSetName = "BBGuestDataSet";
            this.bBGuestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // guestBindingSource
            // 
            this.guestBindingSource.DataMember = "Guest";
            this.guestBindingSource.DataSource = this.bBGuestDataSet;
            // 
            // guestTableAdapter
            // 
            this.guestTableAdapter.ClearBeforeFill = true;
            // 
            // pasnrDataGridViewTextBoxColumn
            // 
            this.pasnrDataGridViewTextBoxColumn.DataPropertyName = "pasnr";
            this.pasnrDataGridViewTextBoxColumn.HeaderText = "pasnr";
            this.pasnrDataGridViewTextBoxColumn.Name = "pasnrDataGridViewTextBoxColumn";
            // 
            // fnavnDataGridViewTextBoxColumn
            // 
            this.fnavnDataGridViewTextBoxColumn.DataPropertyName = "fnavn";
            this.fnavnDataGridViewTextBoxColumn.HeaderText = "fnavn";
            this.fnavnDataGridViewTextBoxColumn.Name = "fnavnDataGridViewTextBoxColumn";
            // 
            // enavnDataGridViewTextBoxColumn
            // 
            this.enavnDataGridViewTextBoxColumn.DataPropertyName = "enavn";
            this.enavnDataGridViewTextBoxColumn.HeaderText = "enavn";
            this.enavnDataGridViewTextBoxColumn.Name = "enavnDataGridViewTextBoxColumn";
            // 
            // tlfDataGridViewTextBoxColumn
            // 
            this.tlfDataGridViewTextBoxColumn.DataPropertyName = "tlf";
            this.tlfDataGridViewTextBoxColumn.HeaderText = "tlf";
            this.tlfDataGridViewTextBoxColumn.Name = "tlfDataGridViewTextBoxColumn";
            // 
            // adrDataGridViewTextBoxColumn
            // 
            this.adrDataGridViewTextBoxColumn.DataPropertyName = "adr";
            this.adrDataGridViewTextBoxColumn.HeaderText = "adr";
            this.adrDataGridViewTextBoxColumn.Name = "adrDataGridViewTextBoxColumn";
            // 
            // kønDataGridViewTextBoxColumn
            // 
            this.kønDataGridViewTextBoxColumn.DataPropertyName = "køn";
            this.kønDataGridViewTextBoxColumn.HeaderText = "køn";
            this.kønDataGridViewTextBoxColumn.Name = "kønDataGridViewTextBoxColumn";
            // 
            // btnHent
            // 
            this.btnHent.Location = new System.Drawing.Point(888, 380);
            this.btnHent.Name = "btnHent";
            this.btnHent.Size = new System.Drawing.Size(99, 48);
            this.btnHent.TabIndex = 1;
            this.btnHent.Text = "Hent";
            this.btnHent.UseVisualStyleBackColor = true;
            this.btnHent.Click += new System.EventHandler(this.btnHent_Click);
            // 
            // btnGem
            // 
            this.btnGem.Location = new System.Drawing.Point(1008, 380);
            this.btnGem.Name = "btnGem";
            this.btnGem.Size = new System.Drawing.Size(88, 48);
            this.btnGem.TabIndex = 2;
            this.btnGem.Text = "Gem";
            this.btnGem.UseVisualStyleBackColor = true;
            this.btnGem.Click += new System.EventHandler(this.btnGem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 450);
            this.Controls.Add(this.btnGem);
            this.Controls.Add(this.btnHent);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bBGuestDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private BBGuestDataSet bBGuestDataSet;
        private System.Windows.Forms.BindingSource guestBindingSource;
        private BBGuestDataSetTableAdapters.GuestTableAdapter guestTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pasnrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnavnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enavnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tlfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kønDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnHent;
        private System.Windows.Forms.Button btnGem;
    }
}

