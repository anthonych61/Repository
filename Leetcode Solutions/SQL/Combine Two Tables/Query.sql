/* Write your T-SQL query statement below */
SELECT firstName, lastName, city, state
FROM Person 
LEFT Join Address
ON Person.personId = Address.personId;