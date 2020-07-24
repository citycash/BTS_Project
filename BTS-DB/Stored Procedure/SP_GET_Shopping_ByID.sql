CREATE PROCEDURE [dbo].[SP_GET_Shopping_ByID]
	@ID int
AS
	SELECT * FROM Tbl_Shopping WHERE Id = @ID
RETURN 0
