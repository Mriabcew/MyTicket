
using Microsoft.EntityFrameworkCore;
using MyTicket.DAL.Interfaces;
using MyTicket.Domain;
using MyTicket.DTO;


namespace MyTicket.DAL.Repositories;

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

    public async Task<List<EventDTO>> GetAllUserEventsAsync(User user)
    {
       var events = await _context.Events.Where(e => e.UserId == user.Id).ToListAsync();

       var eventDTOs = events.Select(e => new EventDTO()
       {
           Id = e.Id,
           TicketMasterId = e.TicketMasterId,
           UserId = e.UserId,
           Date = e.Date,
           Description = e.Description,
           ImageUrl = e.Url,
           Name = e.Name,
           Type = e.Type,


       }).ToList();

       return eventDTOs;
    }

    public async Task<List<EventDTO>> GetAllEventsByDateAsync(User user,DateOnly date)
    {
        var events = await _context.Events.Where(e => e.Date == date  && e.UserId == user.Id).ToListAsync();
        var eventsDTOs = events.Select(e => new EventDTO()
        {
            Id = e.Id,
            TicketMasterId = e.TicketMasterId,
            UserId = e.UserId,
            Date = e.Date,
            Description = e.Description,
            ImageUrl = e.Url,
            Name = e.Name,
            Type = e.Type,


        }).ToList();

        return eventsDTOs;
    }

    public async Task RemoveEvent(EventDTO eventDTO, User user)
    {
         var eventToRemove = await _context.Events.FirstOrDefaultAsync(e => e.TicketMasterId == eventDTO.TicketMasterId && e.UserId == user.Id);
        _context.Remove(eventToRemove);
        await _context.SaveChangesAsync();

    }
}