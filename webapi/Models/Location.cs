namespace webapi.Models;

public class Location
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Street { get; set; }
    public string City { get; set; }
    public string Countr { get; set; }
    public ICollection<Event> Events { get; set; }

}