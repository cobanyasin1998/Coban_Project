using AutoMapper;
using Coban.DTO;
using Coban.Entities.Entity;

namespace Coban.Service
{
    public class DTOMapper : Profile
    {
        public DTOMapper()
        {
            CreateMap<ProductDTO, Product>().ReverseMap();
            CreateMap<CategoryDTO, Category>().ReverseMap();

        }
    }
}
