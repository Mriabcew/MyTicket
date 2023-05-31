using Microsoft.EntityFrameworkCore;
using MyTicket.Domain;

namespace MyTicket.DAL;

public class ApplicationDbContext : DbContext
{
 
    public DbSet<User> Users { get; set; }
    public DbSet<Event> Events { get; set; }
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }
    
    
}