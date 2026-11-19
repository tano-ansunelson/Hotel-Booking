using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hotel_Booking.UserControls;

public partial class ucDashboard : UserControl
{
    public ucDashboard()
    {
        InitializeComponent();
        CreateRoomButton();
        lblDashboardDate.Text =
            DateTime.Now.ToString("dddd, dd MMM yyyy");
    }

    private void pnlOccupancy_Paint(object sender, PaintEventArgs e)
    {

    }

    private void pnlAvailableRooms_Paint(object sender, PaintEventArgs e)
    {

    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void ucDashboard_Load(object sender, EventArgs e)
    {

    }



    private void CreateRoomButton()
    {
        tlpRoomButtons.Controls.Clear();

        for (int floor = 1; floor <= 4; floor++)
        {
            for (int room = 1; room <= 10; room++)
            {
                int roomNumber = (floor * 100) + room;

                Button btn = new Button();

                btn.Name = $"btnRoom{roomNumber}";
                btn.Text = roomNumber.ToString();
                btn.Dock = DockStyle.Fill;
                btn.Margin = new Padding(2);

                btn.FlatStyle = FlatStyle.Flat;

                btn.FlatAppearance.BorderSize = 1;
                btn.Font = new Font("Segoe UI", 8F);
                btn.Cursor = Cursors.Hand;

                //temporary sample room statuses

                int status = roomNumber % 4;

                switch (status)
                {
                    case 0:
                        btn.BackColor = Color.FromArgb(220, 239, 229);
                        btn.ForeColor = Color.FromArgb(36, 107, 72);
                        break;

                    case 1:
                        btn.BackColor = Color.FromArgb(249, 225, 222);
                        btn.ForeColor = Color.FromArgb(168, 61, 53);
                        break;

                    case 2:
                        btn.BackColor = Color.FromArgb(251, 236, 207);
                        btn.ForeColor = Color.FromArgb(147, 101, 27);
                        break;

                    default:
                        btn.BackColor = Color.FromArgb(223, 235, 248);
                        btn.ForeColor = Color.FromArgb(49, 95, 145);
                        break;
                }

                btn.Click += (sender, e) =>
                {
                    MessageBox.Show(
                        $"You selected room{roomNumber}",
                        "Room Overview",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                        );
                };

                tlpRoomButtons.Controls.Add(btn);

            }


        }
    }

    private void dgvTodayArrivals_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void lblAvailableStatus_Click(object sender, EventArgs e)
    {

    }

    private void lblOccupancyPercentage_Click(object sender, EventArgs e)
    {

    }
}

