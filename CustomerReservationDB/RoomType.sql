CREATE TABLE [dbo].[RoomType]
(
	[RoomTypeId] TINYINT IDENTITY (1, 1) NOT NULL,
    [Name] NCHAR(20) NOT NULL, 
    [Price] INT NOT NULL, 
    [NumberOfBeds] TINYINT NULL, 
    [BedSize] NCHAR(10) NULL, 
    [NumberOfOccupants] TINYINT NULL,
    CONSTRAINT [PK_RoomTypeId] PRIMARY KEY CLUSTERED ([RoomTypeId] ASC),
)
