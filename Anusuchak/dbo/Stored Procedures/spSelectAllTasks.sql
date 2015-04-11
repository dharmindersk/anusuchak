CREATE PROCEDURE [dbo].[spSelectAllTasks]

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
