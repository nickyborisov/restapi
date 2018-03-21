namespace WebApi.Services.Interfaces
{
    public interface IMapper<TDto, TEntity>
    {
        TDto MapEntity(TEntity entity);

        TEntity MapDto(TDto model);
    }
}
