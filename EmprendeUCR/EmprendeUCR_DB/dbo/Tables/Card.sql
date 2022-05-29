CREATE TABLE [dbo].[Card] (
    [Name]   VARCHAR (30) NOT NULL,
    [Status] BIT          NOT NULL,
    [Brand]  VARCHAR (30) NOT NULL,
    PRIMARY KEY CLUSTERED ([Name] ASC, [Brand] ASC),
    FOREIGN KEY ([Name]) REFERENCES [dbo].[PaymentMethod] ([Name]) ON DELETE CASCADE,
    UNIQUE NONCLUSTERED ([Brand] ASC)
);

