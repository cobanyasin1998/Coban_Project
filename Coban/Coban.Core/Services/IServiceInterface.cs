using Coban.SharedLibrary.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Coban.Core.Services
{
    public interface IServiceGeneric<TEntity, TDto> where TEntity : class where TDto : class
    {
        Task<ResponseDTO<TDto>> GetByIdAsync(int id);
        Task<ResponseDTO<IEnumerable<TDto>>> GetAllAsync();
        Task<ResponseDTO<IEnumerable<TDto>>> Where(Expression<Func<TEntity, bool>> predicate);
        Task<ResponseDTO<TDto>> AddAsync(TDto entity);
        Task<ResponseDTO<NoDataDTO>> Remove(int id);
        Task<ResponseDTO<NoDataDTO>> UpdateAsync(TDto entity, int id);
    }
}
