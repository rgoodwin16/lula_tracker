using System.Linq;
using LulaTracker.Core.Entities;
using LulaTracker.Application.Interfaces.Repositories;

namespace LulaTracker.Data.Repositories
{
    public class TicketCommentRepository : ITicketCommentRepository
    {
        private readonly DataContext _context;

        public TicketCommentRepository(DataContext context)
        {
            _context = context;
        }
        public TicketComment  GetTicketCommentById(int id)
        {
            return _context.TicketComments.FirstOrDefault(t => t.Id == id);
        }
    }
}