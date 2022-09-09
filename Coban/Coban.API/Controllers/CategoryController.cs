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
        public async Task<IActionResult> GetProducts()
        {
            return ActionResultInstance(await _catService.GetAllAsync());
        }

        [HttpPost]
        public async Task<IActionResult> SaveProducts(ProductDTO productDTO)
        {
            return ActionResultInstance(await _catService.AddAsync(productDTO));
        }
        [HttpPut]
        public async Task<IActionResult> UpdateProduct(ProductDTO productDTO)
        {
            return ActionResultInstance(await _catService.UpdateAsync(productDTO, productDTO.Id));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            return ActionResultInstance(await _catService.Remove(id));
        }
    }
}
