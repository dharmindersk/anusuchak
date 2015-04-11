CREATE PROCEDURE [dbo].[spInsertAccount] (
	@username nvarchar(50),
	@password nvarchar(50),
	@email nvarchar(50),
	@enabled bit
)

AS

SET NOCOUNT ON

INSERT INTO [Account] (
	[username],
	[password],
	[email],
	[enabled]
) VALUES (
	@username,
	@password,
	@email,
	@enabled
)

SELECT SCOPE_IDENTITY() AS id
