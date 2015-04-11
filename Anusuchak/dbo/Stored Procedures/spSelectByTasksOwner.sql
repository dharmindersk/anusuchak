CREATE PROCEDURE [dbo].[spSelectByTasksOwner] (
	@owner nvarchar(50)
)

AS

SET NOCOUNT ON

SELECT
	[id],
	[owner],
	[tasktype],
	[title],
	[status],
	[scheduled_time],
	[frequency]
FROM
	[Tasks]
WHERE
	[owner] = @owner
