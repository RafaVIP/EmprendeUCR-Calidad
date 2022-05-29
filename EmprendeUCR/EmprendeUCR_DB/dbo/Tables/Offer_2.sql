CREATE TABLE [dbo].[Offer] (
    [Offer_ID]          INT           NOT NULL,
    [Initial_Date]      DATE          NOT NULL,
    [Expire_Date]       DATE          NOT NULL,
    [Offer_Description] VARCHAR (220) NULL,
    [Discount]          TINYINT       NOT NULL,
    PRIMARY KEY CLUSTERED ([Offer_ID] ASC)
);

