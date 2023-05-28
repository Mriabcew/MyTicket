using MyTicket.Common.Converters;
using MyTicket.DAL.Interfaces;
using MyTicket.DAL.Repositories;
using MyTicket.Domain;
using MyTicket.DTO;
using MyTicket.Services.Interfaces;

namespace MyTicket.Services.Services;

public class TicketService : ITicketService
{
    private readonly ITicketRepository _ticketRepository;

    public TicketService(ITicketRepository ticketRepository)
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

    public async Task<List<TicketDTO>> GetTicketsByUserId(int userId)
    {
        return (await _ticketRepository.GetTicketsByUserId(userId)).Select(x=>x.ToDTO()).ToList();
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