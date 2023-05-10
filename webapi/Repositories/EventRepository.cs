using Microsoft.EntityFrameworkCore;
using webapi.Data;
using webapi.Interfaces;
using webapi.Models;

namespace webapi.Repositories;

public class EventRepository : Repository,IEventReposiory
{
    public EventRepository(ApplicationDbContext context) : base(context)
    {
    }
    
    public async Task<Event> AddEventAsync(Event newEvent)
    {
        await _context.Events.AddAsync(newEvent);
        await _context.SaveChangesAsync();
        return newEvent;
    }

    public async Task<List<Event>> GetAllEventsAsync()
    {
        return await _context.Events.ToListAsync();
    }

    public async Task<Event> GetEventByIdAsync(int id)
    {
        return await _context.Events.FindAsync(id);
    }
    

    public async Task<Event> UpdateEventAsync(Event updatedEvent)
    {
        _context.Events.Update(updatedEvent);
        await _context.SaveChangesAsync();
        return updatedEvent;
    }

    public async Task DeleteEventAsync(int id)
    {
        var @event = await _context.Events.FindAsync(id);
        if (@event != null)
        {
            _context.Events.Remove(@event);
            await _context.SaveChangesAsync();
        }
    }
}