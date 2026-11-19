using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel_Booking.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string Username { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;

        public string FullName { get; set; } = string.Empty;
        public UserRole Role { get; set; } = UserRole.Receptionist;

        public bool IsActive { get; set; } = true;
        public DateTime CreatedAt { get; set; }



    }
}
