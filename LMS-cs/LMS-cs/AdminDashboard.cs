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
        public AdminDashboard(int userId)
        {
            InitializeComponent();
            adminId = userId;
            conn = new SqlConnection("Server=localhost;Database=LibraryDB;Trusted_Connection=True;");
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {

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
    }
}
