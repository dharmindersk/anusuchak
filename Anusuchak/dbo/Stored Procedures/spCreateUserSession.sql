CREATE PROCEDURE [dbo].[spCreateUserSession] (
	@username nvarchar(50),
	@session_data varchar(50),
	@api_key varchar(50)
)

AS

SET NOCOUNT ON

INSERT INTO [UserSession] (
	[username],
	[session_data],
	[apikey]
) VALUES (
	@username,
	@session_data,
	@api_key
)