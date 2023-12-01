--1.DQL

--DQL is a portion of a SQL statement that allows you to get and organise data from a database.
--You can use the SELECT command to extract data from a database


SELECT * FROM [dbo].[Excel_Export];

SELECT CandidateName,Venue
  FROM [dbo].[Excel_Export];

SELECT DISTINCT CandidateName FROM Excel_Export;

SELECT * FROM Excel_Export
WHERE RollNo='271901330';

SELECT * FROM Excel_Export
WHERE SNo < 100;

SELECT * FROM Excel_Export
ORDER BY SNo DESC;

SELECT * FROM Excel_Export
ORDER BY SNo ASC;

SELECT CandidateName
FROM Excel_Export
WHERE CandidateName IS NULL;

SELECT CandidateName
FROM Excel_Export
WHERE CandidateName IS NOT NULL;

SELECT TOP 3 * FROM Excel_Export;