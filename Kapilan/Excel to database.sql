use Training2023

select * from Excel_Export
select * from Excel_Export1


truncate table Excel_Export
drop table Excel_Export


Create table Excel_Export
(SNo int ,
CandidateName varchar(100),
FatherName varchar(100),
MotherName varchar(100),
IsExServiceMan int,
IsAdHocTeacher int,
IsDisabled int,
Category varchar(100),
RollNo int,
District varchar(100),
OutofState varchar(100),
DateofInterview varchar(100),
ReportingTime varchar(100),
InterviewSubBoard int,
Venue varchar(150))

Alter procedure Excel_Data
@SNo int,
@CandidateName varchar(100),
@FatherName varchar(100),
@MotherName varchar(100),
@IsExServiceMan int,
@IsAdHocTeacher int,
@IsDisabled int,
@Category varchar(100),
@RollNo int,
@District varchar(100),
@OutofState varchar(100),
@DateofInterview varchar(100),
@ReportingTime varchar(100),
@InterviewSubBoard int,
@Venue varchar(150)

AS
BEGIN  
set nocount on
 
insert into Excel_Export(SNo,CandidateName,FatherName,MotherName,IsExServiceMan,IsAdHocTeacher,
 IsDisabled,Category,RollNo,District,OutofState,DateofInterview,ReportingTime,InterviewSubBoard,Venue)
  Values(@SNo,@CandidateName,@FatherName,@MotherName,@IsExServiceMan,@IsAdHocTeacher,
 @IsDisabled,@Category,@RollNo,@District,@OutofState,@DateofInterview,@ReportingTime,@InterviewSubBoard,@Venue)

End;

EXEC Excel_Data

Create table Excel_Export1
(SNo int ,
CandidateName varchar(100),
FatherName varchar(100),
MotherName varchar(100),
IsExServiceMan int,
IsAdHocTeacher int,
IsDisabled int,
Category varchar(100),
RollNo int,
District varchar(100),
OutofState varchar(100),
DateofInterview varchar(100),
ReportingTime varchar(100),
InterviewSubBoard int,
Venue varchar(150))

Create procedure Excel_Data1
@SNo int,
@CandidateName varchar(100),
@FatherName varchar(100),
@MotherName varchar(100),
@IsExServiceMan int,
@IsAdHocTeacher int,
@IsDisabled int,
@Category varchar(100),
@RollNo int,
@District varchar(100),
@OutofState varchar(100),
@DateofInterview varchar(100),
@ReportingTime varchar(100),
@InterviewSubBoard int,
@Venue varchar(150)

AS
BEGIN  
set nocount on
 
insert into Excel_Export1(SNo,CandidateName,FatherName,MotherName,IsExServiceMan,IsAdHocTeacher,
 IsDisabled,Category,RollNo,District,OutofState,DateofInterview,ReportingTime,InterviewSubBoard,Venue)
  Values(@SNo,@CandidateName,@FatherName,@MotherName,@IsExServiceMan,@IsAdHocTeacher,
 @IsDisabled,@Category,@RollNo,@District,@OutofState,@DateofInterview,@ReportingTime,@InterviewSubBoard,@Venue)

End;

EXEC Excel_Data