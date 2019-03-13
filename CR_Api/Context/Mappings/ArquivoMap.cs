using Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Context.Mappings
{
    internal class ArquivoMap : EntityTypeConfiguration<Arquivo>
    {
        public ArquivoMap()
        {
            //Primary key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.IdCategoria).IsRequired();
            Property(t => t.IdSituacao).IsRequired();
            Property(t => t.IdStatus).IsRequired();

            Property(t => t.ByArquivo).IsRequired();

            Property(t => t.Extensao).IsRequired()
                .IsFixedLength()
                .HasMaxLength(5);
            Property(t => t.MimeType).IsRequired()
                .IsFixedLength()
                .HasMaxLength(100);

            Property(t => t.IdPessoa).IsRequired();
            Property(t => t.DataCadastro).IsRequired();

            //Table & Colum Mappings
            ToTable("ARQUIVO", DbConfig.DbSchema);
            Property(t => t.Id).HasColumnName("COD_ARQUIVO");
            Property(t => t.IdCategoria).HasColumnName("COD_CATEGORIA");
            Property(t => t.IdSituacao).HasColumnName("COD_SITUACAO");
            Property(t => t.IdStatus).HasColumnName("COD_STATUS");
            Property(t => t.ByArquivo).HasColumnName("ARQUIVO");
            Property(t => t.Extensao).HasColumnName("DSC_EXTENSAO");
            Property(t => t.MimeType).HasColumnName("DSC_MIME_TYPE");
            Property(t => t.IdPessoa).HasColumnName("COD_USUARIO_CAD");
            Property(t => t.DataCadastro).HasColumnName("DAT_CADASTRO");

            //Relationships
            HasRequired(t => t.Categoria)
              .WithMany(t => t.ArquivosCategoria)
              .HasForeignKey(t => t.IdCategoria);

            HasRequired(t => t.Situacao)
              .WithMany(t => t.ArquivosSituacao)
              .HasForeignKey(t => t.IdSituacao);

            HasRequired(t => t.Status)
              .WithMany(t => t.ArquivosStatus)
              .HasForeignKey(t => t.IdStatus);
        }
    }
}