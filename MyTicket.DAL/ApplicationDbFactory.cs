using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace MyTicket.DAL;

public class ApplicationDbFactory: IDesignTimeDbContextFactory<ApplicationDbContext>
{

    public ApplicationDbFactory()
    {

    }
        
    public ApplicationDbContext CreateDbContext(string[] args)
    {
        IConfigurationRoot configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile(Directory.GetCurrentDirectory() + "../../webapi/appsettings.json").Build();

        var builder = new DbContextOptionsBuilder<ApplicationDbContext>();
        var connectionString = configuration.GetConnectionString("MyTicket");
        builder.UseNpgsql(connectionString);

        return new ApplicationDbContext(builder.Options);
    } 
}