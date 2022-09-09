using Coban.Entities.Base;

namespace Coban.Entities.Entity
{
    public  class Category : BaseEntity<int>
    {
      
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
