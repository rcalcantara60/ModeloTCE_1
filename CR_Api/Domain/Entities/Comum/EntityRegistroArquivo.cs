namespace Domain.Entities.Comum
{
    public abstract class EntityRegistroArquivo<TEntity> : EntityBaseLocal<TEntity> where TEntity : class
    {
        public long IdArquivo { get; set; }
    }
}
