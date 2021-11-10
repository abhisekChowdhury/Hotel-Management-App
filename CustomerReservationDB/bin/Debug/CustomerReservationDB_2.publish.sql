﻿/*
Deployment script for CustomerRervationDB

This code was generated by a tool.
Changes to this file may cause incorrect behavior and will be lost if
the code is regenerated.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "CustomerRervationDB"
:setvar DefaultFilePrefix "CustomerRervationDB"
:setvar DefaultDataPath "C:\Users\Sojara\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\"
:setvar DefaultLogPath "C:\Users\Sojara\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\"

GO
:on error exit
GO
/*
Detect SQLCMD mode and disable script execution if SQLCMD mode is not supported.
To re-enable the script after enabling SQLCMD mode, execute the following:
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'SQLCMD mode must be enabled to successfully execute this script.';
        SET NOEXEC ON;
    END


GO
USE [master];


GO

IF (DB_ID(N'$(DatabaseName)') IS NOT NULL) 
BEGIN
    ALTER DATABASE [$(DatabaseName)]
    SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE [$(DatabaseName)];
END

GO
PRINT N'Creating $(DatabaseName)...'
GO
CREATE DATABASE [$(DatabaseName)]
    ON 
    PRIMARY(NAME = [$(DatabaseName)], FILENAME = N'$(DefaultDataPath)$(DefaultFilePrefix)_Primary.mdf')
    LOG ON (NAME = [$(DatabaseName)_log], FILENAME = N'$(DefaultLogPath)$(DefaultFilePrefix)_Primary.ldf') COLLATE SQL_Latin1_General_CP1_CI_AS
GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET AUTO_CLOSE OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
USE [$(DatabaseName)];


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET ANSI_NULLS ON,
                ANSI_PADDING ON,
                ANSI_WARNINGS ON,
                ARITHABORT ON,
                CONCAT_NULL_YIELDS_NULL ON,
                NUMERIC_ROUNDABORT OFF,
                QUOTED_IDENTIFIER ON,
                ANSI_NULL_DEFAULT ON,
                CURSOR_DEFAULT LOCAL,
                CURSOR_CLOSE_ON_COMMIT OFF,
                AUTO_CREATE_STATISTICS ON,
                AUTO_SHRINK OFF,
                AUTO_UPDATE_STATISTICS ON,
                RECURSIVE_TRIGGERS OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET ALLOW_SNAPSHOT_ISOLATION OFF;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET READ_COMMITTED_SNAPSHOT OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET AUTO_UPDATE_STATISTICS_ASYNC OFF,
                PAGE_VERIFY NONE,
                DATE_CORRELATION_OPTIMIZATION OFF,
                DISABLE_BROKER,
                PARAMETERIZATION SIMPLE,
                SUPPLEMENTAL_LOGGING OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF IS_SRVROLEMEMBER(N'sysadmin') = 1
    BEGIN
        IF EXISTS (SELECT 1
                   FROM   [master].[dbo].[sysdatabases]
                   WHERE  [name] = N'$(DatabaseName)')
            BEGIN
                EXECUTE sp_executesql N'ALTER DATABASE [$(DatabaseName)]
    SET TRUSTWORTHY OFF,
        DB_CHAINING OFF 
    WITH ROLLBACK IMMEDIATE';
            END
    END
ELSE
    BEGIN
        PRINT N'The database settings cannot be modified. You must be a SysAdmin to apply these settings.';
    END


GO
IF IS_SRVROLEMEMBER(N'sysadmin') = 1
    BEGIN
        IF EXISTS (SELECT 1
                   FROM   [master].[dbo].[sysdatabases]
                   WHERE  [name] = N'$(DatabaseName)')
            BEGIN
                EXECUTE sp_executesql N'ALTER DATABASE [$(DatabaseName)]
    SET HONOR_BROKER_PRIORITY OFF 
    WITH ROLLBACK IMMEDIATE';
            END
    END
ELSE
    BEGIN
        PRINT N'The database settings cannot be modified. You must be a SysAdmin to apply these settings.';
    END


GO
ALTER DATABASE [$(DatabaseName)]
    SET TARGET_RECOVERY_TIME = 0 SECONDS 
    WITH ROLLBACK IMMEDIATE;


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET FILESTREAM(NON_TRANSACTED_ACCESS = OFF),
                CONTAINMENT = NONE 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET AUTO_CREATE_STATISTICS ON(INCREMENTAL = OFF),
                MEMORY_OPTIMIZED_ELEVATE_TO_SNAPSHOT = OFF,
                DELAYED_DURABILITY = DISABLED 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET QUERY_STORE (QUERY_CAPTURE_MODE = ALL, DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_PLANS_PER_QUERY = 200, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 367), MAX_STORAGE_SIZE_MB = 100) 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET QUERY_STORE = OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
        ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
        ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
        ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
        ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
        ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
        ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
        ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
    END


GO
IF fulltextserviceproperty(N'IsFulltextInstalled') = 1
    EXECUTE sp_fulltext_database 'enable';


GO
PRINT N'Creating [dbo].[Customers]...';


GO
CREATE TABLE [dbo].[Customers] (
    [CustomerId]     TINYINT       NOT NULL,
    [FirstName]      NCHAR (30)    NOT NULL,
    [LastName]       NCHAR (30)    NOT NULL,
    [PhoneNumber]    NCHAR (15)    NOT NULL,
    [BillingAddress] NCHAR (50)    NOT NULL,
    [DOB]            DATETIME2 (7) NOT NULL,
    CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED ([CustomerId] ASC)
);


GO
PRINT N'Creating [dbo].[Employees]...';


GO
CREATE TABLE [dbo].[Employees] (
    [EmployeeId]   TINYINT    IDENTITY (1, 1) NOT NULL,
    [EmployeeName] NCHAR (50) NULL,
    [Role]         NCHAR (15) NULL,
    CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED ([EmployeeId] ASC)
);


GO
PRINT N'Creating [dbo].[Reservations]...';


GO
CREATE TABLE [dbo].[Reservations] (
    [ReservationId] INT       NOT NULL,
    [CheckInDate]   DATE      NOT NULL,
    [CheckOutDate]  DATE      NOT NULL,
    [FoodService]   NCHAR (1) NULL,
    [RoomId]        TINYINT   NOT NULL,
    [EmployeeId]    TINYINT   NOT NULL,
    [CustomerId]    TINYINT   NOT NULL,
    CONSTRAINT [PK_ReservationId] PRIMARY KEY CLUSTERED ([ReservationId] ASC)
);


GO
PRINT N'Creating [dbo].[Rooms]...';


GO
CREATE TABLE [dbo].[Rooms] (
    [RoomId]       TINYINT        IDENTITY (1, 1) NOT NULL,
    [RoomStatus]   NVARCHAR (10)  NOT NULL,
    [NumberOfBeds] TINYINT        NOT NULL,
    [RoomType]     VARBINARY (10) NOT NULL,
    [RoomPrice]    INT            NOT NULL,
    [Amenities]    NCHAR (50)     NULL,
    CONSTRAINT [PK_Rooms] PRIMARY KEY CLUSTERED ([RoomId] ASC)
);


GO
PRINT N'Creating [dbo].[FK_ReservationId_Rooms_RoomId]...';


GO
ALTER TABLE [dbo].[Reservations]
    ADD CONSTRAINT [FK_ReservationId_Rooms_RoomId] FOREIGN KEY ([RoomId]) REFERENCES [dbo].[Rooms] ([RoomId]);


GO
PRINT N'Creating [dbo].[FK_ReservationId_Employees_EmployeeId]...';


GO
ALTER TABLE [dbo].[Reservations]
    ADD CONSTRAINT [FK_ReservationId_Employees_EmployeeId] FOREIGN KEY ([EmployeeId]) REFERENCES [dbo].[Employees] ([EmployeeId]);


GO
PRINT N'Creating [dbo].[FK_ReservationId_Customers_CustomerId]...';


GO
ALTER TABLE [dbo].[Reservations]
    ADD CONSTRAINT [FK_ReservationId_Customers_CustomerId] FOREIGN KEY ([CustomerId]) REFERENCES [dbo].[Customers] ([CustomerId]);


GO
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


/*
SET IDENTITY_INSERT [dbo].[Customers] ON
insert into [dbo].[Customers] (CustomerId, FirstName, LastName, PhoneNumber, BillingAddress, DOB) values (1, 'Vaclav', 'Chirm', '1044516087', '647 Algoma Trail', '11/25/1989');
insert into [dbo].[Customers] (CustomerId, FirstName, LastName, PhoneNumber, BillingAddress, DOB) values (2, 'Weber', 'Carrol', '2793403172', '778 Barby Park', '4/8/1987');
insert into [dbo].[Customers] (CustomerId, FirstName, LastName, PhoneNumber, BillingAddress, DOB) values (3, 'Reube', 'Eilert', '4561157945', '73 Bunting Drive', '7/14/1990');
insert into [dbo].[Customers] (CustomerId, FirstName, LastName, PhoneNumber, BillingAddress, DOB) values (4, 'Etty', 'Kirley', '3802551109', '5251 Manitowish Circle', '11/30/1996');
insert into [dbo].[Customers] (CustomerId, FirstName, LastName, PhoneNumber, BillingAddress, DOB) values (5, 'Delila', 'Huckel', '6563842375', '8630 Vidon Parkway', '5/20/1988');
insert into [dbo].[Customers] (CustomerId, FirstName, LastName, PhoneNumber, BillingAddress, DOB) values (6, 'Cass', 'Aronovich', '7236792336', '925 School Park', '3/4/1995');
insert into [dbo].[Customers] (CustomerId, FirstName, LastName, PhoneNumber, BillingAddress, DOB) values (7, 'Erek', 'De Simone', '9652807448', '3373 Steensland Drive', '9/30/1994');
insert into [dbo].[Customers] (CustomerId, FirstName, LastName, PhoneNumber, BillingAddress, DOB) values (8, 'Loren', 'Hilhouse', '4153877218', '9 Chive Point', '2/28/1999');
insert into [dbo].[Customers] (CustomerId, FirstName, LastName, PhoneNumber, BillingAddress, DOB) values (9, 'Wyndham', 'Brydon', '1408814027', '16686 Dayton Point', '7/1/1991');
insert into [dbo].[Customers] (CustomerId, FirstName, LastName, PhoneNumber, BillingAddress, DOB) values (10, 'Yulma', 'Wayland', '5302859334', '36 Pepper Wood Plaza', '12/29/1980');
SET IDENTITY_INSERT [dbo].[Customers] OFF
GO

SET IDENTITY_INSERT [dbo].[Rooms] ON
insert into [dbo].[Rooms] (RoomId, RoomStatus, NumberOfBeds, RoomType, RoomPrice) values (1, 'Occupaid', 1, 'Economic', 431);
insert into [dbo].[Rooms] (RoomId, RoomStatus, NumberOfBeds, RoomType, RoomPrice) values (2, 'Occupaid', 2, 'Deluxe', 242);
insert into [dbo].[Rooms] (RoomId, RoomStatus, NumberOfBeds, RoomType, RoomPrice) values (3, 'Occupaid', 4, 'Economic', 271);
insert into [dbo].[Rooms] (RoomId, RoomStatus, NumberOfBeds, RoomType, RoomPrice) values (4, 'Occupaid', 4, 'Economic', 251);
insert into [dbo].[Rooms] (RoomId, RoomStatus, NumberOfBeds, RoomType, RoomPrice) values (5, 'Occupaid', 4, 'Economic', 219);
insert into [dbo].[Rooms] (RoomId, RoomStatus, NumberOfBeds, RoomType, RoomPrice) values (6, 'Occupaid', 2, 'Economic', 278);
insert into [dbo].[Rooms] (RoomId, RoomStatus, NumberOfBeds, RoomType, RoomPrice) values (7, 'Occupaid', 4, 'Economic', 416);
insert into [dbo].[Rooms] (RoomId, RoomStatus, NumberOfBeds, RoomType, RoomPrice) values (8, 'Occupaid', 1, 'Economic', 293);
insert into [dbo].[Rooms] (RoomId, RoomStatus, NumberOfBeds, RoomType, RoomPrice) values (9, 'Occupaid', 1, 'Economic', 206);
insert into [dbo].[Rooms] (RoomId, RoomStatus, NumberOfBeds, RoomType, RoomPrice) values (10, 'Occupaid', 1, 'Economic', 356);
SET IDENTITY_INSERT [dbo].[Employees] OFF
GO

insert into [dbo].[Reservations] (ReservationId, CheckInDate, CheckOutDate, FoodService, RoomId, EmployeeId, CustomerId) values (1, '10/31/2020', '11/10/2020', 'N', 3, 1, 4);
insert into [dbo].[Reservations] (ReservationId, CheckInDate, CheckOutDate, FoodService, RoomId, EmployeeId, CustomerId) values (2, '10/5/2020', '10/15/2020', 'N', 6, 1, 2);
insert into [dbo].[Reservations] (ReservationId, CheckInDate, CheckOutDate, FoodService, RoomId, EmployeeId, CustomerId) values (3, '8/21/2020', '8/31/2020', 'N', 9, 3, 1);
insert into [dbo].[Reservations] (ReservationId, CheckInDate, CheckOutDate, FoodService, RoomId, EmployeeId, CustomerId) values (4, '5/29/2020', '6/8/2020', 'N', 10, 2, 6);
insert into [dbo].[Reservations] (ReservationId, CheckInDate, CheckOutDate, FoodService, RoomId, EmployeeId, CustomerId) values (5, '3/18/2020', '3/28/2020', 'N', 2, 3, 7);
GO
*/


/*example

SET IDENTITY_INSERT [dbo].[Departments] ON
INSERT INTO [dbo].[Departments] ([DepartmentId], [DepartmentCode], [DepartmentName]) VALUES (1, N'CSIS', N'Computing Studies')
INSERT INTO [dbo].[Departments] ([DepartmentId], [DepartmentCode], [DepartmentName]) VALUES (2, N'ACCT', N'Accounting')
INSERT INTO [dbo].[Departments] ([DepartmentId], [DepartmentCode], [DepartmentName]) VALUES (3, N'MKTG', N'Marketing')
INSERT INTO [dbo].[Departments] ([DepartmentId], [DepartmentCode], [DepartmentName]) VALUES (4, N'FINC', N'Finance')
SET IDENTITY_INSERT [dbo].[Departments] OFF
GO

SET IDENTITY_INSERT [dbo].[Students] ON
INSERT INTO [dbo].[Students] ([StudentId], [StudentFirstName], [StudentLastName], [DepartmentId]) VALUES (1, N'Svetlana', N'Rostov', 1)
INSERT INTO [dbo].[Students] ([StudentId], [StudentFirstName], [StudentLastName], [DepartmentId]) VALUES (2, N'Claire', N'Bloome', 2)
INSERT INTO [dbo].[Students] ([StudentId], [StudentFirstName], [StudentLastName], [DepartmentId]) VALUES (3, N'Sven', N'Baertschi', 2)
INSERT INTO [dbo].[Students] ([StudentId], [StudentFirstName], [StudentLastName], [DepartmentId]) VALUES (4, N'Cesar', N'Chavez', 4)
INSERT INTO [dbo].[Students] ([StudentId], [StudentFirstName], [StudentLastName], [DepartmentId]) VALUES (5, N'Debra', N'Manning', 1)
INSERT INTO [dbo].[Students] ([StudentId], [StudentFirstName], [StudentLastName], [DepartmentId]) VALUES (6, N'Fadi', N'Hadari', 2)
INSERT INTO [dbo].[Students] ([StudentId], [StudentFirstName], [StudentLastName], [DepartmentId]) VALUES (7, N'Hanyeng', N'Fen', 2)
INSERT INTO [dbo].[Students] ([StudentId], [StudentFirstName], [StudentLastName], [DepartmentId]) VALUES (8, N'Hugo', N'Victor', 4)
INSERT INTO [dbo].[Students] ([StudentId], [StudentFirstName], [StudentLastName], [DepartmentId]) VALUES (9, N'Lance', N'Armstrong', 2)
INSERT INTO [dbo].[Students] ([StudentId], [StudentFirstName], [StudentLastName], [DepartmentId]) VALUES (10, N'Terry', N'Matthews', 1)
INSERT INTO [dbo].[Students] ([StudentId], [StudentFirstName], [StudentLastName], [DepartmentId]) VALUES (11, N'Eugene', N'Fei', 4)
INSERT INTO [dbo].[Students] ([StudentId], [StudentFirstName], [StudentLastName], [DepartmentId]) VALUES (12, N'Michael', N'Thorson', 1)
INSERT INTO [dbo].[Students] ([StudentId], [StudentFirstName], [StudentLastName], [DepartmentId]) VALUES (13, N'Simon', N'Li', 1)
SET IDENTITY_INSERT [dbo].[Students] OFF
GO

SET IDENTITY_INSERT [dbo].[Courses] ON
INSERT INTO [dbo].[Courses] ([CourseId], [CourseNumber], [DepartmentId], [CourseName]) VALUES (1, 101, 1, N'Programming I')
INSERT INTO [dbo].[Courses] ([CourseId], [CourseNumber], [DepartmentId], [CourseName]) VALUES (2, 102, 1, N'Programming II')
INSERT INTO [dbo].[Courses] ([CourseId], [CourseNumber], [DepartmentId], [CourseName]) VALUES (3, 101, 2, N'Accounting I')
INSERT INTO [dbo].[Courses] ([CourseId], [CourseNumber], [DepartmentId], [CourseName]) VALUES (4, 102, 2, N'Accounting II')
INSERT INTO [dbo].[Courses] ([CourseId], [CourseNumber], [DepartmentId], [CourseName]) VALUES (5, 101, 4, N'Corporate Finance')
SET IDENTITY_INSERT [dbo].[Courses] OFF
GO

INSERT INTO [dbo].[StudentCourses] ([CourseId], [StudentId]) VALUES (1, 1)
INSERT INTO [dbo].[StudentCourses] ([CourseId], [StudentId]) VALUES (2, 1)
INSERT INTO [dbo].[StudentCourses] ([CourseId], [StudentId]) VALUES (5, 1)
INSERT INTO [dbo].[StudentCourses] ([CourseId], [StudentId]) VALUES (1, 2)
INSERT INTO [dbo].[StudentCourses] ([CourseId], [StudentId]) VALUES (3, 3)
GO
*/
GO

GO
DECLARE @VarDecimalSupported AS BIT;

SELECT @VarDecimalSupported = 0;

IF ((ServerProperty(N'EngineEdition') = 3)
    AND (((@@microsoftversion / power(2, 24) = 9)
          AND (@@microsoftversion & 0xffff >= 3024))
         OR ((@@microsoftversion / power(2, 24) = 10)
             AND (@@microsoftversion & 0xffff >= 1600))))
    SELECT @VarDecimalSupported = 1;

IF (@VarDecimalSupported > 0)
    BEGIN
        EXECUTE sp_db_vardecimal_storage_format N'$(DatabaseName)', 'ON';
    END


GO
PRINT N'Update complete.';


GO
