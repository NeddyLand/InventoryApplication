CREATE VIEW V_Sales AS
SELECT
	S.SaleID,
	S.OrderID,
	S.FirstName,
	P.ProductName,
	S.Quantity,
	S.TotalPrice
FROM Sales AS S
INNER JOIN Products AS P
	ON P.ProductID = S.ProductID