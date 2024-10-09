# TigerTix


run with `dotnet run'
run with updates for css `dotnet watch run'

dotnet tool install --global dotnet-ef
dotnet ef migrations add InitialCreate
dotnet ef database update


dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore