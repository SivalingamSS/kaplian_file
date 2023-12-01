use Training2023


create PROCEDURE  Db_Procedures
@CUSTOMER_ID INT , @CUSTOMER_NAME varchar(50),@CUSTOMER_AGE int ,@CUSTOMER_ADDRESS varchar(50),@GENDER varchar(50),@EMAIL_ID varchar (50)
AS
begin 
set nocount on ;
insert into customer_db (CUSTOMER_NAME,CUSTOMER_AGE,CUSTOMER_ADDRESS) values (@CUSTOMER_NAME,@CUSTOMER_AGE,@CUSTOMER_ADDRESS);
DECLARE @ID INT=scope_Identity();
insert into SELLER_db(GENDER,EMAIL_ID,CUSTOMER_ID) values (@GENDER,@EMAIL_ID,@ID); 
	
end
GO


 DROP  PROCEDURE Db_Procedures ;

select * from customer_db
select * from SELLER_db

create procedure Db_GetProcedure 
AS
begin 
set nocount on ;
select  sp.CUSTOMER_ID,sp.CUSTOMER_NAME,sp.CUSTOMER_AGE,sp.CUSTOMER_ADDRESS,s.EMAIL_ID,s.GENDER from customer_db sp
inner join SELLER_db s on sp.CUSTOMER_ID=s.CUSTOMER_ID
end
exec Db_GetProcedure

create procedure Db_Deleteprocedure @CUSTOMER_ID int

as begin 

delete  from customer_db where CUSTOMER_ID=@CUSTOMER_ID
delete  from  SELLER_db where  CUSTOMER_ID= @CUSTOMER_ID
end

exec Db_Deleteprocedure

create procedure Db_Puteprocedure @CUSTOMER_ID INT=null , @CUSTOMER_NAME varchar(50) =null,@CUSTOMER_AGE int=null ,@CUSTOMER_ADDRESS varchar(50)=null,@GENDER varchar(50)=null,@EMAIL_ID varchar (50) =null

as begin 
UPDATE customer_db SET  

			CUSTOMER_NAME = @CUSTOMER_NAME, 
		    CUSTOMER_AGE = @CUSTOMER_AGE,  
			CUSTOMER_ADDRESS = @CUSTOMER_ADDRESS 
			
			
		WHERE CUSTOMER_ID = @CUSTOMER_ID 
UPDATE SELLER_db SET  
           GENDER=@GENDER,
		   EMAIL_ID=@EMAIL_ID
		   WHERE CUSTOMER_ID = @CUSTOMER_ID
end
drop procedure Db_Puteprocedure






