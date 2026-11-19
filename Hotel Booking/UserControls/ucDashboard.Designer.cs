namespace Hotel_Booking.UserControls
{
    partial class ucDashboard
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            tlpDashboard = new TableLayoutPanel();
            tlpDashboardStats = new TableLayoutPanel();
            pnlAvailableRooms = new Panel();
            lblAvailableDescription = new Label();
            label2 = new Label();
            lblAvailableTitle = new Label();
            pnlOccupancy = new Panel();
            lblOccupancyDescription = new Label();
            lblOccupancyValue = new Label();
            lblOccupancyTitle = new Label();
            pnlCheckIns = new Panel();
            lblCheckInsDescription = new Label();
            lblCheckInsValue = new Label();
            lblCheckInsTitle = new Label();
            pnlCheckOuts = new Panel();
            lblCheckOutsDescription = new Label();
            lblCheckOutsValue = new Label();
            lblCheckOutsTitle = new Label();
            tlpDashboardHeader = new TableLayoutPanel();
            pnlDashboardTitle = new Panel();
            lblDashboardDate = new Label();
            lblDashboardTitle = new Label();
            pnlDashboardAction = new Panel();
            btnDashboardNewBooking = new Button();
            tlpDashboardBody = new TableLayoutPanel();
            pnlTodayArrivals = new Panel();
            tlpTodayArrivals = new TableLayoutPanel();
            tlpArrivalsHeader = new TableLayoutPanel();
            lblArrivalsTitle = new Label();
            lblViewAllBookings = new Label();
            dgvTodayArrivals = new DataGridView();
            colArrivalGuest = new DataGridViewTextBoxColumn();
            colArrivalRoom = new DataGridViewTextBoxColumn();
            colArrivalTime = new DataGridViewTextBoxColumn();
            colArrivalStatus = new DataGridViewTextBoxColumn();
            lblArrivalsFooter = new Label();
            pnlRoomOverview = new Panel();
            tlpRoomOverview = new TableLayoutPanel();
            panel1 = new Panel();
            lblRoomOverviewSubtitle = new Label();
            lblRoomOverviewTitle = new Label();
            tlpRoomButtons = new TableLayoutPanel();
            btnRoom101 = new Button();
            tlpRoomLegend = new TableLayoutPanel();
            panel5 = new Panel();
            lblCleaningCount = new Label();
            lblCleaningStatus = new Label();
            pnlCleaningIndicator = new Panel();
            panel4 = new Panel();
            panel6 = new Panel();
            lblReservedCount = new Label();
            pnlReservedIndicator = new Panel();
            lblReservedStatus = new Label();
            panel8 = new Panel();
            panel7 = new Panel();
            label4 = new Label();
            label3 = new Label();
            panel3 = new Panel();
            panel9 = new Panel();
            lblOccupiedCount = new Label();
            lblOccupiedStatus = new Label();
            pnlOccupiedIndicator = new Panel();
            panel11 = new Panel();
            panel10 = new Panel();
            label6 = new Label();
            label5 = new Label();
            panel2 = new Panel();
            pnlAvailableIndicator = new Panel();
            lblAvailableCount = new Label();
            lblAvailableStatus = new Label();
            pnlOccupancyIndicator = new Panel();
            prgOccupancy = new ProgressBar();
            lblOccupancyPercentage = new Label();
            lblOccupancyToday = new Label();
            tlpDashboard.SuspendLayout();
            tlpDashboardStats.SuspendLayout();
            pnlAvailableRooms.SuspendLayout();
            pnlOccupancy.SuspendLayout();
            pnlCheckIns.SuspendLayout();
            pnlCheckOuts.SuspendLayout();
            tlpDashboardHeader.SuspendLayout();
            pnlDashboardTitle.SuspendLayout();
            pnlDashboardAction.SuspendLayout();
            tlpDashboardBody.SuspendLayout();
            pnlTodayArrivals.SuspendLayout();
            tlpTodayArrivals.SuspendLayout();
            tlpArrivalsHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTodayArrivals).BeginInit();
            pnlRoomOverview.SuspendLayout();
            tlpRoomOverview.SuspendLayout();
            panel1.SuspendLayout();
            tlpRoomButtons.SuspendLayout();
            tlpRoomLegend.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            panel8.SuspendLayout();
            panel3.SuspendLayout();
            panel9.SuspendLayout();
            panel11.SuspendLayout();
            panel2.SuspendLayout();
            pnlOccupancyIndicator.SuspendLayout();
            SuspendLayout();
            // 
            // tlpDashboard
            // 
            tlpDashboard.ColumnCount = 1;
            tlpDashboard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpDashboard.Controls.Add(tlpDashboardStats, 0, 1);
            tlpDashboard.Controls.Add(tlpDashboardHeader, 0, 0);
            tlpDashboard.Controls.Add(tlpDashboardBody, 0, 2);
            tlpDashboard.Dock = DockStyle.Fill;
            tlpDashboard.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tlpDashboard.Location = new Point(22, 22);
            tlpDashboard.Margin = new Padding(0);
            tlpDashboard.Name = "tlpDashboard";
            tlpDashboard.Padding = new Padding(20);
            tlpDashboard.RowCount = 3;
            tlpDashboard.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tlpDashboard.RowStyles.Add(new RowStyle(SizeType.Absolute, 115F));
            tlpDashboard.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpDashboard.Size = new Size(1056, 756);
            tlpDashboard.TabIndex = 0;
            // 
            // tlpDashboardStats
            // 
            tlpDashboardStats.ColumnCount = 4;
            tlpDashboardStats.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpDashboardStats.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpDashboardStats.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpDashboardStats.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpDashboardStats.Controls.Add(pnlAvailableRooms, 0, 0);
            tlpDashboardStats.Controls.Add(pnlOccupancy, 1, 0);
            tlpDashboardStats.Controls.Add(pnlCheckIns, 2, 0);
            tlpDashboardStats.Controls.Add(pnlCheckOuts, 3, 0);
            tlpDashboardStats.Dock = DockStyle.Fill;
            tlpDashboardStats.Location = new Point(20, 95);
            tlpDashboardStats.Margin = new Padding(0);
            tlpDashboardStats.Name = "tlpDashboardStats";
            tlpDashboardStats.RowCount = 1;
            tlpDashboardStats.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpDashboardStats.Size = new Size(1016, 115);
            tlpDashboardStats.TabIndex = 2;
            // 
            // pnlAvailableRooms
            // 
            pnlAvailableRooms.BackColor = Color.White;
            pnlAvailableRooms.BorderStyle = BorderStyle.FixedSingle;
            pnlAvailableRooms.Controls.Add(lblAvailableDescription);
            pnlAvailableRooms.Controls.Add(label2);
            pnlAvailableRooms.Controls.Add(lblAvailableTitle);
            pnlAvailableRooms.Dock = DockStyle.Fill;
            pnlAvailableRooms.Location = new Point(0, 3);
            pnlAvailableRooms.Margin = new Padding(0, 3, 10, 3);
            pnlAvailableRooms.Name = "pnlAvailableRooms";
            pnlAvailableRooms.Padding = new Padding(12);
            pnlAvailableRooms.Size = new Size(244, 109);
            pnlAvailableRooms.TabIndex = 0;
            pnlAvailableRooms.Paint += pnlAvailableRooms_Paint;
            // 
            // lblAvailableDescription
            // 
            lblAvailableDescription.AutoSize = true;
            lblAvailableDescription.Font = new Font("Segoe UI", 8F);
            lblAvailableDescription.ForeColor = Color.FromArgb(100, 116, 139);
            lblAvailableDescription.Location = new Point(10, 70);
            lblAvailableDescription.Name = "lblAvailableDescription";
            lblAvailableDescription.Size = new Size(84, 19);
            lblAvailableDescription.TabIndex = 2;
            lblAvailableDescription.Text = "of 40 rooms";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(20, 43, 70);
            label2.Location = new Point(10, 27);
            label2.Name = "label2";
            label2.Size = new Size(64, 50);
            label2.TabIndex = 1;
            label2.Text = "12";
            // 
            // lblAvailableTitle
            // 
            lblAvailableTitle.AutoSize = true;
            lblAvailableTitle.Font = new Font("Segoe UI", 8F);
            lblAvailableTitle.ForeColor = Color.FromArgb(100, 116, 139);
            lblAvailableTitle.Location = new Point(10, 8);
            lblAvailableTitle.Name = "lblAvailableTitle";
            lblAvailableTitle.Size = new Size(121, 19);
            lblAvailableTitle.TabIndex = 0;
            lblAvailableTitle.Text = "● Available Rooms";
            // 
            // pnlOccupancy
            // 
            pnlOccupancy.BackColor = Color.White;
            pnlOccupancy.BorderStyle = BorderStyle.FixedSingle;
            pnlOccupancy.Controls.Add(lblOccupancyDescription);
            pnlOccupancy.Controls.Add(lblOccupancyValue);
            pnlOccupancy.Controls.Add(lblOccupancyTitle);
            pnlOccupancy.Dock = DockStyle.Fill;
            pnlOccupancy.Location = new Point(254, 3);
            pnlOccupancy.Margin = new Padding(0, 3, 10, 3);
            pnlOccupancy.Name = "pnlOccupancy";
            pnlOccupancy.Padding = new Padding(12);
            pnlOccupancy.Size = new Size(244, 109);
            pnlOccupancy.TabIndex = 1;
            pnlOccupancy.Paint += pnlOccupancy_Paint;
            // 
            // lblOccupancyDescription
            // 
            lblOccupancyDescription.AutoSize = true;
            lblOccupancyDescription.Font = new Font("Segoe UI", 8F);
            lblOccupancyDescription.ForeColor = Color.FromArgb(100, 116, 139);
            lblOccupancyDescription.Location = new Point(10, 70);
            lblOccupancyDescription.Name = "lblOccupancyDescription";
            lblOccupancyDescription.Size = new Size(126, 19);
            lblOccupancyDescription.TabIndex = 2;
            lblOccupancyDescription.Text = "22 rooms occupied";
            // 
            // lblOccupancyValue
            // 
            lblOccupancyValue.AutoSize = true;
            lblOccupancyValue.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOccupancyValue.ForeColor = Color.FromArgb(20, 43, 70);
            lblOccupancyValue.Location = new Point(10, 27);
            lblOccupancyValue.Name = "lblOccupancyValue";
            lblOccupancyValue.Size = new Size(96, 50);
            lblOccupancyValue.TabIndex = 1;
            lblOccupancyValue.Text = "55%";
            // 
            // lblOccupancyTitle
            // 
            lblOccupancyTitle.AutoSize = true;
            lblOccupancyTitle.Font = new Font("Segoe UI", 8F);
            lblOccupancyTitle.ForeColor = Color.FromArgb(100, 116, 139);
            lblOccupancyTitle.Location = new Point(10, 8);
            lblOccupancyTitle.Name = "lblOccupancyTitle";
            lblOccupancyTitle.Size = new Size(88, 19);
            lblOccupancyTitle.TabIndex = 0;
            lblOccupancyTitle.Text = "● Occupancy";
            // 
            // pnlCheckIns
            // 
            pnlCheckIns.BackColor = Color.White;
            pnlCheckIns.BorderStyle = BorderStyle.FixedSingle;
            pnlCheckIns.Controls.Add(lblCheckInsDescription);
            pnlCheckIns.Controls.Add(lblCheckInsValue);
            pnlCheckIns.Controls.Add(lblCheckInsTitle);
            pnlCheckIns.Dock = DockStyle.Fill;
            pnlCheckIns.Location = new Point(508, 3);
            pnlCheckIns.Margin = new Padding(0, 3, 10, 3);
            pnlCheckIns.Name = "pnlCheckIns";
            pnlCheckIns.Padding = new Padding(12);
            pnlCheckIns.Size = new Size(244, 109);
            pnlCheckIns.TabIndex = 2;
            // 
            // lblCheckInsDescription
            // 
            lblCheckInsDescription.AutoSize = true;
            lblCheckInsDescription.Font = new Font("Segoe UI", 8F);
            lblCheckInsDescription.ForeColor = Color.FromArgb(100, 116, 139);
            lblCheckInsDescription.Location = new Point(10, 70);
            lblCheckInsDescription.Name = "lblCheckInsDescription";
            lblCheckInsDescription.Size = new Size(158, 19);
            lblCheckInsDescription.TabIndex = 5;
            lblCheckInsDescription.Text = "2 completed, 5 expected";
            // 
            // lblCheckInsValue
            // 
            lblCheckInsValue.AutoSize = true;
            lblCheckInsValue.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCheckInsValue.ForeColor = Color.FromArgb(20, 43, 70);
            lblCheckInsValue.Location = new Point(10, 27);
            lblCheckInsValue.Name = "lblCheckInsValue";
            lblCheckInsValue.Size = new Size(43, 50);
            lblCheckInsValue.TabIndex = 4;
            lblCheckInsValue.Text = "7";
            // 
            // lblCheckInsTitle
            // 
            lblCheckInsTitle.AutoSize = true;
            lblCheckInsTitle.Font = new Font("Segoe UI", 8F);
            lblCheckInsTitle.ForeColor = Color.FromArgb(100, 116, 139);
            lblCheckInsTitle.Location = new Point(10, 8);
            lblCheckInsTitle.Name = "lblCheckInsTitle";
            lblCheckInsTitle.Size = new Size(121, 19);
            lblCheckInsTitle.TabIndex = 3;
            lblCheckInsTitle.Text = "● Check-ins Today";
            // 
            // pnlCheckOuts
            // 
            pnlCheckOuts.BackColor = Color.White;
            pnlCheckOuts.BorderStyle = BorderStyle.FixedSingle;
            pnlCheckOuts.Controls.Add(lblCheckOutsDescription);
            pnlCheckOuts.Controls.Add(lblCheckOutsValue);
            pnlCheckOuts.Controls.Add(lblCheckOutsTitle);
            pnlCheckOuts.Dock = DockStyle.Fill;
            pnlCheckOuts.Location = new Point(762, 3);
            pnlCheckOuts.Margin = new Padding(0, 3, 0, 3);
            pnlCheckOuts.Name = "pnlCheckOuts";
            pnlCheckOuts.Padding = new Padding(12);
            pnlCheckOuts.Size = new Size(254, 109);
            pnlCheckOuts.TabIndex = 3;
            // 
            // lblCheckOutsDescription
            // 
            lblCheckOutsDescription.AutoSize = true;
            lblCheckOutsDescription.Font = new Font("Segoe UI", 8F);
            lblCheckOutsDescription.ForeColor = Color.FromArgb(100, 116, 139);
            lblCheckOutsDescription.Location = new Point(10, 70);
            lblCheckOutsDescription.Name = "lblCheckOutsDescription";
            lblCheckOutsDescription.Size = new Size(158, 19);
            lblCheckOutsDescription.TabIndex = 5;
            lblCheckOutsDescription.Text = "3 completed, 2 expected";
            // 
            // lblCheckOutsValue
            // 
            lblCheckOutsValue.AutoSize = true;
            lblCheckOutsValue.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCheckOutsValue.ForeColor = Color.FromArgb(20, 43, 70);
            lblCheckOutsValue.Location = new Point(10, 27);
            lblCheckOutsValue.Name = "lblCheckOutsValue";
            lblCheckOutsValue.Size = new Size(43, 50);
            lblCheckOutsValue.TabIndex = 4;
            lblCheckOutsValue.Text = "5";
            // 
            // lblCheckOutsTitle
            // 
            lblCheckOutsTitle.AutoSize = true;
            lblCheckOutsTitle.Font = new Font("Segoe UI", 8F);
            lblCheckOutsTitle.ForeColor = Color.FromArgb(100, 116, 139);
            lblCheckOutsTitle.Location = new Point(10, 8);
            lblCheckOutsTitle.Name = "lblCheckOutsTitle";
            lblCheckOutsTitle.Size = new Size(131, 19);
            lblCheckOutsTitle.TabIndex = 3;
            lblCheckOutsTitle.Text = "● Check-outs Today";
            // 
            // tlpDashboardHeader
            // 
            tlpDashboardHeader.ColumnCount = 2;
            tlpDashboardHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tlpDashboardHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tlpDashboardHeader.Controls.Add(pnlDashboardTitle, 0, 0);
            tlpDashboardHeader.Controls.Add(pnlDashboardAction, 1, 0);
            tlpDashboardHeader.Dock = DockStyle.Fill;
            tlpDashboardHeader.Location = new Point(20, 20);
            tlpDashboardHeader.Margin = new Padding(0);
            tlpDashboardHeader.Name = "tlpDashboardHeader";
            tlpDashboardHeader.RowCount = 1;
            tlpDashboardHeader.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpDashboardHeader.Size = new Size(1016, 75);
            tlpDashboardHeader.TabIndex = 0;
            // 
            // pnlDashboardTitle
            // 
            pnlDashboardTitle.Controls.Add(lblDashboardDate);
            pnlDashboardTitle.Controls.Add(lblDashboardTitle);
            pnlDashboardTitle.Dock = DockStyle.Fill;
            pnlDashboardTitle.Location = new Point(0, 0);
            pnlDashboardTitle.Margin = new Padding(0);
            pnlDashboardTitle.Name = "pnlDashboardTitle";
            pnlDashboardTitle.Size = new Size(711, 75);
            pnlDashboardTitle.TabIndex = 0;
            // 
            // lblDashboardDate
            // 
            lblDashboardDate.AutoSize = true;
            lblDashboardDate.Font = new Font("Segoe UI", 8F);
            lblDashboardDate.ForeColor = Color.FromArgb(100, 116, 139);
            lblDashboardDate.Location = new Point(0, 39);
            lblDashboardDate.Name = "lblDashboardDate";
            lblDashboardDate.Size = new Size(192, 19);
            lblDashboardDate.TabIndex = 1;
            lblDashboardDate.Text = "Thursday, 19 November 2026";
            // 
            // lblDashboardTitle
            // 
            lblDashboardTitle.AutoSize = true;
            lblDashboardTitle.Font = new Font("Georgia", 21F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDashboardTitle.ForeColor = Color.FromArgb(20, 43, 70);
            lblDashboardTitle.Location = new Point(0, 0);
            lblDashboardTitle.Name = "lblDashboardTitle";
            lblDashboardTitle.Size = new Size(217, 41);
            lblDashboardTitle.TabIndex = 0;
            lblDashboardTitle.Text = "Dashboard";
            // 
            // pnlDashboardAction
            // 
            pnlDashboardAction.Controls.Add(btnDashboardNewBooking);
            pnlDashboardAction.Dock = DockStyle.Fill;
            pnlDashboardAction.Location = new Point(711, 0);
            pnlDashboardAction.Margin = new Padding(0);
            pnlDashboardAction.Name = "pnlDashboardAction";
            pnlDashboardAction.Size = new Size(305, 75);
            pnlDashboardAction.TabIndex = 1;
            // 
            // btnDashboardNewBooking
            // 
            btnDashboardNewBooking.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDashboardNewBooking.BackColor = Color.FromArgb(201, 151, 61);
            btnDashboardNewBooking.Cursor = Cursors.Hand;
            btnDashboardNewBooking.FlatAppearance.BorderSize = 0;
            btnDashboardNewBooking.FlatStyle = FlatStyle.Flat;
            btnDashboardNewBooking.ForeColor = Color.FromArgb(20, 43, 70);
            btnDashboardNewBooking.Location = new Point(-12, 5);
            btnDashboardNewBooking.Name = "btnDashboardNewBooking";
            btnDashboardNewBooking.Size = new Size(140, 40);
            btnDashboardNewBooking.TabIndex = 0;
            btnDashboardNewBooking.Text = "+ New Booking";
            btnDashboardNewBooking.UseVisualStyleBackColor = false;
            // 
            // tlpDashboardBody
            // 
            tlpDashboardBody.ColumnCount = 2;
            tlpDashboardBody.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58F));
            tlpDashboardBody.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42F));
            tlpDashboardBody.Controls.Add(pnlTodayArrivals, 0, 0);
            tlpDashboardBody.Controls.Add(pnlRoomOverview, 1, 0);
            tlpDashboardBody.Dock = DockStyle.Fill;
            tlpDashboardBody.ForeColor = SystemColors.ControlText;
            tlpDashboardBody.Location = new Point(20, 210);
            tlpDashboardBody.Margin = new Padding(0);
            tlpDashboardBody.Name = "tlpDashboardBody";
            tlpDashboardBody.RowCount = 1;
            tlpDashboardBody.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpDashboardBody.Size = new Size(1016, 526);
            tlpDashboardBody.TabIndex = 3;
            // 
            // pnlTodayArrivals
            // 
            pnlTodayArrivals.BackColor = Color.White;
            pnlTodayArrivals.BorderStyle = BorderStyle.FixedSingle;
            pnlTodayArrivals.Controls.Add(tlpTodayArrivals);
            pnlTodayArrivals.Dock = DockStyle.Fill;
            pnlTodayArrivals.Location = new Point(0, 12);
            pnlTodayArrivals.Margin = new Padding(0, 12, 8, 0);
            pnlTodayArrivals.Name = "pnlTodayArrivals";
            pnlTodayArrivals.Padding = new Padding(14);
            pnlTodayArrivals.Size = new Size(581, 514);
            pnlTodayArrivals.TabIndex = 0;
            // 
            // tlpTodayArrivals
            // 
            tlpTodayArrivals.ColumnCount = 1;
            tlpTodayArrivals.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpTodayArrivals.Controls.Add(tlpArrivalsHeader, 0, 0);
            tlpTodayArrivals.Controls.Add(dgvTodayArrivals, 0, 1);
            tlpTodayArrivals.Controls.Add(lblArrivalsFooter, 0, 2);
            tlpTodayArrivals.Dock = DockStyle.Fill;
            tlpTodayArrivals.Location = new Point(14, 14);
            tlpTodayArrivals.Margin = new Padding(0);
            tlpTodayArrivals.Name = "tlpTodayArrivals";
            tlpTodayArrivals.RowCount = 3;
            tlpTodayArrivals.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tlpTodayArrivals.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpTodayArrivals.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tlpTodayArrivals.Size = new Size(551, 484);
            tlpTodayArrivals.TabIndex = 0;
            // 
            // tlpArrivalsHeader
            // 
            tlpArrivalsHeader.ColumnCount = 2;
            tlpArrivalsHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpArrivalsHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpArrivalsHeader.Controls.Add(lblArrivalsTitle, 0, 0);
            tlpArrivalsHeader.Controls.Add(lblViewAllBookings, 1, 0);
            tlpArrivalsHeader.Dock = DockStyle.Fill;
            tlpArrivalsHeader.Location = new Point(3, 3);
            tlpArrivalsHeader.Name = "tlpArrivalsHeader";
            tlpArrivalsHeader.RowCount = 1;
            tlpArrivalsHeader.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpArrivalsHeader.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpArrivalsHeader.Size = new Size(545, 29);
            tlpArrivalsHeader.TabIndex = 0;
            // 
            // lblArrivalsTitle
            // 
            lblArrivalsTitle.AutoSize = true;
            lblArrivalsTitle.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblArrivalsTitle.ForeColor = Color.FromArgb(20, 43, 70);
            lblArrivalsTitle.Location = new Point(3, 0);
            lblArrivalsTitle.Name = "lblArrivalsTitle";
            lblArrivalsTitle.Size = new Size(145, 25);
            lblArrivalsTitle.TabIndex = 0;
            lblArrivalsTitle.Text = "Today's Arrivals";
            // 
            // lblViewAllBookings
            // 
            lblViewAllBookings.AutoSize = true;
            lblViewAllBookings.Cursor = Cursors.Hand;
            lblViewAllBookings.Dock = DockStyle.Fill;
            lblViewAllBookings.Font = new Font("Segoe UI", 8F);
            lblViewAllBookings.ForeColor = Color.FromArgb(177, 125, 39);
            lblViewAllBookings.Location = new Point(275, 0);
            lblViewAllBookings.Name = "lblViewAllBookings";
            lblViewAllBookings.Size = new Size(267, 29);
            lblViewAllBookings.TabIndex = 1;
            lblViewAllBookings.Text = "View all bookings →";
            lblViewAllBookings.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvTodayArrivals
            // 
            dgvTodayArrivals.AllowUserToAddRows = false;
            dgvTodayArrivals.AllowUserToDeleteRows = false;
            dgvTodayArrivals.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTodayArrivals.BackgroundColor = Color.White;
            dgvTodayArrivals.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 8F);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(20, 43, 70);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(251, 243, 226);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(20, 43, 70);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvTodayArrivals.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvTodayArrivals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTodayArrivals.Columns.AddRange(new DataGridViewColumn[] { colArrivalGuest, colArrivalRoom, colArrivalTime, colArrivalStatus });
            dgvTodayArrivals.Dock = DockStyle.Fill;
            dgvTodayArrivals.EnableHeadersVisualStyles = false;
            dgvTodayArrivals.GridColor = Color.FromArgb(238, 234, 228);
            dgvTodayArrivals.Location = new Point(3, 38);
            dgvTodayArrivals.MultiSelect = false;
            dgvTodayArrivals.Name = "dgvTodayArrivals";
            dgvTodayArrivals.ReadOnly = true;
            dgvTodayArrivals.RowHeadersVisible = false;
            dgvTodayArrivals.RowHeadersWidth = 51;
            dgvTodayArrivals.RowTemplate.Height = 45;
            dgvTodayArrivals.ScrollBars = ScrollBars.Vertical;
            dgvTodayArrivals.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTodayArrivals.Size = new Size(545, 418);
            dgvTodayArrivals.TabIndex = 1;
            dgvTodayArrivals.CellContentClick += dgvTodayArrivals_CellContentClick;
            // 
            // colArrivalGuest
            // 
            colArrivalGuest.FillWeight = 45F;
            colArrivalGuest.HeaderText = "GUEST";
            colArrivalGuest.MinimumWidth = 6;
            colArrivalGuest.Name = "colArrivalGuest";
            colArrivalGuest.ReadOnly = true;
            // 
            // colArrivalRoom
            // 
            colArrivalRoom.FillWeight = 15F;
            colArrivalRoom.HeaderText = "ROOM";
            colArrivalRoom.MinimumWidth = 6;
            colArrivalRoom.Name = "colArrivalRoom";
            colArrivalRoom.ReadOnly = true;
            // 
            // colArrivalTime
            // 
            colArrivalTime.FillWeight = 18F;
            colArrivalTime.HeaderText = "ARRIVAL";
            colArrivalTime.MinimumWidth = 6;
            colArrivalTime.Name = "colArrivalTime";
            colArrivalTime.ReadOnly = true;
            // 
            // colArrivalStatus
            // 
            colArrivalStatus.FillWeight = 30F;
            colArrivalStatus.HeaderText = "STATUS";
            colArrivalStatus.MinimumWidth = 6;
            colArrivalStatus.Name = "colArrivalStatus";
            colArrivalStatus.ReadOnly = true;
            // 
            // lblArrivalsFooter
            // 
            lblArrivalsFooter.AutoSize = true;
            lblArrivalsFooter.Dock = DockStyle.Fill;
            lblArrivalsFooter.Font = new Font("Segoe UI", 8F);
            lblArrivalsFooter.ForeColor = Color.FromArgb(100, 116, 139);
            lblArrivalsFooter.Location = new Point(3, 459);
            lblArrivalsFooter.Name = "lblArrivalsFooter";
            lblArrivalsFooter.Size = new Size(545, 25);
            lblArrivalsFooter.TabIndex = 2;
            lblArrivalsFooter.Text = "Showing today's arrivals";
            lblArrivalsFooter.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlRoomOverview
            // 
            pnlRoomOverview.BackColor = Color.White;
            pnlRoomOverview.BorderStyle = BorderStyle.FixedSingle;
            pnlRoomOverview.Controls.Add(tlpRoomOverview);
            pnlRoomOverview.Dock = DockStyle.Fill;
            pnlRoomOverview.Location = new Point(597, 12);
            pnlRoomOverview.Margin = new Padding(8, 12, 0, 0);
            pnlRoomOverview.Name = "pnlRoomOverview";
            pnlRoomOverview.Padding = new Padding(14);
            pnlRoomOverview.Size = new Size(419, 514);
            pnlRoomOverview.TabIndex = 1;
            // 
            // tlpRoomOverview
            // 
            tlpRoomOverview.ColumnCount = 1;
            tlpRoomOverview.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpRoomOverview.Controls.Add(panel1, 0, 0);
            tlpRoomOverview.Controls.Add(tlpRoomButtons, 0, 1);
            tlpRoomOverview.Controls.Add(tlpRoomLegend, 0, 2);
            tlpRoomOverview.Controls.Add(pnlOccupancyIndicator, 0, 3);
            tlpRoomOverview.Dock = DockStyle.Fill;
            tlpRoomOverview.Location = new Point(14, 14);
            tlpRoomOverview.Margin = new Padding(0);
            tlpRoomOverview.Name = "tlpRoomOverview";
            tlpRoomOverview.RowCount = 4;
            tlpRoomOverview.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tlpRoomOverview.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpRoomOverview.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tlpRoomOverview.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tlpRoomOverview.Size = new Size(389, 484);
            tlpRoomOverview.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblRoomOverviewSubtitle);
            panel1.Controls.Add(lblRoomOverviewTitle);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(383, 42);
            panel1.TabIndex = 1;
            // 
            // lblRoomOverviewSubtitle
            // 
            lblRoomOverviewSubtitle.AutoSize = true;
            lblRoomOverviewSubtitle.Font = new Font("Segoe UI", 8F);
            lblRoomOverviewSubtitle.ForeColor = Color.FromArgb(100, 116, 139);
            lblRoomOverviewSubtitle.Location = new Point(0, 23);
            lblRoomOverviewSubtitle.Name = "lblRoomOverviewSubtitle";
            lblRoomOverviewSubtitle.Size = new Size(189, 19);
            lblRoomOverviewSubtitle.TabIndex = 1;
            lblRoomOverviewSubtitle.Text = "40 rooms across floors 1 to 4";
            // 
            // lblRoomOverviewTitle
            // 
            lblRoomOverviewTitle.AutoSize = true;
            lblRoomOverviewTitle.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRoomOverviewTitle.ForeColor = Color.FromArgb(20, 43, 70);
            lblRoomOverviewTitle.Location = new Point(0, 0);
            lblRoomOverviewTitle.Name = "lblRoomOverviewTitle";
            lblRoomOverviewTitle.Size = new Size(148, 25);
            lblRoomOverviewTitle.TabIndex = 0;
            lblRoomOverviewTitle.Text = "Room Overview";
            // 
            // tlpRoomButtons
            // 
            tlpRoomButtons.ColumnCount = 10;
            tlpRoomButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tlpRoomButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tlpRoomButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tlpRoomButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tlpRoomButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tlpRoomButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tlpRoomButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tlpRoomButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tlpRoomButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tlpRoomButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tlpRoomButtons.Controls.Add(btnRoom101, 0, 0);
            tlpRoomButtons.Dock = DockStyle.Fill;
            tlpRoomButtons.Location = new Point(0, 48);
            tlpRoomButtons.Margin = new Padding(0);
            tlpRoomButtons.Name = "tlpRoomButtons";
            tlpRoomButtons.RowCount = 4;
            tlpRoomButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpRoomButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpRoomButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpRoomButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpRoomButtons.Size = new Size(389, 316);
            tlpRoomButtons.TabIndex = 2;
            // 
            // btnRoom101
            // 
            btnRoom101.BackColor = Color.FromArgb(220, 239, 229);
            btnRoom101.Cursor = Cursors.Hand;
            btnRoom101.Dock = DockStyle.Fill;
            btnRoom101.FlatStyle = FlatStyle.Flat;
            btnRoom101.Font = new Font("Segoe UI", 8F);
            btnRoom101.ForeColor = Color.FromArgb(36, 107, 72);
            btnRoom101.Location = new Point(2, 2);
            btnRoom101.Margin = new Padding(2);
            btnRoom101.Name = "btnRoom101";
            btnRoom101.Size = new Size(34, 75);
            btnRoom101.TabIndex = 0;
            btnRoom101.Text = "101";
            btnRoom101.UseVisualStyleBackColor = false;
            // 
            // tlpRoomLegend
            // 
            tlpRoomLegend.ColumnCount = 2;
            tlpRoomLegend.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpRoomLegend.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpRoomLegend.Controls.Add(panel5, 1, 1);
            tlpRoomLegend.Controls.Add(panel4, 0, 1);
            tlpRoomLegend.Controls.Add(panel3, 1, 0);
            tlpRoomLegend.Controls.Add(panel2, 0, 0);
            tlpRoomLegend.Dock = DockStyle.Fill;
            tlpRoomLegend.Location = new Point(0, 364);
            tlpRoomLegend.Margin = new Padding(0);
            tlpRoomLegend.Name = "tlpRoomLegend";
            tlpRoomLegend.Padding = new Padding(3);
            tlpRoomLegend.RowCount = 2;
            tlpRoomLegend.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpRoomLegend.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpRoomLegend.Size = new Size(389, 75);
            tlpRoomLegend.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.Controls.Add(lblCleaningCount);
            panel5.Controls.Add(lblCleaningStatus);
            panel5.Controls.Add(pnlCleaningIndicator);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(194, 37);
            panel5.Margin = new Padding(0);
            panel5.Name = "panel5";
            panel5.Size = new Size(192, 35);
            panel5.TabIndex = 3;
            // 
            // lblCleaningCount
            // 
            lblCleaningCount.AutoSize = true;
            lblCleaningCount.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCleaningCount.ForeColor = Color.FromArgb(20, 43, 70);
            lblCleaningCount.Location = new Point(165, 8);
            lblCleaningCount.Name = "lblCleaningCount";
            lblCleaningCount.Size = new Size(20, 23);
            lblCleaningCount.TabIndex = 7;
            lblCleaningCount.Text = "2";
            // 
            // lblCleaningStatus
            // 
            lblCleaningStatus.AutoSize = true;
            lblCleaningStatus.Font = new Font("Segoe UI", 8F);
            lblCleaningStatus.ForeColor = Color.FromArgb(20, 43, 70);
            lblCleaningStatus.Location = new Point(63, 8);
            lblCleaningStatus.Name = "lblCleaningStatus";
            lblCleaningStatus.Size = new Size(62, 19);
            lblCleaningStatus.TabIndex = 6;
            lblCleaningStatus.Text = "Cleaning";
            // 
            // pnlCleaningIndicator
            // 
            pnlCleaningIndicator.BackColor = Color.CornflowerBlue;
            pnlCleaningIndicator.BorderStyle = BorderStyle.FixedSingle;
            pnlCleaningIndicator.Location = new Point(3, 11);
            pnlCleaningIndicator.Name = "pnlCleaningIndicator";
            pnlCleaningIndicator.Size = new Size(15, 15);
            pnlCleaningIndicator.TabIndex = 5;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(panel8);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 37);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(191, 35);
            panel4.TabIndex = 2;
            // 
            // panel6
            // 
            panel6.Controls.Add(lblReservedCount);
            panel6.Controls.Add(pnlReservedIndicator);
            panel6.Controls.Add(lblReservedStatus);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(0, 0);
            panel6.Margin = new Padding(0);
            panel6.Name = "panel6";
            panel6.Size = new Size(191, 35);
            panel6.TabIndex = 5;
            // 
            // lblReservedCount
            // 
            lblReservedCount.AutoSize = true;
            lblReservedCount.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReservedCount.ForeColor = Color.FromArgb(20, 43, 70);
            lblReservedCount.Location = new Point(158, 9);
            lblReservedCount.Name = "lblReservedCount";
            lblReservedCount.Size = new Size(20, 23);
            lblReservedCount.TabIndex = 4;
            lblReservedCount.Text = "4";
            // 
            // pnlReservedIndicator
            // 
            pnlReservedIndicator.BackColor = Color.Pink;
            pnlReservedIndicator.BorderStyle = BorderStyle.FixedSingle;
            pnlReservedIndicator.Location = new Point(3, 11);
            pnlReservedIndicator.Name = "pnlReservedIndicator";
            pnlReservedIndicator.Size = new Size(15, 15);
            pnlReservedIndicator.TabIndex = 3;
            // 
            // lblReservedStatus
            // 
            lblReservedStatus.AutoSize = true;
            lblReservedStatus.Font = new Font("Segoe UI", 8F);
            lblReservedStatus.ForeColor = Color.FromArgb(20, 43, 70);
            lblReservedStatus.Location = new Point(59, 7);
            lblReservedStatus.Name = "lblReservedStatus";
            lblReservedStatus.Size = new Size(64, 19);
            lblReservedStatus.TabIndex = 1;
            lblReservedStatus.Text = "Reserved";
            // 
            // panel8
            // 
            panel8.Controls.Add(panel7);
            panel8.Controls.Add(label4);
            panel8.Controls.Add(label3);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(0, 0);
            panel8.Margin = new Padding(0);
            panel8.Name = "panel8";
            panel8.Size = new Size(191, 35);
            panel8.TabIndex = 4;
            // 
            // panel7
            // 
            panel7.BackColor = Color.SpringGreen;
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Location = new Point(3, 15);
            panel7.Name = "panel7";
            panel7.Size = new Size(9, 9);
            panel7.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(20, 43, 70);
            label4.Location = new Point(158, 7);
            label4.Name = "label4";
            label4.Size = new Size(22, 17);
            label4.TabIndex = 1;
            label4.Text = "12";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8F);
            label3.ForeColor = Color.FromArgb(20, 43, 70);
            label3.Location = new Point(59, 7);
            label3.Name = "label3";
            label3.Size = new Size(63, 19);
            label3.TabIndex = 0;
            label3.Text = "Available";
            // 
            // panel3
            // 
            panel3.Controls.Add(panel9);
            panel3.Controls.Add(panel11);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(194, 3);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(192, 34);
            panel3.TabIndex = 1;
            // 
            // panel9
            // 
            panel9.Controls.Add(lblOccupiedCount);
            panel9.Controls.Add(lblOccupiedStatus);
            panel9.Controls.Add(pnlOccupiedIndicator);
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(0, 0);
            panel9.Margin = new Padding(0);
            panel9.Name = "panel9";
            panel9.Size = new Size(192, 34);
            panel9.TabIndex = 5;
            // 
            // lblOccupiedCount
            // 
            lblOccupiedCount.AutoSize = true;
            lblOccupiedCount.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOccupiedCount.ForeColor = Color.FromArgb(20, 43, 70);
            lblOccupiedCount.Location = new Point(165, 8);
            lblOccupiedCount.Name = "lblOccupiedCount";
            lblOccupiedCount.Size = new Size(20, 23);
            lblOccupiedCount.TabIndex = 6;
            lblOccupiedCount.Text = "4";
            // 
            // lblOccupiedStatus
            // 
            lblOccupiedStatus.AutoSize = true;
            lblOccupiedStatus.Font = new Font("Segoe UI", 8F);
            lblOccupiedStatus.ForeColor = Color.FromArgb(20, 43, 70);
            lblOccupiedStatus.Location = new Point(64, 8);
            lblOccupiedStatus.Name = "lblOccupiedStatus";
            lblOccupiedStatus.Size = new Size(66, 19);
            lblOccupiedStatus.TabIndex = 5;
            lblOccupiedStatus.Text = "Occupied";
            // 
            // pnlOccupiedIndicator
            // 
            pnlOccupiedIndicator.BackColor = Color.Salmon;
            pnlOccupiedIndicator.BorderStyle = BorderStyle.FixedSingle;
            pnlOccupiedIndicator.Location = new Point(3, 11);
            pnlOccupiedIndicator.Name = "pnlOccupiedIndicator";
            pnlOccupiedIndicator.Size = new Size(15, 15);
            pnlOccupiedIndicator.TabIndex = 4;
            // 
            // panel11
            // 
            panel11.Controls.Add(panel10);
            panel11.Controls.Add(label6);
            panel11.Controls.Add(label5);
            panel11.Dock = DockStyle.Fill;
            panel11.Location = new Point(0, 0);
            panel11.Margin = new Padding(0);
            panel11.Name = "panel11";
            panel11.Size = new Size(192, 34);
            panel11.TabIndex = 4;
            // 
            // panel10
            // 
            panel10.BackColor = Color.SpringGreen;
            panel10.BorderStyle = BorderStyle.FixedSingle;
            panel10.Location = new Point(3, 15);
            panel10.Name = "panel10";
            panel10.Size = new Size(9, 9);
            panel10.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(20, 43, 70);
            label6.Location = new Point(158, 7);
            label6.Name = "label6";
            label6.Size = new Size(22, 17);
            label6.TabIndex = 1;
            label6.Text = "12";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 8F);
            label5.ForeColor = Color.FromArgb(20, 43, 70);
            label5.Location = new Point(59, 7);
            label5.Name = "label5";
            label5.Size = new Size(63, 19);
            label5.TabIndex = 0;
            label5.Text = "Available";
            // 
            // panel2
            // 
            panel2.Controls.Add(pnlAvailableIndicator);
            panel2.Controls.Add(lblAvailableCount);
            panel2.Controls.Add(lblAvailableStatus);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(191, 34);
            panel2.TabIndex = 0;
            // 
            // pnlAvailableIndicator
            // 
            pnlAvailableIndicator.BackColor = Color.MediumAquamarine;
            pnlAvailableIndicator.BorderStyle = BorderStyle.FixedSingle;
            pnlAvailableIndicator.Location = new Point(3, 11);
            pnlAvailableIndicator.Name = "pnlAvailableIndicator";
            pnlAvailableIndicator.Size = new Size(15, 15);
            pnlAvailableIndicator.TabIndex = 2;
            // 
            // lblAvailableCount
            // 
            lblAvailableCount.AutoSize = true;
            lblAvailableCount.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAvailableCount.ForeColor = Color.FromArgb(20, 43, 70);
            lblAvailableCount.Location = new Point(158, 7);
            lblAvailableCount.Name = "lblAvailableCount";
            lblAvailableCount.Size = new Size(30, 23);
            lblAvailableCount.TabIndex = 1;
            lblAvailableCount.Text = "12";
            // 
            // lblAvailableStatus
            // 
            lblAvailableStatus.AutoSize = true;
            lblAvailableStatus.Font = new Font("Segoe UI", 8F);
            lblAvailableStatus.ForeColor = Color.FromArgb(20, 43, 70);
            lblAvailableStatus.Location = new Point(59, 7);
            lblAvailableStatus.Name = "lblAvailableStatus";
            lblAvailableStatus.Size = new Size(63, 19);
            lblAvailableStatus.TabIndex = 0;
            lblAvailableStatus.Text = "Available";
            lblAvailableStatus.Click += lblAvailableStatus_Click;
            // 
            // pnlOccupancyIndicator
            // 
            pnlOccupancyIndicator.Controls.Add(prgOccupancy);
            pnlOccupancyIndicator.Controls.Add(lblOccupancyPercentage);
            pnlOccupancyIndicator.Controls.Add(lblOccupancyToday);
            pnlOccupancyIndicator.Dock = DockStyle.Fill;
            pnlOccupancyIndicator.Location = new Point(0, 439);
            pnlOccupancyIndicator.Margin = new Padding(0);
            pnlOccupancyIndicator.Name = "pnlOccupancyIndicator";
            pnlOccupancyIndicator.Size = new Size(389, 45);
            pnlOccupancyIndicator.TabIndex = 4;
            // 
            // prgOccupancy
            // 
            prgOccupancy.Location = new Point(22, 22);
            prgOccupancy.Name = "prgOccupancy";
            prgOccupancy.Size = new Size(349, 10);
            prgOccupancy.TabIndex = 2;
            prgOccupancy.Value = 55;
            // 
            // lblOccupancyPercentage
            // 
            lblOccupancyPercentage.AutoSize = true;
            lblOccupancyPercentage.Location = new Point(334, 0);
            lblOccupancyPercentage.Name = "lblOccupancyPercentage";
            lblOccupancyPercentage.Size = new Size(37, 20);
            lblOccupancyPercentage.TabIndex = 1;
            lblOccupancyPercentage.Text = "55%";
            lblOccupancyPercentage.Click += lblOccupancyPercentage_Click;
            // 
            // lblOccupancyToday
            // 
            lblOccupancyToday.AutoSize = true;
            lblOccupancyToday.Font = new Font("Segoe UI", 8F);
            lblOccupancyToday.Location = new Point(22, 0);
            lblOccupancyToday.Name = "lblOccupancyToday";
            lblOccupancyToday.Size = new Size(115, 19);
            lblOccupancyToday.TabIndex = 0;
            lblOccupancyToday.Text = "Occupancy today";
            // 
            // ucDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 243, 239);
            Controls.Add(tlpDashboard);
            Margin = new Padding(0);
            Name = "ucDashboard";
            Padding = new Padding(22);
            Size = new Size(1100, 800);
            Load += ucDashboard_Load;
            tlpDashboard.ResumeLayout(false);
            tlpDashboardStats.ResumeLayout(false);
            pnlAvailableRooms.ResumeLayout(false);
            pnlAvailableRooms.PerformLayout();
            pnlOccupancy.ResumeLayout(false);
            pnlOccupancy.PerformLayout();
            pnlCheckIns.ResumeLayout(false);
            pnlCheckIns.PerformLayout();
            pnlCheckOuts.ResumeLayout(false);
            pnlCheckOuts.PerformLayout();
            tlpDashboardHeader.ResumeLayout(false);
            pnlDashboardTitle.ResumeLayout(false);
            pnlDashboardTitle.PerformLayout();
            pnlDashboardAction.ResumeLayout(false);
            tlpDashboardBody.ResumeLayout(false);
            pnlTodayArrivals.ResumeLayout(false);
            tlpTodayArrivals.ResumeLayout(false);
            tlpTodayArrivals.PerformLayout();
            tlpArrivalsHeader.ResumeLayout(false);
            tlpArrivalsHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTodayArrivals).EndInit();
            pnlRoomOverview.ResumeLayout(false);
            tlpRoomOverview.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tlpRoomButtons.ResumeLayout(false);
            tlpRoomLegend.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel3.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            pnlOccupancyIndicator.ResumeLayout(false);
            pnlOccupancyIndicator.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpDashboard;
        private TableLayoutPanel tlpDashboardHeader;
        private Panel pnlDashboardTitle;
        private Label lblDashboardDate;
        private Label lblDashboardTitle;
        private Panel pnlDashboardAction;
        private Button btnDashboardNewBooking;
        private TableLayoutPanel tlpDashboardStats;
        private Panel pnlAvailableRooms;
        private Panel pnlOccupancy;
        private Panel pnlCheckIns;
        private Panel pnlCheckOuts;
        private Label lblAvailableDescription;
        private Label label2;
        private Label lblAvailableTitle;
        private Label lblOccupancyValue;
        private Label lblOccupancyTitle;
        private Label lblOccupancyDescription;
        private Label lblCheckInsDescription;
        private Label lblCheckInsValue;
        private Label lblCheckInsTitle;
        private Label lblCheckOutsDescription;
        private Label lblCheckOutsValue;
        private Label lblCheckOutsTitle;
        private TableLayoutPanel tlpDashboardBody;
        private Panel pnlTodayArrivals;
        private TableLayoutPanel tlpTodayArrivals;
        private Panel pnlRoomOverview;
        private TableLayoutPanel tlpArrivalsHeader;
        private Label lblArrivalsTitle;
        private Label lblViewAllBookings;
        private DataGridView dgvTodayArrivals;
        private DataGridViewTextBoxColumn colArrivalGuest;
        private DataGridViewTextBoxColumn colArrivalRoom;
        private DataGridViewTextBoxColumn colArrivalTime;
        private DataGridViewTextBoxColumn colArrivalStatus;
        private Label lblArrivalsFooter;
        private TableLayoutPanel tlpRoomOverview;
        private Label lblRoomOverviewTitle;
        private Panel panel1;
        private Label lblRoomOverviewSubtitle;
        private TableLayoutPanel tlpRoomButtons;
        private Button btnRoom101;
        private TableLayoutPanel tlpRoomLegend;
        private Panel pnlOccupancyIndicator;
        private Label lblOccupancyToday;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Label lblAvailableStatus;
        private Label lblAvailableCount;
        private Panel pnlAvailableIndicator;
        private Panel panel6;
        private Label lblReservedCount;
        private Panel pnlReservedIndicator;
        private Label lblReservedStatus;
        private Panel panel8;
        private Panel panel7;
        private Label label4;
        private Label label3;
        private Panel panel9;
        private Panel pnlOccupiedIndicator;
        private Panel panel11;
        private Panel panel10;
        private Label label6;
        private Label label5;
        private Label lblCleaningCount;
        private Label lblCleaningStatus;
        private Panel pnlCleaningIndicator;
        private Label lblOccupiedCount;
        private Label lblOccupiedStatus;
        private ProgressBar prgOccupancy;
        private Label lblOccupancyPercentage;
    }
}
