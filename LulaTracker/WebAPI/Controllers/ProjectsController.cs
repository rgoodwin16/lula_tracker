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

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] AddProjectRequest request)
        {
            try
            {
                return Ok(await _projectService.CreateAsync(request.Name));
            }
            catch (Exception ex)
            {
                
               return BadRequest(ex.Message);
            }
        }
    }

    public class AddProjectRequest
    {
        public string Name { get; set; }
    }
}