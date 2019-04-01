using Context.Mappings.Comum;
using Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Context.Mappings
{
    internal class REGIONMap : EntityBaseMap<REGION>
    {
        public REGIONMap()
        {
            // Primary Key
            this.HasKey(t => t.REGION_ID);

            // Properties
            this.Property(t => t.REGION_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.REGION_NAME)
                .HasMaxLength(25);

            // Table & Column Mappings
            this.ToTable("REGIONS", Context.DbSchema);
            this.Property(t => t.REGION_ID).HasColumnName("REGION_ID");
            this.Property(t => t.REGION_NAME).HasColumnName("REGION_NAME");
        }
    }
}
