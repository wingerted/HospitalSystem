using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HospitalSystem.Models.Mapping
{
    public class adjust_price_recordMap : EntityTypeConfiguration<adjust_price_record>
    {
        public adjust_price_recordMap()
        {
            // Primary Key
            this.HasKey(t => t.AdjustPriceRecordID);

            // Properties
            // Table & Column Mappings
            this.ToTable("adjust_price_record", "teamwork");
            this.Property(t => t.AdjustPriceRecordID).HasColumnName("AdjustPriceRecordID");
            this.Property(t => t.MedicineID).HasColumnName("MedicineID");
            this.Property(t => t.DoctorID).HasColumnName("DoctorID");
            this.Property(t => t.MedicineOldPrice).HasColumnName("MedicineOldPrice");
            this.Property(t => t.MedicineCurrentPrice).HasColumnName("MedicineCurrentPrice");
            this.Property(t => t.AdjustPriceDate).HasColumnName("AdjustPriceDate");

            // Relationships
            this.HasOptional(t => t.doctor)
                .WithMany(t => t.adjust_price_record)
                .HasForeignKey(d => d.DoctorID);
            this.HasOptional(t => t.medicine)
                .WithMany(t => t.adjust_price_record)
                .HasForeignKey(d => d.MedicineID);

        }
    }
}
