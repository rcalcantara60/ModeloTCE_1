using Context.Mappings.Comum;
using Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Context.Mappings
{
    internal class EMP_DETAILS_VIEWMap : EntityBaseMap<EMP_DETAILS_VIEW>
    {
        public EMP_DETAILS_VIEWMap()
        {
            // Primary Key
            this.HasKey(t => new { t.EMPLOYEE_ID, t.JOB_ID, t.LAST_NAME, t.DEPARTMENT_NAME, t.JOB_TITLE, t.CITY });

            // Properties
            this.Property(t => t.EMPLOYEE_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.JOB_ID)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.COUNTRY_ID)
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.FIRST_NAME)
                .HasMaxLength(20);

            this.Property(t => t.LAST_NAME)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.DEPARTMENT_NAME)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.JOB_TITLE)
                .IsRequired()
                .HasMaxLength(35);

            this.Property(t => t.CITY)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.STATE_PROVINCE)
                .HasMaxLength(25);

            this.Property(t => t.COUNTRY_NAME)
                .HasMaxLength(40);

            this.Property(t => t.REGION_NAME)
                .HasMaxLength(25);

            // Table & Column Mappings
            this.ToTable("EMP_DETAILS_VIEW", DbConfig.DbSchema);
            this.Property(t => t.EMPLOYEE_ID).HasColumnName("EMPLOYEE_ID");
            this.Property(t => t.JOB_ID).HasColumnName("JOB_ID");
            this.Property(t => t.MANAGER_ID).HasColumnName("MANAGER_ID");
            this.Property(t => t.DEPARTMENT_ID).HasColumnName("DEPARTMENT_ID");
            this.Property(t => t.LOCATION_ID).HasColumnName("LOCATION_ID");
            this.Property(t => t.COUNTRY_ID).HasColumnName("COUNTRY_ID");
            this.Property(t => t.FIRST_NAME).HasColumnName("FIRST_NAME");
            this.Property(t => t.LAST_NAME).HasColumnName("LAST_NAME");
            this.Property(t => t.SALARY).HasColumnName("SALARY");
            this.Property(t => t.COMMISSION_PCT).HasColumnName("COMMISSION_PCT");
            this.Property(t => t.DEPARTMENT_NAME).HasColumnName("DEPARTMENT_NAME");
            this.Property(t => t.JOB_TITLE).HasColumnName("JOB_TITLE");
            this.Property(t => t.CITY).HasColumnName("CITY");
            this.Property(t => t.STATE_PROVINCE).HasColumnName("STATE_PROVINCE");
            this.Property(t => t.COUNTRY_NAME).HasColumnName("COUNTRY_NAME");
            this.Property(t => t.REGION_NAME).HasColumnName("REGION_NAME");
        }
    }
}
