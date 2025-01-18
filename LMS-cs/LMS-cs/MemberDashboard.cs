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
        public MemberDashboard()
        {
            InitializeComponent();
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
    }
}
