--IN Operator, Shorthand for OR Conditional

SELECT * FROM Customers
WHERE Country IN ('Norway', 'France'); 

SELECT * FROM Customers
WHERE Country NOT IN ('Norway', 'France');