using Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Context.Mappings
{
    internal class ListaTREMap : EntityTypeConfiguration<ListaTRE>
    {
        public ListaTREMap()
        {
            //Primary key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.Cpf).IsRequired().IsFixedLength().HasMaxLength(11);
            Property(t => t.Nome).IsRequired().HasMaxLength(250);
            Property(t => t.Processo).IsRequired();
            Property(t => t.DataSessao).IsRequired();
            Property(t => t.Decisao).IsRequired().HasMaxLength(4000);
            Property(t => t.DataTransitoJulgado).IsOptional();
            Property(t => t.Municipio).IsRequired().HasMaxLength(100);
            Property(t => t.NotaTaq).IsOptional();
            Property(t => t.Acordao).IsOptional();
            Property(t => t.ProcessoCNX).IsOptional();
            Property(t => t.NotaTaqConexo).IsOptional();
            Property(t => t.AcordaoConexo).IsOptional();
            Property(t => t.Status).IsRequired();
            Property(t => t.DataCadastro).IsRequired();

            //Table & Colum Mappings
            ToTable("LISTA_TRE", DbConfig.DbSchema);
            Property(t => t.Id).HasColumnName("COD_LISTA_TRE");
            Property(t => t.Cpf).HasColumnName("NUM_CPF");
            Property(t => t.Nome).HasColumnName("DSC_NOME");
            Property(t => t.Processo).HasColumnName("NUM_PROCESSO");
            Property(t => t.DataSessao).HasColumnName("DAT_SESSAO_TCE");
            Property(t => t.Decisao).HasColumnName("DSC_DECISAO_TCE");
            Property(t => t.DataTransitoJulgado).HasColumnName("DAT_TRANSITO_EM_JULGADO");
            Property(t => t.Municipio).HasColumnName("NOM_MUNICIPIO");
            Property(t => t.NotaTaq).HasColumnName("NUM_NOTA_TAQ");
            Property(t => t.Acordao).HasColumnName("NUM_ACORDAO");
            Property(t => t.ProcessoCNX).HasColumnName("NUM_PROCESSO_CNX");
            Property(t => t.NotaTaqConexo).HasColumnName("NUM_NOTA_TAQ_CONEXO");
            Property(t => t.AcordaoConexo).HasColumnName("NUM_ACORDAO_CONEXO");
            Property(t => t.Status).HasColumnName("INT_STATUS");
            Property(t => t.DataCadastro).HasColumnName("DAT_CADASTRO");
            Property(t => t.IdArquivo).HasColumnName("COD_ARQUIVO");
        }
    }
}
