using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HospitalSystem.Models.Mapping
{
    public class purchase_recordMap : EntityTypeConfiguration<purchase_record>
    {
        public purchase_recordMap()
        {
            // Primary Key
            this.HasKey(t => t.PurchaseRecordID);

            // Properties
            // Table & Column Mappings
            this.ToTable("purchase_record", "teamwork");
            this.Property(t => t.PurchaseRecordID).HasColumnName("PurchaseRecordID");
            this.Property(t => t.MedicineID).HasColumnName("MedicineID");
            this.Property(t => t.StaffID).HasColumnName("StaffID");
            this.Property(t => t.MedicineNumber).HasColumnName("MedicineNumber");
            this.Property(t => t.MedicinePrice).HasColumnName("MedicinePrice");
            this.Property(t => t.PurchaseDate).HasColumnName("PurchaseDate");

            // Relationships
            this.HasOptional(t => t.medicine)
                .WithMany(t => t.purchase_record)
                .HasForeignKey(d => d.MedicineID);
            this.HasOptional(t => t.staff)
                .WithMany(t => t.purchase_record)
                .HasForeignKey(d => d.StaffID);

        }
    }
}
