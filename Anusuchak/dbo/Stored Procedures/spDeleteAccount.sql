CREATE PROCEDURE [dbo].[spDeleteAccount] (
	@username nvarchar(50)
)

AS

SET NOCOUNT ON

DELETE FROM
	[Account]
WHERE
	[username] = @username
