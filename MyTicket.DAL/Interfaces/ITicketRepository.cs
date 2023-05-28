using MyTicket.Domain;

namespace MyTicket.DAL.Interfaces;

public interface ITicketRepository
{
    Task AddTicketAsync(Ticket ticket);
    Task<Ticket> GetTicketByIdAsync(int id);
    public Task<List<Ticket>> GetTicketsByEventIdAsync(int id);
    Task<List<Ticket>> GetAllTicketAsync();
    Task<Ticket> Update(Ticket ticket);
    Task<bool> Delete(Ticket ticket);

    Task<List<Ticket>> GetTicketsByUserId(int id);
}