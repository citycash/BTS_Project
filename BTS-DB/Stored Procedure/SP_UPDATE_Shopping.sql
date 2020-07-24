CREATE PROCEDURE [dbo].[SP_UPDATE_Shopping]
	@ID int, 
	@Name nvarchar(50),
	@CreatedDate datetime
AS
	UPDATE Tbl_Shopping
	SET Name = @Name, CreatedDate = @CreatedDate
	WHERE Id = @ID

	SELECT * FROM Tbl_Shopping WHERE Id = @ID
RETURN 0
