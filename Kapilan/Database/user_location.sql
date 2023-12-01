CREATE TABLE [dbo].[user_location]
(
	[Location_ID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [City] VARCHAR(100) NULL, 
    [District] VARCHAR(100) NULL, 
    [State] VARCHAR(100) NULL
)
