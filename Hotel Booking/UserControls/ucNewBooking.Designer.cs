namespace Hotel_Booking.UserControls
{
    partial class ucNewBooking
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            tlpBookingMain = new TableLayoutPanel();
            pnlBookingHeader = new Panel();
            tlpHeader = new TableLayoutPanel();
            panel1 = new Panel();
            lblBookingSubtitle = new Label();
            lblBookingTitle = new Label();
            flpBookingSteps = new FlowLayoutPanel();
            lblStep1 = new Label();
            lblStepDates = new Label();
            lblStep2 = new Label();
            lblStepRoom = new Label();
            lblStep3 = new Label();
            lblStepConfirm = new Label();
            pnlSearchFilters = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            dtpCheckIn = new Panel();
            dateTimePicker1 = new DateTimePicker();
            lblCheckIn = new Label();
            panel2 = new Panel();
            dtpCheckOut = new DateTimePicker();
            lblCheckOut = new Label();
            panel3 = new Panel();
            cmbAdults = new ComboBox();
            lblAdults = new Label();
            panel4 = new Panel();
            cmbRoomType = new ComboBox();
            lblRoomType = new Label();
            btnSearchRooms = new Button();
            lblNightsCount = new Label();
            tlpBookingBody = new TableLayoutPanel();
            pnlAvailableRooms = new Panel();
            tlpAvailableRooms = new TableLayoutPanel();
            tlpAvailableRoomsHeader = new TableLayoutPanel();
            lblAvailableRoomsTitle = new Label();
            lblAvailableRoomsCount = new Label();
            dgvAvailableRooms = new DataGridView();
            colRoomNumber = new DataGridViewTextBoxColumn();
            colRoomType = new DataGridViewTextBoxColumn();
            colBeds = new DataGridViewTextBoxColumn();
            colRate = new DataGridViewTextBoxColumn();
            colSelectRoom = new DataGridViewButtonColumn();
            pnlBookingSummary = new Panel();
            tlpPriceBreakdown = new TableLayoutPanel();
            lblBookingSummaryTitle = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            lblGuest = new Label();
            cmbBookingGuest = new ComboBox();
            btnNewGuest = new Button();
            panel5 = new Panel();
            tableLayoutPanel4 = new TableLayoutPanel();
            lblSummaryRoom = new Label();
            lblSummaryStay = new Label();
            lblSummaryRate = new Label();
            lblSummarySubtotal = new Label();
            lblSummaryTax = new Label();
            lblSummaryTotal = new Label();
            lblSummaryRoomValue = new Label();
            lblSummaryStayValue = new Label();
            lblSummaryRateValue = new Label();
            lblSummarySubtotalValue = new Label();
            lblSummaryTaxValue = new Label();
            lblSummaryTotalValue = new Label();
            pnlSpecialRequests = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            lblSpecialRequests = new Label();
            txtSpecialRequests = new TextBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            btnConfirmBooking = new Button();
            btnCancelBooking = new Button();
            tlpBookingMain.SuspendLayout();
            pnlBookingHeader.SuspendLayout();
            tlpHeader.SuspendLayout();
            panel1.SuspendLayout();
            flpBookingSteps.SuspendLayout();
            pnlSearchFilters.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            dtpCheckIn.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            tlpBookingBody.SuspendLayout();
            pnlAvailableRooms.SuspendLayout();
            tlpAvailableRooms.SuspendLayout();
            tlpAvailableRoomsHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAvailableRooms).BeginInit();
            pnlBookingSummary.SuspendLayout();
            tlpPriceBreakdown.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel5.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            pnlSpecialRequests.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // tlpBookingMain
            // 
            tlpBookingMain.ColumnCount = 1;
            tlpBookingMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpBookingMain.Controls.Add(pnlBookingHeader, 0, 0);
            tlpBookingMain.Controls.Add(pnlSearchFilters, 0, 1);
            tlpBookingMain.Controls.Add(tlpBookingBody, 0, 2);
            tlpBookingMain.Dock = DockStyle.Fill;
            tlpBookingMain.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tlpBookingMain.Location = new Point(0, 0);
            tlpBookingMain.Margin = new Padding(0);
            tlpBookingMain.Name = "tlpBookingMain";
            tlpBookingMain.Padding = new Padding(10, 15, 20, 20);
            tlpBookingMain.RowCount = 3;
            tlpBookingMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 85F));
            tlpBookingMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 94F));
            tlpBookingMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpBookingMain.Size = new Size(1337, 781);
            tlpBookingMain.TabIndex = 0;
            // 
            // pnlBookingHeader
            // 
            pnlBookingHeader.Controls.Add(tlpHeader);
            pnlBookingHeader.Dock = DockStyle.Fill;
            pnlBookingHeader.Location = new Point(10, 15);
            pnlBookingHeader.Margin = new Padding(0);
            pnlBookingHeader.Name = "pnlBookingHeader";
            pnlBookingHeader.Size = new Size(1307, 85);
            pnlBookingHeader.TabIndex = 0;
            // 
            // tlpHeader
            // 
            tlpHeader.ColumnCount = 2;
            tlpHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tlpHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tlpHeader.Controls.Add(panel1, 0, 0);
            tlpHeader.Controls.Add(flpBookingSteps, 1, 0);
            tlpHeader.Dock = DockStyle.Fill;
            tlpHeader.Location = new Point(0, 0);
            tlpHeader.Margin = new Padding(0);
            tlpHeader.Name = "tlpHeader";
            tlpHeader.RowCount = 1;
            tlpHeader.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpHeader.Size = new Size(1307, 85);
            tlpHeader.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblBookingSubtitle);
            panel1.Controls.Add(lblBookingTitle);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(843, 79);
            panel1.TabIndex = 0;
            // 
            // lblBookingSubtitle
            // 
            lblBookingSubtitle.AutoSize = true;
            lblBookingSubtitle.ForeColor = Color.FromArgb(105, 119, 139);
            lblBookingSubtitle.Location = new Point(0, 48);
            lblBookingSubtitle.Name = "lblBookingSubtitle";
            lblBookingSubtitle.Size = new Size(461, 20);
            lblBookingSubtitle.TabIndex = 1;
            lblBookingSubtitle.Text = "Pick the dates, choose a free room, then confirm the guest and price.";
            // 
            // lblBookingTitle
            // 
            lblBookingTitle.AutoSize = true;
            lblBookingTitle.Font = new Font("Georgia", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBookingTitle.ForeColor = Color.FromArgb(25, 45, 68);
            lblBookingTitle.Location = new Point(0, 5);
            lblBookingTitle.Name = "lblBookingTitle";
            lblBookingTitle.Size = new Size(271, 43);
            lblBookingTitle.TabIndex = 0;
            lblBookingTitle.Text = "New Booking";
            // 
            // flpBookingSteps
            // 
            flpBookingSteps.Controls.Add(lblStep1);
            flpBookingSteps.Controls.Add(lblStepDates);
            flpBookingSteps.Controls.Add(lblStep2);
            flpBookingSteps.Controls.Add(lblStepRoom);
            flpBookingSteps.Controls.Add(lblStep3);
            flpBookingSteps.Controls.Add(lblStepConfirm);
            flpBookingSteps.Dock = DockStyle.Fill;
            flpBookingSteps.Location = new Point(849, 0);
            flpBookingSteps.Margin = new Padding(0);
            flpBookingSteps.Name = "flpBookingSteps";
            flpBookingSteps.Padding = new Padding(0, 18, 0, 0);
            flpBookingSteps.Size = new Size(458, 85);
            flpBookingSteps.TabIndex = 1;
            flpBookingSteps.WrapContents = false;
            // 
            // lblStep1
            // 
            lblStep1.AutoSize = true;
            lblStep1.BackColor = Color.FromArgb(31, 112, 83);
            lblStep1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStep1.ForeColor = Color.White;
            lblStep1.Location = new Point(0, 18);
            lblStep1.Margin = new Padding(0, 0, 5, 0);
            lblStep1.Name = "lblStep1";
            lblStep1.Size = new Size(18, 20);
            lblStep1.TabIndex = 0;
            lblStep1.Text = "1";
            lblStep1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStepDates
            // 
            lblStepDates.AutoSize = true;
            lblStepDates.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStepDates.ForeColor = Color.FromArgb(25, 45, 68);
            lblStepDates.Location = new Point(23, 22);
            lblStepDates.Margin = new Padding(0, 4, 12, 0);
            lblStepDates.Name = "lblStepDates";
            lblStepDates.Size = new Size(49, 20);
            lblStepDates.TabIndex = 1;
            lblStepDates.Text = "Dates";
            // 
            // lblStep2
            // 
            lblStep2.AutoSize = true;
            lblStep2.BackColor = Color.FromArgb(25, 45, 68);
            lblStep2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStep2.ForeColor = Color.White;
            lblStep2.Location = new Point(84, 18);
            lblStep2.Margin = new Padding(0, 0, 5, 0);
            lblStep2.Name = "lblStep2";
            lblStep2.Size = new Size(18, 20);
            lblStep2.TabIndex = 2;
            lblStep2.Text = "2";
            lblStep2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStepRoom
            // 
            lblStepRoom.AutoSize = true;
            lblStepRoom.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStepRoom.ForeColor = Color.FromArgb(25, 45, 68);
            lblStepRoom.Location = new Point(107, 22);
            lblStepRoom.Margin = new Padding(0, 4, 12, 0);
            lblStepRoom.Name = "lblStepRoom";
            lblStepRoom.Size = new Size(51, 20);
            lblStepRoom.TabIndex = 3;
            lblStepRoom.Text = "Room";
            // 
            // lblStep3
            // 
            lblStep3.AutoSize = true;
            lblStep3.BackColor = Color.FromArgb(225, 220, 210);
            lblStep3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStep3.ForeColor = Color.FromArgb(120, 120, 120);
            lblStep3.Location = new Point(170, 18);
            lblStep3.Margin = new Padding(0, 0, 5, 0);
            lblStep3.Name = "lblStep3";
            lblStep3.Size = new Size(18, 20);
            lblStep3.TabIndex = 4;
            lblStep3.Text = "3";
            lblStep3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStepConfirm
            // 
            lblStepConfirm.AutoSize = true;
            lblStepConfirm.ForeColor = Color.FromArgb(105, 119, 139);
            lblStepConfirm.Location = new Point(193, 18);
            lblStepConfirm.Margin = new Padding(0);
            lblStepConfirm.Name = "lblStepConfirm";
            lblStepConfirm.Size = new Size(62, 20);
            lblStepConfirm.TabIndex = 5;
            lblStepConfirm.Text = "Confirm";
            lblStepConfirm.Click += label1_Click;
            // 
            // pnlSearchFilters
            // 
            pnlSearchFilters.BackColor = Color.White;
            pnlSearchFilters.Controls.Add(tableLayoutPanel1);
            pnlSearchFilters.Dock = DockStyle.Fill;
            pnlSearchFilters.Location = new Point(10, 100);
            pnlSearchFilters.Margin = new Padding(0, 0, 0, 16);
            pnlSearchFilters.Name = "pnlSearchFilters";
            pnlSearchFilters.Padding = new Padding(15, 10, 15, 10);
            pnlSearchFilters.Size = new Size(1307, 78);
            pnlSearchFilters.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13F));
            tableLayoutPanel1.Controls.Add(dtpCheckIn, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Controls.Add(panel3, 2, 0);
            tableLayoutPanel1.Controls.Add(panel4, 3, 0);
            tableLayoutPanel1.Controls.Add(btnSearchRooms, 4, 0);
            tableLayoutPanel1.Controls.Add(lblNightsCount, 5, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(15, 10);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1277, 58);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // dtpCheckIn
            // 
            dtpCheckIn.Controls.Add(dateTimePicker1);
            dtpCheckIn.Controls.Add(lblCheckIn);
            dtpCheckIn.Dock = DockStyle.Fill;
            dtpCheckIn.Location = new Point(3, 3);
            dtpCheckIn.Name = "dtpCheckIn";
            dtpCheckIn.Size = new Size(198, 52);
            dtpCheckIn.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dateTimePicker1.CustomFormat = "dd MMM yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(15, 22);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(145, 27);
            dateTimePicker1.TabIndex = 1;
            // 
            // lblCheckIn
            // 
            lblCheckIn.AutoSize = true;
            lblCheckIn.Location = new Point(32, 0);
            lblCheckIn.Name = "lblCheckIn";
            lblCheckIn.Size = new Size(66, 20);
            lblCheckIn.TabIndex = 0;
            lblCheckIn.Text = "Check-in";
            // 
            // panel2
            // 
            panel2.Controls.Add(dtpCheckOut);
            panel2.Controls.Add(lblCheckOut);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(207, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(198, 52);
            panel2.TabIndex = 1;
            // 
            // dtpCheckOut
            // 
            dtpCheckOut.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtpCheckOut.CustomFormat = "dd MMM yyyy";
            dtpCheckOut.Format = DateTimePickerFormat.Custom;
            dtpCheckOut.Location = new Point(19, 22);
            dtpCheckOut.Name = "dtpCheckOut";
            dtpCheckOut.Size = new Size(145, 27);
            dtpCheckOut.TabIndex = 1;
            // 
            // lblCheckOut
            // 
            lblCheckOut.AutoSize = true;
            lblCheckOut.Location = new Point(50, 0);
            lblCheckOut.Name = "lblCheckOut";
            lblCheckOut.Size = new Size(76, 20);
            lblCheckOut.TabIndex = 0;
            lblCheckOut.Text = "Check-out";
            // 
            // panel3
            // 
            panel3.Controls.Add(cmbAdults);
            panel3.Controls.Add(lblAdults);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(411, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(134, 52);
            panel3.TabIndex = 2;
            // 
            // cmbAdults
            // 
            cmbAdults.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbAdults.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAdults.FormattingEnabled = true;
            cmbAdults.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            cmbAdults.Location = new Point(19, 21);
            cmbAdults.Name = "cmbAdults";
            cmbAdults.Size = new Size(97, 28);
            cmbAdults.TabIndex = 1;
            // 
            // lblAdults
            // 
            lblAdults.AutoSize = true;
            lblAdults.Location = new Point(24, 0);
            lblAdults.Name = "lblAdults";
            lblAdults.Size = new Size(51, 20);
            lblAdults.TabIndex = 0;
            lblAdults.Text = "Adults";
            lblAdults.Click += lblAdults_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(cmbRoomType);
            panel4.Controls.Add(lblRoomType);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(551, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(236, 52);
            panel4.TabIndex = 3;
            // 
            // cmbRoomType
            // 
            cmbRoomType.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbRoomType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRoomType.FormattingEnabled = true;
            cmbRoomType.Items.AddRange(new object[] { "Any type", "Standard Twin", "Deluxe King", "Family Room", "Executive Suite" });
            cmbRoomType.Location = new Point(25, 20);
            cmbRoomType.Name = "cmbRoomType";
            cmbRoomType.Size = new Size(151, 28);
            cmbRoomType.TabIndex = 1;
            // 
            // lblRoomType
            // 
            lblRoomType.AutoSize = true;
            lblRoomType.Location = new Point(25, -3);
            lblRoomType.Name = "lblRoomType";
            lblRoomType.Size = new Size(82, 20);
            lblRoomType.TabIndex = 0;
            lblRoomType.Text = "Room type";
            // 
            // btnSearchRooms
            // 
            btnSearchRooms.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearchRooms.BackColor = Color.FromArgb(25, 45, 68);
            btnSearchRooms.FlatAppearance.BorderSize = 0;
            btnSearchRooms.FlatStyle = FlatStyle.Flat;
            btnSearchRooms.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchRooms.ForeColor = Color.White;
            btnSearchRooms.Location = new Point(981, 3);
            btnSearchRooms.Name = "btnSearchRooms";
            btnSearchRooms.Size = new Size(125, 39);
            btnSearchRooms.TabIndex = 4;
            btnSearchRooms.Text = "Search Rooms";
            btnSearchRooms.UseVisualStyleBackColor = false;
            // 
            // lblNightsCount
            // 
            lblNightsCount.AutoSize = true;
            lblNightsCount.Dock = DockStyle.Fill;
            lblNightsCount.ForeColor = Color.FromArgb(105, 119, 139);
            lblNightsCount.Location = new Point(1112, 0);
            lblNightsCount.Name = "lblNightsCount";
            lblNightsCount.Size = new Size(162, 58);
            lblNightsCount.TabIndex = 5;
            lblNightsCount.Text = "3 nights";
            lblNightsCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tlpBookingBody
            // 
            tlpBookingBody.ColumnCount = 2;
            tlpBookingBody.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 63F));
            tlpBookingBody.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37F));
            tlpBookingBody.Controls.Add(pnlAvailableRooms, 0, 0);
            tlpBookingBody.Controls.Add(pnlBookingSummary, 1, 0);
            tlpBookingBody.Dock = DockStyle.Fill;
            tlpBookingBody.ForeColor = Color.FromArgb(105, 119, 139);
            tlpBookingBody.Location = new Point(10, 194);
            tlpBookingBody.Margin = new Padding(0);
            tlpBookingBody.Name = "tlpBookingBody";
            tlpBookingBody.RowCount = 1;
            tlpBookingBody.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpBookingBody.Size = new Size(1307, 567);
            tlpBookingBody.TabIndex = 2;
            // 
            // pnlAvailableRooms
            // 
            pnlAvailableRooms.BackColor = Color.White;
            pnlAvailableRooms.Controls.Add(tlpAvailableRooms);
            pnlAvailableRooms.Dock = DockStyle.Fill;
            pnlAvailableRooms.Location = new Point(0, 0);
            pnlAvailableRooms.Margin = new Padding(0, 0, 10, 0);
            pnlAvailableRooms.Name = "pnlAvailableRooms";
            pnlAvailableRooms.Padding = new Padding(15, 12, 15, 12);
            pnlAvailableRooms.Size = new Size(813, 567);
            pnlAvailableRooms.TabIndex = 0;
            // 
            // tlpAvailableRooms
            // 
            tlpAvailableRooms.ColumnCount = 1;
            tlpAvailableRooms.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpAvailableRooms.Controls.Add(tlpAvailableRoomsHeader, 0, 0);
            tlpAvailableRooms.Controls.Add(dgvAvailableRooms, 0, 1);
            tlpAvailableRooms.Dock = DockStyle.Fill;
            tlpAvailableRooms.Location = new Point(15, 12);
            tlpAvailableRooms.Margin = new Padding(0);
            tlpAvailableRooms.Name = "tlpAvailableRooms";
            tlpAvailableRooms.RowCount = 2;
            tlpAvailableRooms.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tlpAvailableRooms.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpAvailableRooms.Size = new Size(783, 543);
            tlpAvailableRooms.TabIndex = 0;
            // 
            // tlpAvailableRoomsHeader
            // 
            tlpAvailableRoomsHeader.ColumnCount = 2;
            tlpAvailableRoomsHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tlpAvailableRoomsHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tlpAvailableRoomsHeader.Controls.Add(lblAvailableRoomsTitle, 0, 0);
            tlpAvailableRoomsHeader.Controls.Add(lblAvailableRoomsCount, 1, 0);
            tlpAvailableRoomsHeader.Dock = DockStyle.Fill;
            tlpAvailableRoomsHeader.Location = new Point(0, 0);
            tlpAvailableRoomsHeader.Margin = new Padding(0);
            tlpAvailableRoomsHeader.Name = "tlpAvailableRoomsHeader";
            tlpAvailableRoomsHeader.RowCount = 1;
            tlpAvailableRoomsHeader.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpAvailableRoomsHeader.Size = new Size(783, 40);
            tlpAvailableRoomsHeader.TabIndex = 0;
            // 
            // lblAvailableRoomsTitle
            // 
            lblAvailableRoomsTitle.Anchor = AnchorStyles.Left;
            lblAvailableRoomsTitle.AutoSize = true;
            lblAvailableRoomsTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAvailableRoomsTitle.ForeColor = Color.FromArgb(25, 45, 68);
            lblAvailableRoomsTitle.Location = new Point(3, 6);
            lblAvailableRoomsTitle.Name = "lblAvailableRoomsTitle";
            lblAvailableRoomsTitle.Size = new Size(170, 28);
            lblAvailableRoomsTitle.TabIndex = 0;
            lblAvailableRoomsTitle.Text = "Available Rooms";
            // 
            // lblAvailableRoomsCount
            // 
            lblAvailableRoomsCount.AutoSize = true;
            lblAvailableRoomsCount.Dock = DockStyle.Fill;
            lblAvailableRoomsCount.ForeColor = Color.FromArgb(105, 119, 139);
            lblAvailableRoomsCount.Location = new Point(472, 0);
            lblAvailableRoomsCount.Name = "lblAvailableRoomsCount";
            lblAvailableRoomsCount.Size = new Size(308, 40);
            lblAvailableRoomsCount.TabIndex = 1;
            lblAvailableRoomsCount.Text = "6 rooms free for these dates";
            lblAvailableRoomsCount.TextAlign = ContentAlignment.BottomCenter;
            // 
            // dgvAvailableRooms
            // 
            dgvAvailableRooms.AllowUserToAddRows = false;
            dgvAvailableRooms.AllowUserToDeleteRows = false;
            dgvAvailableRooms.AllowUserToResizeRows = false;
            dgvAvailableRooms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAvailableRooms.BackgroundColor = Color.White;
            dgvAvailableRooms.BorderStyle = BorderStyle.None;
            dgvAvailableRooms.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(245, 242, 236);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(85, 100, 120);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvAvailableRooms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvAvailableRooms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAvailableRooms.Columns.AddRange(new DataGridViewColumn[] { colRoomNumber, colRoomType, colBeds, colRate, colSelectRoom });
            dgvAvailableRooms.Dock = DockStyle.Fill;
            dgvAvailableRooms.EnableHeadersVisualStyles = false;
            dgvAvailableRooms.GridColor = Color.FromArgb(235, 230, 220);
            dgvAvailableRooms.Location = new Point(3, 43);
            dgvAvailableRooms.MultiSelect = false;
            dgvAvailableRooms.Name = "dgvAvailableRooms";
            dgvAvailableRooms.ReadOnly = true;
            dgvAvailableRooms.RowHeadersVisible = false;
            dgvAvailableRooms.RowHeadersWidth = 51;
            dgvAvailableRooms.RowTemplate.Height = 55;
            dgvAvailableRooms.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAvailableRooms.Size = new Size(777, 497);
            dgvAvailableRooms.TabIndex = 1;
            dgvAvailableRooms.CellContentClick += dgvAvailableRooms_CellContentClick;
            // 
            // colRoomNumber
            // 
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(25, 45, 68);
            dataGridViewCellStyle2.Padding = new Padding(8, 0, 8, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(250, 242, 222);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(25, 45, 68);
            colRoomNumber.DefaultCellStyle = dataGridViewCellStyle2;
            colRoomNumber.FillWeight = 20F;
            colRoomNumber.HeaderText = "ROOM";
            colRoomNumber.MinimumWidth = 6;
            colRoomNumber.Name = "colRoomNumber";
            colRoomNumber.ReadOnly = true;
            // 
            // colRoomType
            // 
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(25, 45, 68);
            dataGridViewCellStyle3.Padding = new Padding(8, 0, 8, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(250, 242, 222);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(25, 45, 68);
            colRoomType.DefaultCellStyle = dataGridViewCellStyle3;
            colRoomType.FillWeight = 25F;
            colRoomType.HeaderText = "TYPE";
            colRoomType.MinimumWidth = 6;
            colRoomType.Name = "colRoomType";
            colRoomType.ReadOnly = true;
            // 
            // colBeds
            // 
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(25, 45, 68);
            dataGridViewCellStyle4.Padding = new Padding(8, 0, 8, 0);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(250, 242, 222);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(25, 45, 68);
            colBeds.DefaultCellStyle = dataGridViewCellStyle4;
            colBeds.FillWeight = 50F;
            colBeds.HeaderText = "BEDS";
            colBeds.MinimumWidth = 6;
            colBeds.Name = "colBeds";
            colBeds.ReadOnly = true;
            // 
            // colRate
            // 
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(25, 45, 68);
            dataGridViewCellStyle5.Padding = new Padding(8, 0, 8, 0);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(250, 242, 222);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(25, 45, 68);
            colRate.DefaultCellStyle = dataGridViewCellStyle5;
            colRate.FillWeight = 30F;
            colRate.HeaderText = "RATE / NIGHT";
            colRate.MinimumWidth = 6;
            colRate.Name = "colRate";
            colRate.ReadOnly = true;
            // 
            // colSelectRoom
            // 
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(25, 45, 68);
            dataGridViewCellStyle6.Padding = new Padding(8, 0, 8, 0);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(250, 242, 222);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(25, 45, 68);
            colSelectRoom.DefaultCellStyle = dataGridViewCellStyle6;
            colSelectRoom.FlatStyle = FlatStyle.Flat;
            colSelectRoom.HeaderText = "";
            colSelectRoom.MinimumWidth = 6;
            colSelectRoom.Name = "colSelectRoom";
            colSelectRoom.ReadOnly = true;
            colSelectRoom.Text = "Select";
            colSelectRoom.UseColumnTextForButtonValue = true;
            // 
            // pnlBookingSummary
            // 
            pnlBookingSummary.BackColor = Color.White;
            pnlBookingSummary.Controls.Add(tlpPriceBreakdown);
            pnlBookingSummary.Dock = DockStyle.Fill;
            pnlBookingSummary.Location = new Point(833, 0);
            pnlBookingSummary.Margin = new Padding(10, 0, 0, 0);
            pnlBookingSummary.Name = "pnlBookingSummary";
            pnlBookingSummary.Padding = new Padding(15, 12, 15, 12);
            pnlBookingSummary.Size = new Size(474, 567);
            pnlBookingSummary.TabIndex = 1;
            // 
            // tlpPriceBreakdown
            // 
            tlpPriceBreakdown.ColumnCount = 1;
            tlpPriceBreakdown.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpPriceBreakdown.Controls.Add(lblBookingSummaryTitle, 0, 0);
            tlpPriceBreakdown.Controls.Add(tableLayoutPanel3, 0, 1);
            tlpPriceBreakdown.Controls.Add(panel5, 0, 2);
            tlpPriceBreakdown.Controls.Add(pnlSpecialRequests, 0, 3);
            tlpPriceBreakdown.Controls.Add(tableLayoutPanel5, 0, 4);
            tlpPriceBreakdown.Dock = DockStyle.Fill;
            tlpPriceBreakdown.Location = new Point(15, 12);
            tlpPriceBreakdown.Margin = new Padding(0);
            tlpPriceBreakdown.Name = "tlpPriceBreakdown";
            tlpPriceBreakdown.RowCount = 5;
            tlpPriceBreakdown.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tlpPriceBreakdown.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            tlpPriceBreakdown.RowStyles.Add(new RowStyle(SizeType.Percent, 55F));
            tlpPriceBreakdown.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
            tlpPriceBreakdown.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tlpPriceBreakdown.Size = new Size(444, 543);
            tlpPriceBreakdown.TabIndex = 0;
            // 
            // lblBookingSummaryTitle
            // 
            lblBookingSummaryTitle.Anchor = AnchorStyles.Left;
            lblBookingSummaryTitle.AutoSize = true;
            lblBookingSummaryTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBookingSummaryTitle.ForeColor = Color.FromArgb(25, 45, 68);
            lblBookingSummaryTitle.Location = new Point(3, 3);
            lblBookingSummaryTitle.Name = "lblBookingSummaryTitle";
            lblBookingSummaryTitle.Size = new Size(186, 28);
            lblBookingSummaryTitle.TabIndex = 0;
            lblBookingSummaryTitle.Text = "Booking Summary";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.Controls.Add(lblGuest, 0, 0);
            tableLayoutPanel3.Controls.Add(cmbBookingGuest, 0, 1);
            tableLayoutPanel3.Controls.Add(btnNewGuest, 1, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 35);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(444, 65);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // lblGuest
            // 
            lblGuest.AutoSize = true;
            lblGuest.ForeColor = Color.FromArgb(85, 100, 120);
            lblGuest.Location = new Point(3, 0);
            lblGuest.Name = "lblGuest";
            lblGuest.Size = new Size(46, 20);
            lblGuest.TabIndex = 0;
            lblGuest.Text = "Guest";
            // 
            // cmbBookingGuest
            // 
            cmbBookingGuest.Dock = DockStyle.Fill;
            cmbBookingGuest.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBookingGuest.FormattingEnabled = true;
            cmbBookingGuest.Location = new Point(0, 22);
            cmbBookingGuest.Margin = new Padding(0, 0, 5, 0);
            cmbBookingGuest.Name = "cmbBookingGuest";
            cmbBookingGuest.Size = new Size(328, 28);
            cmbBookingGuest.TabIndex = 1;
            // 
            // btnNewGuest
            // 
            btnNewGuest.Dock = DockStyle.Fill;
            btnNewGuest.FlatStyle = FlatStyle.Flat;
            btnNewGuest.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNewGuest.ForeColor = Color.FromArgb(25, 45, 68);
            btnNewGuest.Location = new Point(338, 22);
            btnNewGuest.Margin = new Padding(5, 0, 0, 0);
            btnNewGuest.Name = "btnNewGuest";
            btnNewGuest.Size = new Size(106, 43);
            btnNewGuest.TabIndex = 2;
            btnNewGuest.Text = "+ New";
            btnNewGuest.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(245, 242, 236);
            panel5.Controls.Add(tableLayoutPanel4);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 105);
            panel5.Margin = new Padding(0, 5, 0, 8);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(12, 8, 12, 8);
            panel5.Size = new Size(444, 200);
            panel5.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tableLayoutPanel4.Controls.Add(lblSummaryRoom, 0, 0);
            tableLayoutPanel4.Controls.Add(lblSummaryStay, 0, 1);
            tableLayoutPanel4.Controls.Add(lblSummaryRate, 0, 2);
            tableLayoutPanel4.Controls.Add(lblSummarySubtotal, 0, 3);
            tableLayoutPanel4.Controls.Add(lblSummaryTax, 0, 4);
            tableLayoutPanel4.Controls.Add(lblSummaryTotal, 0, 5);
            tableLayoutPanel4.Controls.Add(lblSummaryRoomValue, 1, 0);
            tableLayoutPanel4.Controls.Add(lblSummaryStayValue, 1, 1);
            tableLayoutPanel4.Controls.Add(lblSummaryRateValue, 1, 2);
            tableLayoutPanel4.Controls.Add(lblSummarySubtotalValue, 1, 3);
            tableLayoutPanel4.Controls.Add(lblSummaryTaxValue, 1, 4);
            tableLayoutPanel4.Controls.Add(lblSummaryTotalValue, 1, 5);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(12, 8);
            tableLayoutPanel4.Margin = new Padding(0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 6;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel4.Size = new Size(420, 184);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // lblSummaryRoom
            // 
            lblSummaryRoom.Anchor = AnchorStyles.Left;
            lblSummaryRoom.AutoSize = true;
            lblSummaryRoom.Location = new Point(3, 5);
            lblSummaryRoom.Name = "lblSummaryRoom";
            lblSummaryRoom.Size = new Size(49, 20);
            lblSummaryRoom.TabIndex = 0;
            lblSummaryRoom.Text = "Room";
            // 
            // lblSummaryStay
            // 
            lblSummaryStay.Anchor = AnchorStyles.Left;
            lblSummaryStay.AutoSize = true;
            lblSummaryStay.Location = new Point(3, 35);
            lblSummaryStay.Name = "lblSummaryStay";
            lblSummaryStay.Size = new Size(37, 20);
            lblSummaryStay.TabIndex = 1;
            lblSummaryStay.Text = "Stay";
            // 
            // lblSummaryRate
            // 
            lblSummaryRate.Anchor = AnchorStyles.Left;
            lblSummaryRate.AutoSize = true;
            lblSummaryRate.Location = new Point(3, 65);
            lblSummaryRate.Name = "lblSummaryRate";
            lblSummaryRate.Size = new Size(39, 20);
            lblSummaryRate.TabIndex = 2;
            lblSummaryRate.Text = "Rate";
            // 
            // lblSummarySubtotal
            // 
            lblSummarySubtotal.Anchor = AnchorStyles.Left;
            lblSummarySubtotal.AutoSize = true;
            lblSummarySubtotal.Location = new Point(3, 95);
            lblSummarySubtotal.Name = "lblSummarySubtotal";
            lblSummarySubtotal.Size = new Size(65, 20);
            lblSummarySubtotal.TabIndex = 3;
            lblSummarySubtotal.Text = "Subtotal";
            // 
            // lblSummaryTax
            // 
            lblSummaryTax.Anchor = AnchorStyles.Left;
            lblSummaryTax.AutoSize = true;
            lblSummaryTax.Location = new Point(3, 125);
            lblSummaryTax.Name = "lblSummaryTax";
            lblSummaryTax.Size = new Size(56, 20);
            lblSummaryTax.TabIndex = 4;
            lblSummaryTax.Text = "Tax(15)";
            // 
            // lblSummaryTotal
            // 
            lblSummaryTotal.Anchor = AnchorStyles.Left;
            lblSummaryTotal.AutoSize = true;
            lblSummaryTotal.Location = new Point(3, 157);
            lblSummaryTotal.Name = "lblSummaryTotal";
            lblSummaryTotal.Size = new Size(42, 20);
            lblSummaryTotal.TabIndex = 5;
            lblSummaryTotal.Text = "Total";
            // 
            // lblSummaryRoomValue
            // 
            lblSummaryRoomValue.AutoSize = true;
            lblSummaryRoomValue.Dock = DockStyle.Fill;
            lblSummaryRoomValue.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSummaryRoomValue.ForeColor = Color.FromArgb(25, 45, 68);
            lblSummaryRoomValue.Location = new Point(234, 0);
            lblSummaryRoomValue.Name = "lblSummaryRoomValue";
            lblSummaryRoomValue.Size = new Size(183, 30);
            lblSummaryRoomValue.TabIndex = 6;
            lblSummaryRoomValue.Text = "204 · Deluxe King";
            lblSummaryRoomValue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblSummaryStayValue
            // 
            lblSummaryStayValue.AutoSize = true;
            lblSummaryStayValue.Dock = DockStyle.Fill;
            lblSummaryStayValue.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSummaryStayValue.ForeColor = Color.FromArgb(25, 45, 68);
            lblSummaryStayValue.Location = new Point(234, 30);
            lblSummaryStayValue.Name = "lblSummaryStayValue";
            lblSummaryStayValue.Size = new Size(183, 30);
            lblSummaryStayValue.TabIndex = 7;
            lblSummaryStayValue.Text = "17 to 20 Nov (3 nights)";
            lblSummaryStayValue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblSummaryRateValue
            // 
            lblSummaryRateValue.AutoSize = true;
            lblSummaryRateValue.Dock = DockStyle.Fill;
            lblSummaryRateValue.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSummaryRateValue.ForeColor = Color.FromArgb(25, 45, 68);
            lblSummaryRateValue.Location = new Point(234, 60);
            lblSummaryRateValue.Name = "lblSummaryRateValue";
            lblSummaryRateValue.Size = new Size(183, 30);
            lblSummaryRateValue.TabIndex = 8;
            lblSummaryRateValue.Text = "GHS 650.00 × 3";
            lblSummaryRateValue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblSummarySubtotalValue
            // 
            lblSummarySubtotalValue.AutoSize = true;
            lblSummarySubtotalValue.Dock = DockStyle.Fill;
            lblSummarySubtotalValue.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSummarySubtotalValue.ForeColor = Color.FromArgb(25, 45, 68);
            lblSummarySubtotalValue.Location = new Point(234, 90);
            lblSummarySubtotalValue.Name = "lblSummarySubtotalValue";
            lblSummarySubtotalValue.Size = new Size(183, 30);
            lblSummarySubtotalValue.TabIndex = 9;
            lblSummarySubtotalValue.Text = "GHS 1,950.00";
            lblSummarySubtotalValue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblSummaryTaxValue
            // 
            lblSummaryTaxValue.AutoSize = true;
            lblSummaryTaxValue.Dock = DockStyle.Fill;
            lblSummaryTaxValue.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSummaryTaxValue.ForeColor = Color.FromArgb(25, 45, 68);
            lblSummaryTaxValue.Location = new Point(234, 120);
            lblSummaryTaxValue.Name = "lblSummaryTaxValue";
            lblSummaryTaxValue.Size = new Size(183, 30);
            lblSummaryTaxValue.TabIndex = 10;
            lblSummaryTaxValue.Text = "GHS 292.50";
            lblSummaryTaxValue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblSummaryTotalValue
            // 
            lblSummaryTotalValue.AutoSize = true;
            lblSummaryTotalValue.Dock = DockStyle.Fill;
            lblSummaryTotalValue.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSummaryTotalValue.ForeColor = Color.FromArgb(25, 45, 68);
            lblSummaryTotalValue.Location = new Point(234, 150);
            lblSummaryTotalValue.Name = "lblSummaryTotalValue";
            lblSummaryTotalValue.Size = new Size(183, 34);
            lblSummaryTotalValue.TabIndex = 11;
            lblSummaryTotalValue.Text = "GHS 2,242.50";
            lblSummaryTotalValue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pnlSpecialRequests
            // 
            pnlSpecialRequests.Controls.Add(tableLayoutPanel2);
            pnlSpecialRequests.Dock = DockStyle.Fill;
            pnlSpecialRequests.Location = new Point(0, 313);
            pnlSpecialRequests.Margin = new Padding(0, 0, 0, 5);
            pnlSpecialRequests.Name = "pnlSpecialRequests";
            pnlSpecialRequests.Padding = new Padding(0, 3, 0, 0);
            pnlSpecialRequests.Size = new Size(444, 169);
            pnlSpecialRequests.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(lblSpecialRequests, 0, 0);
            tableLayoutPanel2.Controls.Add(txtSpecialRequests, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(444, 166);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // lblSpecialRequests
            // 
            lblSpecialRequests.AutoSize = true;
            lblSpecialRequests.ForeColor = Color.FromArgb(25, 45, 68);
            lblSpecialRequests.Location = new Point(3, 0);
            lblSpecialRequests.Name = "lblSpecialRequests";
            lblSpecialRequests.Size = new Size(116, 20);
            lblSpecialRequests.TabIndex = 0;
            lblSpecialRequests.Text = "Special requests";
            // 
            // txtSpecialRequests
            // 
            txtSpecialRequests.Dock = DockStyle.Fill;
            txtSpecialRequests.Location = new Point(3, 28);
            txtSpecialRequests.Multiline = true;
            txtSpecialRequests.Name = "txtSpecialRequests";
            txtSpecialRequests.ScrollBars = ScrollBars.Vertical;
            txtSpecialRequests.Size = new Size(438, 135);
            txtSpecialRequests.TabIndex = 1;
            txtSpecialRequests.Text = "Late arrival around 22:00. High floor if possible.";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel5.Controls.Add(btnConfirmBooking, 0, 0);
            tableLayoutPanel5.Controls.Add(btnCancelBooking, 1, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(0, 487);
            tableLayoutPanel5.Margin = new Padding(0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(444, 56);
            tableLayoutPanel5.TabIndex = 4;
            // 
            // btnConfirmBooking
            // 
            btnConfirmBooking.BackColor = Color.FromArgb(201, 151, 58);
            btnConfirmBooking.Dock = DockStyle.Fill;
            btnConfirmBooking.FlatAppearance.BorderSize = 0;
            btnConfirmBooking.FlatStyle = FlatStyle.Flat;
            btnConfirmBooking.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmBooking.ForeColor = Color.FromArgb(25, 45, 68);
            btnConfirmBooking.Location = new Point(0, 0);
            btnConfirmBooking.Margin = new Padding(0, 0, 4, 0);
            btnConfirmBooking.Name = "btnConfirmBooking";
            btnConfirmBooking.Size = new Size(306, 56);
            btnConfirmBooking.TabIndex = 0;
            btnConfirmBooking.Text = "Confirm Booking";
            btnConfirmBooking.UseVisualStyleBackColor = false;
            // 
            // btnCancelBooking
            // 
            btnCancelBooking.Dock = DockStyle.Fill;
            btnCancelBooking.FlatStyle = FlatStyle.Flat;
            btnCancelBooking.ForeColor = Color.FromArgb(25, 45, 68);
            btnCancelBooking.Location = new Point(314, 0);
            btnCancelBooking.Margin = new Padding(4, 0, 0, 0);
            btnCancelBooking.Name = "btnCancelBooking";
            btnCancelBooking.Size = new Size(130, 56);
            btnCancelBooking.TabIndex = 1;
            btnCancelBooking.Text = "Cancel";
            btnCancelBooking.UseVisualStyleBackColor = true;
            // 
            // ucNewBooking
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(245, 242, 236);
            Controls.Add(tlpBookingMain);
            Margin = new Padding(0);
            Name = "ucNewBooking";
            Size = new Size(1337, 781);
            Load += ucNewBooking_Load;
            tlpBookingMain.ResumeLayout(false);
            pnlBookingHeader.ResumeLayout(false);
            tlpHeader.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flpBookingSteps.ResumeLayout(false);
            flpBookingSteps.PerformLayout();
            pnlSearchFilters.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            dtpCheckIn.ResumeLayout(false);
            dtpCheckIn.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            tlpBookingBody.ResumeLayout(false);
            pnlAvailableRooms.ResumeLayout(false);
            tlpAvailableRooms.ResumeLayout(false);
            tlpAvailableRoomsHeader.ResumeLayout(false);
            tlpAvailableRoomsHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAvailableRooms).EndInit();
            pnlBookingSummary.ResumeLayout(false);
            tlpPriceBreakdown.ResumeLayout(false);
            tlpPriceBreakdown.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            panel5.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            pnlSpecialRequests.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpBookingMain;
        private Panel pnlBookingHeader;
        private TableLayoutPanel tlpHeader;
        private Panel panel1;
        private Label lblBookingSubtitle;
        private Label lblBookingTitle;
        private FlowLayoutPanel flpBookingSteps;
        private Label lblStep1;
        private Label lblStepDates;
        private Label lblStep2;
        private Label lblStepRoom;
        private Label lblStep3;
        private Label lblStepConfirm;
        private Panel pnlSearchFilters;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel dtpCheckIn;
        private Label lblCheckIn;
        private DateTimePicker dateTimePicker1;
        private Panel panel2;
        private DateTimePicker dtpCheckOut;
        private Label lblCheckOut;
        private Panel panel3;
        private ComboBox cmbAdults;
        private Label lblAdults;
        private Panel panel4;
        private ComboBox cmbRoomType;
        private Label lblRoomType;
        private Button btnSearchRooms;
        private Label lblNightsCount;
        private TableLayoutPanel tlpBookingBody;
        private Panel pnlAvailableRooms;
        private TableLayoutPanel tlpAvailableRooms;
        private TableLayoutPanel tlpAvailableRoomsHeader;
        private Label lblAvailableRoomsTitle;
        private Label lblAvailableRoomsCount;
        private DataGridView dgvAvailableRooms;
        private DataGridViewTextBoxColumn colRoomNumber;
        private DataGridViewTextBoxColumn colRoomType;
        private DataGridViewTextBoxColumn colBeds;
        private DataGridViewTextBoxColumn colRate;
        private DataGridViewButtonColumn colSelectRoom;
        private Panel pnlBookingSummary;
        private TableLayoutPanel tlpPriceBreakdown;
        private Label lblBookingSummaryTitle;
        private TableLayoutPanel tableLayoutPanel3;
        private Label lblGuest;
        private ComboBox cmbBookingGuest;
        private Button btnNewGuest;
        private Panel panel5;
        private TableLayoutPanel tableLayoutPanel4;
        private Label lblSummaryRoom;
        private Label lblSummaryStay;
        private Label lblSummaryRate;
        private Label lblSummarySubtotal;
        private Label lblSummaryTax;
        private Label lblSummaryTotal;
        private Label lblSummaryRoomValue;
        private Label lblSummaryStayValue;
        private Label lblSummaryRateValue;
        private Label lblSummarySubtotalValue;
        private Label lblSummaryTaxValue;
        private Label lblSummaryTotalValue;
        private Panel pnlSpecialRequests;
        private TableLayoutPanel tableLayoutPanel2;
        private Label lblSpecialRequests;
        private TextBox txtSpecialRequests;
        private TableLayoutPanel tableLayoutPanel5;
        private Button btnConfirmBooking;
        private Button btnCancelBooking;
    }
}
