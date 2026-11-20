namespace Hotel_Booking
{
    partial class ucSidebar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tlpSidebar = new TableLayoutPanel();
            pnlSidebarLogo = new Panel();
            lbBrandSub = new Label();
            lbBrand = new Label();
            pbLogo = new PictureBox();
            flpNavigation = new FlowLayoutPanel();
            btnDashboard = new Button();
            btnBookings = new Button();
            btnNewBooking = new Button();
            btnCheckInOut = new Button();
            btnGuests = new Button();
            btnRooms = new Button();
            btnPayments = new Button();
            btnReports = new Button();
            pnlUserProfile = new Panel();
            label1 = new Label();
            lblUserName = new Label();
            lblUserInitials = new Label();
            tlpSidebar.SuspendLayout();
            pnlSidebarLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            flpNavigation.SuspendLayout();
            pnlUserProfile.SuspendLayout();
            SuspendLayout();
            // 
            // tlpSidebar
            // 
            tlpSidebar.BackColor = Color.FromArgb(20, 43, 70);
            tlpSidebar.ColumnCount = 1;
            tlpSidebar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpSidebar.Controls.Add(pnlSidebarLogo, 0, 0);
            tlpSidebar.Controls.Add(flpNavigation, 0, 1);
            tlpSidebar.Controls.Add(pnlUserProfile, 0, 2);
            tlpSidebar.Dock = DockStyle.Fill;
            tlpSidebar.Location = new Point(0, 0);
            tlpSidebar.Margin = new Padding(0);
            tlpSidebar.Name = "tlpSidebar";
            tlpSidebar.Padding = new Padding(15);
            tlpSidebar.RowCount = 3;
            tlpSidebar.RowStyles.Add(new RowStyle(SizeType.Absolute, 90F));
            tlpSidebar.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpSidebar.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            tlpSidebar.Size = new Size(235, 775);
            tlpSidebar.TabIndex = 1;
            // 
            // pnlSidebarLogo
            // 
            pnlSidebarLogo.Controls.Add(lbBrandSub);
            pnlSidebarLogo.Controls.Add(lbBrand);
            pnlSidebarLogo.Controls.Add(pbLogo);
            pnlSidebarLogo.Dock = DockStyle.Fill;
            pnlSidebarLogo.Location = new Point(18, 18);
            pnlSidebarLogo.Name = "pnlSidebarLogo";
            pnlSidebarLogo.Size = new Size(199, 84);
            pnlSidebarLogo.TabIndex = 0;
            // 
            // lbBrandSub
            // 
            lbBrandSub.AutoSize = true;
            lbBrandSub.BackColor = Color.Transparent;
            lbBrandSub.ForeColor = Color.FromArgb(200, 150, 62);
            lbBrandSub.Location = new Point(50, 24);
            lbBrandSub.Name = "lbBrandSub";
            lbBrandSub.Size = new Size(128, 20);
            lbBrandSub.TabIndex = 2;
            lbBrandSub.Text = "HOTEL MANAGER";
            // 
            // lbBrand
            // 
            lbBrand.AutoSize = true;
            lbBrand.BackColor = Color.Transparent;
            lbBrand.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbBrand.ForeColor = Color.White;
            lbBrand.Location = new Point(45, 0);
            lbBrand.Name = "lbBrand";
            lbBrand.Size = new Size(133, 24);
            lbBrand.TabIndex = 1;
            lbBrand.Text = "Grand Palm";
            // 
            // pbLogo
            // 
            pbLogo.BackColor = Color.FromArgb(200, 150, 62);
            pbLogo.Location = new Point(3, 3);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(36, 36);
            pbLogo.SizeMode = PictureBoxSizeMode.CenterImage;
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            // 
            // flpNavigation
            // 
            flpNavigation.AutoScroll = true;
            flpNavigation.Controls.Add(btnDashboard);
            flpNavigation.Controls.Add(btnBookings);
            flpNavigation.Controls.Add(btnNewBooking);
            flpNavigation.Controls.Add(btnCheckInOut);
            flpNavigation.Controls.Add(btnGuests);
            flpNavigation.Controls.Add(btnRooms);
            flpNavigation.Controls.Add(btnPayments);
            flpNavigation.Controls.Add(btnReports);
            flpNavigation.Dock = DockStyle.Fill;
            flpNavigation.FlowDirection = FlowDirection.TopDown;
            flpNavigation.Location = new Point(15, 105);
            flpNavigation.Margin = new Padding(0);
            flpNavigation.Name = "flpNavigation";
            flpNavigation.Size = new Size(205, 590);
            flpNavigation.TabIndex = 1;
            flpNavigation.WrapContents = false;
            flpNavigation.Paint += flpNavigation_Paint;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(18, 38, 63);
            btnDashboard.Cursor = Cursors.Hand;
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 58, 92);
            btnDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(27, 53, 82);
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 10F);
            btnDashboard.ForeColor = Color.FromArgb(201, 211, 224);
            btnDashboard.Location = new Point(0, 3);
            btnDashboard.Margin = new Padding(0, 3, 0, 3);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(180, 42);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "▦ Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // btnBookings
            // 
            btnBookings.BackColor = Color.FromArgb(18, 38, 63);
            btnBookings.Cursor = Cursors.Hand;
            btnBookings.Dock = DockStyle.Top;
            btnBookings.FlatAppearance.BorderSize = 0;
            btnBookings.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 58, 92);
            btnBookings.FlatAppearance.MouseOverBackColor = Color.FromArgb(27, 53, 82);
            btnBookings.FlatStyle = FlatStyle.Flat;
            btnBookings.Font = new Font("Segoe UI", 10F);
            btnBookings.ForeColor = Color.FromArgb(201, 211, 224);
            btnBookings.Location = new Point(0, 51);
            btnBookings.Margin = new Padding(0, 3, 0, 3);
            btnBookings.Name = "btnBookings";
            btnBookings.Size = new Size(180, 42);
            btnBookings.TabIndex = 1;
            btnBookings.Text = "▣ Bookings";
            btnBookings.TextAlign = ContentAlignment.MiddleLeft;
            btnBookings.UseVisualStyleBackColor = false;
            // 
            // btnNewBooking
            // 
            btnNewBooking.BackColor = Color.FromArgb(18, 38, 63);
            btnNewBooking.Cursor = Cursors.Hand;
            btnNewBooking.Dock = DockStyle.Top;
            btnNewBooking.FlatAppearance.BorderSize = 0;
            btnNewBooking.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 58, 92);
            btnNewBooking.FlatAppearance.MouseOverBackColor = Color.FromArgb(27, 53, 82);
            btnNewBooking.FlatStyle = FlatStyle.Flat;
            btnNewBooking.Font = new Font("Segoe UI", 10F);
            btnNewBooking.ForeColor = Color.FromArgb(201, 211, 224);
            btnNewBooking.Location = new Point(0, 99);
            btnNewBooking.Margin = new Padding(0, 3, 0, 3);
            btnNewBooking.Name = "btnNewBooking";
            btnNewBooking.Size = new Size(180, 42);
            btnNewBooking.TabIndex = 2;
            btnNewBooking.Text = "⊕ New Booking";
            btnNewBooking.TextAlign = ContentAlignment.MiddleLeft;
            btnNewBooking.UseVisualStyleBackColor = false;
            // 
            // btnCheckInOut
            // 
            btnCheckInOut.BackColor = Color.FromArgb(18, 38, 63);
            btnCheckInOut.Cursor = Cursors.Hand;
            btnCheckInOut.Dock = DockStyle.Top;
            btnCheckInOut.FlatAppearance.BorderSize = 0;
            btnCheckInOut.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 58, 92);
            btnCheckInOut.FlatAppearance.MouseOverBackColor = Color.FromArgb(27, 53, 82);
            btnCheckInOut.FlatStyle = FlatStyle.Flat;
            btnCheckInOut.Font = new Font("Segoe UI", 10F);
            btnCheckInOut.ForeColor = Color.FromArgb(201, 211, 224);
            btnCheckInOut.Location = new Point(0, 147);
            btnCheckInOut.Margin = new Padding(0, 3, 0, 3);
            btnCheckInOut.Name = "btnCheckInOut";
            btnCheckInOut.Size = new Size(180, 42);
            btnCheckInOut.TabIndex = 3;
            btnCheckInOut.Text = "⚿ Check-in / out";
            btnCheckInOut.TextAlign = ContentAlignment.MiddleLeft;
            btnCheckInOut.UseVisualStyleBackColor = false;
            btnCheckInOut.Click += btnCheckInOut_Click;
            // 
            // btnGuests
            // 
            btnGuests.BackColor = Color.FromArgb(18, 38, 63);
            btnGuests.Cursor = Cursors.Hand;
            btnGuests.Dock = DockStyle.Top;
            btnGuests.FlatAppearance.BorderSize = 0;
            btnGuests.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 58, 92);
            btnGuests.FlatAppearance.MouseOverBackColor = Color.FromArgb(27, 53, 82);
            btnGuests.FlatStyle = FlatStyle.Flat;
            btnGuests.Font = new Font("Segoe UI", 10F);
            btnGuests.ForeColor = Color.FromArgb(201, 211, 224);
            btnGuests.Location = new Point(0, 195);
            btnGuests.Margin = new Padding(0, 3, 0, 3);
            btnGuests.Name = "btnGuests";
            btnGuests.Size = new Size(180, 42);
            btnGuests.TabIndex = 4;
            btnGuests.Text = "♙ Guests";
            btnGuests.TextAlign = ContentAlignment.MiddleLeft;
            btnGuests.UseVisualStyleBackColor = false;
            btnGuests.Click += btnGuests_Click;
            // 
            // btnRooms
            // 
            btnRooms.BackColor = Color.FromArgb(18, 38, 63);
            btnRooms.Cursor = Cursors.Hand;
            btnRooms.Dock = DockStyle.Top;
            btnRooms.FlatAppearance.BorderSize = 0;
            btnRooms.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 58, 92);
            btnRooms.FlatAppearance.MouseOverBackColor = Color.FromArgb(27, 53, 82);
            btnRooms.FlatStyle = FlatStyle.Flat;
            btnRooms.Font = new Font("Segoe UI", 10F);
            btnRooms.ForeColor = Color.FromArgb(201, 211, 224);
            btnRooms.Location = new Point(0, 243);
            btnRooms.Margin = new Padding(0, 3, 0, 3);
            btnRooms.Name = "btnRooms";
            btnRooms.Size = new Size(180, 42);
            btnRooms.TabIndex = 5;
            btnRooms.Text = "▰ Rooms";
            btnRooms.TextAlign = ContentAlignment.MiddleLeft;
            btnRooms.UseVisualStyleBackColor = false;
            // 
            // btnPayments
            // 
            btnPayments.BackColor = Color.FromArgb(18, 38, 63);
            btnPayments.Cursor = Cursors.Hand;
            btnPayments.Dock = DockStyle.Top;
            btnPayments.FlatAppearance.BorderSize = 0;
            btnPayments.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 58, 92);
            btnPayments.FlatAppearance.MouseOverBackColor = Color.FromArgb(27, 53, 82);
            btnPayments.FlatStyle = FlatStyle.Flat;
            btnPayments.Font = new Font("Segoe UI", 10F);
            btnPayments.ForeColor = Color.FromArgb(201, 211, 224);
            btnPayments.Location = new Point(0, 291);
            btnPayments.Margin = new Padding(0, 3, 0, 3);
            btnPayments.Name = "btnPayments";
            btnPayments.Size = new Size(180, 42);
            btnPayments.TabIndex = 6;
            btnPayments.Text = "▤ Payments";
            btnPayments.TextAlign = ContentAlignment.MiddleLeft;
            btnPayments.UseVisualStyleBackColor = false;
            // 
            // btnReports
            // 
            btnReports.BackColor = Color.FromArgb(18, 38, 63);
            btnReports.Cursor = Cursors.Hand;
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 58, 92);
            btnReports.FlatAppearance.MouseOverBackColor = Color.FromArgb(27, 53, 82);
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Segoe UI", 10F);
            btnReports.ForeColor = Color.FromArgb(201, 211, 224);
            btnReports.Location = new Point(0, 339);
            btnReports.Margin = new Padding(0, 3, 0, 3);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(180, 42);
            btnReports.TabIndex = 7;
            btnReports.Text = "▥ Reports";
            btnReports.TextAlign = ContentAlignment.MiddleLeft;
            btnReports.UseVisualStyleBackColor = false;
            // 
            // pnlUserProfile
            // 
            pnlUserProfile.Controls.Add(label1);
            pnlUserProfile.Controls.Add(lblUserName);
            pnlUserProfile.Controls.Add(lblUserInitials);
            pnlUserProfile.Dock = DockStyle.Fill;
            pnlUserProfile.Location = new Point(18, 698);
            pnlUserProfile.Name = "pnlUserProfile";
            pnlUserProfile.Size = new Size(199, 59);
            pnlUserProfile.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.LightBlue;
            label1.Location = new Point(58, 29);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 2;
            label1.Text = "Receptionist";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserName.ForeColor = Color.White;
            lblUserName.Location = new Point(58, 9);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(101, 20);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "Ama Mensah";
            // 
            // lblUserInitials
            // 
            lblUserInitials.BackColor = Color.FromArgb(201, 151, 61);
            lblUserInitials.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserInitials.ForeColor = Color.White;
            lblUserInitials.Location = new Point(16, 11);
            lblUserInitials.Name = "lblUserInitials";
            lblUserInitials.Size = new Size(36, 36);
            lblUserInitials.TabIndex = 0;
            lblUserInitials.Text = "AM";
            lblUserInitials.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ucSidebar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tlpSidebar);
            Name = "ucSidebar";
            Size = new Size(235, 775);
            tlpSidebar.ResumeLayout(false);
            pnlSidebarLogo.ResumeLayout(false);
            pnlSidebarLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            flpNavigation.ResumeLayout(false);
            pnlUserProfile.ResumeLayout(false);
            pnlUserProfile.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpSidebar;
        private Panel pnlSidebarLogo;
        private FlowLayoutPanel flpNavigation;
        private Button btnDashboard;
        private Button btnBookings;
        private Button btnNewBooking;
        private Button btnCheckInOut;
        private Button btnGuests;
        private Button btnRooms;
        private Button btnPayments;
        private Button btnReports;
        private Panel pnlUserProfile;
        private Label label1;
        private Label lblUserName;
        private Label lblUserInitials;
        private PictureBox pbLogo;
        private Label lbBrandSub;
        private Label lbBrand;
    }
}
