CREATE TABLE [dbo].[UserSession] (
    [username]     NVARCHAR (50) NOT NULL,
    [session_data] VARCHAR (50)  NOT NULL,
    [apikey]       VARCHAR (50)  NOT NULL,
    [add_date]     DATETIME      CONSTRAINT [DF_UserSession_added_on] DEFAULT (getdate()) NOT NULL,
    CONSTRAINT [FK_UserSession_Account] FOREIGN KEY ([username]) REFERENCES [dbo].[Account] ([username]) ON DELETE CASCADE ON UPDATE CASCADE
);

