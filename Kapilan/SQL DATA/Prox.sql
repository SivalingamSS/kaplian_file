Use Training2023

Alter procedure Main_Details(
@FirstName varchar(100),
@LastName varchar(100),
@Age int,
@PostalCode int,
@DOB Datetime,
@Password varchar(100),
@Address varchar(100),
@Email varchar(100),
@City varchar(100),
@State varchar(100),
@Country Varchar(100),
@MobileNumber varchar(50),
@Role Varchar(100),
@CreatedDate DateTime,
@IsActive bit)
as
Begin 
Set nocount on;

Insert Into Main_Address (Address) values (@Address);
Insert Into Main_Email (Email) values (@Email);
Insert Into Main_Location (City,State,Country) values (@City,@State,@Country);
Insert Into Main_Mobile (MobileNumber) values (@MobileNumber);
Insert Into Main_Role (Role) values (@Role);

DECLARE @ID INT = Scope_Identity();
Insert Into Main_Table(FirstName,LastName,Age,PostalCode,DOB,Password,Role_ID,Location_ID,Email_ID,Address_ID,Mobile_ID,CreatedDate,IsActive)values
(@FirstName,@LastName,@Age,@PostalCode,@DOB,@Password,@ID,@ID,@ID,@ID,@ID,GETUTCDATE(),@IsActive)

END;




SELECT * FROM Main_Address
SELECT * FROM Main_Email
SELECT * FROM Main_Location
SELECT * FROM Main_Mobile
SELECT * FROM Main_Table
SELECT * FROM Main_Role