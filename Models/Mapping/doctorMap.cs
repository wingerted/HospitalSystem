using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HospitalSystem.Models.Mapping
{
    public class doctorMap : EntityTypeConfiguration<doctor>
    {
        public doctorMap()
        {
            // Primary Key
            this.HasKey(t => t.DoctorID);

            // Properties
            this.Property(t => t.DoctorPassword)
                .HasMaxLength(50);

            this.Property(t => t.DoctorName)
                .HasMaxLength(50);

            this.Property(t => t.DoctorGender)
                .HasMaxLength(5);

            this.Property(t => t.Title)
                .HasMaxLength(50);

            this.Property(t => t.Job)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("doctor", "teamwork");
            this.Property(t => t.DoctorID).HasColumnName("DoctorID");
            this.Property(t => t.DepartmentID).HasColumnName("DepartmentID");
            this.Property(t => t.DoctorPassword).HasColumnName("DoctorPassword");
            this.Property(t => t.DoctorName).HasColumnName("DoctorName");
            this.Property(t => t.DoctorGender).HasColumnName("DoctorGender");
            this.Property(t => t.Expert).HasColumnName("Expert");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Job).HasColumnName("Job");

            // Relationships
            this.HasOptional(t => t.department)
                .WithMany(t => t.doctors)
                .HasForeignKey(d => d.DepartmentID);

        }
    }
}
