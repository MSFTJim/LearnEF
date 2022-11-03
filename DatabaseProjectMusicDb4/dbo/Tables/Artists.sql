--drop table [dbo].[Artists]

-- AritiArtistssts can have no Tracks, they can just be Artists

CREATE TABLE [dbo].[Artists] (
    [ArtistId]    INT            IDENTITY (1001, 1) NOT NULL,
    [ArtistNames] varchar (1000) NOT NULL,
    CONSTRAINT [PK_Artists] PRIMARY KEY CLUSTERED ([ArtistId] ASC)
);


GO
