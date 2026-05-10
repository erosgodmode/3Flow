using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TrioFlow
{
    public partial class CustomerBillForm : Form
    {
        private const string connStr = "Server=localhost\\SQLEXPRESS;Database=TrioFlowDB;Trusted_Connection=True;TrustServerCertificate=True;";

        // Optional: pass order number directly when opening from Form3
        public CustomerBillForm(string orderNo = "")
        {
            InitializeComponent();
            if (!string.IsNullOrEmpty(orderNo))
            {
                txtOrderNo.Text = orderNo;
            }
        }

        private void btnGenerateBill_Click(object sender, EventArgs e)
        {
            string orderNo = txtOrderNo.Text.Trim();
            if (orderNo == "")
            {
                MessageBox.Show("Please enter an Order Number!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(orderNo, out int orderID))
            {
                MessageBox.Show("Invalid Order Number!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection con = new SqlConnection(connStr))
            {
                con.Open();

                // Get customer info from Order_Master + Customer
                string qCustomer = @"
                    SELECT c.CustomerID, c.FirstName, c.LastName
                    FROM Order_Master om
                    INNER JOIN Customer c ON om.CustomerID = c.CustomerID
                    WHERE om.OrderID = @oid";
                SqlCommand cmdCust = new SqlCommand(qCustomer, con);
                cmdCust.Parameters.AddWithValue("@oid", orderID);
                SqlDataReader dr = cmdCust.ExecuteReader();

                if (!dr.Read())
                {
                    MessageBox.Show("Order Number not found!", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dr.Close();
                    return;
                }

                txtCustomerID.Text = dr["CustomerID"].ToString();
                txtFirstName.Text = dr["FirstName"].ToString();
                txtLastName.Text = dr["LastName"].ToString();
                txtMI.Text = ""; // MI not stored in DB
                dr.Close();

                // Get order details: StockID, Description, Price, Qty, Total per line
                string qDetails = @"
                    SELECT od.StockID, s.Description, s.Price, od.Qty,
                           (s.Price * od.Qty) AS Total
                    FROM Order_Details od
                    INNER JOIN Stock s ON od.StockID = s.StockID
                    WHERE od.OrderID = @oid";
                SqlDataAdapter da = new SqlDataAdapter(qDetails, con);
                da.SelectCommand.Parameters.AddWithValue("@oid", orderID);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvBill.DataSource = dt;

                // Rename columns for display
                if (dgvBill.Columns.Contains("StockID"))
                    dgvBill.Columns["StockID"].HeaderText = "STOCKID";
                if (dgvBill.Columns.Contains("Description"))
                    dgvBill.Columns["Description"].HeaderText = "DESCRIPTION";
                if (dgvBill.Columns.Contains("Price"))
                    dgvBill.Columns["Price"].HeaderText = "PRICE";
                if (dgvBill.Columns.Contains("Qty"))
                    dgvBill.Columns["Qty"].HeaderText = "QTY";
                if (dgvBill.Columns.Contains("Total"))
                    dgvBill.Columns["Total"].HeaderText = "TOTAL";

                // Calculate total bill
                decimal totalBill = 0;
                foreach (DataRow row in dt.Rows)
                    totalBill += Convert.ToDecimal(row["Total"]);

                txtTotalBill.Text = totalBill.ToString("N0");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMI_TextChanged(object sender, EventArgs e)
        {

        }
    }
}