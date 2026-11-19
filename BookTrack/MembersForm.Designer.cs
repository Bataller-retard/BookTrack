namespace BookTrack
{
    partial class MembersForm
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.lblFormSubtitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpMemberDetails = new System.Windows.Forms.GroupBox();
            this.lblMemberId = new System.Windows.Forms.Label();
            this.txtMemberId = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblContactNo = new System.Windows.Forms.Label();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.lblMemberType = new System.Windows.Forms.Label();
            this.cmbMemberType = new System.Windows.Forms.ComboBox();
            this.pnlRules = new System.Windows.Forms.Panel();
            this.lblRules = new System.Windows.Forms.Label();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.btnUpdateMember = new System.Windows.Forms.Button();
            this.btnDeleteMember = new System.Windows.Forms.Button();
            this.btnClearMember = new System.Windows.Forms.Button();
            this.txtSearchMember = new System.Windows.Forms.TextBox();
            this.btnSearchMember = new System.Windows.Forms.Button();
            this.btnShowAllMembers = new System.Windows.Forms.Button();
            this.dgvMembers = new System.Windows.Forms.DataGridView();
            this.colMembersMemberID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMembersFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMembersContactNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMembersMemberType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMembersActiveLoans = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMembersAltStyle = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvMembersHeadStyle = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblMemberCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.grpMemberDetails.SuspendLayout();
            this.pnlRules.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblFormTitle);
            this.pnlHeader.Controls.Add(this.lblFormSubtitle);
            this.pnlHeader.Controls.Add(this.btnClose);
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(31, 58, 95);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1040, 64);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.lblFormTitle.Location = new System.Drawing.Point(20, 10);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.TabIndex = 0;
            this.lblFormTitle.Text = "Member Management";
            // 
            // lblFormSubtitle
            // 
            this.lblFormSubtitle.BackColor = System.Drawing.Color.Transparent;
            this.lblFormSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFormSubtitle.ForeColor = System.Drawing.Color.FromArgb(200, 215, 235);
            this.lblFormSubtitle.Location = new System.Drawing.Point(22, 40);
            this.lblFormSubtitle.Name = "lblFormSubtitle";
            this.lblFormSubtitle.AutoSize = true;
            this.lblFormSubtitle.TabIndex = 1;
            this.lblFormSubtitle.Text = "Register, update, delete, and search library members";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(31, 58, 95);
            this.btnClose.Location = new System.Drawing.Point(900, 15);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 34);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // grpMemberDetails
            // 
            this.grpMemberDetails.Controls.Add(this.lblMemberId);
            this.grpMemberDetails.Controls.Add(this.txtMemberId);
            this.grpMemberDetails.Controls.Add(this.lblFullName);
            this.grpMemberDetails.Controls.Add(this.txtFullName);
            this.grpMemberDetails.Controls.Add(this.lblContactNo);
            this.grpMemberDetails.Controls.Add(this.txtContactNo);
            this.grpMemberDetails.Controls.Add(this.lblMemberType);
            this.grpMemberDetails.Controls.Add(this.cmbMemberType);
            this.grpMemberDetails.Controls.Add(this.pnlRules);
            this.grpMemberDetails.Controls.Add(this.btnAddMember);
            this.grpMemberDetails.Controls.Add(this.btnUpdateMember);
            this.grpMemberDetails.Controls.Add(this.btnDeleteMember);
            this.grpMemberDetails.Controls.Add(this.btnClearMember);
            this.grpMemberDetails.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.grpMemberDetails.Location = new System.Drawing.Point(20, 84);
            this.grpMemberDetails.Name = "grpMemberDetails";
            this.grpMemberDetails.Size = new System.Drawing.Size(330, 510);
            this.grpMemberDetails.TabIndex = 1;
            this.grpMemberDetails.Text = "Member Details";
            this.grpMemberDetails.TabStop = false;
            // 
            // lblMemberId
            // 
            this.lblMemberId.BackColor = System.Drawing.Color.Transparent;
            this.lblMemberId.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMemberId.ForeColor = System.Drawing.Color.FromArgb(43, 47, 54);
            this.lblMemberId.Location = new System.Drawing.Point(15, 15);
            this.lblMemberId.Name = "lblMemberId";
            this.lblMemberId.AutoSize = true;
            this.lblMemberId.TabIndex = 0;
            this.lblMemberId.Text = "Member ID";
            // 
            // txtMemberId
            // 
            this.txtMemberId.Location = new System.Drawing.Point(15, 39);
            this.txtMemberId.Name = "txtMemberId";
            this.txtMemberId.Size = new System.Drawing.Size(290, 27);
            this.txtMemberId.TabIndex = 1;
            this.txtMemberId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMemberId.PlaceholderText = "Auto-generated";
            this.txtMemberId.ReadOnly = true;
            // 
            // lblFullName
            // 
            this.lblFullName.BackColor = System.Drawing.Color.Transparent;
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFullName.ForeColor = System.Drawing.Color.FromArgb(43, 47, 54);
            this.lblFullName.Location = new System.Drawing.Point(15, 79);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.AutoSize = true;
            this.lblFullName.TabIndex = 2;
            this.lblFullName.Text = "Full Name";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(15, 103);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(290, 27);
            this.txtFullName.TabIndex = 3;
            this.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // lblContactNo
            // 
            this.lblContactNo.BackColor = System.Drawing.Color.Transparent;
            this.lblContactNo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblContactNo.ForeColor = System.Drawing.Color.FromArgb(43, 47, 54);
            this.lblContactNo.Location = new System.Drawing.Point(15, 143);
            this.lblContactNo.Name = "lblContactNo";
            this.lblContactNo.AutoSize = true;
            this.lblContactNo.TabIndex = 4;
            this.lblContactNo.Text = "Contact No.";
            // 
            // txtContactNo
            // 
            this.txtContactNo.Location = new System.Drawing.Point(15, 167);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(290, 27);
            this.txtContactNo.TabIndex = 5;
            this.txtContactNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // lblMemberType
            // 
            this.lblMemberType.BackColor = System.Drawing.Color.Transparent;
            this.lblMemberType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMemberType.ForeColor = System.Drawing.Color.FromArgb(43, 47, 54);
            this.lblMemberType.Location = new System.Drawing.Point(15, 207);
            this.lblMemberType.Name = "lblMemberType";
            this.lblMemberType.AutoSize = true;
            this.lblMemberType.TabIndex = 6;
            this.lblMemberType.Text = "Member Type";
            // 
            // cmbMemberType
            // 
            this.cmbMemberType.Location = new System.Drawing.Point(15, 231);
            this.cmbMemberType.Name = "cmbMemberType";
            this.cmbMemberType.Size = new System.Drawing.Size(290, 27);
            this.cmbMemberType.TabIndex = 7;
            this.cmbMemberType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMemberType.FormattingEnabled = true;
            this.cmbMemberType.Items.AddRange(new object[] {
            "Student",
            "Faculty"});
            // 
            // pnlRules
            // 
            this.pnlRules.Controls.Add(this.lblRules);
            this.pnlRules.BackColor = System.Drawing.Color.FromArgb(232, 240, 250);
            this.pnlRules.Location = new System.Drawing.Point(15, 277);
            this.pnlRules.Name = "pnlRules";
            this.pnlRules.Size = new System.Drawing.Size(290, 86);
            this.pnlRules.TabIndex = 8;
            // 
            // lblRules
            // 
            this.lblRules.BackColor = System.Drawing.Color.Transparent;
            this.lblRules.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRules.ForeColor = System.Drawing.Color.FromArgb(31, 58, 95);
            this.lblRules.Location = new System.Drawing.Point(10, 8);
            this.lblRules.Name = "lblRules";
            this.lblRules.AutoSize = true;
            this.lblRules.TabIndex = 0;
            this.lblRules.Text = "Borrowing rules\nStudent: 3 books, 7 days, \u20B15/day fine\nFaculty: 5 books, 14 days, \u20B12/day fine";
            // 
            // btnAddMember
            // 
            this.btnAddMember.BackColor = System.Drawing.Color.FromArgb(42, 157, 143);
            this.btnAddMember.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddMember.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnAddMember.Location = new System.Drawing.Point(15, 381);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(136, 40);
            this.btnAddMember.TabIndex = 9;
            this.btnAddMember.Text = "Register";
            this.btnAddMember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddMember.FlatAppearance.BorderSize = 0;
            this.btnAddMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMember.UseVisualStyleBackColor = false;
            // 
            // btnUpdateMember
            // 
            this.btnUpdateMember.BackColor = System.Drawing.Color.FromArgb(31, 58, 95);
            this.btnUpdateMember.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateMember.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnUpdateMember.Location = new System.Drawing.Point(169, 381);
            this.btnUpdateMember.Name = "btnUpdateMember";
            this.btnUpdateMember.Size = new System.Drawing.Size(136, 40);
            this.btnUpdateMember.TabIndex = 10;
            this.btnUpdateMember.Text = "Update";
            this.btnUpdateMember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateMember.FlatAppearance.BorderSize = 0;
            this.btnUpdateMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateMember.UseVisualStyleBackColor = false;
            // 
            // btnDeleteMember
            // 
            this.btnDeleteMember.BackColor = System.Drawing.Color.FromArgb(214, 69, 69);
            this.btnDeleteMember.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteMember.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnDeleteMember.Location = new System.Drawing.Point(15, 431);
            this.btnDeleteMember.Name = "btnDeleteMember";
            this.btnDeleteMember.Size = new System.Drawing.Size(136, 40);
            this.btnDeleteMember.TabIndex = 11;
            this.btnDeleteMember.Text = "Delete";
            this.btnDeleteMember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteMember.FlatAppearance.BorderSize = 0;
            this.btnDeleteMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteMember.UseVisualStyleBackColor = false;
            // 
            // btnClearMember
            // 
            this.btnClearMember.BackColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.btnClearMember.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClearMember.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnClearMember.Location = new System.Drawing.Point(169, 431);
            this.btnClearMember.Name = "btnClearMember";
            this.btnClearMember.Size = new System.Drawing.Size(136, 40);
            this.btnClearMember.TabIndex = 12;
            this.btnClearMember.Text = "Clear";
            this.btnClearMember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearMember.FlatAppearance.BorderSize = 0;
            this.btnClearMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearMember.UseVisualStyleBackColor = false;
            // 
            // txtSearchMember
            // 
            this.txtSearchMember.Location = new System.Drawing.Point(370, 90);
            this.txtSearchMember.Name = "txtSearchMember";
            this.txtSearchMember.Size = new System.Drawing.Size(300, 27);
            this.txtSearchMember.TabIndex = 2;
            this.txtSearchMember.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchMember.PlaceholderText = "Search by name or member ID...";
            // 
            // btnSearchMember
            // 
            this.btnSearchMember.BackColor = System.Drawing.Color.FromArgb(31, 58, 95);
            this.btnSearchMember.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearchMember.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnSearchMember.Location = new System.Drawing.Point(680, 88);
            this.btnSearchMember.Name = "btnSearchMember";
            this.btnSearchMember.Size = new System.Drawing.Size(100, 31);
            this.btnSearchMember.TabIndex = 3;
            this.btnSearchMember.Text = "Search";
            this.btnSearchMember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchMember.FlatAppearance.BorderSize = 0;
            this.btnSearchMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchMember.UseVisualStyleBackColor = false;
            // 
            // btnShowAllMembers
            // 
            this.btnShowAllMembers.BackColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.btnShowAllMembers.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnShowAllMembers.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnShowAllMembers.Location = new System.Drawing.Point(790, 88);
            this.btnShowAllMembers.Name = "btnShowAllMembers";
            this.btnShowAllMembers.Size = new System.Drawing.Size(110, 31);
            this.btnShowAllMembers.TabIndex = 4;
            this.btnShowAllMembers.Text = "Show All";
            this.btnShowAllMembers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowAllMembers.FlatAppearance.BorderSize = 0;
            this.btnShowAllMembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAllMembers.UseVisualStyleBackColor = false;
            // 
            // dgvMembers
            // 
            this.dgvMembers.AllowUserToAddRows = false;
            this.dgvMembers.AllowUserToDeleteRows = false;
            this.dgvMembers.AllowUserToResizeRows = false;
            this.dgvMembers.AlternatingRowsDefaultCellStyle = this.dgvMembersAltStyle;
            this.dgvMembers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMembers.BackgroundColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.dgvMembers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvMembers.ColumnHeadersDefaultCellStyle = this.dgvMembersHeadStyle;
            this.dgvMembers.ColumnHeadersHeight = 34;
            this.dgvMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMembers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMembersMemberID,
            this.colMembersFullName,
            this.colMembersContactNo,
            this.colMembersMemberType,
            this.colMembersActiveLoans});
            this.dgvMembers.EnableHeadersVisualStyles = false;
            this.dgvMembers.MultiSelect = false;
            this.dgvMembers.ReadOnly = true;
            this.dgvMembers.RowHeadersVisible = false;
            this.dgvMembers.RowTemplate.Height = 28;
            this.dgvMembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMembers.Location = new System.Drawing.Point(370, 135);
            this.dgvMembers.Name = "dgvMembers";
            this.dgvMembers.Size = new System.Drawing.Size(650, 440);
            this.dgvMembers.TabIndex = 5;
            // 
            // dgvMembersHeadStyle
            // 
            this.dgvMembersHeadStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvMembersHeadStyle.BackColor = System.Drawing.Color.FromArgb(31, 58, 95);
            this.dgvMembersHeadStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dgvMembersHeadStyle.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.dgvMembersHeadStyle.SelectionBackColor = System.Drawing.Color.FromArgb(31, 58, 95);
            this.dgvMembersHeadStyle.SelectionForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.dgvMembersHeadStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dgvMembersAltStyle
            // 
            this.dgvMembersAltStyle.BackColor = System.Drawing.Color.FromArgb(244, 246, 249);
            // 
            // colMembersMemberID
            // 
            this.colMembersMemberID.FillWeight = 60F;
            this.colMembersMemberID.HeaderText = "Member ID";
            this.colMembersMemberID.Name = "colMembersMemberID";
            this.colMembersMemberID.ReadOnly = true;
            // 
            // colMembersFullName
            // 
            this.colMembersFullName.FillWeight = 160F;
            this.colMembersFullName.HeaderText = "Full Name";
            this.colMembersFullName.Name = "colMembersFullName";
            this.colMembersFullName.ReadOnly = true;
            // 
            // colMembersContactNo
            // 
            this.colMembersContactNo.FillWeight = 100F;
            this.colMembersContactNo.HeaderText = "Contact No.";
            this.colMembersContactNo.Name = "colMembersContactNo";
            this.colMembersContactNo.ReadOnly = true;
            // 
            // colMembersMemberType
            // 
            this.colMembersMemberType.FillWeight = 80F;
            this.colMembersMemberType.HeaderText = "Member Type";
            this.colMembersMemberType.Name = "colMembersMemberType";
            this.colMembersMemberType.ReadOnly = true;
            // 
            // colMembersActiveLoans
            // 
            this.colMembersActiveLoans.FillWeight = 70F;
            this.colMembersActiveLoans.HeaderText = "Active Loans";
            this.colMembersActiveLoans.Name = "colMembersActiveLoans";
            this.colMembersActiveLoans.ReadOnly = true;
            // 
            // lblMemberCount
            // 
            this.lblMemberCount.BackColor = System.Drawing.Color.Transparent;
            this.lblMemberCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMemberCount.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblMemberCount.Location = new System.Drawing.Point(370, 588);
            this.lblMemberCount.Name = "lblMemberCount";
            this.lblMemberCount.AutoSize = true;
            this.lblMemberCount.TabIndex = 6;
            this.lblMemberCount.Text = "Total members: 0";
            // 
            // MembersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(244, 246, 249);
            this.ClientSize = new System.Drawing.Size(1040, 640);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.grpMemberDetails);
            this.Controls.Add(this.txtSearchMember);
            this.Controls.Add(this.btnSearchMember);
            this.Controls.Add(this.btnShowAllMembers);
            this.Controls.Add(this.dgvMembers);
            this.Controls.Add(this.lblMemberCount);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MembersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookTrack - Member Management";
            this.pnlHeader.ResumeLayout(false);
            this.grpMemberDetails.ResumeLayout(false);
            this.pnlRules.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Label lblFormSubtitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox grpMemberDetails;
        private System.Windows.Forms.Label lblMemberId;
        private System.Windows.Forms.TextBox txtMemberId;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblContactNo;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.Label lblMemberType;
        private System.Windows.Forms.ComboBox cmbMemberType;
        private System.Windows.Forms.Panel pnlRules;
        private System.Windows.Forms.Label lblRules;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.Button btnUpdateMember;
        private System.Windows.Forms.Button btnDeleteMember;
        private System.Windows.Forms.Button btnClearMember;
        private System.Windows.Forms.TextBox txtSearchMember;
        private System.Windows.Forms.Button btnSearchMember;
        private System.Windows.Forms.Button btnShowAllMembers;
        private System.Windows.Forms.DataGridView dgvMembers;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMembersMemberID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMembersFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMembersContactNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMembersMemberType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMembersActiveLoans;
        private System.Windows.Forms.DataGridViewCellStyle dgvMembersAltStyle;
        private System.Windows.Forms.DataGridViewCellStyle dgvMembersHeadStyle;
        private System.Windows.Forms.Label lblMemberCount;
    }
}
