using webapi.Data;

namespace webapi.Repositories;

public class Repository
{
    protected readonly ApplicationDbContext _context;

    public Repository(ApplicationDbContext context)
    {
        _context = context;
    }
}