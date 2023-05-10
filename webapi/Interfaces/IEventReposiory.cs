using webapi.Models;

namespace webapi.Interfaces;

public interface IEventReposiory
{
    public  Task<Event> AddEventAsync(Event newEvent);
    
    public  Task<List<Event>> GetAllEventsAsync();
    
    public  Task<Event> GetEventByIdAsync(int id);

    public  Task<Event> UpdateEventAsync(Event updatedEvent);
    
    public  Task DeleteEventAsync(int id);

}