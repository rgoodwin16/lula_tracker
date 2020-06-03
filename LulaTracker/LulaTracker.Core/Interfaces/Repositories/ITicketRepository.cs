using LulaTracker.Core.Entities;

namespace LulaTracker.Core.Interfaces.Repositories
{
    public interface ITicketRepository
    {
        Ticket GetTicketById(int id);
    } 
}