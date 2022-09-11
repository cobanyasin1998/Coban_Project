using Coban.SharedLibrary.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace Coban.SharedLibrary.Extension
{
    public static class AddCustomValidationResponse
    {

        public static void UseCustomValidationResponse(this IServiceCollection services)
        {
            services.Configure<ApiBehaviorOptions>(opt =>
            {
                opt.InvalidModelStateResponseFactory = context =>
                {
                    var errors = context.ModelState.Values.Where(x => x.Errors.Count > 0).SelectMany(x => x.Errors).Select(x => x.ErrorMessage);

                    ErrorDTO errorDTO = new ErrorDTO(errors.ToList(), true);

                    var response = ResponseDTO<NoContentResult>.Fail(errorDTO, 400);

                    return new BadRequestObjectResult(response);
                };

            });
        }
    }
}
