using LulaTracker.Core.Entities;

namespace LulaTracker.Application.Interfaces.Repositories
{
    public interface ITicketCommentRepository
    {
        TicketComment GetTicketCommentById(int id);
    }
}