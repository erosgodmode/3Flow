namespace TrioFlow
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Label label1;
        private Label label2;
        private ComboBox cmbService;
        private Button btnProceed;
        private Button btnExit;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            cmbService = new ComboBox();
            btnProceed = new Button();
            btnExit = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.Location = new Point(189, 9);
            label1.Name = "label1";
            label1.Size = new Size(156, 30);
            label1.TabIndex = 0;
            label1.Text = "WELCOME TO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label2.Location = new Point(96, 50);
            label2.Name = "label2";
            label2.Size = new Size(338, 30);
            label2.TabIndex = 1;
            label2.Text = "TrioFlow Water Refilling Station";
            // 
            // cmbService
            // 
            cmbService.FormattingEnabled = true;
            cmbService.Items.AddRange(new object[] { "Gallon Refill", "Home Delivery", "New Container" });
            cmbService.Location = new Point(189, 93);
            cmbService.Name = "cmbService";
            cmbService.Size = new Size(156, 23);
            cmbService.TabIndex = 2;
            cmbService.SelectedIndexChanged += cmbService_SelectedIndexChanged;
            // 
            // btnProceed
            // 
            btnProceed.Location = new Point(270, 122);
            btnProceed.Name = "btnProceed";
            btnProceed.Size = new Size(75, 25);
            btnProceed.TabIndex = 3;
            btnProceed.Text = "Proceed";
            btnProceed.UseVisualStyleBackColor = true;
            btnProceed.Click += btnProceed_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(189, 122);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 25);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.bg1;
            pictureBox1.Image = Properties.Resources.bg1;
            pictureBox1.Location = new Point(-113, -269);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(715, 699);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            ClientSize = new Size(544, 361);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(cmbService);
            Controls.Add(btnProceed);
            Controls.Add(btnExit);
            Controls.Add(pictureBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TrioFlow Water Refilling Station";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private PictureBox pictureBox1;
    }
}
