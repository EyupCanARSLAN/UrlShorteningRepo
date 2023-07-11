
using Business.Interfaces.UrlShortening;
using Business.Services;
using Domain;
using Domain.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var blogConnectionString = builder.Configuration.GetConnectionString("DbConnectionString");
// Add services to the container.
builder.Services.AddDbContext<UrlShorteningDbContext>(options => options.UseSqlServer(blogConnectionString));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IUrlShorteningRepository, UrlShorteningRepository>();
builder.Services.AddScoped<IUrlShorteningService, UrlShorteningService>();


var app = builder.Build();
// ensure database and tables exist
{
    using var scope = app.Services.CreateScope();
    var context = scope.ServiceProvider.GetRequiredService<UrlShorteningDbContext>();
    context.Database.EnsureCreated();
}


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.MapFallback(RedirectDelegate);


static async Task RedirectDelegate(HttpContext httpContext)
{
    var path = httpContext.Request.Path.ToUriComponent().Trim('/');
    httpContext.Response.Redirect($"api/UrlJobs/RedirectShortening?urlShortening={path}"); 
    await Task.CompletedTask;
}

app.Run();
