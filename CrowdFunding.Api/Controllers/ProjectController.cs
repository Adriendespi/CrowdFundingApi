using CrowdFundingBLL.Interfaces;
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

       
    }
}
