--Create, Alter, Drop, Truncate

CREATE DATABASE testDB --Creates a new database named testDB

DROP DATABASE testDB --Delete database named testDB

CREATE TABLE Persons --Creates a new table called Persons
(
  PersonID int,
  LastName varchar(255),
  FirstName varchar(255),
  Address varchar(255),
  City varchar(255) 
);

DROP TABLE Persons; --Deletes the Persons Table

TRUNCATE TABLE Persons; --Deletes all data inside the Persons table

ALTER TABLE Persons --Adds a column of type DATE called Birthday
ADD Birthday DATE;

ALTER TABLE Persons --Deletes column Birthday from the Persons table
DROP COLUMN Birthday;