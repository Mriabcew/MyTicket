using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using MyTicket.Common.Converters;
using MyTicket.DAL.Interfaces;
using MyTicket.Domain;
using MyTicket.DTO;
using MyTicket.DTO.TicketMasterResponses;
using MyTicket.Services.Interfaces;
using Newtonsoft.Json;
using Event = MyTicket.DTO.TicketMasterResponses.Event;

namespace MyTicket.Services.Services;

public class EventService : IEventService
{
    private readonly IUserRepository _userRepository;
    private readonly IEventReposiory _eventReposiory;

    public EventService(IUserRepository userRepository,IEventReposiory eventReposiory)
    {
        _userRepository = userRepository;
        _eventReposiory = eventReposiory;
    }
    public async Task<List<EventDTO>> GetAllEventsByCategoryAsync(string category)
    {
        string apiKey = "xqGaY1wJ15nCq2W7BRTkwyOIHHRT2MAt";
        string baseUrl = "https://app.ticketmaster.com/discovery/v2";

        string url = $"{baseUrl}/events.json?classificationName={category}&apikey={apiKey}";

        try
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage responseMessage = await client.GetAsync(url);
                if (responseMessage.IsSuccessStatusCode)
                {
                    string json = await responseMessage.Content.ReadAsStringAsync();
                    // Deserializacja JSON do obiektu zawierającego wydarzenia
                    Root root = JsonConvert.DeserializeObject<Root>(json);

                    List<EventDTO> events = new List<EventDTO>();
                    // Pobranie listy wydarzeń
                    foreach (var e in root._embedded.events)
                    {
                        events.Add(e.toDTO());
                    }

                    return events;
                }
                else
                {
                    throw new HttpRequestException($"Request failed with status code: {responseMessage.StatusCode}");
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return null;
        }
    }
    
    
    public async Task<EventDTO> GetEventById(string Id)
    {
        string apiKey = "xqGaY1wJ15nCq2W7BRTkwyOIHHRT2MAt";
        string baseUrl = "https://app.ticketmaster.com/discovery/v2";

        string url = $"{baseUrl}/events/{Id}.json?&apikey={apiKey}";
        try
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage responseMessage = await client.GetAsync(url);
                if (responseMessage.IsSuccessStatusCode)
                {
                    string json = await responseMessage.Content.ReadAsStringAsync();
                    Event myDeserializedClass = JsonConvert.DeserializeObject<Event>(json);
                    return (myDeserializedClass).toDTO();
                }
                else
                {
                    return new EventDTO();
                }
            }

        }
        catch (Exception e)
        {
            return new EventDTO();
        }

    }

    public async Task<List<EventDTO>> GetAllEventsByUserId(int id)
    {
      var user = await _userRepository.GetUserByIdAsync(id);
      return await _eventReposiory.GetAllUserEventsAsync(user);
    }

    public async Task AddEventToUserById(int id, string eventId)
    {
        var user = await _userRepository.GetUserByIdAsync(id);
        var @event = await this.GetEventById(eventId);

        await _userRepository.AddEventToUser(@event, id);
    }

    public async Task<List<EventDTO>> GetAllEventsByDateForUser(int id, string dateString)
    {
        var user = await _userRepository.GetUserByIdAsync(id);
        var date = DateOnly.Parse(dateString);
        var eventList = await _eventReposiory.GetAllEventsByDateAsync(user, date);
        return eventList;
    }

    public async Task RemoveEventFromUser(int userId, string eventId)
    {
        var user = await _userRepository.GetUserByIdAsync(userId);
        var @event = await this.GetEventById(eventId);

        await _eventReposiory.RemoveEvent(@event,user);

    }
}