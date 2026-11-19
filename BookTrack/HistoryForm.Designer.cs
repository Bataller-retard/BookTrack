namespace BookTrack
{
    partial class HistoryForm
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            pnlHeader = new Panel();
            lblFormTitle = new Label();
            lblFormSubtitle = new Label();
            btnClose = new Button();
            tabHistory = new TabControl();
            tabRecords = new TabPage();
            lblStatusFilter = new Label();
            cmbStatusFilter = new ComboBox();
            lblRecordSearch = new Label();
            txtRecordSearch = new TextBox();
            btnRecordSearch = new Button();
            btnRecordReset = new Button();
            dgvRecords = new DataGridView();
            colRecordsRecordID = new DataGridViewTextBoxColumn();
            colRecordsMember = new DataGridViewTextBoxColumn();
            colRecordsBook = new DataGridViewTextBoxColumn();
            colRecordsBorrowDate = new DataGridViewTextBoxColumn();
            colRecordsDueDate = new DataGridViewTextBoxColumn();
            colRecordsReturnDate = new DataGridViewTextBoxColumn();
            colRecordsFine = new DataGridViewTextBoxColumn();
            colRecordsStatus = new DataGridViewTextBoxColumn();
            tabMemberHistory = new TabPage();
            lblHistMember = new Label();
            cmbHistMember = new ComboBox();
            btnShowHistory = new Button();
            lblHistSummary = new Label();
            dgvMemberHistory = new DataGridView();
            colMemberHistoryRecordID = new DataGridViewTextBoxColumn();
            colMemberHistoryBook = new DataGridViewTextBoxColumn();
            colMemberHistoryBorrowDate = new DataGridViewTextBoxColumn();
            colMemberHistoryDueDate = new DataGridViewTextBoxColumn();
            colMemberHistoryReturnDate = new DataGridViewTextBoxColumn();
            colMemberHistoryFine = new DataGridViewTextBoxColumn();
            colMemberHistoryStatus = new DataGridViewTextBoxColumn();
            tabOverdue = new TabPage();
            btnRefreshOverdue = new Button();
            lblOverdueSummary = new Label();
            dgvOverdue = new DataGridView();
            colOverdueRecordID = new DataGridViewTextBoxColumn();
            colOverdueMember = new DataGridViewTextBoxColumn();
            colOverdueMemberType = new DataGridViewTextBoxColumn();
            colOverdueBook = new DataGridViewTextBoxColumn();
            colOverdueDueDate = new DataGridViewTextBoxColumn();
            colOverdueDaysOverdue = new DataGridViewTextBoxColumn();
            colOverdueCurrentFine = new DataGridViewTextBoxColumn();
            pnlHeader.SuspendLayout();
            tabHistory.SuspendLayout();
            tabRecords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecords).BeginInit();
            tabMemberHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMemberHistory).BeginInit();
            tabOverdue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOverdue).BeginInit();
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
            pnlHeader.Size = new Size(1040, 81);
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
            lblFormTitle.Size = new Size(322, 45);
            lblFormTitle.TabIndex = 0;
            lblFormTitle.Text = "History and Reports";
            // 
            // lblFormSubtitle
            // 
            lblFormSubtitle.AutoSize = true;
            lblFormSubtitle.BackColor = Color.Transparent;
            lblFormSubtitle.Font = new Font("Segoe UI", 9F);
            lblFormSubtitle.ForeColor = Color.FromArgb(200, 215, 235);
            lblFormSubtitle.Location = new Point(22, 55);
            lblFormSubtitle.Name = "lblFormSubtitle";
            lblFormSubtitle.Size = new Size(450, 25);
            lblFormSubtitle.TabIndex = 1;
            lblFormSubtitle.Text = "Borrowing records, member history, and overdue items";
            lblFormSubtitle.Click += lblFormSubtitle_Click;
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
            // tabHistory
            // 
            tabHistory.Controls.Add(tabRecords);
            tabHistory.Controls.Add(tabMemberHistory);
            tabHistory.Controls.Add(tabOverdue);
            tabHistory.Location = new Point(22, 113);
            tabHistory.Name = "tabHistory";
            tabHistory.SelectedIndex = 0;
            tabHistory.Size = new Size(1000, 540);
            tabHistory.TabIndex = 1;
            // 
            // tabRecords
            // 
            tabRecords.BackColor = Color.FromArgb(255, 255, 255);
            tabRecords.Controls.Add(lblStatusFilter);
            tabRecords.Controls.Add(cmbStatusFilter);
            tabRecords.Controls.Add(lblRecordSearch);
            tabRecords.Controls.Add(txtRecordSearch);
            tabRecords.Controls.Add(btnRecordSearch);
            tabRecords.Controls.Add(btnRecordReset);
            tabRecords.Controls.Add(dgvRecords);
            tabRecords.Location = new Point(4, 37);
            tabRecords.Name = "tabRecords";
            tabRecords.Padding = new Padding(3);
            tabRecords.Size = new Size(992, 499);
            tabRecords.TabIndex = 0;
            tabRecords.Text = "All Borrow Records";
            // 
            // lblStatusFilter
            // 
            lblStatusFilter.AutoSize = true;
            lblStatusFilter.BackColor = Color.Transparent;
            lblStatusFilter.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblStatusFilter.ForeColor = Color.FromArgb(43, 47, 54);
            lblStatusFilter.Location = new Point(20, 12);
            lblStatusFilter.Name = "lblStatusFilter";
            lblStatusFilter.Size = new Size(71, 28);
            lblStatusFilter.TabIndex = 0;
            lblStatusFilter.Text = "Status";
            // 
            // cmbStatusFilter
            // 
            cmbStatusFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatusFilter.FormattingEnabled = true;
            cmbStatusFilter.Items.AddRange(new object[] { "All", "Borrowed", "Returned", "Overdue" });
            cmbStatusFilter.Location = new Point(20, 38);
            cmbStatusFilter.Name = "cmbStatusFilter";
            cmbStatusFilter.Size = new Size(160, 36);
            cmbStatusFilter.TabIndex = 1;
            // 
            // lblRecordSearch
            // 
            lblRecordSearch.AutoSize = true;
            lblRecordSearch.BackColor = Color.Transparent;
            lblRecordSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblRecordSearch.ForeColor = Color.FromArgb(43, 47, 54);
            lblRecordSearch.Location = new Point(200, 12);
            lblRecordSearch.Name = "lblRecordSearch";
            lblRecordSearch.Size = new Size(75, 28);
            lblRecordSearch.TabIndex = 2;
            lblRecordSearch.Text = "Search";
            // 
            // txtRecordSearch
            // 
            txtRecordSearch.BorderStyle = BorderStyle.FixedSingle;
            txtRecordSearch.Location = new Point(200, 38);
            txtRecordSearch.Name = "txtRecordSearch";
            txtRecordSearch.PlaceholderText = "Member name or book title...";
            txtRecordSearch.Size = new Size(300, 34);
            txtRecordSearch.TabIndex = 3;
            // 
            // btnRecordSearch
            // 
            btnRecordSearch.BackColor = Color.FromArgb(31, 58, 95);
            btnRecordSearch.Cursor = Cursors.Hand;
            btnRecordSearch.FlatAppearance.BorderSize = 0;
            btnRecordSearch.FlatStyle = FlatStyle.Flat;
            btnRecordSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRecordSearch.ForeColor = Color.FromArgb(255, 255, 255);
            btnRecordSearch.Location = new Point(510, 36);
            btnRecordSearch.Name = "btnRecordSearch";
            btnRecordSearch.Size = new Size(100, 31);
            btnRecordSearch.TabIndex = 4;
            btnRecordSearch.Text = "Search";
            btnRecordSearch.UseVisualStyleBackColor = false;
            // 
            // btnRecordReset
            // 
            btnRecordReset.BackColor = Color.FromArgb(107, 114, 128);
            btnRecordReset.Cursor = Cursors.Hand;
            btnRecordReset.FlatAppearance.BorderSize = 0;
            btnRecordReset.FlatStyle = FlatStyle.Flat;
            btnRecordReset.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRecordReset.ForeColor = Color.FromArgb(255, 255, 255);
            btnRecordReset.Location = new Point(620, 36);
            btnRecordReset.Name = "btnRecordReset";
            btnRecordReset.Size = new Size(100, 31);
            btnRecordReset.TabIndex = 5;
            btnRecordReset.Text = "Reset";
            btnRecordReset.UseVisualStyleBackColor = false;
            // 
            // dgvRecords
            // 
            dgvRecords.AllowUserToAddRows = false;
            dgvRecords.AllowUserToDeleteRows = false;
            dgvRecords.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(244, 246, 249);
            dgvRecords.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dgvRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecords.BackgroundColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(31, 58, 95);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(31, 58, 95);
            dataGridViewCellStyle8.SelectionForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvRecords.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dgvRecords.ColumnHeadersHeight = 34;
            dgvRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvRecords.Columns.AddRange(new DataGridViewColumn[] { colRecordsRecordID, colRecordsMember, colRecordsBook, colRecordsBorrowDate, colRecordsDueDate, colRecordsReturnDate, colRecordsFine, colRecordsStatus });
            dgvRecords.EnableHeadersVisualStyles = false;
            dgvRecords.Location = new Point(20, 84);
            dgvRecords.MultiSelect = false;
            dgvRecords.Name = "dgvRecords";
            dgvRecords.ReadOnly = true;
            dgvRecords.RowHeadersVisible = false;
            dgvRecords.RowHeadersWidth = 62;
            dgvRecords.RowTemplate.Height = 28;
            dgvRecords.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecords.Size = new Size(950, 400);
            dgvRecords.TabIndex = 6;
            // 
            // colRecordsRecordID
            // 
            colRecordsRecordID.FillWeight = 60F;
            colRecordsRecordID.HeaderText = "Record ID";
            colRecordsRecordID.MinimumWidth = 8;
            colRecordsRecordID.Name = "colRecordsRecordID";
            colRecordsRecordID.ReadOnly = true;
            // 
            // colRecordsMember
            // 
            colRecordsMember.FillWeight = 130F;
            colRecordsMember.HeaderText = "Member";
            colRecordsMember.MinimumWidth = 8;
            colRecordsMember.Name = "colRecordsMember";
            colRecordsMember.ReadOnly = true;
            // 
            // colRecordsBook
            // 
            colRecordsBook.FillWeight = 150F;
            colRecordsBook.HeaderText = "Book";
            colRecordsBook.MinimumWidth = 8;
            colRecordsBook.Name = "colRecordsBook";
            colRecordsBook.ReadOnly = true;
            // 
            // colRecordsBorrowDate
            // 
            colRecordsBorrowDate.FillWeight = 80F;
            colRecordsBorrowDate.HeaderText = "Borrow Date";
            colRecordsBorrowDate.MinimumWidth = 8;
            colRecordsBorrowDate.Name = "colRecordsBorrowDate";
            colRecordsBorrowDate.ReadOnly = true;
            // 
            // colRecordsDueDate
            // 
            colRecordsDueDate.FillWeight = 80F;
            colRecordsDueDate.HeaderText = "Due Date";
            colRecordsDueDate.MinimumWidth = 8;
            colRecordsDueDate.Name = "colRecordsDueDate";
            colRecordsDueDate.ReadOnly = true;
            // 
            // colRecordsReturnDate
            // 
            colRecordsReturnDate.FillWeight = 80F;
            colRecordsReturnDate.HeaderText = "Return Date";
            colRecordsReturnDate.MinimumWidth = 8;
            colRecordsReturnDate.Name = "colRecordsReturnDate";
            colRecordsReturnDate.ReadOnly = true;
            // 
            // colRecordsFine
            // 
            colRecordsFine.FillWeight = 60F;
            colRecordsFine.HeaderText = "Fine";
            colRecordsFine.MinimumWidth = 8;
            colRecordsFine.Name = "colRecordsFine";
            colRecordsFine.ReadOnly = true;
            // 
            // colRecordsStatus
            // 
            colRecordsStatus.FillWeight = 70F;
            colRecordsStatus.HeaderText = "Status";
            colRecordsStatus.MinimumWidth = 8;
            colRecordsStatus.Name = "colRecordsStatus";
            colRecordsStatus.ReadOnly = true;
            // 
            // tabMemberHistory
            // 
            tabMemberHistory.BackColor = Color.FromArgb(255, 255, 255);
            tabMemberHistory.Controls.Add(lblHistMember);
            tabMemberHistory.Controls.Add(cmbHistMember);
            tabMemberHistory.Controls.Add(btnShowHistory);
            tabMemberHistory.Controls.Add(lblHistSummary);
            tabMemberHistory.Controls.Add(dgvMemberHistory);
            tabMemberHistory.Location = new Point(4, 34);
            tabMemberHistory.Name = "tabMemberHistory";
            tabMemberHistory.Padding = new Padding(3);
            tabMemberHistory.Size = new Size(992, 502);
            tabMemberHistory.TabIndex = 1;
            tabMemberHistory.Text = "Member History";
            // 
            // lblHistMember
            // 
            lblHistMember.AutoSize = true;
            lblHistMember.BackColor = Color.Transparent;
            lblHistMember.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblHistMember.ForeColor = Color.FromArgb(43, 47, 54);
            lblHistMember.Location = new Point(20, 12);
            lblHistMember.Name = "lblHistMember";
            lblHistMember.Size = new Size(153, 28);
            lblHistMember.TabIndex = 0;
            lblHistMember.Text = "Select member";
            // 
            // cmbHistMember
            // 
            cmbHistMember.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbHistMember.FormattingEnabled = true;
            cmbHistMember.Location = new Point(20, 38);
            cmbHistMember.Name = "cmbHistMember";
            cmbHistMember.Size = new Size(320, 36);
            cmbHistMember.TabIndex = 1;
            // 
            // btnShowHistory
            // 
            btnShowHistory.BackColor = Color.FromArgb(31, 58, 95);
            btnShowHistory.Cursor = Cursors.Hand;
            btnShowHistory.FlatAppearance.BorderSize = 0;
            btnShowHistory.FlatStyle = FlatStyle.Flat;
            btnShowHistory.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnShowHistory.ForeColor = Color.FromArgb(255, 255, 255);
            btnShowHistory.Location = new Point(350, 36);
            btnShowHistory.Name = "btnShowHistory";
            btnShowHistory.Size = new Size(130, 31);
            btnShowHistory.TabIndex = 2;
            btnShowHistory.Text = "Show History";
            btnShowHistory.UseVisualStyleBackColor = false;
            // 
            // lblHistSummary
            // 
            lblHistSummary.AutoSize = true;
            lblHistSummary.BackColor = Color.Transparent;
            lblHistSummary.Font = new Font("Segoe UI", 10F);
            lblHistSummary.ForeColor = Color.FromArgb(107, 114, 128);
            lblHistSummary.Location = new Point(500, 42);
            lblHistSummary.Name = "lblHistSummary";
            lblHistSummary.Size = new Size(356, 28);
            lblHistSummary.TabIndex = 3;
            lblHistSummary.Text = "Books borrowed: 0   |   Total fines: ₱0.00";
            // 
            // dgvMemberHistory
            // 
            dgvMemberHistory.AllowUserToAddRows = false;
            dgvMemberHistory.AllowUserToDeleteRows = false;
            dgvMemberHistory.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(244, 246, 249);
            dgvMemberHistory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            dgvMemberHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMemberHistory.BackgroundColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(31, 58, 95);
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle10.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(31, 58, 95);
            dataGridViewCellStyle10.SelectionForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            dgvMemberHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dgvMemberHistory.ColumnHeadersHeight = 34;
            dgvMemberHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvMemberHistory.Columns.AddRange(new DataGridViewColumn[] { colMemberHistoryRecordID, colMemberHistoryBook, colMemberHistoryBorrowDate, colMemberHistoryDueDate, colMemberHistoryReturnDate, colMemberHistoryFine, colMemberHistoryStatus });
            dgvMemberHistory.EnableHeadersVisualStyles = false;
            dgvMemberHistory.Location = new Point(20, 84);
            dgvMemberHistory.MultiSelect = false;
            dgvMemberHistory.Name = "dgvMemberHistory";
            dgvMemberHistory.ReadOnly = true;
            dgvMemberHistory.RowHeadersVisible = false;
            dgvMemberHistory.RowHeadersWidth = 62;
            dgvMemberHistory.RowTemplate.Height = 28;
            dgvMemberHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMemberHistory.Size = new Size(950, 400);
            dgvMemberHistory.TabIndex = 4;
            // 
            // colMemberHistoryRecordID
            // 
            colMemberHistoryRecordID.FillWeight = 60F;
            colMemberHistoryRecordID.HeaderText = "Record ID";
            colMemberHistoryRecordID.MinimumWidth = 8;
            colMemberHistoryRecordID.Name = "colMemberHistoryRecordID";
            colMemberHistoryRecordID.ReadOnly = true;
            // 
            // colMemberHistoryBook
            // 
            colMemberHistoryBook.FillWeight = 170F;
            colMemberHistoryBook.HeaderText = "Book";
            colMemberHistoryBook.MinimumWidth = 8;
            colMemberHistoryBook.Name = "colMemberHistoryBook";
            colMemberHistoryBook.ReadOnly = true;
            // 
            // colMemberHistoryBorrowDate
            // 
            colMemberHistoryBorrowDate.FillWeight = 80F;
            colMemberHistoryBorrowDate.HeaderText = "Borrow Date";
            colMemberHistoryBorrowDate.MinimumWidth = 8;
            colMemberHistoryBorrowDate.Name = "colMemberHistoryBorrowDate";
            colMemberHistoryBorrowDate.ReadOnly = true;
            // 
            // colMemberHistoryDueDate
            // 
            colMemberHistoryDueDate.FillWeight = 80F;
            colMemberHistoryDueDate.HeaderText = "Due Date";
            colMemberHistoryDueDate.MinimumWidth = 8;
            colMemberHistoryDueDate.Name = "colMemberHistoryDueDate";
            colMemberHistoryDueDate.ReadOnly = true;
            // 
            // colMemberHistoryReturnDate
            // 
            colMemberHistoryReturnDate.FillWeight = 80F;
            colMemberHistoryReturnDate.HeaderText = "Return Date";
            colMemberHistoryReturnDate.MinimumWidth = 8;
            colMemberHistoryReturnDate.Name = "colMemberHistoryReturnDate";
            colMemberHistoryReturnDate.ReadOnly = true;
            // 
            // colMemberHistoryFine
            // 
            colMemberHistoryFine.FillWeight = 60F;
            colMemberHistoryFine.HeaderText = "Fine";
            colMemberHistoryFine.MinimumWidth = 8;
            colMemberHistoryFine.Name = "colMemberHistoryFine";
            colMemberHistoryFine.ReadOnly = true;
            // 
            // colMemberHistoryStatus
            // 
            colMemberHistoryStatus.FillWeight = 70F;
            colMemberHistoryStatus.HeaderText = "Status";
            colMemberHistoryStatus.MinimumWidth = 8;
            colMemberHistoryStatus.Name = "colMemberHistoryStatus";
            colMemberHistoryStatus.ReadOnly = true;
            // 
            // tabOverdue
            // 
            tabOverdue.BackColor = Color.FromArgb(255, 255, 255);
            tabOverdue.Controls.Add(btnRefreshOverdue);
            tabOverdue.Controls.Add(lblOverdueSummary);
            tabOverdue.Controls.Add(dgvOverdue);
            tabOverdue.Location = new Point(4, 34);
            tabOverdue.Name = "tabOverdue";
            tabOverdue.Padding = new Padding(3);
            tabOverdue.Size = new Size(992, 502);
            tabOverdue.TabIndex = 2;
            tabOverdue.Text = "Overdue Items";
            // 
            // btnRefreshOverdue
            // 
            btnRefreshOverdue.BackColor = Color.FromArgb(31, 58, 95);
            btnRefreshOverdue.Cursor = Cursors.Hand;
            btnRefreshOverdue.FlatAppearance.BorderSize = 0;
            btnRefreshOverdue.FlatStyle = FlatStyle.Flat;
            btnRefreshOverdue.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRefreshOverdue.ForeColor = Color.FromArgb(255, 255, 255);
            btnRefreshOverdue.Location = new Point(20, 12);
            btnRefreshOverdue.Name = "btnRefreshOverdue";
            btnRefreshOverdue.Size = new Size(120, 31);
            btnRefreshOverdue.TabIndex = 0;
            btnRefreshOverdue.Text = "Refresh";
            btnRefreshOverdue.UseVisualStyleBackColor = false;
            // 
            // lblOverdueSummary
            // 
            lblOverdueSummary.AutoSize = true;
            lblOverdueSummary.BackColor = Color.Transparent;
            lblOverdueSummary.Font = new Font("Segoe UI", 10F);
            lblOverdueSummary.ForeColor = Color.FromArgb(107, 114, 128);
            lblOverdueSummary.Location = new Point(160, 18);
            lblOverdueSummary.Name = "lblOverdueSummary";
            lblOverdueSummary.Size = new Size(377, 28);
            lblOverdueSummary.TabIndex = 1;
            lblOverdueSummary.Text = "Overdue items: 0   |   Total fines due: ₱0.00";
            // 
            // dgvOverdue
            // 
            dgvOverdue.AllowUserToAddRows = false;
            dgvOverdue.AllowUserToDeleteRows = false;
            dgvOverdue.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(244, 246, 249);
            dgvOverdue.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            dgvOverdue.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOverdue.BackgroundColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = Color.FromArgb(31, 58, 95);
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle12.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(31, 58, 95);
            dataGridViewCellStyle12.SelectionForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.False;
            dgvOverdue.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            dgvOverdue.ColumnHeadersHeight = 34;
            dgvOverdue.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvOverdue.Columns.AddRange(new DataGridViewColumn[] { colOverdueRecordID, colOverdueMember, colOverdueMemberType, colOverdueBook, colOverdueDueDate, colOverdueDaysOverdue, colOverdueCurrentFine });
            dgvOverdue.EnableHeadersVisualStyles = false;
            dgvOverdue.Location = new Point(20, 60);
            dgvOverdue.MultiSelect = false;
            dgvOverdue.Name = "dgvOverdue";
            dgvOverdue.ReadOnly = true;
            dgvOverdue.RowHeadersVisible = false;
            dgvOverdue.RowHeadersWidth = 62;
            dgvOverdue.RowTemplate.Height = 28;
            dgvOverdue.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOverdue.Size = new Size(950, 424);
            dgvOverdue.TabIndex = 2;
            // 
            // colOverdueRecordID
            // 
            colOverdueRecordID.FillWeight = 60F;
            colOverdueRecordID.HeaderText = "Record ID";
            colOverdueRecordID.MinimumWidth = 8;
            colOverdueRecordID.Name = "colOverdueRecordID";
            colOverdueRecordID.ReadOnly = true;
            // 
            // colOverdueMember
            // 
            colOverdueMember.FillWeight = 130F;
            colOverdueMember.HeaderText = "Member";
            colOverdueMember.MinimumWidth = 8;
            colOverdueMember.Name = "colOverdueMember";
            colOverdueMember.ReadOnly = true;
            // 
            // colOverdueMemberType
            // 
            colOverdueMemberType.FillWeight = 80F;
            colOverdueMemberType.HeaderText = "Member Type";
            colOverdueMemberType.MinimumWidth = 8;
            colOverdueMemberType.Name = "colOverdueMemberType";
            colOverdueMemberType.ReadOnly = true;
            // 
            // colOverdueBook
            // 
            colOverdueBook.FillWeight = 150F;
            colOverdueBook.HeaderText = "Book";
            colOverdueBook.MinimumWidth = 8;
            colOverdueBook.Name = "colOverdueBook";
            colOverdueBook.ReadOnly = true;
            // 
            // colOverdueDueDate
            // 
            colOverdueDueDate.FillWeight = 80F;
            colOverdueDueDate.HeaderText = "Due Date";
            colOverdueDueDate.MinimumWidth = 8;
            colOverdueDueDate.Name = "colOverdueDueDate";
            colOverdueDueDate.ReadOnly = true;
            // 
            // colOverdueDaysOverdue
            // 
            colOverdueDaysOverdue.FillWeight = 70F;
            colOverdueDaysOverdue.HeaderText = "Days Overdue";
            colOverdueDaysOverdue.MinimumWidth = 8;
            colOverdueDaysOverdue.Name = "colOverdueDaysOverdue";
            colOverdueDaysOverdue.ReadOnly = true;
            // 
            // colOverdueCurrentFine
            // 
            colOverdueCurrentFine.FillWeight = 70F;
            colOverdueCurrentFine.HeaderText = "Current Fine";
            colOverdueCurrentFine.MinimumWidth = 8;
            colOverdueCurrentFine.Name = "colOverdueCurrentFine";
            colOverdueCurrentFine.ReadOnly = true;
            // 
            // HistoryForm
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(244, 246, 249);
            ClientSize = new Size(1166, 722);
            Controls.Add(pnlHeader);
            Controls.Add(tabHistory);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "HistoryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BookTrack - History & Reports";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            tabHistory.ResumeLayout(false);
            tabRecords.ResumeLayout(false);
            tabRecords.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecords).EndInit();
            tabMemberHistory.ResumeLayout(false);
            tabMemberHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMemberHistory).EndInit();
            tabOverdue.ResumeLayout(false);
            tabOverdue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOverdue).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Label lblFormSubtitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TabControl tabHistory;
        private System.Windows.Forms.TabPage tabRecords;
        private System.Windows.Forms.TabPage tabMemberHistory;
        private System.Windows.Forms.TabPage tabOverdue;
        private System.Windows.Forms.Label lblStatusFilter;
        private System.Windows.Forms.ComboBox cmbStatusFilter;
        private System.Windows.Forms.Label lblRecordSearch;
        private System.Windows.Forms.TextBox txtRecordSearch;
        private System.Windows.Forms.Button btnRecordSearch;
        private System.Windows.Forms.Button btnRecordReset;
        private System.Windows.Forms.DataGridView dgvRecords;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecordsRecordID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecordsMember;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecordsBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecordsBorrowDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecordsDueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecordsReturnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecordsFine;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecordsStatus;
        private System.Windows.Forms.DataGridViewCellStyle dgvRecordsAltStyle;
        private System.Windows.Forms.DataGridViewCellStyle dgvRecordsHeadStyle;
        private System.Windows.Forms.Label lblHistMember;
        private System.Windows.Forms.ComboBox cmbHistMember;
        private System.Windows.Forms.Button btnShowHistory;
        private System.Windows.Forms.Label lblHistSummary;
        private System.Windows.Forms.DataGridView dgvMemberHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemberHistoryRecordID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemberHistoryBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemberHistoryBorrowDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemberHistoryDueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemberHistoryReturnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemberHistoryFine;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemberHistoryStatus;
        private System.Windows.Forms.DataGridViewCellStyle dgvMemberHistoryAltStyle;
        private System.Windows.Forms.DataGridViewCellStyle dgvMemberHistoryHeadStyle;
        private System.Windows.Forms.Button btnRefreshOverdue;
        private System.Windows.Forms.Label lblOverdueSummary;
        private System.Windows.Forms.DataGridView dgvOverdue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOverdueRecordID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOverdueMember;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOverdueMemberType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOverdueBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOverdueDueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOverdueDaysOverdue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOverdueCurrentFine;
        private System.Windows.Forms.DataGridViewCellStyle dgvOverdueAltStyle;
        private System.Windows.Forms.DataGridViewCellStyle dgvOverdueHeadStyle;
    }
}
