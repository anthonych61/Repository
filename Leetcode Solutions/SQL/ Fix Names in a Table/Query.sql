/* Write your T-SQL query statement below */
SELECT user_id, UPPER(SUBSTRING(name, 1, 1)) + LOWER(SUBSTRING(name, 2, LEN(name))) As name
FROM Users
ORDER BY user_id