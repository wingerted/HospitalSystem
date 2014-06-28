using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HospitalSystem.Models.Mapping
{
    public class examine_detailMap : EntityTypeConfiguration<examine_detail>
    {
        public examine_detailMap()
        {
            // Primary Key
            this.HasKey(t => t.ExamineDetailID);

            // Properties
            this.Property(t => t.ExamineResult)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("examine_detail", "teamwork");
            this.Property(t => t.ExamineDetailID).HasColumnName("ExamineDetailID");
            this.Property(t => t.ExamineListID).HasColumnName("ExamineListID");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.ExamineDoctorID).HasColumnName("ExamineDoctorID");
            this.Property(t => t.ExamineResult).HasColumnName("ExamineResult");
            this.Property(t => t.ExamineTime).HasColumnName("ExamineTime");

            // Relationships
            this.HasOptional(t => t.doctor)
                .WithMany(t => t.examine_detail)
                .HasForeignKey(d => d.ExamineDoctorID);
            this.HasOptional(t => t.examine_list)
                .WithMany(t => t.examine_detail)
                .HasForeignKey(d => d.ExamineListID);
            this.HasOptional(t => t.examine_product)
                .WithMany(t => t.examine_detail)
                .HasForeignKey(d => d.ProductID);

        }
    }
}
