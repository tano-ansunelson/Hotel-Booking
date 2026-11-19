using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel_Booking.Models;

public class Payment
{
    public int PaymentID { get; set; }
    public int BookingID { get; set; }
    public decimal Amount { get; set; }
    public PaymentMethod Method { get; set; } = PaymentMethod.Cash;
    public string? Reference { get; set; }
    public DateTime PaidAt { get; set; }
    public int? ReceivedBy { get; set; }

    // Filled by JOINs
    public string BookingNo { get; set; } = string.Empty;
    public string GuestName { get; set; } = string.Empty;

}
