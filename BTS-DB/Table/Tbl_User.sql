CREATE TABLE [dbo].[Tbl_User]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Username] NVARCHAR(50) NULL, 
    [Email] NVARCHAR(50) NULL, 
    [Password] NVARCHAR(MAX) NULL, 
    [Address] NVARCHAR(MAX) NULL, 
    [City] NVARCHAR(MAX) NULL, 
    [Country] NVARCHAR(50) NULL, 
    [Name] NVARCHAR(50) NULL, 
    [PostCode] NVARCHAR(50) NULL, 
    [Phone] NVARCHAR(50) NULL
)
