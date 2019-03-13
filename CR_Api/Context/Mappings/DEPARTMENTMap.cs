using Context.Mappings.Comum;
using Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;


namespace Context.Mappings
{
    internal class DEPARTMENTMap : EntityBaseMap<DEPARTMENT>
    {
        public DEPARTMENTMap()
        {
            // Primary Key
            this.HasKey(t => t.DEPARTMENT_ID);

            // Properties
            this.Property(t => t.DEPARTMENT_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DEPARTMENT_NAME)
                .IsRequired()
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("DEPARTMENTS", DbConfig.DbSchema);
            this.Property(t => t.DEPARTMENT_ID).HasColumnName("DEPARTMENT_ID");
            this.Property(t => t.DEPARTMENT_NAME).HasColumnName("DEPARTMENT_NAME");
            this.Property(t => t.MANAGER_ID).HasColumnName("MANAGER_ID");
            this.Property(t => t.LOCATION_ID).HasColumnName("LOCATION_ID");

            // Relationships
            this.HasOptional(t => t.LOCATION)
                .WithMany(t => t.DEPARTMENTS)
                .HasForeignKey(d => d.LOCATION_ID);
            this.HasOptional(t => t.EMPLOYEE)
                .WithMany(t => t.DEPARTMENTS)
                .HasForeignKey(d => d.MANAGER_ID);

        }
    }
}
