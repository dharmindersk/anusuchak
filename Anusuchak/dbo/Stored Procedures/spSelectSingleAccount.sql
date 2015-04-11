CREATE PROCEDURE [dbo].[spSelectSingleAccount] (
	@username nvarchar(50)
)

AS

SET NOCOUNT ON

SELECT
	[id],
	[username],
	[password],
	[email],
	[enabled]
FROM
	[Account]
WHERE
	[username] = @username
