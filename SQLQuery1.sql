CREATE DATABASE HotelBooking;
GO
USE HotelBooking;
GO

CREATE TABLE dbo.RoomTypes (
    RoomTypeID    INT IDENTITY(1,1) PRIMARY KEY,
    Name          NVARCHAR(50)  NOT NULL UNIQUE,
    Description   NVARCHAR(200) NULL,
    PricePerNight DECIMAL(10,2) NOT NULL CHECK (PricePerNight >= 0),
    Capacity      INT           NOT NULL DEFAULT 2
);

CREATE TABLE dbo.Rooms (
    RoomID     INT IDENTITY(1,1) PRIMARY KEY,
    RoomNumber NVARCHAR(10) NOT NULL UNIQUE,
    Floor      INT          NOT NULL,
    RoomTypeID INT          NOT NULL REFERENCES dbo.RoomTypes(RoomTypeID),
    Status     NVARCHAR(20) NOT NULL DEFAULT 'Available'
               CHECK (Status IN ('Available','Occupied','Reserved','Cleaning','OutOfService')),
    Notes      NVARCHAR(200) NULL
);

CREATE TABLE dbo.Guests (
    GuestID     INT IDENTITY(1,1) PRIMARY KEY,
    FirstName   NVARCHAR(50)  NOT NULL,
    LastName    NVARCHAR(50)  NOT NULL,
    PhoneNumber NVARCHAR(20)  NOT NULL UNIQUE,
    Email       NVARCHAR(100) NULL,
    IdType      NVARCHAR(30)  NULL,
    IdNumber    NVARCHAR(50)  NULL,
    Nationality NVARCHAR(50)  NULL,
    Address     NVARCHAR(200) NULL,
    CreatedAt   DATETIME2     NOT NULL DEFAULT SYSDATETIME()
);

CREATE TABLE dbo.Users (
    UserID       INT IDENTITY(1,1) PRIMARY KEY,
    Username     NVARCHAR(50)  NOT NULL UNIQUE,
    PasswordHash NVARCHAR(200) NOT NULL,
    FullName     NVARCHAR(100) NOT NULL,
    Role         NVARCHAR(20)  NOT NULL CHECK (Role IN ('Admin','Receptionist','Accountant')),
    IsActive     BIT           NOT NULL DEFAULT 1,
    CreatedAt    DATETIME2     NOT NULL DEFAULT SYSDATETIME()
);

CREATE TABLE dbo.Bookings (
    BookingID       INT IDENTITY(1,1) PRIMARY KEY,
    BookingNo       AS ('BK-' + CAST(BookingID AS VARCHAR(10))) PERSISTED,
    GuestID         INT NOT NULL REFERENCES dbo.Guests(GuestID),
    RoomID          INT NOT NULL REFERENCES dbo.Rooms(RoomID),
    CheckInDate     DATE NOT NULL,
    CheckOutDate    DATE NOT NULL,
    Adults          INT  NOT NULL DEFAULT 1,
    NightlyRate     DECIMAL(10,2) NOT NULL,          -- rate frozen at booking time
    TaxRate         DECIMAL(5,2)  NOT NULL DEFAULT 15.00,
    Status          NVARCHAR(20)  NOT NULL DEFAULT 'Pending'
                    CHECK (Status IN ('Pending','Confirmed','CheckedIn','CheckedOut','Cancelled')),
    SpecialRequests NVARCHAR(300) NULL,
    ActualCheckIn   DATETIME2 NULL,
    ActualCheckOut  DATETIME2 NULL,
    CreatedBy       INT NULL REFERENCES dbo.Users(UserID),
    CreatedAt       DATETIME2 NOT NULL DEFAULT SYSDATETIME(),
    CONSTRAINT CK_Bookings_Dates CHECK (CheckOutDate > CheckInDate)
);
CREATE INDEX IX_Bookings_Room_Dates ON dbo.Bookings (RoomID, CheckInDate, CheckOutDate);

CREATE TABLE dbo.Payments (
    PaymentID  INT IDENTITY(1,1) PRIMARY KEY,
    BookingID  INT NOT NULL REFERENCES dbo.Bookings(BookingID),
    Amount     DECIMAL(10,2) NOT NULL CHECK (Amount > 0),
    Method     NVARCHAR(20)  NOT NULL
               CHECK (Method IN ('Cash','Card','MobileMoney','BankTransfer')),
    Reference  NVARCHAR(50)  NULL,
    PaidAt     DATETIME2 NOT NULL DEFAULT SYSDATETIME(),
    ReceivedBy INT NULL REFERENCES dbo.Users(UserID)
);
GO

-- Sample data
INSERT INTO dbo.RoomTypes (Name, Description, PricePerNight, Capacity) VALUES
('Standard Twin',   '2 single beds',      420.00,  2),
('Deluxe King',     '1 king bed',         650.00,  2),
('Family Room',     '1 king, 2 single',   820.00,  4),
('Executive Suite', '1 king bed, lounge', 1200.00, 2);

INSERT INTO dbo.Rooms (RoomNumber, Floor, RoomTypeID) VALUES
('101',1,1),('102',1,1),('103',1,2),('104',1,2),
('201',2,1),('202',2,1),('203',2,2),('204',2,2),('205',2,2),('206',2,3),
('301',3,3),('302',3,3),('305',3,4),('401',4,4),('402',4,4);
GO