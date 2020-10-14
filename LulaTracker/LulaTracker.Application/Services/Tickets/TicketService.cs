using LulaTracker.Core.Entities;
using LulaTracker.Application.Interfaces.Repositories;

namespace LulaTracker.Application.Services.Tickets
{
    public class TicketService
    {
        private readonly ITicketRepository _ticketRepository;
        public TicketService(ITicketRepository ticketRepository)
        {
            _ticketRepository = ticketRepository;
        }


        public Ticket GetTicketById(int id)
        {
            return _ticketRepository.GetTicketById(id);
        }
    }
}