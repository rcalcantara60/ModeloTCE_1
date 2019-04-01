using Context.Mappings.Comum;
using Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Context.Mappings
{
    internal class COUNTRyMap : EntityBaseMap<COUNTRy>
    {
        public COUNTRyMap()
        {
            // Primary Key
            this.HasKey(t => t.COUNTRY_ID);

            // Properties
            this.Property(t => t.COUNTRY_ID)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.COUNTRY_NAME)
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("COUNTRIES", Context.DbSchema);
            this.Property(t => t.COUNTRY_ID).HasColumnName("COUNTRY_ID");
            this.Property(t => t.COUNTRY_NAME).HasColumnName("COUNTRY_NAME");
            this.Property(t => t.REGION_ID).HasColumnName("REGION_ID");

            // Relationships
            this.HasOptional(t => t.REGION)
                .WithMany(t => t.COUNTRIES)
                .HasForeignKey(d => d.REGION_ID);

        }
    }
}
