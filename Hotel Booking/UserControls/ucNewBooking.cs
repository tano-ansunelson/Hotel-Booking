using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hotel_Booking.UserControls;

public partial class ucNewBooking : UserControl
{
    public ucNewBooking()
    {
        InitializeComponent();
        StyleAvailableRooms();
        LoadSampleAvailableRooms();

        this.Dock = DockStyle.Fill;

    }

    private void ucNewBooking_Load(object sender, EventArgs e)
    {

    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void lblAdults_Click(object sender, EventArgs e)
    {

    }

    private void dgvAvailableRooms_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }










    private void LoadSampleAvailableRooms()
    {
        dgvAvailableRooms.Rows.Clear();

        dgvAvailableRooms.Rows.Add(
            "204", "Deluxe King", "1 King Bed", "650.00", "Select"
        );

        dgvAvailableRooms.Rows.Add(
            "206", "Family Room", "1 King + 2 Single", "820.00", "Select"
        );

        dgvAvailableRooms.Rows.Add(
            "208", "Standard Twin", "2 Single Beds", "420.00", "Select"
        );

        dgvAvailableRooms.Rows.Add(
            "210", "Standard Twin", "2 Single Beds", "420.00", "Select"
        );

        dgvAvailableRooms.Rows.Add(
            "305", "Executive Suite", "1 King Bed", "1200.00", "Select"
        );

        dgvAvailableRooms.Rows.Add(
            "311", "Deluxe King", "1 King Bed", "650.00", "Select"
        );

        lblAvailableRoomsCount.Text =
            $"{dgvAvailableRooms.Rows.Count} rooms free for these dates";
    }

    private void StyleAvailableRooms()
    {
        dgvAvailableRooms.EnableHeadersVisualStyles = false;

        dgvAvailableRooms.ColumnHeadersDefaultCellStyle.BackColor =
            Color.FromArgb(245, 242, 236);

        dgvAvailableRooms.ColumnHeadersDefaultCellStyle.ForeColor =
            Color.FromArgb(85, 100, 120);

        dgvAvailableRooms.ColumnHeadersDefaultCellStyle.Font =
            new Font("Segoe UI", 9, FontStyle.Bold);

        dgvAvailableRooms.DefaultCellStyle.Font =
            new Font("Segoe UI", 9);

        dgvAvailableRooms.DefaultCellStyle.ForeColor =
            Color.FromArgb(25, 45, 68);

        dgvAvailableRooms.DefaultCellStyle.BackColor = Color.White;

        dgvAvailableRooms.DefaultCellStyle.SelectionBackColor =
            Color.FromArgb(250, 242, 222);

        dgvAvailableRooms.DefaultCellStyle.SelectionForeColor =
            Color.FromArgb(25, 45, 68);

        dgvAvailableRooms.RowTemplate.Height = 48;

        dgvAvailableRooms.ColumnHeadersHeight = 38;
    }







}


