using System.Linq;
using LulaTracker.Core.Entities;
using LulaTracker.Application.Interfaces.Repositories;

namespace LulaTracker.Data.Repositories
{
    public class TicketAttachmentRepository : ITicketAttachmentRepository
    {
        private readonly DataContext _context;

        public TicketAttachmentRepository(DataContext context)
        {
            _context = context;
        }
        public TicketAttachment GetTicketAttachmentById(int id)
        {
            return _context.TicketAttachments.FirstOrDefault(t => t.Id == id);
        }
    }
}