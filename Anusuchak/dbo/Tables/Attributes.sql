CREATE TABLE [dbo].[Attributes] (
    [task_id]    BIGINT         NOT NULL,
    [attr_name]  NVARCHAR (50)  NOT NULL,
    [attr_value] NVARCHAR (512) NOT NULL,
    CONSTRAINT [FK_Attributes_Tasks] FOREIGN KEY ([task_id]) REFERENCES [dbo].[Tasks] ([id])  ON DELETE CASCADE ON UPDATE CASCADE
);

