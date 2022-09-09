using Coban.SharedLibrary.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
