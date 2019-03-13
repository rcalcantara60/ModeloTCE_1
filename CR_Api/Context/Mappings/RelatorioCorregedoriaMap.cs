using Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Context.Mappings
{
    internal class RelatorioCorregedoriaMap : EntityTypeConfiguration<RelatorioCorregedoria>
    {
        public RelatorioCorregedoriaMap()
        {
            //Primary key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.Descricao).IsOptional().HasMaxLength(250);
            Property(t => t.Mensal).IsRequired();
            Property(t => t.Mes).IsOptional();
            Property(t => t.Trimestral).IsRequired();
            Property(t => t.Trimestre).IsOptional();
            Property(t => t.Anual).IsRequired();
            Property(t => t.Ano).IsRequired();
            Property(t => t.Url).IsRequired().HasMaxLength(250);
            Property(t => t.Status).IsRequired();
            Property(t => t.DataCadastro).IsRequired();

            //Table & Colum Mappings
            ToTable("RELATORIO_CORREGEDORIA", DbConfig.DbSchema);
            Property(t => t.Id).HasColumnName("COD_RELATORIO_CORREGEDORIA");
            Property(t => t.Descricao).HasColumnName("DSC_RELATORIO");
            Property(t => t.Mensal).HasColumnName("IND_MENSAL");
            Property(t => t.Mes).HasColumnName("NUM_MES");
            Property(t => t.Trimestral).HasColumnName("IND_TRIMESTRAL");
            Property(t => t.Trimestre).HasColumnName("NUM_TRIMESTRE");
            Property(t => t.Anual).HasColumnName("IND_ANUAL");
            Property(t => t.Ano).HasColumnName("ANO_RELATORIO");
            Property(t => t.Url).HasColumnName("URL_RELATORIO");
            Property(t => t.Status).HasColumnName("IND_STATUS");
            Property(t => t.DataCadastro).HasColumnName("DAT_CADASTRO");
            Property(t => t.IdArquivo).HasColumnName("COD_ARQUIVO");

        }
    }
}
