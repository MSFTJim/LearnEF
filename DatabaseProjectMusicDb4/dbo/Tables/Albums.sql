
drop table [dbo].[Albums]
CREATE TABLE [dbo].[Albums] (
    -- a collection of Tracks with creators
    [AlbumId]    INT            IDENTITY (1001, 1) NOT NULL,
    [AlbumTitle] varchar (100) NOT NULL,
   -- [PublisherId] int not null,
    CONSTRAINT [PK_Albums] PRIMARY KEY CLUSTERED ([AlbumId] ASC)
);


GO

