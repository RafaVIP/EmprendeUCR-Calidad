CREATE TABLE [dbo].[Status] (
    [Name]                VARCHAR (20) NOT NULL,
    [Previous_State_Name] VARCHAR (20) NOT NULL,
    PRIMARY KEY CLUSTERED ([Name] ASC),
    CONSTRAINT [FK_dbo.Status_dbo.Status] FOREIGN KEY ([Previous_State_Name]) REFERENCES [dbo].[Status] ([Name])
);

