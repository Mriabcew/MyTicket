using MyTicket.Common.Converters;
using MyTicket.DTO;
using MyTicket.DTO.TicketMasterResponses;
using MyTicket.Services.Interfaces;
using Newtonsoft.Json;

namespace MyTicket.Services.Services;

public class EventService : IEventService
{
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
    
    
    public async Task<EventDTO> getEventById(string Id)
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
}