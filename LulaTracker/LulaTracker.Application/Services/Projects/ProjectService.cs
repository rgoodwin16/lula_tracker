using LulaTracker.Core.Entities;
using LulaTracker.Application.Interfaces.Repositories;

namespace LulaTracker.Application.Services.Projects
{
    public class ProjectsService
    {
        private readonly IProjectRepository _projectRepository;
        public ProjectsService(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }


        public Project GetProjectById(int id)
        {
            return _projectRepository.GetProjectById(id);
        }
    }
}