using System;
using System.Windows.Forms;

namespace TrioFlow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            // Check if the user has selected a service
            if (string.IsNullOrWhiteSpace(cmbService.Text))
            {
                MessageBox.Show("Please select a service first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Create Form2 instance
            Form2 f2 = new Form2();

            // Pass the selected service to Form2
            f2.SetService(cmbService.Text);

            // Show Form2 and hide Form1
            f2.Show();
            this.Hide();
        }
        

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmbService_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Optional: do something when selection changes
        }
    }
}
