using Microsoft.EntityFrameworkCore;
using MyTicket.DAL.Interfaces;
using MyTicket.Domain;

namespace MyTicket.DAL.Repositories;

public class TicketRepository:Repository,ITicketRepository
{
    
    
    public TicketRepository(ApplicationDbContext context):base(context)
    {
    }

    public async Task AddTicketAsync(Ticket ticket)
    {
        await _context.Tickets.AddAsync(ticket);
        await _context.SaveChangesAsync();
    }

    public async Task<Ticket> GetTicketByIdAsync(int id)
    {
        return await _context.Tickets.FirstOrDefaultAsync(t => t.Id == id);
    }

    public async Task<List<Ticket>> GetAllTicketAsync()
    {
        return await _context.Tickets.ToListAsync();
    }

    public async Task<List<Ticket>> GetTicketsByEventIdAsync(int id)
    {
        return await _context.Tickets.Where(t => t.Id == id).ToListAsync();
    }

    public async Task<List<Ticket>> GetTicketsByUserId(int userId)
    {
        var user = await _context.Users.Include(u => u.Tickets).FirstOrDefaultAsync(u => u.Id == userId);
        return user?.Tickets.ToList() ?? new List<Ticket>();
        

       
        

    }


    //#TODO ROZWINAC TICKET
    public async Task<Ticket> Update(Ticket ticket)
    {
        var ticketToUpdate = await _context.Tickets.FindAsync(ticket);
        if (ticketToUpdate == null)
        {
            throw new ArgumentException("Ticket with given id does not exist");
        }

        ticketToUpdate.price = ticket.price;

        await _context.SaveChangesAsync();
        return ticketToUpdate;
    }

    public async Task<bool> Delete(Ticket ticket)
    {
        var ticketToDelete = await _context.Tickets.FindAsync(ticket.Id);
        if (ticketToDelete == null)
        {
            throw new ArgumentException("Ticket with this Id does not exist");
        }

        _context.Tickets.Remove(ticket);
        await _context.SaveChangesAsync();
        return true;
    }
}