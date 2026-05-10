namespace TrioFlow
{
    partial class Form3
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
            menuStrip1 = new MenuStrip();
            orderFormMenuItem = new ToolStripMenuItem();
            customerListMenuItem = new ToolStripMenuItem();
            stockListMenuItem = new ToolStripMenuItem();
            lblTitle = new Label();
            lblOrderID = new Label();
            lblDate = new Label();
            lblCustomerID = new Label();
            lblFirstName = new Label();
            lblLastName = new Label();
            lblMI = new Label();
            lblStockID = new Label();
            lblDescription = new Label();
            lblPrice = new Label();
            lblQty = new Label();
            lblTotal = new Label();
            txtOrderID = new TextBox();
            txtDate = new TextBox();
            txtCustomerID = new TextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtMI = new TextBox();
            txtStockID = new TextBox();
            txtDescription = new TextBox();
            txtPrice = new TextBox();
            txtQty = new TextBox();
            txtTotal = new TextBox();
            btnLoad = new Button();
            btnSave = new Button();
            btnClear = new Button();
            dgvOrders = new DataGridView();
            colStockID = new DataGridViewTextBoxColumn();
            colDescription = new DataGridViewTextBoxColumn();
            colPrice = new DataGridViewTextBoxColumn();
            colQty = new DataGridViewTextBoxColumn();
            colSales = new DataGridViewTextBoxColumn();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.DeepSkyBlue;
            menuStrip1.Items.AddRange(new ToolStripItem[] { orderFormMenuItem, customerListMenuItem, stockListMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(817, 24);
            menuStrip1.TabIndex = 0;
            // 
            // orderFormMenuItem
            // 
            orderFormMenuItem.ForeColor = Color.White;
            orderFormMenuItem.Name = "orderFormMenuItem";
            orderFormMenuItem.Size = new Size(92, 20);
            orderFormMenuItem.Text = "ORDER FORM";
            // 
            // customerListMenuItem
            // 
            customerListMenuItem.ForeColor = Color.White;
            customerListMenuItem.Name = "customerListMenuItem";
            customerListMenuItem.Size = new Size(105, 20);
            customerListMenuItem.Text = "CUSTOMER LIST";
            // 
            // stockListMenuItem
            // 
            stockListMenuItem.ForeColor = Color.White;
            stockListMenuItem.Name = "stockListMenuItem";
            stockListMenuItem.Size = new Size(80, 20);
            stockListMenuItem.Text = "STOCK LIST";
            stockListMenuItem.Click += stockListMenuItem_Click;
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(18, 35);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(233, 52);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "TrioFlow Water \r\nRefilling Station";
            // 
            // lblOrderID
            // 
            lblOrderID.BackColor = Color.Transparent;
            lblOrderID.Font = new Font("Arial", 9F, FontStyle.Bold);
            lblOrderID.ForeColor = Color.White;
            lblOrderID.Location = new Point(18, 92);
            lblOrderID.Margin = new Padding(4, 0, 4, 0);
            lblOrderID.Name = "lblOrderID";
            lblOrderID.Size = new Size(93, 23);
            lblOrderID.TabIndex = 2;
            lblOrderID.Text = "ORDER NO";
            // 
            // lblDate
            // 
            lblDate.BackColor = Color.Transparent;
            lblDate.Font = new Font("Arial", 9F, FontStyle.Bold);
            lblDate.ForeColor = Color.White;
            lblDate.Location = new Point(443, 92);
            lblDate.Margin = new Padding(4, 0, 4, 0);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(52, 23);
            lblDate.TabIndex = 4;
            lblDate.Text = "DATE";
            // 
            // lblCustomerID
            // 
            lblCustomerID.BackColor = Color.Transparent;
            lblCustomerID.Font = new Font("Arial", 9F, FontStyle.Bold);
            lblCustomerID.ForeColor = Color.White;
            lblCustomerID.Location = new Point(18, 133);
            lblCustomerID.Margin = new Padding(4, 0, 4, 0);
            lblCustomerID.Name = "lblCustomerID";
            lblCustomerID.Size = new Size(105, 23);
            lblCustomerID.TabIndex = 6;
            lblCustomerID.Text = "CUSTOMER ID";
            // 
            // lblFirstName
            // 
            lblFirstName.BackColor = Color.Transparent;
            lblFirstName.Font = new Font("Arial", 9F, FontStyle.Bold);
            lblFirstName.ForeColor = Color.White;
            lblFirstName.Location = new Point(18, 171);
            lblFirstName.Margin = new Padding(4, 0, 4, 0);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(93, 23);
            lblFirstName.TabIndex = 8;
            lblFirstName.Text = "FIRSTNAME";
            // 
            // lblLastName
            // 
            lblLastName.BackColor = Color.Transparent;
            lblLastName.Font = new Font("Arial", 9F, FontStyle.Bold);
            lblLastName.ForeColor = Color.White;
            lblLastName.Location = new Point(292, 171);
            lblLastName.Margin = new Padding(4, 0, 4, 0);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(93, 23);
            lblLastName.TabIndex = 10;
            lblLastName.Text = "LASTNAME";
            // 
            // lblMI
            // 
            lblMI.BackColor = Color.Transparent;
            lblMI.Font = new Font("Arial", 9F, FontStyle.Bold);
            lblMI.ForeColor = Color.White;
            lblMI.Location = new Point(548, 171);
            lblMI.Margin = new Padding(4, 0, 4, 0);
            lblMI.Name = "lblMI";
            lblMI.Size = new Size(29, 23);
            lblMI.TabIndex = 12;
            lblMI.Text = "MI";
            // 
            // lblStockID
            // 
            lblStockID.BackColor = Color.Transparent;
            lblStockID.Font = new Font("Arial", 9F, FontStyle.Bold);
            lblStockID.ForeColor = Color.White;
            lblStockID.Location = new Point(18, 211);
            lblStockID.Margin = new Padding(4, 0, 4, 0);
            lblStockID.Name = "lblStockID";
            lblStockID.Size = new Size(82, 23);
            lblStockID.TabIndex = 14;
            lblStockID.Text = "STOCK ID";
            // 
            // lblDescription
            // 
            lblDescription.BackColor = Color.Transparent;
            lblDescription.Font = new Font("Arial", 9F, FontStyle.Bold);
            lblDescription.ForeColor = Color.White;
            lblDescription.Location = new Point(204, 211);
            lblDescription.Margin = new Padding(4, 0, 4, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(105, 23);
            lblDescription.TabIndex = 16;
            lblDescription.Text = "DESCRIPTION";
            // 
            // lblPrice
            // 
            lblPrice.BackColor = Color.Transparent;
            lblPrice.Font = new Font("Arial", 9F, FontStyle.Bold);
            lblPrice.ForeColor = Color.White;
            lblPrice.Location = new Point(484, 211);
            lblPrice.Margin = new Padding(4, 0, 4, 0);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(52, 23);
            lblPrice.TabIndex = 18;
            lblPrice.Text = "PRICE";
            // 
            // lblQty
            // 
            lblQty.BackColor = Color.Transparent;
            lblQty.Font = new Font("Arial", 9F, FontStyle.Bold);
            lblQty.ForeColor = Color.White;
            lblQty.Location = new Point(18, 252);
            lblQty.Margin = new Padding(4, 0, 4, 0);
            lblQty.Name = "lblQty";
            lblQty.Size = new Size(41, 23);
            lblQty.TabIndex = 20;
            lblQty.Text = "QTY";
            // 
            // lblTotal
            // 
            lblTotal.BackColor = Color.Transparent;
            lblTotal.Font = new Font("Arial", 9F, FontStyle.Bold);
            lblTotal.ForeColor = Color.White;
            lblTotal.Location = new Point(537, 489);
            lblTotal.Margin = new Padding(4, 0, 4, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(58, 23);
            lblTotal.TabIndex = 26;
            lblTotal.Text = "TOTAL";
            // 
            // txtOrderID - stays readonly (auto-generated)
            // 
            txtOrderID.BackColor = Color.White;
            txtOrderID.Location = new Point(117, 90);
            txtOrderID.Margin = new Padding(4, 3, 4, 3);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.ReadOnly = true;
            txtOrderID.Size = new Size(128, 23);
            txtOrderID.TabIndex = 3;
            // 
            // txtDate - NOW EDITABLE
            // 
            txtDate.BackColor = Color.White;
            txtDate.Location = new Point(502, 90);
            txtDate.Margin = new Padding(4, 3, 4, 3);
            txtDate.Name = "txtDate";
            txtDate.ReadOnly = false;
            txtDate.Size = new Size(139, 23);
            txtDate.TabIndex = 5;
            // 
            // txtCustomerID
            // 
            txtCustomerID.BackColor = Color.White;
            txtCustomerID.Location = new Point(128, 130);
            txtCustomerID.Margin = new Padding(4, 3, 4, 3);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.Size = new Size(81, 23);
            txtCustomerID.TabIndex = 7;
            txtCustomerID.KeyPress += txtCustomerID_KeyPress;
            // 
            // txtFirstName - NOW EDITABLE
            // 
            txtFirstName.BackColor = Color.White;
            txtFirstName.Location = new Point(117, 168);
            txtFirstName.Margin = new Padding(4, 3, 4, 3);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.ReadOnly = false;
            txtFirstName.Size = new Size(128, 23);
            txtFirstName.TabIndex = 9;
            // 
            // txtLastName - NOW EDITABLE
            // 
            txtLastName.BackColor = Color.White;
            txtLastName.Location = new Point(391, 168);
            txtLastName.Margin = new Padding(4, 3, 4, 3);
            txtLastName.Name = "txtLastName";
            txtLastName.ReadOnly = false;
            txtLastName.Size = new Size(128, 23);
            txtLastName.TabIndex = 11;
            // 
            // txtMI - NOW EDITABLE
            // 
            txtMI.BackColor = Color.White;
            txtMI.Location = new Point(581, 168);
            txtMI.Margin = new Padding(4, 3, 4, 3);
            txtMI.Name = "txtMI";
            txtMI.ReadOnly = false;
            txtMI.MaxLength = 1;
            txtMI.Size = new Size(40, 23);
            txtMI.TabIndex = 13;
            // 
            // txtStockID
            // 
            txtStockID.BackColor = Color.White;
            txtStockID.Location = new Point(117, 209);
            txtStockID.Margin = new Padding(4, 3, 4, 3);
            txtStockID.Name = "txtStockID";
            txtStockID.Size = new Size(63, 23);
            txtStockID.TabIndex = 15;
            txtStockID.KeyPress += txtStockID_KeyPress;
            // 
            // txtDescription - stays readonly (auto-filled from DB)
            // 
            txtDescription.BackColor = Color.White;
            txtDescription.Location = new Point(313, 209);
            txtDescription.Margin = new Padding(4, 3, 4, 3);
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = true;
            txtDescription.Size = new Size(151, 23);
            txtDescription.TabIndex = 17;
            // 
            // txtPrice - stays readonly (auto-filled from DB)
            // 
            txtPrice.BackColor = Color.White;
            txtPrice.Location = new Point(537, 209);
            txtPrice.Margin = new Padding(4, 3, 4, 3);
            txtPrice.Name = "txtPrice";
            txtPrice.ReadOnly = true;
            txtPrice.Size = new Size(93, 23);
            txtPrice.TabIndex = 19;
            // 
            // txtQty
            // 
            txtQty.BackColor = Color.White;
            txtQty.Location = new Point(117, 249);
            txtQty.Margin = new Padding(4, 3, 4, 3);
            txtQty.Name = "txtQty";
            txtQty.Size = new Size(63, 23);
            txtQty.TabIndex = 21;
            // 
            // txtTotal
            // 
            txtTotal.BackColor = Color.White;
            txtTotal.Location = new Point(601, 487);
            txtTotal.Margin = new Padding(4, 3, 4, 3);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(128, 23);
            txtTotal.TabIndex = 27;
            txtTotal.Text = "0.00";
            // 
            // btnLoad
            // 
            btnLoad.BackColor = Color.White;
            btnLoad.FlatStyle = FlatStyle.Flat;
            btnLoad.Location = new Point(192, 247);
            btnLoad.Margin = new Padding(4, 3, 4, 3);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(76, 30);
            btnLoad.TabIndex = 22;
            btnLoad.Text = "LOAD";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.White;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Location = new Point(18, 485);
            btnSave.Margin = new Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(88, 32);
            btnSave.TabIndex = 24;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.White;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Location = new Point(117, 485);
            btnClear.Margin = new Padding(4, 3, 4, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(88, 32);
            btnClear.TabIndex = 25;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // dgvOrders
            // 
            dgvOrders.AllowUserToAddRows = false;
            dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrders.BackgroundColor = Color.DeepSkyBlue;
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Columns.AddRange(new DataGridViewColumn[] { colStockID, colDescription, colPrice, colQty, colSales });
            dgvOrders.Location = new Point(18, 294);
            dgvOrders.Margin = new Padding(4, 3, 4, 3);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.ReadOnly = true;
            dgvOrders.Size = new Size(776, 173);
            dgvOrders.TabIndex = 23;
            // 
            // colStockID
            // 
            colStockID.FillWeight = 15F;
            colStockID.HeaderText = "STOCK ID";
            colStockID.Name = "colStockID";
            colStockID.ReadOnly = true;
            // 
            // colDescription
            // 
            colDescription.FillWeight = 35F;
            colDescription.HeaderText = "DESCRIPTION";
            colDescription.Name = "colDescription";
            colDescription.ReadOnly = true;
            // 
            // colPrice
            // 
            colPrice.FillWeight = 15F;
            colPrice.HeaderText = "PRICE";
            colPrice.Name = "colPrice";
            colPrice.ReadOnly = true;
            // 
            // colQty
            // 
            colQty.FillWeight = 15F;
            colQty.HeaderText = "QTY";
            colQty.Name = "colQty";
            colQty.ReadOnly = true;
            // 
            // colSales
            // 
            colSales.FillWeight = 20F;
            colSales.HeaderText = "SALES";
            colSales.Name = "colSales";
            colSales.ReadOnly = true;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(817, 537);
            Controls.Add(menuStrip1);
            Controls.Add(lblTitle);
            Controls.Add(lblOrderID);
            Controls.Add(txtOrderID);
            Controls.Add(lblDate);
            Controls.Add(txtDate);
            Controls.Add(lblCustomerID);
            Controls.Add(txtCustomerID);
            Controls.Add(lblFirstName);
            Controls.Add(txtFirstName);
            Controls.Add(lblLastName);
            Controls.Add(txtLastName);
            Controls.Add(lblMI);
            Controls.Add(txtMI);
            Controls.Add(lblStockID);
            Controls.Add(txtStockID);
            Controls.Add(lblDescription);
            Controls.Add(txtDescription);
            Controls.Add(lblPrice);
            Controls.Add(txtPrice);
            Controls.Add(lblQty);
            Controls.Add(txtQty);
            Controls.Add(btnLoad);
            Controls.Add(dgvOrders);
            Controls.Add(btnSave);
            Controls.Add(btnClear);
            Controls.Add(lblTotal);
            Controls.Add(txtTotal);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TrioFlow - Order Entry Form";
            Load += Form3_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        // ── Declarations ──────────────────────────────────────────────────────
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem orderFormMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerListMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockListMenuItem;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblMI;
        private System.Windows.Forms.Label lblStockID;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtMI;
        private System.Windows.Forms.TextBox txtStockID;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSales;
    }
}