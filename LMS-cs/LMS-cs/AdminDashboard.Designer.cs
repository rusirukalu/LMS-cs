namespace LMS_cs
{
    partial class AdminDashboard
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
            grpBookManagement = new GroupBox();
            txtCopies = new TextBox();
            txtISBN = new TextBox();
            txtAuthor = new TextBox();
            txtTitle = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            txtMemberName = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            dgvBorrowRecords = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnAddBook = new Button();
            btnLoadRecords = new Button();
            btnAddMember = new Button();
            grpBookManagement.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBorrowRecords).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // grpBookManagement
            // 
            grpBookManagement.Anchor = AnchorStyles.None;
            grpBookManagement.Controls.Add(txtCopies);
            grpBookManagement.Controls.Add(txtISBN);
            grpBookManagement.Controls.Add(txtAuthor);
            grpBookManagement.Controls.Add(txtTitle);
            grpBookManagement.Controls.Add(label4);
            grpBookManagement.Controls.Add(label3);
            grpBookManagement.Controls.Add(label2);
            grpBookManagement.Controls.Add(label1);
            grpBookManagement.Location = new Point(68, 51);
            grpBookManagement.Name = "grpBookManagement";
            grpBookManagement.Size = new Size(864, 318);
            grpBookManagement.TabIndex = 0;
            grpBookManagement.TabStop = false;
            grpBookManagement.Text = "Book Management";
            // 
            // txtCopies
            // 
            txtCopies.Location = new Point(251, 253);
            txtCopies.Name = "txtCopies";
            txtCopies.Size = new Size(559, 39);
            txtCopies.TabIndex = 7;
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(251, 186);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(559, 39);
            txtISBN.TabIndex = 6;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(251, 123);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(559, 39);
            txtAuthor.TabIndex = 5;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(251, 64);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(559, 39);
            txtTitle.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 253);
            label4.Name = "label4";
            label4.Size = new Size(86, 32);
            label4.TabIndex = 3;
            label4.Text = "Copies";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 186);
            label3.Name = "label3";
            label3.Size = new Size(65, 32);
            label3.TabIndex = 2;
            label3.Text = "ISBN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 123);
            label2.Name = "label2";
            label2.Size = new Size(87, 32);
            label2.TabIndex = 1;
            label2.Text = "Author";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 64);
            label1.Name = "label1";
            label1.Size = new Size(60, 32);
            label1.TabIndex = 0;
            label1.Text = "Title";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.Controls.Add(txtPhone);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtMemberName);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label8);
            groupBox1.Location = new Point(53, 422);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(864, 258);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Member Management";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(251, 186);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(559, 39);
            txtPhone.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(251, 123);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(559, 39);
            txtEmail.TabIndex = 5;
            // 
            // txtMemberName
            // 
            txtMemberName.Location = new Point(251, 64);
            txtMemberName.Name = "txtMemberName";
            txtMemberName.Size = new Size(559, 39);
            txtMemberName.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 186);
            label6.Name = "label6";
            label6.Size = new Size(82, 32);
            label6.TabIndex = 2;
            label6.Text = "Phone";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(31, 123);
            label7.Name = "label7";
            label7.Size = new Size(71, 32);
            label7.TabIndex = 1;
            label7.Text = "Email";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(31, 64);
            label8.Name = "label8";
            label8.Size = new Size(78, 32);
            label8.TabIndex = 0;
            label8.Text = "Name";
            // 
            // dgvBorrowRecords
            // 
            dgvBorrowRecords.AllowUserToAddRows = false;
            dgvBorrowRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBorrowRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBorrowRecords.Dock = DockStyle.Fill;
            dgvBorrowRecords.Location = new Point(3, 726);
            dgvBorrowRecords.Name = "dgvBorrowRecords";
            dgvBorrowRecords.ReadOnly = true;
            dgvBorrowRecords.RowHeadersWidth = 82;
            dgvBorrowRecords.Size = new Size(964, 523);
            dgvBorrowRecords.TabIndex = 9;
            dgvBorrowRecords.CellContentClick += dgvBorrowRecords_CellContentClick;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.4312859F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.5687141F));
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 1);
            tableLayoutPanel1.Controls.Add(btnAddMember, 1, 1);
            tableLayoutPanel1.Controls.Add(btnLoadRecords, 1, 2);
            tableLayoutPanel1.Controls.Add(btnAddBook, 1, 0);
            tableLayoutPanel1.Controls.Add(dgvBorrowRecords, 0, 2);
            tableLayoutPanel1.Location = new Point(30, 30);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 52.5587845F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 47.4412155F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 528F));
            tableLayoutPanel1.Size = new Size(1579, 1252);
            tableLayoutPanel1.TabIndex = 13;
            // 
            // btnAddBook
            // 
            btnAddBook.Anchor = AnchorStyles.None;
            btnAddBook.Location = new Point(1138, 154);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(273, 71);
            btnAddBook.TabIndex = 10;
            btnAddBook.Text = "Add Book";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // btnLoadRecords
            // 
            btnLoadRecords.Anchor = AnchorStyles.None;
            btnLoadRecords.Location = new Point(1138, 952);
            btnLoadRecords.Name = "btnLoadRecords";
            btnLoadRecords.Size = new Size(273, 71);
            btnLoadRecords.TabIndex = 12;
            btnLoadRecords.Text = "Load Records";
            btnLoadRecords.UseVisualStyleBackColor = true;
            btnLoadRecords.Click += btnLoadRecords_Click;
            // 
            // btnAddMember
            // 
            btnAddMember.Anchor = AnchorStyles.None;
            btnAddMember.Location = new Point(1138, 516);
            btnAddMember.Name = "btnAddMember";
            btnAddMember.Size = new Size(273, 71);
            btnAddMember.TabIndex = 11;
            btnAddMember.Text = "Add Member";
            btnAddMember.UseVisualStyleBackColor = true;
            btnAddMember.Click += btnAddMember_Click;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1675, 1311);
            Controls.Add(grpBookManagement);
            Controls.Add(tableLayoutPanel1);
            Name = "AdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Dashboard";
            Load += AdminDashboard_Load;
            grpBookManagement.ResumeLayout(false);
            grpBookManagement.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBorrowRecords).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpBookManagement;
        private Label label1;
        private TextBox txtCopies;
        private TextBox txtISBN;
        private TextBox txtAuthor;
        private TextBox txtTitle;
        private Label label4;
        private Label label3;
        private Label label2;
        private GroupBox groupBox1;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private TextBox txtMemberName;
        private Label label6;
        private Label label7;
        private Label label8;
        private DataGridView dgvBorrowRecords;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnAddBook;
        private Button btnLoadRecords;
        private Button btnAddMember;
    }
}