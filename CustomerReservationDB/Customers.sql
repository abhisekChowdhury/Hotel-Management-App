CREATE TABLE [dbo].[Customers]
(
	[CustomerId] TINYINT IDENTITY (1, 1) NOT NULL, 
    [FirstName] NCHAR(30) NOT NULL, 
    [LastName] NCHAR(30) NULL, 
    [PhoneNumber] NCHAR(15) NULL, 
    [BillingAddress] NCHAR(50) NULL, 
    [DOB] DATETIME2 NULL,
    CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED ([CustomerId] ASC)
);

GO