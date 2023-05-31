using Microsoft.EntityFrameworkCore;
using MyTicket.DAL.Interfaces;
using MyTicket.Domain;
using MyTicket.DTO;


namespace MyTicket.DAL.Repositories;

public class UserRepository : Repository, IUserRepository
{
    public UserRepository(ApplicationDbContext context):base(context)
    {
    }

    public async Task AddUserAsync(User user)
    {
        await _context.Users.AddAsync(user);
        await _context.SaveChangesAsync();
    }

    public async Task<User> GetUserByIdAsync(int id)
    {
        return await _context.Users.FirstOrDefaultAsync(u => u.Id == id);
    }
    
    public async Task<User> GetUserByEmailAsync(string email)
    {
        return await _context.Users.FirstOrDefaultAsync(u => u.Email == email);
    }
  
    public async Task<List<User>> GetAllAsync()
    {
        return await _context.Users.ToListAsync();
    }
  
    public async Task<User> Update(User user)
    {
        var userToUpdate = await _context.Users.FindAsync(user.Id);
        if (userToUpdate == null)
        {
            throw new ArgumentException("User with given id does not exist");
        }
        
        userToUpdate.Name = user.Name;
        userToUpdate.Email = user.Email;
        userToUpdate.Password = user.Password;

        await _context.SaveChangesAsync();
        return userToUpdate;
    }
    
    public async Task<bool> Delete(User user)
    {
        var userToDelete = await _context.Users.FindAsync(user.Id);
        if (userToDelete == null)
        {
            throw new ArgumentException("User with this Id does not exist");
        }

        _context.Users.Remove(userToDelete);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task AddEventToUser(EventDTO @event, int UserId)
    {
        @event.UserId = UserId;
        var eventToAdd = new Event()
        {
            Date = @event.Date,
            Description = @event.Description,
            TicketMasterId = @event.TicketMasterId,
            Id = @event.Id,
            Name = @event.Name,
            Url = @event.ImageUrl,
            UserId = @event.UserId,
            Type = @event.Type

        };
        await _context.Events.AddAsync(eventToAdd);
        await _context.SaveChangesAsync();
    }

    public async Task ChangeImageString(User user, string newImageString)
    {
        var userToChange = await _context.Users.FirstOrDefaultAsync(u => u.Id == user.Id);
    
        if (userToChange != null)
        {
            userToChange.Image = newImageString;
            
            _context.Users.Update(userToChange);
            await _context.SaveChangesAsync();
        }

    }

    public async Task UploadBackgroundImage(User user, string cloudinary)
    {
        var userToChange = await _context.Users.FirstOrDefaultAsync(u => u.Id == user.Id);
    
        if (userToChange != null)
        {
            userToChange.BackgroundImage = cloudinary;
            
            _context.Users.Update(userToChange);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<User> GetUserByUsernameOrEmail(string usernameOrEmail)
    {
        return await _context.Users
            .Where(u => u.Username == usernameOrEmail || u.Email == usernameOrEmail)
            .SingleOrDefaultAsync();
    }
    
}