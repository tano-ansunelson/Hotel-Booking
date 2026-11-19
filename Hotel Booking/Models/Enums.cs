using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel_Booking.Models;

public enum UserRole
{
    Admin,
    Receptionist,
    Accountant,
}
public enum RoomStatus
{
    Available,
    Occupied,
    Reserved,
    Cleaning,
    outOfService
}

public enum BookingStatus
{
    Confirmed,
    Cancelled,
    CheckedIn,
    CheckedOut,
    Pending,
}

public enum PaymentMethod
{
    Cash,
    Card,
    MobileMoney,
    BankTransfer,


}