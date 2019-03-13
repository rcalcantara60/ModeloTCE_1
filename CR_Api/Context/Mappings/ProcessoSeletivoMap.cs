using Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Context.Mappings
{
    internal class ProcessoSeletivoMap : EntityTypeConfiguration<ProcessoSeletivo>
    {
        public ProcessoSeletivoMap()
        {
            //Primary key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.Numero).IsRequired();
            Property(t => t.Ano).IsRequired();
            Property(t => t.Titulo).IsOptional().HasMaxLength(250);
            Property(t => t.Objeto).IsRequired().HasMaxLength(4000);
            Property(t => t.DataInicio).IsRequired();
            Property(t => t.DataFim).IsOptional();
            Property(t => t.DataDivulgacao).IsOptional();
            Property(t => t.Url).IsRequired().HasMaxLength(250);
            Property(t => t.Status).IsRequired();
            Property(t => t.DataCadastro).IsRequired();

            //Table & Colum Mappings
            ToTable("PROCESSO_SELETIVO", DbConfig.DbSchema);
            Property(t => t.Id).HasColumnName("COD_PROCESSO_SELETIVO");
            Property(t => t.Numero).HasColumnName("NUM_EDITAL");
            Property(t => t.Ano).HasColumnName("ANO_EDITAL");
            Property(t => t.Titulo).HasColumnName("DSC_TITULO");
            Property(t => t.Objeto).HasColumnName("DSC_OBJETO");
            Property(t => t.DataInicio).HasColumnName("DAT_INICIO_PROCESSO");
            Property(t => t.DataFim).HasColumnName("DAT_FIM_PROCESSO");
            Property(t => t.DataDivulgacao).HasColumnName("DAT_DIVULGACAO_RESULTADO");
            Property(t => t.Url).HasColumnName("URL_EDITAL");
            Property(t => t.Status).HasColumnName("IND_STATUS");
            Property(t => t.DataCadastro).HasColumnName("DAT_CADASTRO");
            Property(t => t.IdArquivo).HasColumnName("COD_ARQUIVO");
        }
    }
}
