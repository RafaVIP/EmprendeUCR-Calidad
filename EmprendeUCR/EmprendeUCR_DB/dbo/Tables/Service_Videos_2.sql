CREATE TABLE [dbo].[Service_Videos] (
    [Services_Videos_ID] INT             NOT NULL,
    [Videos]             VARBINARY (MAX) NULL,
    FOREIGN KEY ([Services_Videos_ID]) REFERENCES [dbo].[Service] ([Code_ID])
);

