using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

public class MusicDBContext : DbContext
{
    public DbSet<Album> Albums { get; set; }
    public DbSet<Song> Songs { get; set; }
    public string _ConfigCn { get; set; }

    public MusicDBContext(string ConfigCn)
    {
        _ConfigCn = ConfigCn;

    }
    //  public MusicDBContext()
    // {        

    // }  
    protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(_ConfigCn);

}

[Table("Songs")]
public class Song
{
    public int SongId { get; set; }
    public string SongTitle { get; set; } = null!;

    // foreign key
    [ForeignKey("AlbumId")]
    public int AlbumId_FK { get; set; }

}

[Table("Albums")]
public class Album
{

    public int AlbumId { get; set; }
    public string AlbumTitle { get; set; } = null!;

    public List<Song> Songs { get; } = new();

}

