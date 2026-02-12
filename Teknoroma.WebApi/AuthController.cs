using Microsoft.AspNetCore.Mvc;
using Teknoroma.BLL.DesignPatterns.GenericRepository.ConcRep;
using Teknoroma.WebApi.Models;

namespace Teknoroma.WebApi
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        UserRepository _userRepo;

        public AuthController()
        {
            _userRepo = new UserRepository();
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequest request) 
        {
            try
            {
                var user = _userRepo.Login(request.UserName, request.Password);

                if (user == null)
                {
                    return Unauthorized(new LoginResponse
                    {
                        IsSuccess = true,
                        Message = "Kullanıcı adı veya şifre hatalı"
                    });
                }

                return Ok(new LoginResponse
                {
                    IsSuccess = true,
                    Message = "Giriş başarılı",
                    UserId = user.ID,
                    UserName = user.UserName,
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new LoginResponse 
                {
                    IsSuccess = false,
                    Message = ex.Message
                });
            }
        }

        [HttpPost("test")]
        public IActionResult Login2([FromBody] LoginRequest request)
        {
            try
            {
                var user = _userRepo.Login(request.UserName, request.Password);

                if (user == null)
                {
                    return Unauthorized(new LoginResponse
                    {
                        IsSuccess = true,
                        Message = "Kullanıcı adı veya şifre hatalı"
                    });
                }

                return Ok(new LoginResponse
                {
                    IsSuccess = true,
                    Message = "Giriş başarılı",
                    UserId = user.ID,
                    UserName = user.UserName,
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new LoginResponse
                {
                    IsSuccess = false,
                    Message = ex.Message
                });
            }
        }
    }
}
