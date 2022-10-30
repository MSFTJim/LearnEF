-- drop TABLE [dbo].[Songs]

CREATE TABLE [dbo].[Songs] (
    [SongId]     INT            IDENTITY (1, 1) NOT NULL,
    [SongTitle]  NVARCHAR (MAX) NOT NULL,
    [AlbumId_FK] INT            NOT NULL,
    [CreatorId_FK] INT  not null,

    CONSTRAINT [PK_Songs] PRIMARY KEY CLUSTERED ([SongId] ASC),
    CONSTRAINT [FK_Songs_Albums_AlbumId] FOREIGN KEY ([AlbumId]) REFERENCES [dbo].[Albums] ([AlbumId]),
    CONSTRAINT [FK_Songs_Creators_CreatorId] FOREIGN KEY ([CreatorId]) REFERENCES [dbo].[Creators] ([CreatorId])
);


GO

CREATE NONCLUSTERED INDEX [IX_Songs_AlbumId]
    ON [dbo].[Songs]([AlbumId] ASC);


GO

