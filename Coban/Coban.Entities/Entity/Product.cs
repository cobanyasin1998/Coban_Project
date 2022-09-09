using Coban.Entities.Base;
using System;

namespace Coban.Entities.Entity
{
    public class Product : BaseEntity<long>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public Decimal Price { get; set; }
        public int Stock { get; set; }
        public string Description { get; set; }
        public string CategoryId { get; set; }

    }
}
