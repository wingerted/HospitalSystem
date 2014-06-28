using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HospitalSystem.Models.Mapping
{
    public class register_listMap : EntityTypeConfiguration<register_list>
    {
        public register_listMap()
        {
            // Primary Key
            this.HasKey(t => t.RegisterID);

            // Properties
            // Table & Column Mappings
            this.ToTable("register_list", "teamwork");
            this.Property(t => t.RegisterID).HasColumnName("RegisterID");
            this.Property(t => t.PatientID).HasColumnName("PatientID");
            this.Property(t => t.StaffID).HasColumnName("StaffID");
            this.Property(t => t.DepartmentID).HasColumnName("DepartmentID");
            this.Property(t => t.DoctorID).HasColumnName("DoctorID");
            this.Property(t => t.RegisterTime).HasColumnName("RegisterTime");

            // Relationships
            this.HasOptional(t => t.department)
                .WithMany(t => t.register_list)
                .HasForeignKey(d => d.DepartmentID);
            this.HasOptional(t => t.doctor)
                .WithMany(t => t.register_list)
                .HasForeignKey(d => d.DoctorID);
            this.HasOptional(t => t.patient)
                .WithMany(t => t.register_list)
                .HasForeignKey(d => d.PatientID);
            this.HasOptional(t => t.staff)
                .WithMany(t => t.register_list)
                .HasForeignKey(d => d.StaffID);

        }
    }
}
