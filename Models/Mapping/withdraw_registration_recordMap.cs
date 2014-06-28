using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HospitalSystem.Models.Mapping
{
    public class withdraw_registration_recordMap : EntityTypeConfiguration<withdraw_registration_record>
    {
        public withdraw_registration_recordMap()
        {
            // Primary Key
            this.HasKey(t => t.WithdrawRegistrationRecordID);

            // Properties
            // Table & Column Mappings
            this.ToTable("withdraw_registration_record", "teamwork");
            this.Property(t => t.WithdrawRegistrationRecordID).HasColumnName("WithdrawRegistrationRecordID");
            this.Property(t => t.PatientID).HasColumnName("PatientID");
            this.Property(t => t.DepartmentID).HasColumnName("DepartmentID");
            this.Property(t => t.StaffID).HasColumnName("StaffID");
            this.Property(t => t.DoctorID).HasColumnName("DoctorID");
            this.Property(t => t.RegisterTime).HasColumnName("RegisterTime");

            // Relationships
            this.HasOptional(t => t.department)
                .WithMany(t => t.withdraw_registration_record)
                .HasForeignKey(d => d.DepartmentID);
            this.HasOptional(t => t.patient)
                .WithMany(t => t.withdraw_registration_record)
                .HasForeignKey(d => d.PatientID);
            this.HasOptional(t => t.staff)
                .WithMany(t => t.withdraw_registration_record)
                .HasForeignKey(d => d.StaffID);

        }
    }
}
