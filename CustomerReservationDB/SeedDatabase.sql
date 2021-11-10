/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/



SET IDENTITY_INSERT [dbo].[Employees] ON
INSERT INTO [dbo].[Employees] ([EmployeeId], [EmployeeName], [Role]) VALUES (1, N'Isaias', N'Staff')
INSERT INTO [dbo].[Employees] ([EmployeeId], [EmployeeName], [Role]) VALUES (2, N'Sphurti', N'Administrator')
INSERT INTO [dbo].[Employees] ([EmployeeId], [EmployeeName], [Role]) VALUES (3, N'Abhisek', N'Administrator')
SET IDENTITY_INSERT [dbo].[Employees] OFF
GO



SET IDENTITY_INSERT [dbo].[Customers] ON
insert into [dbo].[Customers] ([CustomerId], [FirstName], [LastName], [PhoneNumber], [BillingAddress], [DOB]) values (1, N'Vaclav', N'Chirm', N'1044516087', N'647 Algoma Trail', '11/25/1989')
insert into [dbo].[Customers] ([CustomerId], [FirstName], [LastName], [PhoneNumber], [BillingAddress], [DOB]) values (2, N'Weber', N'Carrol', N'2793403172', N'778 Barby Park', '4/8/1987')
insert into [dbo].[Customers] ([CustomerId], [FirstName], [LastName], [PhoneNumber], [BillingAddress], [DOB]) values (3, N'Reube', N'Eilert', N'4561157945', N'73 Bunting Drive', '7/14/1990')
insert into [dbo].[Customers] ([CustomerId], [FirstName], [LastName], [PhoneNumber], [BillingAddress], [DOB]) values (4, N'Etty', N'Kirley', N'3802551109', N'5251 Manitowish Circle', '11/30/1996')
insert into [dbo].[Customers] ([CustomerId], [FirstName], [LastName], [PhoneNumber], [BillingAddress], [DOB]) values (5, N'Delila', N'Huckel', N'6563842375', N'8630 Vidon Parkway', '5/20/1988')
insert into [dbo].[Customers] ([CustomerId], [FirstName], [LastName], [PhoneNumber], [BillingAddress], [DOB]) values (6, N'Cass', N'Aronovich', N'7236792336', N'925 School Park', '3/4/1995')
insert into [dbo].[Customers] ([CustomerId], [FirstName], [LastName], [PhoneNumber], [BillingAddress], [DOB]) values (7, N'Erek', N'De Simone', N'9652807448', N'3373 Steensland Drive', '9/30/1994')
insert into [dbo].[Customers] ([CustomerId], [FirstName], [LastName], [PhoneNumber], [BillingAddress], [DOB]) values (8, N'Loren', N'Hilhouse', N'4153877218', N'9 Chive Point', '2/28/1999')
insert into [dbo].[Customers] ([CustomerId], [FirstName], [LastName], [PhoneNumber], [BillingAddress], [DOB]) values (9, N'Wyndham', N'Brydon', N'1408814027', N'16686 Dayton Point', '7/1/1991')
insert into [dbo].[Customers] ([CustomerId], [FirstName], [LastName], [PhoneNumber], [BillingAddress], [DOB]) values (10, N'Yulma', N'Wayland', N'5302859334', N'36 Pepper Wood Plaza', '12/29/1980')
SET IDENTITY_INSERT [dbo].[Customers] OFF
GO

SET IDENTITY_INSERT [dbo].[RoomType] ON
insert into [dbo].[RoomType] ([RoomTypeId], [Name], [Price], [NumberOfBeds], [BedSize],[NumberOfOccupants]) values (1, N'Economic', 45, 1, N'Queen',1)
insert into [dbo].[RoomType] ([RoomTypeId], [Name], [Price], [NumberOfBeds], [BedSize],[NumberOfOccupants]) values (2, N'Normal', 75, 2, N'King',2)
insert into [dbo].[RoomType] ([RoomTypeId], [Name], [Price], [NumberOfBeds], [BedSize],[NumberOfOccupants]) values (3, N'Deluxe', 125, 3, N'King',4)
SET IDENTITY_INSERT [dbo].[RoomType] OFF
GO


SET IDENTITY_INSERT [dbo].[Rooms] ON
insert into [dbo].[Rooms] (RoomId, RoomStatus, RoomTypeId) values (1, N'Available', 1)
insert into [dbo].[Rooms] (RoomId, RoomStatus, RoomTypeId) values (2, N'Occupied', 2)
insert into [dbo].[Rooms] (RoomId, RoomStatus, RoomTypeId) values (3, N'Occupied', 1)
insert into [dbo].[Rooms] (RoomId, RoomStatus, RoomTypeId) values (4, N'Available', 3)
insert into [dbo].[Rooms] (RoomId, RoomStatus, RoomTypeId) values (5, N'Available', 3)
insert into [dbo].[Rooms] (RoomId, RoomStatus, RoomTypeId) values (6, N'Occupied', 2)
insert into [dbo].[Rooms] (RoomId, RoomStatus, RoomTypeId) values (7, N'Available', 2)
insert into [dbo].[Rooms] (RoomId, RoomStatus, RoomTypeId) values (8, N'Available', 1)
insert into [dbo].[Rooms] (RoomId, RoomStatus, RoomTypeId) values (9, N'Occupied', 1)
insert into [dbo].[Rooms] (RoomId, RoomStatus, RoomTypeId) values (10, N'Occupied', 1)
SET IDENTITY_INSERT [dbo].[Rooms] OFF
GO

SET IDENTITY_INSERT [dbo].[Reservations] ON
insert into [dbo].[Reservations] (ReservationId, CheckInDate, CheckOutDate, FoodService, RoomId, EmployeeId, CustomerId) values (1, '10/31/2020', '11/10/2020', 'N', 3, 1, 4);
insert into [dbo].[Reservations] (ReservationId, CheckInDate, CheckOutDate, FoodService, RoomId, EmployeeId, CustomerId) values (2, '10/5/2020', '10/15/2020', 'N', 6, 1, 2);
insert into [dbo].[Reservations] (ReservationId, CheckInDate, CheckOutDate, FoodService, RoomId, EmployeeId, CustomerId) values (3, '8/21/2020', '8/31/2020', 'N', 9, 3, 1);
insert into [dbo].[Reservations] (ReservationId, CheckInDate, CheckOutDate, FoodService, RoomId, EmployeeId, CustomerId) values (4, '5/29/2020', '6/8/2020', 'Y', 10, 2, 6);
insert into [dbo].[Reservations] (ReservationId, CheckInDate, CheckOutDate, FoodService, RoomId, EmployeeId, CustomerId) values (5, '3/18/2020', '3/28/2020', 'N', 2, 3, 7);
SET IDENTITY_INSERT [dbo].[Reservations] OFF
GO



