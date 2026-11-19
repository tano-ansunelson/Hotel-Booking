using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel_Booking.Models;

public class Guest
{
    public int GuestID { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string? Email { get; set; }
    public string PhoneNumber { get; set; } = string.Empty;
    public string? IdType { get; set; }
    public string? IdNumber { get; set; }
    public string? Nationality { get; set; }
    public string? Address { get; set; }

    public DateTime CreatedAt { get; set; }


    public string FullName => $"{FirstName} {LastName}".Trim();

    public override string ToString() => FullName;






}

