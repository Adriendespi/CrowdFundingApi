using CrowdFundingBLL.Interfaces;
using CrowdFundingBLL.Services;
using CrowdFundingBLL.Tools.DTO.ProjectDTO;
using CrowdFundingBLL.Tools.Mappers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CrowdFunding.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : Controller
    {
       private IProjectService _projectService;

        public ProjectController(IProjectService projectService)
        {
            _projectService= projectService;
        }

        [HttpGet("{id}")]
        public IActionResult GetProject(int id)
        {
            try
            {
                return Ok(_projectService.GetProject(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
           
        }
        [HttpGet("GetAll")]
        public IActionResult GetAllProject()
        {
            try
            {
                return Ok(_projectService.GetAllProjects());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        
        [HttpPost]
       
        public IActionResult InsertProject(ProjectCreate project)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                _projectService.CreateProject(project);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete("{id}")]
        [Authorize("Auth")]
        public IActionResult DeleteProject(int id)
        {
            try
            {
                _projectService.DeleteProject(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPatch("{id}")]
        [Authorize("Auth")]
        public IActionResult UpdateProject(int id, ProjectCreate project)
        {
            try
            {
                _projectService.UpdateProject(id,project);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }



    }
}
