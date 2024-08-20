SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE uspDeleteOrder
	@OrderID int,
	@responseMessage NVARCHAR(250) OUTPUT
AS
BEGIN
	SET NOCOUNT ON;

	BEGIN TRY
		DECLARE @ProductList table
		(
			ProductID int,
			Quntity int
		)

		INSERT INTO @ProductList
			SELECT
				ProductID,
				Quantity
			FROM Sales
			WHERE OrderID = @OrderID

		UPDATE Products 
		SET ProductQuantity += 
			(
				SELECT 
					PL.Quntity 
				FROM @ProductList AS PL 
				WHERE PL.ProductID = Products.ProductID
			)
		WHERE EXISTS 
			(
				SELECT 
					PL.Quntity 
				FROM @ProductList AS PL 
				WHERE PL.ProductID = Products.ProductID
			)

		DELETE FROM Orders WHERE OrderID = @OrderID


		DELETE FROM Sales WHERE OrderID = @OrderID

		SET @responseMessage = 'Заказ успешно удален!'

		END TRY
		BEGIN CATCH
			SET @responseMessage=ERROR_MESSAGE() 
		END CATCH
END
GO
