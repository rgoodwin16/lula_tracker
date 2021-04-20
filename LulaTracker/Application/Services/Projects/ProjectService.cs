using System;
using System.Threading.Tasks;
using Application.Responses.Projects;
using Domain.Interfaces;

namespace Application.Services.Projects
{
    public class ProjectService : IProjectService
    {
        private readonly IProjectRepository _projectRepository;
        public ProjectService(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }
        public async Task<ProjectResponse> CreateAsync(string name)
        {
            if(string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException(nameof(name));
                
            var project = await _projectRepository.CreateAsync(name);
            return new ProjectResponse
            {
                Guid = project.Guid,
                Name = project.Name
            };
        }
    }
}