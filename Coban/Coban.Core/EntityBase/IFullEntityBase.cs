using System;

namespace Coban.Core.EntityBase
{
    public interface IFullEntityBase<T>
    {
        T Id { get; set; }
        DateTime AddedTime { get; set; }
        T AddedUser { get; set; }
        DateTime? ModifiedTime { get; set; }
        T ModifiedUser { get; set; }
    }
}
