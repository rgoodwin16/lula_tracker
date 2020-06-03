using LulaTracker.Core.Entities;

namespace LulaTracker.Core.Interfaces.Repositories
{
    public interface ITicketCommentRepository
    {
        TicketComment GetTicketCommentById(int id);
    }
}