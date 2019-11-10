--BOOLEAN OPERATORS

SELECT * FROM Customers
WHERE CustomerID = 32;

SELECT * FROM Customers
WHERE City = 'Berlin'
AND PostalCode= 12209;

SELECT * FROM Customers
WHERE City = 'Berlin'
OR City = 'London';

SELECT * FROM Customers
WHERE City = 'Berlin'
OR CITY = 'London';
