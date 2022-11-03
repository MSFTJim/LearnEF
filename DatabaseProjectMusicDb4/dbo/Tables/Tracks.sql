-- drop TABLE [dbo].[Tracks]

CREATE TABLE [dbo].[Tracks] (
    [TrackId]     INT            IDENTITY (1001, 1) NOT NULL,
    [TrackTitle]  varchar(100) NOT NULL,
--     [AlbumId_FK] INT            NOT NULL,
--     [AristId_FK] INT  not null,

    CONSTRAINT [PK_Tracks] PRIMARY KEY CLUSTERED ([TrackId] ASC),
    -- CONSTRAINT [FK_Tracks_Albums_AlbumId] FOREIGN KEY ([AlbumId]) REFERENCES [dbo].[Albums] ([AlbumId]),
    -- CONSTRAINT [FK_Tracks_Artists_ArtistId] FOREIGN KEY ([ArtistId]) REFERENCES [dbo].[Artists] ([ArtistId])
);


GO

