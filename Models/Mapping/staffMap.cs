using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HospitalSystem.Models.Mapping
{
    public class staffMap : EntityTypeConfiguration<staff>
    {
        public staffMap()
        {
            // Primary Key
            this.HasKey(t => t.StaffID);

            // Properties
            this.Property(t => t.StaffName)
                .HasMaxLength(50);

            this.Property(t => t.StaffPassword)
                .HasMaxLength(50);

            this.Property(t => t.Gender)
                .HasMaxLength(5);

            this.Property(t => t.Job)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("staff", "teamwork");
            this.Property(t => t.StaffID).HasColumnName("StaffID");
            this.Property(t => t.StaffName).HasColumnName("StaffName");
            this.Property(t => t.StaffPassword).HasColumnName("StaffPassword");
            this.Property(t => t.Gender).HasColumnName("Gender");
            this.Property(t => t.Birthday).HasColumnName("Birthday");
            this.Property(t => t.Job).HasColumnName("Job");
        }
    }
}
