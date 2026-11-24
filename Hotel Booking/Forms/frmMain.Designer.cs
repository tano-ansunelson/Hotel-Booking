namespace Hotel_Booking
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tlpMain = new TableLayoutPanel();
            sidebar = new ucSidebar();
            pnlContent = new Panel();
            tlpMain.SuspendLayout();
            SuspendLayout();
            // 
            // tlpMain
            // 
            tlpMain.ColumnCount = 2;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 235F));
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMain.Controls.Add(sidebar, 0, 0);
            tlpMain.Controls.Add(pnlContent, 1, 0);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(0, 0);
            tlpMain.Margin = new Padding(0);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 1;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMain.Size = new Size(1332, 853);
            tlpMain.TabIndex = 0;
            tlpMain.Paint += tlpMain_Paint;
            // 
            // sidebar
            // 
            sidebar.Dock = DockStyle.Fill;
            sidebar.Location = new Point(0, 0);
            sidebar.Margin = new Padding(0);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(235, 853);
            sidebar.TabIndex = 0;
            // 
            // pnlContent
            // 
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(235, 0);
            pnlContent.Margin = new Padding(0);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1097, 853);
            pnlContent.TabIndex = 1;
            pnlContent.Paint += pnlContent_Paint;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 243, 239);
            ClientSize = new Size(1332, 853);
            Controls.Add(tlpMain);
            MinimumSize = new Size(1100, 700);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Grand Palm Hotel - Hotel Manager";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            tlpMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpMain;
        private ucSidebar sidebar;
        private Panel pnlContent;
    }
}
