CREATE PROCEDURE [dbo].[spDeleteTasks] (
	@id bigint
)

AS

SET NOCOUNT ON

DELETE FROM
	[Tasks]
WHERE
	[id] = @id
