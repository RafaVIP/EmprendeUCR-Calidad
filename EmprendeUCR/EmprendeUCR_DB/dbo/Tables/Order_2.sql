CREATE TABLE [dbo].[Order] (
    [Date_and_hour_of_creation] ROWVERSION    NOT NULL,
    [Client_Email]              VARCHAR (100) NOT NULL,
    [Details]                   VARCHAR (500) NULL,
    [Delivery_date]             DATE          NOT NULL,
    [Entrepreneur_Email]        VARCHAR (100) NOT NULL,
    PRIMARY KEY CLUSTERED ([Date_and_hour_of_creation] ASC, [Client_Email] ASC),
    CONSTRAINT [FK_dbo.Order_dbo.Client] FOREIGN KEY ([Client_Email]) REFERENCES [dbo].[Client] ([User_Email]) ON UPDATE CASCADE,
    CONSTRAINT [FK_dbo.Order_dbo.Entrepreneur] FOREIGN KEY ([Entrepreneur_Email]) REFERENCES [dbo].[Entrepreneur] ([User_Email])
);

