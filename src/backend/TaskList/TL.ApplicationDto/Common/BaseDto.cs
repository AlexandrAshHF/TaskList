using Mapster;

namespace TL.ApplicationDto.Common
{
    public abstract class BaseDto<TDto, TEntity> : IRegister
        where TDto : class
    where TEntity : class, new()
    {
        public TEntity ToEntity()
        {
            return this.Adapt<TEntity>();
        }

        public TEntity ToEntity(TEntity entity)
        {
            return (this as TDto).Adapt(entity);
        }

        public static TDto FromEntity(TEntity entity)
        {
            return entity.Adapt<TDto>();
        }

        private TypeAdapterConfig Config { get; set; }

        protected virtual void Mapping()
        {

        }

        protected TypeAdapterSetter<TDto, TEntity> Set() => Config.ForType<TDto, TEntity>();

        protected TypeAdapterSetter<TEntity, TDto> SetInverse() => Config.ForType<TEntity, TDto>();

        public void Register(TypeAdapterConfig config)
        {
            Config = config;
            Mapping();
        }
    }

}
