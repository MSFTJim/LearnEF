-- drop table [dbo].[Creators]

-- drop table [dbo].[Albums]
-- creators can have no songs, they can just be creators

CREATE TABLE [dbo].[Creators] (
    [CreatorId]    INT            IDENTITY (1001, 1) NOT NULL,
    [CreatorNames] varchar (1000) NOT NULL,
    CONSTRAINT [PK_Creators] PRIMARY KEY CLUSTERED ([CreatorId] ASC)
);


GO
