--Functions (Min, Max, Count, Average, Sum)

SELECT MIN(Price)
FROM Products;

SELECT MAX(Price)
FROM Products;

SELECT COUNT(*)
FROM Products
WHERE Price = 18;

SELECT AVG(Price)
FROM Products;

SELECT SUM(Price) 
FROM Products;
