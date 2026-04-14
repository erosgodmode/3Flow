using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TrioFlow
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        // Set the selected service from Form1
        public void SetService(string service)
        {
            lblService.Text = "Selected Service: " + service;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string address = txtAddress.Text;
            string gallonsText = txtGallons.Text;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(address) ||
                !int.TryParse(gallonsText, out int gallons) || gallons <= 0)
            {
                MessageBox.Show("Please enter valid Name, Address, and Gallons (>0).", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string service = lblService.Text.Replace("Selected Service: ", "").Trim();
            int pricePerGallon = 30; // ₱30 per gallon
            int total = gallons * pricePerGallon;

            // SAVE TO DATABASE
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=TrioFlowDB;Trusted_Connection=True;TrustServerCertificate=True;";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = @"INSERT INTO Orders (CustomerName, Address, Service, Gallons, TotalPrice) 
                                   VALUES (@name, @address, @service, @gallons, @total)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@address", address);
                        cmd.Parameters.AddWithValue("@service", service);
                        cmd.Parameters.AddWithValue("@gallons", gallons);
                        cmd.Parameters.AddWithValue("@total", total);

                        int rowsAffected = cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show($"✅ Order SAVED to Database!\n\n" +
                                  $"Service: {service}\n" +
                                  $"Name: {name}\n" +
                                  $"Address: {address}\n" +
                                  $"Gallons: {gallons}\n" +
                                  $"Total Price: ₱{total}", "Success!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"❌ Database Error: {ex.Message}", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
