CREATE PROCEDURE [dbo].[spDeleteByTasksOwner] (
	@owner nvarchar(50)
)

AS

SET NOCOUNT ON

DELETE FROM
	[Tasks]
WHERE
	[owner] = @owner
