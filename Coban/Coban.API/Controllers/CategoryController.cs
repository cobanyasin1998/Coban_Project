using Coban.Core.Services;
using Coban.DTO;
using Coban.Entities.Entity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Coban.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : CustomBaseController
    {

        private IServiceGeneric<Category, CategoryDTO> _catService;
        public CategoryController(IServiceGeneric<Category, CategoryDTO> catService)
        {
            _catService = catService;
        }

        [HttpGet]
        public async Task<IActionResult> GetCategories()
        {
            var cats = await _catService.GetAllAsync();
            return ActionResultInstance(cats);
        }

        [HttpPost]
        public async Task<IActionResult> SaveProducts(CategoryDTO catDTO)
        {
            return ActionResultInstance(await _catService.AddAsync(catDTO));
        }
        [HttpPut]
        public async Task<IActionResult> UpdateProduct(CategoryDTO catDTO)
        {
            return ActionResultInstance(await _catService.UpdateAsync(catDTO, catDTO.Id));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            return ActionResultInstance(await _catService.Remove(id));
        }
    }
}
