namespace LMS_cs
{
    partial class MemberDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpAvailableBooks = new GroupBox();
            btnViewBooks = new Button();
            dgvAvailableBooks = new DataGridView();
            grpBorrowBook = new GroupBox();
            txtBookId = new TextBox();
            label1 = new Label();
            btnBorrow = new Button();
            grpReturnBook = new GroupBox();
            txtBorrowRecordId = new TextBox();
            label2 = new Label();
            btnReturn = new Button();
            btnLogout = new Button();
            grpAvailableBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAvailableBooks).BeginInit();
            grpBorrowBook.SuspendLayout();
            grpReturnBook.SuspendLayout();
            SuspendLayout();
            // 
            // grpAvailableBooks
            // 
            grpAvailableBooks.Controls.Add(btnViewBooks);
            grpAvailableBooks.Controls.Add(dgvAvailableBooks);
            grpAvailableBooks.Location = new Point(36, 40);
            grpAvailableBooks.Name = "grpAvailableBooks";
            grpAvailableBooks.Size = new Size(1223, 484);
            grpAvailableBooks.TabIndex = 0;
            grpAvailableBooks.TabStop = false;
            grpAvailableBooks.Text = "Available books";
            // 
            // btnViewBooks
            // 
            btnViewBooks.Location = new Point(862, 161);
            btnViewBooks.Name = "btnViewBooks";
            btnViewBooks.Size = new Size(300, 82);
            btnViewBooks.TabIndex = 1;
            btnViewBooks.Text = "View Available Books";
            btnViewBooks.UseVisualStyleBackColor = true;
            btnViewBooks.Click += btnViewBooks_Click;
            // 
            // dgvAvailableBooks
            // 
            dgvAvailableBooks.AllowUserToAddRows = false;
            dgvAvailableBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAvailableBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAvailableBooks.Location = new Point(50, 61);
            dgvAvailableBooks.Name = "dgvAvailableBooks";
            dgvAvailableBooks.ReadOnly = true;
            dgvAvailableBooks.RowHeadersWidth = 82;
            dgvAvailableBooks.Size = new Size(756, 371);
            dgvAvailableBooks.TabIndex = 0;
            // 
            // grpBorrowBook
            // 
            grpBorrowBook.Controls.Add(txtBookId);
            grpBorrowBook.Controls.Add(label1);
            grpBorrowBook.Controls.Add(btnBorrow);
            grpBorrowBook.Location = new Point(36, 579);
            grpBorrowBook.Name = "grpBorrowBook";
            grpBorrowBook.Size = new Size(1223, 168);
            grpBorrowBook.TabIndex = 2;
            grpBorrowBook.TabStop = false;
            grpBorrowBook.Text = "Borrow books";
            // 
            // txtBookId
            // 
            txtBookId.Location = new Point(202, 78);
            txtBookId.Name = "txtBookId";
            txtBookId.Size = new Size(427, 39);
            txtBookId.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 81);
            label1.Name = "label1";
            label1.Size = new Size(98, 32);
            label1.TabIndex = 2;
            label1.Text = "Book ID";
            // 
            // btnBorrow
            // 
            btnBorrow.Location = new Point(770, 67);
            btnBorrow.Name = "btnBorrow";
            btnBorrow.Size = new Size(217, 60);
            btnBorrow.TabIndex = 1;
            btnBorrow.Text = "Borrow Book";
            btnBorrow.UseVisualStyleBackColor = true;
            btnBorrow.Click += btnBorrow_Click;
            // 
            // grpReturnBook
            // 
            grpReturnBook.Controls.Add(txtBorrowRecordId);
            grpReturnBook.Controls.Add(label2);
            grpReturnBook.Controls.Add(btnReturn);
            grpReturnBook.Location = new Point(36, 809);
            grpReturnBook.Name = "grpReturnBook";
            grpReturnBook.Size = new Size(1223, 168);
            grpReturnBook.TabIndex = 4;
            grpReturnBook.TabStop = false;
            grpReturnBook.Text = "Book Return";
            // 
            // txtBorrowRecordId
            // 
            txtBorrowRecordId.Location = new Point(310, 81);
            txtBorrowRecordId.Name = "txtBorrowRecordId";
            txtBorrowRecordId.Size = new Size(427, 39);
            txtBorrowRecordId.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 81);
            label2.Name = "label2";
            label2.Size = new Size(199, 32);
            label2.TabIndex = 2;
            label2.Text = "Borrow Record ID";
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(832, 67);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(217, 60);
            btnReturn.TabIndex = 1;
            btnReturn.Text = "Return Book";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(1352, 480);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(201, 130);
            btnLogout.TabIndex = 15;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // MemberDashboard
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1602, 1033);
            Controls.Add(btnLogout);
            Controls.Add(grpReturnBook);
            Controls.Add(grpBorrowBook);
            Controls.Add(grpAvailableBooks);
            Name = "MemberDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Member Dashboard";
            Load += MemberDashboard_Load;
            grpAvailableBooks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAvailableBooks).EndInit();
            grpBorrowBook.ResumeLayout(false);
            grpBorrowBook.PerformLayout();
            grpReturnBook.ResumeLayout(false);
            grpReturnBook.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpAvailableBooks;
        private DataGridView dgvAvailableBooks;
        private Button btnViewBooks;
        private GroupBox grpBorrowBook;
        private TextBox txtBookId;
        private Label label1;
        private Button btnBorrow;
        private GroupBox grpReturnBook;
        private TextBox txtBorrowRecordId;
        private Label label2;
        private Button btnReturn;
        private Button btnLogout;
    }
}