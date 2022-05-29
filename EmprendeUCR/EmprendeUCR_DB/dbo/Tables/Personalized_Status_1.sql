CREATE TABLE [dbo].[Personalized_Status] (
    [Name]               VARCHAR (20)  NOT NULL,
    [Code_ID]            INT           NOT NULL,
    [Entrepreneur_Email] VARCHAR (100) NOT NULL,
    [Category_ID]        INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Name] ASC, [Code_ID] ASC, [Entrepreneur_Email] ASC, [Category_ID] ASC),
    CONSTRAINT [FK_dbo.Personalized_Status_dbo.Product_Service] FOREIGN KEY ([Code_ID], [Entrepreneur_Email], [Category_ID]) REFERENCES [dbo].[Product_Service] ([Code_ID], [Entrepreneur_Email], [Category_ID]) ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT [FK_dbo.Personalized_Status_dbo.Status] FOREIGN KEY ([Name]) REFERENCES [dbo].[Status] ([Name]) ON DELETE CASCADE ON UPDATE CASCADE
);

