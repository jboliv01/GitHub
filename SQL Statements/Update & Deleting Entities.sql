--Updating and deleting entities


UPDATE Customers
SET City = 'Oslo';

UPDATE Customers
SET City = 'Oslo'
WHERE Country = 'Norway';

UPDATE Customers
SET City = 'Oslo',
Country = 'Norway'
WHERE CustomerID = 32;

DELETE FROM Customers
WHERE Country = 'Norway';

DELETE FROM Customers;