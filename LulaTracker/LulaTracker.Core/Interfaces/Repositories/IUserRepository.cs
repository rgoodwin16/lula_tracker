using LulaTracker.Core.Entities;

namespace LulaTracker.Core.Interfaces.Repositories
{
    public interface IUserRepository
    {
        User GetUserById(int id);
    }
}