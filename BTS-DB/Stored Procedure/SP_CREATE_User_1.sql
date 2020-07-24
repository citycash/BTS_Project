CREATE PROCEDURE [dbo].[SP_CREATE_User]
	@Username nvarchar(50) = '',
	@Email nvarchar(50) = '',
	@Password nvarchar(50) = '',
	@Phone nvarchar(50) = '',
	@Address nvarchar(50) = '',
	@City nvarchar(50) = '',
	@Country nvarchar(50) = '',
	@Name nvarchar(50) = '',
	@PostCode nvarchar(50) = ''
AS
	DECLARE @MyTableVar table([ID] [int])
	INSERT INTO Tbl_User(Username, Email, Password, Phone, Address, City, Country, Name, PostCode)
	OUTPUT inserted.ID INTO @MyTableVar
	VALUES (@Username, @Email, @Password, @Phone, @Address, @City, @Country, @Name, @PostCode)
	SELECT ID from @MyTableVar --return Last ID
	--Get All
	SELECT Email, Username FROM Tbl_User
	WHERE Id = (SELECT ID FROM @MyTableVar)
RETURN 0
