namespace BookTrack
{
    partial class BooksForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            pnlHeader = new Panel();
            lblFormTitle = new Label();
            lblFormSubtitle = new Label();
            btnClose = new Button();
            grpBookDetails = new GroupBox();
            lblBookId = new Label();
            txtBookId = new TextBox();
            lblBookTitle = new Label();
            txtBookTitle = new TextBox();
            lblAuthor = new Label();
            txtAuthor = new TextBox();
            lblCategory = new Label();
            cmbCategory = new ComboBox();
            lblCopies = new Label();
            nudCopies = new NumericUpDown();
            btnAddBook = new Button();
            btnUpdateBook = new Button();
            btnDeleteBook = new Button();
            btnClearBook = new Button();
            txtSearchBook = new TextBox();
            btnSearchBook = new Button();
            btnShowAllBooks = new Button();
            dgvBooks = new DataGridView();
            colBooksBookID = new DataGridViewTextBoxColumn();
            colBooksTitle = new DataGridViewTextBoxColumn();
            colBooksAuthor = new DataGridViewTextBoxColumn();
            colBooksCategory = new DataGridViewTextBoxColumn();
            colBooksCopies = new DataGridViewTextBoxColumn();
            lblBookCount = new Label();
            pnlHeader.SuspendLayout();
            grpBookDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCopies).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(31, 58, 95);
            pnlHeader.Controls.Add(lblFormTitle);
            pnlHeader.Controls.Add(lblFormSubtitle);
            pnlHeader.Controls.Add(btnClose);
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1040, 88);
            pnlHeader.TabIndex = 0;
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.BackColor = Color.Transparent;
            lblFormTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblFormTitle.ForeColor = Color.FromArgb(255, 255, 255);
            lblFormTitle.Location = new Point(20, 10);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(306, 45);
            lblFormTitle.TabIndex = 0;
            lblFormTitle.Text = "Book Management";
            // 
            // lblFormSubtitle
            // 
            lblFormSubtitle.AutoSize = true;
            lblFormSubtitle.BackColor = Color.Transparent;
            lblFormSubtitle.Font = new Font("Segoe UI", 9F);
            lblFormSubtitle.ForeColor = Color.FromArgb(200, 215, 235);
            lblFormSubtitle.Location = new Point(20, 55);
            lblFormSubtitle.Name = "lblFormSubtitle";
            lblFormSubtitle.Size = new Size(317, 25);
            lblFormSubtitle.TabIndex = 1;
            lblFormSubtitle.Text = "Add, update, delete, and search books";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(255, 255, 255);
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClose.ForeColor = Color.FromArgb(31, 58, 95);
            btnClose.Location = new Point(900, 15);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(120, 34);
            btnClose.TabIndex = 2;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            // 
            // grpBookDetails
            // 
            grpBookDetails.BackColor = Color.FromArgb(255, 255, 255);
            grpBookDetails.Controls.Add(lblBookId);
            grpBookDetails.Controls.Add(txtBookId);
            grpBookDetails.Controls.Add(lblBookTitle);
            grpBookDetails.Controls.Add(txtBookTitle);
            grpBookDetails.Controls.Add(lblAuthor);
            grpBookDetails.Controls.Add(txtAuthor);
            grpBookDetails.Controls.Add(lblCategory);
            grpBookDetails.Controls.Add(cmbCategory);
            grpBookDetails.Controls.Add(lblCopies);
            grpBookDetails.Controls.Add(nudCopies);
            grpBookDetails.Controls.Add(btnAddBook);
            grpBookDetails.Controls.Add(btnUpdateBook);
            grpBookDetails.Controls.Add(btnDeleteBook);
            grpBookDetails.Controls.Add(btnClearBook);
            grpBookDetails.Location = new Point(20, 128);
            grpBookDetails.Name = "grpBookDetails";
            grpBookDetails.Size = new Size(330, 490);
            grpBookDetails.TabIndex = 1;
            grpBookDetails.TabStop = false;
            grpBookDetails.Text = "Book Details";
            grpBookDetails.Enter += grpBookDetails_Enter;
            // 
            // lblBookId
            // 
            lblBookId.AutoSize = true;
            lblBookId.BackColor = Color.Transparent;
            lblBookId.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblBookId.ForeColor = Color.FromArgb(43, 47, 54);
            lblBookId.Location = new Point(15, 15);
            lblBookId.Name = "lblBookId";
            lblBookId.Size = new Size(87, 28);
            lblBookId.TabIndex = 0;
            lblBookId.Text = "Book ID";
            // 
            // txtBookId
            // 
            txtBookId.BorderStyle = BorderStyle.FixedSingle;
            txtBookId.Location = new Point(16, 46);
            txtBookId.Name = "txtBookId";
            txtBookId.PlaceholderText = "Auto-generated";
            txtBookId.ReadOnly = true;
            txtBookId.Size = new Size(290, 34);
            txtBookId.TabIndex = 1;
            // 
            // lblBookTitle
            // 
            lblBookTitle.AutoSize = true;
            lblBookTitle.BackColor = Color.Transparent;
            lblBookTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblBookTitle.ForeColor = Color.FromArgb(43, 47, 54);
            lblBookTitle.Location = new Point(16, 86);
            lblBookTitle.Name = "lblBookTitle";
            lblBookTitle.Size = new Size(55, 28);
            lblBookTitle.TabIndex = 2;
            lblBookTitle.Text = "Title";
            // 
            // txtBookTitle
            // 
            txtBookTitle.BorderStyle = BorderStyle.FixedSingle;
            txtBookTitle.Location = new Point(16, 110);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(290, 34);
            txtBookTitle.TabIndex = 3;
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.BackColor = Color.Transparent;
            lblAuthor.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblAuthor.ForeColor = Color.FromArgb(43, 47, 54);
            lblAuthor.Location = new Point(16, 150);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(78, 28);
            lblAuthor.TabIndex = 4;
            lblAuthor.Text = "Author";
            // 
            // txtAuthor
            // 
            txtAuthor.BorderStyle = BorderStyle.FixedSingle;
            txtAuthor.Location = new Point(16, 174);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(290, 34);
            txtAuthor.TabIndex = 5;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.BackColor = Color.Transparent;
            lblCategory.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCategory.ForeColor = Color.FromArgb(43, 47, 54);
            lblCategory.Location = new Point(16, 214);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(98, 28);
            lblCategory.TabIndex = 6;
            lblCategory.Text = "Category";
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "Fiction", "Non-Fiction", "Science", "Mathematics", "History", "Technology", "Literature", "Reference" });
            cmbCategory.Location = new Point(16, 238);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(290, 36);
            cmbCategory.TabIndex = 7;
            // 
            // lblCopies
            // 
            lblCopies.AutoSize = true;
            lblCopies.BackColor = Color.Transparent;
            lblCopies.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCopies.ForeColor = Color.FromArgb(43, 47, 54);
            lblCopies.Location = new Point(16, 278);
            lblCopies.Name = "lblCopies";
            lblCopies.Size = new Size(168, 28);
            lblCopies.TabIndex = 8;
            lblCopies.Text = "Copies Available";
            // 
            // nudCopies
            // 
            nudCopies.Location = new Point(16, 302);
            nudCopies.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudCopies.Name = "nudCopies";
            nudCopies.Size = new Size(120, 34);
            nudCopies.TabIndex = 9;
            // 
            // btnAddBook
            // 
            btnAddBook.BackColor = Color.FromArgb(42, 157, 143);
            btnAddBook.Cursor = Cursors.Hand;
            btnAddBook.FlatAppearance.BorderSize = 0;
            btnAddBook.FlatStyle = FlatStyle.Flat;
            btnAddBook.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAddBook.ForeColor = Color.FromArgb(255, 255, 255);
            btnAddBook.Location = new Point(16, 368);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(136, 40);
            btnAddBook.TabIndex = 10;
            btnAddBook.Text = "Add";
            btnAddBook.UseVisualStyleBackColor = false;
            // 
            // btnUpdateBook
            // 
            btnUpdateBook.BackColor = Color.FromArgb(31, 58, 95);
            btnUpdateBook.Cursor = Cursors.Hand;
            btnUpdateBook.FlatAppearance.BorderSize = 0;
            btnUpdateBook.FlatStyle = FlatStyle.Flat;
            btnUpdateBook.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnUpdateBook.ForeColor = Color.FromArgb(255, 255, 255);
            btnUpdateBook.Location = new Point(170, 368);
            btnUpdateBook.Name = "btnUpdateBook";
            btnUpdateBook.Size = new Size(136, 40);
            btnUpdateBook.TabIndex = 11;
            btnUpdateBook.Text = "Update";
            btnUpdateBook.UseVisualStyleBackColor = false;
            // 
            // btnDeleteBook
            // 
            btnDeleteBook.BackColor = Color.FromArgb(214, 69, 69);
            btnDeleteBook.Cursor = Cursors.Hand;
            btnDeleteBook.FlatAppearance.BorderSize = 0;
            btnDeleteBook.FlatStyle = FlatStyle.Flat;
            btnDeleteBook.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDeleteBook.ForeColor = Color.FromArgb(255, 255, 255);
            btnDeleteBook.Location = new Point(16, 418);
            btnDeleteBook.Name = "btnDeleteBook";
            btnDeleteBook.Size = new Size(136, 40);
            btnDeleteBook.TabIndex = 12;
            btnDeleteBook.Text = "Delete";
            btnDeleteBook.UseVisualStyleBackColor = false;
            // 
            // btnClearBook
            // 
            btnClearBook.BackColor = Color.FromArgb(107, 114, 128);
            btnClearBook.Cursor = Cursors.Hand;
            btnClearBook.FlatAppearance.BorderSize = 0;
            btnClearBook.FlatStyle = FlatStyle.Flat;
            btnClearBook.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClearBook.ForeColor = Color.FromArgb(255, 255, 255);
            btnClearBook.Location = new Point(170, 418);
            btnClearBook.Name = "btnClearBook";
            btnClearBook.Size = new Size(136, 40);
            btnClearBook.TabIndex = 13;
            btnClearBook.Text = "Clear";
            btnClearBook.UseVisualStyleBackColor = false;
            // 
            // txtSearchBook
            // 
            txtSearchBook.BorderStyle = BorderStyle.FixedSingle;
            txtSearchBook.Location = new Point(370, 134);
            txtSearchBook.Name = "txtSearchBook";
            txtSearchBook.PlaceholderText = "Search by title, author, or category...";
            txtSearchBook.Size = new Size(300, 34);
            txtSearchBook.TabIndex = 2;
            // 
            // btnSearchBook
            // 
            btnSearchBook.BackColor = Color.FromArgb(31, 58, 95);
            btnSearchBook.Cursor = Cursors.Hand;
            btnSearchBook.FlatAppearance.BorderSize = 0;
            btnSearchBook.FlatStyle = FlatStyle.Flat;
            btnSearchBook.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSearchBook.ForeColor = Color.FromArgb(255, 255, 255);
            btnSearchBook.Location = new Point(680, 132);
            btnSearchBook.Name = "btnSearchBook";
            btnSearchBook.Size = new Size(100, 31);
            btnSearchBook.TabIndex = 3;
            btnSearchBook.Text = "Search";
            btnSearchBook.UseVisualStyleBackColor = false;
            // 
            // btnShowAllBooks
            // 
            btnShowAllBooks.BackColor = Color.FromArgb(107, 114, 128);
            btnShowAllBooks.Cursor = Cursors.Hand;
            btnShowAllBooks.FlatAppearance.BorderSize = 0;
            btnShowAllBooks.FlatStyle = FlatStyle.Flat;
            btnShowAllBooks.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnShowAllBooks.ForeColor = Color.FromArgb(255, 255, 255);
            btnShowAllBooks.Location = new Point(790, 132);
            btnShowAllBooks.Name = "btnShowAllBooks";
            btnShowAllBooks.Size = new Size(110, 31);
            btnShowAllBooks.TabIndex = 4;
            btnShowAllBooks.Text = "Show All";
            btnShowAllBooks.UseVisualStyleBackColor = false;
            // 
            // dgvBooks
            // 
            dgvBooks.AllowUserToAddRows = false;
            dgvBooks.AllowUserToDeleteRows = false;
            dgvBooks.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(244, 246, 249);
            dgvBooks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBooks.BackgroundColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(31, 58, 95);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(31, 58, 95);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvBooks.ColumnHeadersHeight = 34;
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvBooks.Columns.AddRange(new DataGridViewColumn[] { colBooksBookID, colBooksTitle, colBooksAuthor, colBooksCategory, colBooksCopies });
            dgvBooks.EnableHeadersVisualStyles = false;
            dgvBooks.Location = new Point(370, 179);
            dgvBooks.MultiSelect = false;
            dgvBooks.Name = "dgvBooks";
            dgvBooks.ReadOnly = true;
            dgvBooks.RowHeadersVisible = false;
            dgvBooks.RowHeadersWidth = 62;
            dgvBooks.RowTemplate.Height = 28;
            dgvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBooks.Size = new Size(650, 440);
            dgvBooks.TabIndex = 5;
            // 
            // colBooksBookID
            // 
            colBooksBookID.FillWeight = 55F;
            colBooksBookID.HeaderText = "Book ID";
            colBooksBookID.MinimumWidth = 8;
            colBooksBookID.Name = "colBooksBookID";
            colBooksBookID.ReadOnly = true;
            // 
            // colBooksTitle
            // 
            colBooksTitle.FillWeight = 160F;
            colBooksTitle.HeaderText = "Title";
            colBooksTitle.MinimumWidth = 8;
            colBooksTitle.Name = "colBooksTitle";
            colBooksTitle.ReadOnly = true;
            // 
            // colBooksAuthor
            // 
            colBooksAuthor.FillWeight = 120F;
            colBooksAuthor.HeaderText = "Author";
            colBooksAuthor.MinimumWidth = 8;
            colBooksAuthor.Name = "colBooksAuthor";
            colBooksAuthor.ReadOnly = true;
            // 
            // colBooksCategory
            // 
            colBooksCategory.FillWeight = 90F;
            colBooksCategory.HeaderText = "Category";
            colBooksCategory.MinimumWidth = 8;
            colBooksCategory.Name = "colBooksCategory";
            colBooksCategory.ReadOnly = true;
            // 
            // colBooksCopies
            // 
            colBooksCopies.FillWeight = 50F;
            colBooksCopies.HeaderText = "Copies";
            colBooksCopies.MinimumWidth = 8;
            colBooksCopies.Name = "colBooksCopies";
            colBooksCopies.ReadOnly = true;
            // 
            // lblBookCount
            // 
            lblBookCount.AutoSize = true;
            lblBookCount.BackColor = Color.Transparent;
            lblBookCount.Font = new Font("Segoe UI", 9F);
            lblBookCount.ForeColor = Color.FromArgb(107, 114, 128);
            lblBookCount.Location = new Point(370, 632);
            lblBookCount.Name = "lblBookCount";
            lblBookCount.Size = new Size(123, 25);
            lblBookCount.TabIndex = 6;
            lblBookCount.Text = "Total books: 0";
            // 
            // BooksForm
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(244, 246, 249);
            ClientSize = new Size(1263, 701);
            Controls.Add(pnlHeader);
            Controls.Add(grpBookDetails);
            Controls.Add(txtSearchBook);
            Controls.Add(btnSearchBook);
            Controls.Add(btnShowAllBooks);
            Controls.Add(dgvBooks);
            Controls.Add(lblBookCount);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "BooksForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BookTrack - Book Management";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            grpBookDetails.ResumeLayout(false);
            grpBookDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCopies).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Label lblFormSubtitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox grpBookDetails;
        private System.Windows.Forms.Label lblBookId;
        private System.Windows.Forms.TextBox txtBookId;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.TextBox txtBookTitle;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblCopies;
        private System.Windows.Forms.NumericUpDown nudCopies;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnUpdateBook;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.Button btnClearBook;
        private System.Windows.Forms.TextBox txtSearchBook;
        private System.Windows.Forms.Button btnSearchBook;
        private System.Windows.Forms.Button btnShowAllBooks;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBooksBookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBooksTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBooksAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBooksCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBooksCopies;
        private System.Windows.Forms.DataGridViewCellStyle dgvBooksAltStyle;
        private System.Windows.Forms.DataGridViewCellStyle dgvBooksHeadStyle;
        private System.Windows.Forms.Label lblBookCount;
    }
}
