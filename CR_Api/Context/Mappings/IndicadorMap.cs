using Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Context.Mappings
{
    internal class IndicadorMap : EntityTypeConfiguration<Indicador>
    {
        public IndicadorMap()
        {
            //Primary key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.IdTipoIndicador).IsRequired();
            Property(t => t.SglIndicador).IsRequired()
                .IsFixedLength()
                .HasMaxLength(5);
            Property(t => t.DscIndicador).IsRequired()
                .HasMaxLength(100);

            //Table & Colum Mappings
            ToTable("INDICADOR", DbConfig.DbSchema);
            Property(t => t.Id).HasColumnName("COD_INDICADOR");
            Property(t => t.IdTipoIndicador).HasColumnName("COD_TIPO_INDICADOR");
            Property(t => t.DscIndicador).HasColumnName("DSC_INDICADOR");
            Property(t => t.SglIndicador).HasColumnName("SGL_INDICADOR");

            //Relationships
            HasMany(t => t.ArquivosCategoria)
                .WithRequired(t => t.Categoria)
                .HasForeignKey(t => t.IdCategoria);
            HasMany(t => t.ArquivosSituacao)
                .WithRequired(t => t.Situacao)
                .HasForeignKey(t => t.IdSituacao);
            HasMany(t => t.ArquivosStatus)
                .WithRequired(t => t.Status)
                .HasForeignKey(t => t.IdStatus);

            HasRequired(t => t.TipoIndicador)
                .WithMany(t => t.Indicadores)
                .HasForeignKey(t => t.IdTipoIndicador);
        }
    }
}
