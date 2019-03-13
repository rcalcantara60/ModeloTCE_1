using Domain.Entities.Comum;
using System.Data.Entity.ModelConfiguration;


namespace Context.Mappings.Comum
{
    internal abstract class EntityBaseMap<T> : EntityTypeConfiguration<T> where T : EntityBaseLocal<T>
    {
        public EntityBaseMap()
        {
            //Primary key
            //HasKey(t => t.Id);
            Ignore(t => t.Id);

            //Ignore
            Ignore(t => t.ValidationResult);
        }
    }
}
