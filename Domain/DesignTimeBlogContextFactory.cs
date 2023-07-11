using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Blog.Data.EF
{
    public class DesignTimeBlogContextFactory : IDesignTimeDbContextFactory<UrlShorteningDbContext>
    {
        public UrlShorteningDbContext CreateDbContext(string[] args)
        {
            //var configuration = new ConfigurationBuilder()
            //     .SetBasePath(Directory.GetCurrentDirectory())
            //     .AddJsonFile("appsettings.json")
            //     .Build();

            var dbContextBuilder = new DbContextOptionsBuilder<UrlShorteningDbContext>();

            var connectionString = "Data Source=.\\;Initial Catalog=AppDb; TrustServerCertificate=True;Trusted_Connection=True;MultipleActiveResultSets=true";

            dbContextBuilder.UseSqlServer(connectionString);

            return new UrlShorteningDbContext(dbContextBuilder.Options);
        }
    }
}
