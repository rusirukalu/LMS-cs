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
    public partial class AdminDashboard : Form
    {
        private int adminId;
        private SqlConnection conn;

        public AdminDashboard(int userId)
        {
            InitializeComponent();
            adminId = userId;
            conn = new SqlConnection("Data Source=192.168.1.84;Initial Catalog=LibraryDB;Persist Security Info=True;User ID=sa;Password=kithEm-2hapto-wakdav;Encrypt=False;Trust Server Certificate=True;");
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            LoadBorrowRecords(); // Load records when form opens
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            AddBook(txtTitle.Text, txtAuthor.Text, txtISBN.Text,
            Convert.ToInt32(txtCopies.Text));
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            AddMember(txtMemberName.Text, txtEmail.Text, txtPhone.Text);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnLoadRecords_Click(object sender, EventArgs e)
        {
            LoadBorrowRecords();
        }

        private void dgvBorrowRecords_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // Book Management Methods
        private void AddBook(string title, string author, string isbn, int copies)
        {
            try
            {
                conn.Open();
                string query = "INSERT INTO Books (Title, Author, ISBN, AvailableCopies) VALUES (@Title, @Author, @ISBN, @Copies)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Title", title);
                    cmd.Parameters.AddWithValue("@Author", author);
                    cmd.Parameters.AddWithValue("@ISBN", isbn);
                    cmd.Parameters.AddWithValue("@Copies", copies);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book added successfully!");
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

        // Member Management Methods
        private void AddMember(string name, string email, string phone)
        {
            try
            {
                conn.Open();
                string query = "INSERT INTO Members (Name, Email, Phone) VALUES (@Name, @Email, @Phone)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Phone", phone);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Member added successfully!");
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

        // View Borrow Records
        private void LoadBorrowRecords()
        {
            try
            {
                conn.Open();
                string query = @"SELECT b.Title, m.Name, br.BorrowDate, br.ReturnDate, br.Status 
                               FROM BorrowRecords br 
                               JOIN Books b ON br.BookId = b.Id 
                               JOIN Members m ON br.MemberId = m.Id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvBorrowRecords.DataSource = dt;
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
