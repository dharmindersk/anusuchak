CREATE TABLE [dbo].[Account] (
    [id]       BIGINT        IDENTITY (1, 1) NOT NULL,
    [username] NVARCHAR (50) NOT NULL,
    [password] NVARCHAR (50) NOT NULL,
    [email]    NVARCHAR (50) NOT NULL,
    [enabled]  BIT           NOT NULL,
    [added_on] DATETIME      CONSTRAINT [DF_Account_added_on] DEFAULT (getdate()) NOT NULL,
    CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED ([username] ASC)
);



