--Joins

SELECT * --All from first table, matching from second
FROM Orders
LEFT JOIN Customers
ON Orders.CustomerID = Customers.CustomerID;

SELECT * --Only matching rows
FROM Orders
INNER JOIN Customers 
ON Orders.CustomerID = Customers.CustomerID;

SELECT  * --Matching records from the first, all from the second 
FROM Orders
RIGHT JOIN Customers
ON Orders.CustomerID = Customers.CustomerID;