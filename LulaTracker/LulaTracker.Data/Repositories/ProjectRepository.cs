using System.Linq;
using LulaTracker.Core.Entities;
using LulaTracker.Application.Interfaces.Repositories;

namespace LulaTracker.Data.Repositories
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly DataContext _context;
        public ProjectRepository(DataContext context)
        {
            _context = context;
        }

        public Project GetProjectById(int id)
        {
            return _context.Projects.FirstOrDefault(p => p.Id == id);
        }

        public Project GetProjectByName(string name)
        {
            throw new System.NotImplementedException();
        }
    }
}