namespace TrioFlow
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;

        private Label label1;       // Title
        private Label lblName;      // Name label
        private Label lblAddress;   // Address label
        private Label lblGallons;   // Gallons label
        private Label lblService;   // Selected service label
        private Label lblResult;    // Order summary

        private TextBox txtName;    // Name input
        private TextBox txtAddress; // Address input
        private TextBox txtGallons; // Gallons input
        private Button btnOrder;    // Place Order button

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            label1 = new Label();
            lblName = new Label();
            lblAddress = new Label();
            lblGallons = new Label();
            lblService = new Label();
            lblResult = new Label();
            txtName = new TextBox();
            txtAddress = new TextBox();
            txtGallons = new TextBox();
            btnOrder = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.Location = new Point(130, 10);
            label1.Name = "label1";
            label1.Size = new Size(242, 30);
            label1.TabIndex = 0;
            label1.Text = "Customer Information";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(50, 90);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 2;
            lblName.Text = "Name";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(50, 125);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(49, 15);
            lblAddress.TabIndex = 4;
            lblAddress.Text = "Address";
            // 
            // lblGallons
            // 
            lblGallons.AutoSize = true;
            lblGallons.Location = new Point(50, 160);
            lblGallons.Name = "lblGallons";
            lblGallons.Size = new Size(46, 15);
            lblGallons.TabIndex = 6;
            lblGallons.Text = "Gallons";
            // 
            // lblService
            // 
            lblService.AutoSize = true;
            lblService.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblService.Location = new Point(50, 50);
            lblService.Name = "lblService";
            lblService.Size = new Size(124, 19);
            lblService.TabIndex = 1;
            lblService.Text = "Selected Service:";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(50, 230);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 15);
            lblResult.TabIndex = 9;
            // 
            // txtName
            // 
            txtName.Location = new Point(150, 85);
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 23);
            txtName.TabIndex = 3;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(150, 120);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(200, 23);
            txtAddress.TabIndex = 5;
            // 
            // txtGallons
            // 
            txtGallons.Location = new Point(150, 155);
            txtGallons.Name = "txtGallons";
            txtGallons.Size = new Size(200, 23);
            txtGallons.TabIndex = 7;
            // 
            // btnOrder
            // 
            btnOrder.Location = new Point(150, 190);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(100, 25);
            btnOrder.TabIndex = 8;
            btnOrder.Text = "Place Order";
            btnOrder.Click += btnOrder_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.bg1;
            pictureBox1.Image = Properties.Resources.bg1;
            pictureBox1.Location = new Point(-123, -245);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(583, 688);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            ClientSize = new Size(450, 400);
            Controls.Add(label1);
            Controls.Add(lblService);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(lblAddress);
            Controls.Add(txtAddress);
            Controls.Add(lblGallons);
            Controls.Add(txtGallons);
            Controls.Add(btnOrder);
            Controls.Add(lblResult);
            Controls.Add(pictureBox1);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TrioFlow Customer Form";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private PictureBox pictureBox1;
    }
}
