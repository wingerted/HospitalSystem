using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HospitalSystem.Models.Mapping
{
    public class medical_recordMap : EntityTypeConfiguration<medical_record>
    {
        public medical_recordMap()
        {
            // Primary Key
            this.HasKey(t => t.MedicalRecordID);

            // Properties
            this.Property(t => t.DiseaseDescribe)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("medical_record", "teamwork");
            this.Property(t => t.MedicalRecordID).HasColumnName("MedicalRecordID");
            this.Property(t => t.PatientID).HasColumnName("PatientID");
            this.Property(t => t.DoctorID).HasColumnName("DoctorID");
            this.Property(t => t.DiseaseDescribe).HasColumnName("DiseaseDescribe");
            this.Property(t => t.TreatTime).HasColumnName("TreatTime");

            // Relationships
            this.HasOptional(t => t.doctor)
                .WithMany(t => t.medical_record)
                .HasForeignKey(d => d.DoctorID);
            this.HasOptional(t => t.patient)
                .WithMany(t => t.medical_record)
                .HasForeignKey(d => d.PatientID);

        }
    }
}
