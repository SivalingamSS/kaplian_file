use Training2023

select * from API_DB
select * from API_DB_FK

 --CREATE
create procedure API_DB_CREATE
@staffid int,
@staffname varchar(30),
@staffage int,
@staffcity varchar(40),
@staffmobnumber int,
@emailid varchar(30),
@address_id varchar(30)
AS
begin
set nocount on

insert into API_DB(staff_name,staff_age,staff_city,staff_mob_number) values (@staffname,@staffage,@staffcity,@staffmobnumber);
declare @id int = scope_identity();
insert into API_DB_FK(email_id,address,staff_id) values (@emailid,@address_id,@id);

end
go

--GET_SP
create procedure API_DB_GET
as
begin
set nocount on;
select get1.staff_id,get1.staff_name,get1.staff_age,get1.staff_city,get1.staff_mob_number from API_DB get1
inner join API_DB_FK get2 on get1.staff_id = get2.staff_id
end;
exec API_DB_GET

Alter procedure API_DB_GET
as
begin
set nocount on;
select get1.staff_id,get1.staff_name,get1.staff_age,get1.staff_city,get1.staff_mob_number,get2.work_id,get2.email_id,get2.address from API_DB get1
inner join API_DB_FK get2 on get1.staff_id = get2.staff_id
end;

--POST_SP
create procedure API_DB_POST
@staffid int,
@staffname varchar(30),
@staffage int,
@staffcity varchar(40),
@staffmobnumber int,
@emailid varchar(30),
@address_id varchar(30)
AS
begin
set nocount on;
insert into API_DB(staff_name,staff_age,staff_city,staff_mob_number) values (@staffname,@staffage,@staffcity,@staffmobnumber)
declare @id int = scope_identity();
insert into API_DB_FK(email_id,address,staff_id) values (@emailid,@address_id,@id)
end;

Alter procedure API_DB_POST
@staff_id int,
@staff_name varchar(30),
@staff_age int,
@staff_city varchar(40),
@staff_mob_number int,
@email_id varchar(30),
@address varchar(30)
AS
begin
set nocount on;
insert into API_DB(staff_name,staff_age,staff_city,staff_mob_number) values (@staff_name,@staff_age,@staff_city,@staff_mob_number)
declare @id int = scope_identity();
insert into API_DB_FK(email_id,address,staff_id) values(@email_id,@address,@id)
end;


--PUT_SP
Alter procedure API_DB_PUT
@staff_id int = null,
@staff_name varchar(30) = null,
@staff_age int = nul,
@staff_city varchar(30) = null,
@staff_mob_number int = null,
@email_id varchar(30) = null,
@address varchar(30) = null
As
begin
update API_DB set

staff_name = @staff_name,
staff_age = @staff_age,
staff_city = @staff_city,
staff_mob_number = @staff_mob_number	
where staff_id = @staff_id

update API_DB_FK set

email_id = @email_id,
address = @address
where staff_id = @staff_id
end;


--DELETE_SP
alter procedure API_DB_DELETE 
@staff_id int
as 
begin 
delete  from  API_DB_FK where  staff_id= @staff_id
delete  from API_DB where staff_id=@staff_id
end;
