using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hotel_Booking
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            AcceptButton = btnSignIn;
            lbError.Visible = false;
            Round(pnlLogo, 10);
            Round(btnSignIn, 8);
        }

        private void lblLogoIcon_Click(object sender, EventArgs e)
        {

        }

        private void lblHotelName_Click(object sender, EventArgs e)
        {

        }

        private void lblDescription_Click(object sender, EventArgs e)
        {

        }

        private void lblHotelSubtitle_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void lnkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {

        }



        private void ShowError(string message)
        {
            lbError.Text = message;
            lbError.Visible = true;
        }



        private static void Round(Control c, int radius)
        {
            int d = radius * 2;
            var path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(0, 0, d, d, 180, 90);
            path.AddArc(c.Width - d, 0, d, d, 270, 90);
            path.AddArc(c.Width - d, c.Height - d, d, d, 0, 90);
            path.AddArc(0, c.Height - d, d, d, 90, 90);
            path.CloseFigure();
            c.Region = new Region(path);
        }



    }
}
