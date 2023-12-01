--Aggregate Function

--Aggregate functions are used to summarize a set of values and return a single value.
--Common aggregate functions include COUNT, SUM, AVG, MIN and MAX.

SELECT COUNT(IsAdHocTeacher) FROM Excel_Export;

SELECT SUM(IsAdHocTeacher) FROM Excel_Export;

SELECT AVG(SNo) FROM Excel_Export;

SELECT MIN(SNo) FROM Excel_Export;

SELECT Max(SNo) FROM Excel_Export;

--Date

SELECT GETDATE();
 
--String

SELECT Lower(CandidateName)
FROM Excel_Export;
