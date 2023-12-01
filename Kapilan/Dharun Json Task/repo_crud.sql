use Training2023

create table customer_db(CUSTOMER_ID int primary key identity,
CUSTOMER_NAME varchar(30),
CUSTOMER_AGE int,
CUSTOMER_ADDRESS varchar(30))

select*from customer_db
select*from SELLER_db

create table seller_db(SELLER_ID int primary key identity,
EMAIL_ID varchar(30),
GENDER varchar(30),
CUSTOMER_ID int foreign key references customer_db(CUSTOMER_ID))

