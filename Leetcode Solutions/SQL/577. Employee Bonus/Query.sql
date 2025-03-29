/* Write your T-SQL query statement below */
SELECT name, bonus
FROM Employee e LEFT JOIN Bonus b ON e.empId = b.empId
WHERE b.bonus is NULL OR b.bonus < 1000