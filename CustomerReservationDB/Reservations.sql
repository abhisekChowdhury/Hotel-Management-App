CREATE TABLE [dbo].[Reservations]
(
	[ReservationId] TINYINT IDENTITY (1, 1) NOT NULL, 
    [CheckInDate] DATE NOT NULL, 
    [CheckOutDate] DATE NOT NULL, 
    [FoodService] NCHAR(1) NULL,   
    [RoomId] TINYINT NOT NULL, 
    [EmployeeId] TINYINT NOT NULL, 
    [CustomerId] TINYINT NOT NULL, 
    CONSTRAINT [PK_ReservationId] PRIMARY KEY CLUSTERED ([ReservationId] ASC),
    CONSTRAINT [FK_ReservationId_Rooms_RoomId] FOREIGN KEY ([RoomId]) REFERENCES [Rooms] ([RoomId]) on delete cascade,
    CONSTRAINT [FK_ReservationId_Employees_EmployeeId] FOREIGN KEY ([EmployeeId]) REFERENCES [Employees] ([EmployeeId]) on delete cascade,
    CONSTRAINT [FK_ReservationId_Customers_CustomerId] FOREIGN KEY ([CustomerId]) REFERENCES [Customers] ([CustomerId])  on delete cascade
        
);

