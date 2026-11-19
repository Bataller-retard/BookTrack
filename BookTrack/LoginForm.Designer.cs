namespace BookTrack
{
    partial class LoginForm
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
            pnlBrand = new Panel();
            lblBrand = new Label();
            lblTagline = new Label();
            lblFooter = new Label();
            lblWelcome = new Label();
            lblWelcomeSub = new Label();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            chkShowPassword = new CheckBox();
            lblError = new Label();
            btnLogin = new Button();
            btnExit = new Button();
            pnlBrand.SuspendLayout();
            SuspendLayout();
            // 
            // pnlBrand
            // 
            pnlBrand.BackColor = Color.FromArgb(31, 58, 95);
            pnlBrand.Controls.Add(lblBrand);
            pnlBrand.Controls.Add(lblTagline);
            pnlBrand.Controls.Add(lblFooter);
            pnlBrand.Location = new Point(0, 0);
            pnlBrand.Name = "pnlBrand";
            pnlBrand.Size = new Size(320, 460);
            pnlBrand.TabIndex = 0;
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.BackColor = Color.Transparent;
            lblBrand.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            lblBrand.ForeColor = Color.FromArgb(255, 255, 255);
            lblBrand.Location = new Point(30, 150);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(285, 70);
            lblBrand.TabIndex = 0;
            lblBrand.Text = "BookTrack";
            // 
            // lblTagline
            // 
            lblTagline.AutoSize = true;
            lblTagline.BackColor = Color.Transparent;
            lblTagline.Font = new Font("Segoe UI", 11F);
            lblTagline.ForeColor = Color.FromArgb(200, 215, 235);
            lblTagline.Location = new Point(33, 222);
            lblTagline.Name = "lblTagline";
            lblTagline.Size = new Size(217, 60);
            lblTagline.TabIndex = 1;
            lblTagline.Text = "Library Borrowing\nManagement System";
            lblTagline.Click += lblTagline_Click;
            // 
            // lblFooter
            // 
            lblFooter.AutoSize = true;
            lblFooter.BackColor = Color.Transparent;
            lblFooter.Font = new Font("Segoe UI", 9F);
            lblFooter.ForeColor = Color.FromArgb(200, 215, 235);
            lblFooter.Location = new Point(33, 410);
            lblFooter.Name = "lblFooter";
            lblFooter.Size = new Size(177, 25);
            lblFooter.TabIndex = 2;
            lblFooter.Text = "C# OOP Final Project";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.BackColor = Color.Transparent;
            lblWelcome.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.FromArgb(31, 58, 95);
            lblWelcome.Location = new Point(370, 64);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(227, 54);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Staff Login";
            // 
            // lblWelcomeSub
            // 
            lblWelcomeSub.AutoSize = true;
            lblWelcomeSub.BackColor = Color.Transparent;
            lblWelcomeSub.Font = new Font("Segoe UI", 10F);
            lblWelcomeSub.ForeColor = Color.FromArgb(107, 114, 128);
            lblWelcomeSub.Location = new Point(372, 118);
            lblWelcomeSub.Name = "lblWelcomeSub";
            lblWelcomeSub.Size = new Size(265, 28);
            lblWelcomeSub.TabIndex = 2;
            lblWelcomeSub.Text = "Sign in to manage the library";
            lblWelcomeSub.Click += lblWelcomeSub_Click;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BackColor = Color.Transparent;
            lblUsername.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblUsername.ForeColor = Color.FromArgb(43, 47, 54);
            lblUsername.Location = new Point(372, 154);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(106, 28);
            lblUsername.TabIndex = 3;
            lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Location = new Point(372, 186);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Enter your username";
            txtUsername.Size = new Size(330, 34);
            txtUsername.TabIndex = 4;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.Transparent;
            lblPassword.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPassword.ForeColor = Color.FromArgb(43, 47, 54);
            lblPassword.Location = new Point(370, 254);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(101, 28);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Location = new Point(370, 285);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Enter your password";
            txtPassword.Size = new Size(330, 34);
            txtPassword.TabIndex = 6;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Location = new Point(370, 325);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(174, 32);
            chkShowPassword.TabIndex = 7;
            chkShowPassword.Text = "Show password";
            chkShowPassword.UseVisualStyleBackColor = true;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.BackColor = Color.Transparent;
            lblError.Font = new Font("Segoe UI", 9F);
            lblError.ForeColor = Color.FromArgb(214, 69, 69);
            lblError.Location = new Point(370, 355);
            lblError.Name = "lblError";
            lblError.Size = new Size(254, 25);
            lblError.TabIndex = 8;
            lblError.Text = "Invalid username or password.";
            lblError.Visible = false;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(42, 157, 143);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLogin.ForeColor = Color.FromArgb(255, 255, 255);
            btnLogin.Location = new Point(370, 387);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(330, 42);
            btnLogin.TabIndex = 9;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(107, 114, 128);
            btnExit.Cursor = Cursors.Hand;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnExit.ForeColor = Color.FromArgb(255, 255, 255);
            btnExit.Location = new Point(370, 437);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(330, 34);
            btnExit.TabIndex = 10;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            // 
            // LoginForm
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(244, 246, 249);
            CancelButton = btnExit;
            ClientSize = new Size(1083, 588);
            Controls.Add(pnlBrand);
            Controls.Add(lblWelcome);
            Controls.Add(lblWelcomeSub);
            Controls.Add(lblUsername);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(chkShowPassword);
            Controls.Add(lblError);
            Controls.Add(btnLogin);
            Controls.Add(btnExit);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BookTrack - Login";
            pnlBrand.ResumeLayout(false);
            pnlBrand.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlBrand;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblTagline;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblWelcomeSub;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox chkShowPassword;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
    }
}
