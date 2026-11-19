using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel_Booking.Models;

public class Booking
{

    public int BookingID { get; set; }

    public string BookingNo { get; set; } = string.Empty;

    public int GuestID { get; set; }
    public int RoomID { get; set; }
    public DateTime CheckInDate { get; set; }
    public DateTime CheckOutDate { get; set; }

    public int Adults { get; set; } = 1;
    public decimal NightlyRate { get; set; }
    public decimal TaxRate { get; set; } = 15m;


    public BookingStatus Status { get; set; } = BookingStatus.Pending;
    public string? SpecialRequests { get; set; }
    public DateTime? ActualCheckIn { get; set; }
    public DateTime? ActualCheckOut { get; set; }
    public int? CreatedBy { get; set; }
    public DateTime CreatedAt { get; set; }

    // Filled by JOINs
    public string GuestName { get; set; } = string.Empty;
    public string RoomNumber { get; set; } = string.Empty;
    public string RoomTypeName { get; set; } = string.Empty;
    public decimal PaidAmount { get; set; }



    // Calculated, never stored
    public int Nights => Math.Max((CheckOutDate.Date - CheckInDate.Date).Days, 0);
    public decimal Subtotal => Nights * NightlyRate;
    public decimal TaxAmount => Math.Round(Subtotal * TaxRate / 100m, 2);
    public decimal Total => Subtotal + TaxAmount;
    public decimal Balance => Total - PaidAmount;

}

