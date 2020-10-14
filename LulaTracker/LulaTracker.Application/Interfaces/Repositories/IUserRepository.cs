using LulaTracker.Core.Entities;

namespace LulaTracker.Application.Interfaces.Repositories
{
    public interface IUserRepository
    {
        User GetUserById(int id);
    }
}