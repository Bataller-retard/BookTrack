namespace BookTrack
{
    partial class StaffForm
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
            this.grpStaffDetails = new System.Windows.Forms.GroupBox();
            this.lblUserId = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.lblStaffUsername = new System.Windows.Forms.Label();
            this.txtStaffUsername = new System.Windows.Forms.TextBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.lblStaffPassword = new System.Windows.Forms.Label();
            this.txtStaffPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.btnUpdateStaff = new System.Windows.Forms.Button();
            this.btnDeleteStaff = new System.Windows.Forms.Button();
            this.btnClearStaff = new System.Windows.Forms.Button();
            this.dgvStaff = new System.Windows.Forms.DataGridView();
            this.colStaffUserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStaffUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStaffRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvStaffAltStyle = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvStaffHeadStyle = new System.Windows.Forms.DataGridViewCellStyle();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.grpStaffDetails.SuspendLayout();
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
            this.pnlHeader.Size = new System.Drawing.Size(920, 64);
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
            this.lblFormTitle.Text = "Staff Accounts";
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
            this.lblFormSubtitle.Text = "Admin only: manage librarian and admin logins";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(31, 58, 95);
            this.btnClose.Location = new System.Drawing.Point(780, 15);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 34);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // grpStaffDetails
            // 
            this.grpStaffDetails.Controls.Add(this.lblUserId);
            this.grpStaffDetails.Controls.Add(this.txtUserId);
            this.grpStaffDetails.Controls.Add(this.lblStaffUsername);
            this.grpStaffDetails.Controls.Add(this.txtStaffUsername);
            this.grpStaffDetails.Controls.Add(this.lblRole);
            this.grpStaffDetails.Controls.Add(this.cmbRole);
            this.grpStaffDetails.Controls.Add(this.lblStaffPassword);
            this.grpStaffDetails.Controls.Add(this.txtStaffPassword);
            this.grpStaffDetails.Controls.Add(this.lblConfirmPassword);
            this.grpStaffDetails.Controls.Add(this.txtConfirmPassword);
            this.grpStaffDetails.Controls.Add(this.btnAddStaff);
            this.grpStaffDetails.Controls.Add(this.btnUpdateStaff);
            this.grpStaffDetails.Controls.Add(this.btnDeleteStaff);
            this.grpStaffDetails.Controls.Add(this.btnClearStaff);
            this.grpStaffDetails.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.grpStaffDetails.Location = new System.Drawing.Point(20, 84);
            this.grpStaffDetails.Name = "grpStaffDetails";
            this.grpStaffDetails.Size = new System.Drawing.Size(330, 490);
            this.grpStaffDetails.TabIndex = 1;
            this.grpStaffDetails.Text = "Account Details";
            this.grpStaffDetails.TabStop = false;
            // 
            // lblUserId
            // 
            this.lblUserId.BackColor = System.Drawing.Color.Transparent;
            this.lblUserId.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUserId.ForeColor = System.Drawing.Color.FromArgb(43, 47, 54);
            this.lblUserId.Location = new System.Drawing.Point(15, 15);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.AutoSize = true;
            this.lblUserId.TabIndex = 0;
            this.lblUserId.Text = "User ID";
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(15, 39);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(290, 27);
            this.txtUserId.TabIndex = 1;
            this.txtUserId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserId.PlaceholderText = "Auto-generated";
            this.txtUserId.ReadOnly = true;
            // 
            // lblStaffUsername
            // 
            this.lblStaffUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblStaffUsername.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStaffUsername.ForeColor = System.Drawing.Color.FromArgb(43, 47, 54);
            this.lblStaffUsername.Location = new System.Drawing.Point(15, 79);
            this.lblStaffUsername.Name = "lblStaffUsername";
            this.lblStaffUsername.AutoSize = true;
            this.lblStaffUsername.TabIndex = 2;
            this.lblStaffUsername.Text = "Username";
            // 
            // txtStaffUsername
            // 
            this.txtStaffUsername.Location = new System.Drawing.Point(15, 103);
            this.txtStaffUsername.Name = "txtStaffUsername";
            this.txtStaffUsername.Size = new System.Drawing.Size(290, 27);
            this.txtStaffUsername.TabIndex = 3;
            this.txtStaffUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // lblRole
            // 
            this.lblRole.BackColor = System.Drawing.Color.Transparent;
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRole.ForeColor = System.Drawing.Color.FromArgb(43, 47, 54);
            this.lblRole.Location = new System.Drawing.Point(15, 143);
            this.lblRole.Name = "lblRole";
            this.lblRole.AutoSize = true;
            this.lblRole.TabIndex = 4;
            this.lblRole.Text = "Role";
            // 
            // cmbRole
            // 
            this.cmbRole.Location = new System.Drawing.Point(15, 167);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(290, 27);
            this.cmbRole.TabIndex = 5;
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Items.AddRange(new object[] {
            "Admin",
            "Librarian"});
            // 
            // lblStaffPassword
            // 
            this.lblStaffPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblStaffPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStaffPassword.ForeColor = System.Drawing.Color.FromArgb(43, 47, 54);
            this.lblStaffPassword.Location = new System.Drawing.Point(15, 207);
            this.lblStaffPassword.Name = "lblStaffPassword";
            this.lblStaffPassword.AutoSize = true;
            this.lblStaffPassword.TabIndex = 6;
            this.lblStaffPassword.Text = "Password";
            // 
            // txtStaffPassword
            // 
            this.txtStaffPassword.Location = new System.Drawing.Point(15, 231);
            this.txtStaffPassword.Name = "txtStaffPassword";
            this.txtStaffPassword.Size = new System.Drawing.Size(290, 27);
            this.txtStaffPassword.TabIndex = 7;
            this.txtStaffPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStaffPassword.UseSystemPasswordChar = true;
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(43, 47, 54);
            this.lblConfirmPassword.Location = new System.Drawing.Point(15, 271);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.TabIndex = 8;
            this.lblConfirmPassword.Text = "Confirm Password";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(15, 295);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(290, 27);
            this.txtConfirmPassword.TabIndex = 9;
            this.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.BackColor = System.Drawing.Color.FromArgb(42, 157, 143);
            this.btnAddStaff.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddStaff.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnAddStaff.Location = new System.Drawing.Point(15, 361);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(136, 40);
            this.btnAddStaff.TabIndex = 10;
            this.btnAddStaff.Text = "Add";
            this.btnAddStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddStaff.FlatAppearance.BorderSize = 0;
            this.btnAddStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStaff.UseVisualStyleBackColor = false;
            // 
            // btnUpdateStaff
            // 
            this.btnUpdateStaff.BackColor = System.Drawing.Color.FromArgb(31, 58, 95);
            this.btnUpdateStaff.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateStaff.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnUpdateStaff.Location = new System.Drawing.Point(169, 361);
            this.btnUpdateStaff.Name = "btnUpdateStaff";
            this.btnUpdateStaff.Size = new System.Drawing.Size(136, 40);
            this.btnUpdateStaff.TabIndex = 11;
            this.btnUpdateStaff.Text = "Update";
            this.btnUpdateStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateStaff.FlatAppearance.BorderSize = 0;
            this.btnUpdateStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateStaff.UseVisualStyleBackColor = false;
            // 
            // btnDeleteStaff
            // 
            this.btnDeleteStaff.BackColor = System.Drawing.Color.FromArgb(214, 69, 69);
            this.btnDeleteStaff.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteStaff.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnDeleteStaff.Location = new System.Drawing.Point(15, 411);
            this.btnDeleteStaff.Name = "btnDeleteStaff";
            this.btnDeleteStaff.Size = new System.Drawing.Size(136, 40);
            this.btnDeleteStaff.TabIndex = 12;
            this.btnDeleteStaff.Text = "Delete";
            this.btnDeleteStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteStaff.FlatAppearance.BorderSize = 0;
            this.btnDeleteStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteStaff.UseVisualStyleBackColor = false;
            // 
            // btnClearStaff
            // 
            this.btnClearStaff.BackColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.btnClearStaff.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClearStaff.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnClearStaff.Location = new System.Drawing.Point(169, 411);
            this.btnClearStaff.Name = "btnClearStaff";
            this.btnClearStaff.Size = new System.Drawing.Size(136, 40);
            this.btnClearStaff.TabIndex = 13;
            this.btnClearStaff.Text = "Clear";
            this.btnClearStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearStaff.FlatAppearance.BorderSize = 0;
            this.btnClearStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearStaff.UseVisualStyleBackColor = false;
            // 
            // dgvStaff
            // 
            this.dgvStaff.AllowUserToAddRows = false;
            this.dgvStaff.AllowUserToDeleteRows = false;
            this.dgvStaff.AllowUserToResizeRows = false;
            this.dgvStaff.AlternatingRowsDefaultCellStyle = this.dgvStaffAltStyle;
            this.dgvStaff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStaff.BackgroundColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.dgvStaff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvStaff.ColumnHeadersDefaultCellStyle = this.dgvStaffHeadStyle;
            this.dgvStaff.ColumnHeadersHeight = 34;
            this.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStaff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStaffUserID,
            this.colStaffUsername,
            this.colStaffRole});
            this.dgvStaff.EnableHeadersVisualStyles = false;
            this.dgvStaff.MultiSelect = false;
            this.dgvStaff.ReadOnly = true;
            this.dgvStaff.RowHeadersVisible = false;
            this.dgvStaff.RowTemplate.Height = 28;
            this.dgvStaff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStaff.Location = new System.Drawing.Point(370, 84);
            this.dgvStaff.Name = "dgvStaff";
            this.dgvStaff.Size = new System.Drawing.Size(530, 490);
            this.dgvStaff.TabIndex = 2;
            // 
            // dgvStaffHeadStyle
            // 
            this.dgvStaffHeadStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvStaffHeadStyle.BackColor = System.Drawing.Color.FromArgb(31, 58, 95);
            this.dgvStaffHeadStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dgvStaffHeadStyle.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.dgvStaffHeadStyle.SelectionBackColor = System.Drawing.Color.FromArgb(31, 58, 95);
            this.dgvStaffHeadStyle.SelectionForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.dgvStaffHeadStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dgvStaffAltStyle
            // 
            this.dgvStaffAltStyle.BackColor = System.Drawing.Color.FromArgb(244, 246, 249);
            // 
            // colStaffUserID
            // 
            this.colStaffUserID.FillWeight = 55F;
            this.colStaffUserID.HeaderText = "User ID";
            this.colStaffUserID.Name = "colStaffUserID";
            this.colStaffUserID.ReadOnly = true;
            // 
            // colStaffUsername
            // 
            this.colStaffUsername.FillWeight = 150F;
            this.colStaffUsername.HeaderText = "Username";
            this.colStaffUsername.Name = "colStaffUsername";
            this.colStaffUsername.ReadOnly = true;
            // 
            // colStaffRole
            // 
            this.colStaffRole.FillWeight = 100F;
            this.colStaffRole.HeaderText = "Role";
            this.colStaffRole.Name = "colStaffRole";
            this.colStaffRole.ReadOnly = true;
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(244, 246, 249);
            this.ClientSize = new System.Drawing.Size(920, 600);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.grpStaffDetails);
            this.Controls.Add(this.dgvStaff);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "StaffForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookTrack - Staff Accounts";
            this.pnlHeader.ResumeLayout(false);
            this.grpStaffDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Label lblFormSubtitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox grpStaffDetails;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label lblStaffUsername;
        private System.Windows.Forms.TextBox txtStaffUsername;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Label lblStaffPassword;
        private System.Windows.Forms.TextBox txtStaffPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.Button btnUpdateStaff;
        private System.Windows.Forms.Button btnDeleteStaff;
        private System.Windows.Forms.Button btnClearStaff;
        private System.Windows.Forms.DataGridView dgvStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStaffUserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStaffUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStaffRole;
        private System.Windows.Forms.DataGridViewCellStyle dgvStaffAltStyle;
        private System.Windows.Forms.DataGridViewCellStyle dgvStaffHeadStyle;
    }
}
