using Context.Mappings.Comum;
using Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Context.Mappings
{
    internal class JOB_HISTORYMap : EntityBaseMap<JOB_HISTORY>
    {
        public JOB_HISTORYMap()
        {
            // Primary Key
            this.HasKey(t => new { t.EMPLOYEE_ID, t.START_DATE });

            // Properties
            this.Property(t => t.EMPLOYEE_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.JOB_ID)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("JOB_HISTORY", Context.DbSchema);
            this.Property(t => t.EMPLOYEE_ID).HasColumnName("EMPLOYEE_ID");
            this.Property(t => t.START_DATE).HasColumnName("START_DATE");
            this.Property(t => t.END_DATE).HasColumnName("END_DATE");
            this.Property(t => t.JOB_ID).HasColumnName("JOB_ID");
            this.Property(t => t.DEPARTMENT_ID).HasColumnName("DEPARTMENT_ID");

            // Relationships
            this.HasOptional(t => t.DEPARTMENT)
                .WithMany(t => t.JOB_HISTORY)
                .HasForeignKey(d => d.DEPARTMENT_ID);
            this.HasRequired(t => t.EMPLOYEE)
                .WithMany(t => t.JOB_HISTORY)
                .HasForeignKey(d => d.EMPLOYEE_ID);
            this.HasRequired(t => t.JOB)
                .WithMany(t => t.JOB_HISTORY)
                .HasForeignKey(d => d.JOB_ID);

        }
    }
}
