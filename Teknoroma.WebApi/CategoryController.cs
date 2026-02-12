using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Teknoroma.BLL.DesignPatterns.GenericRepository.ConcRep;
using Teknoroma.WebApi.Models;

namespace Teknoroma.WebApi
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        CategoryRepository _categoryRepo;
        public CategoryController()
        {
            _categoryRepo = new CategoryRepository();
        }

        [HttpGet("CategoryGetAll")]
        public IActionResult GetAll() 
        {
            try
            {
                var category = _categoryRepo.GetAll();

                if (category == null)
                {
                    return NotFound(new 
                    {
                        IsSuccess = false,
                        Message = "Kategoriler getirilemedi"
                    });
                }

                return Ok(new 
                {
                    IsSuccess = true,
                    Message = "Kategoriler getirildi",
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new LoginResponse 
                {
                    IsSuccess = false,
                    Message = ex.Message,
                });
            }
        }

        //[HttpPost("CategoryAdd")]
        //public IActionResult Add([FromBody] CategoryAddRequest item) 
        //{
        //    try
        //    {
        //        var category = _categoryRepo.Add(item.Name);
        //    }
        //    catch (Exception ex)
        //    {

        //        throw;
        //    }
        //}
    }
}
