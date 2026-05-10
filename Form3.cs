using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TrioFlow
{
    public partial class Form3 : Form
    {
        private const string connStr = "Server=localhost\\SQLEXPRESS;Database=TrioFlowDB;Trusted_Connection=True;TrustServerCertificate=True;";
        private decimal runningTotal = 0;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            txtDate.Text = DateTime.Now.ToString("MM/dd/yyyy");
            dgvOrders.AllowUserToAddRows = false;

            // Set up grid columns
            dgvOrders.Columns.Clear();
            dgvOrders.Columns.Add("colStockID", "STOCK ID");
            dgvOrders.Columns.Add("colDescription", "DESCRIPTION");
            dgvOrders.Columns.Add("colPrice", "PRICE");
            dgvOrders.Columns.Add("colQty", "QTY");
            dgvOrders.Columns.Add("colSales", "SALES");

            // Wire up menu items
            orderFormMenuItem.Click += (s, ev) => { };
            customerListMenuItem.Click += customerListMenuItem_Click;
            stockListMenuItem.Click += stockListMenuItem_Click;

            // Add REPORTS menu item
            ToolStripMenuItem reportsMenuItem = new ToolStripMenuItem("REPORTS");
            reportsMenuItem.ForeColor = System.Drawing.Color.White;
            reportsMenuItem.Click += reportsMenuItem_Click;
            menuStrip1.Items.Add(reportsMenuItem);

            // Auto-load customer when leaving CustomerID field
            txtCustomerID.Leave += (s, ev) =>
            {
                if (txtCustomerID.Text.Trim() != "")
                    LoadCustomer();
            };

            // Auto-load stock + price when leaving StockID field
            txtStockID.Leave += (s, ev) =>
            {
                if (txtStockID.Text.Trim() != "")
                    LoadStock();
            };
        }

        // ── CUSTOMER LIST menu ────────────────────────────────────────────────
        private void customerListMenuItem_Click(object sender, EventArgs e)
        {
            CustomerList cl = new CustomerList();
            cl.CustomerSelected += (custID, firstName, lastName, mi) =>
            {
                txtCustomerID.Text = custID.ToString();
                txtFirstName.Text = firstName;
                txtLastName.Text = lastName;
                txtMI.Text = mi;
            };
            cl.ShowDialog();
        }

        // ── STOCK LIST menu ───────────────────────────────────────────────────
        private void stockListMenuItem_Click(object sender, EventArgs e)
        {
            StockList sl = new StockList();
            sl.ShowDialog();

            if (sl.StockSelected)
            {
                txtStockID.Text = sl.SelectedStockID.ToString();
                txtDescription.Text = sl.SelectedDescription;
                txtPrice.Text = sl.SelectedPrice.ToString("0.00");
            }
        }

        // ── REPORTS menu ──────────────────────────────────────────────────────
        private void reportsMenuItem_Click(object sender, EventArgs e)
        {
            string orderNo = txtOrderID.Text.Trim();
            CustomerBillForm bill = new CustomerBillForm(orderNo);
            bill.ShowDialog();
        }

        // ── Load customer by pressing Enter ───────────────────────────────────
        private void txtCustomerID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                LoadCustomer();
        }

        // ── Load stock by pressing Enter ──────────────────────────────────────
        private void txtStockID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                LoadStock();
        }

        private void LoadCustomer()
        {
            if (txtCustomerID.Text.Trim() == "") return;

            using (SqlConnection con = new SqlConnection(connStr))
            {
                con.Open();
                string q = "SELECT LastName, FirstName, MI FROM Customer WHERE CustomerID = @id";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.Parameters.AddWithValue("@id", txtCustomerID.Text.Trim());
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    txtLastName.Text = dr["LastName"].ToString();
                    txtFirstName.Text = dr["FirstName"].ToString();
                    txtMI.Text = dr["MI"] == DBNull.Value ? "" : dr["MI"].ToString();
                }
                else
                {
                    MessageBox.Show("Customer not found!", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtLastName.Text = "";
                    txtFirstName.Text = "";
                    txtMI.Text = "";
                }
            }
        }

        private void LoadStock()
        {
            if (txtStockID.Text.Trim() == "") return;

            using (SqlConnection con = new SqlConnection(connStr))
            {
                con.Open();
                string q = "SELECT Description, Price FROM Stock WHERE StockID = @id";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.Parameters.AddWithValue("@id", txtStockID.Text.Trim());
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    txtDescription.Text = dr["Description"].ToString();
                    txtPrice.Text = Convert.ToDecimal(dr["Price"]).ToString("0.00");
                }
                else
                {
                    MessageBox.Show("Stock not found!", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDescription.Text = "";
                    txtPrice.Text = "";
                }
            }
        }

        // ── LOAD button ───────────────────────────────────────────────────────
        private void btnLoad_Click(object sender, EventArgs e)
        {
            // Load customer if ID is filled
            if (txtCustomerID.Text.Trim() != "")
                LoadCustomer();

            // Validate Stock ID
            if (txtStockID.Text.Trim() == "")
            {
                MessageBox.Show("Please enter a Stock ID first!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Always reload stock to ensure price is fresh
            LoadStock();

            // Validate stock loaded
            if (txtDescription.Text.Trim() == "" || txtPrice.Text.Trim() == "")
            {
                MessageBox.Show("Stock ID not found! Please enter a valid Stock ID.",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate Qty
            if (txtQty.Text.Trim() == "")
            {
                MessageBox.Show("Please enter Qty!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtQty.Text.Trim(), out int qty) || qty <= 0)
            {
                MessageBox.Show("Please enter a valid Qty!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal price = Convert.ToDecimal(txtPrice.Text.Trim());
            decimal sales = price * qty;

            // Add to grid
            dgvOrders.Rows.Add(
                txtStockID.Text.Trim(),
                txtDescription.Text.Trim(),
                price.ToString("0.00"),
                qty,
                sales.ToString("0.00")
            );

            // Update running total
            runningTotal += sales;
            txtTotal.Text = runningTotal.ToString("0.00");

            // Clear stock fields for next entry
            txtStockID.Text = "";
            txtDescription.Text = "";
            txtPrice.Text = "";
            txtQty.Text = "";
            txtStockID.Focus();
        }

        // ── SAVE button ───────────────────────────────────────────────────────
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCustomerID.Text.Trim() == "")
            {
                MessageBox.Show("Please enter a Customer ID!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvOrders.Rows.Count == 0)
            {
                MessageBox.Show("No items to save! Please load items first.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection con = new SqlConnection(connStr))
            {
                con.Open();
                SqlTransaction trans = con.BeginTransaction();

                try
                {
                    // Insert Order_Master
                    string insertMaster = @"INSERT INTO Order_Master (OrderDate, CustomerID)
                                            VALUES (@date, @cid);
                                            SELECT SCOPE_IDENTITY();";
                    SqlCommand cmdMaster = new SqlCommand(insertMaster, con, trans);
                    cmdMaster.Parameters.AddWithValue("@date", DateTime.Now.Date);
                    cmdMaster.Parameters.AddWithValue("@cid", txtCustomerID.Text.Trim());
                    int newOrderID = Convert.ToInt32(cmdMaster.ExecuteScalar());
                    txtOrderID.Text = newOrderID.ToString();

                    // Insert Order_Details for each row
                    foreach (DataGridViewRow row in dgvOrders.Rows)
                    {
                        string insertDetail = @"INSERT INTO Order_Details (OrderID, StockID, Qty)
                                                VALUES (@oid, @sid, @qty)";
                        SqlCommand cmdDetail = new SqlCommand(insertDetail, con, trans);
                        cmdDetail.Parameters.AddWithValue("@oid", newOrderID);
                        cmdDetail.Parameters.AddWithValue("@sid", row.Cells[0].Value);
                        cmdDetail.Parameters.AddWithValue("@qty", row.Cells[3].Value);
                        cmdDetail.ExecuteNonQuery();
                    }

                    trans.Commit();

                    MessageBox.Show("Record is saved!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    MessageBox.Show("Error saving order: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ── CLEAR button ──────────────────────────────────────────────────────
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtOrderID.Text = "";
            txtDate.Text = DateTime.Now.ToString("MM/dd/yyyy");
            txtCustomerID.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtMI.Text = "";
            txtStockID.Text = "";
            txtDescription.Text = "";
            txtPrice.Text = "";
            txtQty.Text = "";
            txtTotal.Text = "0.00";
            dgvOrders.Rows.Clear();
            runningTotal = 0;
        }
    }
}