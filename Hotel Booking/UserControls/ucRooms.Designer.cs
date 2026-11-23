namespace Hotel_Booking.UserControls
{
    partial class ucRooms
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
            tlpMain = new TableLayoutPanel();
            tlpHeader = new TableLayoutPanel();
            pnlPageTitle = new Panel();
            label1 = new Label();
            lblTitle = new Label();
            lblSubtitle = new Label();
            flpRoomFilters = new FlowLayoutPanel();
            btnAdd = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            tlpContent = new TableLayoutPanel();
            pnlRoomsList = new Panel();
            flpRooms = new FlowLayoutPanel();
            tlpMain.SuspendLayout();
            tlpHeader.SuspendLayout();
            pnlPageTitle.SuspendLayout();
            flpRoomFilters.SuspendLayout();
            tlpContent.SuspendLayout();
            pnlRoomsList.SuspendLayout();
            SuspendLayout();
            // 
            // tlpMain
            // 
            tlpMain.ColumnCount = 1;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMain.Controls.Add(tlpHeader, 0, 0);
            tlpMain.Controls.Add(tlpContent, 0, 1);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(32, 25);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 2;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 90F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMain.Size = new Size(1242, 790);
            tlpMain.TabIndex = 0;
            // 
            // tlpHeader
            // 
            tlpHeader.ColumnCount = 2;
            tlpHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            tlpHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tlpHeader.Controls.Add(pnlPageTitle, 0, 0);
            tlpHeader.Controls.Add(flpRoomFilters, 1, 0);
            tlpHeader.Dock = DockStyle.Fill;
            tlpHeader.Location = new Point(3, 3);
            tlpHeader.Name = "tlpHeader";
            tlpHeader.RowCount = 1;
            tlpHeader.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpHeader.Size = new Size(1236, 84);
            tlpHeader.TabIndex = 0;
            // 
            // pnlPageTitle
            // 
            pnlPageTitle.Controls.Add(lblSubtitle);
            pnlPageTitle.Controls.Add(lblTitle);
            pnlPageTitle.Controls.Add(label1);
            pnlPageTitle.Dock = DockStyle.Fill;
            pnlPageTitle.ForeColor = Color.FromArgb(101, 116, 139);
            pnlPageTitle.Location = new Point(3, 3);
            pnlPageTitle.Name = "pnlPageTitle";
            pnlPageTitle.Size = new Size(673, 78);
            pnlPageTitle.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(-32, 178);
            label1.Name = "label1";
            label1.Size = new Size(55, 23);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Georgia", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(20, 43, 70);
            lblTitle.Location = new Point(3, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(181, 51);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Rooms";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Location = new Point(3, 51);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(331, 23);
            lblSubtitle.TabIndex = 2;
            lblSubtitle.Text = "Manage room types, rates and availability.";
            // 
            // flpRoomFilters
            // 
            flpRoomFilters.BackColor = Color.Transparent;
            flpRoomFilters.Controls.Add(btnAdd);
            flpRoomFilters.Controls.Add(button2);
            flpRoomFilters.Controls.Add(button3);
            flpRoomFilters.Controls.Add(button4);
            flpRoomFilters.Controls.Add(button5);
            flpRoomFilters.Dock = DockStyle.Fill;
            flpRoomFilters.Location = new Point(682, 3);
            flpRoomFilters.Name = "flpRoomFilters";
            flpRoomFilters.Size = new Size(551, 78);
            flpRoomFilters.TabIndex = 1;
            flpRoomFilters.WrapContents = false;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(3, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(103, 3);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(203, 3);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(303, 3);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 3;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(403, 3);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 4;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // tlpContent
            // 
            tlpContent.ColumnCount = 2;
            tlpContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tlpContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tlpContent.Controls.Add(pnlRoomsList, 0, 0);
            tlpContent.Dock = DockStyle.Fill;
            tlpContent.Location = new Point(3, 93);
            tlpContent.Name = "tlpContent";
            tlpContent.RowCount = 1;
            tlpContent.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpContent.Size = new Size(1236, 694);
            tlpContent.TabIndex = 1;
            // 
            // pnlRoomsList
            // 
            pnlRoomsList.BackColor = Color.Transparent;
            pnlRoomsList.Controls.Add(flpRooms);
            pnlRoomsList.Dock = DockStyle.Fill;
            pnlRoomsList.Location = new Point(3, 3);
            pnlRoomsList.Name = "pnlRoomsList";
            pnlRoomsList.Size = new Size(797, 688);
            pnlRoomsList.TabIndex = 0;
            // 
            // flpRooms
            // 
            flpRooms.AutoScroll = true;
            flpRooms.Dock = DockStyle.Top;
            flpRooms.Location = new Point(0, 0);
            flpRooms.Margin = new Padding(0);
            flpRooms.Name = "flpRooms";
            flpRooms.Size = new Size(797, 655);
            flpRooms.TabIndex = 0;
            // 
            // ucRooms
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(245, 243, 239);
            Controls.Add(tlpMain);
            Font = new Font("Segoe UI", 10F);
            Margin = new Padding(0);
            Name = "ucRooms";
            Padding = new Padding(32, 25, 28, 20);
            Size = new Size(1302, 835);
            Load += ucRooms_Load;
            tlpMain.ResumeLayout(false);
            tlpHeader.ResumeLayout(false);
            pnlPageTitle.ResumeLayout(false);
            pnlPageTitle.PerformLayout();
            flpRoomFilters.ResumeLayout(false);
            tlpContent.ResumeLayout(false);
            pnlRoomsList.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpMain;
        private TableLayoutPanel tlpHeader;
        private Panel pnlPageTitle;
        private Label label1;
        private Label lblSubtitle;
        private Label lblTitle;
        private FlowLayoutPanel flpRoomFilters;
        private Button btnAdd;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private TableLayoutPanel tlpContent;
        private Panel pnlRoomsList;
        private FlowLayoutPanel flpRooms;
    }
}
