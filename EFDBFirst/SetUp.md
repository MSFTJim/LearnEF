dotnet tool install --global dotnet-ef

dotnet add package Microsoft.EntityFrameworkCore.Design

dotnet add package Microsoft.EntityFrameworkCore.SqlServer

dotnet ef dbcontext scaffold "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Chinook" Microsoft.EntityFrameworkCore.SqlServer

dotnet ef dbcontext scaffold "Data Source=jfv.database.windows.net,1433;Initial Catalog=DB8;User ID=AdminJim;Password=;" Microsoft.EntityFrameworkCore.SqlServer

Server=tcp:jfv.database.windows.net,1433;Initial Catalog=DB8;Persist Security Info=False;User ID=AdminJim;Password={your_password};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;

jfv.database.windows.net,1433;Initial Catalog=DB8;Persist Security Info=False;User ID=AdminJim;Password={your_password};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;