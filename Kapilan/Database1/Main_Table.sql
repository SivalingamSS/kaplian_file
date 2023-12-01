CREATE TABLE [dbo].[Main_Table]
(
	[ID] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [FirstName] VARCHAR(50) NULL, 
    [LastName] VARCHAR(50) NULL, 
    [Email_ID] INT NULL FOREIGN KEY REFERENCES [dbo].[Main_Email](Id), 
    [Mobile_ID]INT NULL FOREIGN KEY REFERENCES [dbo].[Main_Mobile](Id), 
    [Age] INT NULL, 
    [DOB] DATETIME NULL, 
    [Address_ID] INT NULL FOREIGN KEY REFERENCES [dbo].[Main_Address](Id), 
    [PostalCode] INT NULL, 
    [Role_ID] INT NULL FOREIGN KEY REFERENCES [dbo].[Main_Role](Id), 
    [Location_ID] INT NULL FOREIGN KEY REFERENCES [dbo].[Main_Location](Id), 
    [Password] VARCHAR(100) NULL,
    [CreatedDate] DATETIME NULL, 
    [IsActive] BIT NULL, 
)
