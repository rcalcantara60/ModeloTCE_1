using Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Context.Mappings
{
    internal class GlossarioMap : EntityTypeConfiguration<Glossario>
    {
        public GlossarioMap()
        {
            //Primary key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.Palavra).IsRequired().HasMaxLength(45);
            Property(t => t.Descricao).IsRequired().HasMaxLength(4000);
            Property(t => t.Status).IsRequired();
            Property(t => t.DataCadastro).IsRequired();

            //Table & Colum Mappings
            ToTable("GLOSSARIO", DbConfig.DbSchema);
            Property(t => t.Id).HasColumnName("COD_GLOSSARIO");
            Property(t => t.Palavra).HasColumnName("DSC_PALAVRA");
            Property(t => t.Descricao).HasColumnName("DSC_DESCRICAO");
            Property(t => t.Status).HasColumnName("INT_STATUS");
            Property(t => t.DataCadastro).HasColumnName("DAT_CADASTRO");
            Property(t => t.IdArquivo).HasColumnName("COD_ARQUIVO");
        }
    }
}
