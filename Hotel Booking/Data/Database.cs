using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel_Booking.Data;

public class Database
{



    private const string ConnectionString =
       @"Server=localhost;Database=HotelBooking;Trusted_Connection=True;TrustServerCertificate=True;";

    public static SqlConnection CreateConnection() => new(ConnectionString);


    public static bool TestConnection(out string error)
    {
        try
        {
            using var conn = CreateConnection();

            conn.Open();
            error = string.Empty;
            return true;
        }
        catch (Exception ex)
        {
            error = ex.Message;
            return false;
        }
    }

}

