using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel_Booking.Models;

public class Room
{
    public int RoomID { get; set; }
    public string RoomNumber { get; set; } = string.Empty;
    public int Floor { get; set; }
    public int RoomTypeID { get; set; }
    public RoomStatus Status { get; set; } = RoomStatus.Available;
    public string? Notes { get; set; }

    //filled by joins, not stored in the room table
    public string RoomTypeName { get; set; } = string.Empty;
    public decimal PricePerNight { get; set; }
    public int Capacity { get; set; }

    public override string ToString() => $"{RoomNumber} · {RoomTypeName}";



}

