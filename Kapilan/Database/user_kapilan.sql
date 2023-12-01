CREATE TABLE [dbo].[user_kapilan]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FirstName] VARCHAR(100) NULL, 
    [LastName] VARCHAR(100) NULL, 
    [EmailId] INT Foreign key References [dbo].[email_kapilan](Email_ID) NULL, 
    [MobileNumberId] INT Foreign key References [dbo].[mobile_kapilan](Mobile_ID) NULL, 
    [Age] INT NULL, 
    [DOB] DATETIME NULL, 
    [AddressId] INT Foreign key References [dbo].[user_address] (Address_ID) NULL, 
    [PostalCode] INT NULL, 
    [RoleId] INT Foreign key References [dbo].[user_role] (Role_ID) NULL, 
    [LocationId] INT Foreign key References [dbo].[user_location](Location_ID) NULL,
    [Password] VARCHAR(100) NULL,
    [CreatedDate] DATETIME NULL, 
    [ModifiedDate] DATETIME NULL, 
    [IsActive] BIT NULL
)
