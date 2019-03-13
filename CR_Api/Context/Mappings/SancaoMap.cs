using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Context.Mappings
{
    internal class SancaoMap : EntityTypeConfiguration<Sancao>
    {
        public SancaoMap()
        {
            //Primary key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.anoRefProcesso).IsRequired();
            Property(t => t.municipioProcesso).IsRequired().HasMaxLength(100);
            Property(t => t.nomeDevedor).IsRequired().HasMaxLength(100);
            Property(t => t.numCpfCgcPte).IsRequired().IsFixedLength().HasMaxLength(11);
            Property(t => t.Irregularidade).HasMaxLength(4000);
            Property(t => t.Status).IsRequired();
            Property(t => t.DataCadastro).IsRequired();

            //Table & Colum Mappings
            ToTable("SANCAO", DbConfig.DbSchema);
            Property(t => t.Id).HasColumnName("COD_SANCAO");
            Property(t => t.anoRefProcesso).HasColumnName("ANO_SANCAO");
            Property(t => t.municipioProcesso).HasColumnName("NOM_MUNICIPIO");
            Property(t => t.nomeDevedor).HasColumnName("DSC_NOME");
            Property(t => t.numCpfCgcPte).HasColumnName("NUM_CPF");
            Property(t => t.Irregularidade).HasColumnName("DSC_IRREGULARIDADE");
            Property(t => t.Status).HasColumnName("IND_STATUS");
            Property(t => t.DataCadastro).HasColumnName("DAT_CADASTRO");
            Property(t => t.IdArquivo).HasColumnName("COD_ARQUIVO");
            Property(t => t.anoTransito).HasColumnName("ANO_TRANSITO");
        }
    }
}
