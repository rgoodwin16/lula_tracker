using LulaTracker.Core.Entities;

namespace LulaTracker.Core.Interfaces.Repositories
{
    public interface IProjectRepository
    {
        Project GetProjectById(int id);

        Project GetProjectByName(string name);

    }
}