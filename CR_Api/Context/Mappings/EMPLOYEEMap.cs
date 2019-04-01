using Context.Mappings.Comum;
using Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Context.Mappings
{
    internal class EMPLOYEEMap : EntityBaseMap<EMPLOYEE>
    {
        public EMPLOYEEMap()
        {
            // Primary Key
            this.HasKey(t => t.EMPLOYEE_ID);

            // Properties
            this.Property(t => t.EMPLOYEE_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FIRST_NAME)
                .HasMaxLength(20);

            this.Property(t => t.LAST_NAME)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.EMAIL)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.PHONE_NUMBER)
                .HasMaxLength(20);

            this.Property(t => t.JOB_ID)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("EMPLOYEES", Context.DbSchema);
            this.Property(t => t.EMPLOYEE_ID).HasColumnName("EMPLOYEE_ID");
            this.Property(t => t.FIRST_NAME).HasColumnName("FIRST_NAME");
            this.Property(t => t.LAST_NAME).HasColumnName("LAST_NAME");
            this.Property(t => t.EMAIL).HasColumnName("EMAIL");
            this.Property(t => t.PHONE_NUMBER).HasColumnName("PHONE_NUMBER");
            this.Property(t => t.HIRE_DATE).HasColumnName("HIRE_DATE");
            this.Property(t => t.JOB_ID).HasColumnName("JOB_ID");
            this.Property(t => t.SALARY).HasColumnName("SALARY");
            this.Property(t => t.COMMISSION_PCT).HasColumnName("COMMISSION_PCT");
            this.Property(t => t.MANAGER_ID).HasColumnName("MANAGER_ID");
            this.Property(t => t.DEPARTMENT_ID).HasColumnName("DEPARTMENT_ID");

            // Relationships
            this.HasOptional(t => t.DEPARTMENT)
                .WithMany(t => t.EMPLOYEES)
                .HasForeignKey(d => d.DEPARTMENT_ID);
            this.HasRequired(t => t.JOB)
                .WithMany(t => t.EMPLOYEES)
                .HasForeignKey(d => d.JOB_ID);
            this.HasOptional(t => t.EMPLOYEE1)
                .WithMany(t => t.EMPLOYEES1)
                .HasForeignKey(d => d.MANAGER_ID);
        }
    }
}
