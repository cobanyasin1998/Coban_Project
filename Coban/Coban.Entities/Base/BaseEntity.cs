using Coban.Core.EntityBase;
using System;

namespace Coban.Entities.Base
{
    public class BaseEntity<T> : IFullEntityBase<T>
    {
        public T Id { get; set; }
        public DateTime AddedTime { get; set; }
        public T AddedUser { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public T ModifiedUser { get; set; }
       
    }
}