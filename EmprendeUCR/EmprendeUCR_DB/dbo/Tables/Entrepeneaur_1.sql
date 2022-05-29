CREATE TABLE [dbo].[Entrepeneaur] (
    [User_Email]   VARCHAR (100) NOT NULL,
    [Presentation] VARCHAR (220) NULL,
    PRIMARY KEY CLUSTERED ([User_Email] ASC),
    CONSTRAINT [FK_Entrepeneaur_User] FOREIGN KEY ([User_Email]) REFERENCES [dbo].[User] ([Email]) ON DELETE CASCADE ON UPDATE CASCADE
);

