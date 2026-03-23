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
            this.label1 = new Label();
            this.lblName = new Label();
            this.lblAddress = new Label();
            this.lblGallons = new Label();
            this.lblService = new Label();
            this.lblResult = new Label();
            this.txtName = new TextBox();
            this.txtAddress = new TextBox();
            this.txtGallons = new TextBox();
            this.btnOrder = new Button();
            this.SuspendLayout();

            // label1 - Title
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(130, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 30);
            this.label1.Text = "Customer Information";

            // lblService
            this.lblService.AutoSize = true;
            this.lblService.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblService.Location = new System.Drawing.Point(50, 50);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(150, 20);
            this.lblService.Text = "Selected Service:";

            // lblName
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(50, 90);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 15);
            this.lblName.Text = "Name";

            // txtName
            this.txtName.Location = new System.Drawing.Point(150, 85);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 23);

            // lblAddress
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(50, 125);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(50, 15);
            this.lblAddress.Text = "Address";

            // txtAddress
            this.txtAddress.Location = new System.Drawing.Point(150, 120);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(200, 23);

            // lblGallons
            this.lblGallons.AutoSize = true;
            this.lblGallons.Location = new System.Drawing.Point(50, 160);
            this.lblGallons.Name = "lblGallons";
            this.lblGallons.Size = new System.Drawing.Size(46, 15);
            this.lblGallons.Text = "Gallons";

            // txtGallons
            this.txtGallons.Location = new System.Drawing.Point(150, 155);
            this.txtGallons.Name = "txtGallons";
            this.txtGallons.Size = new System.Drawing.Size(200, 23);

            // btnOrder
            this.btnOrder.Location = new System.Drawing.Point(150, 190);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(100, 25);
            this.btnOrder.Text = "Place Order";
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);

            // lblResult
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(50, 230);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 15);

            // Form2
            this.ClientSize = new System.Drawing.Size(450, 400);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblService);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblGallons);
            this.Controls.Add(this.txtGallons);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.lblResult);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrioFlow Customer Form";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
