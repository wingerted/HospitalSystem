using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HospitalSystem.Models.Mapping
{
    public class medicine_detailMap : EntityTypeConfiguration<medicine_detail>
    {
        public medicine_detailMap()
        {
            // Primary Key
            this.HasKey(t => t.MedicineDetailID);

            // Properties
            // Table & Column Mappings
            this.ToTable("medicine_detail", "teamwork");
            this.Property(t => t.MedicineDetailID).HasColumnName("MedicineDetailID");
            this.Property(t => t.MedicineID).HasColumnName("MedicineID");
            this.Property(t => t.PrescriptionID).HasColumnName("PrescriptionID");
            this.Property(t => t.MedicineNumber).HasColumnName("MedicineNumber");

            // Relationships
            this.HasOptional(t => t.medicine)
                .WithMany(t => t.medicine_detail)
                .HasForeignKey(d => d.MedicineID);
            this.HasOptional(t => t.prescription)
                .WithMany(t => t.medicine_detail)
                .HasForeignKey(d => d.PrescriptionID);

        }
    }
}
