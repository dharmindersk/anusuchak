CREATE PROCEDURE [dbo].[spDeleteUserSession] (
	@username nvarchar(50)
)

AS

SET NOCOUNT ON

DELETE FROM
	[UserSession]
	
WHERE
	[username] = @username