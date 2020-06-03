using LulaTracker.Core.Entities;

namespace LulaTracker.Core.Interfaces.Repositories
{
    public interface ITicketAttachmentRepository
    {
        TicketAttachment GetTicketAttachmentById(int id);
    }
}