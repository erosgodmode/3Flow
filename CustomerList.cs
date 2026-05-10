using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TrioFlow
{
    public partial class CustomerList : Form
    {
        private const string connStr = "Server=localhost\\SQLEXPRESS;Database=TrioFlowDB;Trusted_Connection=True;TrustServerCertificate=True;";

        // Event fired when user double-clicks a customer row
        // Parameters: CustomerID, FirstName, LastName, MI
        public event Action<int, string, string, string> CustomerSelected;

        public CustomerList()
        {
            InitializeComponent();

            // Enable double-click to select
            dgvCustomers.CellDoubleClick += dgvCustomers_CellDoubleClick;
            dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomers.MultiSelect = false;
        }

        private void CustomerList_Load(object sender, EventArgs e)
        {
            LoadCustomers("");
        }

        private void LoadCustomers(string search)
        {
            using (SqlConnection con = new SqlConnection(connStr))
            {
                con.Open();
                string q;
                SqlDataAdapter da;

                if (string.IsNullOrWhiteSpace(search))
                {
                    q = @"SELECT CustomerID, FirstName, LastName, MI, Address, Email, ContactNo 
                          FROM Customer 
                          ORDER BY CustomerID";
                    da = new SqlDataAdapter(q, con);
                }
                else
                {
                    q = @"SELECT CustomerID, FirstName, LastName, MI, Address, Email, ContactNo
                          FROM Customer
                          WHERE LastName LIKE @s OR FirstName LIKE @s
                          ORDER BY CustomerID";
                    da = new SqlDataAdapter(q, con);
                    da.SelectCommand.Parameters.AddWithValue("@s", "%" + search + "%");
                }

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvCustomers.DataSource = dt;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadCustomers(txtSearch.Text.Trim());
        }

        private void dgvCustomers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvCustomers.Rows[e.RowIndex];
            int custID = Convert.ToInt32(row.Cells["CustomerID"].Value);
            string firstName = row.Cells["FirstName"].Value?.ToString() ?? "";
            string lastName = row.Cells["LastName"].Value?.ToString() ?? "";
            string mi = row.Cells["MI"].Value?.ToString() ?? "";

            // Fire event to notify Form3
            CustomerSelected?.Invoke(custID, firstName, lastName, mi);

            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}