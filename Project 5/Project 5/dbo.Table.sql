CREATE TABLE [dbo].[Table] (
    [ISBN]      BIGINT        NOT NULL,
    [Title]     NVARCHAR (50) NOT NULL,
    [Author]    NVARCHAR (50) NOT NULL,
    [Publisher] NVARCHAR (50) NOT NULL, 
    CONSTRAINT [PK_Table] PRIMARY KEY ([Title])
);

