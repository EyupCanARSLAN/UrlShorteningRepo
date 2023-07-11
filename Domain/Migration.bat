dotnet ef database update 0 --context UrlShorteningDbContext

dotnet ef migrations remove --context UrlShorteningDbContext

dotnet ef migrations add InitialCreate --context UrlShorteningDbContext

dotnet ef database update --context UrlShorteningDbContext
