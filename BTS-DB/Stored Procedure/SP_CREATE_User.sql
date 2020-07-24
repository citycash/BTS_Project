CREATE PROCEDURE [dbo].[SP_Add_Shopping]
	@Name nvarchar(50),
	@CreatedDate datetime
AS
	DECLARE @MyTableVar table([ID] [int])
	INSERT INTO Tbl_Shopping(Name, CreatedDate)
	OUTPUT inserted.ID INTO @MyTableVar
	VALUES (@Name, @CreatedDate)
	SELECT ID from @MyTableVar --return Last ID
	--Get All
	SELECT * FROM Tbl_Shopping
	WHERE Id = (SELECT ID FROM @MyTableVar)
RETURN 0
