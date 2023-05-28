using MyTicket.Domain;
using MyTicket.DTO;

namespace MyTicket.Services.Interfaces
{
    public interface ITicketService
    {
        Task<IEnumerable<Ticket>> GetAllTicketsAsync();

        Task<List<TicketDTO>> GetTicketsByUserId(int userId);
        Task<Ticket> GetTicketByIdAsync(int id);
        Task<IEnumerable<Ticket>> GetTicketsByEventIdAsync(int eventId);
        Task CreateTicketAsync(Ticket ticket);
        Task UpdateTicketAsync(Ticket ticketToUpdate);
        Task<bool> DeleteTicketAsync(Ticket ticket);
    }
}