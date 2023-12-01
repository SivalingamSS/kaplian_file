use Training2023

Create table API_DB
(staff_id int primary key identity (1,1),
staff_name varchar(20),
staff_age int,
staff_city varchar(30),
staff_mob_number int)

Create table API_DB_FK
(work_id int primary key identity (1,1),
email_id varchar(40),
address varchar(50),
staff_id int foreign key references API_DB (staff_id))


select *from API_DB
select*from API_DB_FK