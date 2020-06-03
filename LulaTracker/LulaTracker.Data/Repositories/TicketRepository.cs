using System.Linq;
using LulaTracker.Core.Entities;
using LulaTracker.Core.Interfaces.Repositories;

namespace LulaTracker.Data.Repositories
{
    public class TicketRepository : ITicketRepository
    {
        private readonly DataContext _context;

        public TicketRepository(DataContext context)
        {
            _context = context;
        }
        public Ticket GetTicketById(int id)
        {
            return _context.Tickets.FirstOrDefault(t => t.Id == id);
        }
    }
}