using System;
using Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Context.Mappings.Comum;

namespace Context.Mappings
{
    internal class JOBMap : EntityBaseMap<JOB>
    {
        public JOBMap()
        {
            // Primary Key
            this.HasKey(t => t.JOB_ID);

            // Properties
            this.Property(t => t.JOB_ID)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.JOB_TITLE)
                .IsRequired()
                .HasMaxLength(35);

            // Table & Column Mappings
            this.ToTable("JOBS", DbConfig.DbSchema);
            this.Property(t => t.JOB_ID).HasColumnName("JOB_ID");
            this.Property(t => t.JOB_TITLE).HasColumnName("JOB_TITLE");
            this.Property(t => t.MIN_SALARY).HasColumnName("MIN_SALARY");
            this.Property(t => t.MAX_SALARY).HasColumnName("MAX_SALARY");

//            Ignore(t => t.ValidationResult);
        }
    }
}
