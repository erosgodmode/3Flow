namespace TrioFlow
{
    partial class StockList
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblSearch = new Label();
            txtSearch = new TextBox();
            btnViewList = new Button();
            dgvStock = new DataGridView();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvStock).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Arial", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(12, 12);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(770, 40);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Stock List";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSearch
            // 
            lblSearch.BackColor = Color.Transparent;
            lblSearch.Font = new Font("Arial", 9F, FontStyle.Bold);
            lblSearch.ForeColor = Color.White;
            lblSearch.Location = new Point(455, 69);
            lblSearch.Margin = new Padding(4, 0, 4, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(76, 27);
            lblSearch.TabIndex = 2;
            lblSearch.Text = "SEARCH:";
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.White;
            txtSearch.Location = new Point(537, 67);
            txtSearch.Margin = new Padding(4, 3, 4, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(233, 23);
            txtSearch.TabIndex = 3;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnViewList
            // 
            btnViewList.BackColor = Color.White;
            btnViewList.FlatStyle = FlatStyle.Flat;
            btnViewList.Location = new Point(12, 63);
            btnViewList.Margin = new Padding(4, 3, 4, 3);
            btnViewList.Name = "btnViewList";
            btnViewList.Size = new Size(93, 32);
            btnViewList.TabIndex = 1;
            btnViewList.Text = "VIEW LIST";
            btnViewList.UseVisualStyleBackColor = false;
            btnViewList.Click += btnViewList_Click;
            // 
            // dgvStock
            // 
            dgvStock.AllowUserToAddRows = false;
            dgvStock.AllowUserToDeleteRows = false;
            dgvStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStock.BackgroundColor = Color.DeepSkyBlue;
            dgvStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStock.Location = new Point(12, 110);
            dgvStock.Margin = new Padding(4, 3, 4, 3);
            dgvStock.MultiSelect = false;
            dgvStock.Name = "dgvStock";
            dgvStock.ReadOnly = true;
            dgvStock.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStock.Size = new Size(770, 346);
            dgvStock.TabIndex = 4;
            dgvStock.CellDoubleClick += dgvStock_CellDoubleClick;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.White;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Location = new Point(688, 473);
            btnExit.Margin = new Padding(4, 3, 4, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(93, 32);
            btnExit.TabIndex = 5;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // StockList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(798, 519);
            Controls.Add(lblTitle);
            Controls.Add(btnViewList);
            Controls.Add(lblSearch);
            Controls.Add(txtSearch);
            Controls.Add(dgvStock);
            Controls.Add(btnExit);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "StockList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TrioFlow - Stock List";
            Load += StockList_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnViewList;
        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.Button btnExit;
    }
}