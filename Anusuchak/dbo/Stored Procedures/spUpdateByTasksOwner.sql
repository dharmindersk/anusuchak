CREATE PROCEDURE [dbo].[spUpdateByTasksOwner] (
	@owner nvarchar(50),
	@tasktype nvarchar(50),
	@title nvarchar(128),
	@status nvarchar(50),
	@scheduled_time DATETIME,
	@frequency nvarchar(50)
)
AS

SET NOCOUNT ON

UPDATE
	[Tasks]
SET
	[owner] = @owner,
	[tasktype] = @tasktype,
	[title] = @title,
	[status] = @status,
	[scheduled_time] = @scheduled_time,
	[frequency] = @frequency
	
WHERE
	 [owner] = @owner
