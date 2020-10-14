using LulaTracker.Core.Entities;

namespace LulaTracker.Application.Interfaces.Repositories
{
    public interface IProjectRepository
    {
        Project GetProjectById(int id);

        Project GetProjectByName(string name);

    }
}