using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TrioFlow
{
    public partial class Form2 : Form
    {
        private const string connStr = "Server=localhost\\SQLEXPRESS;Database=TrioFlowDB;Trusted_Connection=True;TrustServerCertificate=True;";

        private int selectedStockID = 0;
        private decimal stockPrice = 0;
        private string selectedService = "";

        public Form2(string service, int stockID, decimal price)
        {
            InitializeComponent();
            selectedService = service;
            selectedStockID = stockID;
            stockPrice = price;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblSelectedService.Text = "Selected Service: " + selectedService;
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string mi = txtMI.Text.Trim();
            string address = txtAddress.Text.Trim();
            string email = txtEmail.Text.Trim();
            string contact = txtContact.Text.Trim();
            string gallons = txtGallons.Text.Trim();

            if (firstName == "" || lastName == "" || address == "" || gallons == "")
            {
                MessageBox.Show("Please fill in First Name, Last Name, Address, and Gallons!",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(gallons, out int qty) || qty <= 0)
            {
                MessageBox.Show("Please enter a valid number of gallons!",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal total = stockPrice * qty;

            using (SqlConnection con = new SqlConnection(connStr))
            {
                con.Open();

                string insertCustomer = @"
                    INSERT INTO Customer (LastName, FirstName, MI, Address, Email, ContactNo)
                    VALUES (@ln, @fn, @mi, @addr, @email, @contact);
                    SELECT SCOPE_IDENTITY();";

                SqlCommand cmdCust = new SqlCommand(insertCustomer, con);
                cmdCust.Parameters.AddWithValue("@ln", lastName);
                cmdCust.Parameters.AddWithValue("@fn", firstName);
                cmdCust.Parameters.AddWithValue("@mi", mi == "" ? (object)DBNull.Value : mi);
                cmdCust.Parameters.AddWithValue("@addr", address);
                cmdCust.Parameters.AddWithValue("@email", email == "" ? (object)DBNull.Value : email);
                cmdCust.Parameters.AddWithValue("@contact", contact == "" ? (object)DBNull.Value : contact);
                int customerID = Convert.ToInt32(cmdCust.ExecuteScalar());

                string insertMaster = @"
                    INSERT INTO Order_Master (OrderDate, CustomerID)
                    VALUES (@date, @cid);
                    SELECT SCOPE_IDENTITY();";

                SqlCommand cmdMaster = new SqlCommand(insertMaster, con);
                cmdMaster.Parameters.AddWithValue("@date", DateTime.Now.Date);
                cmdMaster.Parameters.AddWithValue("@cid", customerID);
                int orderID = Convert.ToInt32(cmdMaster.ExecuteScalar());

                string insertDetail = @"
                    INSERT INTO Order_Details (OrderID, StockID, Qty)
                    VALUES (@oid, @sid, @qty)";

                SqlCommand cmdDetail = new SqlCommand(insertDetail, con);
                cmdDetail.Parameters.AddWithValue("@oid", orderID);
                cmdDetail.Parameters.AddWithValue("@sid", selectedStockID);
                cmdDetail.Parameters.AddWithValue("@qty", qty);

                try
                {
                    cmdDetail.ExecuteNonQuery();

                    MessageBox.Show(
                        "☑ Order SAVED to Database!\n\n" +
                        "Service: " + selectedService + "\n" +
                        "Name: " + firstName + " " + lastName + "\n" +
                        "Address: " + address + "\n" +
                        "Gallons: " + qty + "\n" +
                        "Total Price: ₱" + total.ToString("N0"),
                        "Success!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    Form3 f3 = new Form3();
                    f3.Show();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error placing order: " + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}