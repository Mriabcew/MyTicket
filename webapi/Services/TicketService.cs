using webapi.Interfaces;
using webapi.Models;
using webapi.Repositories;

namespace webapi.Services;

public class TicketService : ITicketService
{
    private readonly TicketRepository _ticketRepository;

    public TicketService(TicketRepository ticketRepository)
    {
        _ticketRepository = ticketRepository;
    }

    public async Task<IEnumerable<Ticket>> GetAllTicketsAsync()
    {
        return await _ticketRepository.GetAllTicketAsync();
    }
    
    public async Task<Ticket> GetTicketByIdAsync(int id)
    {
        return await _ticketRepository.GetTicketByIdAsync(id);
    }

    public async Task<IEnumerable<Ticket>> GetTicketsByEventIdAsync(int eventId)
    {
        return await _ticketRepository.GetTicketsByEventIdAsync(eventId);
    }

    public async Task<List<Ticket>> GetTicketsByUserId(int id)
    {
        return await _ticketRepository.GetTicketsByUserId(id);
    }

    public async Task CreateTicketAsync(Ticket ticket)
    {
        await _ticketRepository.AddTicketAsync(ticket);
    }

    public async Task UpdateTicketAsync(Ticket ticketToUpdate)
    {
        await _ticketRepository.Update(ticketToUpdate);
    }

    public async Task<bool> DeleteTicketAsync(Ticket ticket)
    {
        return await _ticketRepository.Delete(ticket);
    }
}