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
    public partial class MemberDashboard : Form
    {
        private int memberId;
        private SqlConnection conn;

        public MemberDashboard(int userId)
        {
            InitializeComponent();
            memberId = userId;
            conn = new SqlConnection("Data Source=192.168.1.84;Initial Catalog=LibraryDB;Persist Security Info=True;User ID=sa;Password=kithEm-2hapto-wakdav;Encrypt=False;");
        }

        private void MemberDashboard_Load(object sender, EventArgs e)
        {
            LoadAvailableBooks(); // Load books when form opens
        }

        private void btnViewBooks_Click(object sender, EventArgs e)
        {
            LoadAvailableBooks();
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBookId.Text, out int bookId))
            {
                BorrowBook(bookId);
                LoadAvailableBooks(); // Refresh the list
            }
            else
            {
                MessageBox.Show("Please enter a valid Book ID");
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBorrowRecordId.Text, out int recordId))
            {
                ReturnBook(recordId);
                LoadAvailableBooks(); // Refresh the list
            }
            else
            {
                MessageBox.Show("Please enter a valid Borrow Record ID");
            }
        }

        // View Available Books
        private void LoadAvailableBooks()
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM Books WHERE AvailableCopies > 0";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvAvailableBooks.DataSource = dt;
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

        // Borrow Book
        private void BorrowBook(int bookId)
        {
            try
            {
                conn.Open();
                string query = @"INSERT INTO BorrowRecords (MemberId, BookId, BorrowDate, Status) 
                               VALUES (@MemberId, @BookId, @BorrowDate, 'Borrowed');
                               UPDATE Books SET AvailableCopies = AvailableCopies - 1 
                               WHERE Id = @BookId";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MemberId", memberId);
                    cmd.Parameters.AddWithValue("@BookId", bookId);
                    cmd.Parameters.AddWithValue("@BorrowDate", DateTime.Now);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book borrowed successfully!");
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

        // Return Book
        private void ReturnBook(int borrowRecordId)
        {
            try
            {
                conn.Open();
                string query = @"UPDATE BorrowRecords 
                               SET ReturnDate = @ReturnDate, Status = 'Returned' 
                               WHERE Id = @BorrowRecordId;
                               UPDATE Books SET AvailableCopies = AvailableCopies + 1 
                               WHERE Id = (SELECT BookId FROM BorrowRecords WHERE Id = @BorrowRecordId)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ReturnDate", DateTime.Now);
                    cmd.Parameters.AddWithValue("@BorrowRecordId", borrowRecordId);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book returned successfully!");
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

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }
    }
}
