CREATE PROCEDURE [dbo].[SP_Check_User]
	@Username nvarchar(50),
	@Password nvarchar(50)
AS
	IF EXISTS ((SELECT * FROM Tbl_User WHERE username = @Username AND password = @Password))
	BEGIN
		SELECT 'TRUE'
	END
	ELSE
	BEGIN
		SELECT 'FALSE'
	END
RETURN 0
