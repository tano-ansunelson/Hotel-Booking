using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Text;

namespace Hotel_Booking.Services
{
    public static class UiHelper
    {

        public static void Round(Control c, int radius)
        {
            int d = radius * 2;
            var path = new GraphicsPath();
            path.AddArc(0, 0, d, d, 180, 90);
            path.AddArc(c.Width - d, 0, d, d, 270, 90);
            path.AddArc(c.Width - d, c.Height - d, d, d, 0, 90);
            path.AddArc(0, c.Height - d, d, d, 90, 90);
            path.CloseFigure();
            c.Region = new Region(path);
        }


    }
}
