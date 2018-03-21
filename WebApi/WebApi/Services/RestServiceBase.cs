using Domain;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;
using WebApi.Services.Interfaces;

namespace WebApi.Services
{
    public class RestServiceBase<TDto, TEntity> : IRestService<TDto>
        where TDto : BaseModel
        where TEntity : BaseEntity
    {
        public RestServiceBase(IMapper<TDto, TEntity> mapper, IAsyncRepository<TEntity> repository)
        {
            Mapper = mapper;
            Repository = repository;
        }

        public IMapper<TDto, TEntity> Mapper { get; }

        public IAsyncRepository<TEntity> Repository { get; }

        public async virtual Task<TDto> AddAsync(TDto dto)
        {
            var entity = Mapper.MapDto(dto);
            await Repository.AddAsync(entity);
            dto.Id = entity.Id;
            return dto;
        }

        public async virtual Task DeleteAsync(int id)
        {
            await Repository.DeleteAsync(id);
        }

        public async virtual Task<TDto> GetByIdAsync(int id)
        {
            var e = await Repository.GetByIdAsync(id);
            return Mapper.MapEntity(e);
        }

        public async virtual Task<List<TDto>> ListAllAsync()
        {
            var data = await Repository.ListAllAsync();
            var dtos = data.Select(e => Mapper.MapEntity(e)).ToList();
            return dtos;
        }

        public virtual Task UpdateAsync(TDto dto)
        {
            var entity = Mapper.MapDto(dto);
            return Repository.UpdateAsync(entity);
        }
    }
}
