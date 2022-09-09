using Coban.Core.Repositories;
using Coban.Core.Services;
using Coban.Core.UnitOfWork;
using Coban.SharedLibrary.DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Coban.Service.Services
{
    public class ServiceGeneric<TEntity, TDto> : IServiceGeneric<TEntity, TDto> where TEntity : class where TDto : class
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IGenericRepository<TEntity> _genericRepository;

        public ServiceGeneric(IUnitOfWork unitOfWork, IGenericRepository<TEntity> genericRepository)
        {
            _unitOfWork = unitOfWork;
            _genericRepository = genericRepository;
        }

        public async Task<ResponseDTO<TDto>> AddAsync(TDto entity)
        {
            var newEntity = ObjectMapper.Mapper.Map<TEntity>(entity);

            await _genericRepository.AddAsync(newEntity);

            await _unitOfWork.CommitAsync();

            var newDto = ObjectMapper.Mapper.Map<TDto>(newEntity);

            return ResponseDTO<TDto>.Success(newDto, 200);
        }

        public async Task<ResponseDTO<IEnumerable<TDto>>> GetAllAsync()
        {
            var products = ObjectMapper.Mapper.Map<List<TDto>>(await _genericRepository.GetAllAsync());

            return ResponseDTO<IEnumerable<TDto>>.Success(products, 200);
        }

        public async Task<ResponseDTO<TDto>> GetByIdAsync(int id)
        {
            var product = await _genericRepository.GetByIdAsync(id);
            if (product is null)
            {
                return ResponseDTO<TDto>.Fail("Id Not Found", 404, true);
            }
            return ResponseDTO<TDto>.Success(ObjectMapper.Mapper.Map<TDto>(product), 200);

        }

        public async Task<ResponseDTO<NoDataDTO>> Remove(int id)
        {
            var existEntity = await _genericRepository.GetByIdAsync(id);

            if (existEntity is null)
            {
                return ResponseDTO<NoDataDTO>.Fail("Id Not Found", 404, true);
            }
            _genericRepository.Remove(existEntity);
            await _unitOfWork.CommitAsync();
            return ResponseDTO<NoDataDTO>.Success(200);
        }

        public async Task<ResponseDTO<NoDataDTO>> UpdateAsync(TDto entity, int id)
        {
            var isExistEntity = await _genericRepository.GetByIdAsync(id);

            if (isExistEntity is null)
            {
                return ResponseDTO<NoDataDTO>.Fail("Id Not Found", 404, true);
            }

            var updateEntity = ObjectMapper.Mapper.Map<TEntity>(entity);
            _genericRepository.Update(updateEntity);

            await _unitOfWork.CommitAsync();

            return ResponseDTO<NoDataDTO>.Success(204);

        }

        public async Task<ResponseDTO<IEnumerable<TDto>>> Where(Expression<Func<TEntity, bool>> predicate)
        {
            var list = _genericRepository.Where(predicate);

            return ResponseDTO<IEnumerable<TDto>>.Success(ObjectMapper.Mapper.Map<IEnumerable<TDto>>(await list.ToListAsync()), 200);

        }


    }
}
