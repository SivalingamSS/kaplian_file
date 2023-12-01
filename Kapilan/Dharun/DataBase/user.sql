CREATE TABLE [dbo].[user]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [first_name] NCHAR(10) NULL, 
    [last_name] NCHAR(10) NULL, 
    [email_id] INT foreign key references [dbo].[emailid](id) NULL, 
    [mobile_no] INT foreign key references [dbo].[mobile](id) NULL, 
    [age] INT NULL, 
    [dob] DATE NULL, 
    [address] INT foreign key references [dbo].[address](id) NULL, 
    [postal_code] INT NULL, 
    [role_id]INT foreign key references [dbo].[role](id) NULL 
)
