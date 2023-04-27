namespace webapi.Models;

public class Location
{
    public int Id { get; set; }
    public string Name { get; set; }
    public ICollection<Event> Events { get; set; }

}