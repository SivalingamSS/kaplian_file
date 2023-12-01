CREATE TABLE Orders
(
orderid INT,
orderdate DATE,
customerName VARCHAR(100),
City VARCHAR(50),
amount MONEY
)

INSERT INTO Orders
SELECT 1,'01/01/2021','Mohan Gupta','Alwar',10000
UNION ALL
SELECT 2,'02/04/2021','Lucky Ali','Kota',20000
UNION ALL
SELECT 3,'03/02/2021','Raj Kumar','Jaipur',5000
UNION ALL
SELECT 4,'04/02/2021','Jyoti Kumari','Jaipur',15000
UNION ALL
SELECT 5,'05/03/2021','Rahul Gupta','Jaipur',7000
UNION ALL
SELECT 6,'06/04/2021','Mohan Kumar','Alwar',25000
UNION ALL
SELECT 7,'07/02/2021','Kashish Agarwal','Alwar',15000
UNION ALL
SELECT 8,'08/03/2021','Nagar Singh','Kota',2000
UNION ALL
SELECT 9,'09/04/2021','Anil KG','Alwar',1000
Go

Select * from Orders

SELECT City AS CustomerCity
,sum(amount) AS totalamount FROM Orders
GROUP BY city


SELECT City AS CustomerCity, CustomerName,amount,
max(amount) OVER(PARTITION BY city) TotalOrderAmount
FROM Orders
