using Coban.SharedLibrary.DTO;
using Microsoft.AspNetCore.Mvc;

namespace Coban.API.Controllers
{
    public class CustomBaseController : ControllerBase
    {
        public IActionResult ActionResultInstance<T>(ResponseDTO<T> response) where T : class
        {
            return new ObjectResult(response)
            {
                StatusCode = response.Status
            };
        }
    }
}
