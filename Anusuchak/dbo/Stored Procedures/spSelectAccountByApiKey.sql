CREATE PROCEDURE [dbo].[spSelectAccountByApiKey](
	@apikey varchar(50)
)
AS

SET NOCOUNT ON

SELECT
	A.[id],
	US.[username],
	A.[password],
	A.[email],
	A.[enabled]
FROM
	[UserSession] as US
	JOIN
	[Account] as A
	on US.username = A.username
Where	
	[apikey]=@apikey