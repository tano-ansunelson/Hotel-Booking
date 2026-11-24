namespace Hotel_Booking.UserControls
{
    partial class ucBookings
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            tlpBookingsMain = new TableLayoutPanel();
            pnlBookingsHeader = new Panel();
            tlpBookingsHeader = new TableLayoutPanel();
            pnlBookingHeader = new Panel();
            lblBookingsSubtitle = new Label();
            lblBookingsTitle = new Label();
            btnNewBooking = new Button();
            pnlBookingFilters = new Panel();
            tlpBookingFilters = new TableLayoutPanel();
            txtSearchBooking = new TextBox();
            cmbBookingStatus = new ComboBox();
            dtpBookingFrom = new DateTimePicker();
            dtpBookingTo = new DateTimePicker();
            tlpBookingsContent = new TableLayoutPanel();
            pnlBookingsList = new Panel();
            tlpBookingsList = new TableLayoutPanel();
            dgvBookings = new DataGridView();
            colBookingNumber = new DataGridViewTextBoxColumn();
            colGuestName = new DataGridViewTextBoxColumn();
            colRoomNumber = new DataGridViewTextBoxColumn();
            colCheckIn = new DataGridViewTextBoxColumn();
            colCheckOut = new DataGridViewTextBoxColumn();
            colBookingTotal = new DataGridViewTextBoxColumn();
            colBookingStatus = new DataGridViewTextBoxColumn();
            lblBookingsCount = new Label();
            pnlBookingDetails = new Panel();
            tlpBookingDetails = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblSelectedBookingNumber = new Label();
            lblSelectedBookingStatus = new Label();
            pnlBookingGuest = new Panel();
            tlpBookingGuest = new TableLayoutPanel();
            lblGuestInitials = new Label();
            tlpGuestIdentity = new TableLayoutPanel();
            lblSelectedGuestName = new Label();
            lblSelectedGuestPhone = new Label();
            pnlBookingInformation = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            lblDetailRoom = new Label();
            lblDetailCheckIn = new Label();
            lblDetailCheckOut = new Label();
            lblDetailGuests = new Label();
            lblDetailTotal = new Label();
            lblDetailPaid = new Label();
            lblDetailRoomValue = new Label();
            lblDetailCheckInValue = new Label();
            lblDetailCheckOutValue = new Label();
            lblDetailGuestsValue = new Label();
            label1 = new Label();
            lblDetailPaidValue = new Label();
            pnlBookingNotes = new Panel();
            tlpBookingNotes = new TableLayoutPanel();
            lblBookingNoteTitle = new Label();
            lblBookingNote = new Label();
            btnEditBooking = new Button();
            tlpBookingBottomActions = new TableLayoutPanel();
            btnRecordPayment = new Button();
            btnCancelBooking = new Button();
            tlpBookingsMain.SuspendLayout();
            pnlBookingsHeader.SuspendLayout();
            tlpBookingsHeader.SuspendLayout();
            pnlBookingHeader.SuspendLayout();
            pnlBookingFilters.SuspendLayout();
            tlpBookingFilters.SuspendLayout();
            tlpBookingsContent.SuspendLayout();
            pnlBookingsList.SuspendLayout();
            tlpBookingsList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookings).BeginInit();
            pnlBookingDetails.SuspendLayout();
            tlpBookingDetails.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            pnlBookingGuest.SuspendLayout();
            tlpBookingGuest.SuspendLayout();
            tlpGuestIdentity.SuspendLayout();
            pnlBookingInformation.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            pnlBookingNotes.SuspendLayout();
            tlpBookingNotes.SuspendLayout();
            tlpBookingBottomActions.SuspendLayout();
            SuspendLayout();
            // 
            // tlpBookingsMain
            // 
            tlpBookingsMain.ColumnCount = 1;
            tlpBookingsMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpBookingsMain.Controls.Add(pnlBookingsHeader, 0, 0);
            tlpBookingsMain.Controls.Add(pnlBookingFilters, 0, 1);
            tlpBookingsMain.Controls.Add(tlpBookingsContent, 0, 2);
            tlpBookingsMain.Dock = DockStyle.Fill;
            tlpBookingsMain.Location = new Point(0, 0);
            tlpBookingsMain.Margin = new Padding(0);
            tlpBookingsMain.Name = "tlpBookingsMain";
            tlpBookingsMain.Padding = new Padding(38, 30, 38, 32);
            tlpBookingsMain.RowCount = 3;
            tlpBookingsMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 92F));
            tlpBookingsMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 83F));
            tlpBookingsMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpBookingsMain.Size = new Size(1306, 851);
            tlpBookingsMain.TabIndex = 0;
            // 
            // pnlBookingsHeader
            // 
            pnlBookingsHeader.Controls.Add(tlpBookingsHeader);
            pnlBookingsHeader.Dock = DockStyle.Fill;
            pnlBookingsHeader.Location = new Point(38, 30);
            pnlBookingsHeader.Margin = new Padding(0, 0, 0, 12);
            pnlBookingsHeader.Name = "pnlBookingsHeader";
            pnlBookingsHeader.Size = new Size(1230, 80);
            pnlBookingsHeader.TabIndex = 0;
            // 
            // tlpBookingsHeader
            // 
            tlpBookingsHeader.ColumnCount = 2;
            tlpBookingsHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tlpBookingsHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tlpBookingsHeader.Controls.Add(pnlBookingHeader, 0, 0);
            tlpBookingsHeader.Controls.Add(btnNewBooking, 1, 0);
            tlpBookingsHeader.Dock = DockStyle.Fill;
            tlpBookingsHeader.Location = new Point(0, 0);
            tlpBookingsHeader.Margin = new Padding(0);
            tlpBookingsHeader.Name = "tlpBookingsHeader";
            tlpBookingsHeader.RowCount = 1;
            tlpBookingsHeader.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpBookingsHeader.Size = new Size(1230, 80);
            tlpBookingsHeader.TabIndex = 0;
            // 
            // pnlBookingHeader
            // 
            pnlBookingHeader.Controls.Add(lblBookingsSubtitle);
            pnlBookingHeader.Controls.Add(lblBookingsTitle);
            pnlBookingHeader.Dock = DockStyle.Fill;
            pnlBookingHeader.Location = new Point(0, 0);
            pnlBookingHeader.Margin = new Padding(0);
            pnlBookingHeader.Name = "pnlBookingHeader";
            pnlBookingHeader.Size = new Size(861, 80);
            pnlBookingHeader.TabIndex = 0;
            // 
            // lblBookingsSubtitle
            // 
            lblBookingsSubtitle.AutoSize = true;
            lblBookingsSubtitle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBookingsSubtitle.ForeColor = Color.FromArgb(105, 119, 139);
            lblBookingsSubtitle.Location = new Point(0, 45);
            lblBookingsSubtitle.Name = "lblBookingsSubtitle";
            lblBookingsSubtitle.Size = new Size(309, 20);
            lblBookingsSubtitle.TabIndex = 1;
            lblBookingsSubtitle.Text = "Search, review and manage every reservation.";
            // 
            // lblBookingsTitle
            // 
            lblBookingsTitle.AutoSize = true;
            lblBookingsTitle.Font = new Font("Georgia", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBookingsTitle.ForeColor = Color.FromArgb(25, 45, 68);
            lblBookingsTitle.Location = new Point(0, 0);
            lblBookingsTitle.Name = "lblBookingsTitle";
            lblBookingsTitle.Size = new Size(197, 43);
            lblBookingsTitle.TabIndex = 0;
            lblBookingsTitle.Text = "Bookings";
            // 
            // btnNewBooking
            // 
            btnNewBooking.Anchor = AnchorStyles.Right;
            btnNewBooking.BackColor = Color.FromArgb(201, 151, 58);
            btnNewBooking.FlatAppearance.BorderSize = 0;
            btnNewBooking.FlatStyle = FlatStyle.Flat;
            btnNewBooking.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNewBooking.ForeColor = Color.FromArgb(25, 45, 68);
            btnNewBooking.Location = new Point(1063, 25);
            btnNewBooking.Margin = new Padding(0, 20, 0, 0);
            btnNewBooking.Name = "btnNewBooking";
            btnNewBooking.Size = new Size(167, 49);
            btnNewBooking.TabIndex = 1;
            btnNewBooking.Text = "+ New Booking";
            btnNewBooking.UseVisualStyleBackColor = false;
            // 
            // pnlBookingFilters
            // 
            pnlBookingFilters.BorderStyle = BorderStyle.FixedSingle;
            pnlBookingFilters.Controls.Add(tlpBookingFilters);
            pnlBookingFilters.Dock = DockStyle.Fill;
            pnlBookingFilters.Location = new Point(38, 122);
            pnlBookingFilters.Margin = new Padding(0, 0, 0, 18);
            pnlBookingFilters.Name = "pnlBookingFilters";
            pnlBookingFilters.Padding = new Padding(18, 12, 18, 12);
            pnlBookingFilters.Size = new Size(1230, 65);
            pnlBookingFilters.TabIndex = 1;
            // 
            // tlpBookingFilters
            // 
            tlpBookingFilters.BackColor = Color.White;
            tlpBookingFilters.ColumnCount = 4;
            tlpBookingFilters.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48F));
            tlpBookingFilters.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16F));
            tlpBookingFilters.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18F));
            tlpBookingFilters.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18F));
            tlpBookingFilters.Controls.Add(txtSearchBooking, 0, 0);
            tlpBookingFilters.Controls.Add(cmbBookingStatus, 1, 0);
            tlpBookingFilters.Controls.Add(dtpBookingFrom, 2, 0);
            tlpBookingFilters.Controls.Add(dtpBookingTo, 3, 0);
            tlpBookingFilters.Dock = DockStyle.Fill;
            tlpBookingFilters.Location = new Point(18, 12);
            tlpBookingFilters.Margin = new Padding(0);
            tlpBookingFilters.Name = "tlpBookingFilters";
            tlpBookingFilters.RowCount = 1;
            tlpBookingFilters.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpBookingFilters.Size = new Size(1192, 39);
            tlpBookingFilters.TabIndex = 0;
            // 
            // txtSearchBooking
            // 
            txtSearchBooking.BorderStyle = BorderStyle.FixedSingle;
            txtSearchBooking.Dock = DockStyle.Fill;
            txtSearchBooking.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchBooking.Location = new Point(0, 5);
            txtSearchBooking.Margin = new Padding(0, 5, 10, 5);
            txtSearchBooking.Name = "txtSearchBooking";
            txtSearchBooking.PlaceholderText = "Search by guest, booking no. or room";
            txtSearchBooking.Size = new Size(562, 30);
            txtSearchBooking.TabIndex = 0;
            // 
            // cmbBookingStatus
            // 
            cmbBookingStatus.Dock = DockStyle.Fill;
            cmbBookingStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBookingStatus.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbBookingStatus.FormattingEnabled = true;
            cmbBookingStatus.Items.AddRange(new object[] { "All statuses", "Confirmed", "Pending", "Checked-in", "Checked-out", "Cancelled" });
            cmbBookingStatus.Location = new Point(577, 5);
            cmbBookingStatus.Margin = new Padding(5, 5, 10, 5);
            cmbBookingStatus.Name = "cmbBookingStatus";
            cmbBookingStatus.Size = new Size(175, 31);
            cmbBookingStatus.TabIndex = 1;
            // 
            // dtpBookingFrom
            // 
            dtpBookingFrom.CustomFormat = "dd MMM yyyy";
            dtpBookingFrom.Dock = DockStyle.Fill;
            dtpBookingFrom.Format = DateTimePickerFormat.Custom;
            dtpBookingFrom.Location = new Point(767, 5);
            dtpBookingFrom.Margin = new Padding(5, 5, 10, 5);
            dtpBookingFrom.Name = "dtpBookingFrom";
            dtpBookingFrom.Size = new Size(199, 27);
            dtpBookingFrom.TabIndex = 2;
            // 
            // dtpBookingTo
            // 
            dtpBookingTo.CustomFormat = "dd MMM yyyy";
            dtpBookingTo.Dock = DockStyle.Fill;
            dtpBookingTo.Format = DateTimePickerFormat.Custom;
            dtpBookingTo.Location = new Point(981, 5);
            dtpBookingTo.Margin = new Padding(5, 5, 0, 5);
            dtpBookingTo.Name = "dtpBookingTo";
            dtpBookingTo.Size = new Size(211, 27);
            dtpBookingTo.TabIndex = 3;
            // 
            // tlpBookingsContent
            // 
            tlpBookingsContent.ColumnCount = 2;
            tlpBookingsContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68F));
            tlpBookingsContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32F));
            tlpBookingsContent.Controls.Add(pnlBookingsList, 0, 0);
            tlpBookingsContent.Controls.Add(pnlBookingDetails, 1, 0);
            tlpBookingsContent.Dock = DockStyle.Fill;
            tlpBookingsContent.Location = new Point(38, 205);
            tlpBookingsContent.Margin = new Padding(0);
            tlpBookingsContent.Name = "tlpBookingsContent";
            tlpBookingsContent.RowCount = 1;
            tlpBookingsContent.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpBookingsContent.Size = new Size(1230, 614);
            tlpBookingsContent.TabIndex = 2;
            // 
            // pnlBookingsList
            // 
            pnlBookingsList.BackColor = Color.White;
            pnlBookingsList.BorderStyle = BorderStyle.FixedSingle;
            pnlBookingsList.Controls.Add(tlpBookingsList);
            pnlBookingsList.Dock = DockStyle.Fill;
            pnlBookingsList.Location = new Point(0, 0);
            pnlBookingsList.Margin = new Padding(0, 0, 12, 0);
            pnlBookingsList.Name = "pnlBookingsList";
            pnlBookingsList.Padding = new Padding(18, 18, 18, 12);
            pnlBookingsList.Size = new Size(824, 614);
            pnlBookingsList.TabIndex = 0;
            // 
            // tlpBookingsList
            // 
            tlpBookingsList.ColumnCount = 1;
            tlpBookingsList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpBookingsList.Controls.Add(dgvBookings, 0, 0);
            tlpBookingsList.Controls.Add(lblBookingsCount, 0, 1);
            tlpBookingsList.Dock = DockStyle.Fill;
            tlpBookingsList.Location = new Point(18, 18);
            tlpBookingsList.Margin = new Padding(0);
            tlpBookingsList.Name = "tlpBookingsList";
            tlpBookingsList.RowCount = 2;
            tlpBookingsList.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpBookingsList.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tlpBookingsList.Size = new Size(786, 582);
            tlpBookingsList.TabIndex = 0;
            // 
            // dgvBookings
            // 
            dgvBookings.AllowUserToAddRows = false;
            dgvBookings.AllowUserToDeleteRows = false;
            dgvBookings.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvBookings.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvBookings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBookings.BackgroundColor = Color.White;
            dgvBookings.BorderStyle = BorderStyle.None;
            dgvBookings.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvBookings.ColumnHeadersHeight = 38;
            dgvBookings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvBookings.Columns.AddRange(new DataGridViewColumn[] { colBookingNumber, colGuestName, colRoomNumber, colCheckIn, colCheckOut, colBookingTotal, colBookingStatus });
            dgvBookings.Dock = DockStyle.Fill;
            dgvBookings.EnableHeadersVisualStyles = false;
            dgvBookings.GridColor = Color.FromArgb(238, 234, 226);
            dgvBookings.Location = new Point(3, 3);
            dgvBookings.MultiSelect = false;
            dgvBookings.Name = "dgvBookings";
            dgvBookings.ReadOnly = true;
            dgvBookings.RowHeadersVisible = false;
            dgvBookings.RowHeadersWidth = 51;
            dgvBookings.RowTemplate.Height = 43;
            dgvBookings.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBookings.Size = new Size(780, 544);
            dgvBookings.TabIndex = 0;
            // 
            // colBookingNumber
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(45, 55, 68);
            dataGridViewCellStyle2.Padding = new Padding(8, 0, 5, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(250, 242, 222);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(25, 45, 68);
            colBookingNumber.DefaultCellStyle = dataGridViewCellStyle2;
            colBookingNumber.FillWeight = 95F;
            colBookingNumber.HeaderText = "BOOKING";
            colBookingNumber.MinimumWidth = 6;
            colBookingNumber.Name = "colBookingNumber";
            colBookingNumber.ReadOnly = true;
            // 
            // colGuestName
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(45, 55, 68);
            dataGridViewCellStyle3.Padding = new Padding(8, 0, 5, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(250, 242, 222);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(25, 45, 68);
            colGuestName.DefaultCellStyle = dataGridViewCellStyle3;
            colGuestName.FillWeight = 75F;
            colGuestName.HeaderText = "GUEST";
            colGuestName.MinimumWidth = 6;
            colGuestName.Name = "colGuestName";
            colGuestName.ReadOnly = true;
            // 
            // colRoomNumber
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(45, 55, 68);
            dataGridViewCellStyle4.Padding = new Padding(8, 0, 5, 0);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(250, 242, 222);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(25, 45, 68);
            colRoomNumber.DefaultCellStyle = dataGridViewCellStyle4;
            colRoomNumber.FillWeight = 48F;
            colRoomNumber.HeaderText = "ROOM";
            colRoomNumber.MinimumWidth = 6;
            colRoomNumber.Name = "colRoomNumber";
            colRoomNumber.ReadOnly = true;
            // 
            // colCheckIn
            // 
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(45, 55, 68);
            dataGridViewCellStyle5.Padding = new Padding(8, 0, 5, 0);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(250, 242, 222);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(25, 45, 68);
            colCheckIn.DefaultCellStyle = dataGridViewCellStyle5;
            colCheckIn.FillWeight = 85F;
            colCheckIn.HeaderText = "CHECK-IN";
            colCheckIn.MinimumWidth = 6;
            colCheckIn.Name = "colCheckIn";
            colCheckIn.ReadOnly = true;
            // 
            // colCheckOut
            // 
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(45, 55, 68);
            dataGridViewCellStyle6.Padding = new Padding(8, 0, 5, 0);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(250, 242, 222);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(25, 45, 68);
            colCheckOut.DefaultCellStyle = dataGridViewCellStyle6;
            colCheckOut.FillWeight = 90F;
            colCheckOut.HeaderText = "CHECK-OUT";
            colCheckOut.MinimumWidth = 6;
            colCheckOut.Name = "colCheckOut";
            colCheckOut.ReadOnly = true;
            // 
            // colBookingTotal
            // 
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.White;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(45, 55, 68);
            dataGridViewCellStyle7.Padding = new Padding(8, 0, 5, 0);
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(250, 242, 222);
            dataGridViewCellStyle7.SelectionForeColor = Color.FromArgb(25, 45, 68);
            colBookingTotal.DefaultCellStyle = dataGridViewCellStyle7;
            colBookingTotal.HeaderText = "TOTAL(GHS)";
            colBookingTotal.MinimumWidth = 6;
            colBookingTotal.Name = "colBookingTotal";
            colBookingTotal.ReadOnly = true;
            // 
            // colBookingStatus
            // 
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(45, 55, 68);
            dataGridViewCellStyle8.Padding = new Padding(8, 0, 5, 0);
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(250, 242, 222);
            dataGridViewCellStyle8.SelectionForeColor = Color.FromArgb(25, 45, 68);
            colBookingStatus.DefaultCellStyle = dataGridViewCellStyle8;
            colBookingStatus.FillWeight = 105F;
            colBookingStatus.HeaderText = "STATUS";
            colBookingStatus.MinimumWidth = 6;
            colBookingStatus.Name = "colBookingStatus";
            colBookingStatus.ReadOnly = true;
            // 
            // lblBookingsCount
            // 
            lblBookingsCount.AutoSize = true;
            lblBookingsCount.Dock = DockStyle.Fill;
            lblBookingsCount.ForeColor = Color.FromArgb(105, 119, 139);
            lblBookingsCount.Location = new Point(0, 550);
            lblBookingsCount.Margin = new Padding(0);
            lblBookingsCount.Name = "lblBookingsCount";
            lblBookingsCount.Size = new Size(786, 32);
            lblBookingsCount.TabIndex = 1;
            lblBookingsCount.Text = "Showing 11 of 86 bookings";
            lblBookingsCount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlBookingDetails
            // 
            pnlBookingDetails.BackColor = Color.White;
            pnlBookingDetails.BorderStyle = BorderStyle.FixedSingle;
            pnlBookingDetails.Controls.Add(tlpBookingDetails);
            pnlBookingDetails.Dock = DockStyle.Fill;
            pnlBookingDetails.Location = new Point(848, 0);
            pnlBookingDetails.Margin = new Padding(12, 0, 0, 0);
            pnlBookingDetails.Name = "pnlBookingDetails";
            pnlBookingDetails.Padding = new Padding(20, 18, 20, 18);
            pnlBookingDetails.Size = new Size(382, 614);
            pnlBookingDetails.TabIndex = 1;
            // 
            // tlpBookingDetails
            // 
            tlpBookingDetails.ColumnCount = 1;
            tlpBookingDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpBookingDetails.Controls.Add(tableLayoutPanel1, 0, 0);
            tlpBookingDetails.Controls.Add(pnlBookingGuest, 0, 1);
            tlpBookingDetails.Controls.Add(pnlBookingInformation, 0, 2);
            tlpBookingDetails.Controls.Add(pnlBookingNotes, 0, 3);
            tlpBookingDetails.Controls.Add(btnEditBooking, 0, 4);
            tlpBookingDetails.Controls.Add(tlpBookingBottomActions, 0, 5);
            tlpBookingDetails.Dock = DockStyle.Fill;
            tlpBookingDetails.Location = new Point(20, 18);
            tlpBookingDetails.Margin = new Padding(0);
            tlpBookingDetails.Name = "tlpBookingDetails";
            tlpBookingDetails.RowCount = 6;
            tlpBookingDetails.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tlpBookingDetails.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tlpBookingDetails.RowStyles.Add(new RowStyle(SizeType.Absolute, 205F));
            tlpBookingDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpBookingDetails.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tlpBookingDetails.RowStyles.Add(new RowStyle(SizeType.Absolute, 112F));
            tlpBookingDetails.Size = new Size(340, 576);
            tlpBookingDetails.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.Controls.Add(lblSelectedBookingNumber, 0, 0);
            tableLayoutPanel1.Controls.Add(lblSelectedBookingStatus, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(340, 40);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblSelectedBookingNumber
            // 
            lblSelectedBookingNumber.AutoSize = true;
            lblSelectedBookingNumber.Dock = DockStyle.Fill;
            lblSelectedBookingNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSelectedBookingNumber.ForeColor = Color.FromArgb(25, 45, 68);
            lblSelectedBookingNumber.Location = new Point(3, 0);
            lblSelectedBookingNumber.Name = "lblSelectedBookingNumber";
            lblSelectedBookingNumber.Size = new Size(215, 40);
            lblSelectedBookingNumber.TabIndex = 0;
            lblSelectedBookingNumber.Text = "BK-1042";
            lblSelectedBookingNumber.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSelectedBookingStatus
            // 
            lblSelectedBookingStatus.BackColor = Color.FromArgb(225, 241, 232);
            lblSelectedBookingStatus.Dock = DockStyle.Fill;
            lblSelectedBookingStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSelectedBookingStatus.ForeColor = Color.FromArgb(31, 112, 83);
            lblSelectedBookingStatus.Location = new Point(224, 0);
            lblSelectedBookingStatus.Name = "lblSelectedBookingStatus";
            lblSelectedBookingStatus.Size = new Size(113, 40);
            lblSelectedBookingStatus.TabIndex = 1;
            lblSelectedBookingStatus.Text = "Checked-in";
            lblSelectedBookingStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlBookingGuest
            // 
            pnlBookingGuest.Controls.Add(tlpBookingGuest);
            pnlBookingGuest.Dock = DockStyle.Fill;
            pnlBookingGuest.Location = new Point(0, 45);
            pnlBookingGuest.Margin = new Padding(0, 5, 0, 5);
            pnlBookingGuest.Name = "pnlBookingGuest";
            pnlBookingGuest.Size = new Size(340, 65);
            pnlBookingGuest.TabIndex = 1;
            // 
            // tlpBookingGuest
            // 
            tlpBookingGuest.ColumnCount = 2;
            tlpBookingGuest.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 55F));
            tlpBookingGuest.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpBookingGuest.Controls.Add(lblGuestInitials, 0, 0);
            tlpBookingGuest.Controls.Add(tlpGuestIdentity, 1, 0);
            tlpBookingGuest.Dock = DockStyle.Fill;
            tlpBookingGuest.Location = new Point(0, 0);
            tlpBookingGuest.Name = "tlpBookingGuest";
            tlpBookingGuest.RowCount = 1;
            tlpBookingGuest.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpBookingGuest.Size = new Size(340, 65);
            tlpBookingGuest.TabIndex = 0;
            // 
            // lblGuestInitials
            // 
            lblGuestInitials.AutoSize = true;
            lblGuestInitials.BackColor = Color.FromArgb(20, 43, 70);
            lblGuestInitials.Dock = DockStyle.Fill;
            lblGuestInitials.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGuestInitials.ForeColor = Color.White;
            lblGuestInitials.Location = new Point(3, 0);
            lblGuestInitials.Name = "lblGuestInitials";
            lblGuestInitials.Size = new Size(49, 65);
            lblGuestInitials.TabIndex = 0;
            lblGuestInitials.Text = "OB";
            lblGuestInitials.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tlpGuestIdentity
            // 
            tlpGuestIdentity.ColumnCount = 1;
            tlpGuestIdentity.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpGuestIdentity.Controls.Add(lblSelectedGuestName, 0, 0);
            tlpGuestIdentity.Controls.Add(lblSelectedGuestPhone, 0, 1);
            tlpGuestIdentity.Dock = DockStyle.Fill;
            tlpGuestIdentity.Location = new Point(58, 3);
            tlpGuestIdentity.Name = "tlpGuestIdentity";
            tlpGuestIdentity.RowCount = 2;
            tlpGuestIdentity.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpGuestIdentity.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpGuestIdentity.Size = new Size(279, 59);
            tlpGuestIdentity.TabIndex = 1;
            // 
            // lblSelectedGuestName
            // 
            lblSelectedGuestName.AutoSize = true;
            lblSelectedGuestName.Dock = DockStyle.Fill;
            lblSelectedGuestName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSelectedGuestName.ForeColor = Color.FromArgb(38, 47, 60);
            lblSelectedGuestName.Location = new Point(3, 0);
            lblSelectedGuestName.Name = "lblSelectedGuestName";
            lblSelectedGuestName.Size = new Size(273, 29);
            lblSelectedGuestName.TabIndex = 0;
            lblSelectedGuestName.Text = "Olivia Bennett";
            lblSelectedGuestName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSelectedGuestPhone
            // 
            lblSelectedGuestPhone.AutoSize = true;
            lblSelectedGuestPhone.Dock = DockStyle.Fill;
            lblSelectedGuestPhone.ForeColor = Color.FromArgb(105, 119, 139);
            lblSelectedGuestPhone.Location = new Point(3, 29);
            lblSelectedGuestPhone.Name = "lblSelectedGuestPhone";
            lblSelectedGuestPhone.Size = new Size(273, 30);
            lblSelectedGuestPhone.TabIndex = 1;
            lblSelectedGuestPhone.Text = "0241 234 567";
            lblSelectedGuestPhone.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlBookingInformation
            // 
            pnlBookingInformation.Controls.Add(tableLayoutPanel2);
            pnlBookingInformation.Dock = DockStyle.Fill;
            pnlBookingInformation.Location = new Point(0, 120);
            pnlBookingInformation.Margin = new Padding(0, 5, 0, 8);
            pnlBookingInformation.Name = "pnlBookingInformation";
            pnlBookingInformation.Padding = new Padding(12, 8, 12, 8);
            pnlBookingInformation.Size = new Size(340, 192);
            pnlBookingInformation.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.FromArgb(245, 242, 236);
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            tableLayoutPanel2.Controls.Add(lblDetailRoom, 0, 0);
            tableLayoutPanel2.Controls.Add(lblDetailCheckIn, 0, 1);
            tableLayoutPanel2.Controls.Add(lblDetailCheckOut, 0, 2);
            tableLayoutPanel2.Controls.Add(lblDetailGuests, 0, 3);
            tableLayoutPanel2.Controls.Add(lblDetailTotal, 0, 4);
            tableLayoutPanel2.Controls.Add(lblDetailPaid, 0, 5);
            tableLayoutPanel2.Controls.Add(lblDetailRoomValue, 1, 0);
            tableLayoutPanel2.Controls.Add(lblDetailCheckInValue, 1, 1);
            tableLayoutPanel2.Controls.Add(lblDetailCheckOutValue, 1, 2);
            tableLayoutPanel2.Controls.Add(lblDetailGuestsValue, 1, 3);
            tableLayoutPanel2.Controls.Add(label1, 1, 4);
            tableLayoutPanel2.Controls.Add(lblDetailPaidValue, 1, 5);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(12, 8);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 6;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(316, 176);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // lblDetailRoom
            // 
            lblDetailRoom.AutoSize = true;
            lblDetailRoom.Dock = DockStyle.Fill;
            lblDetailRoom.ForeColor = Color.FromArgb(105, 119, 139);
            lblDetailRoom.Location = new Point(3, 0);
            lblDetailRoom.Name = "lblDetailRoom";
            lblDetailRoom.Size = new Size(136, 29);
            lblDetailRoom.TabIndex = 0;
            lblDetailRoom.Text = "Room";
            lblDetailRoom.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDetailCheckIn
            // 
            lblDetailCheckIn.AutoSize = true;
            lblDetailCheckIn.Dock = DockStyle.Fill;
            lblDetailCheckIn.ForeColor = Color.FromArgb(105, 119, 139);
            lblDetailCheckIn.Location = new Point(3, 29);
            lblDetailCheckIn.Name = "lblDetailCheckIn";
            lblDetailCheckIn.Size = new Size(136, 29);
            lblDetailCheckIn.TabIndex = 1;
            lblDetailCheckIn.Text = "Check-in";
            lblDetailCheckIn.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDetailCheckOut
            // 
            lblDetailCheckOut.AutoSize = true;
            lblDetailCheckOut.Dock = DockStyle.Fill;
            lblDetailCheckOut.ForeColor = Color.FromArgb(105, 119, 139);
            lblDetailCheckOut.Location = new Point(3, 58);
            lblDetailCheckOut.Name = "lblDetailCheckOut";
            lblDetailCheckOut.Size = new Size(136, 29);
            lblDetailCheckOut.TabIndex = 2;
            lblDetailCheckOut.Text = "Check-out";
            lblDetailCheckOut.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDetailGuests
            // 
            lblDetailGuests.AutoSize = true;
            lblDetailGuests.Dock = DockStyle.Fill;
            lblDetailGuests.ForeColor = Color.FromArgb(105, 119, 139);
            lblDetailGuests.Location = new Point(3, 87);
            lblDetailGuests.Name = "lblDetailGuests";
            lblDetailGuests.Size = new Size(136, 29);
            lblDetailGuests.TabIndex = 3;
            lblDetailGuests.Text = "Guests";
            lblDetailGuests.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDetailTotal
            // 
            lblDetailTotal.AutoSize = true;
            lblDetailTotal.Dock = DockStyle.Fill;
            lblDetailTotal.ForeColor = Color.FromArgb(105, 119, 139);
            lblDetailTotal.Location = new Point(3, 116);
            lblDetailTotal.Name = "lblDetailTotal";
            lblDetailTotal.Size = new Size(136, 29);
            lblDetailTotal.TabIndex = 4;
            lblDetailTotal.Text = "Total";
            lblDetailTotal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDetailPaid
            // 
            lblDetailPaid.AutoSize = true;
            lblDetailPaid.Dock = DockStyle.Fill;
            lblDetailPaid.ForeColor = Color.FromArgb(105, 119, 139);
            lblDetailPaid.Location = new Point(3, 145);
            lblDetailPaid.Name = "lblDetailPaid";
            lblDetailPaid.Size = new Size(136, 31);
            lblDetailPaid.TabIndex = 5;
            lblDetailPaid.Text = "Paid";
            lblDetailPaid.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDetailRoomValue
            // 
            lblDetailRoomValue.AutoSize = true;
            lblDetailRoomValue.Dock = DockStyle.Fill;
            lblDetailRoomValue.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDetailRoomValue.ForeColor = Color.FromArgb(45, 55, 68);
            lblDetailRoomValue.Location = new Point(145, 0);
            lblDetailRoomValue.Name = "lblDetailRoomValue";
            lblDetailRoomValue.Size = new Size(168, 29);
            lblDetailRoomValue.TabIndex = 6;
            lblDetailRoomValue.Text = "204 · Deluxe King";
            lblDetailRoomValue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDetailCheckInValue
            // 
            lblDetailCheckInValue.AutoSize = true;
            lblDetailCheckInValue.Dock = DockStyle.Fill;
            lblDetailCheckInValue.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDetailCheckInValue.ForeColor = Color.FromArgb(45, 55, 68);
            lblDetailCheckInValue.Location = new Point(145, 29);
            lblDetailCheckInValue.Name = "lblDetailCheckInValue";
            lblDetailCheckInValue.Size = new Size(168, 29);
            lblDetailCheckInValue.TabIndex = 7;
            lblDetailCheckInValue.Text = "17 Nov 2026";
            lblDetailCheckInValue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDetailCheckOutValue
            // 
            lblDetailCheckOutValue.AutoSize = true;
            lblDetailCheckOutValue.Dock = DockStyle.Fill;
            lblDetailCheckOutValue.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDetailCheckOutValue.ForeColor = Color.FromArgb(45, 55, 68);
            lblDetailCheckOutValue.Location = new Point(145, 58);
            lblDetailCheckOutValue.Name = "lblDetailCheckOutValue";
            lblDetailCheckOutValue.Size = new Size(168, 29);
            lblDetailCheckOutValue.TabIndex = 8;
            lblDetailCheckOutValue.Text = "20 Nov 2026";
            lblDetailCheckOutValue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDetailGuestsValue
            // 
            lblDetailGuestsValue.AutoSize = true;
            lblDetailGuestsValue.Dock = DockStyle.Fill;
            lblDetailGuestsValue.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDetailGuestsValue.ForeColor = Color.FromArgb(45, 55, 68);
            lblDetailGuestsValue.Location = new Point(145, 87);
            lblDetailGuestsValue.Name = "lblDetailGuestsValue";
            lblDetailGuestsValue.Size = new Size(168, 29);
            lblDetailGuestsValue.TabIndex = 9;
            lblDetailGuestsValue.Text = "2 adults";
            lblDetailGuestsValue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(25, 45, 68);
            label1.Location = new Point(145, 116);
            label1.Name = "label1";
            label1.Size = new Size(168, 29);
            label1.TabIndex = 10;
            label1.Text = "GHS 2,242.50";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDetailPaidValue
            // 
            lblDetailPaidValue.AutoSize = true;
            lblDetailPaidValue.Dock = DockStyle.Fill;
            lblDetailPaidValue.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDetailPaidValue.ForeColor = Color.FromArgb(31, 112, 83);
            lblDetailPaidValue.Location = new Point(145, 145);
            lblDetailPaidValue.Name = "lblDetailPaidValue";
            lblDetailPaidValue.Size = new Size(168, 31);
            lblDetailPaidValue.TabIndex = 11;
            lblDetailPaidValue.Text = "GHS 1,000.00";
            lblDetailPaidValue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pnlBookingNotes
            // 
            pnlBookingNotes.Controls.Add(tlpBookingNotes);
            pnlBookingNotes.Dock = DockStyle.Fill;
            pnlBookingNotes.Location = new Point(0, 323);
            pnlBookingNotes.Margin = new Padding(0, 3, 0, 8);
            pnlBookingNotes.Name = "pnlBookingNotes";
            pnlBookingNotes.Padding = new Padding(0, 5, 0, 0);
            pnlBookingNotes.Size = new Size(340, 81);
            pnlBookingNotes.TabIndex = 3;
            // 
            // tlpBookingNotes
            // 
            tlpBookingNotes.ColumnCount = 1;
            tlpBookingNotes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpBookingNotes.Controls.Add(lblBookingNoteTitle, 0, 0);
            tlpBookingNotes.Controls.Add(lblBookingNote, 0, 1);
            tlpBookingNotes.Dock = DockStyle.Fill;
            tlpBookingNotes.Location = new Point(0, 5);
            tlpBookingNotes.Name = "tlpBookingNotes";
            tlpBookingNotes.RowCount = 2;
            tlpBookingNotes.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tlpBookingNotes.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpBookingNotes.Size = new Size(340, 76);
            tlpBookingNotes.TabIndex = 0;
            // 
            // lblBookingNoteTitle
            // 
            lblBookingNoteTitle.AutoSize = true;
            lblBookingNoteTitle.Dock = DockStyle.Fill;
            lblBookingNoteTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBookingNoteTitle.ForeColor = Color.FromArgb(38, 47, 60);
            lblBookingNoteTitle.Location = new Point(3, 0);
            lblBookingNoteTitle.Name = "lblBookingNoteTitle";
            lblBookingNoteTitle.Size = new Size(334, 25);
            lblBookingNoteTitle.TabIndex = 0;
            lblBookingNoteTitle.Text = "Note:";
            // 
            // lblBookingNote
            // 
            lblBookingNote.AutoEllipsis = true;
            lblBookingNote.Dock = DockStyle.Fill;
            lblBookingNote.ForeColor = Color.FromArgb(105, 119, 139);
            lblBookingNote.Location = new Point(3, 25);
            lblBookingNote.Name = "lblBookingNote";
            lblBookingNote.Size = new Size(334, 51);
            lblBookingNote.TabIndex = 1;
            lblBookingNote.Text = "Late arrival around 22:00. High floor if possible.";
            // 
            // btnEditBooking
            // 
            btnEditBooking.BackColor = Color.FromArgb(20, 43, 70);
            btnEditBooking.Cursor = Cursors.Hand;
            btnEditBooking.Dock = DockStyle.Fill;
            btnEditBooking.FlatAppearance.BorderSize = 0;
            btnEditBooking.FlatStyle = FlatStyle.Flat;
            btnEditBooking.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditBooking.ForeColor = Color.White;
            btnEditBooking.Location = new Point(0, 416);
            btnEditBooking.Margin = new Padding(0, 4, 0, 5);
            btnEditBooking.Name = "btnEditBooking";
            btnEditBooking.Size = new Size(340, 43);
            btnEditBooking.TabIndex = 4;
            btnEditBooking.Text = "Edit Booking";
            btnEditBooking.UseVisualStyleBackColor = false;
            // 
            // tlpBookingBottomActions
            // 
            tlpBookingBottomActions.ColumnCount = 1;
            tlpBookingBottomActions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpBookingBottomActions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpBookingBottomActions.Controls.Add(btnRecordPayment, 0, 0);
            tlpBookingBottomActions.Controls.Add(btnCancelBooking, 0, 1);
            tlpBookingBottomActions.Dock = DockStyle.Fill;
            tlpBookingBottomActions.Location = new Point(0, 464);
            tlpBookingBottomActions.Margin = new Padding(0);
            tlpBookingBottomActions.Name = "tlpBookingBottomActions";
            tlpBookingBottomActions.RowCount = 2;
            tlpBookingBottomActions.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpBookingBottomActions.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpBookingBottomActions.Size = new Size(340, 112);
            tlpBookingBottomActions.TabIndex = 5;
            // 
            // btnRecordPayment
            // 
            btnRecordPayment.BackColor = Color.FromArgb(201, 151, 58);
            btnRecordPayment.Cursor = Cursors.Hand;
            btnRecordPayment.Dock = DockStyle.Fill;
            btnRecordPayment.FlatAppearance.BorderSize = 0;
            btnRecordPayment.FlatStyle = FlatStyle.Flat;
            btnRecordPayment.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRecordPayment.ForeColor = Color.FromArgb(25, 45, 68);
            btnRecordPayment.Location = new Point(0, 3);
            btnRecordPayment.Margin = new Padding(0, 3, 0, 4);
            btnRecordPayment.Name = "btnRecordPayment";
            btnRecordPayment.Size = new Size(340, 49);
            btnRecordPayment.TabIndex = 0;
            btnRecordPayment.Text = "Record Payment";
            btnRecordPayment.UseVisualStyleBackColor = false;
            // 
            // btnCancelBooking
            // 
            btnCancelBooking.Cursor = Cursors.Hand;
            btnCancelBooking.Dock = DockStyle.Fill;
            btnCancelBooking.FlatAppearance.BorderColor = Color.FromArgb(230, 180, 174);
            btnCancelBooking.FlatStyle = FlatStyle.Flat;
            btnCancelBooking.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelBooking.ForeColor = Color.FromArgb(185, 58, 51);
            btnCancelBooking.Location = new Point(0, 60);
            btnCancelBooking.Margin = new Padding(0, 4, 0, 0);
            btnCancelBooking.Name = "btnCancelBooking";
            btnCancelBooking.Size = new Size(340, 52);
            btnCancelBooking.TabIndex = 1;
            btnCancelBooking.Text = "Cancel Booking";
            btnCancelBooking.UseVisualStyleBackColor = true;
            // 
            // ucBookings
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(245, 242, 236);
            Controls.Add(tlpBookingsMain);
            Margin = new Padding(0);
            Name = "ucBookings";
            Size = new Size(1306, 851);
            Load += ucBookings_Load;
            tlpBookingsMain.ResumeLayout(false);
            pnlBookingsHeader.ResumeLayout(false);
            tlpBookingsHeader.ResumeLayout(false);
            pnlBookingHeader.ResumeLayout(false);
            pnlBookingHeader.PerformLayout();
            pnlBookingFilters.ResumeLayout(false);
            tlpBookingFilters.ResumeLayout(false);
            tlpBookingFilters.PerformLayout();
            tlpBookingsContent.ResumeLayout(false);
            pnlBookingsList.ResumeLayout(false);
            tlpBookingsList.ResumeLayout(false);
            tlpBookingsList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookings).EndInit();
            pnlBookingDetails.ResumeLayout(false);
            tlpBookingDetails.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            pnlBookingGuest.ResumeLayout(false);
            tlpBookingGuest.ResumeLayout(false);
            tlpBookingGuest.PerformLayout();
            tlpGuestIdentity.ResumeLayout(false);
            tlpGuestIdentity.PerformLayout();
            pnlBookingInformation.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            pnlBookingNotes.ResumeLayout(false);
            tlpBookingNotes.ResumeLayout(false);
            tlpBookingNotes.PerformLayout();
            tlpBookingBottomActions.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpBookingsMain;
        private Panel pnlBookingsHeader;
        private TableLayoutPanel tlpBookingsHeader;
        private Panel pnlBookingHeader;
        private Label lblBookingsTitle;
        private Label lblBookingsSubtitle;
        private Button btnNewBooking;
        private Panel pnlBookingFilters;
        private TableLayoutPanel tlpBookingFilters;
        private TextBox txtSearchBooking;
        private ComboBox cmbBookingStatus;
        private DateTimePicker dtpBookingFrom;
        private DateTimePicker dtpBookingTo;
        private TableLayoutPanel tlpBookingsContent;
        private Panel pnlBookingsList;
        private TableLayoutPanel tlpBookingsList;
        private DataGridView dgvBookings;
        private DataGridViewTextBoxColumn colBookingNumber;
        private DataGridViewTextBoxColumn colGuestName;
        private DataGridViewTextBoxColumn colRoomNumber;
        private DataGridViewTextBoxColumn colCheckIn;
        private DataGridViewTextBoxColumn colCheckOut;
        private DataGridViewTextBoxColumn colBookingTotal;
        private DataGridViewTextBoxColumn colBookingStatus;
        private Label lblBookingsCount;
        private Panel pnlBookingDetails;
        private TableLayoutPanel tlpBookingDetails;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblSelectedBookingNumber;
        private Label lblSelectedBookingStatus;
        private Panel pnlBookingGuest;
        private TableLayoutPanel tlpBookingGuest;
        private Label lblGuestInitials;
        private TableLayoutPanel tlpGuestIdentity;
        private Label lblSelectedGuestName;
        private Label lblSelectedGuestPhone;
        private Panel pnlBookingInformation;
        private TableLayoutPanel tableLayoutPanel2;
        private Label lblDetailRoom;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label lblDetailCheckIn;
        private Label lblDetailCheckOut;
        private Label lblDetailGuests;
        private Label lblDetailTotal;
        private Label lblDetailPaid;
        private Label lblDetailRoomValue;
        private Label lblDetailCheckInValue;
        private Label lblDetailCheckOutValue;
        private Label lblDetailGuestsValue;
        private Label label1;
        private Label lblDetailPaidValue;
        private Panel pnlBookingNotes;
        private TableLayoutPanel tlpBookingNotes;
        private Label lblBookingNoteTitle;
        private Label lblBookingNote;
        private Button btnEditBooking;
        private TableLayoutPanel tlpBookingBottomActions;
        private Button btnRecordPayment;
        private Button btnCancelBooking;
    }
}
