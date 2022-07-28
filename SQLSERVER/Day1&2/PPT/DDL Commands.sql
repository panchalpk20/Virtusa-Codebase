

-- DATA DEFINITION LANGUAGE COMMANDS (DDL):

-- Examples:

-- CREATE - To create objects in the database 
-- ALTER - Alters the structure of the database 
-- DROP - Delete objects from the database 
-- TRUNCATE - Removes all records from a table, including all spaces allocated 
-- for the records are removed 
-- COMMENT - Adds comment to the data dictionary 
-- RENAME - Renames an object


-- Creating a new database
CREATE DATABASE TrainingDB
GO

-- Creating a new table
CREATE TABLE ParticipantList
(
	ParticipantID BIGINT IDENTITY(100,-1) NOT NULL,
	FirstName VARCHAR(30),
	LastName VARCHAR(30),
	OfficialEmail VARCHAR(100)
)
GO

-- Deleting all rows from the ParticipantList table
TRUNCATE TABLE ParticipantList
GO

-- Deleting table from the database
DROP TABLE ParticipantList
GO

-- Deleting the database
DROP DATABASE TrainingDB
GO

/*** End of script ***/
insert into ParticipantList(Firstname,LastName) values('aa','bb')
select * from Participantlist