CREATE PROCEDURE [dbo].[spSelectByAttributesTask_id] (
	@task_id bigint
)

AS

SET NOCOUNT ON

SELECT
	[task_id],
	[attr_name],
	[attr_value]
FROM
	[Attributes]
WHERE
	[task_id] = @task_id
