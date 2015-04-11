CREATE PROCEDURE [dbo].[spInsertAttributes] (
	@task_id bigint,
	@attr_name nvarchar(50),
	@attr_value nvarchar(512)
)

AS

SET NOCOUNT ON

INSERT INTO [Attributes] (
	[task_id],
	[attr_name],
	[attr_value]
) VALUES (
	@task_id,
	@attr_name,
	@attr_value
)
