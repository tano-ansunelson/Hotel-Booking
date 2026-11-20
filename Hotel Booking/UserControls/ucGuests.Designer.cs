namespace Hotel_Booking.UserControls
{
    partial class ucGuests
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
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            tlpGuestsMain = new TableLayoutPanel();
            pnlGuestsHeader = new Panel();
            lblGuestsSubtitle = new Label();
            lblGuestsTitle = new Label();
            pnlGuestsContent = new Panel();
            tlpGuestsContent = new TableLayoutPanel();
            pnlGuestDetails = new Panel();
            btnClearGuest = new Button();
            btnDeleteGuest = new Button();
            btnUpdateGuest = new Button();
            btnAddGuest = new Button();
            txtAddress = new TextBox();
            lblAddress = new Label();
            cmbNationality = new ComboBox();
            lblNationality = new Label();
            txtIdNumber = new TextBox();
            lblIdNumber = new Label();
            cmbIdType = new ComboBox();
            lblIdType = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtPhoneNumber = new TextBox();
            lblPhoneNumber = new Label();
            txtLastName = new TextBox();
            lblLastName = new Label();
            textBox1 = new TextBox();
            lblFirstName = new Label();
            txtGuestId = new TextBox();
            lblGuestId = new Label();
            lblGuestDetailsTitle = new Label();
            pnlAllGuests = new Panel();
            lblGuestCount = new Label();
            dgvGuests = new DataGridView();
            colGuestID = new DataGridViewTextBoxColumn();
            colGuestName = new DataGridViewTextBoxColumn();
            colNationality = new DataGridViewTextBoxColumn();
            colStays = new DataGridViewTextBoxColumn();
            colPhone = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            txtSearchGuests = new TextBox();
            lblAllGuestsTitle = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            tlpGuestsMain.SuspendLayout();
            pnlGuestsHeader.SuspendLayout();
            pnlGuestsContent.SuspendLayout();
            tlpGuestsContent.SuspendLayout();
            pnlGuestDetails.SuspendLayout();
            pnlAllGuests.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGuests).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tlpGuestsMain
            // 
            tlpGuestsMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tlpGuestsMain.ColumnCount = 1;
            tlpGuestsMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpGuestsMain.Controls.Add(pnlGuestsHeader, 0, 0);
            tlpGuestsMain.Controls.Add(pnlGuestsContent, 0, 1);
            tlpGuestsMain.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tlpGuestsMain.Location = new Point(0, 0);
            tlpGuestsMain.Margin = new Padding(0);
            tlpGuestsMain.Name = "tlpGuestsMain";
            tlpGuestsMain.Padding = new Padding(15);
            tlpGuestsMain.RowCount = 2;
            tlpGuestsMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 85F));
            tlpGuestsMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpGuestsMain.Size = new Size(1100, 800);
            tlpGuestsMain.TabIndex = 0;
            // 
            // pnlGuestsHeader
            // 
            pnlGuestsHeader.Controls.Add(lblGuestsTitle);
            pnlGuestsHeader.Dock = DockStyle.Fill;
            pnlGuestsHeader.Location = new Point(15, 15);
            pnlGuestsHeader.Margin = new Padding(0, 0, 0, 12);
            pnlGuestsHeader.Name = "pnlGuestsHeader";
            pnlGuestsHeader.Size = new Size(1070, 73);
            pnlGuestsHeader.TabIndex = 0;
            // 
            // lblGuestsSubtitle
            // 
            lblGuestsSubtitle.AutoSize = true;
            lblGuestsSubtitle.BackColor = Color.Transparent;
            lblGuestsSubtitle.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGuestsSubtitle.ForeColor = Color.FromArgb(82, 103, 128);
            lblGuestsSubtitle.Location = new Point(20, 34);
            lblGuestsSubtitle.Name = "lblGuestsSubtitle";
            lblGuestsSubtitle.Size = new Size(287, 23);
            lblGuestsSubtitle.TabIndex = 1;
            lblGuestsSubtitle.Text = "Add, edit and look up guest records.";
            // 
            // lblGuestsTitle
            // 
            lblGuestsTitle.AutoSize = true;
            lblGuestsTitle.BackColor = Color.Transparent;
            lblGuestsTitle.Font = new Font("Georgia", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGuestsTitle.ForeColor = Color.FromArgb(25, 47, 73);
            lblGuestsTitle.Location = new Point(0, 4);
            lblGuestsTitle.Name = "lblGuestsTitle";
            lblGuestsTitle.Size = new Size(160, 46);
            lblGuestsTitle.TabIndex = 0;
            lblGuestsTitle.Text = "Guests";
            // 
            // pnlGuestsContent
            // 
            pnlGuestsContent.Controls.Add(tlpGuestsContent);
            pnlGuestsContent.Dock = DockStyle.Fill;
            pnlGuestsContent.Location = new Point(15, 100);
            pnlGuestsContent.Margin = new Padding(0);
            pnlGuestsContent.Name = "pnlGuestsContent";
            pnlGuestsContent.Size = new Size(1070, 685);
            pnlGuestsContent.TabIndex = 1;
            // 
            // tlpGuestsContent
            // 
            tlpGuestsContent.ColumnCount = 2;
            tlpGuestsContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tlpGuestsContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tlpGuestsContent.Controls.Add(pnlGuestDetails, 0, 0);
            tlpGuestsContent.Controls.Add(tableLayoutPanel1, 1, 0);
            tlpGuestsContent.Dock = DockStyle.Fill;
            tlpGuestsContent.Location = new Point(0, 0);
            tlpGuestsContent.Margin = new Padding(0);
            tlpGuestsContent.Name = "tlpGuestsContent";
            tlpGuestsContent.RowCount = 1;
            tlpGuestsContent.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpGuestsContent.Size = new Size(1070, 685);
            tlpGuestsContent.TabIndex = 0;
            // 
            // pnlGuestDetails
            // 
            pnlGuestDetails.BackColor = Color.White;
            pnlGuestDetails.Controls.Add(lblGuestsSubtitle);
            pnlGuestDetails.Controls.Add(lblGuestDetailsTitle);
            pnlGuestDetails.Controls.Add(btnClearGuest);
            pnlGuestDetails.Controls.Add(btnDeleteGuest);
            pnlGuestDetails.Controls.Add(btnUpdateGuest);
            pnlGuestDetails.Controls.Add(btnAddGuest);
            pnlGuestDetails.Controls.Add(txtAddress);
            pnlGuestDetails.Controls.Add(lblAddress);
            pnlGuestDetails.Controls.Add(cmbNationality);
            pnlGuestDetails.Controls.Add(lblNationality);
            pnlGuestDetails.Controls.Add(txtIdNumber);
            pnlGuestDetails.Controls.Add(lblIdNumber);
            pnlGuestDetails.Controls.Add(cmbIdType);
            pnlGuestDetails.Controls.Add(lblIdType);
            pnlGuestDetails.Controls.Add(txtEmail);
            pnlGuestDetails.Controls.Add(lblEmail);
            pnlGuestDetails.Controls.Add(txtPhoneNumber);
            pnlGuestDetails.Controls.Add(lblPhoneNumber);
            pnlGuestDetails.Controls.Add(txtLastName);
            pnlGuestDetails.Controls.Add(lblLastName);
            pnlGuestDetails.Controls.Add(textBox1);
            pnlGuestDetails.Controls.Add(lblFirstName);
            pnlGuestDetails.Controls.Add(txtGuestId);
            pnlGuestDetails.Controls.Add(lblGuestId);
            pnlGuestDetails.Dock = DockStyle.Fill;
            pnlGuestDetails.Location = new Point(8, 0);
            pnlGuestDetails.Margin = new Padding(8, 0, 8, 0);
            pnlGuestDetails.Name = "pnlGuestDetails";
            pnlGuestDetails.Padding = new Padding(15);
            pnlGuestDetails.Size = new Size(412, 685);
            pnlGuestDetails.TabIndex = 0;
            // 
            // btnClearGuest
            // 
            btnClearGuest.FlatStyle = FlatStyle.Flat;
            btnClearGuest.ForeColor = Color.FromArgb(25, 47, 73);
            btnClearGuest.Location = new Point(245, 627);
            btnClearGuest.Name = "btnClearGuest";
            btnClearGuest.Size = new Size(67, 40);
            btnClearGuest.TabIndex = 22;
            btnClearGuest.Text = "Clear";
            btnClearGuest.UseVisualStyleBackColor = true;
            // 
            // btnDeleteGuest
            // 
            btnDeleteGuest.BackColor = Color.FromArgb(187, 57, 52);
            btnDeleteGuest.FlatStyle = FlatStyle.Flat;
            btnDeleteGuest.ForeColor = Color.White;
            btnDeleteGuest.Location = new Point(169, 627);
            btnDeleteGuest.Name = "btnDeleteGuest";
            btnDeleteGuest.Size = new Size(70, 40);
            btnDeleteGuest.TabIndex = 21;
            btnDeleteGuest.Text = "Delete";
            btnDeleteGuest.UseVisualStyleBackColor = false;
            btnDeleteGuest.Click += btnDeleteGuest_Click;
            // 
            // btnUpdateGuest
            // 
            btnUpdateGuest.BackColor = Color.FromArgb(50, 115, 168);
            btnUpdateGuest.FlatStyle = FlatStyle.Flat;
            btnUpdateGuest.ForeColor = Color.White;
            btnUpdateGuest.Location = new Point(88, 627);
            btnUpdateGuest.Name = "btnUpdateGuest";
            btnUpdateGuest.Size = new Size(76, 40);
            btnUpdateGuest.TabIndex = 20;
            btnUpdateGuest.Text = "Update";
            btnUpdateGuest.UseVisualStyleBackColor = false;
            // 
            // btnAddGuest
            // 
            btnAddGuest.BackColor = Color.FromArgb(23, 103, 71);
            btnAddGuest.FlatStyle = FlatStyle.Flat;
            btnAddGuest.ForeColor = Color.White;
            btnAddGuest.Location = new Point(15, 627);
            btnAddGuest.Name = "btnAddGuest";
            btnAddGuest.Size = new Size(67, 40);
            btnAddGuest.TabIndex = 19;
            btnAddGuest.Text = "Add";
            btnAddGuest.UseVisualStyleBackColor = false;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(20, 539);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.ScrollBars = ScrollBars.Vertical;
            txtAddress.Size = new Size(290, 38);
            txtAddress.TabIndex = 18;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 9F);
            lblAddress.Location = new Point(35, 505);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(62, 20);
            lblAddress.TabIndex = 17;
            lblAddress.Text = "Address";
            // 
            // cmbNationality
            // 
            cmbNationality.FormattingEnabled = true;
            cmbNationality.Items.AddRange(new object[] { "Ghanaian", "Nigerain", "British", "American", "French", "Italian", "Japanese", "Swedish" });
            cmbNationality.Location = new Point(20, 456);
            cmbNationality.Name = "cmbNationality";
            cmbNationality.Size = new Size(290, 31);
            cmbNationality.TabIndex = 16;
            // 
            // lblNationality
            // 
            lblNationality.AutoSize = true;
            lblNationality.Font = new Font("Segoe UI", 9F);
            lblNationality.Location = new Point(35, 433);
            lblNationality.Name = "lblNationality";
            lblNationality.Size = new Size(82, 20);
            lblNationality.TabIndex = 15;
            lblNationality.Text = "Nationality";
            // 
            // txtIdNumber
            // 
            txtIdNumber.Location = new Point(170, 385);
            txtIdNumber.Name = "txtIdNumber";
            txtIdNumber.Size = new Size(140, 30);
            txtIdNumber.TabIndex = 14;
            // 
            // lblIdNumber
            // 
            lblIdNumber.AutoSize = true;
            lblIdNumber.Font = new Font("Segoe UI", 9F);
            lblIdNumber.Location = new Point(185, 361);
            lblIdNumber.Name = "lblIdNumber";
            lblIdNumber.Size = new Size(79, 20);
            lblIdNumber.TabIndex = 13;
            lblIdNumber.Text = "ID number";
            // 
            // cmbIdType
            // 
            cmbIdType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbIdType.FormattingEnabled = true;
            cmbIdType.Items.AddRange(new object[] { "Passport", "National ID", "Driver's License", "Voter ID" });
            cmbIdType.Location = new Point(20, 384);
            cmbIdType.Name = "cmbIdType";
            cmbIdType.Size = new Size(140, 31);
            cmbIdType.TabIndex = 12;
            // 
            // lblIdType
            // 
            lblIdType.AutoSize = true;
            lblIdType.Font = new Font("Segoe UI", 9F);
            lblIdType.Location = new Point(35, 361);
            lblIdType.Name = "lblIdType";
            lblIdType.Size = new Size(57, 20);
            lblIdType.TabIndex = 11;
            lblIdType.Text = "ID type";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(20, 312);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(290, 30);
            txtEmail.TabIndex = 10;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F);
            lblEmail.Location = new Point(35, 289);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 9;
            lblEmail.Text = "Email";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(20, 240);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(290, 30);
            txtPhoneNumber.TabIndex = 8;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Font = new Font("Segoe UI", 9F);
            lblPhoneNumber.Location = new Point(35, 217);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(105, 20);
            lblPhoneNumber.TabIndex = 7;
            lblPhoneNumber.Text = "Phone number";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(170, 167);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(140, 30);
            txtLastName.TabIndex = 6;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.ImageAlign = ContentAlignment.TopLeft;
            lblLastName.Location = new Point(185, 141);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(88, 23);
            lblLastName.TabIndex = 5;
            lblLastName.Text = "Last name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(20, 167);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(140, 30);
            textBox1.TabIndex = 4;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(35, 141);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(89, 23);
            lblFirstName.TabIndex = 3;
            lblFirstName.Text = "First name";
            // 
            // txtGuestId
            // 
            txtGuestId.BackColor = Color.FromArgb(245, 242, 236);
            txtGuestId.ForeColor = Color.FromArgb(82, 103, 128);
            txtGuestId.Location = new Point(20, 95);
            txtGuestId.Name = "txtGuestId";
            txtGuestId.ReadOnly = true;
            txtGuestId.Size = new Size(290, 30);
            txtGuestId.TabIndex = 2;
            // 
            // lblGuestId
            // 
            lblGuestId.AutoSize = true;
            lblGuestId.Font = new Font("Segoe UI", 10F);
            lblGuestId.ForeColor = Color.FromArgb(40, 55, 72);
            lblGuestId.Location = new Point(35, 69);
            lblGuestId.Name = "lblGuestId";
            lblGuestId.Size = new Size(76, 23);
            lblGuestId.TabIndex = 1;
            lblGuestId.Text = "Guest ID";
            // 
            // lblGuestDetailsTitle
            // 
            lblGuestDetailsTitle.AutoSize = true;
            lblGuestDetailsTitle.BackColor = Color.Transparent;
            lblGuestDetailsTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGuestDetailsTitle.ForeColor = Color.FromArgb(25, 47, 73);
            lblGuestDetailsTitle.Location = new Point(20, 6);
            lblGuestDetailsTitle.Name = "lblGuestDetailsTitle";
            lblGuestDetailsTitle.Size = new Size(138, 28);
            lblGuestDetailsTitle.TabIndex = 0;
            lblGuestDetailsTitle.Text = "Guest Details";
            // 
            // pnlAllGuests
            // 
            pnlAllGuests.BackColor = Color.White;
            pnlAllGuests.Controls.Add(dgvGuests);
            pnlAllGuests.Dock = DockStyle.Fill;
            pnlAllGuests.Location = new Point(8, 64);
            pnlAllGuests.Margin = new Padding(8, 0, 8, 0);
            pnlAllGuests.Name = "pnlAllGuests";
            pnlAllGuests.Padding = new Padding(15);
            pnlAllGuests.Size = new Size(620, 584);
            pnlAllGuests.TabIndex = 1;
            pnlAllGuests.Paint += pnlAllGuests_Paint;
            // 
            // lblGuestCount
            // 
            lblGuestCount.AutoSize = true;
            lblGuestCount.Font = new Font("Segoe UI", 9F);
            lblGuestCount.ForeColor = Color.FromArgb(82, 103, 128);
            lblGuestCount.Location = new Point(3, 648);
            lblGuestCount.Name = "lblGuestCount";
            lblGuestCount.Size = new Size(170, 20);
            lblGuestCount.TabIndex = 3;
            lblGuestCount.Text = "Showing 11 of 18 guests";
            lblGuestCount.Click += lblGuestCount_Click;
            // 
            // dgvGuests
            // 
            dgvGuests.AllowUserToAddRows = false;
            dgvGuests.AllowUserToDeleteRows = false;
            dgvGuests.AllowUserToResizeRows = false;
            dgvGuests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGuests.BackgroundColor = Color.White;
            dgvGuests.BorderStyle = BorderStyle.None;
            dgvGuests.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvGuests.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(245, 242, 236);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(82, 103, 128);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(245, 242, 236);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvGuests.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvGuests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGuests.Columns.AddRange(new DataGridViewColumn[] { colGuestID, colGuestName, colNationality, colStays, colPhone, colEmail });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(25, 47, 73);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.Padding = new Padding(4, 0, 4, 0);
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(250, 242, 222);
            dataGridViewCellStyle8.SelectionForeColor = Color.FromArgb(25, 47, 73);
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvGuests.DefaultCellStyle = dataGridViewCellStyle8;
            dgvGuests.Dock = DockStyle.Fill;
            dgvGuests.EnableHeadersVisualStyles = false;
            dgvGuests.GridColor = Color.FromArgb(235, 230, 222);
            dgvGuests.Location = new Point(15, 15);
            dgvGuests.MultiSelect = false;
            dgvGuests.Name = "dgvGuests";
            dgvGuests.ReadOnly = true;
            dgvGuests.RowHeadersVisible = false;
            dgvGuests.RowHeadersWidth = 51;
            dgvGuests.RowTemplate.Height = 35;
            dgvGuests.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGuests.Size = new Size(590, 554);
            dgvGuests.TabIndex = 2;
            dgvGuests.CellContentClick += dgvGuests_CellContentClick;
            // 
            // colGuestID
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            colGuestID.DefaultCellStyle = dataGridViewCellStyle2;
            colGuestID.HeaderText = "ID";
            colGuestID.MinimumWidth = 6;
            colGuestID.Name = "colGuestID";
            colGuestID.ReadOnly = true;
            colGuestID.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colGuestName
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            colGuestName.DefaultCellStyle = dataGridViewCellStyle3;
            colGuestName.HeaderText = "NAME";
            colGuestName.MinimumWidth = 6;
            colGuestName.Name = "colGuestName";
            colGuestName.ReadOnly = true;
            colGuestName.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colNationality
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            colNationality.DefaultCellStyle = dataGridViewCellStyle4;
            colNationality.HeaderText = "NATIONALITY";
            colNationality.MinimumWidth = 6;
            colNationality.Name = "colNationality";
            colNationality.ReadOnly = true;
            colNationality.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colStays
            // 
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            colStays.DefaultCellStyle = dataGridViewCellStyle5;
            colStays.HeaderText = "STAYS";
            colStays.MinimumWidth = 6;
            colStays.Name = "colStays";
            colStays.ReadOnly = true;
            colStays.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colPhone
            // 
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            colPhone.DefaultCellStyle = dataGridViewCellStyle6;
            colPhone.HeaderText = "PHONE";
            colPhone.MinimumWidth = 6;
            colPhone.Name = "colPhone";
            colPhone.ReadOnly = true;
            colPhone.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colEmail
            // 
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            colEmail.DefaultCellStyle = dataGridViewCellStyle7;
            colEmail.HeaderText = "EMAIL";
            colEmail.MinimumWidth = 6;
            colEmail.Name = "colEmail";
            colEmail.ReadOnly = true;
            colEmail.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // txtSearchGuests
            // 
            txtSearchGuests.BorderStyle = BorderStyle.FixedSingle;
            txtSearchGuests.Location = new Point(141, 13);
            txtSearchGuests.Name = "txtSearchGuests";
            txtSearchGuests.PlaceholderText = "Search by name, phone or ID";
            txtSearchGuests.Size = new Size(474, 30);
            txtSearchGuests.TabIndex = 1;
            // 
            // lblAllGuestsTitle
            // 
            lblAllGuestsTitle.AutoSize = true;
            lblAllGuestsTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAllGuestsTitle.ForeColor = Color.FromArgb(25, 47, 73);
            lblAllGuestsTitle.Location = new Point(13, 15);
            lblAllGuestsTitle.Name = "lblAllGuestsTitle";
            lblAllGuestsTitle.Size = new Size(107, 28);
            lblAllGuestsTitle.TabIndex = 0;
            lblAllGuestsTitle.Text = "All Guests";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(pnlAllGuests, 0, 1);
            tableLayoutPanel1.Controls.Add(lblGuestCount, 0, 2);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(431, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.Size = new Size(636, 679);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblAllGuestsTitle);
            panel1.Controls.Add(txtSearchGuests);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(630, 58);
            panel1.TabIndex = 3;
            // 
            // ucGuests
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(245, 242, 236);
            Controls.Add(tlpGuestsMain);
            Font = new Font("Segoe UI", 10F);
            Name = "ucGuests";
            Size = new Size(1100, 800);
            Load += ucGuests_Load;
            tlpGuestsMain.ResumeLayout(false);
            pnlGuestsHeader.ResumeLayout(false);
            pnlGuestsHeader.PerformLayout();
            pnlGuestsContent.ResumeLayout(false);
            tlpGuestsContent.ResumeLayout(false);
            pnlGuestDetails.ResumeLayout(false);
            pnlGuestDetails.PerformLayout();
            pnlAllGuests.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGuests).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpGuestsMain;
        private Panel pnlGuestsHeader;
        private Panel pnlGuestsContent;
        private Label lblGuestsTitle;
        private Label lblGuestsSubtitle;
        private TableLayoutPanel tlpGuestsContent;
        private Panel pnlGuestDetails;
        private Panel pnlAllGuests;
        private Label lblGuestDetailsTitle;
        private Label lblFirstName;
        private TextBox txtGuestId;
        private Label lblGuestId;
        private TextBox txtLastName;
        private Label lblLastName;
        private TextBox textBox1;
        private Label lblEmail;
        private TextBox txtPhoneNumber;
        private Label lblPhoneNumber;
        private ComboBox cmbIdType;
        private Label lblIdType;
        private TextBox txtEmail;
        private ComboBox cmbNationality;
        private Label lblNationality;
        private TextBox txtIdNumber;
        private Label lblIdNumber;
        private TextBox txtAddress;
        private Label lblAddress;
        private Button btnClearGuest;
        private Button btnDeleteGuest;
        private Button btnUpdateGuest;
        private Button btnAddGuest;
        private TextBox txtSearchGuests;
        private Label lblAllGuestsTitle;
        private DataGridView dgvGuests;
        private DataGridViewTextBoxColumn colGuestID;
        private DataGridViewTextBoxColumn colGuestName;
        private DataGridViewTextBoxColumn colNationality;
        private DataGridViewTextBoxColumn colStays;
        private DataGridViewTextBoxColumn colPhone;
        private DataGridViewTextBoxColumn colEmail;
        private Label lblGuestCount;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
    }
}
