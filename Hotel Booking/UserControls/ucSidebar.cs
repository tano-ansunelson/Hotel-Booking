using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hotel_Booking
{
    public partial class ucSidebar : UserControl
    {
        public event Action<string> NavigationRequested;
        public ucSidebar()
        {
            InitializeComponent();
            btnDashboard.Click += (s, e) =>
                NavigationRequested?.Invoke("Dashboard");

            btnBookings.Click += (s, e) =>
               NavigationRequested?.Invoke("Bookings");
            btnNewBooking.Click += (s, e) =>
               NavigationRequested?.Invoke("NewBooking");
            btnCheckInOut.Click += (s, e) =>
               NavigationRequested?.Invoke("CheckInOut");
            btnGuests.Click += (s, e) =>
               NavigationRequested?.Invoke("Guests");
            btnReports.Click += (s, e) =>
               NavigationRequested?.Invoke("Reports");
            btnRooms.Click += (s, e) =>
               NavigationRequested?.Invoke("Rooms");
            btnPayments.Click += (s, e) =>
               NavigationRequested?.Invoke("Payments");
        }

        public void SetActivePage(string page)
        {
            Button[] buttons =
            {
                btnDashboard,
                btnBookings,
                btnNewBooking,
                btnCheckInOut,
                btnGuests,
                btnReports,
                btnRooms,
                btnPayments
            };

            foreach (Button button in buttons)
            {
                button.BackColor = Color.FromArgb(20, 43, 70);
                button.ForeColor = Color.White;

            }

            //Heiglight the seleted page

            Button activeButton = page switch
            {
                "Dashboard" => btnDashboard,
                "Bookings" => btnBookings,
                "NewBooking" => btnNewBooking,
                "CheckInOut" => btnCheckInOut,
                "Guests" => btnGuests,
                "Rooms" => btnRooms,
                "Payments" => btnPayments,
                "Reports" => btnReports,
                _ => btnDashboard
            };

            activeButton.BackColor = Color.FromArgb(32, 63, 96);
            activeButton.ForeColor = Color.White;


        }




        private void flpNavigation_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCheckInOut_Click(object sender, EventArgs e)
        {

        }

        private void btnGuests_Click(object sender, EventArgs e)
        {

        }
    }
}
