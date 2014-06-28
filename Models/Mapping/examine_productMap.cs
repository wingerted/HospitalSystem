using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HospitalSystem.Models.Mapping
{
    public class examine_productMap : EntityTypeConfiguration<examine_product>
    {
        public examine_productMap()
        {
            // Primary Key
            this.HasKey(t => t.ProductID);

            // Properties
            this.Property(t => t.ProductName)
                .HasMaxLength(50);

            this.Property(t => t.ProductDescribe)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("examine_product", "teamwork");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.ProductName).HasColumnName("ProductName");
            this.Property(t => t.ProductDescribe).HasColumnName("ProductDescribe");
            this.Property(t => t.ProductPrice).HasColumnName("ProductPrice");
        }
    }
}
