--Triggers

--A trigger is called a special procedure because it cannot be called directly like a stored procedure.
--The key distinction between the trigger and procedure is that a trigger is called automatically


--Create Table

CREATE table EmployeeT(  
Id INT PRIMARY KEY,  
first_name varchar(20),  
last_name varchar(20),  
address_ varchar(20),  
);

--Insert Value

insert into EmployeeT Values
(1,'Saravana','Vikram','Chennai'),
(2,'Vijay','Varma','Coimbatore')

--Check

select * from EmployeeT

--Create Audit Table

create table Employee_Audit(
Id int identity,
Audit_Action text)

--Create Triggers

CREATE TRIGGER insert_trigger
ON EmployeeT  
FOR Insert
AS  
BEGIN  
	Declare @Id int
	select @Id = Id from inserted
	insert into Employee_Audit
	values('New Employee With Id = ' + CAST(@Id AS VARCHAR(20)) + ' Is Added At ' + CAST(Getdate() As VARCHAR(30)))
END 

insert into EmployeeT Values
(3,'Pradeep','Antony','Salem')

select * from EmployeeT 
select * from Employee_Audit


