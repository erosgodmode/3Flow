namespace TrioFlow
{
    partial class Form2
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
            label1 = new System.Windows.Forms.Label();
            lblSelectedService = new System.Windows.Forms.Label();
            lblFirstName = new System.Windows.Forms.Label();
            lblLastName = new System.Windows.Forms.Label();
            lblMI = new System.Windows.Forms.Label();
            lblAddress = new System.Windows.Forms.Label();
            lblEmail = new System.Windows.Forms.Label();
            lblContact = new System.Windows.Forms.Label();
            lblGallons = new System.Windows.Forms.Label();
            txtFirstName = new System.Windows.Forms.TextBox();
            txtLastName = new System.Windows.Forms.TextBox();
            txtMI = new System.Windows.Forms.TextBox();
            txtAddress = new System.Windows.Forms.TextBox();
            txtEmail = new System.Windows.Forms.TextBox();
            txtContact = new System.Windows.Forms.TextBox();
            txtGallons = new System.Windows.Forms.TextBox();
            btnPlaceOrder = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();

            // label1 - Title
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            label1.Location = new System.Drawing.Point(100, 10);
            label1.Name = "label1";
            label1.Text = "Customer Information";
            label1.BackColor = System.Drawing.Color.Transparent;

            // lblSelectedService
            lblSelectedService.AutoSize = true;
            lblSelectedService.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lblSelectedService.Location = new System.Drawing.Point(30, 50);
            lblSelectedService.Name = "lblSelectedService";
            lblSelectedService.Text = "Selected Service:";
            lblSelectedService.BackColor = System.Drawing.Color.Transparent;

            // lblFirstName
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new System.Drawing.Point(30, 90);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Text = "First Name:";
            lblFirstName.BackColor = System.Drawing.Color.Transparent;
            lblFirstName.ForeColor = System.Drawing.Color.Black;
            lblFirstName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);

            // txtFirstName
            txtFirstName.Location = new System.Drawing.Point(130, 87);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new System.Drawing.Size(150, 23);

            // lblLastName
            lblLastName.AutoSize = true;
            lblLastName.Location = new System.Drawing.Point(30, 125);
            lblLastName.Name = "lblLastName";
            lblLastName.Text = "Last Name:";
            lblLastName.BackColor = System.Drawing.Color.Transparent;
            lblLastName.ForeColor = System.Drawing.Color.Black;
            lblLastName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);

            // txtLastName
            txtLastName.Location = new System.Drawing.Point(130, 122);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new System.Drawing.Size(150, 23);

            // lblMI
            lblMI.AutoSize = true;
            lblMI.Location = new System.Drawing.Point(295, 125);
            lblMI.Name = "lblMI";
            lblMI.Text = "M.I.:";
            lblMI.BackColor = System.Drawing.Color.Transparent;
            lblMI.ForeColor = System.Drawing.Color.Black;
            lblMI.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);

            // txtMI
            txtMI.Location = new System.Drawing.Point(330, 122);
            txtMI.Name = "txtMI";
            txtMI.Size = new System.Drawing.Size(40, 23);
            txtMI.MaxLength = 1;

            // lblAddress
            lblAddress.AutoSize = true;
            lblAddress.Location = new System.Drawing.Point(30, 160);
            lblAddress.Name = "lblAddress";
            lblAddress.Text = "Address:";
            lblAddress.BackColor = System.Drawing.Color.Transparent;
            lblAddress.ForeColor = System.Drawing.Color.Black;
            lblAddress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);

            // txtAddress
            txtAddress.Location = new System.Drawing.Point(130, 157);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new System.Drawing.Size(240, 23);

            // lblEmail
            lblEmail.AutoSize = true;
            lblEmail.Location = new System.Drawing.Point(30, 195);
            lblEmail.Name = "lblEmail";
            lblEmail.Text = "Email:";
            lblEmail.BackColor = System.Drawing.Color.Transparent;
            lblEmail.ForeColor = System.Drawing.Color.Black;
            lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);

            // txtEmail
            txtEmail.Location = new System.Drawing.Point(130, 192);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(240, 23);

            // lblContact
            lblContact.AutoSize = true;
            lblContact.Location = new System.Drawing.Point(30, 230);
            lblContact.Name = "lblContact";
            lblContact.Text = "Contact #:";
            lblContact.BackColor = System.Drawing.Color.Transparent;
            lblContact.ForeColor = System.Drawing.Color.Black;
            lblContact.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);

            // txtContact
            txtContact.Location = new System.Drawing.Point(130, 227);
            txtContact.Name = "txtContact";
            txtContact.Size = new System.Drawing.Size(240, 23);

            // lblGallons
            lblGallons.AutoSize = true;
            lblGallons.Location = new System.Drawing.Point(30, 265);
            lblGallons.Name = "lblGallons";
            lblGallons.Text = "Gallons:";
            lblGallons.BackColor = System.Drawing.Color.Transparent;
            lblGallons.ForeColor = System.Drawing.Color.Black;
            lblGallons.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);

            // txtGallons
            txtGallons.Location = new System.Drawing.Point(130, 262);
            txtGallons.Name = "txtGallons";
            txtGallons.Size = new System.Drawing.Size(100, 23);

            // btnPlaceOrder
            btnPlaceOrder.Location = new System.Drawing.Point(130, 305);
            btnPlaceOrder.Name = "btnPlaceOrder";
            btnPlaceOrder.Size = new System.Drawing.Size(110, 30);
            btnPlaceOrder.Text = "Place Order";
            btnPlaceOrder.BackColor = System.Drawing.Color.White;
            btnPlaceOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);

            // btnCancel
            btnCancel.Location = new System.Drawing.Point(255, 305);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(110, 30);
            btnCancel.Text = "Cancel";
            btnCancel.BackColor = System.Drawing.Color.White;
            btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // pictureBox1 - background
            pictureBox1.BackgroundImage = Properties.Resources.bg1;
            pictureBox1.Image = Properties.Resources.bg1;
            pictureBox1.Location = new System.Drawing.Point(-123, -245);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(700, 750);
            pictureBox1.TabStop = false;

            // Form2
            ClientSize = new System.Drawing.Size(450, 360);
            Controls.Add(label1);
            Controls.Add(lblSelectedService);
            Controls.Add(lblFirstName);
            Controls.Add(txtFirstName);
            Controls.Add(lblLastName);
            Controls.Add(txtLastName);
            Controls.Add(lblMI);
            Controls.Add(txtMI);
            Controls.Add(lblAddress);
            Controls.Add(txtAddress);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblContact);
            Controls.Add(txtContact);
            Controls.Add(lblGallons);
            Controls.Add(txtGallons);
            Controls.Add(btnPlaceOrder);
            Controls.Add(btnCancel);
            Controls.Add(pictureBox1);
            Name = "Form2";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "TrioFlow Customer Form";
            Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSelectedService;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblMI;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblGallons;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtMI;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtGallons;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}