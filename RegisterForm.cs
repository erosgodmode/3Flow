using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TrioFlow
{
    public partial class RegisterForm : Form
    {
        private const string connStr = "Server=localhost\\SQLEXPRESS;Database=TrioFlowDB;Trusted_Connection=True;TrustServerCertificate=True;";
        private byte[] profileImageBytes = null;

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string fullName = txtFullName.Text.Trim();
            string contact = txtContact.Text.Trim();
            string email = txtEmail.Text.Trim();
            string user = txtUsername.Text.Trim();
            string pass = txtPassword.Text.Trim();
            string confirm = txtConfirm.Text.Trim();

            if (fullName == "" || contact == "" || email == "" || user == "" || pass == "" || confirm == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (pass != confirm)
            {
                MessageBox.Show("Passwords do not match!");
                return;
            }

            using (SqlConnection con = new SqlConnection(connStr))
            {
                con.Open();

                // Check if username already exists
                string check = "SELECT COUNT(*) FROM Users WHERE Username=@u";
                SqlCommand checkCmd = new SqlCommand(check, con);
                checkCmd.Parameters.AddWithValue("@u", user);
                int exists = (int)checkCmd.ExecuteScalar();

                if (exists > 0)
                {
                    MessageBox.Show("Username already taken!");
                    return;
                }

                // Insert new user
                string insert = @"INSERT INTO Users (FullName, ContactNumber, Email, Username, Password, ProfileImage)
                                  VALUES (@fn, @cn, @em, @u, @p, @img)";
                SqlCommand cmd = new SqlCommand(insert, con);
                cmd.Parameters.AddWithValue("@fn", fullName);
                cmd.Parameters.AddWithValue("@cn", contact);
                cmd.Parameters.AddWithValue("@em", email);
                cmd.Parameters.AddWithValue("@u", user);
                cmd.Parameters.AddWithValue("@p", pass);
                SqlParameter imgParam = new SqlParameter("@img", System.Data.SqlDbType.VarBinary);
                imgParam.Value = (object)profileImageBytes ?? DBNull.Value;
                cmd.Parameters.Add(imgParam);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Account created successfully!");
                ClearFields();
                LoadUsers();
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUploadProfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                profileImageBytes = File.ReadAllBytes(ofd.FileName);
                pictureBoxProfile.Image = Image.FromFile(ofd.FileName);
                pictureBoxProfile.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void LoadUsers()
        {
            using (SqlConnection con = new SqlConnection(connStr))
            {
                con.Open();
                string query = "SELECT FullName, ContactNumber, Email, Username FROM Users";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void ClearFields()
        {
            txtFullName.Clear();
            txtContact.Clear();
            txtEmail.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            txtConfirm.Clear();
            pictureBoxProfile.Image = null;
            profileImageBytes = null;
        }
    }
}