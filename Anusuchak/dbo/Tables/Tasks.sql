CREATE TABLE [dbo].[Tasks] (
    [id]             BIGINT         IDENTITY (1, 1) NOT NULL,
    [owner]          NVARCHAR (50)  NOT NULL,
    [tasktype]       NVARCHAR (50)  NOT NULL,
    [title]          NVARCHAR (128) NOT NULL,
    [status]         NVARCHAR (50)  NOT NULL,
    [scheduled_time] DATETIME       NOT NULL,
    [frequency]      NVARCHAR (50)  NOT NULL,
    [added_on]       DATETIME       CONSTRAINT [DF_Tasks_added_on] DEFAULT (getdate()) NOT NULL,
    CONSTRAINT [PK_Tasks] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_Tasks_Account] FOREIGN KEY ([owner]) REFERENCES [dbo].[Account] ([username]) ON DELETE CASCADE ON UPDATE CASCADE
);



