// See https://aka.ms/new-console-template for more information

using EFDBFirst;
using Microsoft.Extensions.Configuration;

IConfiguration config = new ConfigurationBuilder()    
    .AddUserSecrets<Program>(true)
    .Build();

// #warning Tin is a knucklehead
// Get values from the config given their key and their target type.
var dbCn = config["DbCn"];

Console.WriteLine($"Hello: {dbCn}");

using var db = new DB8Context(dbCn);

 Console.WriteLine("Inserting a new Album");
    db.Add(new Blog { Name = "TBone", Url="www.Outback.com" });
    db.SaveChanges();

