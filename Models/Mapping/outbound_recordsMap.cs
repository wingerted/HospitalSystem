using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HospitalSystem.Models.Mapping
{
    public class outbound_recordsMap : EntityTypeConfiguration<outbound_records>
    {
        public outbound_recordsMap()
        {
            // Primary Key
            this.HasKey(t => t.OutboundRecordsID);

            // Properties
            // Table & Column Mappings
            this.ToTable("outbound_records", "teamwork");
            this.Property(t => t.OutboundRecordsID).HasColumnName("OutboundRecordsID");
            this.Property(t => t.MedicineID).HasColumnName("MedicineID");
            this.Property(t => t.StaffID).HasColumnName("StaffID");
            this.Property(t => t.MedicineNumber).HasColumnName("MedicineNumber");
            this.Property(t => t.OutboundDate).HasColumnName("OutboundDate");

            // Relationships
            this.HasOptional(t => t.medicine)
                .WithMany(t => t.outbound_records)
                .HasForeignKey(d => d.MedicineID);
            this.HasOptional(t => t.staff)
                .WithMany(t => t.outbound_records)
                .HasForeignKey(d => d.StaffID);

        }
    }
}
