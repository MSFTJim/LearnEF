
dotnet add package Microsoft.EntityFrameworkCore.SqlServer

Server=tcp:jfv.database.windows.net,1433;Initial Catalog=TestDB;Persist Security Info=False;User ID=AdminJim;Password={your_password};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;


dotnet tool install --global dotnet-ef
    export PATH="$PATH:/home/codespace/.dotnet/tools"

dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet ef migrations add InitialCreate
dotnet ef database update 

push me