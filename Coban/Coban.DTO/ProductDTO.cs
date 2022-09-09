using Coban.Core.EntityBase;
using System;

namespace Coban.DTO
{
    public class ProductDTO : DTOEntityBase<long>
    {
        public long Id { get; set; }
        public int MyProperty { get; set; }
        public string Name { get; set; }
        public Decimal Price { get; set; }
        public int Stock { get; set; }
        public string Description { get; set; }
    }
}
