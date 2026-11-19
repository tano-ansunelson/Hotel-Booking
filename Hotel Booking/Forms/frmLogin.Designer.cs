namespace Hotel_Booking
{
    partial class frmLogin
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
            tlpMain = new TableLayoutPanel();
            pnlBrand = new Panel();
            lblVersion = new Label();
            lblFeature3 = new Label();
            lbFeature2 = new Label();
            lbFeature1 = new Label();
            lblDescription = new Label();
            lblHeading2 = new Label();
            lblHeading1 = new Label();
            lblHotelSubtitle = new Label();
            lblHotelName = new Label();
            pnlLogo = new Panel();
            lblLogoIcon = new Label();
            pnlLogin = new Panel();
            lbError = new Label();
            pnlLoginContent = new Panel();
            lblAccessInfo = new Label();
            btnSignIn = new Button();
            lnkForgotPassword = new LinkLabel();
            chkRememberMe = new CheckBox();
            txtPassword = new TextBox();
            lblPassword = new Label();
            txtUsername = new TextBox();
            lblUsername = new Label();
            lblSignInDescription = new Label();
            lblSignIn = new Label();
            tlpMain.SuspendLayout();
            pnlBrand.SuspendLayout();
            pnlLogo.SuspendLayout();
            pnlLogin.SuspendLayout();
            pnlLoginContent.SuspendLayout();
            SuspendLayout();
            // 
            // tlpMain
            // 
            tlpMain.ColumnCount = 2;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpMain.Controls.Add(pnlBrand, 0, 0);
            tlpMain.Controls.Add(pnlLogin, 1, 0);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(0, 0);
            tlpMain.Margin = new Padding(0);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 1;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpMain.Size = new Size(1102, 674);
            tlpMain.TabIndex = 0;
            // 
            // pnlBrand
            // 
            pnlBrand.AutoSize = true;
            pnlBrand.BackColor = Color.FromArgb(20, 43, 70);
            pnlBrand.Controls.Add(lblVersion);
            pnlBrand.Controls.Add(lblFeature3);
            pnlBrand.Controls.Add(lbFeature2);
            pnlBrand.Controls.Add(lbFeature1);
            pnlBrand.Controls.Add(lblDescription);
            pnlBrand.Controls.Add(lblHeading2);
            pnlBrand.Controls.Add(lblHeading1);
            pnlBrand.Controls.Add(lblHotelSubtitle);
            pnlBrand.Controls.Add(lblHotelName);
            pnlBrand.Controls.Add(pnlLogo);
            pnlBrand.Dock = DockStyle.Fill;
            pnlBrand.Location = new Point(0, 0);
            pnlBrand.Margin = new Padding(0);
            pnlBrand.Name = "pnlBrand";
            pnlBrand.Padding = new Padding(40);
            pnlBrand.Size = new Size(551, 674);
            pnlBrand.TabIndex = 0;
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.Font = new Font("Segoe UI", 8F);
            lblVersion.ForeColor = Color.LightSteelBlue;
            lblVersion.Location = new Point(92, 594);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(197, 19);
            lblVersion.TabIndex = 9;
            lblVersion.Text = "Version 1.0 · Grand Palm Hotel";
            // 
            // lblFeature3
            // 
            lblFeature3.AutoSize = true;
            lblFeature3.Font = new Font("Segoe UI", 10F);
            lblFeature3.ForeColor = Color.White;
            lblFeature3.Location = new Point(92, 510);
            lblFeature3.Name = "lblFeature3";
            lblFeature3.Size = new Size(255, 23);
            lblFeature3.TabIndex = 8;
            lblFeature3.Text = "✓ Billing, payments and receipts";
            // 
            // lbFeature2
            // 
            lbFeature2.AutoSize = true;
            lbFeature2.Font = new Font("Segoe UI", 10F);
            lbFeature2.ForeColor = Color.White;
            lbFeature2.Location = new Point(92, 463);
            lbFeature2.Name = "lbFeature2";
            lbFeature2.Size = new Size(241, 23);
            lbFeature2.TabIndex = 7;
            lbFeature2.Text = "✓ Fast check-in and check-out";
            // 
            // lbFeature1
            // 
            lbFeature1.AutoSize = true;
            lbFeature1.Font = new Font("Segoe UI", 10F);
            lbFeature1.ForeColor = Color.White;
            lbFeature1.Location = new Point(92, 411);
            lbFeature1.Name = "lbFeature1";
            lbFeature1.Size = new Size(187, 23);
            lbFeature1.TabIndex = 6;
            lbFeature1.Text = "✓ Live room availability";
            // 
            // lblDescription
            // 
            lblDescription.Font = new Font("Segoe UI", 10F);
            lblDescription.ForeColor = Color.White;
            lblDescription.Location = new Point(92, 330);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(430, 55);
            lblDescription.TabIndex = 5;
            lblDescription.Text = "Bookings, guests, rooms and payments in one place, built for the people who welcome every arrival.";
            lblDescription.Click += lblDescription_Click;
            // 
            // lblHeading2
            // 
            lblHeading2.AutoSize = true;
            lblHeading2.Font = new Font("Georgia", 28F, FontStyle.Bold);
            lblHeading2.ForeColor = Color.FromArgb(217, 161, 62);
            lblHeading2.Location = new Point(92, 241);
            lblHeading2.Name = "lblHeading2";
            lblHeading2.Size = new Size(284, 54);
            lblHeading2.TabIndex = 4;
            lblHeading2.Text = "simplified.";
            // 
            // lblHeading1
            // 
            lblHeading1.AutoSize = true;
            lblHeading1.Font = new Font("Georgia", 28F, FontStyle.Bold);
            lblHeading1.ForeColor = Color.White;
            lblHeading1.Location = new Point(92, 164);
            lblHeading1.Name = "lblHeading1";
            lblHeading1.Size = new Size(299, 54);
            lblHeading1.TabIndex = 3;
            lblHeading1.Text = "Front desk,";
            // 
            // lblHotelSubtitle
            // 
            lblHotelSubtitle.AutoSize = true;
            lblHotelSubtitle.Font = new Font("Segoe UI", 8F);
            lblHotelSubtitle.ForeColor = Color.FromArgb(217, 161, 62);
            lblHotelSubtitle.Location = new Point(92, 68);
            lblHotelSubtitle.Name = "lblHotelSubtitle";
            lblHotelSubtitle.Size = new Size(120, 19);
            lblHotelSubtitle.TabIndex = 2;
            lblHotelSubtitle.Text = "HOTEL MANAGER";
            lblHotelSubtitle.Click += lblHotelSubtitle_Click;
            // 
            // lblHotelName
            // 
            lblHotelName.AutoSize = true;
            lblHotelName.Font = new Font("Georgia", 15F, FontStyle.Bold);
            lblHotelName.ForeColor = Color.White;
            lblHotelName.Location = new Point(78, 30);
            lblHotelName.Name = "lblHotelName";
            lblHotelName.Size = new Size(168, 30);
            lblHotelName.TabIndex = 1;
            lblHotelName.Text = "Grand Palm";
            lblHotelName.Click += lblHotelName_Click;
            // 
            // pnlLogo
            // 
            pnlLogo.BackColor = Color.FromArgb(201, 151, 61);
            pnlLogo.Controls.Add(lblLogoIcon);
            pnlLogo.Location = new Point(10, 30);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(40, 40);
            pnlLogo.TabIndex = 0;
            // 
            // lblLogoIcon
            // 
            lblLogoIcon.AutoSize = true;
            lblLogoIcon.Dock = DockStyle.Fill;
            lblLogoIcon.Font = new Font("Segoe UI", 25F);
            lblLogoIcon.ForeColor = Color.FromArgb(20, 43, 70);
            lblLogoIcon.Location = new Point(0, 0);
            lblLogoIcon.Name = "lblLogoIcon";
            lblLogoIcon.Size = new Size(62, 57);
            lblLogoIcon.TabIndex = 1;
            lblLogoIcon.Text = "\t⌂";
            lblLogoIcon.TextAlign = ContentAlignment.MiddleCenter;
            lblLogoIcon.Click += lblLogoIcon_Click;
            // 
            // pnlLogin
            // 
            pnlLogin.BackColor = Color.FromArgb(245, 243, 239);
            pnlLogin.Controls.Add(lbError);
            pnlLogin.Controls.Add(pnlLoginContent);
            pnlLogin.Dock = DockStyle.Fill;
            pnlLogin.Location = new Point(551, 0);
            pnlLogin.Margin = new Padding(0);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Padding = new Padding(40);
            pnlLogin.Size = new Size(551, 674);
            pnlLogin.TabIndex = 1;
            // 
            // lbError
            // 
            lbError.ForeColor = Color.FromArgb(184, 58, 50);
            lbError.Location = new Point(60, 478);
            lbError.Name = "lbError";
            lbError.Size = new Size(380, 22);
            lbError.TabIndex = 1;
            lbError.Text = "Error message";
            lbError.Visible = false;
            // 
            // pnlLoginContent
            // 
            pnlLoginContent.Anchor = AnchorStyles.None;
            pnlLoginContent.Controls.Add(lblAccessInfo);
            pnlLoginContent.Controls.Add(btnSignIn);
            pnlLoginContent.Controls.Add(lnkForgotPassword);
            pnlLoginContent.Controls.Add(chkRememberMe);
            pnlLoginContent.Controls.Add(txtPassword);
            pnlLoginContent.Controls.Add(lblPassword);
            pnlLoginContent.Controls.Add(txtUsername);
            pnlLoginContent.Controls.Add(lblUsername);
            pnlLoginContent.Controls.Add(lblSignInDescription);
            pnlLoginContent.Controls.Add(lblSignIn);
            pnlLoginContent.Font = new Font("Segoe UI", 8F);
            pnlLoginContent.ForeColor = Color.FromArgb(20, 43, 70);
            pnlLoginContent.Location = new Point(71, 167);
            pnlLoginContent.Name = "pnlLoginContent";
            pnlLoginContent.Size = new Size(414, 415);
            pnlLoginContent.TabIndex = 0;
            // 
            // lblAccessInfo
            // 
            lblAccessInfo.AutoSize = true;
            lblAccessInfo.ForeColor = Color.SlateGray;
            lblAccessInfo.Location = new Point(39, 371);
            lblAccessInfo.Name = "lblAccessInfo";
            lblAccessInfo.Size = new Size(289, 19);
            lblAccessInfo.TabIndex = 9;
            lblAccessInfo.Text = "Need access? Contact the hotel administrator.";
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = Color.FromArgb(201, 151, 61);
            btnSignIn.Cursor = Cursors.Hand;
            btnSignIn.FlatAppearance.BorderSize = 0;
            btnSignIn.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, 133, 47);
            btnSignIn.FlatStyle = FlatStyle.Flat;
            btnSignIn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignIn.ForeColor = Color.FromArgb(18, 38, 63);
            btnSignIn.Location = new Point(21, 318);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(328, 40);
            btnSignIn.TabIndex = 3;
            btnSignIn.Text = "Sign In";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // lnkForgotPassword
            // 
            lnkForgotPassword.ActiveLinkColor = Color.FromArgb(107, 74, 12);
            lnkForgotPassword.AutoSize = true;
            lnkForgotPassword.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lnkForgotPassword.LinkBehavior = LinkBehavior.HoverUnderline;
            lnkForgotPassword.LinkColor = Color.FromArgb(153, 103, 22);
            lnkForgotPassword.Location = new Point(232, 272);
            lnkForgotPassword.Name = "lnkForgotPassword";
            lnkForgotPassword.Size = new Size(117, 17);
            lnkForgotPassword.TabIndex = 7;
            lnkForgotPassword.TabStop = true;
            lnkForgotPassword.Text = "Forgot password?";
            lnkForgotPassword.VisitedLinkColor = Color.FromArgb(138, 94, 16);
            lnkForgotPassword.LinkClicked += lnkForgotPassword_LinkClicked;
            // 
            // chkRememberMe
            // 
            chkRememberMe.AutoSize = true;
            chkRememberMe.Checked = true;
            chkRememberMe.CheckState = CheckState.Checked;
            chkRememberMe.ForeColor = Color.FromArgb(74, 85, 99);
            chkRememberMe.Location = new Point(22, 272);
            chkRememberMe.Name = "chkRememberMe";
            chkRememberMe.Size = new Size(120, 23);
            chkRememberMe.TabIndex = 2;
            chkRememberMe.Text = "Remember me";
            chkRememberMe.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 10F);
            txtPassword.Location = new Point(22, 214);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(328, 30);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.FromArgb(74, 85, 99);
            lblPassword.Location = new Point(22, 192);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(66, 17);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.White;
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.ForeColor = Color.FromArgb(20, 43, 70);
            txtUsername.Location = new Point(21, 134);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(328, 25);
            txtUsername.TabIndex = 0;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.FromArgb(74, 85, 99);
            lblUsername.Location = new Point(21, 112);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(69, 17);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Username";
            // 
            // lblSignInDescription
            // 
            lblSignInDescription.AutoSize = true;
            lblSignInDescription.Font = new Font("Segoe UI", 10F);
            lblSignInDescription.ForeColor = Color.FromArgb(95, 105, 117);
            lblSignInDescription.Location = new Point(21, 51);
            lblSignInDescription.Name = "lblSignInDescription";
            lblSignInDescription.Size = new Size(310, 23);
            lblSignInDescription.TabIndex = 1;
            lblSignInDescription.Text = "Enter your staff credentials to continue.";
            // 
            // lblSignIn
            // 
            lblSignIn.AutoSize = true;
            lblSignIn.Font = new Font("Georgia", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSignIn.ForeColor = Color.FromArgb(20, 43, 70);
            lblSignIn.Location = new Point(12, 8);
            lblSignIn.Name = "lblSignIn";
            lblSignIn.Size = new Size(151, 43);
            lblSignIn.TabIndex = 0;
            lblSignIn.Text = "Sign in";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1102, 674);
            Controls.Add(tlpMain);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Grand Palm Hotel - Sign in";
            Load += frmLogin_Load;
            tlpMain.ResumeLayout(false);
            tlpMain.PerformLayout();
            pnlBrand.ResumeLayout(false);
            pnlBrand.PerformLayout();
            pnlLogo.ResumeLayout(false);
            pnlLogo.PerformLayout();
            pnlLogin.ResumeLayout(false);
            pnlLoginContent.ResumeLayout(false);
            pnlLoginContent.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpMain;
        private Panel pnlBrand;
        private Panel pnlLogin;
        private Panel pnlLogo;
        private Label lblLogoIcon;
        private Label lblHotelSubtitle;
        private Label lblHotelName;
        private Label lblHeading2;
        private Label lblHeading1;
        private Label lblDescription;
        private Label lblFeature3;
        private Label lbFeature2;
        private Label lbFeature1;
        private Label lblVersion;
        private Panel pnlLoginContent;
        private Label lblSignIn;
        private TextBox txtUsername;
        private Label lblUsername;
        private Label lblSignInDescription;
        private TextBox txtPassword;
        private Label lblPassword;
        private LinkLabel lnkForgotPassword;
        private CheckBox chkRememberMe;
        private Button btnSignIn;
        private Label lblAccessInfo;
        private Label lbError;
    }
}