using Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Context.Mappings
{
    internal class TipoIndicadorMap : EntityTypeConfiguration<TipoIndicador>
    {
        public TipoIndicadorMap()
        {
            //Primary key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.NomTipoIndicador)
                .IsRequired()
                .IsFixedLength().HasMaxLength(50);

            //Table & Colum Mappings
            ToTable("TIPO_INDICADOR", DbConfig.DbSchema);
            Property(t => t.Id).HasColumnName("COD_TIPO_INDICADOR");
            Property(t => t.NomTipoIndicador).HasColumnName("NOM_TIPO_INDICADOR");

            //Relationships
            HasMany(t => t.Indicadores)
                .WithRequired(t => t.TipoIndicador)
                .HasForeignKey(t => t.IdTipoIndicador);
        }
    }
}
