CREATE TABLE [dbo].[User]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [FirstName] NCHAR(10) NULL, 
    [LastName] NCHAR(10) NULL, 
    [EmailId] int Foreign Key References [dbo].[Email](id) NULL, 
    [MobileNumberID] int Foreign Key References [dbo].[Mobile](id) NULL, 
    [Age] NCHAR(10) NULL, 
    [DOB] NCHAR(10) NULL, 
    [AddressId] int Foreign Key References [dbo].[Address](id) NULL, 
    [PostalCode] NCHAR(10) NULL, 
    [RoleId] int Foreign Key References [dbo].[Role](id) NULL, 
)
