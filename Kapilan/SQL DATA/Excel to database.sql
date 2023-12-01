use Training2023

select * from Excel_import

Create table Excel_Export
(SNo int ,
CandidateName varchar(30),
FatherName varchar(30),
MotherName varchar(30),
IsExServiceMan int,
IsAdHocTeacher int,
IsDisabled int,
Category varchar(30),
RollNo varchar(30),
District varchar(30),
OutofState varchar(30),
DateofInterview varchar(50),
ReportingTime varchar(50),
InterviewSubBoard int,
Venue varchar(50))

create procedure Excel_Data
@SNo int,
@CandidateName varchar(30),
@Fathername varchar(30),
@MotherName varchar(30),
@IsExServiceMan int,
@IsAdHocTeacher int,
@IsDisabled int,
@Category varchar(30),
@RollNo varchar(30),
@District varchar(30),
@OutofState varchar(30),
@DateofInterview varchar(50),
@ReportingTime varchar(50),
@InterviewSubBoard int,
@Venue varchar(50)

AS
BEGIN  
set nocount on
 
insert into Excel_import(SNo,CandidateName,FatherName,MotherName,IsExServiceMan,IsAdHocTeacher,
 IsDisabled,Category,RollNo,District,OutofState,DateofInterview,ReportingTime,InterviewSubBoard,Venue)
  Values(@SNo,@CandidateName,@Fathername,@MotherName,@IsExServiceMan,@IsAdHocTeacher,
 @IsDisabled,@Category,@RollNo,@District,@OutofState,@DateofInterview,@ReportingTime,@InterviewSubBoard,@Venue)

End;

EXEC Excel_Data