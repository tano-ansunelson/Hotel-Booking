namespace Hotel_Booking.UserControls
{
    partial class ucRoomCard
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
            lblRoomNumber = new Label();
            lblStatus = new Label();
            lblRoomType = new Label();
            lblRoomInfo = new Label();
            lblPrice = new Label();
            SuspendLayout();
            // 
            // lblRoomNumber
            // 
            lblRoomNumber.AutoSize = true;
            lblRoomNumber.Location = new Point(15, 12);
            lblRoomNumber.Name = "lblRoomNumber";
            lblRoomNumber.Size = new Size(33, 20);
            lblRoomNumber.TabIndex = 0;
            lblRoomNumber.Text = "201";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(112, 12);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(71, 20);
            lblStatus.TabIndex = 1;
            lblStatus.Text = "Available";
            // 
            // lblRoomType
            // 
            lblRoomType.AutoSize = true;
            lblRoomType.Location = new Point(15, 32);
            lblRoomType.Name = "lblRoomType";
            lblRoomType.Size = new Size(103, 20);
            lblRoomType.TabIndex = 2;
            lblRoomType.Text = "Standard Twin";
            lblRoomType.Click += lblRoomType_Click;
            // 
            // lblRoomInfo
            // 
            lblRoomInfo.AutoSize = true;
            lblRoomInfo.Location = new Point(15, 67);
            lblRoomInfo.Name = "lblRoomInfo";
            lblRoomInfo.Size = new Size(153, 20);
            lblRoomInfo.TabIndex = 3;
            lblRoomInfo.Text = "Floor 2 · 2 single beds";
            lblRoomInfo.Click += label1_Click;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(15, 88);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(114, 20);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "GHS 420 / night";
            // 
            // ucRoomCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lblPrice);
            Controls.Add(lblRoomInfo);
            Controls.Add(lblRoomType);
            Controls.Add(lblStatus);
            Controls.Add(lblRoomNumber);
            Margin = new Padding(0, 0, 14, 14);
            Name = "ucRoomCard";
            Padding = new Padding(12);
            Size = new Size(198, 120);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRoomNumber;
        private Label lblStatus;
        private Label lblRoomType;
        private Label lblRoomInfo;
        private Label lblPrice;
    }
}
