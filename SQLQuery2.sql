CREATE TABLE [dbo].[eval] (
    [Id]            INT           NOT NULL,
    [name]          NVARCHAR (50) NULL,
    [section]       NCHAR (10)    NULL,
    [branch]        NCHAR (10)    NULL,
    [date_of_birth] DATE    NULL,
    [picture]       IMAGE         NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);