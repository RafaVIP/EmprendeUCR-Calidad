CREATE TABLE [dbo].[Product_Photos] (
    [Product_Photos_ID]  INT             NOT NULL,
    [Photos]             VARBINARY (MAX) NULL,
    [Entrepreneur_Email] VARCHAR (100)   NOT NULL,
    [Category_ID]        INT             NOT NULL,
    PRIMARY KEY CLUSTERED ([Product_Photos_ID] ASC),
    FOREIGN KEY ([Product_Photos_ID], [Entrepreneur_Email], [Category_ID]) REFERENCES [dbo].[Product] ([Code_ID], [Entrepreneur_Email], [Category_ID])
);

