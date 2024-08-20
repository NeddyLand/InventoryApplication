SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspDeleteUser]
	@pUserID int,
	@responseMessage NVARCHAR(250) OUTPUT
AS
BEGIN
	SET NOCOUNT ON;

	BEGIN TRY
		IF @pUserID = 1
			SET @responseMessage = 'Нельзя удалить данного пользователя!'
		ELSE
			DELETE FROM Users WHERE UserID = @pUserID
	END TRY
	BEGIN CATCH
        SET @responseMessage=ERROR_MESSAGE() 
    END CATCH
END
GO
