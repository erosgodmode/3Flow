namespace TrioFlow
{
    partial class CustomerBillForm
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
            lblOrderNo = new Label();
            txtOrderNo = new TextBox();
            btnGenerateBill = new Button();
            lblCustomerID = new Label();
            txtCustomerID = new TextBox();
            lblFirstName = new Label();
            txtFirstName = new TextBox();
            lblLastName = new Label();
            txtLastName = new TextBox();
            lblMI = new Label();
            txtMI = new TextBox();
            dgvBill = new DataGridView();
            lblTotalBill = new Label();
            txtTotalBill = new TextBox();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBill).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Arial", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(12, 12);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(653, 40);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "COLLECTIBLE BY ORDER NUMBER";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblOrderNo
            // 
            lblOrderNo.Font = new Font("Arial", 9F, FontStyle.Bold);
            lblOrderNo.Location = new Point(12, 63);
            lblOrderNo.Margin = new Padding(4, 0, 4, 0);
            lblOrderNo.Name = "lblOrderNo";
            lblOrderNo.Size = new Size(93, 27);
            lblOrderNo.TabIndex = 1;
            lblOrderNo.Text = "ORDER NO:";
            // 
            // txtOrderNo
            // 
            txtOrderNo.Location = new Point(111, 61);
            txtOrderNo.Margin = new Padding(4, 3, 4, 3);
            txtOrderNo.Name = "txtOrderNo";
            txtOrderNo.Size = new Size(116, 23);
            txtOrderNo.TabIndex = 2;
            // 
            // btnGenerateBill
            // 
            btnGenerateBill.BackColor = Color.DeepSkyBlue;
            btnGenerateBill.FlatStyle = FlatStyle.Flat;
            btnGenerateBill.ForeColor = Color.White;
            btnGenerateBill.Location = new Point(239, 58);
            btnGenerateBill.Margin = new Padding(4, 3, 4, 3);
            btnGenerateBill.Name = "btnGenerateBill";
            btnGenerateBill.Size = new Size(128, 32);
            btnGenerateBill.TabIndex = 3;
            btnGenerateBill.Text = "GENERATE BILL";
            btnGenerateBill.UseVisualStyleBackColor = false;
            btnGenerateBill.Click += btnGenerateBill_Click;
            // 
            // lblCustomerID
            // 
            lblCustomerID.Font = new Font("Arial", 9F, FontStyle.Bold);
            lblCustomerID.Location = new Point(12, 104);
            lblCustomerID.Margin = new Padding(4, 0, 4, 0);
            lblCustomerID.Name = "lblCustomerID";
            lblCustomerID.Size = new Size(105, 27);
            lblCustomerID.TabIndex = 4;
            lblCustomerID.Text = "CUSTOMER ID";
            // 
            // txtCustomerID
            // 
            txtCustomerID.Location = new Point(122, 102);
            txtCustomerID.Margin = new Padding(4, 3, 4, 3);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.ReadOnly = true;
            txtCustomerID.Size = new Size(93, 23);
            txtCustomerID.TabIndex = 5;
            // 
            // lblFirstName
            // 
            lblFirstName.Font = new Font("Arial", 9F, FontStyle.Bold);
            lblFirstName.Location = new Point(12, 138);
            lblFirstName.Margin = new Padding(4, 0, 4, 0);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(93, 27);
            lblFirstName.TabIndex = 6;
            lblFirstName.Text = "FIRSTNAME";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(111, 136);
            txtFirstName.Margin = new Padding(4, 3, 4, 3);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.ReadOnly = true;
            txtFirstName.Size = new Size(139, 23);
            txtFirstName.TabIndex = 7;
            // 
            // lblLastName
            // 
            lblLastName.Font = new Font("Arial", 9F, FontStyle.Bold);
            lblLastName.Location = new Point(268, 138);
            lblLastName.Margin = new Padding(4, 0, 4, 0);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(93, 27);
            lblLastName.TabIndex = 8;
            lblLastName.Text = "LASTNAME";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(368, 136);
            txtLastName.Margin = new Padding(4, 3, 4, 3);
            txtLastName.Name = "txtLastName";
            txtLastName.ReadOnly = true;
            txtLastName.Size = new Size(139, 23);
            txtLastName.TabIndex = 9;
            // 
            // lblMI
            // 
            lblMI.Font = new Font("Arial", 9F, FontStyle.Bold);
            lblMI.Location = new Point(525, 138);
            lblMI.Margin = new Padding(4, 0, 4, 0);
            lblMI.Name = "lblMI";
            lblMI.Size = new Size(29, 27);
            lblMI.TabIndex = 10;
            lblMI.Text = "MI";
            // 
            // txtMI
            // 
            txtMI.Location = new Point(560, 136);
            txtMI.Margin = new Padding(4, 3, 4, 3);
            txtMI.Name = "txtMI";
            txtMI.ReadOnly = true;
            txtMI.Size = new Size(46, 23);
            txtMI.TabIndex = 11;
            txtMI.TextChanged += txtMI_TextChanged;
            // 
            // dgvBill
            // 
            dgvBill.AllowUserToAddRows = false;
            dgvBill.AllowUserToDeleteRows = false;
            dgvBill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBill.BackgroundColor = SystemColors.Control;
            dgvBill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBill.Location = new Point(12, 179);
            dgvBill.Margin = new Padding(4, 3, 4, 3);
            dgvBill.Name = "dgvBill";
            dgvBill.ReadOnly = true;
            dgvBill.Size = new Size(653, 254);
            dgvBill.TabIndex = 12;
            // 
            // lblTotalBill
            // 
            lblTotalBill.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblTotalBill.Location = new Point(12, 450);
            lblTotalBill.Margin = new Padding(4, 0, 4, 0);
            lblTotalBill.Name = "lblTotalBill";
            lblTotalBill.Size = new Size(105, 27);
            lblTotalBill.TabIndex = 13;
            lblTotalBill.Text = "TOTAL BILL:";
            // 
            // txtTotalBill
            // 
            txtTotalBill.Location = new Point(122, 448);
            txtTotalBill.Margin = new Padding(4, 3, 4, 3);
            txtTotalBill.Name = "txtTotalBill";
            txtTotalBill.ReadOnly = true;
            txtTotalBill.Size = new Size(139, 23);
            txtTotalBill.TabIndex = 14;
            txtTotalBill.Text = "0";
            // 
            // btnClose
            // 
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(572, 448);
            btnClose.Margin = new Padding(4, 3, 4, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(93, 32);
            btnClose.TabIndex = 15;
            btnClose.Text = "CLOSE";
            btnClose.Click += btnClose_Click;
            // 
            // CustomerBillForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(681, 496);
            Controls.Add(lblTitle);
            Controls.Add(lblOrderNo);
            Controls.Add(txtOrderNo);
            Controls.Add(btnGenerateBill);
            Controls.Add(lblCustomerID);
            Controls.Add(txtCustomerID);
            Controls.Add(lblFirstName);
            Controls.Add(txtFirstName);
            Controls.Add(lblLastName);
            Controls.Add(txtLastName);
            Controls.Add(lblMI);
            Controls.Add(txtMI);
            Controls.Add(dgvBill);
            Controls.Add(lblTotalBill);
            Controls.Add(txtTotalBill);
            Controls.Add(btnClose);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "CustomerBillForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer Bill Form";
            ((System.ComponentModel.ISupportInitialize)dgvBill).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblOrderNo;
        private System.Windows.Forms.TextBox txtOrderNo;
        private System.Windows.Forms.Button btnGenerateBill;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblMI;
        private System.Windows.Forms.TextBox txtMI;
        private System.Windows.Forms.DataGridView dgvBill;
        private System.Windows.Forms.Label lblTotalBill;
        private System.Windows.Forms.TextBox txtTotalBill;
        private System.Windows.Forms.Button btnClose;
    }
}