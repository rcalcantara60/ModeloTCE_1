using Context.Mappings.Comum;
using Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Context.Mappings
{
    internal class LOCATIONMap : EntityBaseMap<LOCATION>
    {
        public LOCATIONMap()
        {
            // Primary Key
            this.HasKey(t => t.LOCATION_ID);

            // Properties
            this.Property(t => t.LOCATION_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.STREET_ADDRESS)
                .HasMaxLength(40);

            this.Property(t => t.POSTAL_CODE)
                .HasMaxLength(12);

            this.Property(t => t.CITY)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.STATE_PROVINCE)
                .HasMaxLength(25);

            this.Property(t => t.COUNTRY_ID)
                .IsFixedLength()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("LOCATIONS", DbConfig.DbSchema);
            this.Property(t => t.LOCATION_ID).HasColumnName("LOCATION_ID");
            this.Property(t => t.STREET_ADDRESS).HasColumnName("STREET_ADDRESS");
            this.Property(t => t.POSTAL_CODE).HasColumnName("POSTAL_CODE");
            this.Property(t => t.CITY).HasColumnName("CITY");
            this.Property(t => t.STATE_PROVINCE).HasColumnName("STATE_PROVINCE");
            this.Property(t => t.COUNTRY_ID).HasColumnName("COUNTRY_ID");

            // Relationships
            this.HasOptional(t => t.COUNTRy)
                .WithMany(t => t.LOCATIONS)
                .HasForeignKey(d => d.COUNTRY_ID);

        }
    }
}
