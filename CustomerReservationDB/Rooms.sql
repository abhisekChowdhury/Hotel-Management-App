CREATE TABLE [dbo].[Rooms]
(
	[RoomId] TINYINT IDENTITY (1, 1) NOT NULL,
    [RoomStatus] NCHAR(10) NOT NULL,
    [RoomTypeId] TINYINT NOT NULL,
    CONSTRAINT [PK_Rooms] PRIMARY KEY CLUSTERED ([RoomId] ASC),
    CONSTRAINT [FK_RoomId_RoomType_RoomTypeId] FOREIGN KEY ([RoomTypeId]) REFERENCES [RoomType] ([RoomTypeId])
    
);