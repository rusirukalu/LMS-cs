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
            dgvAvailableBooks = new DataGridView();
            btnViewBooks = new Button();
            grpAvailableBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAvailableBooks).BeginInit();
            SuspendLayout();
            // 
            // grpAvailableBooks
            // 
            grpAvailableBooks.Controls.Add(btnViewBooks);
            grpAvailableBooks.Controls.Add(dgvAvailableBooks);
            grpAvailableBooks.Location = new Point(36, 40);
            grpAvailableBooks.Name = "grpAvailableBooks";
            grpAvailableBooks.Size = new Size(1223, 693);
            grpAvailableBooks.TabIndex = 0;
            grpAvailableBooks.TabStop = false;
            grpAvailableBooks.Text = "Available books";
            // 
            // dgvAvailableBooks
            // 
            dgvAvailableBooks.AllowUserToAddRows = false;
            dgvAvailableBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAvailableBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAvailableBooks.Location = new Point(50, 74);
            dgvAvailableBooks.Name = "dgvAvailableBooks";
            dgvAvailableBooks.ReadOnly = true;
            dgvAvailableBooks.RowHeadersWidth = 82;
            dgvAvailableBooks.Size = new Size(528, 273);
            dgvAvailableBooks.TabIndex = 0;
            // 
            // btnViewBooks
            // 
            btnViewBooks.Location = new Point(152, 458);
            btnViewBooks.Name = "btnViewBooks";
            btnViewBooks.Size = new Size(300, 82);
            btnViewBooks.TabIndex = 1;
            btnViewBooks.Text = "View ";
            btnViewBooks.UseVisualStyleBackColor = true;
            // 
            // MemberDashboard
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1602, 1036);
            Controls.Add(grpAvailableBooks);
            Name = "MemberDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Member Dashboard";
            grpAvailableBooks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAvailableBooks).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpAvailableBooks;
        private DataGridView dgvAvailableBooks;
        private Button btnViewBooks;
    }
}