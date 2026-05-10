namespace TrioFlow
{
    partial class RegisterForm
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
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtConfirm = new TextBox();
            btnRegister = new Button();
            btnCancel = new Button();
            lblTitle = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            lblConfirm = new Label();
            pictureBox1 = new PictureBox();
            lblFullName = new Label();
            lblEmail = new Label();
            lblContact = new Label();
            txtFullName = new TextBox();
            txtEmail = new TextBox();
            txtContact = new TextBox();
            btnView = new Button();
            pictureBoxProfile = new PictureBox();
            dataGridView1 = new DataGridView();
            btnUploadProfile = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfile).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(121, 175);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(166, 23);
            txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(121, 208);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(166, 23);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtConfirm
            // 
            txtConfirm.Location = new Point(121, 240);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.PasswordChar = '*';
            txtConfirm.Size = new Size(166, 23);
            txtConfirm.TabIndex = 6;
            txtConfirm.UseSystemPasswordChar = true;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(116, 277);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(90, 30);
            btnRegister.TabIndex = 7;
            btnRegister.Text = "Register";
            btnRegister.Click += btnRegister_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(331, 277);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(90, 30);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.Click += btnCancel_Click;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(116, 21);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(330, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "TrioFlow Water Refilling Station";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUsername
            // 
            lblUsername.Location = new Point(35, 175);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(80, 23);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            lblPassword.Location = new Point(35, 208);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(80, 23);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password:";
            // 
            // lblConfirm
            // 
            lblConfirm.Location = new Point(35, 240);
            lblConfirm.Name = "lblConfirm";
            lblConfirm.Size = new Size(80, 34);
            lblConfirm.TabIndex = 5;
            lblConfirm.Text = "Confirm \r\nPassword:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.bg1;
            pictureBox1.Image = Properties.Resources.bg1;
            pictureBox1.Location = new Point(-117, -261);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(745, 808);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lblFullName
            // 
            lblFullName.Location = new Point(35, 74);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(80, 23);
            lblFullName.TabIndex = 10;
            lblFullName.Text = "FullName:";
            // 
            // lblEmail
            // 
            lblEmail.Location = new Point(35, 143);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(80, 23);
            lblEmail.TabIndex = 11;
            lblEmail.Text = "Email:";
            // 
            // lblContact
            // 
            lblContact.Location = new Point(35, 109);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(80, 23);
            lblContact.TabIndex = 12;
            lblContact.Text = "Contact #:";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(121, 74);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(166, 23);
            txtFullName.TabIndex = 13;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(121, 143);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(166, 23);
            txtEmail.TabIndex = 14;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(121, 109);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(166, 23);
            txtContact.TabIndex = 15;
            // 
            // btnView
            // 
            btnView.Location = new Point(224, 277);
            btnView.Name = "btnView";
            btnView.Size = new Size(90, 30);
            btnView.TabIndex = 16;
            btnView.Text = "View";
            btnView.Click += btnView_Click;
            // 
            // pictureBoxProfile
            // 
            pictureBoxProfile.BackColor = Color.White;
            pictureBoxProfile.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxProfile.Location = new Point(396, 74);
            pictureBoxProfile.Name = "pictureBoxProfile";
            pictureBoxProfile.Size = new Size(92, 73);
            pictureBoxProfile.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxProfile.TabIndex = 17;
            pictureBoxProfile.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-2, 313);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(567, 150);
            dataGridView1.TabIndex = 18;
            // 
            // btnUploadProfile
            // 
            btnUploadProfile.Location = new Point(396, 153);
            btnUploadProfile.Name = "btnUploadProfile";
            btnUploadProfile.Size = new Size(92, 23);
            btnUploadProfile.TabIndex = 19;
            btnUploadProfile.Text = "Upload Profile";
            btnUploadProfile.Click += btnUploadProfile_Click;
            // 
            // RegisterForm
            // 
            ClientSize = new Size(564, 461);
            Controls.Add(btnUploadProfile);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBoxProfile);
            Controls.Add(btnView);
            Controls.Add(txtContact);
            Controls.Add(txtEmail);
            Controls.Add(txtFullName);
            Controls.Add(lblContact);
            Controls.Add(lblEmail);
            Controls.Add(lblFullName);
            Controls.Add(lblTitle);
            Controls.Add(lblUsername);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(lblConfirm);
            Controls.Add(txtConfirm);
            Controls.Add(btnRegister);
            Controls.Add(btnCancel);
            Controls.Add(pictureBox1);
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TrioFlow - Register";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfile).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUploadProfile;
    }
}