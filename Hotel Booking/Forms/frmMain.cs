using Hotel_Booking.UserControls;

namespace Hotel_Booking
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            sidebar.SetActivePage("Dashboard");

            LoadDashboard();


        }

        private void LoadDashboard()
        {
            ucDashboard dashboard = new ucDashboard();
            dashboard.Dock = DockStyle.Fill;
            pnlContent.Controls.Clear();

            pnlContent.Controls.Add(dashboard);
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tlpMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
