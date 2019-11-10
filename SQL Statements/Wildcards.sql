--Wildcards


SELECT * FROM Customers --City starts with an a
WHERE City LIKE 'a%';

SELECT * FROM Customers --City ends with an a
WHERE City LIKE '%a';

SELECT * FROM Customers --City contains an a
WHERE City LIKE '%a%';

SELECT * FROM Customers --City starts with an a and ends with a b
WHERE City LIKE 'a%b';

SELECT * FROM Customers --Second letter starts with a
WHERE City LIKE '_a%';

SELECT * FROM Customers --First letter is an a c or an s
WHERE City LIKE '[acs]%';

SELECT * FROM Customers --First letter is between a-f
WHERE City like '[a-f]%'; 

SELECT * FROM Customers --First letter is not a c or an f
WHERE City LIKE '[^acf]$';
