using MyTicket.Domain;
using MyTicket.DTO;

namespace MyTicket.DAL.Interfaces;

public interface IEventReposiory
{
    public  Task<Event> AddEventAsync(Event newEvent);
    
    public  Task<List<Event>> GetAllEventsAsync();

    public  Task<Event> UpdateEventAsync(Event updatedEvent);
    
    public  Task DeleteEventAsync(int id);

    public Task<List<EventDTO>> GetAllUserEventsAsync(User user);

    public Task<List<EventDTO>> GetAllEventsByDateAsync(User user, DateOnly date);

    public Task RemoveEvent(EventDTO eventDTO,User user);

}