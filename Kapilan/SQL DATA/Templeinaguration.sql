use Training2023

Select * from Upload_Data

Create Table Upload_Data
(dev_name varchar(100),
mobile bigint);

Create Procedure SendData
@devname varchar(100),
@mobile bigint
AS
begin
set nocount on
insert into Upload_Data(dev_name,mobile) values (@devname,@mobile);
End;

exec SendData;