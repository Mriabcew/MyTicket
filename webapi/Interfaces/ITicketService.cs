using System.Collections.Generic;
using System.Threading.Tasks;
using webapi.Models;

namespace webapi.Interfaces
{
    public interface ITicketService
    {
        Task<IEnumerable<Ticket>> GetAllTicketsAsync();
        Task<Ticket> GetTicketByIdAsync(int id);
        Task<IEnumerable<Ticket>> GetTicketsByEventIdAsync(int eventId);
        Task CreateTicketAsync(Ticket ticket);
        Task UpdateTicketAsync(Ticket ticketToUpdate);
        Task<bool> DeleteTicketAsync(Ticket ticket);
    }
}