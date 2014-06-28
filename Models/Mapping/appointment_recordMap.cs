using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HospitalSystem.Models.Mapping
{
    public class appointment_recordMap : EntityTypeConfiguration<appointment_record>
    {
        public appointment_recordMap()
        {
            // Primary Key
            this.HasKey(t => t.AppointmentID);

            // Properties
            // Table & Column Mappings
            this.ToTable("appointment_record", "teamwork");
            this.Property(t => t.AppointmentID).HasColumnName("AppointmentID");
            this.Property(t => t.DoctorID).HasColumnName("DoctorID");
            this.Property(t => t.PatientID).HasColumnName("PatientID");
            this.Property(t => t.AppointmentTime).HasColumnName("AppointmentTime");

            // Relationships
            this.HasOptional(t => t.doctor)
                .WithMany(t => t.appointment_record)
                .HasForeignKey(d => d.DoctorID);
            this.HasOptional(t => t.patient)
                .WithMany(t => t.appointment_record)
                .HasForeignKey(d => d.PatientID);

        }
    }
}
