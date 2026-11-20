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
            tlpBookingMain = new TableLayoutPanel();
            pnlBookingHeader = new Panel();
            lblBookingTitle = new Label();
            lblBookingSubtitle = new Label();
            tlpBookingMain.SuspendLayout();
            pnlBookingHeader.SuspendLayout();
            SuspendLayout();
            // 
            // tlpBookingMain
            // 
            tlpBookingMain.BackColor = Color.FromArgb(245, 242, 236);
            tlpBookingMain.ColumnCount = 1;
            tlpBookingMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpBookingMain.Controls.Add(pnlBookingHeader, 0, 0);
            tlpBookingMain.Dock = DockStyle.Fill;
            tlpBookingMain.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tlpBookingMain.Location = new Point(0, 0);
            tlpBookingMain.Margin = new Padding(0);
            tlpBookingMain.Name = "tlpBookingMain";
            tlpBookingMain.Padding = new Padding(20, 15, 20, 15);
            tlpBookingMain.RowCount = 3;
            tlpBookingMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tlpBookingMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 110F));
            tlpBookingMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpBookingMain.Size = new Size(1337, 781);
            tlpBookingMain.TabIndex = 0;
            // 
            // pnlBookingHeader
            // 
            pnlBookingHeader.Controls.Add(lblBookingSubtitle);
            pnlBookingHeader.Controls.Add(lblBookingTitle);
            pnlBookingHeader.Dock = DockStyle.Fill;
            pnlBookingHeader.Location = new Point(20, 15);
            pnlBookingHeader.Margin = new Padding(0);
            pnlBookingHeader.Name = "pnlBookingHeader";
            pnlBookingHeader.Size = new Size(1297, 75);
            pnlBookingHeader.TabIndex = 0;
            // 
            // lblBookingTitle
            // 
            lblBookingTitle.AutoSize = true;
            lblBookingTitle.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBookingTitle.ForeColor = Color.FromArgb(25, 45, 68);
            lblBookingTitle.Location = new Point(18, 0);
            lblBookingTitle.Name = "lblBookingTitle";
            lblBookingTitle.Size = new Size(258, 50);
            lblBookingTitle.TabIndex = 0;
            lblBookingTitle.Text = "New Booking";
            // 
            // lblBookingSubtitle
            // 
            lblBookingSubtitle.AutoSize = true;
            lblBookingSubtitle.ForeColor = Color.FromArgb(120, 120, 120);
            lblBookingSubtitle.Location = new Point(28, 50);
            lblBookingSubtitle.Name = "lblBookingSubtitle";
            lblBookingSubtitle.Size = new Size(371, 20);
            lblBookingSubtitle.TabIndex = 1;
            lblBookingSubtitle.Text = "Create a new reservation and assign a room to a guest.";
            // 
            // ucNewBooking
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tlpBookingMain);
            Name = "ucNewBooking";
            Size = new Size(1337, 781);
            Load += ucNewBooking_Load;
            tlpBookingMain.ResumeLayout(false);
            pnlBookingHeader.ResumeLayout(false);
            pnlBookingHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpBookingMain;
        private Panel pnlBookingHeader;
        private Label lblBookingSubtitle;
        private Label lblBookingTitle;
    }
}
