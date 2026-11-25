namespace Hotel_Booking.UserControls
{
    partial class ucPayments
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            tlpPaymentsMain = new TableLayoutPanel();
            pnlPaymentsHeader = new Panel();
            tlpPaymentsHeader = new TableLayoutPanel();
            lblPaymentsTitle = new Label();
            lblPaymentsSubtitle = new Label();
            tlpPaymentStatistics = new TableLayoutPanel();
            pnlCollectedToday = new Panel();
            tlpCollectedToday = new TableLayoutPanel();
            lblCollectedTodayTitle = new Label();
            lblCollectedTodayAmount = new Label();
            pnlCollectedMonth = new Panel();
            tlpCollectedMonth = new TableLayoutPanel();
            lblCollectedMonthTitle = new Label();
            lblCollectedMonthAmount = new Label();
            pnlOutstandingBalances = new Panel();
            tlpOutstandingBalances = new TableLayoutPanel();
            lblOutstandingBalancesTitle = new Label();
            lblOutstandingBalancesAmount = new Label();
            tlpPaymentsContent = new TableLayoutPanel();
            pnlRecordPayment = new Panel();
            tlpRecordPayment = new TableLayoutPanel();
            lblRecordPaymentTitle = new Label();
            tlpPaymentBooking = new TableLayoutPanel();
            lblPaymentBooking = new Label();
            cmbPaymentBooking = new ComboBox();
            pnlPaymentBillSummary = new Panel();
            tlpPaymentBillSummary = new TableLayoutPanel();
            lblPaymentTotalBill = new Label();
            lblPaymentTotalBillValue = new Label();
            lblPaymentPaidSoFar = new Label();
            label1 = new Label();
            lblPaymentBalanceDue = new Label();
            lblPaymentBalanceDueValue = new Label();
            tlpPaymentAmount = new TableLayoutPanel();
            lblPaymentAmount = new Label();
            textBox1 = new TextBox();
            tlpPaymentMethod = new TableLayoutPanel();
            lblPaymentMethod = new Label();
            tlpPaymentMethodButtons = new TableLayoutPanel();
            btnMethodBankTransfer = new Button();
            btnMethodMobileMoney = new Button();
            btnMethodCard = new Button();
            btnMethodCash = new Button();
            tlpPaymentReference = new TableLayoutPanel();
            lblPaymentReference = new Label();
            txtPaymentReference = new TextBox();
            tlpPaymentActions = new TableLayoutPanel();
            btnSavePayment = new Button();
            btnPrintReceipt = new Button();
            pnlPaymentHistory = new Panel();
            tlpPaymentHistory = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblPaymentHistoryTitle = new Label();
            pnlPaymentHistorySearch = new Panel();
            tlpPaymentHistorySearch = new TableLayoutPanel();
            lblPaymentSearchIcon = new Label();
            txtPaymentSearch = new TextBox();
            dgvPaymentHistory = new DataGridView();
            colReceiptNumber = new DataGridViewTextBoxColumn();
            colPaymentGuest = new DataGridViewTextBoxColumn();
            colPaymentBooking = new DataGridViewTextBoxColumn();
            colPaymentMethod = new DataGridViewTextBoxColumn();
            colPaymentAmount = new DataGridViewTextBoxColumn();
            colPaymentDate = new DataGridViewTextBoxColumn();
            lblPaymentHistoryCount = new Label();
            tlpPaymentsMain.SuspendLayout();
            pnlPaymentsHeader.SuspendLayout();
            tlpPaymentsHeader.SuspendLayout();
            tlpPaymentStatistics.SuspendLayout();
            pnlCollectedToday.SuspendLayout();
            tlpCollectedToday.SuspendLayout();
            pnlCollectedMonth.SuspendLayout();
            tlpCollectedMonth.SuspendLayout();
            pnlOutstandingBalances.SuspendLayout();
            tlpOutstandingBalances.SuspendLayout();
            tlpPaymentsContent.SuspendLayout();
            pnlRecordPayment.SuspendLayout();
            tlpRecordPayment.SuspendLayout();
            tlpPaymentBooking.SuspendLayout();
            pnlPaymentBillSummary.SuspendLayout();
            tlpPaymentBillSummary.SuspendLayout();
            tlpPaymentAmount.SuspendLayout();
            tlpPaymentMethod.SuspendLayout();
            tlpPaymentMethodButtons.SuspendLayout();
            tlpPaymentReference.SuspendLayout();
            tlpPaymentActions.SuspendLayout();
            pnlPaymentHistory.SuspendLayout();
            tlpPaymentHistory.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            pnlPaymentHistorySearch.SuspendLayout();
            tlpPaymentHistorySearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPaymentHistory).BeginInit();
            SuspendLayout();
            // 
            // tlpPaymentsMain
            // 
            tlpPaymentsMain.ColumnCount = 1;
            tlpPaymentsMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpPaymentsMain.Controls.Add(pnlPaymentsHeader, 0, 0);
            tlpPaymentsMain.Controls.Add(tlpPaymentStatistics, 0, 1);
            tlpPaymentsMain.Controls.Add(tlpPaymentsContent, 0, 2);
            tlpPaymentsMain.Dock = DockStyle.Fill;
            tlpPaymentsMain.Location = new Point(0, 0);
            tlpPaymentsMain.Margin = new Padding(0);
            tlpPaymentsMain.Name = "tlpPaymentsMain";
            tlpPaymentsMain.Padding = new Padding(32, 25, 32, 25);
            tlpPaymentsMain.RowCount = 3;
            tlpPaymentsMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tlpPaymentsMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tlpPaymentsMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpPaymentsMain.Size = new Size(1291, 786);
            tlpPaymentsMain.TabIndex = 0;
            // 
            // pnlPaymentsHeader
            // 
            pnlPaymentsHeader.Controls.Add(tlpPaymentsHeader);
            pnlPaymentsHeader.Dock = DockStyle.Fill;
            pnlPaymentsHeader.Location = new Point(32, 25);
            pnlPaymentsHeader.Margin = new Padding(0, 0, 0, 10);
            pnlPaymentsHeader.Name = "pnlPaymentsHeader";
            pnlPaymentsHeader.Size = new Size(1227, 65);
            pnlPaymentsHeader.TabIndex = 0;
            // 
            // tlpPaymentsHeader
            // 
            tlpPaymentsHeader.ColumnCount = 1;
            tlpPaymentsHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpPaymentsHeader.Controls.Add(lblPaymentsTitle, 0, 0);
            tlpPaymentsHeader.Controls.Add(lblPaymentsSubtitle, 0, 1);
            tlpPaymentsHeader.Dock = DockStyle.Fill;
            tlpPaymentsHeader.Location = new Point(0, 0);
            tlpPaymentsHeader.Margin = new Padding(0);
            tlpPaymentsHeader.Name = "tlpPaymentsHeader";
            tlpPaymentsHeader.RowCount = 2;
            tlpPaymentsHeader.RowStyles.Add(new RowStyle(SizeType.Percent, 55F));
            tlpPaymentsHeader.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
            tlpPaymentsHeader.Size = new Size(1227, 65);
            tlpPaymentsHeader.TabIndex = 0;
            // 
            // lblPaymentsTitle
            // 
            lblPaymentsTitle.AutoSize = true;
            lblPaymentsTitle.Dock = DockStyle.Fill;
            lblPaymentsTitle.Font = new Font("Georgia", 21F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPaymentsTitle.ForeColor = Color.FromArgb(25, 45, 68);
            lblPaymentsTitle.Location = new Point(3, 0);
            lblPaymentsTitle.Name = "lblPaymentsTitle";
            lblPaymentsTitle.Size = new Size(1221, 35);
            lblPaymentsTitle.TabIndex = 0;
            lblPaymentsTitle.Text = "Payments";
            lblPaymentsTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPaymentsSubtitle
            // 
            lblPaymentsSubtitle.AutoSize = true;
            lblPaymentsSubtitle.Dock = DockStyle.Fill;
            lblPaymentsSubtitle.ForeColor = Color.FromArgb(105, 119, 139);
            lblPaymentsSubtitle.Location = new Point(3, 35);
            lblPaymentsSubtitle.Name = "lblPaymentsSubtitle";
            lblPaymentsSubtitle.Size = new Size(1221, 30);
            lblPaymentsSubtitle.TabIndex = 1;
            lblPaymentsSubtitle.Text = "Record payments and review the guest bill.";
            lblPaymentsSubtitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tlpPaymentStatistics
            // 
            tlpPaymentStatistics.ColumnCount = 3;
            tlpPaymentStatistics.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlpPaymentStatistics.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlpPaymentStatistics.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlpPaymentStatistics.Controls.Add(pnlCollectedToday, 0, 0);
            tlpPaymentStatistics.Controls.Add(pnlCollectedMonth, 1, 0);
            tlpPaymentStatistics.Controls.Add(pnlOutstandingBalances, 2, 0);
            tlpPaymentStatistics.Dock = DockStyle.Fill;
            tlpPaymentStatistics.Location = new Point(32, 100);
            tlpPaymentStatistics.Margin = new Padding(0, 0, 0, 15);
            tlpPaymentStatistics.Name = "tlpPaymentStatistics";
            tlpPaymentStatistics.RowCount = 1;
            tlpPaymentStatistics.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpPaymentStatistics.Size = new Size(1227, 85);
            tlpPaymentStatistics.TabIndex = 1;
            // 
            // pnlCollectedToday
            // 
            pnlCollectedToday.BorderStyle = BorderStyle.FixedSingle;
            pnlCollectedToday.Controls.Add(tlpCollectedToday);
            pnlCollectedToday.Dock = DockStyle.Fill;
            pnlCollectedToday.Location = new Point(0, 0);
            pnlCollectedToday.Margin = new Padding(0, 0, 8, 0);
            pnlCollectedToday.Name = "pnlCollectedToday";
            pnlCollectedToday.Padding = new Padding(20, 10, 15, 10);
            pnlCollectedToday.Size = new Size(401, 85);
            pnlCollectedToday.TabIndex = 0;
            // 
            // tlpCollectedToday
            // 
            tlpCollectedToday.BackColor = Color.White;
            tlpCollectedToday.ColumnCount = 1;
            tlpCollectedToday.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpCollectedToday.Controls.Add(lblCollectedTodayTitle, 0, 0);
            tlpCollectedToday.Controls.Add(lblCollectedTodayAmount, 0, 1);
            tlpCollectedToday.Dock = DockStyle.Fill;
            tlpCollectedToday.Location = new Point(20, 10);
            tlpCollectedToday.Name = "tlpCollectedToday";
            tlpCollectedToday.RowCount = 2;
            tlpCollectedToday.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tlpCollectedToday.RowStyles.Add(new RowStyle(SizeType.Percent, 65F));
            tlpCollectedToday.Size = new Size(364, 63);
            tlpCollectedToday.TabIndex = 0;
            // 
            // lblCollectedTodayTitle
            // 
            lblCollectedTodayTitle.AutoSize = true;
            lblCollectedTodayTitle.Dock = DockStyle.Fill;
            lblCollectedTodayTitle.ForeColor = Color.FromArgb(85, 100, 120);
            lblCollectedTodayTitle.Location = new Point(3, 0);
            lblCollectedTodayTitle.Name = "lblCollectedTodayTitle";
            lblCollectedTodayTitle.Size = new Size(358, 22);
            lblCollectedTodayTitle.TabIndex = 0;
            lblCollectedTodayTitle.Text = "Collected today";
            // 
            // lblCollectedTodayAmount
            // 
            lblCollectedTodayAmount.AutoSize = true;
            lblCollectedTodayAmount.Dock = DockStyle.Fill;
            lblCollectedTodayAmount.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCollectedTodayAmount.ForeColor = Color.FromArgb(25, 45, 68);
            lblCollectedTodayAmount.Location = new Point(3, 22);
            lblCollectedTodayAmount.Name = "lblCollectedTodayAmount";
            lblCollectedTodayAmount.Size = new Size(358, 41);
            lblCollectedTodayAmount.TabIndex = 1;
            lblCollectedTodayAmount.Text = "GHS 6,840.00";
            // 
            // pnlCollectedMonth
            // 
            pnlCollectedMonth.BackColor = Color.White;
            pnlCollectedMonth.BorderStyle = BorderStyle.FixedSingle;
            pnlCollectedMonth.Controls.Add(tlpCollectedMonth);
            pnlCollectedMonth.Dock = DockStyle.Fill;
            pnlCollectedMonth.Location = new Point(417, 0);
            pnlCollectedMonth.Margin = new Padding(8, 0, 8, 0);
            pnlCollectedMonth.Name = "pnlCollectedMonth";
            pnlCollectedMonth.Padding = new Padding(20, 10, 15, 10);
            pnlCollectedMonth.Size = new Size(393, 85);
            pnlCollectedMonth.TabIndex = 1;
            // 
            // tlpCollectedMonth
            // 
            tlpCollectedMonth.ColumnCount = 1;
            tlpCollectedMonth.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpCollectedMonth.Controls.Add(lblCollectedMonthTitle, 0, 0);
            tlpCollectedMonth.Controls.Add(lblCollectedMonthAmount, 0, 1);
            tlpCollectedMonth.Dock = DockStyle.Fill;
            tlpCollectedMonth.Location = new Point(20, 10);
            tlpCollectedMonth.Name = "tlpCollectedMonth";
            tlpCollectedMonth.RowCount = 2;
            tlpCollectedMonth.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tlpCollectedMonth.RowStyles.Add(new RowStyle(SizeType.Percent, 65F));
            tlpCollectedMonth.Size = new Size(356, 63);
            tlpCollectedMonth.TabIndex = 0;
            // 
            // lblCollectedMonthTitle
            // 
            lblCollectedMonthTitle.AutoSize = true;
            lblCollectedMonthTitle.Dock = DockStyle.Fill;
            lblCollectedMonthTitle.Font = new Font("Segoe UI", 8.5F);
            lblCollectedMonthTitle.ForeColor = Color.FromArgb(85, 100, 120);
            lblCollectedMonthTitle.Location = new Point(3, 0);
            lblCollectedMonthTitle.Name = "lblCollectedMonthTitle";
            lblCollectedMonthTitle.Size = new Size(350, 22);
            lblCollectedMonthTitle.TabIndex = 0;
            lblCollectedMonthTitle.Text = "Collected this month";
            // 
            // lblCollectedMonthAmount
            // 
            lblCollectedMonthAmount.AutoSize = true;
            lblCollectedMonthAmount.Dock = DockStyle.Fill;
            lblCollectedMonthAmount.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCollectedMonthAmount.Location = new Point(3, 22);
            lblCollectedMonthAmount.Name = "lblCollectedMonthAmount";
            lblCollectedMonthAmount.Size = new Size(350, 41);
            lblCollectedMonthAmount.TabIndex = 1;
            lblCollectedMonthAmount.Text = "GHS 98,215.50";
            // 
            // pnlOutstandingBalances
            // 
            pnlOutstandingBalances.BackColor = Color.White;
            pnlOutstandingBalances.BorderStyle = BorderStyle.FixedSingle;
            pnlOutstandingBalances.Controls.Add(tlpOutstandingBalances);
            pnlOutstandingBalances.Dock = DockStyle.Fill;
            pnlOutstandingBalances.Location = new Point(826, 0);
            pnlOutstandingBalances.Margin = new Padding(8, 0, 0, 0);
            pnlOutstandingBalances.Name = "pnlOutstandingBalances";
            pnlOutstandingBalances.Padding = new Padding(20, 10, 15, 10);
            pnlOutstandingBalances.Size = new Size(401, 85);
            pnlOutstandingBalances.TabIndex = 2;
            // 
            // tlpOutstandingBalances
            // 
            tlpOutstandingBalances.ColumnCount = 1;
            tlpOutstandingBalances.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpOutstandingBalances.Controls.Add(lblOutstandingBalancesTitle, 0, 0);
            tlpOutstandingBalances.Controls.Add(lblOutstandingBalancesAmount, 0, 1);
            tlpOutstandingBalances.Dock = DockStyle.Fill;
            tlpOutstandingBalances.Location = new Point(20, 10);
            tlpOutstandingBalances.Name = "tlpOutstandingBalances";
            tlpOutstandingBalances.RowCount = 2;
            tlpOutstandingBalances.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tlpOutstandingBalances.RowStyles.Add(new RowStyle(SizeType.Percent, 65F));
            tlpOutstandingBalances.Size = new Size(364, 63);
            tlpOutstandingBalances.TabIndex = 0;
            // 
            // lblOutstandingBalancesTitle
            // 
            lblOutstandingBalancesTitle.AutoSize = true;
            lblOutstandingBalancesTitle.Dock = DockStyle.Fill;
            lblOutstandingBalancesTitle.Font = new Font("Segoe UI", 8.5F);
            lblOutstandingBalancesTitle.ForeColor = Color.FromArgb(85, 100, 120);
            lblOutstandingBalancesTitle.Location = new Point(3, 0);
            lblOutstandingBalancesTitle.Name = "lblOutstandingBalancesTitle";
            lblOutstandingBalancesTitle.Size = new Size(358, 22);
            lblOutstandingBalancesTitle.TabIndex = 0;
            lblOutstandingBalancesTitle.Text = "Outstanding balances";
            // 
            // lblOutstandingBalancesAmount
            // 
            lblOutstandingBalancesAmount.AutoSize = true;
            lblOutstandingBalancesAmount.Dock = DockStyle.Fill;
            lblOutstandingBalancesAmount.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOutstandingBalancesAmount.ForeColor = Color.FromArgb(175, 53, 45);
            lblOutstandingBalancesAmount.Location = new Point(3, 22);
            lblOutstandingBalancesAmount.Name = "lblOutstandingBalancesAmount";
            lblOutstandingBalancesAmount.Size = new Size(358, 41);
            lblOutstandingBalancesAmount.TabIndex = 1;
            lblOutstandingBalancesAmount.Text = "GHS 11,430.00";
            // 
            // tlpPaymentsContent
            // 
            tlpPaymentsContent.ColumnCount = 2;
            tlpPaymentsContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36F));
            tlpPaymentsContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64F));
            tlpPaymentsContent.Controls.Add(pnlRecordPayment, 0, 0);
            tlpPaymentsContent.Controls.Add(pnlPaymentHistory, 1, 0);
            tlpPaymentsContent.Dock = DockStyle.Fill;
            tlpPaymentsContent.Location = new Point(32, 200);
            tlpPaymentsContent.Margin = new Padding(0);
            tlpPaymentsContent.Name = "tlpPaymentsContent";
            tlpPaymentsContent.RowCount = 1;
            tlpPaymentsContent.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpPaymentsContent.Size = new Size(1227, 561);
            tlpPaymentsContent.TabIndex = 2;
            // 
            // pnlRecordPayment
            // 
            pnlRecordPayment.BackColor = Color.White;
            pnlRecordPayment.BorderStyle = BorderStyle.FixedSingle;
            pnlRecordPayment.Controls.Add(tlpRecordPayment);
            pnlRecordPayment.Dock = DockStyle.Fill;
            pnlRecordPayment.Location = new Point(0, 0);
            pnlRecordPayment.Margin = new Padding(0, 0, 10, 0);
            pnlRecordPayment.Name = "pnlRecordPayment";
            pnlRecordPayment.Padding = new Padding(20, 15, 20, 15);
            pnlRecordPayment.Size = new Size(431, 561);
            pnlRecordPayment.TabIndex = 0;
            // 
            // tlpRecordPayment
            // 
            tlpRecordPayment.ColumnCount = 1;
            tlpRecordPayment.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpRecordPayment.Controls.Add(lblRecordPaymentTitle, 0, 0);
            tlpRecordPayment.Controls.Add(tlpPaymentBooking, 0, 1);
            tlpRecordPayment.Controls.Add(pnlPaymentBillSummary, 0, 2);
            tlpRecordPayment.Controls.Add(tlpPaymentAmount, 0, 3);
            tlpRecordPayment.Controls.Add(tlpPaymentMethod, 0, 4);
            tlpRecordPayment.Controls.Add(tlpPaymentReference, 0, 5);
            tlpRecordPayment.Controls.Add(tlpPaymentActions, 0, 6);
            tlpRecordPayment.Dock = DockStyle.Fill;
            tlpRecordPayment.Location = new Point(20, 15);
            tlpRecordPayment.Margin = new Padding(0);
            tlpRecordPayment.Name = "tlpRecordPayment";
            tlpRecordPayment.RowCount = 7;
            tlpRecordPayment.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpRecordPayment.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tlpRecordPayment.RowStyles.Add(new RowStyle(SizeType.Absolute, 105F));
            tlpRecordPayment.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            tlpRecordPayment.RowStyles.Add(new RowStyle(SizeType.Absolute, 125F));
            tlpRecordPayment.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            tlpRecordPayment.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpRecordPayment.Size = new Size(389, 529);
            tlpRecordPayment.TabIndex = 0;
            // 
            // lblRecordPaymentTitle
            // 
            lblRecordPaymentTitle.AutoSize = true;
            lblRecordPaymentTitle.Dock = DockStyle.Fill;
            lblRecordPaymentTitle.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecordPaymentTitle.ForeColor = Color.FromArgb(25, 45, 68);
            lblRecordPaymentTitle.Location = new Point(3, 0);
            lblRecordPaymentTitle.Name = "lblRecordPaymentTitle";
            lblRecordPaymentTitle.Size = new Size(383, 20);
            lblRecordPaymentTitle.TabIndex = 0;
            lblRecordPaymentTitle.Text = "Record Payment";
            lblRecordPaymentTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tlpPaymentBooking
            // 
            tlpPaymentBooking.ColumnCount = 1;
            tlpPaymentBooking.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpPaymentBooking.Controls.Add(lblPaymentBooking, 0, 0);
            tlpPaymentBooking.Controls.Add(cmbPaymentBooking, 0, 1);
            tlpPaymentBooking.Dock = DockStyle.Fill;
            tlpPaymentBooking.Location = new Point(3, 23);
            tlpPaymentBooking.Name = "tlpPaymentBooking";
            tlpPaymentBooking.RowCount = 2;
            tlpPaymentBooking.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpPaymentBooking.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpPaymentBooking.Size = new Size(383, 46);
            tlpPaymentBooking.TabIndex = 1;
            // 
            // lblPaymentBooking
            // 
            lblPaymentBooking.AutoSize = true;
            lblPaymentBooking.Dock = DockStyle.Fill;
            lblPaymentBooking.Font = new Font("Segoe UI", 8.5F);
            lblPaymentBooking.ForeColor = Color.FromArgb(25, 45, 68);
            lblPaymentBooking.Location = new Point(3, 0);
            lblPaymentBooking.Name = "lblPaymentBooking";
            lblPaymentBooking.Size = new Size(377, 20);
            lblPaymentBooking.TabIndex = 0;
            lblPaymentBooking.Text = "Booking";
            // 
            // cmbPaymentBooking
            // 
            cmbPaymentBooking.Dock = DockStyle.Fill;
            cmbPaymentBooking.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPaymentBooking.FormattingEnabled = true;
            cmbPaymentBooking.Items.AddRange(new object[] { "BK-1042 · Olivia Bennett · Room 204" });
            cmbPaymentBooking.Location = new Point(0, 22);
            cmbPaymentBooking.Margin = new Padding(0, 2, 0, 2);
            cmbPaymentBooking.Name = "cmbPaymentBooking";
            cmbPaymentBooking.Size = new Size(383, 28);
            cmbPaymentBooking.TabIndex = 1;
            // 
            // pnlPaymentBillSummary
            // 
            pnlPaymentBillSummary.BackColor = Color.FromArgb(245, 242, 236);
            pnlPaymentBillSummary.Controls.Add(tlpPaymentBillSummary);
            pnlPaymentBillSummary.Dock = DockStyle.Fill;
            pnlPaymentBillSummary.Location = new Point(0, 77);
            pnlPaymentBillSummary.Margin = new Padding(0, 5, 0, 5);
            pnlPaymentBillSummary.Name = "pnlPaymentBillSummary";
            pnlPaymentBillSummary.Padding = new Padding(12, 7, 12, 7);
            pnlPaymentBillSummary.Size = new Size(389, 95);
            pnlPaymentBillSummary.TabIndex = 2;
            // 
            // tlpPaymentBillSummary
            // 
            tlpPaymentBillSummary.ColumnCount = 2;
            tlpPaymentBillSummary.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            tlpPaymentBillSummary.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tlpPaymentBillSummary.Controls.Add(lblPaymentTotalBill, 0, 0);
            tlpPaymentBillSummary.Controls.Add(lblPaymentTotalBillValue, 1, 0);
            tlpPaymentBillSummary.Controls.Add(lblPaymentPaidSoFar, 0, 1);
            tlpPaymentBillSummary.Controls.Add(label1, 1, 1);
            tlpPaymentBillSummary.Controls.Add(lblPaymentBalanceDue, 0, 2);
            tlpPaymentBillSummary.Controls.Add(lblPaymentBalanceDueValue, 1, 2);
            tlpPaymentBillSummary.Dock = DockStyle.Fill;
            tlpPaymentBillSummary.Location = new Point(12, 7);
            tlpPaymentBillSummary.Name = "tlpPaymentBillSummary";
            tlpPaymentBillSummary.RowCount = 3;
            tlpPaymentBillSummary.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tlpPaymentBillSummary.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tlpPaymentBillSummary.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tlpPaymentBillSummary.Size = new Size(365, 81);
            tlpPaymentBillSummary.TabIndex = 0;
            // 
            // lblPaymentTotalBill
            // 
            lblPaymentTotalBill.AutoSize = true;
            lblPaymentTotalBill.Dock = DockStyle.Fill;
            lblPaymentTotalBill.Font = new Font("Segoe UI", 8.5F);
            lblPaymentTotalBill.ForeColor = Color.FromArgb(105, 119, 139);
            lblPaymentTotalBill.Location = new Point(3, 0);
            lblPaymentTotalBill.Name = "lblPaymentTotalBill";
            lblPaymentTotalBill.Size = new Size(194, 27);
            lblPaymentTotalBill.TabIndex = 0;
            lblPaymentTotalBill.Text = "Total bill";
            // 
            // lblPaymentTotalBillValue
            // 
            lblPaymentTotalBillValue.AutoSize = true;
            lblPaymentTotalBillValue.Dock = DockStyle.Fill;
            lblPaymentTotalBillValue.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblPaymentTotalBillValue.ForeColor = Color.FromArgb(25, 45, 68);
            lblPaymentTotalBillValue.Location = new Point(203, 0);
            lblPaymentTotalBillValue.Name = "lblPaymentTotalBillValue";
            lblPaymentTotalBillValue.Size = new Size(159, 27);
            lblPaymentTotalBillValue.TabIndex = 1;
            lblPaymentTotalBillValue.Text = "GHS 2,242.50";
            lblPaymentTotalBillValue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblPaymentPaidSoFar
            // 
            lblPaymentPaidSoFar.AutoSize = true;
            lblPaymentPaidSoFar.Dock = DockStyle.Fill;
            lblPaymentPaidSoFar.Font = new Font("Segoe UI", 8.5F);
            lblPaymentPaidSoFar.ForeColor = Color.FromArgb(105, 119, 139);
            lblPaymentPaidSoFar.Location = new Point(3, 27);
            lblPaymentPaidSoFar.Name = "lblPaymentPaidSoFar";
            lblPaymentPaidSoFar.Size = new Size(194, 27);
            lblPaymentPaidSoFar.TabIndex = 2;
            lblPaymentPaidSoFar.Text = "Paid so far";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(31, 112, 83);
            label1.Location = new Point(203, 27);
            label1.Name = "label1";
            label1.Size = new Size(159, 27);
            label1.TabIndex = 3;
            label1.Text = "GHS 1,000.00";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblPaymentBalanceDue
            // 
            lblPaymentBalanceDue.AutoSize = true;
            lblPaymentBalanceDue.Dock = DockStyle.Fill;
            lblPaymentBalanceDue.Font = new Font("Segoe UI", 8.5F);
            lblPaymentBalanceDue.ForeColor = Color.FromArgb(105, 119, 139);
            lblPaymentBalanceDue.Location = new Point(3, 54);
            lblPaymentBalanceDue.Name = "lblPaymentBalanceDue";
            lblPaymentBalanceDue.Size = new Size(194, 27);
            lblPaymentBalanceDue.TabIndex = 4;
            lblPaymentBalanceDue.Text = "Balance due";
            // 
            // lblPaymentBalanceDueValue
            // 
            lblPaymentBalanceDueValue.AutoSize = true;
            lblPaymentBalanceDueValue.Dock = DockStyle.Fill;
            lblPaymentBalanceDueValue.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPaymentBalanceDueValue.ForeColor = Color.FromArgb(175, 53, 45);
            lblPaymentBalanceDueValue.Location = new Point(203, 54);
            lblPaymentBalanceDueValue.Name = "lblPaymentBalanceDueValue";
            lblPaymentBalanceDueValue.Size = new Size(159, 27);
            lblPaymentBalanceDueValue.TabIndex = 5;
            lblPaymentBalanceDueValue.Text = "GHS 1,242.50";
            lblPaymentBalanceDueValue.TextAlign = ContentAlignment.MiddleRight;
            lblPaymentBalanceDueValue.Visible = false;
            // 
            // tlpPaymentAmount
            // 
            tlpPaymentAmount.ColumnCount = 1;
            tlpPaymentAmount.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpPaymentAmount.Controls.Add(lblPaymentAmount, 0, 0);
            tlpPaymentAmount.Controls.Add(textBox1, 0, 1);
            tlpPaymentAmount.Dock = DockStyle.Fill;
            tlpPaymentAmount.Location = new Point(3, 180);
            tlpPaymentAmount.Name = "tlpPaymentAmount";
            tlpPaymentAmount.RowCount = 2;
            tlpPaymentAmount.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            tlpPaymentAmount.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpPaymentAmount.Size = new Size(383, 59);
            tlpPaymentAmount.TabIndex = 3;
            // 
            // lblPaymentAmount
            // 
            lblPaymentAmount.AutoSize = true;
            lblPaymentAmount.Dock = DockStyle.Fill;
            lblPaymentAmount.Font = new Font("Segoe UI", 8.5F);
            lblPaymentAmount.ForeColor = Color.FromArgb(25, 45, 68);
            lblPaymentAmount.Location = new Point(3, 0);
            lblPaymentAmount.Name = "lblPaymentAmount";
            lblPaymentAmount.Size = new Size(377, 22);
            lblPaymentAmount.TabIndex = 0;
            lblPaymentAmount.Text = "Amount (GHS)";
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(0, 24);
            textBox1.Margin = new Padding(0, 2, 0, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(383, 31);
            textBox1.TabIndex = 1;
            textBox1.Text = "1,242.50";
            // 
            // tlpPaymentMethod
            // 
            tlpPaymentMethod.ColumnCount = 1;
            tlpPaymentMethod.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpPaymentMethod.Controls.Add(lblPaymentMethod, 0, 0);
            tlpPaymentMethod.Controls.Add(tlpPaymentMethodButtons, 0, 1);
            tlpPaymentMethod.Dock = DockStyle.Fill;
            tlpPaymentMethod.Location = new Point(0, 242);
            tlpPaymentMethod.Margin = new Padding(0);
            tlpPaymentMethod.Name = "tlpPaymentMethod";
            tlpPaymentMethod.RowCount = 2;
            tlpPaymentMethod.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tlpPaymentMethod.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpPaymentMethod.Size = new Size(389, 125);
            tlpPaymentMethod.TabIndex = 4;
            // 
            // lblPaymentMethod
            // 
            lblPaymentMethod.AutoSize = true;
            lblPaymentMethod.Dock = DockStyle.Fill;
            lblPaymentMethod.Font = new Font("Segoe UI", 8.5F);
            lblPaymentMethod.ForeColor = Color.FromArgb(25, 45, 68);
            lblPaymentMethod.Location = new Point(3, 0);
            lblPaymentMethod.Name = "lblPaymentMethod";
            lblPaymentMethod.Size = new Size(383, 25);
            lblPaymentMethod.TabIndex = 0;
            lblPaymentMethod.Text = "Payment method";
            // 
            // tlpPaymentMethodButtons
            // 
            tlpPaymentMethodButtons.ColumnCount = 2;
            tlpPaymentMethodButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpPaymentMethodButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpPaymentMethodButtons.Controls.Add(btnMethodBankTransfer, 1, 1);
            tlpPaymentMethodButtons.Controls.Add(btnMethodMobileMoney, 0, 1);
            tlpPaymentMethodButtons.Controls.Add(btnMethodCard, 1, 0);
            tlpPaymentMethodButtons.Controls.Add(btnMethodCash, 0, 0);
            tlpPaymentMethodButtons.Dock = DockStyle.Fill;
            tlpPaymentMethodButtons.Location = new Point(0, 25);
            tlpPaymentMethodButtons.Margin = new Padding(0);
            tlpPaymentMethodButtons.Name = "tlpPaymentMethodButtons";
            tlpPaymentMethodButtons.RowCount = 2;
            tlpPaymentMethodButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpPaymentMethodButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpPaymentMethodButtons.Size = new Size(389, 100);
            tlpPaymentMethodButtons.TabIndex = 1;
            // 
            // btnMethodBankTransfer
            // 
            btnMethodBankTransfer.Dock = DockStyle.Fill;
            btnMethodBankTransfer.FlatAppearance.BorderColor = Color.FromArgb(210, 216, 224);
            btnMethodBankTransfer.FlatStyle = FlatStyle.Flat;
            btnMethodBankTransfer.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold);
            btnMethodBankTransfer.ForeColor = Color.FromArgb(25, 45, 68);
            btnMethodBankTransfer.Location = new Point(194, 52);
            btnMethodBankTransfer.Margin = new Padding(0, 2, 0, 2);
            btnMethodBankTransfer.Name = "btnMethodBankTransfer";
            btnMethodBankTransfer.Size = new Size(195, 46);
            btnMethodBankTransfer.TabIndex = 3;
            btnMethodBankTransfer.Text = "Bank Transfer";
            btnMethodBankTransfer.UseVisualStyleBackColor = true;
            // 
            // btnMethodMobileMoney
            // 
            btnMethodMobileMoney.Dock = DockStyle.Fill;
            btnMethodMobileMoney.FlatStyle = FlatStyle.Flat;
            btnMethodMobileMoney.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold);
            btnMethodMobileMoney.ForeColor = Color.FromArgb(25, 45, 68);
            btnMethodMobileMoney.Location = new Point(0, 52);
            btnMethodMobileMoney.Margin = new Padding(0, 2, 8, 2);
            btnMethodMobileMoney.Name = "btnMethodMobileMoney";
            btnMethodMobileMoney.Size = new Size(186, 46);
            btnMethodMobileMoney.TabIndex = 2;
            btnMethodMobileMoney.Text = "Mobile Money";
            btnMethodMobileMoney.UseVisualStyleBackColor = true;
            // 
            // btnMethodCard
            // 
            btnMethodCard.Dock = DockStyle.Fill;
            btnMethodCard.FlatAppearance.BorderColor = Color.FromArgb(210, 216, 224);
            btnMethodCard.FlatStyle = FlatStyle.Flat;
            btnMethodCard.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold);
            btnMethodCard.ForeColor = Color.FromArgb(25, 45, 68);
            btnMethodCard.Location = new Point(194, 2);
            btnMethodCard.Margin = new Padding(0, 2, 0, 2);
            btnMethodCard.Name = "btnMethodCard";
            btnMethodCard.Size = new Size(195, 46);
            btnMethodCard.TabIndex = 1;
            btnMethodCard.Text = "Card";
            btnMethodCard.UseVisualStyleBackColor = true;
            // 
            // btnMethodCash
            // 
            btnMethodCash.BackColor = Color.FromArgb(20, 43, 70);
            btnMethodCash.Dock = DockStyle.Fill;
            btnMethodCash.FlatAppearance.BorderSize = 0;
            btnMethodCash.FlatStyle = FlatStyle.Flat;
            btnMethodCash.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold);
            btnMethodCash.ForeColor = Color.White;
            btnMethodCash.Location = new Point(0, 2);
            btnMethodCash.Margin = new Padding(0, 2, 8, 2);
            btnMethodCash.Name = "btnMethodCash";
            btnMethodCash.Size = new Size(186, 46);
            btnMethodCash.TabIndex = 0;
            btnMethodCash.Text = "Cash";
            btnMethodCash.UseVisualStyleBackColor = false;
            // 
            // tlpPaymentReference
            // 
            tlpPaymentReference.ColumnCount = 1;
            tlpPaymentReference.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpPaymentReference.Controls.Add(lblPaymentReference, 0, 0);
            tlpPaymentReference.Controls.Add(txtPaymentReference, 0, 1);
            tlpPaymentReference.Dock = DockStyle.Fill;
            tlpPaymentReference.Location = new Point(3, 370);
            tlpPaymentReference.Name = "tlpPaymentReference";
            tlpPaymentReference.RowCount = 2;
            tlpPaymentReference.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpPaymentReference.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpPaymentReference.Size = new Size(383, 59);
            tlpPaymentReference.TabIndex = 5;
            // 
            // lblPaymentReference
            // 
            lblPaymentReference.AutoSize = true;
            lblPaymentReference.Dock = DockStyle.Fill;
            lblPaymentReference.Font = new Font("Segoe UI", 8.5F);
            lblPaymentReference.ForeColor = Color.FromArgb(25, 45, 68);
            lblPaymentReference.Location = new Point(3, 0);
            lblPaymentReference.Name = "lblPaymentReference";
            lblPaymentReference.Size = new Size(377, 20);
            lblPaymentReference.TabIndex = 0;
            lblPaymentReference.Text = "Reference";
            // 
            // txtPaymentReference
            // 
            txtPaymentReference.Dock = DockStyle.Fill;
            txtPaymentReference.Location = new Point(0, 22);
            txtPaymentReference.Margin = new Padding(0, 2, 0, 2);
            txtPaymentReference.Name = "txtPaymentReference";
            txtPaymentReference.Size = new Size(383, 27);
            txtPaymentReference.TabIndex = 1;
            txtPaymentReference.Text = "MM-88421907";
            // 
            // tlpPaymentActions
            // 
            tlpPaymentActions.ColumnCount = 2;
            tlpPaymentActions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tlpPaymentActions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tlpPaymentActions.Controls.Add(btnSavePayment, 0, 0);
            tlpPaymentActions.Controls.Add(btnPrintReceipt, 1, 0);
            tlpPaymentActions.Dock = DockStyle.Bottom;
            tlpPaymentActions.Location = new Point(0, 481);
            tlpPaymentActions.Margin = new Padding(0);
            tlpPaymentActions.Name = "tlpPaymentActions";
            tlpPaymentActions.RowCount = 1;
            tlpPaymentActions.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpPaymentActions.Size = new Size(389, 48);
            tlpPaymentActions.TabIndex = 6;
            // 
            // btnSavePayment
            // 
            btnSavePayment.BackColor = Color.FromArgb(31, 105, 75);
            btnSavePayment.Dock = DockStyle.Fill;
            btnSavePayment.FlatAppearance.BorderSize = 0;
            btnSavePayment.FlatStyle = FlatStyle.Flat;
            btnSavePayment.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSavePayment.ForeColor = Color.White;
            btnSavePayment.Location = new Point(0, 2);
            btnSavePayment.Margin = new Padding(0, 2, 8, 0);
            btnSavePayment.Name = "btnSavePayment";
            btnSavePayment.Size = new Size(244, 46);
            btnSavePayment.TabIndex = 0;
            btnSavePayment.Text = "Save Payment";
            btnSavePayment.UseVisualStyleBackColor = false;
            // 
            // btnPrintReceipt
            // 
            btnPrintReceipt.Dock = DockStyle.Fill;
            btnPrintReceipt.FlatAppearance.BorderColor = Color.FromArgb(210, 216, 224);
            btnPrintReceipt.FlatAppearance.BorderSize = 0;
            btnPrintReceipt.FlatStyle = FlatStyle.Flat;
            btnPrintReceipt.Font = new Font("Segoe UI", 8.5F);
            btnPrintReceipt.ForeColor = Color.FromArgb(25, 45, 68);
            btnPrintReceipt.Location = new Point(252, 2);
            btnPrintReceipt.Margin = new Padding(0, 2, 0, 0);
            btnPrintReceipt.Name = "btnPrintReceipt";
            btnPrintReceipt.Size = new Size(137, 46);
            btnPrintReceipt.TabIndex = 1;
            btnPrintReceipt.Text = "Print Receipt";
            btnPrintReceipt.UseVisualStyleBackColor = true;
            // 
            // pnlPaymentHistory
            // 
            pnlPaymentHistory.BackColor = Color.White;
            pnlPaymentHistory.BorderStyle = BorderStyle.FixedSingle;
            pnlPaymentHistory.Controls.Add(tlpPaymentHistory);
            pnlPaymentHistory.Dock = DockStyle.Fill;
            pnlPaymentHistory.Location = new Point(451, 0);
            pnlPaymentHistory.Margin = new Padding(10, 0, 0, 0);
            pnlPaymentHistory.Name = "pnlPaymentHistory";
            pnlPaymentHistory.Padding = new Padding(20, 15, 20, 15);
            pnlPaymentHistory.Size = new Size(776, 561);
            pnlPaymentHistory.TabIndex = 1;
            // 
            // tlpPaymentHistory
            // 
            tlpPaymentHistory.ColumnCount = 1;
            tlpPaymentHistory.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpPaymentHistory.Controls.Add(tableLayoutPanel1, 0, 0);
            tlpPaymentHistory.Controls.Add(dgvPaymentHistory, 0, 1);
            tlpPaymentHistory.Controls.Add(lblPaymentHistoryCount, 0, 2);
            tlpPaymentHistory.Dock = DockStyle.Fill;
            tlpPaymentHistory.Location = new Point(20, 15);
            tlpPaymentHistory.Margin = new Padding(0);
            tlpPaymentHistory.Name = "tlpPaymentHistory";
            tlpPaymentHistory.RowCount = 3;
            tlpPaymentHistory.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tlpPaymentHistory.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpPaymentHistory.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tlpPaymentHistory.Size = new Size(734, 529);
            tlpPaymentHistory.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tableLayoutPanel1.Controls.Add(lblPaymentHistoryTitle, 0, 0);
            tableLayoutPanel1.Controls.Add(pnlPaymentHistorySearch, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(734, 52);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblPaymentHistoryTitle
            // 
            lblPaymentHistoryTitle.AutoSize = true;
            lblPaymentHistoryTitle.Dock = DockStyle.Fill;
            lblPaymentHistoryTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPaymentHistoryTitle.ForeColor = Color.FromArgb(25, 45, 68);
            lblPaymentHistoryTitle.Location = new Point(3, 0);
            lblPaymentHistoryTitle.Name = "lblPaymentHistoryTitle";
            lblPaymentHistoryTitle.Size = new Size(397, 52);
            lblPaymentHistoryTitle.TabIndex = 0;
            lblPaymentHistoryTitle.Text = "Payment History";
            lblPaymentHistoryTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlPaymentHistorySearch
            // 
            pnlPaymentHistorySearch.BorderStyle = BorderStyle.FixedSingle;
            pnlPaymentHistorySearch.Controls.Add(tlpPaymentHistorySearch);
            pnlPaymentHistorySearch.Dock = DockStyle.Fill;
            pnlPaymentHistorySearch.Location = new Point(403, 3);
            pnlPaymentHistorySearch.Margin = new Padding(0, 3, 0, 5);
            pnlPaymentHistorySearch.Name = "pnlPaymentHistorySearch";
            pnlPaymentHistorySearch.Padding = new Padding(5, 2, 5, 2);
            pnlPaymentHistorySearch.Size = new Size(331, 44);
            pnlPaymentHistorySearch.TabIndex = 1;
            // 
            // tlpPaymentHistorySearch
            // 
            tlpPaymentHistorySearch.ColumnCount = 2;
            tlpPaymentHistorySearch.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 28F));
            tlpPaymentHistorySearch.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpPaymentHistorySearch.Controls.Add(lblPaymentSearchIcon, 0, 0);
            tlpPaymentHistorySearch.Controls.Add(txtPaymentSearch, 1, 0);
            tlpPaymentHistorySearch.Dock = DockStyle.Fill;
            tlpPaymentHistorySearch.Location = new Point(5, 2);
            tlpPaymentHistorySearch.Name = "tlpPaymentHistorySearch";
            tlpPaymentHistorySearch.RowCount = 1;
            tlpPaymentHistorySearch.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpPaymentHistorySearch.Size = new Size(319, 38);
            tlpPaymentHistorySearch.TabIndex = 0;
            // 
            // lblPaymentSearchIcon
            // 
            lblPaymentSearchIcon.AutoSize = true;
            lblPaymentSearchIcon.Dock = DockStyle.Fill;
            lblPaymentSearchIcon.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPaymentSearchIcon.ForeColor = Color.FromArgb(105, 119, 139);
            lblPaymentSearchIcon.Location = new Point(3, 0);
            lblPaymentSearchIcon.Name = "lblPaymentSearchIcon";
            lblPaymentSearchIcon.Size = new Size(22, 38);
            lblPaymentSearchIcon.TabIndex = 0;
            lblPaymentSearchIcon.Text = "⌕";
            lblPaymentSearchIcon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPaymentSearch
            // 
            txtPaymentSearch.BorderStyle = BorderStyle.None;
            txtPaymentSearch.Dock = DockStyle.Fill;
            txtPaymentSearch.Location = new Point(28, 0);
            txtPaymentSearch.Margin = new Padding(0);
            txtPaymentSearch.Name = "txtPaymentSearch";
            txtPaymentSearch.PlaceholderText = "Search payments";
            txtPaymentSearch.Size = new Size(291, 20);
            txtPaymentSearch.TabIndex = 1;
            // 
            // dgvPaymentHistory
            // 
            dgvPaymentHistory.AllowUserToAddRows = false;
            dgvPaymentHistory.AllowUserToDeleteRows = false;
            dgvPaymentHistory.AllowUserToResizeRows = false;
            dgvPaymentHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPaymentHistory.BackgroundColor = Color.White;
            dgvPaymentHistory.BorderStyle = BorderStyle.None;
            dgvPaymentHistory.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(245, 242, 236);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(85, 100, 120);
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvPaymentHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvPaymentHistory.ColumnHeadersHeight = 32;
            dgvPaymentHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvPaymentHistory.ColumnHeadersVisible = false;
            dgvPaymentHistory.Columns.AddRange(new DataGridViewColumn[] { colReceiptNumber, colPaymentGuest, colPaymentBooking, colPaymentMethod, colPaymentAmount, colPaymentDate });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(25, 45, 68);
            dataGridViewCellStyle6.Padding = new Padding(6, 0, 6, 0);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(250, 242, 222);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(25, 45, 68);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvPaymentHistory.DefaultCellStyle = dataGridViewCellStyle6;
            dgvPaymentHistory.Dock = DockStyle.Fill;
            dgvPaymentHistory.EnableHeadersVisualStyles = false;
            dgvPaymentHistory.GridColor = Color.FromArgb(235, 230, 220);
            dgvPaymentHistory.Location = new Point(3, 55);
            dgvPaymentHistory.MultiSelect = false;
            dgvPaymentHistory.Name = "dgvPaymentHistory";
            dgvPaymentHistory.ReadOnly = true;
            dgvPaymentHistory.RowHeadersVisible = false;
            dgvPaymentHistory.RowHeadersWidth = 51;
            dgvPaymentHistory.RowTemplate.Height = 41;
            dgvPaymentHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPaymentHistory.Size = new Size(728, 446);
            dgvPaymentHistory.TabIndex = 1;
            // 
            // colReceiptNumber
            // 
            colReceiptNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colReceiptNumber.FillWeight = 90F;
            colReceiptNumber.HeaderText = "RECEIPT";
            colReceiptNumber.MinimumWidth = 6;
            colReceiptNumber.Name = "colReceiptNumber";
            colReceiptNumber.ReadOnly = true;
            // 
            // colPaymentGuest
            // 
            colPaymentGuest.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colPaymentGuest.FillWeight = 65F;
            colPaymentGuest.HeaderText = "GUEST";
            colPaymentGuest.MinimumWidth = 6;
            colPaymentGuest.Name = "colPaymentGuest";
            colPaymentGuest.ReadOnly = true;
            // 
            // colPaymentBooking
            // 
            colPaymentBooking.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colPaymentBooking.FillWeight = 95F;
            colPaymentBooking.HeaderText = "BOOKING";
            colPaymentBooking.MinimumWidth = 6;
            colPaymentBooking.Name = "colPaymentBooking";
            colPaymentBooking.ReadOnly = true;
            // 
            // colPaymentMethod
            // 
            colPaymentMethod.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colPaymentMethod.FillWeight = 120F;
            colPaymentMethod.HeaderText = "METHOD";
            colPaymentMethod.MinimumWidth = 6;
            colPaymentMethod.Name = "colPaymentMethod";
            colPaymentMethod.ReadOnly = true;
            // 
            // colPaymentAmount
            // 
            colPaymentAmount.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            colPaymentAmount.DefaultCellStyle = dataGridViewCellStyle5;
            colPaymentAmount.FillWeight = 110F;
            colPaymentAmount.HeaderText = "AMOUNT (GHS)";
            colPaymentAmount.MinimumWidth = 6;
            colPaymentAmount.Name = "colPaymentAmount";
            colPaymentAmount.ReadOnly = true;
            // 
            // colPaymentDate
            // 
            colPaymentDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colPaymentDate.FillWeight = 75F;
            colPaymentDate.HeaderText = "DATE";
            colPaymentDate.MinimumWidth = 6;
            colPaymentDate.Name = "colPaymentDate";
            colPaymentDate.ReadOnly = true;
            // 
            // lblPaymentHistoryCount
            // 
            lblPaymentHistoryCount.AutoSize = true;
            lblPaymentHistoryCount.Dock = DockStyle.Fill;
            lblPaymentHistoryCount.Font = new Font("Segoe UI", 8.5F);
            lblPaymentHistoryCount.ForeColor = Color.FromArgb(105, 119, 139);
            lblPaymentHistoryCount.ImageAlign = ContentAlignment.MiddleLeft;
            lblPaymentHistoryCount.Location = new Point(3, 504);
            lblPaymentHistoryCount.Name = "lblPaymentHistoryCount";
            lblPaymentHistoryCount.Size = new Size(728, 25);
            lblPaymentHistoryCount.TabIndex = 2;
            lblPaymentHistoryCount.Text = "Showing 10 of 86 payments";
            // 
            // ucPayments
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(245, 242, 236);
            Controls.Add(tlpPaymentsMain);
            Margin = new Padding(0);
            Name = "ucPayments";
            Size = new Size(1291, 786);
            Load += ucPayments_Load;
            tlpPaymentsMain.ResumeLayout(false);
            pnlPaymentsHeader.ResumeLayout(false);
            tlpPaymentsHeader.ResumeLayout(false);
            tlpPaymentsHeader.PerformLayout();
            tlpPaymentStatistics.ResumeLayout(false);
            pnlCollectedToday.ResumeLayout(false);
            tlpCollectedToday.ResumeLayout(false);
            tlpCollectedToday.PerformLayout();
            pnlCollectedMonth.ResumeLayout(false);
            tlpCollectedMonth.ResumeLayout(false);
            tlpCollectedMonth.PerformLayout();
            pnlOutstandingBalances.ResumeLayout(false);
            tlpOutstandingBalances.ResumeLayout(false);
            tlpOutstandingBalances.PerformLayout();
            tlpPaymentsContent.ResumeLayout(false);
            pnlRecordPayment.ResumeLayout(false);
            tlpRecordPayment.ResumeLayout(false);
            tlpRecordPayment.PerformLayout();
            tlpPaymentBooking.ResumeLayout(false);
            tlpPaymentBooking.PerformLayout();
            pnlPaymentBillSummary.ResumeLayout(false);
            tlpPaymentBillSummary.ResumeLayout(false);
            tlpPaymentBillSummary.PerformLayout();
            tlpPaymentAmount.ResumeLayout(false);
            tlpPaymentAmount.PerformLayout();
            tlpPaymentMethod.ResumeLayout(false);
            tlpPaymentMethod.PerformLayout();
            tlpPaymentMethodButtons.ResumeLayout(false);
            tlpPaymentReference.ResumeLayout(false);
            tlpPaymentReference.PerformLayout();
            tlpPaymentActions.ResumeLayout(false);
            pnlPaymentHistory.ResumeLayout(false);
            tlpPaymentHistory.ResumeLayout(false);
            tlpPaymentHistory.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            pnlPaymentHistorySearch.ResumeLayout(false);
            tlpPaymentHistorySearch.ResumeLayout(false);
            tlpPaymentHistorySearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPaymentHistory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpPaymentsMain;
        private Panel pnlPaymentsHeader;
        private TableLayoutPanel tlpPaymentsHeader;
        private Label lblPaymentsTitle;
        private Label lblPaymentsSubtitle;
        private TableLayoutPanel tlpPaymentStatistics;
        private Panel pnlCollectedToday;
        private TableLayoutPanel tlpCollectedToday;
        private Label lblCollectedTodayTitle;
        private Label lblCollectedTodayAmount;
        private Panel pnlCollectedMonth;
        private TableLayoutPanel tlpCollectedMonth;
        private Label lblCollectedMonthTitle;
        private Label lblCollectedMonthAmount;
        private Panel pnlOutstandingBalances;
        private TableLayoutPanel tlpOutstandingBalances;
        private Label lblOutstandingBalancesTitle;
        private Label lblOutstandingBalancesAmount;
        private TableLayoutPanel tlpPaymentsContent;
        private Panel pnlRecordPayment;
        private TableLayoutPanel tlpRecordPayment;
        private Label lblRecordPaymentTitle;
        private TableLayoutPanel tlpPaymentBooking;
        private Label lblPaymentBooking;
        private ComboBox cmbPaymentBooking;
        private Panel pnlPaymentBillSummary;
        private TableLayoutPanel tlpPaymentBillSummary;
        private Label lblPaymentTotalBill;
        private Label lblPaymentTotalBillValue;
        private Label lblPaymentPaidSoFar;
        private Label label1;
        private Label lblPaymentBalanceDue;
        private Label lblPaymentBalanceDueValue;
        private TableLayoutPanel tlpPaymentAmount;
        private Label lblPaymentAmount;
        private TextBox textBox1;
        private TableLayoutPanel tlpPaymentMethod;
        private Label lblPaymentMethod;
        private TableLayoutPanel tlpPaymentMethodButtons;
        private Button btnMethodBankTransfer;
        private Button btnMethodMobileMoney;
        private Button btnMethodCard;
        private Button btnMethodCash;
        private TableLayoutPanel tlpPaymentReference;
        private Label lblPaymentReference;
        private TextBox txtPaymentReference;
        private TableLayoutPanel tlpPaymentActions;
        private Button btnSavePayment;
        private Button btnPrintReceipt;
        private Panel pnlPaymentHistory;
        private TableLayoutPanel tlpPaymentHistory;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblPaymentHistoryTitle;
        private Panel pnlPaymentHistorySearch;
        private TableLayoutPanel tlpPaymentHistorySearch;
        private Label lblPaymentSearchIcon;
        private TextBox txtPaymentSearch;
        private DataGridView dgvPaymentHistory;
        private DataGridViewTextBoxColumn colReceiptNumber;
        private DataGridViewTextBoxColumn colPaymentGuest;
        private DataGridViewTextBoxColumn colPaymentBooking;
        private DataGridViewTextBoxColumn colPaymentMethod;
        private DataGridViewTextBoxColumn colPaymentAmount;
        private DataGridViewTextBoxColumn colPaymentDate;
        private Label lblPaymentHistoryCount;
    }
}
