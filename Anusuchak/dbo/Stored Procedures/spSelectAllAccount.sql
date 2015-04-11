CREATE PROCEDURE [dbo].[spSelectAllAccount]

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
	[enabled]=1
