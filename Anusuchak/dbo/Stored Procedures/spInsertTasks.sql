CREATE PROCEDURE [dbo].[spInsertTasks] (
	@owner nvarchar(50),
	@tasktype nvarchar(50),
	@title nvarchar(128),
	@status nvarchar(50),
	@scheduled_time DATETIME,
	@frequency nvarchar(50)
)

AS

SET NOCOUNT ON

INSERT INTO [Tasks] (
	[owner],
	[tasktype],
	[title],
	[status],
	[scheduled_time],
	[frequency]
) VALUES (
	@owner,
	@tasktype,
	@title,
	@status,
	@scheduled_time,
	@frequency
)
