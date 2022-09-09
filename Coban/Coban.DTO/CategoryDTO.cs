using Coban.Core.EntityBase;

namespace Coban.DTO
{
    public class CategoryDTO : DTOEntityBase<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
       
    }
}
