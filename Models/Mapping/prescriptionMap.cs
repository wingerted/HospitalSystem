using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HospitalSystem.Models.Mapping
{
    public class prescriptionMap : EntityTypeConfiguration<prescription>
    {
        public prescriptionMap()
        {
            // Primary Key
            this.HasKey(t => t.PrescriptionID);

            // Properties
            // Table & Column Mappings
            this.ToTable("prescription", "teamwork");
            this.Property(t => t.PrescriptionID).HasColumnName("PrescriptionID");
            this.Property(t => t.MedicalRecordID).HasColumnName("MedicalRecordID");

            // Relationships
            this.HasOptional(t => t.medical_record)
                .WithMany(t => t.prescriptions)
                .HasForeignKey(d => d.MedicalRecordID);

        }
    }
}
