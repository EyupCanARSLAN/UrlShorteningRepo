# About Ef Core Create Db If Not Exist-

Program.cs deki bu kod bloğu sayesinde CreateDbIfNotExist approach sağlanmış olur.
```
var app = builder.Build();
// ensure database and tables exist
{
    using var scope = app.Services.CreateScope();
    var context = scope.ServiceProvider.GetRequiredService<UrlShorteningDbContext>();
    context.Database.EnsureCreated();
}
```
