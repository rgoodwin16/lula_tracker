using LulaTracker.Core.Entities;

namespace LulaTracker.Application.Interfaces.Repositories
{
    public interface ITicketAttachmentRepository
    {
        TicketAttachment GetTicketAttachmentById(int id);
    }
}