SELECT TOP (1000) [SongId]
      ,[SongTitle]
      ,[AlbumId]
  FROM [dbo].[Songs]

  SELECT * FROM [dbo].[Albums]

  select Songs.*, Albums.*
  from Songs join Albums on Songs.AlbumId = Albums.AlbumId