using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SPS.Data.Models;
using SPS.Services.Interface.ProductAdmin;
using SPS.Services.Services.ProductAdmin;
using System.Net;

namespace SPS.API.Controllers.ProductAdmin
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [HttpGet]
        public IActionResult GetCategory()
        {
            var responseData = _categoryService.GetCategory();
            return Ok(responseData);
        }
        [HttpPost]
        public IActionResult Post(Category category)
        {
            _categoryService.AddCategory(category);
            return Ok();
        }


    }
}
