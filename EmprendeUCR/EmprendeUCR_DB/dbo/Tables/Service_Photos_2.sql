CREATE TABLE [dbo].[Service_Photos] (
    [Services_Photos_ID] INT             NOT NULL,
    [Photos]             VARBINARY (MAX) NULL,
    FOREIGN KEY ([Services_Photos_ID]) REFERENCES [dbo].[Service] ([Code_ID])
);

