using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TrioFlow
{
    public partial class StockList : Form
    {
        private const string connStr = "Server=localhost\\SQLEXPRESS;Database=TrioFlowDB;Trusted_Connection=True;TrustServerCertificate=True;";

        // These will be set when user double-clicks a stock row
        public int SelectedStockID { get; private set; }
        public string SelectedDescription { get; private set; }
        public decimal SelectedPrice { get; private set; }
        public bool StockSelected { get; private set; } = false;

        public StockList()
        {
            InitializeComponent();
        }

        private void StockList_Load(object sender, EventArgs e)
        {
            // Don't auto-load; user clicks VIEW LIST first
        }

        private void btnViewList_Click(object sender, EventArgs e)
        {
            LoadStock("");
        }

        private void LoadStock(string search)
        {
            using (SqlConnection con = new SqlConnection(connStr))
            {
                con.Open();
                string q;
                SqlDataAdapter da;

                if (string.IsNullOrWhiteSpace(search))
                {
                    q = "SELECT StockID, Description, Price FROM Stock ORDER BY StockID";
                    da = new SqlDataAdapter(q, con);
                }
                else
                {
                    q = @"SELECT StockID, Description, Price FROM Stock
                          WHERE CAST(StockID AS VARCHAR) LIKE @s OR Description LIKE @s
                          ORDER BY StockID";
                    da = new SqlDataAdapter(q, con);
                    da.SelectCommand.Parameters.AddWithValue("@s", "%" + search + "%");
                }

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvStock.DataSource = dt;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadStock(txtSearch.Text.Trim());
        }

        private void dgvStock_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvStock.Rows[e.RowIndex];
            SelectedStockID = Convert.ToInt32(row.Cells["StockID"].Value);
            SelectedDescription = row.Cells["Description"].Value.ToString();
            SelectedPrice = Convert.ToDecimal(row.Cells["Price"].Value);
            StockSelected = true;

            this.Close(); // Return to Form3
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}