using CrowdFundingBLL.Interfaces;
using CrowdFundingBLL.Services;
using CrowdFundingBLL.Tools.DTO.CommentaryDTO;
using CrowdFundingBLL.Tools.DTO.ProjectDTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CrowdFunding.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentaryController : Controller
    {
        private ICommentaryService _commentaryService;
        public CommentaryController(ICommentaryService commentaryService)
        {
            _commentaryService = commentaryService;
        }

        [HttpGet("{id}")]
        public IActionResult GetComment(int id) 
        { 
            try
            {
                return Ok(_commentaryService.GetCommentary(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("GetAllfrom/{id}")]
        public IActionResult GetAllCommentFromProject(int id)
        {
            try
            {
                return Ok(_commentaryService.GetAllCommentFromProjects(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Authorize("Auth")]
        public IActionResult InsertComment(CommentaryCreate commentary)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                _commentaryService.CreateCommentary(commentary);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete("{id}")]
        [Authorize("Auth")]
        public IActionResult DeleteComment(int id)
        {
            try
            {
               ;
                return Ok(_commentaryService.DeleteCommentary(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPatch("{id}")]
        [Authorize("Auth")]
        public IActionResult UpdateComment(int id,CommentaryCreate comment )
        {
            try
            {
               
                return Ok(_commentaryService.UpdateCommentary(id,comment));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
