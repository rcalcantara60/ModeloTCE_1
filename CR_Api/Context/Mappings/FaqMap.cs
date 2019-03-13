using Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Context.Mappings
{
    internal class FaqMap : EntityTypeConfiguration<Faq>
    {
        public FaqMap()
        {
            //Primary key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.Pergunta).IsRequired().HasMaxLength(4000);
            Property(t => t.Resposta).IsRequired().HasMaxLength(4000);
            Property(t => t.Status).IsRequired();
            Property(t => t.DataCadastro).IsRequired();

            //Table & Colum Mappings
            ToTable("FAQ", DbConfig.DbSchema);
            Property(t => t.Id).HasColumnName("COD_FAQ");
            Property(t => t.Pergunta).HasColumnName("DSC_PERGUNTA");
            Property(t => t.Resposta).HasColumnName("DSC_RESPOSTA");
            Property(t => t.Status).HasColumnName("IND_STATUS");
            Property(t => t.DataCadastro).HasColumnName("DAT_CADASTRO");
            Property(t => t.IdArquivo).HasColumnName("COD_ARQUIVO");
        }
    }
}
