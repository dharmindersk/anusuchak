/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
--Truncate table [Attributes]
--Truncate table [Tasks]
DELETE FROM [Account]
Go
/****** Object:  Table [dbo].[Account]    Script Date: 05/08/2014 20:37:57 ******/
SET IDENTITY_INSERT [dbo].[Account] ON
INSERT [dbo].[Account] ([id], [username], [password], [email], [enabled], [added_on]) VALUES (1, N'dharmindersk', N'662467f7b01b532d65a6b9986d43bb55', N'dharminder85@gmail.com', 1, CAST(0x0000A32200112372 AS DateTime))
INSERT [dbo].[Account] ([id], [username], [password], [email], [enabled], [added_on]) VALUES (2, N'manindersk', N'662467f7b01b532d65a6b9986d43bb55', N'mann84@gmail.com', 0, CAST(0x0000A32200112372 AS DateTime))
SET IDENTITY_INSERT [dbo].[Account] OFF
/****** Object:  Table [dbo].[Tasks]    Script Date: 05/08/2014 20:37:57 ******/
SET IDENTITY_INSERT [dbo].[Tasks] ON
INSERT [dbo].[Tasks] ([id], [owner], [tasktype], [title], [status], [scheduled_time], [frequency], [added_on]) 
VALUES (2, N'dharmindersk', N'EmailScheduler.Tasks.BasicEmailTask', N'Send update today before first half', N'pending', CAST(0x0000A322001774A2 AS DateTime), N'Once', CAST(0x0000A3220015896B AS DateTime))
SET IDENTITY_INSERT [dbo].[Tasks] OFF
/****** Object:  Table [dbo].[Attributes]    Script Date: 05/08/2014 20:37:57 ******/
INSERT [dbo].[Attributes] ([task_id], [attr_name], [attr_value]) VALUES (2, N'email_message', N'activty report <p> Regards <BR /> DSK</p> ')
