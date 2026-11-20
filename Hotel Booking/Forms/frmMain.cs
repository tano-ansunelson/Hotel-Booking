using Hotel_Booking.UserControls;

namespace Hotel_Booking
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            sidebar.NavigationRequested += Sidebar_NavigationRequested;

            sidebar.SetActivePage("Dashboard");
            //load default page
            LoadPage(new ucDashboard());

        }

        private void LoadPage(UserControl page)
        {
            //ucDashboard dashboard = new ucDashboard();
            //dashboard.Dock = DockStyle.Fill;
            pnlContent.Controls.Clear();
            page.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(page);
        }

        private void Sidebar_NavigationRequested(string page)
        {
            sidebar.SetActivePage(page);
            switch (page)
            {
                case "Dashboard":
                    LoadPage(new ucDashboard());
                    break;

                case "Guests":
                    LoadPage(new ucGuests());
                    break;
                case "NewBooking":
                    LoadPage(new ucNewBooking());
                    break;
                case "Payments":
                    LoadPage(new ucPayments());
                    break;

                case "Rooms":
                    LoadPage(new ucRooms());
                    break;
                case "Reports":
                    LoadPage(new ucReports());
                    break;
                case "CheckInOut":
                    LoadPage(new ucCheckInOut());
                    break;

                case "Bookings":
                    LoadPage(new ucBookings());
                    break;


            }
        }




        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tlpMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
