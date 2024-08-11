using CodePulse.API.Data;
using CodePulse.API.Models.Domain;
using CodePulse.API.Models.DTOs;
using CodePulse.API.Respository.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CodePulse.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriesController : Controller
    {

        private ICategoryRespository categoryRespository;
        public CategoriesController(ICategoryRespository categoryRespository)
        {
            this.categoryRespository = categoryRespository;
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoriesDTO createCategoriesDTO)
        {
            var category = new Category
            {
                Name = createCategoriesDTO.Name,
                UrlHandle = createCategoriesDTO.UrlHandle,
            };
            await categoryRespository.CreateAsync(category);

            return Ok();
        }
    }
}
