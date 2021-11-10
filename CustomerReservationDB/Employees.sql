CREATE TABLE [dbo].[Employees]
(
	[EmployeeId] TINYINT IDENTITY (1, 1) NOT NULL,
    [EmployeeName] NCHAR(50) NULL, 
    [Role] NCHAR(15) NULL, 
    CONSTRAINT [PK_Employees] PRIMARY KEY ([EmployeeId])
);


GO