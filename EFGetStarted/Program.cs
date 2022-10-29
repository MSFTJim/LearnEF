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

// Write the values to the console.
Console.WriteLine($"Config AppSettings Key = {configKey}");
Console.WriteLine($"Config Secret Key = {configSQLKey}");
Console.WriteLine($"Config Secret Key = {configMusicDbCn}");
Console.WriteLine("Hello, World!");

// Create
// Console.WriteLine("Inserting a new Album");
// db.Add(new Album { AlbumTitle = "Wish You Were Here" });
// db.SaveChanges();

// // Read
// Console.WriteLine("Querying for a albums");
// var albums = db.Albums
//     .OrderBy(a => a.AlbumId)
//     .First();

// // Update
// Console.WriteLine("Updating the Album and adding a Song");
// albums.AlbumTitle = "Dark Side of the Moon";
// albums.Songs.Add(
//     new Song { SongTitle = "Breathe" });
// db.SaveChanges();

// Delete
// Console.WriteLine("Delete the orphan song");
// db.Remove(blog);
// db.SaveChanges();



// Delete
Console.WriteLine("Delete the orphan song");
 // Query for all blogs with names starting with B 
    // var OrphanSongs = db.Songs
    //                .Where(os => os. )
    //                b.Name.StartsWith("B")
    //                select b;

    // Query for the Blog named ADO.NET Blog
     var TimCantDoIt = db.Songs
                    .Where(os => os.SongTitle == "Wish You Were Here")
                    .FirstOrDefault();

db.Remove(TimCantDoIt);
db.SaveChanges();
