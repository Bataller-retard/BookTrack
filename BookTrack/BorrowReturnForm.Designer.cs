namespace BookTrack
{
    partial class BorrowReturnForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pnlHeader = new Panel();
            lblFormTitle = new Label();
            lblFormSubtitle = new Label();
            btnClose = new Button();
            tabBorrowReturn = new TabControl();
            tabBorrow = new TabPage();
            grpSelectMember = new GroupBox();
            lblMember = new Label();
            cmbMember = new ComboBox();
            lblMemberTypeCaption = new Label();
            lblMemberTypeValue = new Label();
            lblLoanLimitCaption = new Label();
            lblLoanLimitValue = new Label();
            lblLoanPeriodCaption = new Label();
            lblLoanPeriodValue = new Label();
            lblFinePerDayCaption = new Label();
            lblFinePerDayValue = new Label();
            lblActiveLoansCaption = new Label();
            lblActiveLoansValue = new Label();
            grpSelectBook = new GroupBox();
            lblBook = new Label();
            cmbBook = new ComboBox();
            lblBookAuthorCaption = new Label();
            lblBookAuthorValue = new Label();
            lblBookCategoryCaption = new Label();
            lblBookCategoryValue = new Label();
            lblCopiesAvailableCaption = new Label();
            lblCopiesAvailableValue = new Label();
            grpLoanDetails = new GroupBox();
            lblBorrowDate = new Label();
            dtpBorrowDate = new DateTimePicker();
            lblDueDate = new Label();
            dtpDueDate = new DateTimePicker();
            lblLoanNote = new Label();
            btnBorrow = new Button();
            btnClearBorrow = new Button();
            tabReturn = new TabPage();
            lblFindLoan = new Label();
            txtReturnSearch = new TextBox();
            btnReturnSearch = new Button();
            btnReturnShowAll = new Button();
            dgvActiveLoans = new DataGridView();
            colActiveLoansRecordID = new DataGridViewTextBoxColumn();
            colActiveLoansMember = new DataGridViewTextBoxColumn();
            colActiveLoansBook = new DataGridViewTextBoxColumn();
            colActiveLoansBorrowDate = new DataGridViewTextBoxColumn();
            colActiveLoansDueDate = new DataGridViewTextBoxColumn();
            colActiveLoansDaysLate = new DataGridViewTextBoxColumn();
            grpReturnSummary = new GroupBox();
            lblReturnDate = new Label();
            dtpReturnDate = new DateTimePicker();
            lblDaysLateCaption = new Label();
            lblDaysLateValue = new Label();
            lblFineCaption = new Label();
            lblFineValue = new Label();
            btnReturn = new Button();
            pnlHeader.SuspendLayout();
            tabBorrowReturn.SuspendLayout();
            tabBorrow.SuspendLayout();
            grpSelectMember.SuspendLayout();
            grpSelectBook.SuspendLayout();
            grpLoanDetails.SuspendLayout();
            tabReturn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvActiveLoans).BeginInit();
            grpReturnSummary.SuspendLayout();
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
            pnlHeader.Size = new Size(1040, 87);
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
            lblFormTitle.Size = new Size(265, 45);
            lblFormTitle.TabIndex = 0;
            lblFormTitle.Text = "Borrow / Return";
            // 
            // lblFormSubtitle
            // 
            lblFormSubtitle.AutoSize = true;
            lblFormSubtitle.BackColor = Color.Transparent;
            lblFormSubtitle.Font = new Font("Segoe UI", 9F);
            lblFormSubtitle.ForeColor = Color.FromArgb(200, 215, 235);
            lblFormSubtitle.Location = new Point(20, 55);
            lblFormSubtitle.Name = "lblFormSubtitle";
            lblFormSubtitle.Size = new Size(261, 25);
            lblFormSubtitle.TabIndex = 1;
            lblFormSubtitle.Text = "Process book loans and returns";
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
            // tabBorrowReturn
            // 
            tabBorrowReturn.Controls.Add(tabBorrow);
            tabBorrowReturn.Controls.Add(tabReturn);
            tabBorrowReturn.Location = new Point(20, 113);
            tabBorrowReturn.Name = "tabBorrowReturn";
            tabBorrowReturn.SelectedIndex = 0;
            tabBorrowReturn.Size = new Size(1000, 540);
            tabBorrowReturn.TabIndex = 1;
            // 
            // tabBorrow
            // 
            tabBorrow.BackColor = Color.FromArgb(255, 255, 255);
            tabBorrow.Controls.Add(grpSelectMember);
            tabBorrow.Controls.Add(grpSelectBook);
            tabBorrow.Controls.Add(grpLoanDetails);
            tabBorrow.Location = new Point(4, 37);
            tabBorrow.Name = "tabBorrow";
            tabBorrow.Padding = new Padding(3);
            tabBorrow.Size = new Size(992, 499);
            tabBorrow.TabIndex = 0;
            tabBorrow.Text = "Borrow Book";
            // 
            // grpSelectMember
            // 
            grpSelectMember.BackColor = Color.FromArgb(255, 255, 255);
            grpSelectMember.Controls.Add(lblMember);
            grpSelectMember.Controls.Add(cmbMember);
            grpSelectMember.Controls.Add(lblMemberTypeCaption);
            grpSelectMember.Controls.Add(lblMemberTypeValue);
            grpSelectMember.Controls.Add(lblLoanLimitCaption);
            grpSelectMember.Controls.Add(lblLoanLimitValue);
            grpSelectMember.Controls.Add(lblLoanPeriodCaption);
            grpSelectMember.Controls.Add(lblLoanPeriodValue);
            grpSelectMember.Controls.Add(lblFinePerDayCaption);
            grpSelectMember.Controls.Add(lblFinePerDayValue);
            grpSelectMember.Controls.Add(lblActiveLoansCaption);
            grpSelectMember.Controls.Add(lblActiveLoansValue);
            grpSelectMember.Location = new Point(20, 16);
            grpSelectMember.Name = "grpSelectMember";
            grpSelectMember.Size = new Size(460, 250);
            grpSelectMember.TabIndex = 0;
            grpSelectMember.TabStop = false;
            grpSelectMember.Text = "1. Select Member";
            // 
            // lblMember
            // 
            lblMember.AutoSize = true;
            lblMember.BackColor = Color.Transparent;
            lblMember.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblMember.ForeColor = Color.FromArgb(43, 47, 54);
            lblMember.Location = new Point(15, 15);
            lblMember.Name = "lblMember";
            lblMember.Size = new Size(91, 28);
            lblMember.TabIndex = 0;
            lblMember.Text = "Member";
            // 
            // cmbMember
            // 
            cmbMember.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbMember.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbMember.FormattingEnabled = true;
            cmbMember.Location = new Point(15, 39);
            cmbMember.Name = "cmbMember";
            cmbMember.Size = new Size(420, 36);
            cmbMember.TabIndex = 1;
            // 
            // lblMemberTypeCaption
            // 
            lblMemberTypeCaption.AutoSize = true;
            lblMemberTypeCaption.BackColor = Color.Transparent;
            lblMemberTypeCaption.Font = new Font("Segoe UI", 10F);
            lblMemberTypeCaption.ForeColor = Color.FromArgb(107, 114, 128);
            lblMemberTypeCaption.Location = new Point(15, 85);
            lblMemberTypeCaption.Name = "lblMemberTypeCaption";
            lblMemberTypeCaption.Size = new Size(134, 28);
            lblMemberTypeCaption.TabIndex = 2;
            lblMemberTypeCaption.Text = "Member type:";
            // 
            // lblMemberTypeValue
            // 
            lblMemberTypeValue.AutoSize = true;
            lblMemberTypeValue.BackColor = Color.Transparent;
            lblMemberTypeValue.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblMemberTypeValue.ForeColor = Color.FromArgb(43, 47, 54);
            lblMemberTypeValue.Location = new Point(187, 85);
            lblMemberTypeValue.Name = "lblMemberTypeValue";
            lblMemberTypeValue.Size = new Size(20, 28);
            lblMemberTypeValue.TabIndex = 3;
            lblMemberTypeValue.Text = "-";
            // 
            // lblLoanLimitCaption
            // 
            lblLoanLimitCaption.AutoSize = true;
            lblLoanLimitCaption.BackColor = Color.Transparent;
            lblLoanLimitCaption.Font = new Font("Segoe UI", 10F);
            lblLoanLimitCaption.ForeColor = Color.FromArgb(107, 114, 128);
            lblLoanLimitCaption.Location = new Point(15, 113);
            lblLoanLimitCaption.Name = "lblLoanLimitCaption";
            lblLoanLimitCaption.Size = new Size(102, 28);
            lblLoanLimitCaption.TabIndex = 4;
            lblLoanLimitCaption.Text = "Loan limit:";
            // 
            // lblLoanLimitValue
            // 
            lblLoanLimitValue.AutoSize = true;
            lblLoanLimitValue.BackColor = Color.Transparent;
            lblLoanLimitValue.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblLoanLimitValue.ForeColor = Color.FromArgb(43, 47, 54);
            lblLoanLimitValue.Location = new Point(187, 113);
            lblLoanLimitValue.Name = "lblLoanLimitValue";
            lblLoanLimitValue.Size = new Size(20, 28);
            lblLoanLimitValue.TabIndex = 5;
            lblLoanLimitValue.Text = "-";
            // 
            // lblLoanPeriodCaption
            // 
            lblLoanPeriodCaption.AutoSize = true;
            lblLoanPeriodCaption.BackColor = Color.Transparent;
            lblLoanPeriodCaption.Font = new Font("Segoe UI", 10F);
            lblLoanPeriodCaption.ForeColor = Color.FromArgb(107, 114, 128);
            lblLoanPeriodCaption.Location = new Point(15, 141);
            lblLoanPeriodCaption.Name = "lblLoanPeriodCaption";
            lblLoanPeriodCaption.Size = new Size(121, 28);
            lblLoanPeriodCaption.TabIndex = 6;
            lblLoanPeriodCaption.Text = "Loan period:";
            // 
            // lblLoanPeriodValue
            // 
            lblLoanPeriodValue.AutoSize = true;
            lblLoanPeriodValue.BackColor = Color.Transparent;
            lblLoanPeriodValue.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblLoanPeriodValue.ForeColor = Color.FromArgb(43, 47, 54);
            lblLoanPeriodValue.Location = new Point(187, 141);
            lblLoanPeriodValue.Name = "lblLoanPeriodValue";
            lblLoanPeriodValue.Size = new Size(20, 28);
            lblLoanPeriodValue.TabIndex = 7;
            lblLoanPeriodValue.Text = "-";
            // 
            // lblFinePerDayCaption
            // 
            lblFinePerDayCaption.AutoSize = true;
            lblFinePerDayCaption.BackColor = Color.Transparent;
            lblFinePerDayCaption.Font = new Font("Segoe UI", 10F);
            lblFinePerDayCaption.ForeColor = Color.FromArgb(107, 114, 128);
            lblFinePerDayCaption.Location = new Point(15, 169);
            lblFinePerDayCaption.Name = "lblFinePerDayCaption";
            lblFinePerDayCaption.Size = new Size(123, 28);
            lblFinePerDayCaption.TabIndex = 8;
            lblFinePerDayCaption.Text = "Fine per day:";
            // 
            // lblFinePerDayValue
            // 
            lblFinePerDayValue.AutoSize = true;
            lblFinePerDayValue.BackColor = Color.Transparent;
            lblFinePerDayValue.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFinePerDayValue.ForeColor = Color.FromArgb(43, 47, 54);
            lblFinePerDayValue.Location = new Point(187, 169);
            lblFinePerDayValue.Name = "lblFinePerDayValue";
            lblFinePerDayValue.Size = new Size(20, 28);
            lblFinePerDayValue.TabIndex = 9;
            lblFinePerDayValue.Text = "-";
            // 
            // lblActiveLoansCaption
            // 
            lblActiveLoansCaption.AutoSize = true;
            lblActiveLoansCaption.BackColor = Color.Transparent;
            lblActiveLoansCaption.Font = new Font("Segoe UI", 10F);
            lblActiveLoansCaption.ForeColor = Color.FromArgb(107, 114, 128);
            lblActiveLoansCaption.Location = new Point(15, 197);
            lblActiveLoansCaption.Name = "lblActiveLoansCaption";
            lblActiveLoansCaption.Size = new Size(187, 28);
            lblActiveLoansCaption.TabIndex = 10;
            lblActiveLoansCaption.Text = "Currently borrowed:";
            // 
            // lblActiveLoansValue
            // 
            lblActiveLoansValue.AutoSize = true;
            lblActiveLoansValue.BackColor = Color.Transparent;
            lblActiveLoansValue.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblActiveLoansValue.ForeColor = Color.FromArgb(43, 47, 54);
            lblActiveLoansValue.Location = new Point(187, 197);
            lblActiveLoansValue.Name = "lblActiveLoansValue";
            lblActiveLoansValue.Size = new Size(20, 28);
            lblActiveLoansValue.TabIndex = 11;
            lblActiveLoansValue.Text = "-";
            // 
            // grpSelectBook
            // 
            grpSelectBook.BackColor = Color.FromArgb(255, 255, 255);
            grpSelectBook.Controls.Add(lblBook);
            grpSelectBook.Controls.Add(cmbBook);
            grpSelectBook.Controls.Add(lblBookAuthorCaption);
            grpSelectBook.Controls.Add(lblBookAuthorValue);
            grpSelectBook.Controls.Add(lblBookCategoryCaption);
            grpSelectBook.Controls.Add(lblBookCategoryValue);
            grpSelectBook.Controls.Add(lblCopiesAvailableCaption);
            grpSelectBook.Controls.Add(lblCopiesAvailableValue);
            grpSelectBook.Location = new Point(500, 16);
            grpSelectBook.Name = "grpSelectBook";
            grpSelectBook.Size = new Size(470, 250);
            grpSelectBook.TabIndex = 1;
            grpSelectBook.TabStop = false;
            grpSelectBook.Text = "2. Select Book";
            // 
            // lblBook
            // 
            lblBook.AutoSize = true;
            lblBook.BackColor = Color.Transparent;
            lblBook.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblBook.ForeColor = Color.FromArgb(43, 47, 54);
            lblBook.Location = new Point(15, 15);
            lblBook.Name = "lblBook";
            lblBook.Size = new Size(60, 28);
            lblBook.TabIndex = 0;
            lblBook.Text = "Book";
            // 
            // cmbBook
            // 
            cmbBook.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbBook.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbBook.FormattingEnabled = true;
            cmbBook.Location = new Point(15, 39);
            cmbBook.Name = "cmbBook";
            cmbBook.Size = new Size(430, 36);
            cmbBook.TabIndex = 1;
            // 
            // lblBookAuthorCaption
            // 
            lblBookAuthorCaption.AutoSize = true;
            lblBookAuthorCaption.BackColor = Color.Transparent;
            lblBookAuthorCaption.Font = new Font("Segoe UI", 10F);
            lblBookAuthorCaption.ForeColor = Color.FromArgb(107, 114, 128);
            lblBookAuthorCaption.Location = new Point(15, 85);
            lblBookAuthorCaption.Name = "lblBookAuthorCaption";
            lblBookAuthorCaption.Size = new Size(77, 28);
            lblBookAuthorCaption.TabIndex = 2;
            lblBookAuthorCaption.Text = "Author:";
            // 
            // lblBookAuthorValue
            // 
            lblBookAuthorValue.AutoSize = true;
            lblBookAuthorValue.BackColor = Color.Transparent;
            lblBookAuthorValue.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblBookAuthorValue.ForeColor = Color.FromArgb(43, 47, 54);
            lblBookAuthorValue.Location = new Point(187, 85);
            lblBookAuthorValue.Name = "lblBookAuthorValue";
            lblBookAuthorValue.Size = new Size(20, 28);
            lblBookAuthorValue.TabIndex = 3;
            lblBookAuthorValue.Text = "-";
            // 
            // lblBookCategoryCaption
            // 
            lblBookCategoryCaption.AutoSize = true;
            lblBookCategoryCaption.BackColor = Color.Transparent;
            lblBookCategoryCaption.Font = new Font("Segoe UI", 10F);
            lblBookCategoryCaption.ForeColor = Color.FromArgb(107, 114, 128);
            lblBookCategoryCaption.Location = new Point(15, 113);
            lblBookCategoryCaption.Name = "lblBookCategoryCaption";
            lblBookCategoryCaption.Size = new Size(96, 28);
            lblBookCategoryCaption.TabIndex = 4;
            lblBookCategoryCaption.Text = "Category:";
            // 
            // lblBookCategoryValue
            // 
            lblBookCategoryValue.AutoSize = true;
            lblBookCategoryValue.BackColor = Color.Transparent;
            lblBookCategoryValue.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblBookCategoryValue.ForeColor = Color.FromArgb(43, 47, 54);
            lblBookCategoryValue.Location = new Point(187, 113);
            lblBookCategoryValue.Name = "lblBookCategoryValue";
            lblBookCategoryValue.Size = new Size(20, 28);
            lblBookCategoryValue.TabIndex = 5;
            lblBookCategoryValue.Text = "-";
            // 
            // lblCopiesAvailableCaption
            // 
            lblCopiesAvailableCaption.AutoSize = true;
            lblCopiesAvailableCaption.BackColor = Color.Transparent;
            lblCopiesAvailableCaption.Font = new Font("Segoe UI", 10F);
            lblCopiesAvailableCaption.ForeColor = Color.FromArgb(107, 114, 128);
            lblCopiesAvailableCaption.Location = new Point(15, 141);
            lblCopiesAvailableCaption.Name = "lblCopiesAvailableCaption";
            lblCopiesAvailableCaption.Size = new Size(157, 28);
            lblCopiesAvailableCaption.TabIndex = 6;
            lblCopiesAvailableCaption.Text = "Copies available:";
            // 
            // lblCopiesAvailableValue
            // 
            lblCopiesAvailableValue.AutoSize = true;
            lblCopiesAvailableValue.BackColor = Color.Transparent;
            lblCopiesAvailableValue.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCopiesAvailableValue.ForeColor = Color.FromArgb(43, 47, 54);
            lblCopiesAvailableValue.Location = new Point(187, 141);
            lblCopiesAvailableValue.Name = "lblCopiesAvailableValue";
            lblCopiesAvailableValue.Size = new Size(20, 28);
            lblCopiesAvailableValue.TabIndex = 7;
            lblCopiesAvailableValue.Text = "-";
            // 
            // grpLoanDetails
            // 
            grpLoanDetails.BackColor = Color.FromArgb(255, 255, 255);
            grpLoanDetails.Controls.Add(lblBorrowDate);
            grpLoanDetails.Controls.Add(dtpBorrowDate);
            grpLoanDetails.Controls.Add(lblDueDate);
            grpLoanDetails.Controls.Add(dtpDueDate);
            grpLoanDetails.Controls.Add(lblLoanNote);
            grpLoanDetails.Controls.Add(btnBorrow);
            grpLoanDetails.Controls.Add(btnClearBorrow);
            grpLoanDetails.Location = new Point(20, 282);
            grpLoanDetails.Name = "grpLoanDetails";
            grpLoanDetails.Size = new Size(950, 160);
            grpLoanDetails.TabIndex = 2;
            grpLoanDetails.TabStop = false;
            grpLoanDetails.Text = "3. Loan Details";
            // 
            // lblBorrowDate
            // 
            lblBorrowDate.AutoSize = true;
            lblBorrowDate.BackColor = Color.Transparent;
            lblBorrowDate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblBorrowDate.ForeColor = Color.FromArgb(43, 47, 54);
            lblBorrowDate.Location = new Point(15, 15);
            lblBorrowDate.Name = "lblBorrowDate";
            lblBorrowDate.Size = new Size(129, 28);
            lblBorrowDate.TabIndex = 0;
            lblBorrowDate.Text = "Borrow date";
            // 
            // dtpBorrowDate
            // 
            dtpBorrowDate.Enabled = false;
            dtpBorrowDate.Format = DateTimePickerFormat.Short;
            dtpBorrowDate.Location = new Point(15, 39);
            dtpBorrowDate.Name = "dtpBorrowDate";
            dtpBorrowDate.Size = new Size(200, 34);
            dtpBorrowDate.TabIndex = 1;
            // 
            // lblDueDate
            // 
            lblDueDate.AutoSize = true;
            lblDueDate.BackColor = Color.Transparent;
            lblDueDate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDueDate.ForeColor = Color.FromArgb(43, 47, 54);
            lblDueDate.Location = new Point(247, 15);
            lblDueDate.Name = "lblDueDate";
            lblDueDate.Size = new Size(98, 28);
            lblDueDate.TabIndex = 2;
            lblDueDate.Text = "Due date";
            // 
            // dtpDueDate
            // 
            dtpDueDate.Enabled = false;
            dtpDueDate.Format = DateTimePickerFormat.Short;
            dtpDueDate.Location = new Point(247, 39);
            dtpDueDate.Name = "dtpDueDate";
            dtpDueDate.Size = new Size(200, 34);
            dtpDueDate.TabIndex = 3;
            // 
            // lblLoanNote
            // 
            lblLoanNote.AutoSize = true;
            lblLoanNote.BackColor = Color.Transparent;
            lblLoanNote.Font = new Font("Segoe UI", 9F);
            lblLoanNote.ForeColor = Color.FromArgb(107, 114, 128);
            lblLoanNote.Location = new Point(477, 43);
            lblLoanNote.Name = "lblLoanNote";
            lblLoanNote.Size = new Size(484, 25);
            lblLoanNote.TabIndex = 4;
            lblLoanNote.Text = "Due date is calculated automatically from the member type.";
            // 
            // btnBorrow
            // 
            btnBorrow.BackColor = Color.FromArgb(42, 157, 143);
            btnBorrow.Cursor = Cursors.Hand;
            btnBorrow.FlatAppearance.BorderSize = 0;
            btnBorrow.FlatStyle = FlatStyle.Flat;
            btnBorrow.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBorrow.ForeColor = Color.FromArgb(255, 255, 255);
            btnBorrow.Location = new Point(15, 85);
            btnBorrow.Name = "btnBorrow";
            btnBorrow.Size = new Size(200, 42);
            btnBorrow.TabIndex = 5;
            btnBorrow.Text = "Confirm Borrow";
            btnBorrow.UseVisualStyleBackColor = false;
            // 
            // btnClearBorrow
            // 
            btnClearBorrow.BackColor = Color.FromArgb(107, 114, 128);
            btnClearBorrow.Cursor = Cursors.Hand;
            btnClearBorrow.FlatAppearance.BorderSize = 0;
            btnClearBorrow.FlatStyle = FlatStyle.Flat;
            btnClearBorrow.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClearBorrow.ForeColor = Color.FromArgb(255, 255, 255);
            btnClearBorrow.Location = new Point(229, 85);
            btnClearBorrow.Name = "btnClearBorrow";
            btnClearBorrow.Size = new Size(120, 42);
            btnClearBorrow.TabIndex = 6;
            btnClearBorrow.Text = "Clear";
            btnClearBorrow.UseVisualStyleBackColor = false;
            // 
            // tabReturn
            // 
            tabReturn.BackColor = Color.FromArgb(255, 255, 255);
            tabReturn.Controls.Add(lblFindLoan);
            tabReturn.Controls.Add(txtReturnSearch);
            tabReturn.Controls.Add(btnReturnSearch);
            tabReturn.Controls.Add(btnReturnShowAll);
            tabReturn.Controls.Add(dgvActiveLoans);
            tabReturn.Controls.Add(grpReturnSummary);
            tabReturn.Location = new Point(4, 34);
            tabReturn.Name = "tabReturn";
            tabReturn.Padding = new Padding(3);
            tabReturn.Size = new Size(992, 502);
            tabReturn.TabIndex = 1;
            tabReturn.Text = "Return Book";
            // 
            // lblFindLoan
            // 
            lblFindLoan.AutoSize = true;
            lblFindLoan.BackColor = Color.Transparent;
            lblFindLoan.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFindLoan.ForeColor = Color.FromArgb(43, 47, 54);
            lblFindLoan.Location = new Point(20, 12);
            lblFindLoan.Name = "lblFindLoan";
            lblFindLoan.Size = new Size(162, 28);
            lblFindLoan.TabIndex = 0;
            lblFindLoan.Text = "Find active loan";
            // 
            // txtReturnSearch
            // 
            txtReturnSearch.BorderStyle = BorderStyle.FixedSingle;
            txtReturnSearch.Location = new Point(20, 40);
            txtReturnSearch.Name = "txtReturnSearch";
            txtReturnSearch.PlaceholderText = "Member name or book title...";
            txtReturnSearch.Size = new Size(330, 34);
            txtReturnSearch.TabIndex = 1;
            // 
            // btnReturnSearch
            // 
            btnReturnSearch.BackColor = Color.FromArgb(31, 58, 95);
            btnReturnSearch.Cursor = Cursors.Hand;
            btnReturnSearch.FlatAppearance.BorderSize = 0;
            btnReturnSearch.FlatStyle = FlatStyle.Flat;
            btnReturnSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnReturnSearch.ForeColor = Color.FromArgb(255, 255, 255);
            btnReturnSearch.Location = new Point(360, 38);
            btnReturnSearch.Name = "btnReturnSearch";
            btnReturnSearch.Size = new Size(100, 31);
            btnReturnSearch.TabIndex = 2;
            btnReturnSearch.Text = "Search";
            btnReturnSearch.UseVisualStyleBackColor = false;
            // 
            // btnReturnShowAll
            // 
            btnReturnShowAll.BackColor = Color.FromArgb(107, 114, 128);
            btnReturnShowAll.Cursor = Cursors.Hand;
            btnReturnShowAll.FlatAppearance.BorderSize = 0;
            btnReturnShowAll.FlatStyle = FlatStyle.Flat;
            btnReturnShowAll.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnReturnShowAll.ForeColor = Color.FromArgb(255, 255, 255);
            btnReturnShowAll.Location = new Point(470, 38);
            btnReturnShowAll.Name = "btnReturnShowAll";
            btnReturnShowAll.Size = new Size(110, 31);
            btnReturnShowAll.TabIndex = 3;
            btnReturnShowAll.Text = "Show All";
            btnReturnShowAll.UseVisualStyleBackColor = false;
            // 
            // dgvActiveLoans
            // 
            dgvActiveLoans.AllowUserToAddRows = false;
            dgvActiveLoans.AllowUserToDeleteRows = false;
            dgvActiveLoans.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(244, 246, 249);
            dgvActiveLoans.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvActiveLoans.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvActiveLoans.BackgroundColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(31, 58, 95);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(31, 58, 95);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvActiveLoans.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvActiveLoans.ColumnHeadersHeight = 34;
            dgvActiveLoans.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvActiveLoans.Columns.AddRange(new DataGridViewColumn[] { colActiveLoansRecordID, colActiveLoansMember, colActiveLoansBook, colActiveLoansBorrowDate, colActiveLoansDueDate, colActiveLoansDaysLate });
            dgvActiveLoans.EnableHeadersVisualStyles = false;
            dgvActiveLoans.Location = new Point(20, 84);
            dgvActiveLoans.MultiSelect = false;
            dgvActiveLoans.Name = "dgvActiveLoans";
            dgvActiveLoans.ReadOnly = true;
            dgvActiveLoans.RowHeadersVisible = false;
            dgvActiveLoans.RowHeadersWidth = 62;
            dgvActiveLoans.RowTemplate.Height = 28;
            dgvActiveLoans.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvActiveLoans.Size = new Size(950, 220);
            dgvActiveLoans.TabIndex = 4;
            // 
            // colActiveLoansRecordID
            // 
            colActiveLoansRecordID.FillWeight = 60F;
            colActiveLoansRecordID.HeaderText = "Record ID";
            colActiveLoansRecordID.MinimumWidth = 8;
            colActiveLoansRecordID.Name = "colActiveLoansRecordID";
            colActiveLoansRecordID.ReadOnly = true;
            // 
            // colActiveLoansMember
            // 
            colActiveLoansMember.FillWeight = 130F;
            colActiveLoansMember.HeaderText = "Member";
            colActiveLoansMember.MinimumWidth = 8;
            colActiveLoansMember.Name = "colActiveLoansMember";
            colActiveLoansMember.ReadOnly = true;
            // 
            // colActiveLoansBook
            // 
            colActiveLoansBook.FillWeight = 160F;
            colActiveLoansBook.HeaderText = "Book";
            colActiveLoansBook.MinimumWidth = 8;
            colActiveLoansBook.Name = "colActiveLoansBook";
            colActiveLoansBook.ReadOnly = true;
            // 
            // colActiveLoansBorrowDate
            // 
            colActiveLoansBorrowDate.FillWeight = 80F;
            colActiveLoansBorrowDate.HeaderText = "Borrow Date";
            colActiveLoansBorrowDate.MinimumWidth = 8;
            colActiveLoansBorrowDate.Name = "colActiveLoansBorrowDate";
            colActiveLoansBorrowDate.ReadOnly = true;
            // 
            // colActiveLoansDueDate
            // 
            colActiveLoansDueDate.FillWeight = 80F;
            colActiveLoansDueDate.HeaderText = "Due Date";
            colActiveLoansDueDate.MinimumWidth = 8;
            colActiveLoansDueDate.Name = "colActiveLoansDueDate";
            colActiveLoansDueDate.ReadOnly = true;
            // 
            // colActiveLoansDaysLate
            // 
            colActiveLoansDaysLate.FillWeight = 60F;
            colActiveLoansDaysLate.HeaderText = "Days Late";
            colActiveLoansDaysLate.MinimumWidth = 8;
            colActiveLoansDaysLate.Name = "colActiveLoansDaysLate";
            colActiveLoansDaysLate.ReadOnly = true;
            // 
            // grpReturnSummary
            // 
            grpReturnSummary.BackColor = Color.FromArgb(255, 255, 255);
            grpReturnSummary.Controls.Add(lblReturnDate);
            grpReturnSummary.Controls.Add(dtpReturnDate);
            grpReturnSummary.Controls.Add(lblDaysLateCaption);
            grpReturnSummary.Controls.Add(lblDaysLateValue);
            grpReturnSummary.Controls.Add(lblFineCaption);
            grpReturnSummary.Controls.Add(lblFineValue);
            grpReturnSummary.Controls.Add(btnReturn);
            grpReturnSummary.Location = new Point(20, 322);
            grpReturnSummary.Name = "grpReturnSummary";
            grpReturnSummary.Size = new Size(950, 160);
            grpReturnSummary.TabIndex = 5;
            grpReturnSummary.TabStop = false;
            grpReturnSummary.Text = "Return Summary";
            // 
            // lblReturnDate
            // 
            lblReturnDate.AutoSize = true;
            lblReturnDate.BackColor = Color.Transparent;
            lblReturnDate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblReturnDate.ForeColor = Color.FromArgb(43, 47, 54);
            lblReturnDate.Location = new Point(15, 15);
            lblReturnDate.Name = "lblReturnDate";
            lblReturnDate.Size = new Size(124, 28);
            lblReturnDate.TabIndex = 0;
            lblReturnDate.Text = "Return date";
            // 
            // dtpReturnDate
            // 
            dtpReturnDate.Enabled = false;
            dtpReturnDate.Format = DateTimePickerFormat.Short;
            dtpReturnDate.Location = new Point(15, 39);
            dtpReturnDate.Name = "dtpReturnDate";
            dtpReturnDate.Size = new Size(200, 34);
            dtpReturnDate.TabIndex = 1;
            // 
            // lblDaysLateCaption
            // 
            lblDaysLateCaption.AutoSize = true;
            lblDaysLateCaption.BackColor = Color.Transparent;
            lblDaysLateCaption.Font = new Font("Segoe UI", 10F);
            lblDaysLateCaption.ForeColor = Color.FromArgb(107, 114, 128);
            lblDaysLateCaption.Location = new Point(277, 21);
            lblDaysLateCaption.Name = "lblDaysLateCaption";
            lblDaysLateCaption.Size = new Size(95, 28);
            lblDaysLateCaption.TabIndex = 2;
            lblDaysLateCaption.Text = "Days late:";
            // 
            // lblDaysLateValue
            // 
            lblDaysLateValue.AutoSize = true;
            lblDaysLateValue.BackColor = Color.Transparent;
            lblDaysLateValue.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDaysLateValue.ForeColor = Color.FromArgb(43, 47, 54);
            lblDaysLateValue.Location = new Point(417, 21);
            lblDaysLateValue.Name = "lblDaysLateValue";
            lblDaysLateValue.Size = new Size(24, 28);
            lblDaysLateValue.TabIndex = 3;
            lblDaysLateValue.Text = "0";
            // 
            // lblFineCaption
            // 
            lblFineCaption.AutoSize = true;
            lblFineCaption.BackColor = Color.Transparent;
            lblFineCaption.Font = new Font("Segoe UI", 10F);
            lblFineCaption.ForeColor = Color.FromArgb(107, 114, 128);
            lblFineCaption.Location = new Point(277, 59);
            lblFineCaption.Name = "lblFineCaption";
            lblFineCaption.Size = new Size(90, 28);
            lblFineCaption.TabIndex = 4;
            lblFineCaption.Text = "Fine due:";
            // 
            // lblFineValue
            // 
            lblFineValue.AutoSize = true;
            lblFineValue.BackColor = Color.Transparent;
            lblFineValue.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblFineValue.ForeColor = Color.FromArgb(214, 69, 69);
            lblFineValue.Location = new Point(417, 53);
            lblFineValue.Name = "lblFineValue";
            lblFineValue.Size = new Size(91, 38);
            lblFineValue.TabIndex = 5;
            lblFineValue.Text = "₱0.00";
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.FromArgb(42, 157, 143);
            btnReturn.Cursor = Cursors.Hand;
            btnReturn.FlatAppearance.BorderSize = 0;
            btnReturn.FlatStyle = FlatStyle.Flat;
            btnReturn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnReturn.ForeColor = Color.FromArgb(255, 255, 255);
            btnReturn.Location = new Point(15, 85);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(200, 42);
            btnReturn.TabIndex = 6;
            btnReturn.Text = "Confirm Return";
            btnReturn.UseVisualStyleBackColor = false;
            // 
            // BorrowReturnForm
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(244, 246, 249);
            ClientSize = new Size(1114, 705);
            Controls.Add(pnlHeader);
            Controls.Add(tabBorrowReturn);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "BorrowReturnForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BookTrack - Borrow / Return";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            tabBorrowReturn.ResumeLayout(false);
            tabBorrow.ResumeLayout(false);
            grpSelectMember.ResumeLayout(false);
            grpSelectMember.PerformLayout();
            grpSelectBook.ResumeLayout(false);
            grpSelectBook.PerformLayout();
            grpLoanDetails.ResumeLayout(false);
            grpLoanDetails.PerformLayout();
            tabReturn.ResumeLayout(false);
            tabReturn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvActiveLoans).EndInit();
            grpReturnSummary.ResumeLayout(false);
            grpReturnSummary.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Label lblFormSubtitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TabControl tabBorrowReturn;
        private System.Windows.Forms.TabPage tabBorrow;
        private System.Windows.Forms.TabPage tabReturn;
        private System.Windows.Forms.GroupBox grpSelectMember;
        private System.Windows.Forms.Label lblMember;
        private System.Windows.Forms.ComboBox cmbMember;
        private System.Windows.Forms.Label lblMemberTypeCaption;
        private System.Windows.Forms.Label lblMemberTypeValue;
        private System.Windows.Forms.Label lblLoanLimitCaption;
        private System.Windows.Forms.Label lblLoanLimitValue;
        private System.Windows.Forms.Label lblLoanPeriodCaption;
        private System.Windows.Forms.Label lblLoanPeriodValue;
        private System.Windows.Forms.Label lblFinePerDayCaption;
        private System.Windows.Forms.Label lblFinePerDayValue;
        private System.Windows.Forms.Label lblActiveLoansCaption;
        private System.Windows.Forms.Label lblActiveLoansValue;
        private System.Windows.Forms.GroupBox grpSelectBook;
        private System.Windows.Forms.Label lblBook;
        private System.Windows.Forms.ComboBox cmbBook;
        private System.Windows.Forms.Label lblBookAuthorCaption;
        private System.Windows.Forms.Label lblBookAuthorValue;
        private System.Windows.Forms.Label lblBookCategoryCaption;
        private System.Windows.Forms.Label lblBookCategoryValue;
        private System.Windows.Forms.Label lblCopiesAvailableCaption;
        private System.Windows.Forms.Label lblCopiesAvailableValue;
        private System.Windows.Forms.GroupBox grpLoanDetails;
        private System.Windows.Forms.Label lblBorrowDate;
        private System.Windows.Forms.DateTimePicker dtpBorrowDate;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.Label lblLoanNote;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.Button btnClearBorrow;
        private System.Windows.Forms.Label lblFindLoan;
        private System.Windows.Forms.TextBox txtReturnSearch;
        private System.Windows.Forms.Button btnReturnSearch;
        private System.Windows.Forms.Button btnReturnShowAll;
        private System.Windows.Forms.DataGridView dgvActiveLoans;
        private System.Windows.Forms.DataGridViewTextBoxColumn colActiveLoansRecordID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colActiveLoansMember;
        private System.Windows.Forms.DataGridViewTextBoxColumn colActiveLoansBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn colActiveLoansBorrowDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colActiveLoansDueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colActiveLoansDaysLate;
        private System.Windows.Forms.DataGridViewCellStyle dgvActiveLoansAltStyle;
        private System.Windows.Forms.DataGridViewCellStyle dgvActiveLoansHeadStyle;
        private System.Windows.Forms.GroupBox grpReturnSummary;
        private System.Windows.Forms.Label lblReturnDate;
        private System.Windows.Forms.DateTimePicker dtpReturnDate;
        private System.Windows.Forms.Label lblDaysLateCaption;
        private System.Windows.Forms.Label lblDaysLateValue;
        private System.Windows.Forms.Label lblFineCaption;
        private System.Windows.Forms.Label lblFineValue;
        private System.Windows.Forms.Button btnReturn;
    }
}
