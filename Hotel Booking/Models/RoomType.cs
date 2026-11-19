using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel_Booking.Models
{
    public class RoomType
    {

        public int RoomTypeID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public decimal PricePerNight { get; set; }
        public int Capacity { get; set; } = 2;
        public override string ToString() => Name;   // lets a ComboBox show the name
    }
}
