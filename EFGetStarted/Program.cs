// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.Configuration;

// Build a config object, using env vars and JSON providers.
IConfiguration config = new ConfigurationBuilder()
    // .AddJsonFile($"appsettings.json", true, true)   
    .AddJsonFile("appsettings.json")
    .AddUserSecrets<Program>(true)
    .Build();

// Get values from the config given their key and their target type.
var configKey = config["FAKEKey"];
var configSQLKey = config["SQLPass"];
var configMusicDbCn = config["MusicDbCn"];

using var db = new MusicDBContext(configMusicDbCn);
// using var db = new MusicDBContext();

BasicEFProcess(db);
Console.WriteLine("Querying for a songs");
       var songs = db.Songs
 .Where(s => s.AlbumId ==1);

// Write the values to the console.

Console.WriteLine("Hello, World!");

static void BasicEFProcess(MusicDBContext db)
{
    Console.WriteLine("MyMethodHere says hello World!");
    // Create
    Console.WriteLine("Inserting a new Album");
    db.Add(new Album { AlbumTitle = "Wish You Were Here" });
    db.SaveChanges();

    // Read
    Console.WriteLine("Querying for a albums");
    var albums = db.Albums
        .OrderBy(a => a.AlbumId)
        .First();

    // Update
    Console.WriteLine("Updating the Album and adding a Song");
    albums.AlbumTitle = "Dark Side of the Moon";
    albums.Songs.Add(
        new Song { SongTitle = "Breathe" });
    db.SaveChanges();

    
}
