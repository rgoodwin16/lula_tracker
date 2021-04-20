using System;
using System.Threading.Tasks;
using Application.Responses.Projects;
using Application.Services.Projects;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("/projects")]
    public class ProjectsController : ControllerBase
    {
        private readonly IProjectService _projectService;
        public ProjectsController(IProjectService projectService)
        {
            _projectService = projectService;
        }
        public async Task<IActionResult> Post(string name)
        {
            try
            {
                return Ok(await _projectService.CreateAsync(name));
            }
            catch (Exception ex)
            {
                
               return BadRequest(ex.Message);
            }
        }
    }
}