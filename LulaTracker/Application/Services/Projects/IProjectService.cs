using System;
using System.Threading.Tasks;
using Application.Responses.Projects;

namespace Application.Services.Projects
{
    public interface IProjectService
    {
         Task<ProjectResponse> CreateAsync(string name);
         Task DeleteAsync(int id);
         Task DeleteAsync(string guid);
         
    }
}