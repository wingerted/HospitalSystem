using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HospitalSystem.Models.Mapping
{
    public class medicine_inventoryMap : EntityTypeConfiguration<medicine_inventory>
    {
        public medicine_inventoryMap()
        {
            // Primary Key
            this.HasKey(t => t.MedicineInventoryID);

            // Properties
            // Table & Column Mappings
            this.ToTable("medicine_inventory", "teamwork");
            this.Property(t => t.MedicineInventoryID).HasColumnName("MedicineInventoryID");
            this.Property(t => t.MedicineID).HasColumnName("MedicineID");
            this.Property(t => t.ManufactureDate).HasColumnName("ManufactureDate");
            this.Property(t => t.InventoryNumber).HasColumnName("InventoryNumber");

            // Relationships
            this.HasOptional(t => t.medicine)
                .WithMany(t => t.medicine_inventory)
                .HasForeignKey(d => d.MedicineID);

        }
    }
}
