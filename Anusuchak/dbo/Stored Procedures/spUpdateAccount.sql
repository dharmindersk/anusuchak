CREATE PROCEDURE [dbo].[spUpdateAccount] (
	@id bigint,
	@username nvarchar(50),
	@password nvarchar(50),
	@email nvarchar(50),
	@enabled bit
)

AS

SET NOCOUNT ON

UPDATE
	[Account]
SET
	[password] = @password,
	[email] = @email,
	[enabled] = @enabled
WHERE
	 [username] = @username
