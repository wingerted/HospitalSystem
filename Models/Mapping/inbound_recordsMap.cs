using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HospitalSystem.Models.Mapping
{
    public class inbound_recordsMap : EntityTypeConfiguration<inbound_records>
    {
        public inbound_recordsMap()
        {
            // Primary Key
            this.HasKey(t => t.InboundRecordsID);

            // Properties
            // Table & Column Mappings
            this.ToTable("inbound_records", "teamwork");
            this.Property(t => t.InboundRecordsID).HasColumnName("InboundRecordsID");
            this.Property(t => t.MedicineID).HasColumnName("MedicineID");
            this.Property(t => t.StaffID).HasColumnName("StaffID");
            this.Property(t => t.MedicineNumber).HasColumnName("MedicineNumber");
            this.Property(t => t.ManufactureDate).HasColumnName("ManufactureDate");
            this.Property(t => t.InboundDate).HasColumnName("InboundDate");

            // Relationships
            this.HasOptional(t => t.medicine)
                .WithMany(t => t.inbound_records)
                .HasForeignKey(d => d.MedicineID);
            this.HasOptional(t => t.staff)
                .WithMany(t => t.inbound_records)
                .HasForeignKey(d => d.StaffID);

        }
    }
}
