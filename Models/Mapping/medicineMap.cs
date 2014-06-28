using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HospitalSystem.Models.Mapping
{
    public class medicineMap : EntityTypeConfiguration<medicine>
    {
        public medicineMap()
        {
            // Primary Key
            this.HasKey(t => t.MedicineID);

            // Properties
            this.Property(t => t.MedicineID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MedicineName)
                .HasMaxLength(50);

            this.Property(t => t.Manufacturer)
                .HasMaxLength(50);

            this.Property(t => t.Supplier)
                .HasMaxLength(50);

            this.Property(t => t.PackageCompany)
                .HasMaxLength(50);

            this.Property(t => t.DispensingCompany)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("medicine", "teamwork");
            this.Property(t => t.MedicineID).HasColumnName("MedicineID");
            this.Property(t => t.MedicineName).HasColumnName("MedicineName");
            this.Property(t => t.MedicinePrice).HasColumnName("MedicinePrice");
            this.Property(t => t.Manufacturer).HasColumnName("Manufacturer");
            this.Property(t => t.Supplier).HasColumnName("Supplier");
            this.Property(t => t.PackageCompany).HasColumnName("PackageCompany");
            this.Property(t => t.DispensingCompany).HasColumnName("DispensingCompany");
            this.Property(t => t.Poison).HasColumnName("Poison");
            this.Property(t => t.Psychotic).HasColumnName("Psychotic");
            this.Property(t => t.Precious).HasColumnName("Precious");
            this.Property(t => t.MakeSelf).HasColumnName("MakeSelf");
            this.Property(t => t.Entrance).HasColumnName("Entrance");
            this.Property(t => t.PaySelf).HasColumnName("PaySelf");
            this.Property(t => t.ValidityDate).HasColumnName("ValidityDate");
            this.Property(t => t.MaxNumber).HasColumnName("MaxNumber");
        }
    }
}
