-- drop TABLE [dbo].[Publishers]
-- publishers publish songs and albums
-- songs may not be on albums, but have creators 
-- creators is a list/collection of CreatorName(s) 
CREATE TABLE [dbo].[Publishers] (
    [PublisherId]     INT            IDENTITY (101, 1) NOT NULL,
    [PublisherName]  varchar(200) NOT NULL,
    [AlbumId_FK] INT            NOT NULL,
    [CreatorId_FK] INT            NULL,
    --[CreatorId_FK] INT  not null,

    CONSTRAINT [PK_Publishers] PRIMARY KEY CLUSTERED ([PublisherId] ASC),
    CONSTRAINT [FK_Publishers_Albums_AlbumId] FOREIGN KEY ([AlbumId]) REFERENCES [dbo].[Albums] ([AlbumId]),
    CONSTRAINT [FK_Publishers_Creators_CreatorId] FOREIGN KEY ([CreatorId]) REFERENCES [dbo].[Creators] ([CreatorId])
);


GO

CREATE NONCLUSTERED INDEX [IX_Songs_AlbumId]
    ON [dbo].[Publishers]([PublisherId] ASC);


GO