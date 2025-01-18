using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace LMS_cs
{
    public partial class LoginForm : Form
    {
        private SqlConnection conn;
        private string connectionString = "Data Source=192.168.1.84;Initial Catalog=LibraryDB;Persist Security Info=True;User ID=sa;Password=kithEm-2hapto-wakdav;Encrypt=False;Trust Server Certificate=True;";

        public LoginForm()
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString);
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // You can keep this empty or add initialization logic if needed
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM Users WHERE Username = @Username AND Password = @Password";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string role = reader["Role"].ToString();
                            int userId = Convert.ToInt32(reader["Id"]);

                            if (role.Equals("Admin", StringComparison.OrdinalIgnoreCase))
                            {
                                new AdminDashboard(userId).Show();
                            }
                            else
                            {
                                new MemberDashboard(userId).Show();
                            }
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid credentials!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                conn.Close();
            }
        }
    }
}

