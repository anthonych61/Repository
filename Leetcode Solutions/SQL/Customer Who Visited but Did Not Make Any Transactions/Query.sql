/* Write your T-SQL query statement below */
SELECT customer_id, COUNT(customer_id) As count_no_trans
FROM Visits
LEFT JOIN Transactions ON Visits.visit_id = Transactions.visit_id
WHERE Transactions.visit_id IS NULL
GROUP BY customer_id