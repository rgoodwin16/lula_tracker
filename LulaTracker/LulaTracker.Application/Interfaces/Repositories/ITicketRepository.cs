using LulaTracker.Core.Entities;

namespace LulaTracker.Application.Interfaces.Repositories
{
    public interface ITicketRepository
    {
        Ticket GetTicketById(int id);
    } 
}