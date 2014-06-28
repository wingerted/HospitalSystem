using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HospitalSystem.Models.Mapping
{
    public class allocate_recordMap : EntityTypeConfiguration<allocate_record>
    {
        public allocate_recordMap()
        {
            // Primary Key
            this.HasKey(t => t.AllocateRecordID);

            // Properties
            this.Property(t => t.AllocateType)
                .HasMaxLength(5);

            this.Property(t => t.AllocateReason)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("allocate_record", "teamwork");
            this.Property(t => t.AllocateRecordID).HasColumnName("AllocateRecordID");
            this.Property(t => t.MedicineID).HasColumnName("MedicineID");
            this.Property(t => t.DoctorID).HasColumnName("DoctorID");
            this.Property(t => t.AllocateType).HasColumnName("AllocateType");
            this.Property(t => t.AllocateDate).HasColumnName("AllocateDate");
            this.Property(t => t.AllocateReason).HasColumnName("AllocateReason");
            this.Property(t => t.AllocateNumber).HasColumnName("AllocateNumber");

            // Relationships
            this.HasOptional(t => t.doctor)
                .WithMany(t => t.allocate_record)
                .HasForeignKey(d => d.DoctorID);
            this.HasOptional(t => t.medicine)
                .WithMany(t => t.allocate_record)
                .HasForeignKey(d => d.MedicineID);

        }
    }
}
