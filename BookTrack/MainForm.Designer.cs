namespace BookTrack
{
    partial class MainForm
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
            pnlSidebar = new Panel();
            lblLogo = new Label();
            lblLogoSub = new Label();
            btnDashboard = new Button();
            btnBooks = new Button();
            btnMembers = new Button();
            btnBorrowReturn = new Button();
            btnHistory = new Button();
            btnStaff = new Button();
            btnLogout = new Button();
            pnlTop = new Panel();
            lblPageTitle = new Label();
            lblLoggedUser = new Label();
            pnlCardBooks = new Panel();
            pnlStripBooks = new Panel();
            lblBooksValue = new Label();
            lblBooksCaption = new Label();
            pnlCardMembers = new Panel();
            pnlStripMembers = new Panel();
            lblMembersValue = new Label();
            lblMembersCaption = new Label();
            pnlCardBorrowed = new Panel();
            pnlStripBorrowed = new Panel();
            lblBorrowedValue = new Label();
            lblBorrowedCaption = new Label();
            pnlCardOverdue = new Panel();
            pnlStripOverdue = new Panel();
            lblOverdueValue = new Label();
            lblOverdueCaption = new Label();
            lblQuick = new Label();
            btnQuickBorrow = new Button();
            btnQuickReturn = new Button();
            btnQuickAddBook = new Button();
            btnQuickAddMember = new Button();
            lblRecent = new Label();
            dgvRecent = new DataGridView();
            colRecentRecordID = new DataGridViewTextBoxColumn();
            colRecentMember = new DataGridViewTextBoxColumn();
            colRecentBook = new DataGridViewTextBoxColumn();
            colRecentBorrowDate = new DataGridViewTextBoxColumn();
            colRecentDueDate = new DataGridViewTextBoxColumn();
            colRecentStatus = new DataGridViewTextBoxColumn();
            pnlSidebar.SuspendLayout();
            pnlTop.SuspendLayout();
            pnlCardBooks.SuspendLayout();
            pnlCardMembers.SuspendLayout();
            pnlCardBorrowed.SuspendLayout();
            pnlCardOverdue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecent).BeginInit();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(31, 58, 95);
            pnlSidebar.Controls.Add(lblLogo);
            pnlSidebar.Controls.Add(lblLogoSub);
            pnlSidebar.Controls.Add(btnDashboard);
            pnlSidebar.Controls.Add(btnBooks);
            pnlSidebar.Controls.Add(btnMembers);
            pnlSidebar.Controls.Add(btnBorrowReturn);
            pnlSidebar.Controls.Add(btnHistory);
            pnlSidebar.Controls.Add(btnStaff);
            pnlSidebar.Controls.Add(btnLogout);
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(230, 680);
            pnlSidebar.TabIndex = 0;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.BackColor = Color.Transparent;
            lblLogo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblLogo.ForeColor = Color.FromArgb(255, 255, 255);
            lblLogo.Location = new Point(20, 20);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(195, 48);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "BookTrack";
            // 
            // lblLogoSub
            // 
            lblLogoSub.AutoSize = true;
            lblLogoSub.BackColor = Color.Transparent;
            lblLogoSub.Font = new Font("Segoe UI", 9F);
            lblLogoSub.ForeColor = Color.FromArgb(200, 215, 235);
            lblLogoSub.Location = new Point(20, 68);
            lblLogoSub.Name = "lblLogoSub";
            lblLogoSub.Size = new Size(127, 25);
            lblLogoSub.TabIndex = 1;
            lblLogoSub.Text = "Library System";
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(45, 80, 128);
            btnDashboard.Cursor = Cursors.Hand;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDashboard.ForeColor = Color.FromArgb(255, 255, 255);
            btnDashboard.Location = new Point(0, 110);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(24, 0, 0, 0);
            btnDashboard.Size = new Size(230, 46);
            btnDashboard.TabIndex = 2;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // btnBooks
            // 
            btnBooks.BackColor = Color.FromArgb(31, 58, 95);
            btnBooks.Cursor = Cursors.Hand;
            btnBooks.FlatAppearance.BorderSize = 0;
            btnBooks.FlatStyle = FlatStyle.Flat;
            btnBooks.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBooks.ForeColor = Color.FromArgb(255, 255, 255);
            btnBooks.Location = new Point(0, 160);
            btnBooks.Name = "btnBooks";
            btnBooks.Padding = new Padding(24, 0, 0, 0);
            btnBooks.Size = new Size(230, 46);
            btnBooks.TabIndex = 3;
            btnBooks.Text = "Books";
            btnBooks.TextAlign = ContentAlignment.MiddleLeft;
            btnBooks.UseVisualStyleBackColor = false;
            // 
            // btnMembers
            // 
            btnMembers.BackColor = Color.FromArgb(31, 58, 95);
            btnMembers.Cursor = Cursors.Hand;
            btnMembers.FlatAppearance.BorderSize = 0;
            btnMembers.FlatStyle = FlatStyle.Flat;
            btnMembers.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnMembers.ForeColor = Color.FromArgb(255, 255, 255);
            btnMembers.Location = new Point(0, 210);
            btnMembers.Name = "btnMembers";
            btnMembers.Padding = new Padding(24, 0, 0, 0);
            btnMembers.Size = new Size(230, 46);
            btnMembers.TabIndex = 4;
            btnMembers.Text = "Members";
            btnMembers.TextAlign = ContentAlignment.MiddleLeft;
            btnMembers.UseVisualStyleBackColor = false;
            // 
            // btnBorrowReturn
            // 
            btnBorrowReturn.BackColor = Color.FromArgb(31, 58, 95);
            btnBorrowReturn.Cursor = Cursors.Hand;
            btnBorrowReturn.FlatAppearance.BorderSize = 0;
            btnBorrowReturn.FlatStyle = FlatStyle.Flat;
            btnBorrowReturn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBorrowReturn.ForeColor = Color.FromArgb(255, 255, 255);
            btnBorrowReturn.Location = new Point(0, 260);
            btnBorrowReturn.Name = "btnBorrowReturn";
            btnBorrowReturn.Padding = new Padding(24, 0, 0, 0);
            btnBorrowReturn.Size = new Size(230, 46);
            btnBorrowReturn.TabIndex = 5;
            btnBorrowReturn.Text = "Borrow / Return";
            btnBorrowReturn.TextAlign = ContentAlignment.MiddleLeft;
            btnBorrowReturn.UseVisualStyleBackColor = false;
            // 
            // btnHistory
            // 
            btnHistory.BackColor = Color.FromArgb(31, 58, 95);
            btnHistory.Cursor = Cursors.Hand;
            btnHistory.FlatAppearance.BorderSize = 0;
            btnHistory.FlatStyle = FlatStyle.Flat;
            btnHistory.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnHistory.ForeColor = Color.FromArgb(255, 255, 255);
            btnHistory.Location = new Point(0, 310);
            btnHistory.Name = "btnHistory";
            btnHistory.Padding = new Padding(24, 0, 0, 0);
            btnHistory.Size = new Size(230, 46);
            btnHistory.TabIndex = 6;
            btnHistory.Text = "History && Reports";
            btnHistory.TextAlign = ContentAlignment.MiddleLeft;
            btnHistory.UseVisualStyleBackColor = false;
            // 
            // btnStaff
            // 
            btnStaff.BackColor = Color.FromArgb(31, 58, 95);
            btnStaff.Cursor = Cursors.Hand;
            btnStaff.FlatAppearance.BorderSize = 0;
            btnStaff.FlatStyle = FlatStyle.Flat;
            btnStaff.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnStaff.ForeColor = Color.FromArgb(255, 255, 255);
            btnStaff.Location = new Point(0, 360);
            btnStaff.Name = "btnStaff";
            btnStaff.Padding = new Padding(24, 0, 0, 0);
            btnStaff.Size = new Size(230, 46);
            btnStaff.TabIndex = 7;
            btnStaff.Text = "Staff Accounts";
            btnStaff.TextAlign = ContentAlignment.MiddleLeft;
            btnStaff.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(214, 69, 69);
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLogout.ForeColor = Color.FromArgb(255, 255, 255);
            btnLogout.Location = new Point(20, 610);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(190, 40);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.FromArgb(255, 255, 255);
            pnlTop.Controls.Add(lblPageTitle);
            pnlTop.Controls.Add(lblLoggedUser);
            pnlTop.Location = new Point(230, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(890, 64);
            pnlTop.TabIndex = 1;
            // 
            // lblPageTitle
            // 
            lblPageTitle.AutoSize = true;
            lblPageTitle.BackColor = Color.Transparent;
            lblPageTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblPageTitle.ForeColor = Color.FromArgb(31, 58, 95);
            lblPageTitle.Location = new Point(24, 16);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(184, 45);
            lblPageTitle.TabIndex = 0;
            lblPageTitle.Text = "Dashboard";
            // 
            // lblLoggedUser
            // 
            lblLoggedUser.BackColor = Color.Transparent;
            lblLoggedUser.Font = new Font("Segoe UI", 10F);
            lblLoggedUser.ForeColor = Color.FromArgb(107, 114, 128);
            lblLoggedUser.Location = new Point(566, 20);
            lblLoggedUser.Name = "lblLoggedUser";
            lblLoggedUser.Size = new Size(300, 24);
            lblLoggedUser.TabIndex = 1;
            lblLoggedUser.Text = "Logged in as: admin (Admin)";
            lblLoggedUser.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pnlCardBooks
            // 
            pnlCardBooks.BackColor = Color.FromArgb(255, 255, 255);
            pnlCardBooks.Controls.Add(pnlStripBooks);
            pnlCardBooks.Controls.Add(lblBooksValue);
            pnlCardBooks.Controls.Add(lblBooksCaption);
            pnlCardBooks.Location = new Point(254, 90);
            pnlCardBooks.Name = "pnlCardBooks";
            pnlCardBooks.Size = new Size(198, 100);
            pnlCardBooks.TabIndex = 2;
            // 
            // pnlStripBooks
            // 
            pnlStripBooks.BackColor = Color.FromArgb(31, 58, 95);
            pnlStripBooks.Location = new Point(0, 0);
            pnlStripBooks.Name = "pnlStripBooks";
            pnlStripBooks.Size = new Size(6, 100);
            pnlStripBooks.TabIndex = 0;
            // 
            // lblBooksValue
            // 
            lblBooksValue.AutoSize = true;
            lblBooksValue.BackColor = Color.Transparent;
            lblBooksValue.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBooksValue.ForeColor = Color.DarkTurquoise;
            lblBooksValue.Location = new Point(24, 9);
            lblBooksValue.Name = "lblBooksValue";
            lblBooksValue.Size = new Size(46, 54);
            lblBooksValue.TabIndex = 1;
            lblBooksValue.Text = "0";
            // 
            // lblBooksCaption
            // 
            lblBooksCaption.AutoSize = true;
            lblBooksCaption.BackColor = Color.Transparent;
            lblBooksCaption.Font = new Font("Segoe UI", 10F);
            lblBooksCaption.ForeColor = Color.FromArgb(107, 114, 128);
            lblBooksCaption.Location = new Point(24, 64);
            lblBooksCaption.Name = "lblBooksCaption";
            lblBooksCaption.Size = new Size(112, 28);
            lblBooksCaption.TabIndex = 2;
            lblBooksCaption.Text = "Total Books";
            // 
            // pnlCardMembers
            // 
            pnlCardMembers.BackColor = Color.FromArgb(255, 255, 255);
            pnlCardMembers.Controls.Add(pnlStripMembers);
            pnlCardMembers.Controls.Add(lblMembersValue);
            pnlCardMembers.Controls.Add(lblMembersCaption);
            pnlCardMembers.Location = new Point(468, 90);
            pnlCardMembers.Name = "pnlCardMembers";
            pnlCardMembers.Size = new Size(198, 100);
            pnlCardMembers.TabIndex = 3;
            // 
            // pnlStripMembers
            // 
            pnlStripMembers.BackColor = Color.FromArgb(42, 157, 143);
            pnlStripMembers.Location = new Point(0, 0);
            pnlStripMembers.Name = "pnlStripMembers";
            pnlStripMembers.Size = new Size(6, 100);
            pnlStripMembers.TabIndex = 0;
            // 
            // lblMembersValue
            // 
            lblMembersValue.AutoSize = true;
            lblMembersValue.BackColor = Color.Transparent;
            lblMembersValue.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            lblMembersValue.ForeColor = Color.FromArgb(42, 157, 143);
            lblMembersValue.Location = new Point(24, 0);
            lblMembersValue.Name = "lblMembersValue";
            lblMembersValue.Size = new Size(60, 70);
            lblMembersValue.TabIndex = 1;
            lblMembersValue.Text = "0";
            // 
            // lblMembersCaption
            // 
            lblMembersCaption.AutoSize = true;
            lblMembersCaption.BackColor = Color.Transparent;
            lblMembersCaption.Font = new Font("Segoe UI", 10F);
            lblMembersCaption.ForeColor = Color.FromArgb(107, 114, 128);
            lblMembersCaption.Location = new Point(24, 64);
            lblMembersCaption.Name = "lblMembersCaption";
            lblMembersCaption.Size = new Size(141, 28);
            lblMembersCaption.TabIndex = 2;
            lblMembersCaption.Text = "Total Members";
            // 
            // pnlCardBorrowed
            // 
            pnlCardBorrowed.BackColor = Color.FromArgb(255, 255, 255);
            pnlCardBorrowed.Controls.Add(pnlStripBorrowed);
            pnlCardBorrowed.Controls.Add(lblBorrowedValue);
            pnlCardBorrowed.Controls.Add(lblBorrowedCaption);
            pnlCardBorrowed.Location = new Point(682, 90);
            pnlCardBorrowed.Name = "pnlCardBorrowed";
            pnlCardBorrowed.Size = new Size(198, 100);
            pnlCardBorrowed.TabIndex = 4;
            // 
            // pnlStripBorrowed
            // 
            pnlStripBorrowed.BackColor = Color.FromArgb(233, 162, 59);
            pnlStripBorrowed.Location = new Point(0, 0);
            pnlStripBorrowed.Name = "pnlStripBorrowed";
            pnlStripBorrowed.Size = new Size(6, 100);
            pnlStripBorrowed.TabIndex = 0;
            // 
            // lblBorrowedValue
            // 
            lblBorrowedValue.AutoSize = true;
            lblBorrowedValue.BackColor = Color.Transparent;
            lblBorrowedValue.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            lblBorrowedValue.ForeColor = Color.FromArgb(233, 162, 59);
            lblBorrowedValue.Location = new Point(24, 0);
            lblBorrowedValue.Name = "lblBorrowedValue";
            lblBorrowedValue.Size = new Size(60, 70);
            lblBorrowedValue.TabIndex = 1;
            lblBorrowedValue.Text = "0";
            lblBorrowedValue.Click += lblBorrowedValue_Click;
            // 
            // lblBorrowedCaption
            // 
            lblBorrowedCaption.AutoSize = true;
            lblBorrowedCaption.BackColor = Color.Transparent;
            lblBorrowedCaption.Font = new Font("Segoe UI", 10F);
            lblBorrowedCaption.ForeColor = Color.FromArgb(107, 114, 128);
            lblBorrowedCaption.Location = new Point(24, 64);
            lblBorrowedCaption.Name = "lblBorrowedCaption";
            lblBorrowedCaption.Size = new Size(182, 28);
            lblBorrowedCaption.TabIndex = 2;
            lblBorrowedCaption.Text = "Currently Borrowed";
            // 
            // pnlCardOverdue
            // 
            pnlCardOverdue.BackColor = Color.FromArgb(255, 255, 255);
            pnlCardOverdue.Controls.Add(pnlStripOverdue);
            pnlCardOverdue.Controls.Add(lblOverdueValue);
            pnlCardOverdue.Controls.Add(lblOverdueCaption);
            pnlCardOverdue.Location = new Point(896, 90);
            pnlCardOverdue.Name = "pnlCardOverdue";
            pnlCardOverdue.Size = new Size(198, 100);
            pnlCardOverdue.TabIndex = 5;
            // 
            // pnlStripOverdue
            // 
            pnlStripOverdue.BackColor = Color.FromArgb(214, 69, 69);
            pnlStripOverdue.Location = new Point(0, 0);
            pnlStripOverdue.Name = "pnlStripOverdue";
            pnlStripOverdue.Size = new Size(6, 100);
            pnlStripOverdue.TabIndex = 0;
            // 
            // lblOverdueValue
            // 
            lblOverdueValue.AutoSize = true;
            lblOverdueValue.BackColor = Color.Transparent;
            lblOverdueValue.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            lblOverdueValue.ForeColor = Color.FromArgb(214, 69, 69);
            lblOverdueValue.Location = new Point(24, 0);
            lblOverdueValue.Name = "lblOverdueValue";
            lblOverdueValue.Size = new Size(60, 70);
            lblOverdueValue.TabIndex = 1;
            lblOverdueValue.Text = "0";
            // 
            // lblOverdueCaption
            // 
            lblOverdueCaption.AutoSize = true;
            lblOverdueCaption.BackColor = Color.Transparent;
            lblOverdueCaption.Font = new Font("Segoe UI", 10F);
            lblOverdueCaption.ForeColor = Color.FromArgb(107, 114, 128);
            lblOverdueCaption.Location = new Point(24, 64);
            lblOverdueCaption.Name = "lblOverdueCaption";
            lblOverdueCaption.Size = new Size(139, 28);
            lblOverdueCaption.TabIndex = 2;
            lblOverdueCaption.Text = "Overdue Items";
            // 
            // lblQuick
            // 
            lblQuick.AutoSize = true;
            lblQuick.BackColor = Color.Transparent;
            lblQuick.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblQuick.ForeColor = Color.FromArgb(31, 58, 95);
            lblQuick.Location = new Point(254, 214);
            lblQuick.Name = "lblQuick";
            lblQuick.Size = new Size(172, 32);
            lblQuick.TabIndex = 6;
            lblQuick.Text = "Quick Actions";
            // 
            // btnQuickBorrow
            // 
            btnQuickBorrow.BackColor = Color.FromArgb(42, 157, 143);
            btnQuickBorrow.Cursor = Cursors.Hand;
            btnQuickBorrow.FlatAppearance.BorderSize = 0;
            btnQuickBorrow.FlatStyle = FlatStyle.Flat;
            btnQuickBorrow.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnQuickBorrow.ForeColor = Color.FromArgb(255, 255, 255);
            btnQuickBorrow.Location = new Point(254, 246);
            btnQuickBorrow.Name = "btnQuickBorrow";
            btnQuickBorrow.Size = new Size(198, 42);
            btnQuickBorrow.TabIndex = 7;
            btnQuickBorrow.Text = "Borrow a Book";
            btnQuickBorrow.UseVisualStyleBackColor = false;
            // 
            // btnQuickReturn
            // 
            btnQuickReturn.BackColor = Color.FromArgb(31, 58, 95);
            btnQuickReturn.Cursor = Cursors.Hand;
            btnQuickReturn.FlatAppearance.BorderSize = 0;
            btnQuickReturn.FlatStyle = FlatStyle.Flat;
            btnQuickReturn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnQuickReturn.ForeColor = Color.FromArgb(255, 255, 255);
            btnQuickReturn.Location = new Point(468, 246);
            btnQuickReturn.Name = "btnQuickReturn";
            btnQuickReturn.Size = new Size(198, 42);
            btnQuickReturn.TabIndex = 8;
            btnQuickReturn.Text = "Return a Book";
            btnQuickReturn.UseVisualStyleBackColor = false;
            // 
            // btnQuickAddBook
            // 
            btnQuickAddBook.BackColor = Color.FromArgb(31, 58, 95);
            btnQuickAddBook.Cursor = Cursors.Hand;
            btnQuickAddBook.FlatAppearance.BorderSize = 0;
            btnQuickAddBook.FlatStyle = FlatStyle.Flat;
            btnQuickAddBook.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnQuickAddBook.ForeColor = Color.FromArgb(255, 255, 255);
            btnQuickAddBook.Location = new Point(682, 246);
            btnQuickAddBook.Name = "btnQuickAddBook";
            btnQuickAddBook.Size = new Size(198, 42);
            btnQuickAddBook.TabIndex = 9;
            btnQuickAddBook.Text = "Add New Book";
            btnQuickAddBook.UseVisualStyleBackColor = false;
            // 
            // btnQuickAddMember
            // 
            btnQuickAddMember.BackColor = Color.FromArgb(31, 58, 95);
            btnQuickAddMember.Cursor = Cursors.Hand;
            btnQuickAddMember.FlatAppearance.BorderSize = 0;
            btnQuickAddMember.FlatStyle = FlatStyle.Flat;
            btnQuickAddMember.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnQuickAddMember.ForeColor = Color.FromArgb(255, 255, 255);
            btnQuickAddMember.Location = new Point(896, 246);
            btnQuickAddMember.Name = "btnQuickAddMember";
            btnQuickAddMember.Size = new Size(198, 42);
            btnQuickAddMember.TabIndex = 10;
            btnQuickAddMember.Text = "Register Member";
            btnQuickAddMember.UseVisualStyleBackColor = false;
            // 
            // lblRecent
            // 
            lblRecent.AutoSize = true;
            lblRecent.BackColor = Color.Transparent;
            lblRecent.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblRecent.ForeColor = Color.FromArgb(31, 58, 95);
            lblRecent.Location = new Point(254, 312);
            lblRecent.Name = "lblRecent";
            lblRecent.Size = new Size(241, 32);
            lblRecent.TabIndex = 11;
            lblRecent.Text = "Recent Transactions";
            // 
            // dgvRecent
            // 
            dgvRecent.AllowUserToAddRows = false;
            dgvRecent.AllowUserToDeleteRows = false;
            dgvRecent.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(244, 246, 249);
            dgvRecent.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvRecent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecent.BackgroundColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(31, 58, 95);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(31, 58, 95);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvRecent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvRecent.ColumnHeadersHeight = 34;
            dgvRecent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvRecent.Columns.AddRange(new DataGridViewColumn[] { colRecentRecordID, colRecentMember, colRecentBook, colRecentBorrowDate, colRecentDueDate, colRecentStatus });
            dgvRecent.EnableHeadersVisualStyles = false;
            dgvRecent.Location = new Point(254, 344);
            dgvRecent.MultiSelect = false;
            dgvRecent.Name = "dgvRecent";
            dgvRecent.ReadOnly = true;
            dgvRecent.RowHeadersVisible = false;
            dgvRecent.RowHeadersWidth = 62;
            dgvRecent.RowTemplate.Height = 28;
            dgvRecent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecent.Size = new Size(840, 300);
            dgvRecent.TabIndex = 12;
            // 
            // colRecentRecordID
            // 
            colRecentRecordID.FillWeight = 60F;
            colRecentRecordID.HeaderText = "Record ID";
            colRecentRecordID.MinimumWidth = 8;
            colRecentRecordID.Name = "colRecentRecordID";
            colRecentRecordID.ReadOnly = true;
            // 
            // colRecentMember
            // 
            colRecentMember.FillWeight = 130F;
            colRecentMember.HeaderText = "Member";
            colRecentMember.MinimumWidth = 8;
            colRecentMember.Name = "colRecentMember";
            colRecentMember.ReadOnly = true;
            // 
            // colRecentBook
            // 
            colRecentBook.FillWeight = 160F;
            colRecentBook.HeaderText = "Book";
            colRecentBook.MinimumWidth = 8;
            colRecentBook.Name = "colRecentBook";
            colRecentBook.ReadOnly = true;
            // 
            // colRecentBorrowDate
            // 
            colRecentBorrowDate.FillWeight = 80F;
            colRecentBorrowDate.HeaderText = "Borrow Date";
            colRecentBorrowDate.MinimumWidth = 8;
            colRecentBorrowDate.Name = "colRecentBorrowDate";
            colRecentBorrowDate.ReadOnly = true;
            // 
            // colRecentDueDate
            // 
            colRecentDueDate.FillWeight = 80F;
            colRecentDueDate.HeaderText = "Due Date";
            colRecentDueDate.MinimumWidth = 8;
            colRecentDueDate.Name = "colRecentDueDate";
            colRecentDueDate.ReadOnly = true;
            // 
            // colRecentStatus
            // 
            colRecentStatus.FillWeight = 70F;
            colRecentStatus.HeaderText = "Status";
            colRecentStatus.MinimumWidth = 8;
            colRecentStatus.Name = "colRecentStatus";
            colRecentStatus.ReadOnly = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(244, 246, 249);
            ClientSize = new Size(1120, 680);
            Controls.Add(pnlSidebar);
            Controls.Add(pnlTop);
            Controls.Add(pnlCardBooks);
            Controls.Add(pnlCardMembers);
            Controls.Add(pnlCardBorrowed);
            Controls.Add(pnlCardOverdue);
            Controls.Add(lblQuick);
            Controls.Add(btnQuickBorrow);
            Controls.Add(btnQuickReturn);
            Controls.Add(btnQuickAddBook);
            Controls.Add(btnQuickAddMember);
            Controls.Add(lblRecent);
            Controls.Add(dgvRecent);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BookTrack - Dashboard";
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            pnlCardBooks.ResumeLayout(false);
            pnlCardBooks.PerformLayout();
            pnlCardMembers.ResumeLayout(false);
            pnlCardMembers.PerformLayout();
            pnlCardBorrowed.ResumeLayout(false);
            pnlCardBorrowed.PerformLayout();
            pnlCardOverdue.ResumeLayout(false);
            pnlCardOverdue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblLogoSub;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnBooks;
        private System.Windows.Forms.Button btnMembers;
        private System.Windows.Forms.Button btnBorrowReturn;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Label lblLoggedUser;
        private System.Windows.Forms.Panel pnlCardBooks;
        private System.Windows.Forms.Panel pnlStripBooks;
        private System.Windows.Forms.Label lblBooksValue;
        private System.Windows.Forms.Label lblBooksCaption;
        private System.Windows.Forms.Panel pnlCardMembers;
        private System.Windows.Forms.Panel pnlStripMembers;
        private System.Windows.Forms.Label lblMembersValue;
        private System.Windows.Forms.Label lblMembersCaption;
        private System.Windows.Forms.Panel pnlCardBorrowed;
        private System.Windows.Forms.Panel pnlStripBorrowed;
        private System.Windows.Forms.Label lblBorrowedValue;
        private System.Windows.Forms.Label lblBorrowedCaption;
        private System.Windows.Forms.Panel pnlCardOverdue;
        private System.Windows.Forms.Panel pnlStripOverdue;
        private System.Windows.Forms.Label lblOverdueValue;
        private System.Windows.Forms.Label lblOverdueCaption;
        private System.Windows.Forms.Label lblQuick;
        private System.Windows.Forms.Button btnQuickBorrow;
        private System.Windows.Forms.Button btnQuickReturn;
        private System.Windows.Forms.Button btnQuickAddBook;
        private System.Windows.Forms.Button btnQuickAddMember;
        private System.Windows.Forms.Label lblRecent;
        private System.Windows.Forms.DataGridView dgvRecent;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecentRecordID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecentMember;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecentBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecentBorrowDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecentDueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecentStatus;
        private System.Windows.Forms.DataGridViewCellStyle dgvRecentAltStyle;
        private System.Windows.Forms.DataGridViewCellStyle dgvRecentHeadStyle;
    }
}
