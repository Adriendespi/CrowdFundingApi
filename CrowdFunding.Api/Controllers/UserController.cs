using CrowdFunding.Api.Infrastructure;
using CrowdFunding.Api.Model;
using CrowdFunding.Api.Tools;
using CrowdFundingBLL.Interfaces;
using CrowdFundingBLL.Tools.DTO.UserDTO;
using CrowdFundingBLL.Tools.Mappers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CrowdFunding.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserService _userService;
        private TokenManager _tokkenManager;

        public UserController(IUserService userService,TokenManager tokenManager)
        {
            _tokkenManager= tokenManager;
            _userService= userService;
        }
        [HttpPost("/register")]
        public ActionResult Register(UserRegister user) 
        {
            if(!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                _userService.Register(user);
                return Ok();
            }    
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            

        }
        [HttpPost("/login")]
        public IActionResult Login(UserLogin user)
        {
            UserApi currentuser = _userService.Login(user).ToBLL().ToApi();
            currentuser.Token = _tokkenManager.GenerateToken(currentuser);
            return Ok(currentuser.Token);

        }
        [HttpGet("{id}")]
        public IActionResult GetUser(int id)
        {
            try
            {
                return Ok(_userService.GetUser(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet]
        public IActionResult GetAllUser()
        {
            try
            {
                return Ok(GetAllUser());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete("{id}")]
        [Authorize("Auth")]
        public IActionResult Delete(int id)
        {
            try
            {
                _userService.Delete(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPatch]
        [Authorize("Auth")]
        public IActionResult Update(int id)
        {
            try
            {
                _userService.Update(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }



    }


        
       
    }
}
